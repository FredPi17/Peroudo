using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    enum Niveau
    {
        Facile,
        Difficile
    }
    class IA
    {
        ///Propriétés
        private Niveau myNiveau;
        ///Constructeur
        public IA()
        {
            myNiveau = Niveau.Facile;
        }
        public IA(Niveau niveau)
        {
            
            myNiveau = Niveau.niveau;
        }
        ///Méthodes
    }
}
