using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Perudo.Backend;
using Xamarin.Forms;

namespace Perudo
{
	public partial class App : Application
	{
        public static Partie CurrentPartie = new Partie();
		public App ()
		{
			InitializeComponent();

			MainPage = new Perudo.MainPage();
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
