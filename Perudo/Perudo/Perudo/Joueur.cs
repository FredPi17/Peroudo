using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo
{
    class Joueur 
    {
        int type { get; set; }
        void TypeJoueur()
        {
            if (type == 1)
            {

            }
        }

        public void CompteurDes()
        {
            int compteur = 5;
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
        }
    }
}
