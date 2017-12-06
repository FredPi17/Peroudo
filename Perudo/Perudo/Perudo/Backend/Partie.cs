using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perudo;
using Perudo.Backend;

namespace ConsoleApp1
{
    public class Partie
    {
        public List<Joueur> JoueurList;
        public List<Manche> MancheList;
        public Partie(Joueur joueur, int nbJoueurs)
        {
            JoueurList = new List<Joueur>(nbJoueurs);
            this.AddJoueur(nbJoueurs);

            Manche manche1 = new Manche(JoueurList);
            MancheList = new List<Manche>();
            this.AddManche(manche1);
        }

        public void AddJoueur(int nbJoueurs)
        {
            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur Joueur = new Humain("joueur" + i, 0, Randomizer);
                JoueurList.Add(Joueur);
            }
        }

        public void AddJoueur(Joueur joueur)
        {
            JoueurList.Add(joueur);
        }

        public Randomizer Randomizer { get; set; }

        public void AddManche(Manche manche)
        {
            MancheList.Add(manche);
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
        public void FinJeu()
        {
            if (CountAlive() == 1)
            {
                foreach (var joueur in JoueurList)
                {
                    if (joueur.IsAlive())
                    {
                        if (joueur.GetTypeJoueur() == TypeJoueur.humain)
                        {
                            Humain humain = joueur as Humain;
                            string pseudoGagnant = humain.Getpseudo();
                            Console.WriteLine($"C'est la fin du jeu. C'est {pseudoGagnant} qui a gagné");
                            //Faire appel aux méthode de stockage
                        }
                        else
                        {
                            //TODO pour IA
                            /*  Humain humain = joueur as Humain;
                              string pseudoGagnant = humain.Getpseudo();
                              Console.WriteLine($"C'est la fin du jeu. C'est {pseudoGagnant} qui a gagné");*/
                        }
                    }
                }
            }
        }
    }
}
