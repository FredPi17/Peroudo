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
        /// <summary>
        /// Création d'une liste : 
        /// - JoueurList avec la liste des joueurs
        /// Et création MainPartie à partir de Partir
        /// </summary>
        public List<Joueur> JoueurList { get; set; }
        public static Partie MainPartie { get; set; }

        /// <summary>
        /// Création d'un partie avec l'ajout du nombre d'humains, de machines et création d'une manche
        /// </summary>
        /// <param name="nbHumains">Nombre d'humains</param>
        /// <param name="nbMachines">Nombre d'IA</param>
        /// <param name="randomizer">Fonction Randomizer qui crée les dés</param>
        /// <param name="niveau">Difficulté des IA</param>
        public Partie(int nbHumains, int nbMachines, Randomizer randomizer, Niveau niveau)
        {
            this.Randomizer = randomizer;

            JoueurList = new List<Joueur>(nbHumains + nbMachines);
            this.AddHumain(nbHumains);
            this.AddIA(nbMachines, nbHumains + nbMachines, niveau);

            Manche.MainManche = new Manche(JoueurList);

        
            Partie.MainPartie = this;
        }

        /// <summary>
        /// Ajout d'humains dans une partie
        /// </summary>
        /// <param name="nbJoueurs">Nombre de joueurs à créer</param>
        public void AddHumain(int nbJoueurs)
        {
            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur Joueur = new Humain("joueur" + i, 0, Randomizer);
                JoueurList.Add(Joueur);
            }
        }

        /// <summary>
        /// Ajout des IA dans la partie
        /// </summary>
        /// <param name="nbJoueurs">Nombre de joueurs</param>
        /// <param name="nbTotalJoueur">Nombre total de joueurs dans la partie</param>
        /// <param name="niveau">Niveau de difficulté </param>
        public void AddIA(int nbJoueurs, int nbTotalJoueur, Niveau niveau)
        {
            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur Joueur = new IA(niveau, i, "IA" + i, Randomizer, nbTotalJoueur);
                JoueurList.Add(Joueur);
            }
        }
        
        public Randomizer Randomizer { get; set; }

        /// <summary>
        /// Récupère le nombre de dés 
        /// </summary>
        /// <param name="valeur"></param>
        /// <returns></returns>
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
            //Vérifier s'il reste un dans JoueurListDansManche
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
        /// Fonction qui affiche le joueur ou IA gagnant. Elle renvoit rien car elle fait appel à d'autres fonctions comme Sauvegarde etc...
        /// </summary>
        public bool FinJeu()
        {
            bool end = false;
            if (JoueurList.Count(e => e.IsAlive()) == 1)
            {
                var joueur = JoueurList.First(e => e.IsAlive());

                string pseudoGagnant = joueur.Getpseudo();
                Debug.WriteLine($"C'est la fin du jeu. C'est {pseudoGagnant} qui a gagné");
                return true;
            }
            return end;
        }
    }
}
