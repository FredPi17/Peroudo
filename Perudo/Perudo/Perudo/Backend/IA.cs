using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    //TODO a supp
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
    //fin supp

    class IA : Joueur
    {
        //Todo a supp
        protected List<Decision> decs = new List<Decision>();
        // fin supp
                    
        ///Propriétés
        private Niveau myNiveau;
        private int nbTotalDes;
        private List<Tuple<int, int>> listJoueurDes;

       
        /// <summary>
        /// Constructeur d'IA
        /// </summary>
        /// <param name="choix">Le choix du niveau</param>
        /// <param name="id">l'index ou le numéro du joueur</param>
        /// <param name="pseudo">Le pseudo de l'IA</param>
        /// <param name="randomizer">pour les dés</param>
        public IA(Niveau choix, int id, string pseudo, Randomizer randomizer, int nbJoueur)
            : base (id, pseudo, randomizer)
        {
            myNiveau = choix;
            typeJ = TypeJoueur.ordinateur;
            listJoueurDes = new List<Tuple<int, int>>();
            for (int i = 0; i < nbJoueur; i++)
            {
                listJoueurDes.Add(new Tuple<int, int>(i, 5));
            }
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

        int Calcul()
        {

        } 

        public override void Resultat(int idJoueur, bool perdu)
        {
            if (id == idJoueur)
            {
                if (perdu == true)
                {
                    nbDes--;
                    if (nbDes == 0)
                    {
                        alive = false;
                    }
                }
                else if (nbDes < 5)
                {
                    nbDes++;
                }
            }
            else
            {
                int i = 0;
                bool foundJoueur = false;
                while (i < listJoueurDes.Count - 1 || foundJoueur == false)
                {
                    if (listJoueurDes[i].Item1 == idJoueur)
                    {
                        foundJoueur = true;
                    } else
                    {
                        i++;
                    }                    
                }
                int nbDes = listJoueurDes[i].Item2;
                if (perdu == true)
                {
                    nbDes--;
                }
                else if (nbDes < 5)
                {
                    nbDes++;
                }
                listJoueurDes[i] = Tuple.Create(i, nbDes);
            }
        }

        private int NbTotalDes()
        {
            int tot = 0;
            for (int j = 0; j < listJoueurDes.Count - 1; j++)
            {
                tot += listJoueurDes[j].Item2;
            }
            return tot;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chiffre">le numéro du dé</param>
        /// <returns>Combien on a de dé "chiffre" dans notre main</returns>
        private int Combien(int chiffre)
        {
            int tot = 0;
            for (int i = 0; i < mesDes.Count -1; i++)
            {
                if (mesDes[i] == chiffre)
                {
                    tot++;
                }
            }
            return tot;
        }
    }
}
