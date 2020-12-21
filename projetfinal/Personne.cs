using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public class Personne
    {
        // Déclaration des champs privés
        private string nom;
        private string prenom;
        private string adresse;
        private string ville;
        private string province;
        private string num_telephone;
        //Déclaration des propriétés
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        public string Telephone
        {
            get { return num_telephone; }
            set { num_telephone = value; }
        }

        //Constructeur par défaut
        public Personne()
        {
            nom = "";
            prenom = "";
            adresse = "";
            ville = "";
            province = "";
            num_telephone = "";
        }
        //Constructeur par paramètres
        public Personne(string n, string p, string adr, string v, string pv, string tel)
        {
            nom = n;
            prenom = p;
            adresse = adr;
            ville = v;
            province = pv;
            num_telephone = tel;
        }

        // Méthode qui retourne un tableau contenant les différentes valeurs des attributs
        //Cette méthode sera surchargée dans la classe client
        public virtual string[] ToArray()
        {
            string[] proprietes = new string[6];
            proprietes[0] = nom;
            proprietes[1] = prenom;
            proprietes[2] = adresse;
            proprietes[3] = ville;
            proprietes[4] = province;
            proprietes[5] = num_telephone;
            return proprietes;
        }
    }
}
