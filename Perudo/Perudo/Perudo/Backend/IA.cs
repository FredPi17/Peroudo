﻿using System;
using System.Collections.Generic;
using System.Text;

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
                            ///encherir sur de
                            dec = new Decision(Backend.Action.encherir, );
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
