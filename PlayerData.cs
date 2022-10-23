using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeMailStampSystem
{
    class PlayerData
    {
        public string Name { set; get; }

        public int Rolls { set; get; }

        public int OriginalStampCount { set; get; }

        public int FinalRoll { set; get; }

        public double StampCost { set; get; }

        public double StampsRemaining { set; get; }

        public string ItemWon { set; get; }

        public Dictionary<string, int> CompetingRolls { set; get; }

        public PlayerData()
        {
            CompetingRolls = new Dictionary<string, int>();
        }

    }
}
