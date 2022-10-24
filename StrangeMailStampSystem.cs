using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace StrangeMailStampSystem
{

    public enum Status
    {
        NoSelected,
        Roll,
        StampRoll
    };

    public partial class StrangeMailStampSystem : Form
    {
        private List<string> gGuildMemberList;
        private List<string> gGuildMemberListBonus;

        private List<string> gGuildMemberListChecked;
        private List<string> gGuildMemberListBonusChecked;

        private Dictionary<string, int> gPlayersWithRolls;
        private Dictionary<string, int> gPlayersWithRollsBonus;

        private List<PlayerData> gFinalPlayerDataList;

        private PlayerData gWinningPlayerData;

        private Point gStartLocation;

        private bool gDragging;

        private int[] gStartPoint;

        private string gLogFile;

        private string gItemName;

        private string gRaidName;

        private string gRaidType;

        private bool gTieFound;

        private bool gTieFoundBetweenTwoNormal;

        private bool gTieFoundBetweenTwoStamps;

        private bool gTieFoundBetweenNormalAndStamps;




        public StrangeMailStampSystem()
        {
            InitializeComponent();

            gStartPoint = new int[2];
            gLogFile = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Strange_Mail_Stamp_System_Logs.txt";
            gGuildMemberList = new List<string>();
            gGuildMemberListBonus = new List<string>();

            gGuildMemberListChecked = new List<string>();
            gGuildMemberListBonusChecked = new List<string>();

            gPlayersWithRolls = new Dictionary<string, int>();
            gPlayersWithRollsBonus = new Dictionary<string, int>();

            gFinalPlayerDataList = new List<PlayerData>();

            gWinningPlayerData = new PlayerData();

            gItemName = "";
            gRaidName = "";
            gRaidType = "";
            gTieFound = false;

            gTieFoundBetweenTwoNormal = false;
            gTieFoundBetweenTwoStamps = false;
            gTieFoundBetweenNormalAndStamps = false;



        }

        public void CheckIfReady()
        {
            if ((m_Checkbox10Man.Checked == true || m_CheckBox25Man.Checked == true) && (m_CheckBoxNaxx.Checked == true || m_CheckBoxEoE.Checked == true || m_CheckBoxOS.Checked == true) && !String.IsNullOrEmpty(gRaidName) && !String.IsNullOrEmpty(gItemName))
            {
                m_ButtonEnterRolls.Enabled = true;
            }
            else
            {
                m_ButtonEnterRolls.Enabled = false;
            }
        }

        private void IntializeList()
        {
            string userName = Environment.GetEnvironmentVariable("USERNAME");

            string fileName = "C:\\Users\\" + userName + "\\Documents\\GuildMembers.txt";
            gGuildMemberList = File.ReadAllLines(fileName).ToList();
            gGuildMemberListBonus = File.ReadAllLines(fileName).ToList();

        }

        public void CreateLogFile()
        {
            if (File.Exists(gLogFile))
            {
                File.Delete(gLogFile);
            }

            File.Create(gLogFile).Dispose();
        }

        public void UpdateLogs(string message)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { UpdateLogs(message); });
            }
            else
            {
                File.AppendAllText(gLogFile, DateTime.Now + ": " + message + Environment.NewLine);

                m_RichTextBoxResults.Text += DateTime.Now + ":" + message + Environment.NewLine;
            }
        }

        private void m_PanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (gDragging)
            {
                Point p = PointToScreen(new Point(m_PanelTitleBar.Location.X + e.Location.X, m_PanelTitleBar.Location.Y + e.Location.Y));

                Location = new Point(gStartPoint[0] + p.X - gStartLocation.X, gStartPoint[1] + p.Y - gStartLocation.Y);
            }
        }

        private void m_PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                float ratio = (float)(e.Location.X) / (float)(m_PanelTitleBar.Width);
                this.WindowState = FormWindowState.Normal;
                Point p = PointToScreen(new Point(m_PanelTitleBar.Location.X + e.Location.X,
                                                    m_PanelTitleBar.Location.Y + e.Location.Y));

                gStartLocation = p;
                gStartPoint[0] = Location.X;
                gStartPoint[1] = Location.Y;

            }
            else
            {
                gStartLocation = PointToScreen(new Point(m_PanelTitleBar.Location.X + e.Location.X,
                                                            m_PanelTitleBar.Location.Y + e.Location.Y));

                gStartPoint[0] = Location.X;
                gStartPoint[1] = Location.Y;
            }
            gDragging = true;
        }

        private void m_PanelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            gDragging = false;

            Point p = PointToScreen(e.Location);
            if (p.Y < 2)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private Color m_checkedListBoxGuildMembers_GetForeColor(CustomCheckedListBox listBox, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                FuncInfo fi = (FuncInfo)m_checkedListBoxGuildMembers.Items[e.Index];
                return fi.ForeColor;
            }
            else
            {
                return m_checkedListBoxGuildMembers.ForeColor;
            }
        }

        private void m_checkedListBoxGuildMembers_ItemCheck(object sender, ItemCheckedEventArgs e)
        {
            //FuncInfo fi = (FuncInfo)m_checkedListBoxGuildMembers.Items[e.Index];

        }

        private void m_TextBoxItemName_TextChanged(object sender, EventArgs e)
        {
            gItemName = m_TextBoxItemName.Text;

            CheckIfReady();
        }

        private void m_ButtonRoll_Click(object sender, EventArgs e)
        {
            //new SheetSync(this);
        }

        private void m_Checkbox10Man_CheckedChanged(object sender, EventArgs e)
        {
            gRaidType = "";

            m_CheckBox25Man.Checked = false;

            gRaidType = "10 Man";

            CheckIfReady();
        }

        private void m_CheckBox25Man_CheckedChanged(object sender, EventArgs e)
        {
            gRaidType = "";

            m_Checkbox10Man.Checked = false;

            gRaidType = "25 Man";

            CheckIfReady();
        }

        private void m_ButtonInitList_Click(object sender, EventArgs e)
        {
            IntializeList();
            UpdateLogs("List Initialized");
            m_checkedListBoxGuildMembers.Items.AddRange(gGuildMemberList.ToArray());
            m_checkedListBoxGuildMembersBonus.Items.AddRange(gGuildMemberList.ToArray());

            CheckIfReady();
        }

        private void CreateCheckedLists()
        {


            for (int i = 0; i < m_checkedListBoxGuildMembers.CheckedItems.Count; i++)
            {
                gGuildMemberListChecked.Add(m_checkedListBoxGuildMembers.CheckedItems[i].ToString());
            }

            for (int i = 0; i < m_checkedListBoxGuildMembersBonus.CheckedItems.Count; i++)
            {
                gGuildMemberListBonusChecked.Add(m_checkedListBoxGuildMembersBonus.CheckedItems[i].ToString());
            }

        }

        private void m_ButtonGatherRollData_Click(object sender, EventArgs e)
        {
            CreateCheckedLists();

            new RollChecker(this, gGuildMemberListChecked, gGuildMemberListBonusChecked);
        }

        async private void m_ButtonEnterRolls_Click(object sender, EventArgs e)
        {

            // Grab rolls from game for normal roll members and store them in normal roll dictionary
            for (int i = 0; i < m_checkedListBoxGuildMembers.CheckedItems.Count; i++)
            {
                string name = m_checkedListBoxGuildMembers.CheckedItems[i].ToString();
                string roll = Interaction.InputBox("Enter roll for " + m_checkedListBoxGuildMembers.CheckedItems[i].ToString(), "Enter The Roll", "", 400, 400);

                int rollValue;
                rollValue = Int32.Parse(roll);

                gPlayersWithRolls.Add(m_checkedListBoxGuildMembers.CheckedItems[i].ToString(), rollValue);


            }

            // Grab rolls from game for stamp roll members and store them in stamp roll dictionary
            for (int i = 0; i < m_checkedListBoxGuildMembersBonus.CheckedItems.Count; i++)
            {
                string name = m_checkedListBoxGuildMembersBonus.CheckedItems[i].ToString();
                string roll = Interaction.InputBox("Enter roll for " + m_checkedListBoxGuildMembersBonus.CheckedItems[i].ToString() + ". Stamps will be applied!", "Enter The Roll", "", 400, 400);

                int rollValue;
                rollValue = Int32.Parse(roll);

                gPlayersWithRollsBonus.Add(m_checkedListBoxGuildMembersBonus.CheckedItems[i].ToString(), rollValue);
            }

            foreach (var player in gPlayersWithRolls)
            {
                foreach (var bonusPlayer in gPlayersWithRollsBonus)
                {
                    if (player.Key.Equals(bonusPlayer.Key))
                    {
                        MessageBox.Show("The same player cant be selected for both categories (Stamps and No Stamps", "Same Player Used Twice");
                        ClearAllFields();
                        return;
                    }
                }
            }

            Task task1 = Task.Factory.StartNew(() => RunAll());
        }

        public void RunAll()
        {
            // List of players with bonus rolls and changes are complete after this.
            new SheetSync(this, gPlayersWithRolls, gPlayersWithRollsBonus, out gFinalPlayerDataList);

            this.UpdateLogs("Final list of bonus rollers compiled");


            // Now lets caluculate winner
            CalculateWinner();

            WriteToLootHistory();
        }

        public void CalculateWinner()
        {

            foreach (PlayerData player in gFinalPlayerDataList)
            {
                string message = "N/A";

                if (player.OriginalStampCount == 0 || player.StampCost == 0 || player.StampsRemaining == 0)
                {
                    this.UpdateLogs(player.Name + " rolled " + player.Rolls + ". Used " + message + " stamps and has final roll of " + player.FinalRoll);

                }
                else
                {
                    this.UpdateLogs(player.Name + " rolled " + player.Rolls + ". Used " + player.OriginalStampCount + " stamps and has final roll of " + player.FinalRoll);

                }

            }

            // Now lets check for any ties
            double temp = 0;
            double potentialWinner = gFinalPlayerDataList.Max(player => player.FinalRoll);

            // Grab just the roll values, add them to a list and sort them for comparison.
            List<double> justRollValues = new List<double>();

            foreach (PlayerData player in gFinalPlayerDataList)
            {
                justRollValues.Add(player.FinalRoll);
            }

            // Sort it
            justRollValues.Sort();

            // Make dictionary to hold the player data and a flag for if they are a stamp roller or not.
            Dictionary<PlayerData, bool> dictionaryWithFlags = new Dictionary<PlayerData, bool>();

            // For each roll in our list, check for a tie.
            foreach (double roll in justRollValues)
            {

                // If their roll equals the previous and has the value of the potential winning roll, its a tie.
                if (roll == temp && roll == potentialWinner)
                {
                    gTieFound = true;
                    this.UpdateLogs("Tie was found");
                    MessageBox.Show("Tie was found!", "Tie Detected");

                    // Check if each player in the final list is a stamp roller or not.
                    foreach (PlayerData player in gFinalPlayerDataList)
                    {
                        // If theyre stamp cost is NOT 0, they are a stamp roller
                        if (player.StampCost != 0)
                        {
                            dictionaryWithFlags.Add(player, true);
                        }
                        // If theyre stamp cost is 0, they are a normal roller
                        else
                        {
                            dictionaryWithFlags.Add(player, false);
                        }

                    }


                    // Add prompt for reroll, though if you tied with a normal roller when you used stamps you just get it. If two stamp users tie, reroll and re-apply stamps.If two normal rollers tie, reroll.

                    bool stampRollerHadAWinningValue = false;
                    bool normalRollerHadAWinningValue = false;


                    foreach (KeyValuePair<PlayerData, bool> player in dictionaryWithFlags)
                    {
                        bool flag = player.Value;

                        // If two normal rollers tie, reroll them
                        if (roll == player.Key.FinalRoll && flag == false && roll == potentialWinner)
                        {
                            this.UpdateLogs("Tie was found between two normal rollers");
                            normalRollerHadAWinningValue = true;
                        }
                        // If two stamp rollers tie, reroll them with stamps reapplied.
                        else if (roll == player.Key.FinalRoll && flag == true && roll == potentialWinner)
                        {
                            this.UpdateLogs("Tie was found between two stamp rollers");
                            stampRollerHadAWinningValue = true;
                        }
                        // If a normal roller ties with a stamp roller, stamp roller wins
                        else if (roll == player.Key.FinalRoll && (flag == true || flag == false) && roll == potentialWinner)
                        {
                            this.UpdateLogs("A tie was found between a stamp roller and normal roller");
                            stampRollerHadAWinningValue = true;
                            normalRollerHadAWinningValue = true;
                        }
                        else
                        {
                            //this.UpdateLogs("Tie didnt beat winning value");
                        }


                    }

                    if (normalRollerHadAWinningValue && stampRollerHadAWinningValue)
                    {
                        // We tied between a stamp roller and a normal roller, stamp roll wins
                        gTieFoundBetweenNormalAndStamps = true;
                    }
                    else if (normalRollerHadAWinningValue && !stampRollerHadAWinningValue)
                    {
                        // We tied between two normal rollers
                        gTieFoundBetweenTwoNormal = true;
                    }
                    else
                    {
                        // We ties between two stamp rollers
                        gTieFoundBetweenTwoStamps = true;
                    }

                }
                else
                {
                    gTieFound = false;
                    //this.UpdateLogs("No tie found");
                }

                temp = roll;
            }

            if (gTieFound)
            {
                // Do tie break things;

                if (gTieFoundBetweenTwoStamps)
                {
                    MessageBox.Show("Tie found between the two stamp rollers. Clear run and reset stamp count on sheet. Only stamp people will reroll.", "Tie between stamp rollers detected");
                    return;

                }
                else if (gTieFoundBetweenTwoNormal)
                {
                    MessageBox.Show("Tie found between the two normal rollers. Clear run and only normal people will reroll.", "Tie between normal rollers detected");
                    return;
                }
                else if (gTieFoundBetweenNormalAndStamps)
                {

                    MessageBox.Show("Tie found between stamp and normal rollers. Stamp roller will win", "Tie Detected");

                    double winningRoll = gFinalPlayerDataList.Max(player => player.FinalRoll);

                    string winnerName = "";

                    foreach (PlayerData player in gFinalPlayerDataList)
                    {

                        if (player.FinalRoll == winningRoll && player.StampCost != 0)
                        {
                            this.UpdateLogs(player.Name + " Wins " + gItemName + " With a roll of " + player.FinalRoll);
                            winnerName = player.Name;

                            gWinningPlayerData.ItemWon = gItemName;
                            gWinningPlayerData.Name = player.Name;
                            gWinningPlayerData.Rolls = player.Rolls;
                            gWinningPlayerData.OriginalStampCount = player.OriginalStampCount;
                            gWinningPlayerData.FinalRoll = player.FinalRoll;
                            gWinningPlayerData.StampCost = player.StampCost;

                        }
                        else
                        {
                            gWinningPlayerData.CompetingRolls.Add(player.Name, player.FinalRoll);
                        }
                    }

                    foreach (PlayerData player in gFinalPlayerDataList.ToList())
                    {
                        if (player.Name.Equals(winnerName))
                        {
                            gFinalPlayerDataList.Remove(player);
                        }

                        if (player.StampCost == 0)
                        {
                            gFinalPlayerDataList.Remove(player);
                        }
                    }

                    //Create COM Objects. Create a COM object for everything that is referenced
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"G:\My Drive\StrangeMailStampSystem.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    //xlApp.Visible = true;

                    // For each player in the list with bonus rolls
                    foreach (var player in gFinalPlayerDataList)
                    {


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

                                    // If they are not the winner and have a stamp cost lists
                                    if (xlRange.Cells[i, j].Value2.Equals(player.Name))
                                    {


                                        // If they were not the winner, reset their stamp count back to normal
                                        xlRange.Cells[i, j + 1].Value = player.OriginalStampCount;


                                    }
                                }

                            }
                        }
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

                }
                else
                {

                }



            }
            else
            {
                // Continue as normal
                double winningRoll = gFinalPlayerDataList.Max(player => player.FinalRoll);

                string winnerName = "";

                DeclareWinnerAndFixStamps(winningRoll, winnerName);
            }


        }

        public void DeclareWinnerAndFixStamps(double winningRoll, string winnerName)
        {


            foreach (PlayerData player in gFinalPlayerDataList)
            {

                if (player.FinalRoll == winningRoll)
                {
                    this.UpdateLogs(player.Name + " Wins " + gItemName + " With a roll of " + player.FinalRoll);
                    winnerName = player.Name;

                    gWinningPlayerData.ItemWon = gItemName;
                    gWinningPlayerData.Name = player.Name;
                    gWinningPlayerData.Rolls = player.Rolls;
                    gWinningPlayerData.OriginalStampCount = player.OriginalStampCount;
                    gWinningPlayerData.FinalRoll = player.FinalRoll;
                    gWinningPlayerData.StampCost = player.StampCost;

                }
                else
                {
                    gWinningPlayerData.CompetingRolls.Add(player.Name, player.FinalRoll);
                }
            }

            foreach (PlayerData player in gFinalPlayerDataList.ToList())
            {
                if (player.Name.Equals(winnerName))
                {
                    gFinalPlayerDataList.Remove(player);
                }

                if (player.StampCost == 0)
                {
                    gFinalPlayerDataList.Remove(player);
                }
            }

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"G:\My Drive\StrangeMailStampSystem.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //xlApp.Visible = true;

            // For each player in the list with bonus rolls
            foreach (var player in gFinalPlayerDataList)
            {


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

                            // If they are not the winner and have a stamp cost lists
                            if (xlRange.Cells[i, j].Value2.Equals(player.Name))
                            {


                                // If they were not the winner, reset their stamp count back to normal
                                xlRange.Cells[i, j + 1].Value = player.OriginalStampCount;


                            }
                        }

                    }
                }
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
        }

        double Round(double num, int multipleOf)
        {
            return Math.Ceiling((num + multipleOf / 2) / multipleOf) * multipleOf;
        }

        public void WriteToLootHistory()
        {


            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"G:\My Drive\StrangeMailStampSystem.xlsx", 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[2];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //These two lines do the magic.
            xlRange.Columns.ClearFormats();
            xlRange.Rows.ClearFormats();

            //xlApp.Visible = true;

            List<PlayerData> gWinningPlayerDataList = new List<PlayerData>();

            gWinningPlayerDataList.Add(gWinningPlayerData);

            //Code Here to write row to sheet
            //xlWorksheet.Rows[rowCount + 1].Insert(gWinningPlayerData);+

            int column = 1;

            //foreach (var item in gWinningPlayerDataList)
            //xlWorksheet.Cells[1, column++].Value = item;


            rowCount = xlRange.Rows.Count;
            colCount = xlRange.Columns.Count;

            //setting up member values
            List<string> competingRolls = new List<string>();

            int row = rowCount + 1;
            column = 1;

            xlWorksheet.Cells[row, column++].Value = gWinningPlayerDataList[0].ItemWon;
            xlWorksheet.Cells[row, column++].Value = gWinningPlayerDataList[0].Name;
            xlWorksheet.Cells[row, column++].Value = gWinningPlayerDataList[0].Rolls;
            xlWorksheet.Cells[row, column++].Value = gWinningPlayerDataList[0].OriginalStampCount;
            xlWorksheet.Cells[row, column++].Value = gWinningPlayerDataList[0].FinalRoll;
            xlWorksheet.Cells[row, column++].Value = gWinningPlayerDataList[0].StampCost;
            xlWorksheet.Cells[row, column++].Value = gRaidName;
            xlWorksheet.Cells[row, column++].Value = gRaidType;
            xlWorksheet.Cells[row, column++].Value = System.DateTime.Now.ToShortDateString();


            /*
            for(int index = 0; index < item.CompetingRolls.Count; index++)
            {
                xlWorksheet.Cells[row++, column].Value = item.CompetingRolls[index];
            }
            */

            foreach (var thing in gWinningPlayerDataList[0].CompetingRolls)
            {
                competingRolls.Add(thing.ToString());
            }

            //xlWorksheet.Cells[row, column++].Value = competingRolls.ToArray();

            /*
            for (int index = 0; index < competingRolls.Count; index++)
            {
                xlWorksheet.Cells[row++, column].Value = competingRolls[index];
            }
            */
            for (int index = 0; index < competingRolls.Count; index++)
            {
                xlWorksheet.Cells[row++, column].Value = competingRolls[index];
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

            this.UpdateLogs("Sheet has been updated. Session Complete");
        }

        private void m_ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_CheckBoxNaxx_CheckedChanged(object sender, EventArgs e)
        {
            gRaidName = "";

            m_CheckBoxEoE.Checked = false;
            m_CheckBoxOS.Checked = false;

            gRaidName = "Naxx";

            CheckIfReady();

        }

        private void m_CheckBoxEoE_CheckedChanged(object sender, EventArgs e)
        {
            gRaidName = "";

            m_CheckBoxNaxx.Checked = false;
            m_CheckBoxOS.Checked = false;

            gRaidName = "EoE";

            CheckIfReady();
        }

        private void m_CheckBoxOS_CheckedChanged(object sender, EventArgs e)
        {
            gRaidName = "";

            m_CheckBoxNaxx.Checked = false;
            m_CheckBoxEoE.Checked = false;

            gRaidName = "EoE";

            CheckIfReady();
        }

        private void m_ButtonClearAllFields_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            m_TextBoxItemName.Text = "";
            m_Checkbox10Man.Checked = false;
            m_CheckBox25Man.Checked = false;
            m_CheckBoxNaxx.Checked = false;
            m_CheckBoxEoE.Checked = false;
            m_CheckBoxOS.Checked = false;

            gGuildMemberList.Clear();
            gGuildMemberListBonus.Clear();
            gFinalPlayerDataList.Clear();
            gPlayersWithRolls.Clear();
            gPlayersWithRollsBonus.Clear();
            gWinningPlayerData = new PlayerData();

            m_checkedListBoxGuildMembers.Items.Clear();
            m_checkedListBoxGuildMembersBonus.Items.Clear();
        }
    }

}
