using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perudo;

namespace ConsoleApp1
{
    public class Manche
    {
        public List<Joueur> JoueurListDansManche;
        public Manche(List<Joueur> JoueurList)
        {
            JoueurListDansManche = JoueurList;
        }
    }
}
