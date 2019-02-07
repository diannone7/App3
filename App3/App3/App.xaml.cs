using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.Data;
[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App3
{
	public partial class App : Application
	{
        static GarbageDAO database;
        public static DateTime timerM;
        public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static GarbageDAO Database
        {
            get
            {
                if (database == null)
                {
                    database = new GarbageDAO();
                }
                return database;
            }
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

	}
}
