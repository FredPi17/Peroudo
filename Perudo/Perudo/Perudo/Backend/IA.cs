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
        
        ///Méthodes
        
        public void Jouer(int de, int nb, int nbjoueur)
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
                            ///colza
                        }
                    }
                    break;

                case Niveau.Moyen:
                    {
                        if (nb > nbjoueur)
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
                                    ///colza
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
