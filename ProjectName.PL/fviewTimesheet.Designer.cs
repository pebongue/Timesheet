namespace Aculocity.ProjectName.PL
{
    partial class fviewTimesheet
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
            if (disposing && (m_components != null))
            {
                m_components.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ddlWorkCategory = new System.Windows.Forms.ComboBox();
            this.ddlCompany = new System.Windows.Forms.ComboBox();
            this.cbBillable = new System.Windows.Forms.CheckBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lstWorkingTask = new System.Windows.Forms.ListBox();
            this.cmdStartStopTime = new System.Windows.Forms.Button();
            this.gbWorkingTask = new System.Windows.Forms.GroupBox();
            this.gbOtherTasks = new System.Windows.Forms.GroupBox();
            this.lstOtherTasks = new System.Windows.Forms.ListBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.pnlChgTime = new System.Windows.Forms.Panel();
            this.toolTipTS = new System.Windows.Forms.ToolTip(this.components);
            this.systemTimer = new System.Timers.Timer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbWorkingTask.SuspendLayout();
            this.gbOtherTasks.SuspendLayout();
            this.pnlChgTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logOutToolStripMenuItem.Text = "Log &Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDataToolStripMenuItem,
            this.timesheetOnlineToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewDataToolStripMenuItem.Text = "&View Data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // timesheetOnlineToolStripMenuItem
            // 
            this.timesheetOnlineToolStripMenuItem.Name = "timesheetOnlineToolStripMenuItem";
            this.timesheetOnlineToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.timesheetOnlineToolStripMenuItem.Text = "&Timesheet Online";
            this.timesheetOnlineToolStripMenuItem.Click += new System.EventHandler(this.timesheetOnlineToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusInfo
            // 
            this.toolStripStatusInfo.Name = "toolStripStatusInfo";
            this.toolStripStatusInfo.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusInfo.Text = "Status bar";
            // 
            // ddlWorkCategory
            // 
            this.ddlWorkCategory.FormattingEnabled = true;
            this.ddlWorkCategory.Location = new System.Drawing.Point(12, 95);
            this.ddlWorkCategory.MaxDropDownItems = 10;
            this.ddlWorkCategory.Name = "ddlWorkCategory";
            this.ddlWorkCategory.Size = new System.Drawing.Size(238, 21);
            this.ddlWorkCategory.TabIndex = 2;
            this.ddlWorkCategory.Text = "Select Work Category";
            this.ddlWorkCategory.SelectedValueChanged += new System.EventHandler(this.ddlWorkCategory_SelectedValueChanged);
            // 
            // ddlCompany
            // 
            this.ddlCompany.FormattingEnabled = true;
            this.ddlCompany.Location = new System.Drawing.Point(12, 122);
            this.ddlCompany.Name = "ddlCompany";
            this.ddlCompany.Size = new System.Drawing.Size(238, 21);
            this.ddlCompany.Sorted = true;
            this.ddlCompany.TabIndex = 3;
            this.ddlCompany.Text = "Select Company";
            // 
            // cbBillable
            // 
            this.cbBillable.AutoSize = true;
            this.cbBillable.Location = new System.Drawing.Point(20, 34);
            this.cbBillable.Name = "cbBillable";
            this.cbBillable.Size = new System.Drawing.Size(59, 17);
            this.cbBillable.TabIndex = 4;
            this.cbBillable.Text = "Billable";
            this.cbBillable.UseVisualStyleBackColor = true;
            // 
            // txtStartTime
            // 
            this.txtStartTime.BackColor = System.Drawing.Color.White;
            this.txtStartTime.Location = new System.Drawing.Point(20, 3);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(111, 20);
            this.txtStartTime.TabIndex = 2;
            this.txtStartTime.Text = "Start Time";
            this.toolTipTS.SetToolTip(this.txtStartTime, "start time");
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDuration.Location = new System.Drawing.Point(20, 99);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(111, 20);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.Text = "Duration";
            this.toolTipTS.SetToolTip(this.txtDuration, "time spent on current task");
            // 
            // lstWorkingTask
            // 
            this.lstWorkingTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstWorkingTask.FormattingEnabled = true;
            this.lstWorkingTask.HorizontalScrollbar = true;
            this.lstWorkingTask.Location = new System.Drawing.Point(6, 30);
            this.lstWorkingTask.Name = "lstWorkingTask";
            this.lstWorkingTask.Size = new System.Drawing.Size(448, 134);
            this.lstWorkingTask.TabIndex = 8;
            this.lstWorkingTask.SelectedIndexChanged += new System.EventHandler(this.lstWorkingTask_SelectedIndexChanged);
            // 
            // cmdStartStopTime
            // 
            this.cmdStartStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStartStopTime.Location = new System.Drawing.Point(20, 146);
            this.cmdStartStopTime.Name = "cmdStartStopTime";
            this.cmdStartStopTime.Size = new System.Drawing.Size(111, 23);
            this.cmdStartStopTime.TabIndex = 7;
            this.cmdStartStopTime.Text = "Start Time";
            this.cmdStartStopTime.UseVisualStyleBackColor = true;
            this.cmdStartStopTime.Click += new System.EventHandler(this.cmdStartStopTime_Click);
            // 
            // gbWorkingTask
            // 
            this.gbWorkingTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWorkingTask.Controls.Add(this.lstWorkingTask);
            this.gbWorkingTask.Location = new System.Drawing.Point(12, 305);
            this.gbWorkingTask.Name = "gbWorkingTask";
            this.gbWorkingTask.Size = new System.Drawing.Size(460, 183);
            this.gbWorkingTask.TabIndex = 10;
            this.gbWorkingTask.TabStop = false;
            this.gbWorkingTask.Text = "Working Tasks";
            // 
            // gbOtherTasks
            // 
            this.gbOtherTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOtherTasks.Controls.Add(this.lstOtherTasks);
            this.gbOtherTasks.Location = new System.Drawing.Point(12, 543);
            this.gbOtherTasks.Name = "gbOtherTasks";
            this.gbOtherTasks.Size = new System.Drawing.Size(460, 152);
            this.gbOtherTasks.TabIndex = 11;
            this.gbOtherTasks.TabStop = false;
            this.gbOtherTasks.Text = "Other Tasks";
            // 
            // lstOtherTasks
            // 
            this.lstOtherTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOtherTasks.FormattingEnabled = true;
            this.lstOtherTasks.HorizontalScrollbar = true;
            this.lstOtherTasks.Location = new System.Drawing.Point(6, 19);
            this.lstOtherTasks.Name = "lstOtherTasks";
            this.lstOtherTasks.Size = new System.Drawing.Size(448, 121);
            this.lstOtherTasks.TabIndex = 9;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 149);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(238, 112);
            this.txtComments.TabIndex = 5;
            this.txtComments.Text = "Comments";
            // 
            // pnlChgTime
            // 
            this.pnlChgTime.Controls.Add(this.txtStartTime);
            this.pnlChgTime.Controls.Add(this.cbBillable);
            this.pnlChgTime.Controls.Add(this.txtDuration);
            this.pnlChgTime.Controls.Add(this.cmdStartStopTime);
            this.pnlChgTime.Location = new System.Drawing.Point(272, 95);
            this.pnlChgTime.Name = "pnlChgTime";
            this.pnlChgTime.Size = new System.Drawing.Size(200, 175);
            this.pnlChgTime.TabIndex = 12;
            // 
            // systemTimer
            // 
            this.systemTimer.Interval = 1000;
            this.systemTimer.SynchronizingObject = this;
            this.systemTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.systemTimer_Elapsed);
            // 
            // fviewTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 730);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlChgTime);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.gbOtherTasks);
            this.Controls.Add(this.gbWorkingTask);
            this.Controls.Add(this.ddlCompany);
            this.Controls.Add(this.ddlWorkCategory);
            this.Controls.Add(this.statusStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Aculocity.ProjectName.PL.Properties.Settings.Default, "ParentLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::Aculocity.ProjectName.PL.Properties.Settings.Default.ParentLocation;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fviewTimesheet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Aculocity Timesheets - [User Name]";
            this.Load += new System.EventHandler(this.fviewTimesheet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbWorkingTask.ResumeLayout(false);
            this.gbOtherTasks.ResumeLayout(false);
            this.pnlChgTime.ResumeLayout(false);
            this.pnlChgTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInfo;
        private System.Windows.Forms.ComboBox ddlWorkCategory;
        private System.Windows.Forms.ComboBox ddlCompany;
        private System.Windows.Forms.CheckBox cbBillable;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ListBox lstWorkingTask;
        private System.Windows.Forms.Button cmdStartStopTime;
        private System.Windows.Forms.GroupBox gbWorkingTask;
        private System.Windows.Forms.GroupBox gbOtherTasks;
        private System.Windows.Forms.ListBox lstOtherTasks;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetOnlineToolStripMenuItem;
        private System.Windows.Forms.Panel pnlChgTime;
        private System.Windows.Forms.ToolTip toolTipTS;
        private System.Timers.Timer systemTimer;
    }
}