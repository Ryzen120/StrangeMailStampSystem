using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StrangeMailStampSystem
{
    public class FuncInfo
    {

        public Status Status { set; get; }

        public FuncInfo()
        {
            Status = Status.NoSelected;
        }

        public Color ForeColor
        {
            get
            {
                if(Status == Status.NoSelected)
                {
                    return Color.White;
                }
                if(Status == Status.Roll)
                {
                    return Color.Wheat;
                }
                if (Status == Status.StampRoll)
                {
                    return Color.Orange;
                }

                return Color.White;
            }
        }

    }
}
