using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace StrangeMailStampSystem
{
    class SheetSync
    {
        string gPersonalAccessToken = "123";

        //string gPersonalAccessToken = "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";

        List<string> gResults;
        string gErrors;

        private Dictionary<string, int> gPlayersWithRolls;
        private Dictionary<string, int> gPlayersWithRollsBonus;

        private List<PlayerData> gFinalPlayerDataList;

        int gFinalRoll;
        int gStampDeduction;
        double gRemainingStamps;
        double gStampCost;


        public SheetSync(StrangeMailStampSystem gui, Dictionary<string, int> playersWithRolls, Dictionary<string, int> playersWithRollsBonus, out List<PlayerData>  finalPlayerDataList)
        {
            gResults = new List<string>();
            gFinalPlayerDataList = new List<PlayerData>();
            
            gErrors = "";
            gFinalRoll = 0;
            gStampDeduction = 0;
            gRemainingStamps = 0;
            gStampCost = 0;

            gPlayersWithRolls = playersWithRolls;
            gPlayersWithRollsBonus = playersWithRollsBonus;

            //string link = "https://docs.google.com/spreadsheets/d/1UkUjNwO3DuflFGfwcQg7EQR8srM1y0PvWGjT6FARkC4/edit#gid=0";
            //string link = "https://docs.google.com/spreadsheets/d/1UkUjNwO3DuflFGfwcQg7EQR8srM1y0PvWGjT6FARkC4/edit#gid=1968822032";
            //string link = "https://sheets.googleapis.com/v4/spreadsheets/d/1UkUjNwO3DuflFGfwcQg7EQR8srM1y0PvWGjT6FARkC4/42/StampCount!A35:D35:append?valueInputOption=USER_ENTERED";
            //string link = "https://sheets.googleapis.com/v4/spreadsheets/1UkUjNwO3DuflFGfwcQg7EQR8srM1y0PvWGjT6FARkC4/values/A35%3AD35:append?valueInputOption=RAW";

            // Works in browser, just not with cURL command.
            //string link = "https://sheets.googleapis.com/v4/spreadsheets/1UkUjNwO3DuflFGfwcQg7EQR8srM1y0PvWGjT6FARkC4/values/A5:D5?key=AIzaSyCXoHNSHKu9P4WAnNzr_YFIVzlWARmosvw";


            //ExecuteRestCall(link, "GET", false, false);

            //ExecuteRestCall(link, "GET", false, false);

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"G:\My Drive\StrangeMailStampSystem.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //xlApp.Visible = true;

            // For each player in the list with bonus rolls
            foreach (var player in gPlayersWithRollsBonus)
            {
                PlayerData pd = new PlayerData();

                pd.Name = player.Key;
                pd.Rolls = player.Value;

                // Update each players data
                //UpdatePlayerData(pd);

                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        //new line
                        if (j == 1)
                            Console.Write("\r\n");

                        //write the value to the console
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");

                            if (xlRange.Cells[i, j].Value2.Equals(pd.Name))
                            {
                                // If we find the player, update their stamp count and output final roll
                                string previousStampValue = xlRange.Cells[i, j+1].Value2.ToString();
                                int previousStampValueInt = Int32.Parse(previousStampValue);



                                gFinalRoll = previousStampValueInt + pd.Rolls;

                                gStampDeduction = previousStampValueInt / 2;

                                gStampCost = Round(gStampDeduction, 5);

                                gRemainingStamps = previousStampValueInt - gStampCost;


                                
                                pd.OriginalStampCount = previousStampValueInt;
                                pd.FinalRoll = gFinalRoll;
                                pd.StampCost = gStampCost;
                                pd.StampsRemaining = gRemainingStamps;

                                gFinalPlayerDataList.Add(pd);


                                xlRange.Cells[i, j + 1].Value = gRemainingStamps;
                                Console.WriteLine("Found name: " + pd.Name);

                            }
                        }

                    }
                }
            }


            // Now lets add normal rollers to the final list
            foreach (var player in gPlayersWithRolls)
            {
                PlayerData pd = new PlayerData();

                pd.Name = player.Key;
                pd.Rolls = player.Value;
                pd.OriginalStampCount = 0;
                pd.FinalRoll = player.Value;
                pd.StampCost = 0;
                pd.StampsRemaining = 0;

                gFinalPlayerDataList.Add(pd);

            }

            xlWorkbook.Save();

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);



            finalPlayerDataList = gFinalPlayerDataList;

        }

        double Round(double num, int multipleOf)
        {
            return Math.Ceiling((num + multipleOf / 2) / multipleOf) * multipleOf;
        }

        private void UpdatePlayerData(PlayerData pd)
        {

            /*
             * 1. Find player in sheet
             * 2. Do the calculations on their roll
             * 3. Update the stampcount
             * 4. Send a list of the modified rolls back out
             * 
             * */

            //Create COM Objects. Create a COM object for everything that is referenced
            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Bobby\Documents\StrangeMailStampSystem.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
            //Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;

            //int rowCount = xlRange.Rows.Count;
            //int colCount = xlRange.Columns.Count;

            //xlApp.Visible = true;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            /*
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");

                        if(xlRange.Cells[i,j].Value2.Equals(pd.Name))
                        {
                            xlRange.Cells[i + 1, j + 1].Value = pd.Rolls.ToString();
                            Console.WriteLine("Found name: " + pd.Name);

                        }
                    }
                        
                }
            }
            */
            //cleanup
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            //Marshal.ReleaseComObject(xlRange);
            //Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            //xlWorkbook.Close();
            //Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            //xlApp.Quit();
            //Marshal.ReleaseComObject(xlApp);



        }




        private dynamic ExecuteRestCall(string link, string type, bool deserialize = false, bool display = true)
        {
            dynamic ret = null;
            string curl;

            if(type.Equals("POST"))
            {
                //curl = "-H \"Authorization: Bearer " + gPersonalAccessToken + "\" -H \"Content-Type: application/json\" -k \"" + link + "\"";

                curl = "-H \"Authorization: Bearer " + gPersonalAccessToken + "\" -H \"Content-Type: application/json\" -k \"" + link + "\"";
            }
            else if(type.Equals("PUT"))
            {
                curl = "-X PUT -H \"Authorization: Bearer " + gPersonalAccessToken + "\" -H \"Content-Type: application/json\" -k \"" + link + "\"";
            }
            else
            {
                curl = "-X GET -H \"Authorization: Bearer " + gPersonalAccessToken + "\" -H \"Content-Type: application/json\" -k \"" + link + "\"";
            }

            ExecuteCurlCommand(curl, out gResults, out gErrors, display);

            if(gResults.Count > 0)
            {
                while(gResults[0].Contains("<title>Oops - an error has occured</title>"))
                {
                    // Update logs
                    ExecuteCurlCommand(curl, out gResults, out gErrors, display);
                }
            }

            if(type.Equals("GET") || deserialize)
            {
                ret = JsonConvert.DeserializeObject(gResults[0]);
            }

            return ret;

        }


        private void ExecuteCurlCommand(string curl, out List<string> gResults, out string gErrors, bool display)
        {
            ExecuteCommand("curl", curl, out gResults, out gErrors, display);

            while (gResults.Find(x => x.Contains("Unauthorized (401)")) != null || gErrors.Contains("curl: (56) Send failure: Connection was reset"))
            {
                Thread.Sleep(5000);
                ExecuteCommand("curl", curl, out gResults, out gErrors, display);
            }
        }

        private void ExecuteCommand(string exe, string arguments, out List<string> result, out string errors, bool display = true)
        {
            errors = "";
            result = new List<string>();

            try
            {
                if(!String.IsNullOrEmpty(gPersonalAccessToken))
                {
                    string toDisplay = arguments.Replace(gPersonalAccessToken, "token");
                    // Update logs (exe + " " + toDisplay)
                }
                else
                {
                    // Update logs (exe + " " + arguments)
                }

                List<string> tmpResults = new List<string>();
                string tempErrors = "";
                Process process = new Process();

                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = exe;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;

                process.StartInfo.Arguments = arguments;

                process.OutputDataReceived += (o, e) =>
                {
                    if (e.Data != null)
                    {
                        tmpResults.Add(e.Data);
                        if (display)
                        {
                            // Update logs e.Data
                        }
                    }
                };

                process.ErrorDataReceived += (o, e) =>
                {
                    if (e.Data != null)
                    {
                        tempErrors += e.Data;
                        if (!e.Data.Contains("--:--:--") && !e.Data.Contains("% Received") && !e.Data.Contains("Upload   Total") && String.IsNullOrEmpty(e.Data))
                        {
                            // Update logs e.Data
                        }
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
                process.Close();
                result = tmpResults;
                errors = tempErrors;

            }
            catch (Exception e)
            {
                //Log exception (e.Message + e.StackTrace + exe + " " + arguments
            }
        }
    }

}
