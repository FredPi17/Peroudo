using System;
using System.Collections.Generic;
using System.Text;

namespace Perudo.Backend
{
    public class Decision
    {
        public Action actionEncours;
        public int de;
        public int nb;

        public Decision(Action action)
        {
            actionEncours = action;
        }

        public Decision(Action action, int de, int nb)
        {
            actionEncours = action;
            this.de = de;
            this.nb = nb;
        }
    }
}