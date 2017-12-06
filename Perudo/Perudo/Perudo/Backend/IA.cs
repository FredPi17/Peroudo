using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Decision
    {
        public Action actionEncours;
        public int de;
        public int nb;

        public Decision(Action action)
        {
            actionEncours = action;
        }

        public Decision(Action action, int de, int nb)
        {
            actionEncours = action;
            this.de = de;
            this.nb = nb;
        }
    }

    class IA : Joueur
    {
        // a supp
        protected List<Decision> decs = new List<Decision>();
        // fin supp

            
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
        public Decision Jouer()
        {
            Decision dec;
            Decision olddec = decs[decs.Count - 1];
            switch (myNiveau)
            {
                case Niveau.Facile:
                    { 
                        Random rng = new Random();
                        int choix = rng.Next(0, 6);
                        if (choix == 0)
                        {
                            dec = new Decision(Backend.Action.bluff);
                        }
                        else if (choix == 1)
                        {
                            dec = new Decision(Backend.Action.encherir, olddec.de + 1, olddec.nb);
                        }
                        else if (choix == 2)
                        {
                            dec = new Decision(Backend.Action.encherir, olddec.de, olddec.nb + 1);
                        }
                        else if (choix == 3)
                        {
                            ///encherir perudo
                            double res = olddec.nb / 2;
                            int paco = Math.Ceiling(res);
                            dec = new Decision(Backend.Action.encherir, 1, paco);
                        }
                        else if (choix == 4)
                        {
                            dec = new Decision(Backend.Action.encherir, olddec.de + 1, olddec.nb + 1);
                        }
                        else if (choix == 5)
                        {
                            dec = new Decision(Backend.Action.calza);
                        }
                    }
                    break;

                case Niveau.Moyen:
                    {

                    }
                    break;

                case Niveau.Difficile:
                    {
                    }
                    break;
            }
           
        }


    }
}
