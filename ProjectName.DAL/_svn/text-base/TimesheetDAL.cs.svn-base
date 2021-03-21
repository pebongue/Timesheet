using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;

namespace Aculocity.ProjectName.DAL
{
    /// <summary>
    /// Description for the Timesheet Data Access Layer
    /// </summary>
    public class TimesheetDAL
    {
        private SqlConnection m_cnn;
        
        public TimesheetDAL()
        {
            
        }

        /// <summary>
        /// get and retrieve the list of work category
        /// </summary>
        /// <returns>work category list</returns>
        public DataSet GetWorkCategory()
        {
            DataSet ds = null;
            try
            {
                OpenMasterCnn();

                ds = SqlHelper.ExecuteDataset(m_cnn, CommandType.StoredProcedure, "TSGetWorkCategory", new SqlParameter("@ActiveUserID", GetUserID()));
            }
            catch (Exception ex)
            {
                LogException(ref ex);
            }
            finally
            {
                if (m_cnn.State != ConnectionState.Closed)
                {
                    m_cnn.Close();
                }
            }

            return ds;
        }

        /// <summary>
        /// Checks if Database Connection is possible
        /// </summary>
        /// <returns>Connection State</returns>
        public Boolean ConnState()
        {
            try
            {
                String cnnString = ConfigurationManager.ConnectionStrings["MasterDB"].ConnectionString;
                m_cnn = new SqlConnection(cnnString);
                m_cnn.Open();
                return true;
            }
            catch(Exception ex)
            {
                LogException(ref ex);
                return false;
            }
        }

        public DataTable GetTaskInfo(String taskname)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenMasterCnn();
                dt = SqlHelper.ExecuteDataset(m_cnn, CommandType.StoredProcedure, "GetTaskInformation", new SqlParameter("@ActiveUserID", taskname)).Tables[0];
                return dt;
            }
            catch(Exception ex)
            {
                LogException(ref ex);
            }

            return dt;
        }

        /// <summary>
        /// get and return a list of company
        /// </summary>
        /// <returns>company list</returns>
        public DataSet GetCompany()
        {
            DataSet ds = null;
            try
            {
                OpenMasterCnn();

                ds = SqlHelper.ExecuteDataset(m_cnn, CommandType.StoredProcedure, "TSGetCompanies");
            }
            catch (Exception ex)
            {
                LogException(ref ex);
            }
            finally
            {
                if (m_cnn.State != ConnectionState.Closed)
                {
                    m_cnn.Close();
                }
            }

            return ds;
        }

        /// <summary>
        /// get user default issues
        /// </summary>
        /// <returns>dataset containing user default issues list</returns>
        public DataSet GetUserIssues()
        {
            DataSet ds = null;
            try
            {
                OpenMasterCnn();

                ds = SqlHelper.ExecuteDataset(m_cnn, CommandType.StoredProcedure, "TSGetUserIssues", new SqlParameter("@ActiveUserID", GetUserID()));
            }
            catch (Exception ex)
            {
                LogException(ref ex);
            }
            finally
            {
                if (m_cnn.State != ConnectionState.Closed)
                {
                    m_cnn.Close();
                }
            }

            return ds;
        }

        /// <summary>
        /// set connection string then open the connection
        /// </summary>
        private void OpenMasterCnn()
        {
            try
            {
                String cnnString = ConfigurationManager.ConnectionStrings["MasterDB"].ConnectionString;
                m_cnn = new SqlConnection(cnnString);
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            
            m_cnn.Open();
        }
        
        /// <summary>
        /// close connection
        /// </summary>
        private void CloseMasterCnn()
        {
            m_cnn.Close();
        }
        public void LogException(ref Exception ThrownException)
        {
            using(SqlConnection cnnMasterDB = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterDB"].ConnectionString))
            {
                try
                {
                    SqlHelper.ExecuteNonQuery(cnnMasterDB, "TSLogException",
                    ThrownException.Message,
                    ThrownException.StackTrace,
                    ThrownException.Source,
                    GetUserID());
                }
                catch (SqlException sqlex)
                {
                    //throw ex;
                    Console.WriteLine(sqlex.StackTrace);
                }
                finally
                {
                    if ((cnnMasterDB.State != ConnectionState.Closed))
                    {
                        cnnMasterDB.Close();
                    }
                }
            }
       }

        /// <summary>
        /// get user ID from db
        /// </summary>
        /// <returns>user ID number</returns>
        public Int32 GetUserID()
        {
            try
            {
                DataSet ds = LogInUseIntegratedSecu();
                DataTable dtbl = ds.Tables[0];

                foreach (DataRow dr in dtbl.Rows)
                {
                    return (Int32.Parse(dr["userID"].ToString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return -1;
        }

        /// <summary>
        /// log in user using integrated security
        /// </summary>
        /// <returns>dataset containing the loginName and the UserID</returns>
        public DataSet LogInUseIntegratedSecu()
        {
            DataSet ds = null;

            try
            {
                OpenMasterCnn();

                ds = SqlHelper.ExecuteDataset(m_cnn, CommandType.StoredProcedure, "TSGetUserDetails", new SqlParameter("@Username", Environment.UserDomainName + "\\" + Environment.UserName));
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            finally
            {
                if (m_cnn.State != ConnectionState.Closed)
                {
                    m_cnn.Close();
                }
            }
            return ds;
        }

        /// <summary>
        /// log in user using username and password
        /// </summary>
        /// <param name="LogInName">username</param>
        /// <param name="Password">user's password</param>
        /// <returns></returns>
        public DataSet UserCredential(String LogInName, String Password)
        {
            DataSet ds = null;
            using(SqlConnection cnnSecurityDB = new SqlConnection(ConfigurationManager.ConnectionStrings["SecurityDB"].ConnectionString))
            {
                try
                {
                    ds = SqlHelper.ExecuteDataset(cnnSecurityDB,CommandType.StoredProcedure,"spAuthenticateUser",new SqlParameter("@loginName",LogInName),
                        new SqlParameter("@password",Password));
                }
            catch(SqlException sqlex)
                {
                throw sqlex;
            }
            return ds;
            }
        }

        /// <summary>
        /// save timesheet task to the db
        /// </summary>
        /// <param name="UserID">user ID</param>
        /// <param name="EntryDate">date the work was done</param>
        /// <param name="WorkCategory">work category name</param>
        /// <param name="Comment">work category comment</param>
        /// <param name="Company">company's name</param>
        /// <param name="TimeSpent">time spent on task</param>
        /// <param name="BillableTime">time that will be paid</param>
        public void UpdateTimesheet(int UserID, DateTime EntryDate, String WorkCategory, String Comment, String Company, double TimeSpent, double BillableTime)
        {
            throw new NotImplementedException();
        }
    }
}
