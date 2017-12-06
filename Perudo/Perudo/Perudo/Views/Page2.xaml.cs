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
	        int humains = 0;
	        int machine = 0;

            try
	        {
                humains = Int32.Parse(Humans.Text);
                machine = Int32.Parse(Machine.Text);

	           
            }
	        catch (Exception exception)
	        {
	            Debug.WriteLine(exception);
	            Alert.Text = "Doit contenir des chiffres";
	            Alert.IsVisible = true;
	        }
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
	            Alert.Text = "Le nombre de joueurs ne doit pas dépasser 6";

	            Alert.IsVisible = true;
	        }
            //TODO: ctr IA.

        }
	    public static bool CheckMaxJoueurs(int nbHumains, int nbIA)
	    {
	        return nbHumains + nbIA <= 6 && nbHumains + nbIA > 0;
	    }
    }
}