using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;


namespace sauvegarde_partie
{
    class exportimport
    {
        public static string Save(Partie partie)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(partie);
        }

        public static Partie Load(string jsonPartie)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Partie>(jsonPartie);
        }
    }
}
