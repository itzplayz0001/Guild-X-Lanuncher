namespace Guild_X
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.console = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.manualStartup = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manual = new System.Windows.Forms.ToolTip(this.components);
            this.console.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualStartup)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Left;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(134, 450);
            this.browser.TabIndex = 0;
            this.browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.browser_Navigating);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Controls.Add(this.label11);
            this.console.Controls.Add(this.panel2);
            this.console.Controls.Add(this.label10);
            this.console.Controls.Add(this.time);
            this.console.Controls.Add(this.manualStartup);
            this.console.Controls.Add(this.label9);
            this.console.Controls.Add(this.label8);
            this.console.Controls.Add(this.label7);
            this.console.Controls.Add(this.label6);
            this.console.Controls.Add(this.label5);
            this.console.Controls.Add(this.label4);
            this.console.Controls.Add(this.panel1);
            this.console.Controls.Add(this.label1);
            this.console.Dock = System.Windows.Forms.DockStyle.Right;
            this.console.Location = new System.Drawing.Point(134, 0);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(668, 450);
            this.console.TabIndex = 1;
            this.console.Paint += new System.Windows.Forms.PaintEventHandler(this.console_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(20, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Enabled RPC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(24, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 22);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 18);
            this.panel3.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(360, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estimated Launch Period - 9.28 Seconds ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(159, 71);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(54, 20);
            this.time.TabIndex = 9;
            this.time.Text = "00:00";
            // 
            // manualStartup
            // 
            this.manualStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manualStartup.Image = ((System.Drawing.Image)(resources.GetObject("manualStartup.Image")));
            this.manualStartup.Location = new System.Drawing.Point(624, 1);
            this.manualStartup.Name = "manualStartup";
            this.manualStartup.Size = new System.Drawing.Size(43, 36);
            this.manualStartup.TabIndex = 8;
            this.manualStartup.TabStop = false;
            this.manual.SetToolTip(this.manualStartup, "Manual Launch, Will require browser access.");
            this.manualStartup.Click += new System.EventHandler(this.manualStartup_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(144)))), ((int)(((byte)(207)))));
            this.label9.Location = new System.Drawing.Point(18, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Turning on the client, Please wait";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(18, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Connecting to client\'s website";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "$ node index.js";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(144)))), ((int)(((byte)(207)))));
            this.label6.Location = new System.Drawing.Point(135, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "~";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(121, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(226)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(18, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "app@guild-x";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.githubLink);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(403, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 83);
            this.panel1.TabIndex = 1;
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.githubLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(252)))));
            this.githubLink.Location = new System.Drawing.Point(58, 53);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(135, 20);
            this.githubLink.TabIndex = 2;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "View on GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(66, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "itzplayz0001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Developed By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(18, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged in as Guild X#5742!";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.console);
            this.Controls.Add(this.browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guild X";
            this.Load += new System.EventHandler(this.home_Load);
            this.console.ResumeLayout(false);
            this.console.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manualStartup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Panel console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox manualStartup;
        private System.Windows.Forms.ToolTip manual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
    }
}

