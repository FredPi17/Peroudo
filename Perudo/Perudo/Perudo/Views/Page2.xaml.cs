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

namespace Perudo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
	   
        public Page2 ()
		{
			InitializeComponent ();
		}
	    void submit_Clicked(object sender, EventArgs e)
	    {

	        var Randomizer = new Randomizer();
            int humains = Int32.Parse(Humans.Text);
            int machine = Int32.Parse(Machine.Text);

	        Partie mainPartie = null;
            

            if (CheckMaxJoueurs(humains, machine))
            {
                Debug.WriteLine("La partie va commencer");
                new Partie(humains + machine, Randomizer);

                var np = new NavigationPage(new Page3());
                Application.Current.MainPage = np;
            }
            else
            {
                Debug.WriteLine("La partie ne peux pas démarrer elle a trop de joueur");

            }

           
            //TODO: ctr IA.

            //créer une partie, avec une liste de human.text.toInt de joueur idem pour IA(+difficulté), une liste de une manche pour init
          
	    }

	    

	    public static bool CheckMaxJoueurs(int nbHumains, int nbIA)
	    {
	        return nbHumains + nbIA <= 6;
	    }
    }
}