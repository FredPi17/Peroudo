using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    class IA : Jouer
    {
        ///Propriétés
        private Niveau myNiveau;
       
        /// <summary>
        /// Constructeur d'IA
        /// </summary>
        /// <param name="choix">Le choix du niveau</param>
        /// <param name="id">l'index ou le numéro du joueur</param>
        /// <param name="randomizer">pour les dés</param>
        public IA(Niveau choix, int id, Randomizer randomizer)
            : base (id, randomizer)
        {
            myNiveau = choix;
            typeJ = TypeJoueur.ordinateur;
        }
        
        /// <summary>
        /// Cette méthode permet a l'IA de jouer
        /// </summary>
        /// <param name="de">le numéro du de</param>
        /// <param name="nb">le nombre de des</param>
        /// <param name="nbDeTable">le nombre de des encore en jeu</param>
        public void Jouer(int de, int nb, int nbDeTable)
        {
            switch (myNiveau)
            {
                case Niveau.Facile:
                    { 
                        Random rng = new Random();
                        int choix = rng.Next(0, 6);
                        if (choix == 0)
                        {
                            ///bluff
                        }
                        else if (choix == 1)
                        {
                            ///encherir sur de
                        }
                        else if (choix == 2)
                        {
                            ///encherir sur nb
                        }
                        else if (choix == 3)
                        {
                            ///encherir perudo
                        }
                        else if (choix == 4)
                        {
                            ///encherir de et nb
                        }
                        else if (choix == 5)
                        {
                           ///calza
                        }
                    }
                    break;

                case Niveau.Moyen:
                    {
                        if (nb > nbDeTable)
                        {
                            if (de != 0)///perudo
                            {
                                ///TODO
                            } else if (de < 6)
                            {
                                ///encherir sur de
                            } else
                            {
                                Random rng = new Random();
                                int choix = rng.Next(0, 2);
                                if (choix == 0)
                                {
                                    ///bluff
                                }
                                else if (choix == 1)
                                {
                                    ///calza
                                }
                            } 
                        }
                        else
                        {
                            Random rng = new Random();
                            int choix = rng.Next(0, 2);
                            if (choix == 0)
                            {
                                ///encherir sur de
                            } else if (choix == 1)
                            {
                                ///enchrir sur nb
                            } 
                        }
                    }
                    break;
            }
           
        }


    }
}
