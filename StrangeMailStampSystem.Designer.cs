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
            this.m_ButtonCloseApp = new System.Windows.Forms.Button();
            this.m_ButtonMinimize = new System.Windows.Forms.Button();
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
            this.m_ButtonGatherRollData = new System.Windows.Forms.Button();
            this.m_ButtonEnterRolls = new System.Windows.Forms.Button();
            this.m_CheckBoxNaxx = new System.Windows.Forms.CheckBox();
            this.m_CheckBoxEoE = new System.Windows.Forms.CheckBox();
            this.m_CheckBoxOS = new System.Windows.Forms.CheckBox();
            this.m_ButtonClearAllFields = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PanelTitleBar
            // 
            this.m_PanelTitleBar.BackColor = System.Drawing.Color.Black;
            this.m_PanelTitleBar.Controls.Add(this.pictureBox1);
            this.m_PanelTitleBar.Controls.Add(this.m_ButtonCloseApp);
            this.m_PanelTitleBar.Controls.Add(this.m_ButtonMinimize);
            this.m_PanelTitleBar.Controls.Add(this.m_LabelTitle);
            this.m_PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.m_PanelTitleBar.Name = "m_PanelTitleBar";
            this.m_PanelTitleBar.Size = new System.Drawing.Size(1315, 70);
            this.m_PanelTitleBar.TabIndex = 0;
            this.m_PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseDown);
            this.m_PanelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseMove);
            this.m_PanelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseUp);
            // 
            // m_ButtonCloseApp
            // 
            this.m_ButtonCloseApp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonCloseApp.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonCloseApp.Location = new System.Drawing.Point(1260, 19);
            this.m_ButtonCloseApp.Name = "m_ButtonCloseApp";
            this.m_ButtonCloseApp.Size = new System.Drawing.Size(34, 30);
            this.m_ButtonCloseApp.TabIndex = 5;
            this.m_ButtonCloseApp.Text = "X";
            this.m_ButtonCloseApp.UseVisualStyleBackColor = true;
            this.m_ButtonCloseApp.Click += new System.EventHandler(this.m_ButtonCloseApp_Click);
            // 
            // m_ButtonMinimize
            // 
            this.m_ButtonMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonMinimize.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonMinimize.Location = new System.Drawing.Point(1220, 19);
            this.m_ButtonMinimize.Name = "m_ButtonMinimize";
            this.m_ButtonMinimize.Size = new System.Drawing.Size(34, 30);
            this.m_ButtonMinimize.TabIndex = 4;
            this.m_ButtonMinimize.Text = "-";
            this.m_ButtonMinimize.UseVisualStyleBackColor = true;
            this.m_ButtonMinimize.Click += new System.EventHandler(this.m_ButtonMinimize_Click);
            // 
            // m_LabelTitle
            // 
            this.m_LabelTitle.AutoSize = true;
            this.m_LabelTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_LabelTitle.Location = new System.Drawing.Point(494, 19);
            this.m_LabelTitle.Name = "m_LabelTitle";
            this.m_LabelTitle.Size = new System.Drawing.Size(368, 33);
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
            this.m_LabelItemName.Size = new System.Drawing.Size(87, 20);
            this.m_LabelItemName.TabIndex = 2;
            this.m_LabelItemName.Text = "Item Name";
            // 
            // m_TextBoxItemName
            // 
            this.m_TextBoxItemName.Location = new System.Drawing.Point(874, 96);
            this.m_TextBoxItemName.Name = "m_TextBoxItemName";
            this.m_TextBoxItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_TextBoxItemName.Size = new System.Drawing.Size(208, 20);
            this.m_TextBoxItemName.TabIndex = 3;
            this.m_TextBoxItemName.TextChanged += new System.EventHandler(this.m_TextBoxItemName_TextChanged);
            // 
            // m_RichTextBoxResults
            // 
            this.m_RichTextBoxResults.Location = new System.Drawing.Point(781, 455);
            this.m_RichTextBoxResults.Name = "m_RichTextBoxResults";
            this.m_RichTextBoxResults.ReadOnly = true;
            this.m_RichTextBoxResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_RichTextBoxResults.Size = new System.Drawing.Size(522, 310);
            this.m_RichTextBoxResults.TabIndex = 4;
            this.m_RichTextBoxResults.Text = "";
            // 
            // m_LabelResults
            // 
            this.m_LabelResults.AutoSize = true;
            this.m_LabelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_LabelResults.Location = new System.Drawing.Point(980, 420);
            this.m_LabelResults.Name = "m_LabelResults";
            this.m_LabelResults.Size = new System.Drawing.Size(106, 20);
            this.m_LabelResults.TabIndex = 5;
            this.m_LabelResults.Text = "Roll Results";
            // 
            // m_ButtonRoll
            // 
            this.m_ButtonRoll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_ButtonRoll.Enabled = false;
            this.m_ButtonRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonRoll.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonRoll.Location = new System.Drawing.Point(794, 288);
            this.m_ButtonRoll.Name = "m_ButtonRoll";
            this.m_ButtonRoll.Size = new System.Drawing.Size(154, 23);
            this.m_ButtonRoll.TabIndex = 6;
            this.m_ButtonRoll.Text = "Auto Roll - Beta";
            this.m_ButtonRoll.UseVisualStyleBackColor = false;
            this.m_ButtonRoll.Click += new System.EventHandler(this.m_ButtonRoll_Click);
            // 
            // m_Checkbox10Man
            // 
            this.m_Checkbox10Man.AutoSize = true;
            this.m_Checkbox10Man.Location = new System.Drawing.Point(806, 133);
            this.m_Checkbox10Man.Name = "m_Checkbox10Man";
            this.m_Checkbox10Man.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_Checkbox10Man.Size = new System.Drawing.Size(62, 17);
            this.m_Checkbox10Man.TabIndex = 7;
            this.m_Checkbox10Man.Text = "10 Man";
            this.m_Checkbox10Man.UseVisualStyleBackColor = true;
            this.m_Checkbox10Man.CheckedChanged += new System.EventHandler(this.m_Checkbox10Man_CheckedChanged);
            // 
            // m_CheckBox25Man
            // 
            this.m_CheckBox25Man.AutoSize = true;
            this.m_CheckBox25Man.Location = new System.Drawing.Point(806, 156);
            this.m_CheckBox25Man.Name = "m_CheckBox25Man";
            this.m_CheckBox25Man.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_CheckBox25Man.Size = new System.Drawing.Size(62, 17);
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
            this.m_labelGuildMemberList.Size = new System.Drawing.Size(110, 20);
            this.m_labelGuildMemberList.TabIndex = 11;
            this.m_labelGuildMemberList.Text = "Normal Rolls";
            // 
            // m_LabelGuildMembersStampRolls
            // 
            this.m_LabelGuildMembersStampRolls.AutoSize = true;
            this.m_LabelGuildMembersStampRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelGuildMembersStampRolls.Location = new System.Drawing.Point(539, 89);
            this.m_LabelGuildMembersStampRolls.Name = "m_LabelGuildMembersStampRolls";
            this.m_LabelGuildMembersStampRolls.Size = new System.Drawing.Size(106, 20);
            this.m_LabelGuildMembersStampRolls.TabIndex = 12;
            this.m_LabelGuildMembersStampRolls.Text = "Stamp Rolls";
            // 
            // m_ButtonGatherRollData
            // 
            this.m_ButtonGatherRollData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_ButtonGatherRollData.Enabled = false;
            this.m_ButtonGatherRollData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonGatherRollData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonGatherRollData.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonGatherRollData.Location = new System.Drawing.Point(794, 243);
            this.m_ButtonGatherRollData.Name = "m_ButtonGatherRollData";
            this.m_ButtonGatherRollData.Size = new System.Drawing.Size(234, 23);
            this.m_ButtonGatherRollData.TabIndex = 13;
            this.m_ButtonGatherRollData.Text = "Gather Rolls From Chat - Beta";
            this.m_ButtonGatherRollData.UseVisualStyleBackColor = false;
            this.m_ButtonGatherRollData.Click += new System.EventHandler(this.m_ButtonGatherRollData_Click);
            // 
            // m_ButtonEnterRolls
            // 
            this.m_ButtonEnterRolls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_ButtonEnterRolls.Enabled = false;
            this.m_ButtonEnterRolls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonEnterRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonEnterRolls.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonEnterRolls.Location = new System.Drawing.Point(1105, 94);
            this.m_ButtonEnterRolls.Name = "m_ButtonEnterRolls";
            this.m_ButtonEnterRolls.Size = new System.Drawing.Size(189, 23);
            this.m_ButtonEnterRolls.TabIndex = 14;
            this.m_ButtonEnterRolls.Text = "Enter Rolls Manually";
            this.m_ButtonEnterRolls.UseVisualStyleBackColor = false;
            this.m_ButtonEnterRolls.Click += new System.EventHandler(this.m_ButtonEnterRolls_Click);
            // 
            // m_CheckBoxNaxx
            // 
            this.m_CheckBoxNaxx.AutoSize = true;
            this.m_CheckBoxNaxx.Location = new System.Drawing.Point(883, 133);
            this.m_CheckBoxNaxx.Name = "m_CheckBoxNaxx";
            this.m_CheckBoxNaxx.Size = new System.Drawing.Size(50, 17);
            this.m_CheckBoxNaxx.TabIndex = 15;
            this.m_CheckBoxNaxx.Text = "Naxx";
            this.m_CheckBoxNaxx.UseVisualStyleBackColor = true;
            this.m_CheckBoxNaxx.CheckedChanged += new System.EventHandler(this.m_CheckBoxNaxx_CheckedChanged);
            // 
            // m_CheckBoxEoE
            // 
            this.m_CheckBoxEoE.AutoSize = true;
            this.m_CheckBoxEoE.Location = new System.Drawing.Point(887, 156);
            this.m_CheckBoxEoE.Name = "m_CheckBoxEoE";
            this.m_CheckBoxEoE.Size = new System.Drawing.Size(46, 17);
            this.m_CheckBoxEoE.TabIndex = 16;
            this.m_CheckBoxEoE.Text = "EoE";
            this.m_CheckBoxEoE.UseVisualStyleBackColor = true;
            this.m_CheckBoxEoE.CheckedChanged += new System.EventHandler(this.m_CheckBoxEoE_CheckedChanged);
            // 
            // m_CheckBoxOS
            // 
            this.m_CheckBoxOS.AutoSize = true;
            this.m_CheckBoxOS.Location = new System.Drawing.Point(892, 179);
            this.m_CheckBoxOS.Name = "m_CheckBoxOS";
            this.m_CheckBoxOS.Size = new System.Drawing.Size(41, 17);
            this.m_CheckBoxOS.TabIndex = 17;
            this.m_CheckBoxOS.Text = "OS";
            this.m_CheckBoxOS.UseVisualStyleBackColor = true;
            this.m_CheckBoxOS.CheckedChanged += new System.EventHandler(this.m_CheckBoxOS_CheckedChanged);
            // 
            // m_ButtonClearAllFields
            // 
            this.m_ButtonClearAllFields.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_ButtonClearAllFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonClearAllFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonClearAllFields.ForeColor = System.Drawing.Color.Black;
            this.m_ButtonClearAllFields.Location = new System.Drawing.Point(406, 771);
            this.m_ButtonClearAllFields.Name = "m_ButtonClearAllFields";
            this.m_ButtonClearAllFields.Size = new System.Drawing.Size(119, 23);
            this.m_ButtonClearAllFields.TabIndex = 18;
            this.m_ButtonClearAllFields.Text = "Clear Fields";
            this.m_ButtonClearAllFields.UseVisualStyleBackColor = false;
            this.m_ButtonClearAllFields.Click += new System.EventHandler(this.m_ButtonClearAllFields_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::StrangeMailStampSystem.Properties.Resources.StrangeMailLogo;
            this.pictureBox1.InitialImage = global::StrangeMailStampSystem.Properties.Resources.StrangeMailLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StrangeMailStampSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1315, 806);
            this.Controls.Add(this.m_ButtonClearAllFields);
            this.Controls.Add(this.m_CheckBoxOS);
            this.Controls.Add(this.m_CheckBoxEoE);
            this.Controls.Add(this.m_CheckBoxNaxx);
            this.Controls.Add(this.m_ButtonEnterRolls);
            this.Controls.Add(this.m_ButtonGatherRollData);
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
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StrangeMailStampSystem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.m_PanelTitleBar.ResumeLayout(false);
            this.m_PanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button m_ButtonGatherRollData;
        private System.Windows.Forms.Button m_ButtonEnterRolls;
        private System.Windows.Forms.Button m_ButtonCloseApp;
        private System.Windows.Forms.Button m_ButtonMinimize;
        private System.Windows.Forms.CheckBox m_CheckBoxNaxx;
        private System.Windows.Forms.CheckBox m_CheckBoxEoE;
        private System.Windows.Forms.CheckBox m_CheckBoxOS;
        private System.Windows.Forms.Button m_ButtonClearAllFields;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

