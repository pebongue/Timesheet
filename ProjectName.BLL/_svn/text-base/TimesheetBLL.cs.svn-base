using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Configuration;
using System.Xml.Serialization;
using Aculocity.ProjectName.DAL;
using System.Data.SqlClient;

namespace Aculocity.ProjectName.BLL
{
    /// <summary>
    /// Description for the Timesheet Business Logic Layer
    /// </summary>
    public class TimesheetBLL
    {
        //reference to the timesheet DAL
        TimesheetDAL m_timeSheetDAL;

        /// <summary>
        /// constructor
        /// </summary>
        public TimesheetBLL()
        {
            m_timeSheetDAL = new TimesheetDAL();
        }

        #region: Timesheet save tasks variable declaration
        private int _userID;
        private DateTime _entryDate;
        private String _workCategory;
        private String _comment;
        private String _company;
        private double _timeSpent;
        private double _billableTime;
        #endregion

        #region: Public API Timesheet save tasks
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                this._userID = value;
            }
        }
        public DateTime EntryDate
        {
            get
            {
                return _entryDate;
            }
            set
            {
                this._entryDate = value;
            }
        }
        public String WorkCategory
        {
            get
            {
                return _workCategory;
            }
            set
            {
                this._workCategory = value;
            }
        }
        public String Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                this._comment = value;
            }
        }
        public String Company
        {
            get
            {
                return _company;
            }
            set
            {
                this._company = value;
            }
        }
        public double TimeSpent
        {
            get
            {
                return _timeSpent;
            }
            set
            {
                this._timeSpent = value;
            }
        }
        public double BillableTime
        {
            get
            {
                return _billableTime;
            }
            set
            {
                this._billableTime = value;
            }
        }
        #endregion

        #region: User login
        /// <summary>
        /// manage login into the database
        /// </summary>
        /// <returns>return the login status</returns>
        public bool UseIntegratedSecu()
        {
            DataSet ds = m_timeSheetDAL.LogInUseIntegratedSecu();

            if (ds == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// verify user log in access
        /// </summary>
        /// <param name="LogInName">user log in name</param>
        /// <param name="Password">user password</param>
        /// <returns>true if user found , else false</returns>
        public bool CheckCredential(String LogInName, String Password)
        {
            DataSet ds = m_timeSheetDAL.UserCredential(LogInName, Password);

            if (ds.Tables.Count == 1)
            {
                FileStream fs = new FileStream(Environment.CurrentDirectory + @"\UserCredential.xml", FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(DataSet));
                xs.Serialize(fs, xs);
                return true;
            }
            return false;
        }
        #endregion

        #region: Timesheet management
        /// <summary>
        /// Load work category data into the combo box
        /// </summary>
        public DataSet LoadWorkCategory()
        {
            DataSet ds;
            FileStream fs;
            //XmlSerializer xs= new XmlSerializer(typeof(DataSet));
            BinaryFormatter bf = new BinaryFormatter();

            if(m_timeSheetDAL.ConnState())
            {
                ds = m_timeSheetDAL.GetWorkCategory();
                fs = new FileStream(Environment.CurrentDirectory + @"\WorkCategory.xml", FileMode.Create);
                bf.Serialize(fs, ds);
            }
            else
            {
                fs = new FileStream(Environment.CurrentDirectory + @"\WorkCategory.xml", FileMode.Open);
                ds = (DataSet) bf.Deserialize(fs);
            }
            return ds;
        }

        /// <summary>
        /// load company name base on selected item from work category list
        /// </summary>
        /// <returns>dataset containing company names order by WorkCatSelctedItem</returns>
        public DataSet LoadCompany() 
        {
            DataSet ds;
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (m_timeSheetDAL.ConnState())
            {
                ds = m_timeSheetDAL.GetCompany();
                fs = new FileStream(Environment.CurrentDirectory +@"\GetCompany.xml", FileMode.Create);
                bf.Serialize(fs, ds);
            }
            else
            {
                fs = new FileStream(Environment.CurrentDirectory + @"\GetCompany.xml", FileMode.Open);
                ds = (DataSet) bf.Deserialize(fs);
            }
            return ds;
        }

        public DataSet LoadTaskInfo(String taskname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds.Tables.Add(m_timeSheetDAL.GetTaskInfo(taskname));
                FileStream fs = new FileStream(Environment.CurrentDirectory + @"\TaskInfo.xml", FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(DataSet));
                xs.Serialize(fs, ds);
                return ds;
            }
            catch(Exception ex)
            {
                LogExecption(ref ex);
            }
            return ds;
        }
    
        /// <summary>
        /// user default issues list
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserIssues()
        {
            DataSet ds = m_timeSheetDAL.GetUserIssues();
            return ds;
        }

        public DataSet GetOtherWorkIssues()
        {
            DataSet ds = m_timeSheetDAL.GetWorkCategory();
            return ds;
        }
        /// <summary>
        /// find the default company name for the selected work category
        /// </summary>
        /// <param name="WorkCatSelctedItem">current selected work category item</param>
        /// <returns></returns>
        public Object FindDefaultCompany(Object WorkCatSelctedItem)
        {
            DataSet ds = LoadWorkCategory();

            DataTable dtbl = ds.Tables[0];
            foreach (DataRow dr in dtbl.Rows)
            {
                if (WorkCatSelctedItem.Equals(dr["TaskName"]))
                {
                    return dr["Company"];
                }
            }
            return null;
        }

        /// <summary>
        /// write back timesheet (task) information to the tblTimesheet
        /// </summary>
        /// <param name="UserID">active user ID</param>
        /// <param name="EntryDate">current task date</param>
        /// <param name="WorkCategory">request ID</param>
        /// <param name="Comment">user comments</param>
        /// <param name="Company">company name</param>
        /// <param name="TimeSpent">time spent on task</param>
        /// <param name="BillableTime">time spent on a billable task</param>
        public void UpdateTimesheet()
        {
            _userID = m_timeSheetDAL.GetUserID();
            m_timeSheetDAL.UpdateTimesheet(_userID, _entryDate, _workCategory, _comment, _company, _timeSpent, _billableTime);
        }
        #endregion

        #region: Common code
        public void LogExecption(ref Exception ThrownException)
        {
            m_timeSheetDAL.LogException(ref ThrownException);
        }

        #endregion
    }
}
