using System;
using System.Windows.Forms;
using Aculocity.ProjectName.BLL;

namespace Aculocity.ProjectName.PL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// reference to timesheet BLL
        /// </summary>
        TimesheetBLL m_timeSheetBLL = new TimesheetBLL();

        ///<summary>
        ///user login
        ///</summary>
        private void LogIn()
        {
            if (txtUserName.TextLength > 0)
            {
                if (txtPassword.TextLength > 0)
                {
                    try
                    {
                        bool loginStatus = m_timeSheetBLL.CheckCredential(txtUserName.Text.Trim(),txtPassword.Text.Trim());
                        if (loginStatus == true)
                        {
                            this.Hide();
                            (new fviewTimesheet()).Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password", "Check login info", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                        }
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusInfo.Text = ex.Message;
                    }
                }
            }
            else
            {
                toolStripStatusInfo.Text = "Username or password cannot be blank...";
            }
        }

        private void bttLogIn_Click(object sender, System.EventArgs e)
        {
            LogIn();
        }

        private void logToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LogIn();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fviewSettings fvSetting = new fviewSettings();
            fvSetting.ShowDialog();
        }

        private void cbUseIntgSecu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseIntgSecu.Checked == true)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;

                try
                {
                    bool loginStatus = m_timeSheetBLL.UseIntegratedSecu();
                    if (loginStatus == true)
                    {
                        fviewTimesheet fvTimesheet = new fviewTimesheet();
                        this.Hide();
                        fvTimesheet.Show();
                    }
                    else
                    {
                        toolStripStatusInfo.Text = "Check your username and/or password in settings...";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection could not be establish", "Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtUserName.Text.Equals("Username "))
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text.Equals("Password "))
            {
                txtPassword.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.TextLength == 0)
            {
                txtUserName.Text = "Username ";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.TextLength == 0)
            {
                txtPassword.Text = "Password ";
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripStatusInfo.Text = "Not Connected...";
        }

        /// <summary>
        /// TODO: check this method later
        /// </summary>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fviewTimesheet fvTimesheet = new fviewTimesheet();
            //Form f = fvTimesheet.FindForm();
            //f.Dispose();
            using (fviewTimesheet fvTimesheet = new fviewTimesheet())
            {
                Form f = fvTimesheet.FindForm();
            }
        }
        /// <summary>
        /// keep the layout fluid when the form is resized
        /// </summary>
        private void Main_Resize(object sender, EventArgs e)
        {
            AlignUI.CenterInForm.Horizontally(this, pnlLogIn);
            AlignUI.CenterInForm.Vertically(this, pnlLogIn);
        }

        /// <summary>
        /// TODO: release memory when LOgIn is closed after being call by fviewTS
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //fviewTimesheet fvTimesheet = new fviewTimesheet();
            //Form f = fvTimesheet.FindForm();
            //f.Dispose();

            using (fviewTimesheet fvTimesheet = new fviewTimesheet())
            {
                Form f = fvTimesheet.FindForm();
            }

            base.OnFormClosing(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((Char)Keys.Enter))
            {
                LogIn();
            }
        }
    }
}
