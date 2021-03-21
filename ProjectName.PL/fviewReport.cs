using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Aculocity.ProjectName.BLL;
using System.Collections;
using System.Xml.Serialization;

namespace Aculocity.ProjectName.PL
{
    public partial class fviewReport : Form
    {
        /// <summary>
        /// Initialise component and display the name of the current user
        /// </summary>
        public fviewReport()
        {
            InitializeComponent();

            this.Text = "Aculocity Timesheet - " + System.Environment.UserName;
        }

        /// <summary>
        /// Name of the test file used to load/save the customer object.
        /// </summary>
        private const String _xmlFileName = "TimeSheet.xml";
        private TimesheetBLL _timeSheetBLL = new TimesheetBLL();

        private ArrayList _columnToShow;

        #region: Upload to server
        private void cmdUploadToSrv_Click(object sender, EventArgs e)
        {
            ControlCollection controlTSData = (ControlCollection)pnlHostTSData.Controls;

            ControlToDataTable(controlTSData);
        }
        private void ControlToDataTable(ControlCollection ctrlTSData)
        {
            for (int x = 0; x < ctrlTSData.Count; x++)
            {
                if (ctrlTSData[x] is ListView)
                {
                    ListView timesheetData = (ListView)ctrlTSData[x];

                }
            }
        }
        #endregion

        #region: Export to csv
        #endregion

        #region: Load listview timesheet
        /// <summary>
        /// load timesheet data from xml offline storage file to UserTimesheet object
        /// </summary>
        private void LoadTSDataObject()
        {
            DataTable dt = GetOfflineTSData();

            if (dt != null)
            {
                MessageBox.Show("Unable to load timesheet data object from file '" + _xmlFileName + "'!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.LoadTSDataIntoListview(dt);
            }
        }

        /// <summary>
        /// get offline timesheet data from xml file
        /// </summary>
        /// <returns>datatable containing timesheet offline data</returns>
        private DataTable GetOfflineTSData()
        {
            DataTable dt = new DataTable();
            try
            {
                if (!File.Exists(Environment.CurrentDirectory + @"\TimeSheet.xml"))
                {
                    MessageBox.Show("The XML file '" + _xmlFileName + "' does not exist.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FileStream fs = new FileStream(Environment.CurrentDirectory + @"\TimeSheet.xml", FileMode.Open);
                    XmlSerializer xs = new XmlSerializer(typeof(DataSet));
                    dt = ((DataSet)xs.Deserialize(fs)).Tables[0];
                }

            }
            catch (Exception ex)
            {
                _timeSheetBLL.LogExecption(ref ex);
            }
            return dt;
        }

        /// <summary>
        /// load offline timesheet data into listview and display them to the report form
        /// </summary>
        /// <param name="userTSData">data source containin offline timesheet data</param>
        private void LoadTSDataIntoListview(DataTable userTSData)
        {
            //load to the listview
            //SetDataSource(dtbl, _columnsToShow);

            try
            {
                //Random rnd = new Random();
                //int lstviewCount = rnd.Next(2, 6);
                int lblPosY = 17;
                int lstviewControlHeight = 163, lblIncrementPosY = 0;//lstviewControlHeight + 10;
                int lblHeight = 13, lstviewIncrementPosY = 0;//lblHeight + 3;
                int lstviewControlPosY = 33;

                this.pnlHostTSData.Controls.Clear();
                //for (int x = 1; x <= lstviewCount; x++)
                //{
                    Label lblEntryDate = new Label();
                    lblEntryDate.Name = "lblEntryDate";//+ x;
                    lblPosY += lblIncrementPosY;
                    SetEntryDateLabel(lblEntryDate, lblPosY, "Date goes here: ");

                    ListView lstviewTS = new ListView(); //ltvDisplayList.Clear();
                    lstviewTS.View = View.Details;
                    //AddColumnToControl(lstviewTS);

                    for (int i = 0; i < userTSData.Rows.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.SubItems[0].Text = userTSData.Rows[i][_columnToShow[0].ToString()].ToString();
                        for (int j = 1; j < _columnToShow.Count; j++)
                        {
                            listViewItem.SubItems.Add(userTSData.Rows[i][_columnToShow[j].ToString()].ToString());
                        }
                        lstviewTS.Items.Add(listViewItem);
                    }
                    lstviewControlPosY += lstviewIncrementPosY;
                    SetControlProperties(lstviewTS, lstviewControlPosY);
                    SetColumnsToFit(lstviewTS);
                    AddControlToForm(lstviewTS);

                    lblIncrementPosY = lblHeight + 3 + lstviewControlHeight + 10;
                    lstviewIncrementPosY = lstviewControlHeight + 10 + lblHeight + 3;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// set the entry date label for a listview
        /// </summary>
        /// <param name="lblEntryDate">entry date label</param>
        /// <param name="lblPosY">the Y position of the label</param>
        /// <param name="lblText">the label text</param>
        private void SetEntryDateLabel(Label lblEntryDate, int lblPosY, String lblText)
        {
            lblEntryDate.Location = new Point(16, lblPosY);
            lblEntryDate.AutoSize = true;//new Size(120, 13);
            lblEntryDate.Text = "Entry date: " + lblText;
            lblEntryDate.Visible = true;

            this.pnlHostTSData.Controls.Add(lblEntryDate);
        }

        /// <summary>
        /// set the column header on the listview control
        /// </summary>
        private void SetColumnToShow()
        {
            _columnToShow = new ArrayList() { "Company", "WorkCategory", "Comment(s)", "EntryDate", "TimeSpent", "Billable" };
        }

        /// <summary>
        /// add columns header to listview control
        /// </summary>
        /// <param name="ListviewControl">control to add columns to</param>
        private void AddColumnToControl(ListView lstviewControl)
        {
            for (int i = 0; i < _columnToShow.Count; i++)
            {
                System.Windows.Forms.ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = _columnToShow[i].ToString();
                lstviewControl.Columns.Add(columnHeader);
            }
        }
        /// <summary>
        /// add the listview filled of data to the report form
        /// </summary>
        /// <param name="lstviewControl">listview containing the data</param>
        private void AddControlToForm(ListView lstviewControl)
        {
            lstviewControl.Visible = true;
            this.pnlHostTSData.Controls.Add(lstviewControl);
        }
        /// <summary>
        /// set the columns in the listview to autofit
        /// </summary>
        /// <param name="lstviewControl">the listview control</param>
        private void SetColumnsToFit(ListView lstviewControl)
        {
            for (int x = 0; x < lstviewControl.Columns.Count; x++)
            {
                lstviewControl.Columns[x].Width = -2;
            }
        }
        /// <summary>
        /// set the listview properties
        /// </summary>
        /// <param name="lstviewControl">listview control</param>
        /// <param name="nameIndex">the n-th listview control</param>
        /// <param name="lstviewPosY">the listview control Y position</param>
        private void SetControlProperties(ListView lstviewControl, int lstviewPosY)
        {
            lstviewControl.Name = "lstviewTS";
            lstviewControl.Size = new Size(511, 163);
            lstviewControl.Location = new Point(16, lstviewPosY);
            lstviewControl.GridLines = true;
            //lstviewControl.Anchor = AnchorStyles.Top; //Left; Right;
            //lstviewControl.Anchor = AnchorStyles.Left;
            //lstviewControl.Anchor = AnchorStyles.Right;
        }
        #endregion

        #region: common code
        /// <summary>
        /// Close the report window without committing any task
        /// </summary>
        private void cmdCancelReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// TODO: keep the content align in the form
        /// </summary>
        private void fviewReport_Resize(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// form report load event
        /// </summary>
        /// <param name="sender">envent sender</param>
        /// <param name="e">event argument</param>
        private void OnLoad(object sender, EventArgs e)
        {
            SetColumnToShow();
            LoadTSDataObject();
        }
        #endregion
    }
}
