using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perudo;
using Perudo.Backend;
using Perudo.Views;
using Xamarin.Forms;
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
        public static Joueur JoueurPasse { get; set; }
        public static Decision AncienneEnchere { get; set; }
        public static Partie MainPartie { get; set; }
        public static int nbManche { get; set; }
        public static int nbRound { get; set; }
        public static string actionJoueur { get; set; }



        /// <summary>
        /// Permet de retourner l'ID du joueur en train de jouer
        /// </summary>
        /// <param name="joueurlist"></param>
        /// <returns></returns>
        public void SetJoueurEnCours(List<Joueur> joueurlist, int Index)
        {
            JoueurEnCours = joueurlist[Index];
        }
        

        /// <summary>
        /// Permet de retourner l'ID du dernier joueur ayant joué
        /// </summary>
        /// <param name="joueurlist"></param>
        /// <returns></returns>
        public void SetJoueurPasse(List<Joueur> joueurlist)
        {
            int indexPrecedent = GetIndexJoueurPrecedent();
            if (numTour != 0)
            {
                JoueurPasse = JoueurListDansManche[indexPrecedent]; //le Joueur précédent
            }
            else
            {
                JoueurPasse = JoueurListDansManche[IndexJoueurEnCours]; //Le Joueur qui est en train de joueur
            }
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
            nbManche = 1;
            nbRound = 1;
            actionJoueur = "";
            string proposition = "0";

            SetJoueurEnCours(JoueurListDansManche, IndexJoueurEnCours);
            MainManche = this;
        }

        /// <summary>
        /// Se termine quand quelqu'un perd/gagne un dé
        /// Je ne sais pas si elle est utile celle là
        /// </summary>
        public void FinManche()
        {

        }
        

        public void Traiter(Decision dec)
        {
            if (dec.actionEncours == Action.bluff)
            {
                Debug.WriteLine("ActionBluff");
                nbManche += 1;
                verificationBluff();
            }
            else if(dec.actionEncours == Action.calza)
            {
                Debug.WriteLine("ActionCalza");
                nbManche += 1;
                verificationCalza();
            }
            else //Enchère
            {
                Debug.WriteLine("ActionEnchere");
                AncienneEnchere = dec;
                nbRound += 1;
                Debug.WriteLine($"dec : {dec.nb} dés de {dec.de}");
                Debug.WriteLine($"AncienneEnchère: {AncienneEnchere.nb} dés de {AncienneEnchere.de}");
                ChangerJoueurCourrant();
            }
        }

        public void verificationBluff()
        {
            //Renvois vrai si l'enchère précedente est vrai, on vérifis donc le nombre total de valeur dé.
            //On comparer alors DésEnCours et NbEnCours dans l'objet Decision par le nombre total de la valeur de tous les dés
            var valeur = AncienneEnchere.de.ToString();
            int NbDes = Partie.MainPartie.GetNbDes(valeur);
            //Si c'est vrai le bluff fonctionne alors le joueur précédent perd un dé
            if (NbDes > AncienneEnchere.nb)
            {
               JoueurPasse.SetNbDes(JoueurPasse.GetNbDes() - 1);
               Debug.WriteLine("Le joueur précédent perd un dés");
               foreach (var joueur in JoueurListDansManche)
               {
                   joueur.SetDes();
               }
            }
            //Sinon c'est que le bluff n'a pas fonctionné et c'est le joueur actuel qui perd un dé.
            else
            {
               JoueurEnCours.SetNbDes(JoueurEnCours.GetNbDes() - 1);
               Debug.WriteLine("Le joueur actuel perd un dés");

               foreach (var joueur in Partie.MainPartie.JoueurList)
               {
                   joueur.SetDes();
               }
            }
            ChangerJoueurCourrant();
        }

        public void verificationCalza()
        {
            var valeur = AncienneEnchere.de.ToString();
            int NbDes = Partie.MainPartie.GetNbDes(valeur);
            //Si c'est vrai le bluff fonctionne alors le joueur précédent perd un dé
            if (NbDes == AncienneEnchere.nb)
            {
                if (JoueurEnCours.GetNbDes() >= 5)
                {
                    Debug.WriteLine("Le joueur a assez de dés pour en gagner un de plus");
                    foreach (var joueur in JoueurListDansManche)
                    {
                        joueur.SetDes();
                    }
                }
                else
                {
                    JoueurEnCours.SetNbDes(JoueurEnCours.GetNbDes() + 1);
                    Debug.WriteLine("Le joueur actuel gagne un dé");
                    actionJoueur = JoueurEnCours.Getpseudo() + " gagne un dé";

                    foreach (var joueur in JoueurListDansManche)
                    {
                        joueur.SetDes();
                    }
                }
                ChangerJoueurCourrant();
            }
            //Sinon c'est que le bluff n'a pas fonctionné et c'est le joueur actuel qui perd un dé.
            else
            {
                JoueurEnCours.SetNbDes(JoueurEnCours.GetNbDes() - 1);
                Debug.WriteLine("Le joueur actuel perd un dé");
                actionJoueur = JoueurEnCours.Getpseudo() + " perd un dé";

                foreach (var joueur in JoueurListDansManche)
                {
                    joueur.SetDes();
                }
                ChangerJoueurCourrant();
            }
        }

        void ChangerJoueurCourrant()
        {
            Debug.WriteLine("Changer le joueur courant");
            //On dice roll les dés de tous les joueurs.
            JoueurPasse = JoueurEnCours;
            if (JoueurEnCours.GetNbDes() == 0)
            {
                JoueurEnCours.Resultat(IndexJoueurEnCours, true);
            }
                if (Partie.MainPartie.FinJeu())
                {
                    //Faire appel à la page de fin.
                    Application.Current.MainPage = new NavigationPage(new Page4());
                }
                else
                {
                    do
                    {
                        if (IndexJoueurEnCours == JoueurListDansManche.Count - 1)
                        {
                            IndexJoueurEnCours = 0;
                        }
                        else
                        {
                            IndexJoueurEnCours++;
                        }
                        SetJoueurEnCours(JoueurListDansManche, IndexJoueurEnCours);

                    } while (!JoueurEnCours.IsAlive());
                    Debug.WriteLine($"Joueur En Cours après: {JoueurEnCours.Getpseudo()}");

                    var np = new NavigationPage(new Page3());
                    Application.Current.MainPage = np;
                }

            if (JoueurEnCours.GetTypeJoueur() == TypeJoueur.ordinateur)
            {
                Debug.WriteLine("IA");
                /* Decision decisionIA = JoueurEnCours(JoueurListDansManche).Jouer();
                 Traiter(decisionIA);*/
            }
        }


    }
}
