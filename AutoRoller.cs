using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeMailStampSystem
{
    class AutoRoller
    {
        private List<string> pnRollers;
        private List<string> psRollers;
        private Dictionary<string, int> pssRollers; 
        private Dictionary<string, int> pnEndRolls;
        private Dictionary<string, int> psEndRolls;
        private Dictionary<string, int> allRolls;
        StrangeMailStampSystem gui;

        public AutoRoller(StrangeMailStampSystem gui)
        {
            pnRollers = Globals.nRollers;
            psRollers = Globals.sRollers;
            pssRollers = Globals.ssRollers;
            this.gui = gui;
        }

        private void dWinner()
        {
            gui.UpdateLogs("a");
        }

        private Dictionary<string, int> nRoll()
        {
            Random rnd = new Random();
            foreach (string roller in pnRollers)
            {
                pnEndRolls.Add(roller, rnd.Next(1,100));
            }

            return pnEndRolls;
        }
        private Dictionary<string, int> sRoll()
        {
            Random rnd = new Random();

            foreach (var item in pssRollers)
            {
                psEndRolls.Add(item.Key, item.Value + rnd.Next(1, 100));
            }
            return psEndRolls;
        }

        private Dictionary<string, int> megaDic()
        {
            
            foreach(var item in pnEndRolls)
            {
                allRolls.Add(item.Key,item.Value);

            }
            foreach (var item in psEndRolls)
            {
                allRolls.Add(item.Key, item.Value);
            }

            return allRolls;

        }

    }
}
