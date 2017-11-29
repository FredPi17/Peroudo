using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Des
    {
        public string valeur;
        private Randomizer randomizer;

        public Des(Randomizer randomizer)
        {
            this.randomizer = randomizer;
            valeur = this.DiceRoll();
        }

        public string DiceRoll()
        {
            int result;
            string valeur;

            string toto = randomizer.Next(1, 7).ToString();
            return toto;
        }
    }
}
