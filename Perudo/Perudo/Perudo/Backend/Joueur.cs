using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo
{  
    public abstract class Joueur 
    {
        ///Propriétées
        protected TypeJoueur typeJ;
        protected int nbDes = 5;
        protected List<Des> mesDes = new List<Des>(5);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Le nombre de dés du joueur</returns>
        public int GetNbDes()
        {
            return nbDes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Une liste avec la valeur de chaque dés du Joueur</returns>
        public List<Des> GetDes()
        {
            return mesDes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbDes">Lance tous les dés du joueur</param>
        public void SetDes(int nbDes)
        {
            mesDes.RemoveRange(0, 5);
            foreach(Des d in mesDes)
            {
                d.DiceRoll();
                mesDes.Add(d);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Le type du joueur</returns>
        public TypeJoueur GetTypeJoueur()
        {
            return typeJ;
        }
        public abstract Backend.Action Jouer();
    }

}
