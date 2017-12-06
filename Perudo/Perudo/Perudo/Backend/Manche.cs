using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perudo;
using Perudo.Backend;
using Action = Perudo.Backend.Action;

namespace ConsoleApp1
{
    class Manche
    {
        public List<Joueur> JoueurListDansManche;
        public int IndexJoueurEnCours = 0;
        public int numTour = 0;
        public static Manche MainManche { get; set; }
        public static Joueur JoueurEnCours { get; set; }

        /// <summary>
        /// Permet de retourner l'ID du joueur en train de jouer
        /// </summary>
        /// <param name="joueurlist"></param>
        /// <returns></returns>
        public void SetJoueurEnCours(List<Joueur> joueurlist)
        {
            JoueurEnCours = JoueurListDansManche[IndexJoueurEnCours];
        }

        /// <summary>
        /// Permet de retourner l'ID du dernier joueur ayant joué
        /// </summary>
        /// <param name="joueurlist"></param>
        /// <returns></returns>
        public Joueur JoueurPasse(List<Joueur> joueurlist)
        {
            int indexPrecedent = GetIndexJoueurPrecedent();
            if (numTour != 0)
                return JoueurListDansManche[indexPrecedent]; //le Joueur précédent
            else
                return JoueurListDansManche[IndexJoueurEnCours]; //Le Joueur qui est en train de joueur
        }

        /// <summary>
        /// Retourne l'id du joueur
        /// </summary>
        /// <returns></returns>
        public int GetIndexJoueurPrecedent()
        {
            if (IndexJoueurEnCours == 0)
                return JoueurListDansManche.Count - 1;
            else
                return IndexJoueurEnCours - 1;
        }


        //public string DeEncours = Des.DiceRoll();//Le chiffre ou paco du dé qui est dans le pari


        public string DePasse = "0"; //Le dernier chiffre utilisé avant le paco



        /// <summary>
        /// Vérifier en cas de calza ou de bluff si le joueur a raison
        /// </summary>
        /// <returns></returns>
        /*public bool Vérification()
        {

        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="joueurs"></param>
        /// <param name="nbTotalDeDes"></param>
        public Manche(List<Joueur> Joueurlist)
        {
            JoueurListDansManche = Joueurlist;
            IndexJoueurEnCours = 0;

            string proposition = "0";

            SetJoueurEnCours(JoueurListDansManche);
            MainManche = this;
        }

        /// <summary>
        /// Se termine quand quelqu'un perd/gagne un dé
        /// </summary>
        public void FinManche()
        {

        }
        

        public void Traiter(Decision dec)
        {
            if (dec.actionEncours == Action.bluff)
            {
                Debug.WriteLine("ActionBluff");
                verificationBluff();
            }
            else if(dec.actionEncours == Action.calza)
            {
                Debug.WriteLine("ActionCalza");

                verificationCalza();
            }
            else //Enchère
            {
                Debug.WriteLine("ActionEnchere");

                ChangerJoueurCourrant();
            }
        }

        public void verificationBluff()
        {
            
        }

        public void verificationCalza()
        {
            
        }

        void ChangerJoueurCourrant()
        {
            Debug.WriteLine("Changer le joueur courrant");
            SetJoueurEnCours(JoueurListDansManche);
            if (JoueurEnCours.GetTypeJoueur() == TypeJoueur.ordinateur)
            {
                Debug.WriteLine("IA");
                /* Decision decisionIA = JoueurEnCours(JoueurListDansManche).Jouer();
                 Traiter(decisionIA);*/
            }
        }


    }
}
