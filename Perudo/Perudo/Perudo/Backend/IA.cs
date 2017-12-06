using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public enum Action
    {
        encherir = 0,
        bluff = 1,
        calza = 2
    }
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
        /// <param name="pseudo">Le pseudo de l'IA</param>
        /// <param name="randomizer">pour les dés</param>
        public IA(Niveau choix, int id, string pseudo, Randomizer randomizer)
            : base (id, pseudo, randomizer)
        {
            myNiveau = choix;
            typeJ = TypeJoueur.ordinateur;
        }
                
        /// <summary>
        /// Permet a l'IA de jouer
        /// </summary>
        /// <returns>une decision</returns>
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
                            double res = olddec.nb / 2;
                            double rnd = Math.Round(res);
                            int paco = Convert.ToInt32(rnd);
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
