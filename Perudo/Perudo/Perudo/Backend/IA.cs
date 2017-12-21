using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace Perudo.Backend
{
    class IA : Joueur
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
            : base(id, randomizer)
        {
            myNiveau = choix;
            typeJ = TypeJoueur.ordinateur;
        }

        /// <summary>
        /// Cette méthode permet a l'IA de jouer
        /// </summary>
        /// <returns>une decision</returns>
        public override Decision Jouer(List<Des> listDes)
        {
            Decision dec;
            Decision olddec = Manche.AncienneEnchere;
            double p1 = 0.5;
            double p2 = 0.6;
            int Z = 1;

            nbTotalDes = NbTotalDes();

            int Y = CalculY(olddec);
            int X = CalculX(olddec);

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
                        double T = X * p1 + Y * p2;
                        if (T < Z - 0.10)
                        {
                            dec = new Decision(Backend.Action.bluff);
                        }
                        else if (T > Z + 0.10)
                        {
                            if (Y >= 0 && Y < 5 )
                            {
                                ///TODO
                            }
                            else if (de < 6)
                            {
                                ///encherir sur de
                            }
                            else
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
                            dec = new Decision(Backend.Action.calza);
                        }
                    }
                    return dec;

                case Niveau.Difficile:
                    {
                        int paco = 0;
                        int deux = 0;
                        int trois = 0;
                        int quatre = 0;
                        int cinq = 0;
                        int six = 0;
                        Random rng = new Random();
                        int choix = rng.Next(1, 11);
                        
                        for (int i = 0; i < listDes.Count - 1; i++)
                        {
                            if (listDes[i].valeur == "1")
                            {
                                ///encherir sur de
                            }
                            else if (listDes[i].valeur == "2")
                            {
                                ///enchrir sur nb
                            }
                            else if (listDes[i] .valeur == "3")
                            {
                                trois++;
                            }
                            else if (listDes[i].valeur == "4")
                            {
                                quatre++;
                            }
                            else if (listDes[i].valeur == "5")
                            {
                                cinq++;
                            }
                            else if (listDes[i].valeur == "6")
                            {
                                six++;
                            }

                        }
                    }
                    break;
            }
            return null;

        }


        public override Action Jouer()
        {
            throw new NotImplementedException();
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
                nbTotalDes = NbTotalDes();
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
                if (mesDes[i].valeur == chiffre.ToString())
                {
                    tot++;
                }
            }
            return tot;
        }
    }
}