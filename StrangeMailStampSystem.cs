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

        private Point gStartLocation;

        private bool gDragging;

        private int[] gStartPoint;

        private string gLogFile;

        public StrangeMailStampSystem()
        {
            InitializeComponent();

            gStartPoint = new int[2];
            gLogFile = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Strange_Mail_Stamp_System_Logs.txt";
            gGuildMemberList = new List<string>();
            gGuildMemberListBonus = new List<string>();
        }

        private void IntializeList()
        {
            string fileName = "C:\\Users\\Bobby\\Documents\\GuildMembers.txt";
            gGuildMemberList = File.ReadAllLines(fileName).ToList();
            gGuildMemberListBonus = File.ReadAllLines(fileName).ToList();

            Console.WriteLine("tyest");
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
            if(e.Index >= 0)
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

        }

        private void m_ButtonRoll_Click(object sender, EventArgs e)
        {
            
        }

        private void m_Checkbox10Man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m_CheckBox25Man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m_ButtonInitList_Click(object sender, EventArgs e)
        {
            IntializeList();
            UpdateLogs("List Initialized");
            m_checkedListBoxGuildMembers.Items.AddRange(gGuildMemberList.ToArray());
            m_checkedListBoxGuildMembersBonus.Items.AddRange(gGuildMemberList.ToArray());
        }
    }
}
