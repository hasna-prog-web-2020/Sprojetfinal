using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetfinal
{
    public class Perssone
    {
        // Déclaration des champs privés
        private string nom;
        private string prenom;
        private char genre;
        private DateTime date_naissance;
        private string adresse;
        private string num_telephone;
        private string courriel;
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
        public char Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public DateTime DateNaissance
        {
            get { return date_naissance; }
            set { date_naissance = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Telephone
        {
            get { return num_telephone; }
            set { num_telephone = value; }
        }
        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }
        //Constructeur par défaut
        public Perssone()
        {
            nom = "";
            prenom = "";
            genre = '\0';
            adresse = "";
            num_telephone = "";
            courriel = "";
        }
        //Constructeur par paramètres
        public Perssone(string n, string p, char g, DateTime dt, string adr, string tel, string c)
        {
            nom = n;
            prenom = p;
            genre = g;
            date_naissance = dt;
            adresse = adr;
            num_telephone = tel;
            courriel = c;
        }

        // Méthode qui retourne un tableau contenant les différentes valeurs des attributs
        //Cette méthode sera surchargée dans la classe client
        public virtual string[] ToArray()
        {
            string[] proprietes = new string[7];
            proprietes[0] = nom;
            proprietes[1] = prenom;
            proprietes[2] = genre.ToString();
            proprietes[3] = date_naissance.ToString();
            proprietes[4] = adresse;
            proprietes[5] = num_telephone;
            proprietes[6] = courriel;
            return proprietes;
        }
    }
}
