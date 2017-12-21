using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Perudo.Backend;
using sauvegarde_partie;
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
            Round.Text = "Round n° " + Manche.nbRound.ToString();
            numManche.Text = "Manche n° " + Manche.nbManche.ToString();
            JoueurEnCours.Text = "Joueur en cours: \n" + Manche.JoueurEnCours.Getpseudo();
            joueurSituation.Text = Manche.actionJoueur.ToString();
            Debug.WriteLine($"{Manche.JoueurEnCours.Getpseudo()}");
            string ValeurJoueur1Des = "Mes dés : \n";
            
                foreach (var des in Manche.JoueurEnCours.GetDes())
                {
                    ValeurJoueur1Des += des.valeur + " ";
                }
                DesJoueur.Text = ValeurJoueur1Des;
            
            if (Manche.AncienneEnchere != null)
            {
                Enchere.Text = $"Dernière enchère : \n {Manche.AncienneEnchere.nb} dés de {Manche.AncienneEnchere.de}";
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
	        if (Manche.AncienneEnchere != null)
	        {
	            if (nbValeurDe > Manche.AncienneEnchere.nb)
	            {
	                if (valeurDes >= Manche.AncienneEnchere.de)
	                {
                        Decision decision = new Decision(Action.encherir, valeurDes, nbValeurDe);
	                    Manche.MainManche.Traiter(decision);
	                    joueurSituation.Text = "";

	                }
	            }
	            joueurSituation.Text = "Votre enchère doit etre supérieure à la précédente";
            }
	        else
	        {
	            Decision decision = new Decision(Action.encherir, valeurDes, nbValeurDe);
	            Manche.MainManche.Traiter(decision);
	        }
        }

        void Click_Kelza(object sender, EventArgs e)
	    {
	        if (Manche.AncienneEnchere != null)
	        {
	            Decision decision = new Decision(Action.calza);
	            Manche.MainManche.Traiter(decision);
            }
	        else
	        {
	            joueurSituation.Text = "Vous ne pouvez pas faire de calza sans enchères";
            }

        }
	    void Click_Bluff(object sender, EventArgs e)
	    {
	        if (Manche.AncienneEnchere != null)
	        {
	            Decision decision = new Decision(Action.bluff);
	            Manche.MainManche.Traiter(decision);
	        }
	        else
	        {
	            joueurSituation.Text = "Vous ne pouvez pas faire de bluff sans enchères";

            }

        }

	    private void Save_OnClicked(object sender, EventArgs e)
	    {
	        json.Text = exportimport.Save(Partie.MainPartie);
        }
	}
}