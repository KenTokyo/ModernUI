using Dapper;
using ModernFlatUI.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ModernFlatUI.database
{
    public class DBLoginAccess
    {

        private string m_loginWhere = "Username";
        private string m_loginSelect = "* from LoginData";

        private IDbConnection m_idbConnection;
        public DBLoginAccess(IDbConnection p_idbConnection)
        {
            m_idbConnection = p_idbConnection;
        }


        public List<LoginDataModel> FindLoginData(string p_username, string p_password)
        {
            IEnumerable<LoginDataModel> output = null;
            output = m_idbConnection.Query<LoginDataModel>("select * from LoginData Where Username like '" + p_username + "' AND Password like '" + p_password + "'", new DynamicParameters());
            return output.ToList();
        }
        public List<LoginDataModel> LoadLoginData()
        {
            IEnumerable<LoginDataModel> output = null;
            output = m_idbConnection.Query<LoginDataModel>("select " + m_loginSelect, new DynamicParameters());
            ResetLogin();
            return output.ToList();
        }

        public void SaveLoginData(LoginDataModel loginData)
        {
            m_idbConnection.Execute("insert into LoginData (Username, Password, Name, Email, Admin) values (@Username, @Password, @Name, @Email, @Admin)", loginData);
        }

        public void DeleteSelectedLogindata(LoginDataModel loginData)
        {
            m_idbConnection.Execute("DELETE FROM LoginData WHERE Id = @Id", loginData);
        }

        public void UpdateSelectedLoginData(LoginDataModel loginData)
        {
            m_idbConnection.Execute("UPDATE LoginData SET Username = '" + loginData.Username + "', Password = '" + loginData.Password + "', Name = '" + loginData.Name + "', Email = '" + loginData.Email + "' WHERE Id = @Id", loginData);
        }

        public void SelectLoginWhere(string p_category)
        {
            m_loginWhere = p_category;
        }

        public void SearchLoginForOccurence(String p_keywords)
        {
            m_loginSelect = "* from LoginData Where " + m_loginWhere + " like  '%" + p_keywords + "%'";
        }

        public void ResetLogin()
        {
            m_loginSelect = "* from LoginData";
        }
    }
}
