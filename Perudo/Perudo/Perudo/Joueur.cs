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

        public void CompteurDes()
        {
            int compteur = 5; // A remplacer par la variable qui indique le nombre de dés d'un joueur
            bool calza = false;
            bool dudo = false;
            bool perdu = false;
            
            if (compteur > 0)
            {
                if (dudo == true) // Si le joueur a perdu la manche
                {
                    compteur = compteur - 1;
                    dudo = false;
                }
                if (calza == true && compteur < 5) // Si le joueur a remporté le calza
                {
                    compteur = compteur + 1;
                    calza = false;
                }
            }
            if (compteur == 0) // Si le joueur a perdu tous ses dés
                perdu = true;

            return (compteur, perdu);
        }
    }
}
