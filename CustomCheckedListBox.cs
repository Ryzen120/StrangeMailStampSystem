using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StrangeMailStampSystem
{
    public class CustomCheckedListBox : CheckedListBox
    {
        public delegate Color GetColorDelegate(CustomCheckedListBox listBox, DrawItemEventArgs e);
        public event GetColorDelegate GetForeColor = null;

        public CustomCheckedListBox()
        {

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Color foreColor = (GetForeColor != null) ? GetForeColor(this, e) : e.ForeColor;

            DrawItemEventArgs e2 = new DrawItemEventArgs(e.Graphics, e.Font, new Rectangle(e.Bounds.Location, e.Bounds.Size),
            e.Index, (e.State & DrawItemState.Focus) == DrawItemState.Focus ? DrawItemState.Focus : DrawItemState.None,
            foreColor, this.BackColor);

            base.OnDrawItem(e2);
        }
    }
}
