using Perudo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using sauvegarde_partie;
using Xamarin.Forms;
namespace Perudo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
	    void localModeBtn_Click(object sender, EventArgs e)
	    {
	        Partie mainPartie = null;
            var np = new NavigationPage(new Page2());
	        Application.Current.MainPage = np;
	    }


	    private void ImportSave_OnClicked(object sender, EventArgs e)
	    {
	        Partie mainPartie = exportimport.Load(json.Text);
	        var np = new NavigationPage(new Page2());
	        Application.Current.MainPage = np;
        }
    }
   }
