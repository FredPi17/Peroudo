using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perudo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
        public Page3 ()
		{
			InitializeComponent ();

		    List<Joueur> JoueurList2 = new List<Joueur>();
            Manche manche2 = new Manche(JoueurList2);

            Partie.MainPartie.AddManche(manche2);

		    Debug.WriteLine("hello world");
		}

	    void Clicked_validate(object sender, EventArgs e)
	    {
	        
	    }

	    void Click_Kelza(object sender, EventArgs e)
	    {
	        
	    }
	    void Click_Bluff(object sender, EventArgs e)
	    {

	    }



    }
}