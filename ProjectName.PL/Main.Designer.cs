namespace Aculocity.ProjectName.PL
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbUseIntgSecu = new System.Windows.Forms.CheckBox();
            this.cmdLogIn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgAculocityLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAculocityLogo)).BeginInit();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.logToolStripMenuItem.Text = "Log In";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(14, 214);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(251, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "Username ";
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            this.txtUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserName_MouseClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(14, 255);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password ";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // cbUseIntgSecu
            // 
            this.cbUseIntgSecu.AutoSize = true;
            this.cbUseIntgSecu.Location = new System.Drawing.Point(14, 290);
            this.cbUseIntgSecu.Name = "cbUseIntgSecu";
            this.cbUseIntgSecu.Size = new System.Drawing.Size(137, 17);
            this.cbUseIntgSecu.TabIndex = 4;
            this.cbUseIntgSecu.Text = "Use Integrated Security";
            this.cbUseIntgSecu.UseVisualStyleBackColor = true;
            this.cbUseIntgSecu.CheckedChanged += new System.EventHandler(this.cbUseIntgSecu_CheckedChanged);
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogIn.Location = new System.Drawing.Point(14, 350);
            this.cmdLogIn.Name = "cmdLogIn";
            this.cmdLogIn.Size = new System.Drawing.Size(100, 23);
            this.cmdLogIn.TabIndex = 5;
            this.cmdLogIn.Text = "LogIn";
            this.cmdLogIn.UseVisualStyleBackColor = true;
            this.cmdLogIn.Click += new System.EventHandler(this.bttLogIn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusInfo
            // 
            this.toolStripStatusInfo.Name = "toolStripStatusInfo";
            this.toolStripStatusInfo.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusInfo.Text = "Status bar";
            // 
            // imgAculocityLogo
            // 
            this.imgAculocityLogo.Image = global::Aculocity.ProjectName.PL.Properties.Resources.aculogo;
            this.imgAculocityLogo.Location = new System.Drawing.Point(14, 32);
            this.imgAculocityLogo.Name = "imgAculocityLogo";
            this.imgAculocityLogo.Size = new System.Drawing.Size(406, 119);
            this.imgAculocityLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAculocityLogo.TabIndex = 1;
            this.imgAculocityLogo.TabStop = false;
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.imgAculocityLogo);
            this.pnlLogIn.Controls.Add(this.txtUserName);
            this.pnlLogIn.Controls.Add(this.cmdLogIn);
            this.pnlLogIn.Controls.Add(this.txtPassword);
            this.pnlLogIn.Controls.Add(this.cbUseIntgSecu);
            this.pnlLogIn.Location = new System.Drawing.Point(21, 48);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(433, 584);
            this.pnlLogIn.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 730);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Aculocity Timesheets";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAculocityLogo)).EndInit();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgAculocityLogo;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbUseIntgSecu;
        private System.Windows.Forms.Button cmdLogIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInfo;
        private System.Windows.Forms.Panel pnlLogIn;
    }
}