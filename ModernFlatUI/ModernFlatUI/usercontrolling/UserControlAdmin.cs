using ModernFlatUI.database;
using ModernFlatUI.Login;
using ModernFlatUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModernFlatUI
{
    public partial class UserControlAdmin : UserControl
    {

        private DBLoginAccess m_dbLoginAccess;

        private List<LoginDataModel> accountList = new List<LoginDataModel>();
        public UserControlAdmin()
        {
            InitializeComponent();
        }

        public void LoadAccountList()
        {
            m_dbLoginAccess = FormMainMenu.m_dbLoginAccess;
            accountList = m_dbLoginAccess.LoadLoginData();
            WireUpAccountList();
        }


        public void WireUpAccountList()
        {
            ExistingAccountsGrid.DataSource = accountList;
        }


        private void CreateBtn_Click(object sender, EventArgs e)
        {
            LoginDataModel loginData = new LoginDataModel();

            if (String.IsNullOrWhiteSpace(UsernameText.Text) || String.IsNullOrWhiteSpace(PasswordText.Text) || String.IsNullOrWhiteSpace(EmailText.Text) || String.IsNullOrWhiteSpace(NameText.Text))
            {
                Utils.ShowErrorForm("Alle Felder müssen ausgefüllt sein!");
                return;
            }

            loginData.Username = UsernameText.Text;
            loginData.Password = PasswordText.Text;
            loginData.Name = NameText.Text;
            loginData.Email = EmailText.Text;
            if (Admin.Checked)
                loginData.Admin = "True";


            m_dbLoginAccess.SaveLoginData(loginData);

            UsernameText.Text = "";
            PasswordText.Text = "";
            NameText.Text = "";
            EmailText.Text = "";
            LoadAccountList();
        }


        private LoginDataModel GetSelectedLoginDataFromDatabase()
        {
            try
            {
                LoginDataModel login = ExistingAccountsGrid.SelectedRows[0].DataBoundItem as LoginDataModel;
                return login;
            }
            catch (ArgumentOutOfRangeException)
            {
                Utils.ShowErrorForm("Keine Einträge in Datenbank vorhanden.");
                return null;
            }

        }

        private void RemoveLoginData_Click(object sender, EventArgs e)
        {

            if (GetSelectedLoginDataFromDatabase() != null)
            {
                LoginDataModel login = GetSelectedLoginDataFromDatabase();
                m_dbLoginAccess.DeleteSelectedLogindata(login);
                LoadAccountList();
            }

        }

        private void UpdateLoginDataButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedLoginDataFromDatabase() != null)
            {
                LoginDataModel login = GetSelectedLoginDataFromDatabase();
                m_dbLoginAccess.UpdateSelectedLoginData(login);
                LoadAccountList();
            }
        }


        private void SelectLoginDataCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dbLoginAccess.SelectLoginWhere(CategoryComboBox.SelectedItem.ToString());
            SearchButton_Click(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(KeywordsText.Text))
            {
                m_dbLoginAccess.SearchLoginForOccurence(KeywordsText.Text);
                LoadAccountList();
            }

        }

        private void UserControlAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExistingAccountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
