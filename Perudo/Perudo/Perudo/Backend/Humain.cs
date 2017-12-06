using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Humain : Joueur
    {
        private string pseudo;

        public Humain(string pseudo, int id, Randomizer randomizer)
            : base(id, randomizer)
        {
            typeJ = TypeJoueur.humain;
            this.pseudo = pseudo;
        }
                
        public string Getpseudo()
        {
            return pseudo;
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
                } else if (nbDes < 5)
                {
                    nbDes++;
                }
            }
        }
    }
}
