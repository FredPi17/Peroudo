using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Perudo.Backend;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Action = Perudo.Backend.Action;

namespace Perudo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
        public Page3 ()
        {
			InitializeComponent ();
            JoueurEnCours.Text = Manche.JoueurEnCours.Getpseudo();

            Debug.WriteLine($"{Manche.JoueurEnCours.Getpseudo()}");
		}

	    void Clicked_validate(object sender, EventArgs e)
	    {
	        
	    }

	    void Click_Kelza(object sender, EventArgs e)
	    {
            Decision decision = new Decision(Action.calza);
	        Manche.MainManche.Traiter(decision);
	    }
	    void Click_Bluff(object sender, EventArgs e)
	    {
	        Decision decision = new Decision(Action.bluff);
	        Manche.MainManche.Traiter(decision);
        }



    }
}