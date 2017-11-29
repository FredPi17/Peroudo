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
        protected int id;
        protected bool alive = true;

        private Randomizer randomizer;

        public Joueur(Randomizer randomizer)
        {
            this.randomizer = randomizer;
            SetDes();
        }


        public int GetId()
        {
            return id;
        }

        public bool IsAlive()
        {
            return alive;
        }

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
        /// <param name="nombre">Modifie le nombre de des du joueur</param>
        public void SetNbDes(int nombre)
        {
            nbDes = nombre;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbDes">Lance tous les dés du joueur</param>
        public void SetDes()
        {
            if (mesDes.Count != 0)
            {
                mesDes.RemoveRange(0, 4);
            }
           
            for (int i = 0; i < nbDes; i++)
            {
                Des d = new Des(randomizer);
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


        public abstract void Resultat(int idJoueur, bool perdu);
    }

}
