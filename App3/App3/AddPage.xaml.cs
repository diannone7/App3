using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.Model;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPage : ContentPage
	{
        private GarbageModel gm;
        private bool isInsert;

		public AddPage ()
		{
			InitializeComponent ();
            isInsert = true;
		}
        public AddPage(GarbageModel gm) {
            InitializeComponent();
            this.gm = gm;
            isInsert = false;
            tipo.IsEnabled = false;
            tipo.SelectedItem = gm.Tipo;
            string app = gm.Colore;
            string app2 = app.Substring(0, app.Length - 4);
            colore.SelectedItem = app2;
            giorno.SelectedItem = gm.Giorno;
            string [] ora = gm.Ora.Split(':');
            TimeSpan ts=new TimeSpan(Int32.Parse(ora[0]),Int32.Parse(ora[1]),0);
            orario.Time = ts;
        }
        private async void ToolbarItem_Save(object sender, EventArgs e)
        {
            string t = tipo.SelectedItem as string;
            int indiceTipo = tipo.SelectedIndex;
            string g = giorno.SelectedItem as string;
            string app = colore.SelectedItem as string;
            string c = app.ToLower() + ".png";
            string descr = "";
            switch (indiceTipo) {
                case 0:
                    descr = "Possono essere buttati: stracci sporchi, spugne, spazzolini, oggetti di gomma, " +
                        "cicche di sigarette, carta plastificata, scontrini, " +
                        "posate monouso, polvere, pannolini e assorbenti.";
                    break;
                case 1:
                    descr = "Possono essere buttati: giornali e riviste, cartone e " +
                        "cartoncino, fotocopie, confezioni di alimenti e bevande, " +
                        "confezioni TetraPak.";
                    break;
                case 2:
                    descr = "Possono essere buttati: bottiglie, flaconi per detersivi in plastica privi di liquido, " +
                        "piatti e bicchieri monouso, buste, vaschette, pellicole, polistirolo, " +
                        "barattoli yogurt, blister trasparenti e cellophane.";
                    break;
                case 3:
                    descr = "Possono essere buttati: barattoli per alimenti privi di residui di cibo, lattine e latte, " +
                        "bombolette per alimenti e per prodotti destinati all'igiene personale privi della dicitura \"T\" e\\o \"F\", " +
                        "chiusure metalliche per vasetti di vetro, scatole varie in metallo usate per confezioni regalo, " +
                        "carta stagnola.";
                    break;
                case 4:
                    descr = "Possono essere buttati: bottiglie, barattoli, vasetti e flaconi.";
                    break;
                case 5:
                    descr = "Possono essere buttati: scarti di cucine, avanzi di cibo e frutta, tovaglioli da cucina unti non colorati, " +
                        "caffè, cialde biodegradabili, stuzzicadenti, tappi di sughero, ceneri di camino, cartoni di pizza unti," +
                        "piccole potature di fiori e piante e terriccio.";
                    break;
            }
            string h = orario.Time.Hours + ":" + orario.Time.Minutes;
            if (isInsert) {
                gm = new GarbageModel();
            }
            gm.Tipo = t;
            gm.Colore = c;
            gm.Descrizione = descr;
            gm.Giorno = g;
            gm.Ora = h;
            App.Database.SaveGarbage(gm);
            TimeSpan span = new DateTime() - App.timerM;
            Console.WriteLine("DB TIME= " + (int)span.TotalMilliseconds);
            await DisplayAlert("Info", "Salvato!", "Ok");
            await Navigation.PopToRootAsync();
        }
    }
}