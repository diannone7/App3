using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.Model;
namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            //garbageList.ItemsSource = App.Database.GetGarbageList();
            //garbageList.ItemsSource = GarbageDataSource.GetList();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            garbageList.ItemsSource = App.Database.GetGarbageList();
            TimeSpan span = new DateTime() - App.timerM;
            Console.WriteLine("DB TIME= "+ (int)span.TotalMilliseconds);
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }

        private async void garbageList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var answer = await DisplayAlert("Question?", "Sicuro di voler cancellare?", "Sì", "No");
            //*
            var element = e.SelectedItem as GarbageModel;
            //var answer = await DisplayAlert("Question?", element.Id+" "+element.Tipo, "Sì", "No");
            await Navigation.PushAsync(new Page1(element));
            //*/
        }
    }
}
