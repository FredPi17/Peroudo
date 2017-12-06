using Perudo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var np = new NavigationPage(new Page2());
	        Application.Current.MainPage = np;
	    }

	    void ImporterSauvegarde(object sender, EventArgs e)
	    {
	        
	    }
	    
	}
   }
