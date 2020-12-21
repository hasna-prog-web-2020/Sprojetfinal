using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetfinal
{
    public partial class FormHistorique : Form
    {
        //Création du délégé pour utiliser un object, aucun return.
        private delegate void DelegateShow(Achat a);
        public FormHistorique()
        {
            InitializeComponent();
        }
        //Méthode qui servira de remplir la listView avec les achats de clients.
        public void AfficherProduitListview(Achat a)
        {
            string[] arr = new string[3];
            ListViewItem itm;
            //Préparer les items dans un tableau
            arr[0] = a.Produit;
            arr[2] = a.Qantite.ToString();
            arr[1] = a.Montant.ToString();
            //Créer un ListViewItem
            itm = new ListViewItem(arr);
            //Ajouter la l'item ListViewItem à la listView1.
            listView1.Items.Add(itm);
        }
        //Méthode qui affiche les produits dans un MessageBox.
        public void AfficherProduit(Achat a)
        {
            string s = "";
            s += "Le produit : " + a.Produit + "\n";
            s += "La quantité : " + a.Qantite.ToString() + "\n";
            s += "Le prix : " + a.Montant.ToString() + "\n";
            MessageBox.Show(s);
        }
        //Méthode qui affiche les utilisateurs dans un MessageBox.
        public void AfficherUtilisateur(Achat a)
        {
            foreach(Client c in InfoCompte.ListeClients)
            {
                if(a.NomCompte == c.NomCompte)
                {
                    string s = "";
                    s += "Prénom : " + c.Prenom + "\n";
                    s += "Nom : " + c.Nom + "\n";
                    s += "Nom d'utilisateur : " + c.NomCompte + "\n";
                    s += "Adresse : " + c.Adresse + "\n";
                    s += "Ville : " + c.Ville + "\n";
                    s += "Province : " + c.Province + "\n";
                    s += "Numéro de téléphone : " + c.Telephone + "\n";
                    MessageBox.Show(s);
                }
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bool trouve = false;
            //Parcourir la liste d'achats de la classe InfoCompte pour afficher tous les achats de l'utilisateur choisie
            foreach (Achat ach in InfoCompte.ListAchats)
            {
                if (ach.NomCompte == textBox1.Text) //Si l'utilisateur est inscrit.
                {
                    AfficherProduitListview(ach); //Afficher les attributs de l'utilisateur en question dans la listView1                                 
                    trouve = true;
                }
            }
            if (trouve == false)// Si aucun article acheter dans l'historique choisie par l'utilisateur
                MessageBox.Show("Pas d'article dans l'historique :  " + textBox1.Text, "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Achat ach in InfoCompte.ListAchats)
            {
                if (ach.NomCompte == textBox1.Text) //Si l'utilisateur est inscrit.
                {
                    DelegateShow show = AfficherUtilisateur;
                    show(ach);
                    show = AfficherProduit;
                    show(ach);
                }
            }
        }
    }
}
