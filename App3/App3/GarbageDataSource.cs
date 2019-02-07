using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    class GarbageDataSource
    {
        public string Type { get; set; }
        public string DateAndDay { get; set; }
        public string ImagePath {get;set;}

        public GarbageDataSource(string type, string dateandday, string imagepath)
        {
            Type = type;
            DateAndDay = dateandday;
            ImagePath = imagepath;
        }

        public override string ToString() {
            return Type;
        }

        public static List<GarbageDataSource> GetList()
        {
            var garbagesList = new List<GarbageDataSource>();
            garbagesList.Add(new GarbageDataSource("Indifferenziata", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Carta", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Plastica", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Alluminio", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Umido", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Rifiuti ingombranti", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Giardinaggio", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Indifferenziata", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Carta", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Plastica", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Alluminio", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Umido", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Rifiuti ingombranti", "Lunedì 21:00", "nero.png"));
            garbagesList.Add(new GarbageDataSource("Giardinaggio", "Lunedì 21:00", "nero.png"));
            return garbagesList;
        }
    }
    
}
