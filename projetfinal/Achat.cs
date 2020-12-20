using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public class Achat
    {
        /* private  Dictionary<int, Produit> listProduits;*/
        private string produit;
        private  int quantite;
        private  float montant;
        private string nomcompte;

        public  int Qantite
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
       /* public  Dictionary<int, Produit> ListProduits
        {
            get { return listProduits; }
            set { listProduits = value; }
        }*/


       public Achat()
        {
            quantite = 1;
            montant = 0;
            produit = "";
           /* listProduits = null;
            listProduits = new Dictionary<int, Produit>();*/
        }
        public Achat(/*Dictionary<int, Produit> lst*/string pd,int qt,float mt,string nc)
        {
            /*listProduits = lst;*/
            quantite = qt;
            montant = mt;
            nomcompte = nc;
            produit = pd;

        }

     

    }
}
