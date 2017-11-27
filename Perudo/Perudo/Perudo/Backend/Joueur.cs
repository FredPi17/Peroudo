using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo
{  
    abstract class Joueur 
    {
        ///Propriétées
        protected TypeJoueur typeJ;
        protected int nbDes = 5;
        protected List<Des> mesDes = new List<Des>();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Le nombre de dés du joueur</returns>
        int GetNbDes()
        {
            return nbDes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Une liste avec la valeur de chaque dés du Joueur</returns>
        List<Des> GetDes()
        {
            return mesDes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbDes">Lance tous les dés du joueur</param>
        void SetDes(int nbDes)
        {
            foreach(Des d in mesDes)
            {
                d.DiceRoll();
                mesDes.Add(d);
            }
        }
    }

}
