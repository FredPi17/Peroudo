using Perudo.Backend;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace Perudo
{
    public abstract class Joueur
    {
        ///Propriétées du joueur
        protected List<Decision> decs = new List<Decision>();
        public TypeJoueur typeJ { get; set; }
        public int nbDes { get; set; }
        public List<Des> mesDes { get; set; }
        public int id { get; set; }
        public bool alive { get; set; }
        public string pseudo { get; set; }
        private Randomizer randomizer;

        /// <summary>
        /// Paramètres du joueur en récupérant les informations des méthodes qui le crée 
        /// </summary>
        /// <param name="id">L'index ou numéro du joueur</param>
        /// <param name="randomizer"></param>
        public Joueur(int id, string pseudo, Randomizer randomizer)
        {
            this.id = id;
            this.randomizer = randomizer;
            this.nbDes = 5;
            this.mesDes = new List<Des>(5);
            SetDes();
            alive = true;
            this.pseudo = pseudo;
        }
        /// <summary>
        /// Notification du joueur sel
        /// </summary>
        /// <param name="des"></param>
        public void Notify(Decision des)
        {
            decs.Add(des);
        }
        /// <summary>
        /// Renvoie le pseudo du joueur pointé
        /// </summary>
        /// <returns></returns>
        public string Getpseudo()
        {
            return pseudo;
        }

        /// <summary>
        /// Renvoie l'id du joueur pointé 
        /// </summary>
        /// <returns>Donne l'id du joueur</returns>
        public int GetId()
        {
            return id;
        }
        /// <summary>
        /// Vérifie si le joueur est toujours en vie => dés supérieur à 0
        /// </summary>
        /// <returns>Si le joueur a encore des dés </returns>
        public bool IsAlive()
        {
            return alive;
        }
        /// <summary>
        /// Récupère le nombre de dés du joueur pointé
        /// </summary>
        /// <returns>Le nombre de dés du joueur</returns>
        public int GetNbDes()
        {
            return nbDes;
        }
        /// <summary>
        /// Affiche les dés du joueur pointé
        /// </summary>
        /// <returns>Une liste avec la valeur de chaque dés du Joueur</returns>
        public List<Des> GetDes()
        {
            return mesDes;
        }
        /// <summary>
        /// Modifie le nombre de dés du joueur pointé 
        /// </summary>
        /// <param name="nombre"></param>
        public void SetNbDes(int nombre)
        {
            if (nombre <= 5)
            {
                nbDes = nombre;
            }
        }
        /// <summary>
        /// Regénère les dés du joueur
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
        /// Retourne le type du joueur pointé => IA ou humain
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
        public abstract Decision Jouer(List<Des> TotalDes);
    }

}

