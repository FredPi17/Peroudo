using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Randomizer
    {
        private Random random = new Random();

        public int Next(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
