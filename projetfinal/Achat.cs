using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    //Création des attributs
    public class Achat
    {
        private string produit;
        private int quantite;
        private float montant;
        private string nomcompte;

        //Définitions des propriétés des attributs.
        public int Qantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public string NomCompte
        {
            get { return nomcompte; }
            set { nomcompte = value; }
        }


        public  float Montant
        {
            get { return montant; }
            set { montant = value; }
        }
         
        public string Produit
        {
            get { return produit; }
            set { produit = value; }
        }


        /// <summary>
        /// Constructeur pour la classe Achat
        /// </summary>
       public Achat()
        {
            quantite = 1;
            montant = 0;
            produit = "";
        }

        /// <summary>
        /// Constructeur avec paramètres pour la classe achat
        /// </summary>
        /// <param name="pd"></param> Produit
        /// <param name="qt"></param> Quantité
        /// <param name="mt"></param> Montant
        /// <param name="nc"></param> NomCompte
        public Achat(string pd,int qt,float mt,string nc)
        {
            quantite = qt;
            montant = mt;
            nomcompte = nc;
            produit = pd;
        }
    }
}
