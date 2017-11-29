﻿using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Humain : Joueur
    {
        private string pseudo;

        public Humain(string pseudo, Randomizer randomizer)
            : base(randomizer)
        {
            typeJ = TypeJoueur.humain;
            this.pseudo = pseudo;
        }
                
        public string Getpseudo()
        {
            return pseudo;
        }

        public Backend.Action Jouer()
        {
            throw new NotImplementedException;
        }

        public void Resultat(string pseudoJoueur, bool perdu)
        {
            if (pseudo == pseudoJoueur)
            {
                if (perdu == true)
                {
                    nbDes--;
                } else if (nbDes < 5)
                {
                    nbDes++;
                }
            }
        }
    }
}
