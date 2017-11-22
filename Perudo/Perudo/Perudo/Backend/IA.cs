using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    enum Niveau
    {
        Facile = 0,
        Moyen = 1
    }
    class IA : Jouer
    {
        ///Propriétés
        private Niveau myNiveau;

        /// <summary>
        /// 
        /// </summary>
        public IA()
        {
            myNiveau = Niveau.Facile;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="choix">La difficulté de l'IA</param>
        public IA(Niveau choix)
        {
            myNiveau = choix;
        }
        
        /// <summary>
        /// Cette méthode permet a l'IA de jouer
        /// </summary>
        /// <param name="de">le numéro du de</param>
        /// <param name="nb">le nombre de des</param>
        /// <param name="nbDeTable">le nombre de des encore en jeu</param>
        /// <returns>le choix de l'IA</returns>
        public string Jouer(int de, int nb, int nbDeTable)
        {
            string res;
            switch (myNiveau)
            {
                case Niveau.Facile:
                    { 
                        Random rng = new Random();
                        int choix = rng.Next(0, 6);
                        if (choix == 0)
                        {
                            res = "bluff";
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
                            res = "calza";
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
                                    res = "bluff";
                                }
                                else if (choix == 1)
                                {
                                    res = "calza";
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
