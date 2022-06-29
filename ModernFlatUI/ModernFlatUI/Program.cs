
using ModernFlatUI.database;
using ModernFlatUI.Login.Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ModernFlatUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            String config = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            // Hier erstellen wir die Verbindung zur Datenbank
            IDbConnection iDBConnection = new SQLiteConnection(config);

            // hier erstellen wir die Instanz der Klasse SqliteDataAccess
            DBStorageAccess dbStorageAccess = new DBStorageAccess(iDBConnection);
            DBLoginAccess dbLoginAccess = new DBLoginAccess(iDBConnection);



            Application.Run(new FormLogin(dbStorageAccess, dbLoginAccess));


        }
    }
}
