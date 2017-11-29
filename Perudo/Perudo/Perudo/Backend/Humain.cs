using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Humain : Joueur
    {
        private string nom;
        private string prenom;
        private string pseudo;

        public Humain(string pseudo, Randomizer randomizer)
            : base(randomizer)
        {
            typeJ = TypeJoueur.humain;
            this.pseudo = pseudo;
        }

        public Humain(string nom, string prenom, string pseudo, Randomizer randomizer)
            : base(randomizer)
        {
            typeJ = TypeJoueur.humain;
            this.nom = nom;
            this.prenom = prenom;
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
    }
}
