using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(App3.Droid.GarbageDatabaseConnection_Android))]
namespace App3.Droid
{
    public class GarbageDatabaseConnection_Android : IGarbageDatabaseConnection
    {
        public GarbageDatabaseConnection_Android() { }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "GarbageDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}