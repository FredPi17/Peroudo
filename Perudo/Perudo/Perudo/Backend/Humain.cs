using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    class Humain : Joueur
    {
        string nom;
        string prenom;
        string pseudo;

        Humain(string pseudo)
        {
            typeJ = TypeJoueur.Humain;
            this.pseudo = pseudo;
        }

        Humain(string nom, string prenom, string pseudo)
        {
            typeJ = TypeJoueur.Humain;
            this.nom = nom;
            this.prenom = prenom;
            this.pseudo = pseudo;
        }
        string Getpseudo()
        {
            return pseudo;
        }
    }
}
