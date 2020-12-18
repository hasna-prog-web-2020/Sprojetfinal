using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public class Client : Perssone
    {

        //Champs privés
        private int num_client;
        private string nom_compte;
        private string mots_passe;

        //Accesseurs (propriétés)
        public int NumeroClient
        {
            get { return num_client; }
            set { num_client = value; }
        }
        public string NomCompte
        {
            get { return nom_compte; }
            set { nom_compte = value; }
        }
        public string MotsPasse
        {
            get { return mots_passe; }
            set { mots_passe = value; }
        }

        public Client()
        {
            num_client = 0;
            nom_compte = "";
            mots_passe = "";

        }

        public Client(string n, string p, char g, DateTime dt, string adr, string tel, string c, int numclient, string nmcompt, string mtspss) : base(n, p, g, dt, adr, tel, c)
        {
            num_client = numclient;
            nom_compte = nmcompt;
            mots_passe = mtspss;

        }


        // Méthode surchargée dans la classe fille client
        public override string[] ToArray()
        {
            //récuperer le tableau des proprietés de la classe parent personne
            string[] proprietes1 = base.ToArray();
            // créer un tableau pour acceuillir toutes les proprietés
            string[] proprietes = new string[proprietes1.Length + 2];
            // copier les proprietés héritées  
            proprietes1.CopyTo(proprietes, 0);
            // compléter le tableau proprietes avec les propriétés de la classe fille
            proprietes[7] = num_client.ToString();
            proprietes[8] = nom_compte;
            proprietes[9] = mots_passe;
            return proprietes;

        }

    }
}