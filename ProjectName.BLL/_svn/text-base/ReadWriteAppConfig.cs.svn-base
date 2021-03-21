using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using AMS.Profile;

namespace Aculocity.ProjectName.BLL
{
    public class ReadWriteAppConfig
    {
        private Config _appConfig;

        #region Declarations
        private String _server;
        private String _database;
        private Boolean _usernamePwdStatus;
        private String _username;
        private String _password;
        private Boolean _protectPwd;

        private String[] _availableWorkTask;
        private String[] _selectedWorkTask;

        private Boolean _setTimer;
        private int _remimderTime;
        private String _onlineWebAddress;
        #endregion

        #region Server Access: Properties
        public String Server
        {
            get
            {
                return _server;
            }
            set
            {
                this._server = value;
            }
        }
        public String Database
        {
            get
            {
                return _database;
            }
            set
            {
                this._database = value;
            }
        }
        public Boolean UsernamePwdStatus
        {
            get
            {
                return _usernamePwdStatus;
            }
            set
            {
                this._usernamePwdStatus = value;
            }
        }
        public String Username
        {
            get
            {
                return _username;
            }
            set
            {
                this._username = value;
            }
        }
        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = value;
            }
        }
        public Boolean ProtectPwd
        {
            get
            {
                return _protectPwd;
            }
            set
            {
                this._protectPwd = value;
            }
        }
        #endregion

        #region Select Working task: Properties
        public String[] AvailableWorkTask
        {
            get
            {
                return _availableWorkTask;
            }
            set
            {
                this._availableWorkTask = value;
            }
        }
        public String[] SelectedWorkTask
        {
            get
            {
                return _selectedWorkTask;
            }
            set
            {
                this._selectedWorkTask = value;
            }
        }
        #endregion

        #region General Settings: Properties
        public Boolean SetTimer
        {
            get
            {
                return _setTimer;
            }
            set
            {
                this._setTimer = value;
            }
        }
        public int ReminderTime
        {
            get
            {
                return _remimderTime;
            }
            set
            {
                this._remimderTime = value;
            }
        }
        public String OnlineWebAddress
        {
            get
            {
                return _onlineWebAddress;
            }
            set
            {
                this._onlineWebAddress = value;
            }
        }
        #endregion

        public ReadWriteAppConfig(String AppConfigFileName, String GroupName)
        {
            _appConfig = new Config(AppConfigFileName);
            _appConfig.GroupName = GroupName;
        }

        #region Server Access
        public void SetServerSetting()
        {
            try
            {
                _appConfig.SetValue("Server Access", "Server", _server);
                _appConfig.SetValue("Server Access", "Database", _database);
                _appConfig.SetValue("Server Access", "UsernamePwdStatus", _usernamePwdStatus);
                _appConfig.SetValue("Server Access", "Username", _username);
                _appConfig.SetValue("Server Access", "Password", _password);
                _appConfig.SetValue("Server Access", "Protect Pwd", _protectPwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetServerSetting()
        {
            try
            {
                _server = _appConfig.GetValue("Server Access", "Server").ToString();
                _database = _appConfig.GetValue("Server Access", "Database").ToString();
                _usernamePwdStatus = Boolean.Parse(_appConfig.GetValue("Server Access", "UsernamePwdStatus").ToString());
                _username = _appConfig.GetValue("Server Access", "Username").ToString();
                _password = _appConfig.GetValue("Server Access", "Password").ToString();
                _protectPwd = Boolean.Parse(_appConfig.GetValue("Server Access", "Protect Pwd").ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Select Working task
        public void SetAvailableWorkTask()
        {
            try
            {
                for (int i = 0; i < _availableWorkTask.Length; i++)
                {
                    _appConfig.SetValue("Available Working Task", "key" + i, _availableWorkTask[i]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetSelectedWorkTask()
        {
            try
            {
                for (int i = 0; i < _selectedWorkTask.Length; i++)
                {
                    _appConfig.SetValue("Selected Working Task", "key" + i, _selectedWorkTask[i]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GetAvailableWorkTask()
        {
            try
            {
                String[] availableWorkTask = _appConfig.GetEntryNames("Available Working Task");
                String[] getAvailableWorkTask = new String[availableWorkTask.Length];
                for (int i = 0; i < availableWorkTask.Length; i++)
                {
                    getAvailableWorkTask[i] = _appConfig.GetValue("Available Working Task", availableWorkTask[i]).ToString();
                }
                _availableWorkTask = getAvailableWorkTask;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GetSelectedWorkTask()
        {
            try
            {
                String[] selectedWorkTask = _appConfig.GetEntryNames("Selected Working Task");
                String[] getSelectedWorkTask = new String[selectedWorkTask.Length];
                for (int i = 0; i < selectedWorkTask.Length; i++)
                {
                    getSelectedWorkTask[i] = _appConfig.GetValue("Selected Working Task", selectedWorkTask[i]).ToString();
                }
                _selectedWorkTask = getSelectedWorkTask;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region General Settings
        public void SetGeneralSetting()
        {
            try
            {
                _appConfig.SetValue("General Setting", "Timer Status", _setTimer);
                _appConfig.SetValue("General Setting", "Remimder Time", _remimderTime);
                _appConfig.SetValue("General Setting", "Online Web Address", _onlineWebAddress);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetGeneralSetting()
        {
            try
            {
                _setTimer = Boolean.Parse(_appConfig.GetValue("General Setting", "Timer Status").ToString());
                _remimderTime = int.Parse(_appConfig.GetValue("General Setting", "Remimder Time").ToString());
                _onlineWebAddress = _appConfig.GetValue("General Setting", "Online Web Address").ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
