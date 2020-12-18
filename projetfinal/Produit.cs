using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public class Produit
    {
        private int no_ref;
        private int quantite_stock;
        private float prix_unitaire;

        public int NumeroProduit
        {
            get { return no_ref; }
            set { no_ref = value; }
        }
        public int Quantite
        {
            get { return quantite_stock; }
            set { quantite_stock = value; }
        }
        public float Montant
        {
            get { return prix_unitaire; }
            set { prix_unitaire = value; }
        }

        public Produit()
        {
            no_ref = 0;
            quantite_stock = 0;
            prix_unitaire = 0;
        }


        public Produit( int nump, int qt, int prx)
        {
            no_ref = nump;
            quantite_stock = qt;
            prix_unitaire = prx;
        }
        // Méthode qui retourne un tableau contenant les différentes valeurs des attributs
        //Cette méthode sera surchargée dans la classe vendeur
        public virtual string[] ToArray()
        {
            string[] proprietes = new string[3];
            proprietes[0] = no_ref.ToString(); ;
            proprietes[1] = quantite_stock.ToString(); ;
            proprietes[2] = prix_unitaire.ToString();
           
            return proprietes;
        }


    }
}
