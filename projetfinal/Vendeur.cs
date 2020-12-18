using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public class Vendeur : Produit
    {
        private int no_fournisseur;
        private string nom_fournisseur;
        private string contact_fournisseur;
        private int tele_fournisseur;

        public int NumeroFournisseur
        {
            get { return no_fournisseur; }
            set { no_fournisseur = value; }
        }
        public string ContactFournisseur
        {
            get { return contact_fournisseur; }
            set { contact_fournisseur = value; }
        }
        public string NomFournisseur
        {
            get { return nom_fournisseur; }
            set { nom_fournisseur = value; }
        }
        public int TeleFournisseur
        {
            get { return tele_fournisseur; }
            set { tele_fournisseur = value; }
        }

        public Vendeur()
        {
            nom_fournisseur = "";
            no_fournisseur = 0;
            contact_fournisseur = "";
            tele_fournisseur = 0;
        }

        public Vendeur(int nump, int qt, int prx, string nmf, int nof, string ctf, int tlf) : base(nump, qt, prx)
        {
            nom_fournisseur = nmf;
            no_fournisseur = nof;
            contact_fournisseur = ctf;
            tele_fournisseur = tlf;
        }

        public override string[] ToArray()                            
         {
            //récuperer le tableau des proprietés de la classe parent produit
            string[] proprietes1 = base.ToArray();
        // créer un tableau pour acceuillir toutes les proprietés
            string[] proprietes = new string[proprietes1.Length + 2];
            // copier les proprietés héritées  
            proprietes1.CopyTo(proprietes, 0);
            // compléter le tableau proprietes avec les propriétés de la classe fille
            proprietes[3] = nom_fournisseur;
            proprietes[4] = no_fournisseur.ToString();
            proprietes[5] = contact_fournisseur;
            proprietes[6] = tele_fournisseur.ToString();
            return proprietes;
         }
    }
}
