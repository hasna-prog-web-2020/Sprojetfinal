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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void AfficherElecteurListview(Achat a)
        {
            string[] arr = new string[3];
            ListViewItem itm;
            //Préparer les items dans un tableau
            arr[0] = a.Produit;
            arr[2] = a.Qantite.ToString();
            arr[1] = a.Montant.ToString();
            //Créer un ListViewItem
            itm = new ListViewItem(arr);
            //Ajouter la l'item ListViewItem à la listView1
            listView1.Items.Add(itm);

        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bool trouve = false;
            //Parcourir le dictionnaire des électeurs de la classe Election pour afficher tous les électeurs de la circonscription choisie par l'utilisateur
            foreach (Achat ach in InfoCompte.ListAchats)
            {
                if (ach.NomCompte == textBox1.Text) //Si l'électeur est inscrit dans la circonscription choisie par l'utilisateur
                {
                    AfficherElecteurListview(ach); //Afficher les attributs de l'électeur en question dans la listView1
                                                          // Noter que item.value correspond à l'objet Electeur dont le numéro d'électeur correspond au numéro entré par l'utilisateur  

                    trouve = true;
                }
            }
            if (trouve == false)// Si pas d'électeurs inscrits dans la circonscription choisie par l'utilisateur
                MessageBox.Show("Pas d'électeurs dans la circonscription " + textBox1.Text, "Message");
        }
    }
}
