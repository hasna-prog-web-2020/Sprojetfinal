using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public static class InfoCompte
    {
       /* private static Dictionary<int, Client> listClients;

        public static Dictionary<int, Client> ListeClients
        {
            get { return listClients; }
            set { listClients = value; }
        }

        static InfoCompte()
        {
            listClients = new Dictionary<int, Client>();
        }

        public static void CompterNb()  // compte le nb de client dans la liste ??
        {
            listClients.Count();
        }*/
        private static List<Client> listClients;
        private static List<Achat> listAchats;

        public static List<Achat> ListAchats
        {
            get { return listAchats; }
            set { listAchats = value; }
        }
        public static List<Client> ListeClients
        {
            get { return listClients; }
            set { listClients = value; }
        }

        static InfoCompte()
        {
            listClients = new List<Client>();
            listAchats = new List<Achat>();
        }

        public static int CompterNb()  // compte le nb de client dans la liste ??
        {
            return listClients.Count();
        }
    }
}