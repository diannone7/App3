using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        private GarbageModel gm;
        public Page1 (GarbageModel gm)
		{
            BindingContext = gm;            
            InitializeComponent();
            this.gm = gm;
            switch (gm.Colore)
            {
                case "azzurro.png":
                    ColorFrame.BorderColor = Color.LightBlue;
                    break;
                case "blu.png":
                    ColorFrame.BorderColor = Color.Blue;
                    break;
                case "giallo.png":
                    ColorFrame.BorderColor = Color.Yellow;
                    break;
                case "grigio.png":
                    ColorFrame.BorderColor = Color.Gray;
                    break;
                case "marrone.png":
                    ColorFrame.BorderColor = Color.Brown;
                    break;
                case "nero.png":
                    ColorFrame.BorderColor = Color.Black;
                    break;
                case "verde.png":
                    ColorFrame.BorderColor = Color.Green;
                    break; ;
            }
        }

        async void ToolbarItem_Update(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage(gm));
        }

        async void ToolbarItem_Delete(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Sicuro di voler cancellare?", "Sì", "No");
            if (answer) {
                App.Database.DeleteGarbage(gm.Id);
                TimeSpan span = new DateTime() - App.timerM;
                Console.WriteLine("DB TIME= " + (int)span.TotalMilliseconds);
                await Navigation.PopAsync();
            }
        }
    }
}