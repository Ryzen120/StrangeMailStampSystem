using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrangeMailStampSystem
{
    class RollChecker
    {
        List<string> gRawRollDataList;

        List<string> gRawRollDataListFiltered;

        List<string> gRollDataList;

        List<string> gMemberList;

        List<string> gMemberListBonus;

        StrangeMailStampSystem gGui;

        public RollChecker(StrangeMailStampSystem gui, List<string> memberList, List<string> memberListBonus )
        {
            gRawRollDataList = new List<string>();
            gRawRollDataListFiltered = new List<string>();
            gRollDataList = new List<string>();
            gMemberList = memberList;
            gMemberListBonus = memberListBonus;

            gGui = gui;

            BuildDataList();
        }

        public void FilterList(List<string> rawDataList)
        {
            List<string> tmpList = new List<string>();

            tmpList = rawDataList;

         
            for(int i = 0; i < tmpList.Count; i++)
            {
                if (tmpList[i].Contains("rolls"))
                {
                    gRawRollDataListFiltered.Add(tmpList[i]);
                }

            }
        }

        public void BuildDataList()
        {
            string fileName = "E:\\World of Warcraft\\_classic_\\Logs\\WoWChatLog.txt";
            string tempFileName = "E:\\World of Warcraft\\_classic_\\Logs\\WoWChatLogTemp.txt";

            File.Copy(fileName, tempFileName);

            gGui.UpdateLogs("Building roll list...");

            gRawRollDataList = File.ReadAllLines(tempFileName).ToList();

            FilterList(gRawRollDataList);

            for (int i = 0; i < gRawRollDataListFiltered.Count; i++)
            {
                // If the raw data list contains a member from the normal list or bonus list

                for(int j = 0; j < gMemberList.Count; j++)
                {
                    if (gRawRollDataListFiltered[i].Contains(gMemberList[j]) || gRawRollDataListFiltered[i].Contains(gMemberListBonus[j]))
                    {
                        gRollDataList.Add(gRawRollDataListFiltered[i]);
                    }
                }

                for (int j = 0; j < gMemberList.Count; j++)
                {
                    if (gRawRollDataListFiltered[i].Contains(gMemberList[j]) || gRawRollDataListFiltered[i].Contains(gMemberListBonus[j]))
                    {
                        gRollDataList.Add(gRawRollDataListFiltered[i]);
                    }
                }

            }

            File.Delete(tempFileName);
        }

    }
}
