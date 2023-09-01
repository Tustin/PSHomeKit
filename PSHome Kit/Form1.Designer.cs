namespace PSHome_Kit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nsTheme1 = new NSTheme();
            this.chat = new NSTrackBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.size = new NSComboBox();
            this.nsGroupBox3 = new NSGroupBox();
            this.channel = new NSCheckBox();
            this.admin = new NSCheckBox();
            this.action = new NSCheckBox();
            this.wallhack = new NSCheckBox();
            this.console = new NSCheckBox();
            this.sendname = new NSButton();
            this.namebox = new NSTextBox();
            this.nsLabel2 = new NSLabel();
            this.nsLabel1 = new NSLabel();
            this.nsGroupBox1 = new NSGroupBox();
            this.ccapibutton = new NSRadioButton();
            this.nsGroupBox2 = new NSGroupBox();
            this.connect = new NSButton();
            this.ipbox = new NSTextBox();
            this.tmapi = new NSRadioButton();
            this.nsControlButton2 = new NSControlButton();
            this.nsControlButton1 = new NSControlButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nsTheme1.SuspendLayout();
            this.nsGroupBox3.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.label1);
            this.nsTheme1.Controls.Add(this.chat);
            this.nsTheme1.Controls.Add(this.linkLabel1);
            this.nsTheme1.Controls.Add(this.size);
            this.nsTheme1.Controls.Add(this.nsGroupBox3);
            this.nsTheme1.Controls.Add(this.sendname);
            this.nsTheme1.Controls.Add(this.namebox);
            this.nsTheme1.Controls.Add(this.nsLabel2);
            this.nsTheme1.Controls.Add(this.nsLabel1);
            this.nsTheme1.Controls.Add(this.nsGroupBox1);
            this.nsTheme1.Controls.Add(this.nsControlButton2);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(318, 315);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "PS Home Mod Kit - Tustin";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Click += new System.EventHandler(this.nsTheme1_Click);
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(63, 282);
            this.chat.Maximum = 5;
            this.chat.Minimum = 3;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(85, 21);
            this.chat.TabIndex = 13;
            this.chat.Text = "nsTrackBar1";
            this.chat.Value = 3;
            this.chat.Scroll += new NSTrackBar.ScrollEventHandler(this.nsTrackBar1_Scroll);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(269, 295);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.Enabled = false;
            this.size.ForeColor = System.Drawing.Color.White;
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "Default",
            "10x",
            "20x",
            "50x",
            "100x"});
            this.size.Location = new System.Drawing.Point(111, 229);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(121, 21);
            this.size.TabIndex = 12;
            this.size.SelectedIndexChanged += new System.EventHandler(this.nsComboBox1_SelectedIndexChanged);
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.Controls.Add(this.channel);
            this.nsGroupBox3.Controls.Add(this.admin);
            this.nsGroupBox3.Controls.Add(this.action);
            this.nsGroupBox3.Controls.Add(this.wallhack);
            this.nsGroupBox3.Controls.Add(this.console);
            this.nsGroupBox3.DrawSeperator = false;
            this.nsGroupBox3.Location = new System.Drawing.Point(15, 128);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(287, 95);
            this.nsGroupBox3.SubTitle = "Mods";
            this.nsGroupBox3.TabIndex = 10;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "";
            this.nsGroupBox3.Click += new System.EventHandler(this.nsGroupBox3_Click);
            // 
            // channel
            // 
            this.channel.Checked = false;
            this.channel.Enabled = false;
            this.channel.Location = new System.Drawing.Point(86, 69);
            this.channel.Name = "channel";
            this.channel.Size = new System.Drawing.Size(112, 23);
            this.channel.TabIndex = 10;
            this.channel.Text = "Channel Info";
            this.channel.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged_3);
            // 
            // admin
            // 
            this.admin.Checked = false;
            this.admin.Enabled = false;
            this.admin.Location = new System.Drawing.Point(26, 18);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(136, 23);
            this.admin.TabIndex = 8;
            this.admin.Text = "Admin Chat Range";
            this.admin.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged_1);
            // 
            // action
            // 
            this.action.Checked = false;
            this.action.Enabled = false;
            this.action.Location = new System.Drawing.Point(26, 46);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(134, 23);
            this.action.TabIndex = 9;
            this.action.Text = "No Action Delay";
            this.action.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged_2);
            // 
            // wallhack
            // 
            this.wallhack.Checked = false;
            this.wallhack.Enabled = false;
            this.wallhack.Location = new System.Drawing.Point(166, 18);
            this.wallhack.Name = "wallhack";
            this.wallhack.Size = new System.Drawing.Size(90, 23);
            this.wallhack.TabIndex = 3;
            this.wallhack.Text = "Wall hack";
            this.wallhack.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.wallhack_CheckedChanged);
            // 
            // console
            // 
            this.console.Checked = false;
            this.console.Enabled = false;
            this.console.Location = new System.Drawing.Point(166, 47);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(75, 23);
            this.console.TabIndex = 7;
            this.console.Text = "Console";
            this.console.CheckedChanged += new NSCheckBox.CheckedChangedEventHandler(this.nsCheckBox1_CheckedChanged);
            // 
            // sendname
            // 
            this.sendname.Enabled = false;
            this.sendname.Location = new System.Drawing.Point(235, 102);
            this.sendname.Name = "sendname";
            this.sendname.Size = new System.Drawing.Size(32, 23);
            this.sendname.TabIndex = 6;
            this.sendname.Text = ">";
            this.sendname.Click += new System.EventHandler(this.nsButton1_Click_1);
            // 
            // namebox
            // 
            this.namebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.Enabled = false;
            this.namebox.Location = new System.Drawing.Point(101, 102);
            this.namebox.MaxLength = 32767;
            this.namebox.Multiline = false;
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = false;
            this.namebox.Size = new System.Drawing.Size(132, 23);
            this.namebox.TabIndex = 5;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.namebox.UseSystemPasswordChar = false;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel2.Location = new System.Drawing.Point(27, 229);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(82, 18);
            this.nsLabel2.TabIndex = 4;
            this.nsLabel2.Text = "nsLabel1";
            this.nsLabel2.Value1 = "Player Size:";
            this.nsLabel2.Value2 = "";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(45, 104);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(52, 18);
            this.nsLabel1.TabIndex = 4;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "Name:";
            this.nsLabel1.Value2 = "";
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.ccapibutton);
            this.nsGroupBox1.Controls.Add(this.nsGroupBox2);
            this.nsGroupBox1.Controls.Add(this.connect);
            this.nsGroupBox1.Controls.Add(this.ipbox);
            this.nsGroupBox1.Controls.Add(this.tmapi);
            this.nsGroupBox1.DrawSeperator = false;
            this.nsGroupBox1.Location = new System.Drawing.Point(12, 34);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(290, 59);
            this.nsGroupBox1.SubTitle = "Control Panel";
            this.nsGroupBox1.TabIndex = 2;
            this.nsGroupBox1.Text = "nsGroupBox1";
            this.nsGroupBox1.Title = "";
            // 
            // ccapibutton
            // 
            this.ccapibutton.Checked = false;
            this.ccapibutton.Location = new System.Drawing.Point(73, 21);
            this.ccapibutton.Name = "ccapibutton";
            this.ccapibutton.Size = new System.Drawing.Size(63, 23);
            this.ccapibutton.TabIndex = 11;
            this.ccapibutton.Text = "CCAPI";
            this.ccapibutton.CheckedChanged += new NSRadioButton.CheckedChangedEventHandler(this.ccapibutton_CheckedChanged);
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.DrawSeperator = false;
            this.nsGroupBox2.Location = new System.Drawing.Point(73, 62);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(111, 78);
            this.nsGroupBox2.SubTitle = "";
            this.nsGroupBox2.TabIndex = 10;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "Mods";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(237, 21);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(39, 23);
            this.connect.TabIndex = 5;
            this.connect.Text = ">>";
            this.connect.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // ipbox
            // 
            this.ipbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipbox.Location = new System.Drawing.Point(142, 21);
            this.ipbox.MaxLength = 32767;
            this.ipbox.Multiline = false;
            this.ipbox.Name = "ipbox";
            this.ipbox.ReadOnly = false;
            this.ipbox.Size = new System.Drawing.Size(89, 23);
            this.ipbox.TabIndex = 3;
            this.ipbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ipbox.UseSystemPasswordChar = false;
            this.ipbox.Visible = false;
            // 
            // tmapi
            // 
            this.tmapi.Checked = false;
            this.tmapi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tmapi.Location = new System.Drawing.Point(3, 21);
            this.tmapi.Name = "tmapi";
            this.tmapi.Size = new System.Drawing.Size(64, 23);
            this.tmapi.TabIndex = 3;
            this.tmapi.Text = "TMAPI";
            this.tmapi.CheckedChanged += new NSRadioButton.CheckedChangedEventHandler(this.tmapi_CheckedChanged);
            // 
            // nsControlButton2
            // 
            this.nsControlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton2.ControlButton = NSControlButton.Button.Minimize;
            this.nsControlButton2.Location = new System.Drawing.Point(278, 3);
            this.nsControlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton2.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.Name = "nsControlButton2";
            this.nsControlButton2.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton2.TabIndex = 1;
            this.nsControlButton2.Text = "nsControlButton2";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(296, 3);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 0;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chat box size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 315);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.nsGroupBox3.ResumeLayout(false);
            this.nsGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSGroupBox nsGroupBox1;
        private NSRadioButton tmapi;
        private NSControlButton nsControlButton2;
        private NSControlButton nsControlButton1;
        private NSTextBox ipbox;
        private NSButton connect;
        private NSCheckBox wallhack;
        private NSButton sendname;
        private NSTextBox namebox;
        private NSLabel nsLabel1;
        private NSCheckBox console;
        private NSCheckBox admin;
        private NSCheckBox action;
        private NSGroupBox nsGroupBox3;
        private NSGroupBox nsGroupBox2;
        private NSRadioButton ccapibutton;
        private NSCheckBox channel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private NSComboBox size;
        private NSLabel nsLabel2;
        private NSTrackBar chat;
        private System.Windows.Forms.Label label1;
    }
}

