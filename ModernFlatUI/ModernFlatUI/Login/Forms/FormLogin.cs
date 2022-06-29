using ModernFlatUI.usercontrolling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using ModernFlatUI.database;

namespace ModernFlatUI.Login.Forms
{
    public partial class FormLogin : Form
    {
        private DBStorageAccess m_dbStorageAccess;
        private DBLoginAccess m_dbLoginAccess;
        private Thread m_thread;
        private bool m_isAdmin;

        List<LoginDataModel> loginList = new List<LoginDataModel>();
        public FormLogin(DBStorageAccess p_dbStorageAccess, DBLoginAccess p_dbLoginAccess)
        {
            m_dbStorageAccess = p_dbStorageAccess;
            m_dbLoginAccess = p_dbLoginAccess;
            InitializeComponent();

        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(UsernameTextBox.Text) && !String.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                //if (m_dbAccess.FindLoginData(UsernameTextBox.Text, PasswordTextBox.Text))
                //{
                //    AttemptLoginLabel.Text = "Login hat funktioniert!!!";
                //}
                //else
                //{
                //    AttemptLoginLabel.Text = "Logindaten sind fehlerhaft!";
                //}
                loginList = m_dbLoginAccess.FindLoginData(UsernameTextBox.Text, PasswordTextBox.Text);

                if (loginList.Count == 0)
                {
                    AttemptLoginLabel.Text = "Die Liste hat keinen Eintrag, falsche Login-Daten";
                }
                else if (!string.IsNullOrEmpty(loginList[0].Admin))
                {
                    AttemptLoginLabel.Text = "Es wurde ein Eintrag gefunden! Sie sind Admin!";
                    ShowMainMenuBtn.Visible = true;
                    m_isAdmin = true;

                }
                else
                {
                    AttemptLoginLabel.Text = "Es wurde ein Eintrag gefunden! " + loginList[0].Admin + "";
                    ShowMainMenuBtn.Visible = true;
                    m_isAdmin = false;
                }

                WireUpStockList();
            }
        }


        public void WireUpStockList()
        {
            LoginDataGrid.DataSource = loginList;
        }

        private void AttemptLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowMainFormAndCloseLogin()
        {

            this.Close();
            m_thread = new Thread(OpenNewForm);
            m_thread.SetApartmentState(ApartmentState.STA);
            m_thread.Start();

        }

        private void OpenNewForm(object obj)
        {
            Application.Run(new FormMainMenu(m_dbStorageAccess, m_dbLoginAccess, m_isAdmin));
        }

        private void ShowMainMenuBtn_Click(object sender, EventArgs e)
        {
            ShowMainFormAndCloseLogin();
        }
    }
}
