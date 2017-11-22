using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    class Des
    {
        private static Random _rand = new Random();
        // Fonction qui retourne le resultat d'un dé 6 faces
        static int UnDeSixFaces()
        {
            int Lancer = _rand.Next(1, 7);
            return Lancer;
        }





        static void Main(string[] args)
        {
            int Lancer;


            // Boucle pour faire une centaines de lancers
            for (int i = 1; i <= 100; i++)
            {

                // Appel de la fonction pour avoir un résultat de dé.
                Lancer = UnDeSixFaces();



                // Pour que tous les 10 lancers je passe a la ligne.
                if ((i % 10) == 0)
                    Console.WriteLine(" {0} ", Lancer);
                else
                    Console.Write(" {0} ", Lancer);

            }
            Console.ReadKey();
        }
    }
}
