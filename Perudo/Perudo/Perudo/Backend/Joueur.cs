using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

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
        protected string pseudo;


        private Randomizer randomizer;

        public Joueur(int id, Randomizer randomizer)
        {
            this.id = id;
            this.randomizer = randomizer;
            SetDes();
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
            else
            {

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

        public abstract Backend.Action Jouer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idJoueur">le numéro du joueur qui a perdu ou ganger un dé</param>
        /// <param name="perdu">vrai, le joueur perds un dé, faux le joueur gagne un dé</param>
        public abstract void Resultat(int idJoueur, bool perdu);
    }

}
