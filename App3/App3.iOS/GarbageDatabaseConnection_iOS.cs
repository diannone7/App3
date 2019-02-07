using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Foundation;
using UIKit;
using System;
using System.IO;

[assembly: Dependency(typeof(App3.iOS.GarbageDatabaseConnection_iOS))]
namespace App3.iOS
{
    class GarbageDatabaseConnection_iOS:IGarbageDatabaseConnection
    {
        public GarbageDatabaseConnection_iOS() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "GarbageDB.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}