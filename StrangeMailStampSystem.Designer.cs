namespace StrangeMailStampSystem
{
    partial class StrangeMailStampSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_PanelTitleBar = new System.Windows.Forms.Panel();
            this.m_LabelTitle = new System.Windows.Forms.Label();
            this.m_checkedListBoxGuildMembers = new System.Windows.Forms.CheckedListBox();
            this.m_LabelItemName = new System.Windows.Forms.Label();
            this.m_TextBoxItemName = new System.Windows.Forms.TextBox();
            this.m_RichTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.m_LabelResults = new System.Windows.Forms.Label();
            this.m_ButtonRoll = new System.Windows.Forms.Button();
            this.m_Checkbox10Man = new System.Windows.Forms.CheckBox();
            this.m_CheckBox25Man = new System.Windows.Forms.CheckBox();
            this.m_ButtonInitList = new System.Windows.Forms.Button();
            this.m_checkedListBoxGuildMembersBonus = new System.Windows.Forms.CheckedListBox();
            this.m_labelGuildMemberList = new System.Windows.Forms.Label();
            this.m_LabelGuildMembersStampRolls = new System.Windows.Forms.Label();
            this.m_PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PanelTitleBar
            // 
            this.m_PanelTitleBar.BackColor = System.Drawing.Color.Black;
            this.m_PanelTitleBar.Controls.Add(this.m_LabelTitle);
            this.m_PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.m_PanelTitleBar.Name = "m_PanelTitleBar";
            this.m_PanelTitleBar.Size = new System.Drawing.Size(1315, 70);
            this.m_PanelTitleBar.TabIndex = 0;
            this.m_PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseDown);
            this.m_PanelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseMove);
            this.m_PanelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseUp);
            // 
            // m_LabelTitle
            // 
            this.m_LabelTitle.AutoSize = true;
            this.m_LabelTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_LabelTitle.Location = new System.Drawing.Point(494, 19);
            this.m_LabelTitle.Name = "m_LabelTitle";
            this.m_LabelTitle.Size = new System.Drawing.Size(462, 40);
            this.m_LabelTitle.TabIndex = 0;
            this.m_LabelTitle.Text = "Strange Mail Stamp System";
            // 
            // m_checkedListBoxGuildMembers
            // 
            this.m_checkedListBoxGuildMembers.BackColor = System.Drawing.Color.Black;
            this.m_checkedListBoxGuildMembers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_checkedListBoxGuildMembers.FormattingEnabled = true;
            this.m_checkedListBoxGuildMembers.Location = new System.Drawing.Point(22, 116);
            this.m_checkedListBoxGuildMembers.Name = "m_checkedListBoxGuildMembers";
            this.m_checkedListBoxGuildMembers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_checkedListBoxGuildMembers.Size = new System.Drawing.Size(354, 649);
            this.m_checkedListBoxGuildMembers.TabIndex = 1;
            this.m_checkedListBoxGuildMembers.ThreeDCheckBoxes = true;
            // 
            // m_LabelItemName
            // 
            this.m_LabelItemName.AutoSize = true;
            this.m_LabelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelItemName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_LabelItemName.Location = new System.Drawing.Point(781, 96);
            this.m_LabelItemName.Name = "m_LabelItemName";
            this.m_LabelItemName.Size = new System.Drawing.Size(106, 25);
            this.m_LabelItemName.TabIndex = 2;
            this.m_LabelItemName.Text = "Item Name";
            // 
            // m_TextBoxItemName
            // 
            this.m_TextBoxItemName.Location = new System.Drawing.Point(874, 96);
            this.m_TextBoxItemName.Name = "m_TextBoxItemName";
            this.m_TextBoxItemName.Size = new System.Drawing.Size(208, 20);
            this.m_TextBoxItemName.TabIndex = 3;
            this.m_TextBoxItemName.TextChanged += new System.EventHandler(this.m_TextBoxItemName_TextChanged);
            // 
            // m_RichTextBoxResults
            // 
            this.m_RichTextBoxResults.Location = new System.Drawing.Point(826, 255);
            this.m_RichTextBoxResults.Name = "m_RichTextBoxResults";
            this.m_RichTextBoxResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_RichTextBoxResults.Size = new System.Drawing.Size(328, 310);
            this.m_RichTextBoxResults.TabIndex = 4;
            this.m_RichTextBoxResults.Text = "";
            // 
            // m_LabelResults
            // 
            this.m_LabelResults.AutoSize = true;
            this.m_LabelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_LabelResults.Location = new System.Drawing.Point(941, 228);
            this.m_LabelResults.Name = "m_LabelResults";
            this.m_LabelResults.Size = new System.Drawing.Size(125, 25);
            this.m_LabelResults.TabIndex = 5;
            this.m_LabelResults.Text = "Roll Results";
            // 
            // m_ButtonRoll
            // 
            this.m_ButtonRoll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_ButtonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonRoll.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonRoll.Location = new System.Drawing.Point(1109, 116);
            this.m_ButtonRoll.Name = "m_ButtonRoll";
            this.m_ButtonRoll.Size = new System.Drawing.Size(75, 31);
            this.m_ButtonRoll.TabIndex = 6;
            this.m_ButtonRoll.Text = "Roll";
            this.m_ButtonRoll.UseVisualStyleBackColor = false;
            this.m_ButtonRoll.Click += new System.EventHandler(this.m_ButtonRoll_Click);
            // 
            // m_Checkbox10Man
            // 
            this.m_Checkbox10Man.AutoSize = true;
            this.m_Checkbox10Man.Location = new System.Drawing.Point(826, 139);
            this.m_Checkbox10Man.Name = "m_Checkbox10Man";
            this.m_Checkbox10Man.Size = new System.Drawing.Size(71, 19);
            this.m_Checkbox10Man.TabIndex = 7;
            this.m_Checkbox10Man.Text = "10 Man";
            this.m_Checkbox10Man.UseVisualStyleBackColor = true;
            this.m_Checkbox10Man.CheckedChanged += new System.EventHandler(this.m_Checkbox10Man_CheckedChanged);
            // 
            // m_CheckBox25Man
            // 
            this.m_CheckBox25Man.AutoSize = true;
            this.m_CheckBox25Man.Checked = true;
            this.m_CheckBox25Man.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckBox25Man.Location = new System.Drawing.Point(826, 162);
            this.m_CheckBox25Man.Name = "m_CheckBox25Man";
            this.m_CheckBox25Man.Size = new System.Drawing.Size(71, 19);
            this.m_CheckBox25Man.TabIndex = 8;
            this.m_CheckBox25Man.Text = "25 Man";
            this.m_CheckBox25Man.UseVisualStyleBackColor = true;
            this.m_CheckBox25Man.CheckedChanged += new System.EventHandler(this.m_CheckBox25Man_CheckedChanged);
            // 
            // m_ButtonInitList
            // 
            this.m_ButtonInitList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_ButtonInitList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonInitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonInitList.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonInitList.Location = new System.Drawing.Point(22, 771);
            this.m_ButtonInitList.Name = "m_ButtonInitList";
            this.m_ButtonInitList.Size = new System.Drawing.Size(119, 23);
            this.m_ButtonInitList.TabIndex = 9;
            this.m_ButtonInitList.Text = "Initialize List";
            this.m_ButtonInitList.UseVisualStyleBackColor = false;
            this.m_ButtonInitList.Click += new System.EventHandler(this.m_ButtonInitList_Click);
            // 
            // m_checkedListBoxGuildMembersBonus
            // 
            this.m_checkedListBoxGuildMembersBonus.BackColor = System.Drawing.Color.Black;
            this.m_checkedListBoxGuildMembersBonus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_checkedListBoxGuildMembersBonus.FormattingEnabled = true;
            this.m_checkedListBoxGuildMembersBonus.Location = new System.Drawing.Point(406, 116);
            this.m_checkedListBoxGuildMembersBonus.Name = "m_checkedListBoxGuildMembersBonus";
            this.m_checkedListBoxGuildMembersBonus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_checkedListBoxGuildMembersBonus.Size = new System.Drawing.Size(354, 649);
            this.m_checkedListBoxGuildMembersBonus.TabIndex = 10;
            this.m_checkedListBoxGuildMembersBonus.ThreeDCheckBoxes = true;
            // 
            // m_labelGuildMemberList
            // 
            this.m_labelGuildMemberList.AutoSize = true;
            this.m_labelGuildMemberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelGuildMemberList.Location = new System.Drawing.Point(149, 89);
            this.m_labelGuildMemberList.Name = "m_labelGuildMemberList";
            this.m_labelGuildMemberList.Size = new System.Drawing.Size(133, 25);
            this.m_labelGuildMemberList.TabIndex = 11;
            this.m_labelGuildMemberList.Text = "Normal Rolls";
            // 
            // m_LabelGuildMembersStampRolls
            // 
            this.m_LabelGuildMembersStampRolls.AutoSize = true;
            this.m_LabelGuildMembersStampRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelGuildMembersStampRolls.Location = new System.Drawing.Point(539, 89);
            this.m_LabelGuildMembersStampRolls.Name = "m_LabelGuildMembersStampRolls";
            this.m_LabelGuildMembersStampRolls.Size = new System.Drawing.Size(127, 25);
            this.m_LabelGuildMembersStampRolls.TabIndex = 12;
            this.m_LabelGuildMembersStampRolls.Text = "Stamp Rolls";
            // 
            // StrangeMailStampSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1315, 806);
            this.Controls.Add(this.m_LabelGuildMembersStampRolls);
            this.Controls.Add(this.m_labelGuildMemberList);
            this.Controls.Add(this.m_checkedListBoxGuildMembersBonus);
            this.Controls.Add(this.m_ButtonInitList);
            this.Controls.Add(this.m_CheckBox25Man);
            this.Controls.Add(this.m_Checkbox10Man);
            this.Controls.Add(this.m_ButtonRoll);
            this.Controls.Add(this.m_LabelResults);
            this.Controls.Add(this.m_RichTextBoxResults);
            this.Controls.Add(this.m_TextBoxItemName);
            this.Controls.Add(this.m_LabelItemName);
            this.Controls.Add(this.m_checkedListBoxGuildMembers);
            this.Controls.Add(this.m_PanelTitleBar);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StrangeMailStampSystem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.m_PanelTitleBar.ResumeLayout(false);
            this.m_PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_PanelTitleBar;
        private System.Windows.Forms.Label m_LabelTitle;
        private System.Windows.Forms.CheckedListBox m_checkedListBoxGuildMembers;
        private System.Windows.Forms.Label m_LabelItemName;
        private System.Windows.Forms.TextBox m_TextBoxItemName;
        private System.Windows.Forms.RichTextBox m_RichTextBoxResults;
        private System.Windows.Forms.Label m_LabelResults;
        private System.Windows.Forms.Button m_ButtonRoll;
        private System.Windows.Forms.CheckBox m_Checkbox10Man;
        private System.Windows.Forms.CheckBox m_CheckBox25Man;
        private System.Windows.Forms.Button m_ButtonInitList;
        private System.Windows.Forms.CheckedListBox m_checkedListBoxGuildMembersBonus;
        private System.Windows.Forms.Label m_labelGuildMemberList;
        private System.Windows.Forms.Label m_LabelGuildMembersStampRolls;
    }
}

