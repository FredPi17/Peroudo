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

            //Debug provisoire
            string ValeurDes = "";
            foreach (var Des in Manche.JoueurEnCours.GetDes())
            {
                ValeurDes += Des.valeur + " ";
            }
            DesJoueur.Text = ValeurDes;
            string ValeurJoueur0Des = "";
            foreach (var Des in Partie.MainPartie.JoueurList[0].GetDes())
            {
                
                ValeurJoueur0Des += Des.valeur + " ";
            }
            Debug.WriteLine($"{Partie.MainPartie.JoueurList[0].Getpseudo()}: {ValeurJoueur0Des}");
            string ValeurJoueur1Des = "";
            foreach (var Des in Partie.MainPartie.JoueurList[1].GetDes())
            {
                
                ValeurJoueur1Des += Des.valeur + " ";
            }
            Debug.WriteLine($"{Partie.MainPartie.JoueurList[1].Getpseudo()}: {ValeurJoueur1Des}");
            //Fin du débug provisoire
            if (Manche.AncienneEnchere != null)
            {
                Enchere.Text = $"{Manche.AncienneEnchere.nb} dés de {Manche.AncienneEnchere.de}";
            }
        }

        void Clicked_validate(object sender, EventArgs e)
	    {
	        int valeurDes = 0;
	        int nbValeurDe = 0;

            try
	        {
	            nbValeurDe = Int32.Parse(Dés.Text);
	            valeurDes = Int32.Parse(ValeursDés.Text);
            }
	        catch (Exception exception)
	        {
	            Debug.WriteLine(exception);
	        }
	        Decision decision = new Decision(Action.encherir, valeurDes, nbValeurDe);
            Manche.MainManche.Traiter(decision);
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