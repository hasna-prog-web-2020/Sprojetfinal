using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    class Achat
    {
        private  Dictionary<int, Produit> listProduits;
        private  int quantite;
        private  float montant;

        public  int Qantite
        {
            get { return quantite; }
            set { quantite = value; }
        }


        public  float Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        public  Dictionary<int, Produit> ListProduits
        {
            get { return listProduits; }
            set { listProduits = value; }
        }


       public Achat()
        {
            quantite = 0;
            montant = 0;
            listProduits = null;
            listProduits = new Dictionary<int, Produit>();
        }
        public Achat(Dictionary<int, Produit> lst,int qt,float mt)
        {
            listProduits = lst;
            quantite = qt;
            montant = mt;

        }

     

    }
}
