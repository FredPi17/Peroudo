using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo
{
    class Joueur 
    {
        enum Type
        {
            ordinateur,
            humain
        }
        public void TypeJoueur()
        {
            bool joueur = true; // A remplacer par la variable qui indique si on veut une ia ou un joueur
            if (joueur == true)
            {
                Type type = Type.humain;
            }
            else
            { 
                Type type = Type.ordinateur;
            }
            return Type;
        }
        int CompteDés = 5;
    }

    interface Joueur
    {
        Type typeJoueur; //le type du joueur

        int nbdes; //le nombre de des du joueur

        void Joueur(Type joueur) { } //constructeur

        int GetNbDes() { } //renvoi le nombre de des du joueur

    }
}
