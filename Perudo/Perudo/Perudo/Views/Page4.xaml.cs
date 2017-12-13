using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using sauvegarde_partie;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perudo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
		}

	    private void Validate(object sender, EventArgs e)
	    {
	        Chemin.Text = exportimport.Save(Partie.MainPartie);

        }
	}
}