using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    //Création des attributs de la classe InfoCompte
    public static class InfoCompte
    {
        private static List<Client> listClients;
        private static List<Achat> listAchats;
        //Création des propriétés des attributs
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
        //Méthode statique qui créé 2 listes : client et achat.
        static InfoCompte()
        {
            listClients = new List<Client>();
            listAchats = new List<Achat>();
        }

        public static int CompterNb()  // compte le nb de client dans la liste.
        {
            return listClients.Count();
        }
    }
}