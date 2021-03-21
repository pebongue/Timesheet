namespace Aculocity.ProjectName.PL
{
    partial class fviewSettings
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
            this.gbSetTimer = new System.Windows.Forms.GroupBox();
            this.radShowReminder = new System.Windows.Forms.RadioButton();
            this.radDontShowReminder = new System.Windows.Forms.RadioButton();
            this.lblMinute = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.lblSetTimer = new System.Windows.Forms.Label();
            this.gbDBSetting = new System.Windows.Forms.GroupBox();
            this.cblSetUsernamePwd = new System.Windows.Forms.CheckBox();
            this.cmdRefreshSrv = new System.Windows.Forms.Button();
            this.ddlDatabase = new System.Windows.Forms.ComboBox();
            this.ddlServer = new System.Windows.Forms.ComboBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cblPassword = new System.Windows.Forms.CheckBox();
            this.lblCfrmPwd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDBName = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.gbWTaskSetting = new System.Windows.Forms.GroupBox();
            this.cmdRemoveAllWT = new System.Windows.Forms.Button();
            this.cmdRemoveWT = new System.Windows.Forms.Button();
            this.cmdAddAllWT = new System.Windows.Forms.Button();
            this.cmdAddWT = new System.Windows.Forms.Button();
            this.lblSelectedWT = new System.Windows.Forms.Label();
            this.lblAvailWT = new System.Windows.Forms.Label();
            this.lstSelectedWT = new System.Windows.Forms.ListBox();
            this.lstAvailableWT = new System.Windows.Forms.ListBox();
            this.pnlSettingsBtn = new System.Windows.Forms.Panel();
            this.btnReloadAvailable = new System.Windows.Forms.Button();
            this.cmdSettingCancel = new System.Windows.Forms.Button();
            this.cmdSettingSave = new System.Windows.Forms.Button();
            this.gbWebAddress = new System.Windows.Forms.GroupBox();
            this.txtEnterURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCtrlSettings = new System.Windows.Forms.TabControl();
            this.tabServerAccess = new System.Windows.Forms.TabPage();
            this.tabWorkingTask = new System.Windows.Forms.TabPage();
            this.tabGenSettings = new System.Windows.Forms.TabPage();
            this.gbSetTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.gbDBSetting.SuspendLayout();
            this.gbWTaskSetting.SuspendLayout();
            this.pnlSettingsBtn.SuspendLayout();
            this.gbWebAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tabCtrlSettings.SuspendLayout();
            this.tabServerAccess.SuspendLayout();
            this.tabWorkingTask.SuspendLayout();
            this.tabGenSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetTimer
            // 
            this.gbSetTimer.Controls.Add(this.radShowReminder);
            this.gbSetTimer.Controls.Add(this.radDontShowReminder);
            this.gbSetTimer.Controls.Add(this.lblMinute);
            this.gbSetTimer.Controls.Add(this.numericUpDownMin);
            this.gbSetTimer.Controls.Add(this.lblSetTimer);
            this.gbSetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSetTimer.Location = new System.Drawing.Point(6, 29);
            this.gbSetTimer.Name = "gbSetTimer";
            this.gbSetTimer.Size = new System.Drawing.Size(620, 183);
            this.gbSetTimer.TabIndex = 0;
            this.gbSetTimer.TabStop = false;
            this.gbSetTimer.Text = "Set Time Reminder";
            // 
            // radShowReminder
            // 
            this.radShowReminder.AutoSize = true;
            this.radShowReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radShowReminder.Location = new System.Drawing.Point(37, 77);
            this.radShowReminder.Name = "radShowReminder";
            this.radShowReminder.Size = new System.Drawing.Size(278, 21);
            this.radShowReminder.TabIndex = 12;
            this.radShowReminder.Text = "&Enable timer and show reminder window";
            this.radShowReminder.UseVisualStyleBackColor = true;
            this.radShowReminder.CheckedChanged += new System.EventHandler(this.radDontShowReminder_CheckedChanged);
            // 
            // radDontShowReminder
            // 
            this.radDontShowReminder.AutoSize = true;
            this.radDontShowReminder.Checked = true;
            this.radDontShowReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radDontShowReminder.Location = new System.Drawing.Point(37, 49);
            this.radDontShowReminder.Name = "radDontShowReminder";
            this.radDontShowReminder.Size = new System.Drawing.Size(213, 21);
            this.radDontShowReminder.TabIndex = 11;
            this.radDontShowReminder.TabStop = true;
            this.radDontShowReminder.Text = "Do not show reminder window";
            this.radDontShowReminder.UseVisualStyleBackColor = true;
            this.radDontShowReminder.CheckedChanged += new System.EventHandler(this.radDontShowReminder_CheckedChanged);
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMinute.Location = new System.Drawing.Point(312, 112);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(57, 17);
            this.lblMinute.TabIndex = 10;
            this.lblMinute.Text = "Minutes";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(261, 103);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(45, 26);
            this.numericUpDownMin.TabIndex = 9;
            this.numericUpDownMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // lblSetTimer
            // 
            this.lblSetTimer.AutoSize = true;
            this.lblSetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTimer.Location = new System.Drawing.Point(77, 112);
            this.lblSetTimer.Name = "lblSetTimer";
            this.lblSetTimer.Size = new System.Drawing.Size(178, 17);
            this.lblSetTimer.TabIndex = 0;
            this.lblSetTimer.Text = "&Remind me on a task after:";
            // 
            // gbDBSetting
            // 
            this.gbDBSetting.Controls.Add(this.cblSetUsernamePwd);
            this.gbDBSetting.Controls.Add(this.cmdRefreshSrv);
            this.gbDBSetting.Controls.Add(this.ddlDatabase);
            this.gbDBSetting.Controls.Add(this.ddlServer);
            this.gbDBSetting.Controls.Add(this.txtConfirmPwd);
            this.gbDBSetting.Controls.Add(this.txtPassword);
            this.gbDBSetting.Controls.Add(this.txtUsername);
            this.gbDBSetting.Controls.Add(this.cblPassword);
            this.gbDBSetting.Controls.Add(this.lblCfrmPwd);
            this.gbDBSetting.Controls.Add(this.lblUsername);
            this.gbDBSetting.Controls.Add(this.lblDBName);
            this.gbDBSetting.Controls.Add(this.lblServerName);
            this.gbDBSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDBSetting.Location = new System.Drawing.Point(6, 22);
            this.gbDBSetting.Name = "gbDBSetting";
            this.gbDBSetting.Size = new System.Drawing.Size(620, 385);
            this.gbDBSetting.TabIndex = 1;
            this.gbDBSetting.TabStop = false;
            // 
            // cblSetUsernamePwd
            // 
            this.cblSetUsernamePwd.AutoSize = true;
            this.cblSetUsernamePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cblSetUsernamePwd.Location = new System.Drawing.Point(23, 156);
            this.cblSetUsernamePwd.Name = "cblSetUsernamePwd";
            this.cblSetUsernamePwd.Size = new System.Drawing.Size(207, 21);
            this.cblSetUsernamePwd.TabIndex = 10;
            this.cblSetUsernamePwd.Text = "S&et username and password";
            this.cblSetUsernamePwd.UseVisualStyleBackColor = true;
            this.cblSetUsernamePwd.CheckedChanged += new System.EventHandler(this.cblSetUsernamePwd_CheckedChanged_1);
            // 
            // cmdRefreshSrv
            // 
            this.cmdRefreshSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefreshSrv.Location = new System.Drawing.Point(523, 41);
            this.cmdRefreshSrv.Name = "cmdRefreshSrv";
            this.cmdRefreshSrv.Size = new System.Drawing.Size(75, 24);
            this.cmdRefreshSrv.TabIndex = 9;
            this.cmdRefreshSrv.Text = "&Refresh";
            this.cmdRefreshSrv.UseVisualStyleBackColor = true;
            this.cmdRefreshSrv.Click += new System.EventHandler(this.cmdRefreshSrv_Click);
            // 
            // ddlDatabase
            // 
            this.ddlDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ddlDatabase.FormattingEnabled = true;
            this.ddlDatabase.Location = new System.Drawing.Point(179, 76);
            this.ddlDatabase.Name = "ddlDatabase";
            this.ddlDatabase.Size = new System.Drawing.Size(338, 24);
            this.ddlDatabase.TabIndex = 8;
            this.ddlDatabase.SelectedValueChanged += new System.EventHandler(this.ddlServer_SelectedValueChanged_1);
            this.ddlDatabase.DropDown += new System.EventHandler(this.ddlDatabase_DropDown);
            // 
            // ddlServer
            // 
            this.ddlServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ddlServer.FormattingEnabled = true;
            this.ddlServer.Location = new System.Drawing.Point(179, 43);
            this.ddlServer.Name = "ddlServer";
            this.ddlServer.Size = new System.Drawing.Size(338, 24);
            this.ddlServer.TabIndex = 7;
            this.ddlServer.SelectedValueChanged += new System.EventHandler(this.ddlServer_SelectedValueChanged_1);
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmPwd.Location = new System.Drawing.Point(179, 255);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Size = new System.Drawing.Size(338, 23);
            this.txtConfirmPwd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtConfirmPwd, "Confirm the same password");
            this.txtConfirmPwd.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(179, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(338, 23);
            this.txtPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPassword, "Set password");
            this.txtPassword.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.Location = new System.Drawing.Point(179, 191);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(338, 23);
            this.txtUsername.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUsername, "Enter username to use when connecting to the server");
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cblPassword
            // 
            this.cblPassword.AutoSize = true;
            this.cblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblPassword.Location = new System.Drawing.Point(23, 226);
            this.cblPassword.Name = "cblPassword";
            this.cblPassword.Size = new System.Drawing.Size(157, 21);
            this.cblPassword.TabIndex = 5;
            this.cblPassword.Text = "Pass&word Protected:";
            this.toolTip1.SetToolTip(this.cblPassword, "Hide pasword");
            this.cblPassword.UseVisualStyleBackColor = true;
            this.cblPassword.CheckedChanged += new System.EventHandler(this.cblSetUsernamePwd_CheckedChanged_1);
            // 
            // lblCfrmPwd
            // 
            this.lblCfrmPwd.AutoSize = true;
            this.lblCfrmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfrmPwd.Location = new System.Drawing.Point(51, 261);
            this.lblCfrmPwd.Name = "lblCfrmPwd";
            this.lblCfrmPwd.Size = new System.Drawing.Size(125, 17);
            this.lblCfrmPwd.TabIndex = 4;
            this.lblCfrmPwd.Text = "Confir&m Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(96, 197);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "&Username:";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBName.Location = new System.Drawing.Point(96, 83);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(77, 17);
            this.lblDBName.TabIndex = 1;
            this.lblDBName.Text = "&Database :";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(115, 49);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(58, 17);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "&Server :";
            // 
            // gbWTaskSetting
            // 
            this.gbWTaskSetting.Controls.Add(this.cmdRemoveAllWT);
            this.gbWTaskSetting.Controls.Add(this.cmdRemoveWT);
            this.gbWTaskSetting.Controls.Add(this.cmdAddAllWT);
            this.gbWTaskSetting.Controls.Add(this.cmdAddWT);
            this.gbWTaskSetting.Controls.Add(this.lblSelectedWT);
            this.gbWTaskSetting.Controls.Add(this.lblAvailWT);
            this.gbWTaskSetting.Controls.Add(this.lstSelectedWT);
            this.gbWTaskSetting.Controls.Add(this.lstAvailableWT);
            this.gbWTaskSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWTaskSetting.Location = new System.Drawing.Point(6, 6);
            this.gbWTaskSetting.Name = "gbWTaskSetting";
            this.gbWTaskSetting.Size = new System.Drawing.Size(620, 404);
            this.gbWTaskSetting.TabIndex = 2;
            this.gbWTaskSetting.TabStop = false;
            // 
            // cmdRemoveAllWT
            // 
            this.cmdRemoveAllWT.Location = new System.Drawing.Point(282, 295);
            this.cmdRemoveAllWT.Name = "cmdRemoveAllWT";
            this.cmdRemoveAllWT.Size = new System.Drawing.Size(60, 29);
            this.cmdRemoveAllWT.TabIndex = 7;
            this.cmdRemoveAllWT.Text = "<<";
            this.cmdRemoveAllWT.UseVisualStyleBackColor = true;
            this.cmdRemoveAllWT.Click += new System.EventHandler(this.cmdRemoveAllWT_Click);
            // 
            // cmdRemoveWT
            // 
            this.cmdRemoveWT.Location = new System.Drawing.Point(282, 260);
            this.cmdRemoveWT.Name = "cmdRemoveWT";
            this.cmdRemoveWT.Size = new System.Drawing.Size(60, 29);
            this.cmdRemoveWT.TabIndex = 6;
            this.cmdRemoveWT.Text = "<";
            this.cmdRemoveWT.UseVisualStyleBackColor = true;
            this.cmdRemoveWT.Click += new System.EventHandler(this.cmdRemoveWT_Click);
            // 
            // cmdAddAllWT
            // 
            this.cmdAddAllWT.Location = new System.Drawing.Point(282, 146);
            this.cmdAddAllWT.Name = "cmdAddAllWT";
            this.cmdAddAllWT.Size = new System.Drawing.Size(60, 29);
            this.cmdAddAllWT.TabIndex = 5;
            this.cmdAddAllWT.Text = ">>";
            this.cmdAddAllWT.UseVisualStyleBackColor = true;
            this.cmdAddAllWT.Click += new System.EventHandler(this.cmdAddAllWT_Click);
            // 
            // cmdAddWT
            // 
            this.cmdAddWT.Location = new System.Drawing.Point(282, 111);
            this.cmdAddWT.Name = "cmdAddWT";
            this.cmdAddWT.Size = new System.Drawing.Size(60, 29);
            this.cmdAddWT.TabIndex = 4;
            this.cmdAddWT.Text = ">";
            this.cmdAddWT.UseVisualStyleBackColor = true;
            this.cmdAddWT.Click += new System.EventHandler(this.cmdAddWT_Click);
            // 
            // lblSelectedWT
            // 
            this.lblSelectedWT.AutoSize = true;
            this.lblSelectedWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedWT.Location = new System.Drawing.Point(345, 34);
            this.lblSelectedWT.Name = "lblSelectedWT";
            this.lblSelectedWT.Size = new System.Drawing.Size(169, 17);
            this.lblSelectedWT.TabIndex = 3;
            this.lblSelectedWT.Text = "Selected &Work Category :";
            // 
            // lblAvailWT
            // 
            this.lblAvailWT.AutoSize = true;
            this.lblAvailWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailWT.Location = new System.Drawing.Point(6, 34);
            this.lblAvailWT.Name = "lblAvailWT";
            this.lblAvailWT.Size = new System.Drawing.Size(171, 17);
            this.lblAvailWT.TabIndex = 2;
            this.lblAvailWT.Text = "&Available Work Category :";
            // 
            // lstSelectedWT
            // 
            this.lstSelectedWT.FormattingEnabled = true;
            this.lstSelectedWT.HorizontalScrollbar = true;
            this.lstSelectedWT.ItemHeight = 20;
            this.lstSelectedWT.Location = new System.Drawing.Point(348, 54);
            this.lstSelectedWT.Name = "lstSelectedWT";
            this.lstSelectedWT.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedWT.Size = new System.Drawing.Size(266, 324);
            this.lstSelectedWT.Sorted = true;
            this.lstSelectedWT.TabIndex = 1;
            this.lstSelectedWT.ClientSizeChanged += new System.EventHandler(this.lstAvailableWT_ClientSizeChanged);
            // 
            // lstAvailableWT
            // 
            this.lstAvailableWT.FormattingEnabled = true;
            this.lstAvailableWT.HorizontalScrollbar = true;
            this.lstAvailableWT.ItemHeight = 20;
            this.lstAvailableWT.Location = new System.Drawing.Point(6, 54);
            this.lstAvailableWT.Name = "lstAvailableWT";
            this.lstAvailableWT.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAvailableWT.Size = new System.Drawing.Size(270, 324);
            this.lstAvailableWT.Sorted = true;
            this.lstAvailableWT.TabIndex = 0;
            this.lstAvailableWT.ClientSizeChanged += new System.EventHandler(this.lstAvailableWT_ClientSizeChanged);
            // 
            // pnlSettingsBtn
            // 
            this.pnlSettingsBtn.Controls.Add(this.btnReloadAvailable);
            this.pnlSettingsBtn.Controls.Add(this.cmdSettingCancel);
            this.pnlSettingsBtn.Controls.Add(this.cmdSettingSave);
            this.pnlSettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettingsBtn.Location = new System.Drawing.Point(0, 460);
            this.pnlSettingsBtn.Name = "pnlSettingsBtn";
            this.pnlSettingsBtn.Size = new System.Drawing.Size(666, 58);
            this.pnlSettingsBtn.TabIndex = 3;
            // 
            // btnReloadAvailable
            // 
            this.btnReloadAvailable.Location = new System.Drawing.Point(370, 17);
            this.btnReloadAvailable.Name = "btnReloadAvailable";
            this.btnReloadAvailable.Size = new System.Drawing.Size(93, 29);
            this.btnReloadAvailable.TabIndex = 10;
            this.btnReloadAvailable.Text = "&Reload Work";
            this.btnReloadAvailable.UseVisualStyleBackColor = true;
            this.btnReloadAvailable.Click += new System.EventHandler(this.btnReloadAvailable_Click);
            // 
            // cmdSettingCancel
            // 
            this.cmdSettingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSettingCancel.Location = new System.Drawing.Point(573, 17);
            this.cmdSettingCancel.Name = "cmdSettingCancel";
            this.cmdSettingCancel.Size = new System.Drawing.Size(75, 29);
            this.cmdSettingCancel.TabIndex = 9;
            this.cmdSettingCancel.Text = "&Close";
            this.cmdSettingCancel.UseVisualStyleBackColor = true;
            this.cmdSettingCancel.Click += new System.EventHandler(this.cmdSettingCancel_Click);
            // 
            // cmdSettingSave
            // 
            this.cmdSettingSave.Location = new System.Drawing.Point(492, 17);
            this.cmdSettingSave.Name = "cmdSettingSave";
            this.cmdSettingSave.Size = new System.Drawing.Size(75, 29);
            this.cmdSettingSave.TabIndex = 8;
            this.cmdSettingSave.Text = "&Save";
            this.cmdSettingSave.UseVisualStyleBackColor = true;
            this.cmdSettingSave.Click += new System.EventHandler(this.cmdSettingSave_Click);
            // 
            // gbWebAddress
            // 
            this.gbWebAddress.Controls.Add(this.txtEnterURL);
            this.gbWebAddress.Controls.Add(this.lblURL);
            this.gbWebAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWebAddress.Location = new System.Drawing.Point(6, 236);
            this.gbWebAddress.Name = "gbWebAddress";
            this.gbWebAddress.Size = new System.Drawing.Size(620, 112);
            this.gbWebAddress.TabIndex = 4;
            this.gbWebAddress.TabStop = false;
            this.gbWebAddress.Text = "Online Timesheet Web Address";
            // 
            // txtEnterURL
            // 
            this.txtEnterURL.Location = new System.Drawing.Point(162, 58);
            this.txtEnterURL.Name = "txtEnterURL";
            this.txtEnterURL.Size = new System.Drawing.Size(338, 26);
            this.txtEnterURL.TabIndex = 6;
            this.txtEnterURL.Text = "http://";
            this.toolTip1.SetToolTip(this.txtEnterURL, "Enter url for the Aculocity Timesheet online");
            this.txtEnterURL.TextChanged += new System.EventHandler(this.txtEnterURL_TextChanged);
            this.txtEnterURL.Validating += new System.ComponentModel.CancelEventHandler(this.txtEnterURL_Validating);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(77, 67);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(79, 17);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "&URL name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tabCtrlSettings
            // 
            this.tabCtrlSettings.Controls.Add(this.tabServerAccess);
            this.tabCtrlSettings.Controls.Add(this.tabWorkingTask);
            this.tabCtrlSettings.Controls.Add(this.tabGenSettings);
            this.tabCtrlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabCtrlSettings.Name = "tabCtrlSettings";
            this.tabCtrlSettings.SelectedIndex = 0;
            this.tabCtrlSettings.Size = new System.Drawing.Size(640, 442);
            this.tabCtrlSettings.TabIndex = 5;
            this.tabCtrlSettings.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlSettings_Selected);
            // 
            // tabServerAccess
            // 
            this.tabServerAccess.BackColor = System.Drawing.SystemColors.Control;
            this.tabServerAccess.Controls.Add(this.gbDBSetting);
            this.tabServerAccess.Location = new System.Drawing.Point(4, 22);
            this.tabServerAccess.Name = "tabServerAccess";
            this.tabServerAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tabServerAccess.Size = new System.Drawing.Size(632, 416);
            this.tabServerAccess.TabIndex = 0;
            this.tabServerAccess.Text = "Server Access";
            // 
            // tabWorkingTask
            // 
            this.tabWorkingTask.BackColor = System.Drawing.SystemColors.Control;
            this.tabWorkingTask.Controls.Add(this.gbWTaskSetting);
            this.tabWorkingTask.Location = new System.Drawing.Point(4, 22);
            this.tabWorkingTask.Name = "tabWorkingTask";
            this.tabWorkingTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkingTask.Size = new System.Drawing.Size(632, 416);
            this.tabWorkingTask.TabIndex = 1;
            this.tabWorkingTask.Text = "Select Working Task";
            // 
            // tabGenSettings
            // 
            this.tabGenSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabGenSettings.Controls.Add(this.gbWebAddress);
            this.tabGenSettings.Controls.Add(this.gbSetTimer);
            this.tabGenSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGenSettings.Name = "tabGenSettings";
            this.tabGenSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenSettings.Size = new System.Drawing.Size(632, 416);
            this.tabGenSettings.TabIndex = 2;
            this.tabGenSettings.Text = "General Settings";
            // 
            // fviewSettings
            // 
            this.AcceptButton = this.cmdSettingSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 518);
            this.Controls.Add(this.tabCtrlSettings);
            this.Controls.Add(this.pnlSettingsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fviewSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aculocity Timesheets - Settings";
            this.Load += new System.EventHandler(this.OnLoad);
            this.gbSetTimer.ResumeLayout(false);
            this.gbSetTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.gbDBSetting.ResumeLayout(false);
            this.gbDBSetting.PerformLayout();
            this.gbWTaskSetting.ResumeLayout(false);
            this.gbWTaskSetting.PerformLayout();
            this.pnlSettingsBtn.ResumeLayout(false);
            this.gbWebAddress.ResumeLayout(false);
            this.gbWebAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tabCtrlSettings.ResumeLayout(false);
            this.tabServerAccess.ResumeLayout(false);
            this.tabWorkingTask.ResumeLayout(false);
            this.tabGenSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetTimer;
        private System.Windows.Forms.Label lblSetTimer;
        private System.Windows.Forms.GroupBox gbDBSetting;
        private System.Windows.Forms.GroupBox gbWTaskSetting;
        private System.Windows.Forms.Panel pnlSettingsBtn;
        private System.Windows.Forms.Button cmdSettingCancel;
        private System.Windows.Forms.Button cmdSettingSave;
        private System.Windows.Forms.Label lblCfrmPwd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.CheckBox cblPassword;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox gbWebAddress;
        private System.Windows.Forms.TextBox txtEnterURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl tabCtrlSettings;
        private System.Windows.Forms.TabPage tabServerAccess;
        private System.Windows.Forms.TabPage tabWorkingTask;
        private System.Windows.Forms.TabPage tabGenSettings;
        private System.Windows.Forms.ListBox lstSelectedWT;
        private System.Windows.Forms.ListBox lstAvailableWT;
        private System.Windows.Forms.Button cmdRemoveAllWT;
        private System.Windows.Forms.Button cmdRemoveWT;
        private System.Windows.Forms.Button cmdAddAllWT;
        private System.Windows.Forms.Button cmdAddWT;
        private System.Windows.Forms.Label lblSelectedWT;
        private System.Windows.Forms.Label lblAvailWT;
        private System.Windows.Forms.ComboBox ddlDatabase;
        private System.Windows.Forms.ComboBox ddlServer;
        private System.Windows.Forms.Button cmdRefreshSrv;
        private System.Windows.Forms.CheckBox cblSetUsernamePwd;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.RadioButton radShowReminder;
        private System.Windows.Forms.RadioButton radDontShowReminder;
        private System.Windows.Forms.Button btnReloadAvailable;
    }
}