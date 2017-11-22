using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    class Des
    {
        public int DiceRoll()
        {
            int result;
            Random rnd = new Random();

            result = rnd.Next(1, 7);
            return result;
        }
    }
}
