using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace projetfinal
{
    public partial class FormAjoutCompte : Form
    {
        public FormAjoutCompte()
        {
            InitializeComponent();
        }
        public bool Verif_RegexNP(string chaine)
        {
            //Du labo élection
            Regex Reg = new Regex("^[A-Z]{1}[A-Za-z]{1,20}$");
            return Reg.IsMatch(chaine);
        }

        public bool Verif_RegexA(string chaine)
        {
            //Du labo élection
            Regex Reg = new Regex(@"^[0-9]{1,4},[a-zA-Z]+$");
            return Reg.IsMatch(chaine);
        }

        public bool Verif_RegexU(string chaine)
        {
            //https://stackoverflow.com/questions/12018245/regular-expression-to-validate-username/12019115
            Regex Reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
            return Reg.IsMatch(chaine);
        }

        public bool Verif_RegexT(string chaine)
        {
            //Du labo élection
            Regex Reg = new Regex(@"(^(\d{3})\ \d{3}-\d{4})|(^\d{3}\ \d{3}-\d{4})$");
            return Reg.IsMatch(chaine);
        }

        public bool Verif_RegexV(string chaine)
        {
            //https://stackoverflow.com/questions/11757013/regular-expressions-for-city-name
            Regex Reg = new Regex("^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$");
            return Reg.IsMatch(chaine);
        }

        public bool Verif_RegexMdp(string chaine)
        {
            //https://stackoverflow.com/questions/19605150/regex-for-password-must-contain-at-least-eight-characters-at-least-one-number-a
            Regex Reg = new Regex(@"^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{8,}$");
            return Reg.IsMatch(chaine);
        }

        public void Initialiser(bool b_nom, bool b_prenom, bool b_prov, bool b_ville, bool b_adresse, bool b_nomCompte, bool b_numTel, bool b_mdp)
        {
            if (!b_nom) textBox1.Text = "";
            if (!b_prenom) textBox2.Text = "";
            if (!b_prov) comboBox1.SelectedIndex = -1;
            if (!b_ville) textBox4.Text = "";
            if (!b_adresse) textBox5.Text = "";
            if (!b_nomCompte) textBox6.Text = "";
            if (!b_numTel) textBox7.Text = "";
            if (!b_mdp) textBox8.Text = "";
        }

        //Méthode qui permet d'afficher les messages d'erreur selectivement
        public void Afficher_messages(bool b_nom, bool b_prenom, bool b_prov, bool b_ville, bool b_adresse, bool b_nomCompte, bool b_numTel, bool b_mdp)
        {
            string s = "";
            if (b_nom == false) s += "Le nom doit commencer par une majuscule suivie de 1 à 20 caractères. \n";
            if (b_prenom == false) s += "Le prénom doit commencer par une majuscule suivie de 1 à 20 caractères.\n";
            if (b_prov == false) s += "Vous devez choisir une province. (Choisir de la sélection) \n";
            if (b_ville == false) s += "Vous devez entrer une ville. (Commence par majuscule, aucun caractère spécial successif)\n";
            if (b_adresse == false) s += "Vous devez entrer une adresse. (Maximum de 4 chiffres suivis d'une virgule suivie d'une suite de lettres) \n";
            if (b_nomCompte == false) s += "Vous devez entrer un nom de compte unique. (8-20 caractères, chiffres, lettres, barre en bas et point. Un point et/ou un barre en bas ne peut pas se succéder ou débuter / finir le nom. Aucun espace) \n";
            if (b_numTel == false) s += "Vous devez entrer un numéro de téléphone valide. ((ccc) ccc-cccc ou ccc ccc-cccc) \n";
            if (b_mdp == false) s += "Vous devez entrer un mot de passe valide (min 8 caractère, 1 maj, 1 min, 1 chiffre, 1 car spécial). \n";
            MessageBox.Show(s, "Message(s) d'erreur");
        }

            private void button1_Click(object sender, EventArgs e)
        {
            //Initialiser les booleens
            bool b_nom = false;
            bool b_prenom = false;
            bool b_prov = false;
            bool b_ville = false;
            bool b_adresse = false;
            bool b_nomuti = false;
            bool b_numtel = false;
            bool b_mdp = false;
            //Vérifier les contrôles et mettre le résultat dans les booleens
            if (Verif_RegexNP(textBox1.Text)) b_nom = true;
            if (Verif_RegexNP(textBox2.Text)) b_prenom = true;
            if (comboBox1.SelectedIndex != -1) b_prov = true;
            if (Verif_RegexV(textBox4.Text)) b_ville = true;
            if (Verif_RegexA(textBox5.Text)) b_adresse = true;
            if (Verif_RegexU(textBox6.Text)) b_nomuti = true;
            if (Verif_RegexT(textBox7.Text)) b_numtel = true;
            if (Verif_RegexMdp(textBox8.Text)) b_mdp = true;
            //Tester les booléens
            //Si tous sont à vrai, instancier un objet Client et l'ajouter la la liste statique listClients
            //Et initialiser les contrôles
            if (b_nom && b_prenom && b_prov && b_ville && b_adresse && b_nomuti && b_numtel && b_mdp)
            {
                foreach (Client cl in InfoCompte.ListeClients) //Vérification des duplicats
                    if (textBox1.Text == cl.NomCompte)
                    {
                        MessageBox.Show("Votre nom n'est pas unique, veuillez essayer de le changer."); 
                        break; // On brise le code et on ne créé pas de compte, l'utilisateur 
                    }
                //Création d'un client
                Client cli = new Client(textBox1.Text, textBox2.Text, comboBox1.Text, textBox4.Text, textBox5.Text, textBox7.Text, textBox6.Text, textBox8.Text);
                InfoCompte.ListeClients.Add(cli);
                Initialiser(!b_nom, !b_prenom, !b_prov, !b_ville, !b_adresse, !b_nomuti, !b_numtel, !b_mdp);
                    
            }// Sinon afficher les messages d'erreur selectivement dans une MessageBox
             // et réinitialiser les contrôles
            else
            {
                Afficher_messages(b_nom, b_prenom, b_prov, b_ville, b_adresse, b_nomuti, b_numtel, b_mdp);
                Initialiser(b_nom, b_prenom, b_prov, b_ville, b_adresse, b_nomuti, b_numtel, b_mdp);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void labelnomutilisateur_Click(object sender, EventArgs e)
        {

        }
    }
}
