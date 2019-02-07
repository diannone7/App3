using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace App3.Model
{
    [Table("Garbage")]
    public class GarbageModel:INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey,AutoIncrement]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _tipo;
        [NotNull]
        public string Tipo {
            get {
                return _tipo;
            }
            set {
                this._tipo = value;
                OnPropertyChanged(nameof(Tipo));
            }
        }

        private string _colore;
        [NotNull]
        public string Colore
        {
            get
            {
                return _colore;
            }
            set
            {
                this._colore = value;
                OnPropertyChanged(nameof(Colore));
            }
        }

        private string _descrizione;
        [NotNull]
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            set
            {
                this._descrizione = value;
                OnPropertyChanged(nameof(Descrizione));
            }
        }

        private string _giorno;
        [NotNull]
        public string Giorno
        {
            get
            {
                return _giorno;
            }
            set
            {
                this._giorno = value;
                OnPropertyChanged(nameof(Giorno));
            }
        }

        private string _ora;
        [NotNull]
        public string Ora
        {
            get
            {
                return _ora;
            }
            set
            {
                this._ora = value;
                OnPropertyChanged(nameof(Ora));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
