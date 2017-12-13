using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perudo;
using Perudo.Backend;
using System.Diagnostics;
using Perudo.Views;
using Xamarin.Forms;

namespace ConsoleApp1
{
    public class Partie
    {
        public List<Joueur> JoueurList { get; set; }
        public static Partie MainPartie { get; set; }

        public Partie(int nbHumains, int nbMachines, Randomizer randomizer, Niveau niveau)
        {
            this.Randomizer = randomizer;

            JoueurList = new List<Joueur>(nbHumains + nbMachines);
            this.AddHumain(nbHumains);
            this.AddIA(nbMachines, nbHumains + nbMachines, niveau);

            Manche.MainManche = new Manche(JoueurList);
            
            Partie.MainPartie = this;
        }

        public void AddHumain(int nbJoueurs)
        {
            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur Joueur = new Humain("joueur" + i, i, Randomizer);
                JoueurList.Add(Joueur);
            }
        }

        public void AddIA(int nbJoueurs, int nbTotalJoueur, Niveau niveau)
        {
            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur Joueur = new IA(niveau, i, "IA" + i, Randomizer, nbTotalJoueur);
                JoueurList.Add(Joueur);
            }
        }

        public Randomizer Randomizer { get; set; }

        public int GetNbDes(string valeur)
        {
            int compteurDes = 0;
            foreach (var joueur in JoueurList)
            {
                foreach (var de in joueur.GetDes())
                {
                    if (de.valeur == valeur)
                    {
                        compteurDes++;
                    }
                }
            }
            return compteurDes;
        }

        /// <summary>
        /// Fonction qui permet de calculer combien il reste de survivant dans ma liste de joueur
        /// <return>Elle renvoit un int de personnes en vie</return>
        /// </summary>
        /// <returns></returns>
        public int CountAlive()
        {
            //Vérifier si il reste un dans JoueurListDansManche
            int compteur = 0;
            foreach (var joueur in JoueurList)
            {
                if (joueur.IsAlive())
                {
                    compteur++;
                }
            }
            return compteur;
        }

        /// <summary>
        /// Fonction qui affiche le joueur ou IA gagnant. Elle renvois rien car elle fait appel à d'autre fonctions comme Sauvegarde etc...
        /// </summary>
        public bool FinJeu()
        {
            bool end = false;
            if (JoueurList.Count(e => e.IsAlive() && e.GetTypeJoueur() == TypeJoueur.humain) == 1)
            {
                Humain humain = (Humain)JoueurList.First(e => e.IsAlive() && e.GetTypeJoueur() == TypeJoueur.humain);
                string pseudoGagnant = humain.Getpseudo();
                Debug.WriteLine($"C'est la fin du jeu. C'est {pseudoGagnant} qui a gagné");
                return true;
            }
            return end;
        }
    }
}
