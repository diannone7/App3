using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App3.Model;
using SQLite;
using Xamarin.Forms;

namespace App3.Data
{
    public class GarbageDAO
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public GarbageDAO()
        {
            database = DependencyService.Get<IGarbageDatabaseConnection>().GetConnection();
            database.CreateTable<GarbageModel>();
        }

        public IEnumerable<GarbageModel> GetGarbageList()
        {
            lock (collisionLock)
            {
                App.timerM = new DateTime();
                return (from i in database.Table<GarbageModel>() select i).ToList();
            }
        }

        public GarbageModel GetSingleGarbage(int id)
        {
            lock (collisionLock)
            {
                App.timerM = new DateTime();
                return database.Table<GarbageModel>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveGarbage(GarbageModel g)
        {
            lock (collisionLock)
            {
                if (g.Id != 0)
                {
                    App.timerM = new DateTime();
                    database.Update(g);
                    return g.Id;
                }
                else
                {
                    App.timerM = new DateTime();
                    return database.Insert(g);
                }
            }
        }

        public int DeleteGarbage(int id)
        {
            lock (collisionLock)
            {
                App.timerM = new DateTime();
                return database.Delete<GarbageModel>(id);
            }
        }
    }
}
