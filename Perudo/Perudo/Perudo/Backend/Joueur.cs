using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo
{  
    public abstract class Joueur 
    {
        ///Propriétées
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">L'index ou numéro du joueur</param>
        /// <param name="randomizer"></param>
                
        public void Notify(Decision des)
        {
            decs.Add(des);
        }

        public string Getpseudo()
        {
            return pseudo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Donne l'id du joueur</returns>
        public int GetId()
        {
            return id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Si le joueur a encore des dés </returns>
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
            if (nombre <= 5)
            {
                nbDes = nombre;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbDes">Lance tous les dés du joueur</param>
        public void SetDes()
        {
            mesDes.Clear();

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idJoueur">le numéro du joueur qui a perdu ou ganger un dé</param>
        /// <param name="perdu">vrai, le joueur perds un dé, faux le joueur gagne un dé</param>
        public abstract void Resultat(int idJoueur, bool perdu);
    }

}

        protected List<Decision> decs = new List<Decision>();
        public TypeJoueur typeJ { get; set; }
        public int nbDes { get; set; }
        public List<Des> mesDes { get; set; }
        public int id { get; set; }
        public bool alive { get; set; }
        public string pseudo { get; set; }
        private Randomizer randomizer;
        public Joueur(int id, Randomizer randomizer)
        {
            this.id = id;
            this.randomizer = randomizer;
            this.nbDes = 5;
            this.mesDes = new List<Des>(5);
            SetDes();
            alive = true;
        }

