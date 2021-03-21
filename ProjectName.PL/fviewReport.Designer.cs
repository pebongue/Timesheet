namespace Aculocity.ProjectName.PL
{
    partial class fviewReport
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
            this.lblReportHeading = new System.Windows.Forms.Label();
            this.cmdUploadToSrv = new System.Windows.Forms.Button();
            this.cmdExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancelReport = new System.Windows.Forms.Button();
            this.pnlRepHeader = new System.Windows.Forms.Panel();
            this.pnlHostTSData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlRepHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReportHeading
            // 
            this.lblReportHeading.AutoSize = true;
            this.lblReportHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportHeading.Location = new System.Drawing.Point(15, 23);
            this.lblReportHeading.Name = "lblReportHeading";
            this.lblReportHeading.Size = new System.Drawing.Size(255, 20);
            this.lblReportHeading.TabIndex = 0;
            this.lblReportHeading.Text = "Timesheets Entries to be uploaded";
            // 
            // cmdUploadToSrv
            // 
            this.cmdUploadToSrv.Location = new System.Drawing.Point(335, 20);
            this.cmdUploadToSrv.Name = "cmdUploadToSrv";
            this.cmdUploadToSrv.Size = new System.Drawing.Size(102, 29);
            this.cmdUploadToSrv.TabIndex = 1;
            this.cmdUploadToSrv.Text = "Upload to Server";
            this.cmdUploadToSrv.UseVisualStyleBackColor = true;
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(455, 20);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(75, 29);
            this.cmdExport.TabIndex = 2;
            this.cmdExport.Text = "Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCancelReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 61);
            this.panel1.TabIndex = 3;
            // 
            // cmdCancelReport
            // 
            this.cmdCancelReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancelReport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelReport.Location = new System.Drawing.Point(455, 20);
            this.cmdCancelReport.Name = "cmdCancelReport";
            this.cmdCancelReport.Size = new System.Drawing.Size(75, 29);
            this.cmdCancelReport.TabIndex = 0;
            this.cmdCancelReport.Text = "Cancel";
            this.cmdCancelReport.UseVisualStyleBackColor = true;
            this.cmdCancelReport.Click += new System.EventHandler(this.cmdCancelReport_Click);
            // 
            // pnlRepHeader
            // 
            this.pnlRepHeader.Controls.Add(this.lblReportHeading);
            this.pnlRepHeader.Controls.Add(this.cmdUploadToSrv);
            this.pnlRepHeader.Controls.Add(this.cmdExport);
            this.pnlRepHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlRepHeader.Name = "pnlRepHeader";
            this.pnlRepHeader.Size = new System.Drawing.Size(599, 65);
            this.pnlRepHeader.TabIndex = 4;
            // 
            // pnlHostTSData
            // 
            this.pnlHostTSData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHostTSData.AutoScroll = true;
            this.pnlHostTSData.Location = new System.Drawing.Point(1, 65);
            this.pnlHostTSData.Name = "pnlHostTSData";
            this.pnlHostTSData.Size = new System.Drawing.Size(566, 408);
            this.pnlHostTSData.TabIndex = 5;
            // 
            // fviewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancelReport;
            this.ClientSize = new System.Drawing.Size(599, 540);
            this.Controls.Add(this.pnlHostTSData);
            this.Controls.Add(this.pnlRepHeader);
            this.Controls.Add(this.panel1);
            this.Name = "fviewReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Aculocity Timesheets - [User name]";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.pnlRepHeader.ResumeLayout(false);
            this.pnlRepHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReportHeading;
        private System.Windows.Forms.Button cmdUploadToSrv;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCancelReport;
        private System.Windows.Forms.Panel pnlRepHeader;
        private System.Windows.Forms.Panel pnlHostTSData;
    }
}