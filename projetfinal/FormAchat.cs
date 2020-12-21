using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projetfinal
{
    public partial class FormAchat : Form
    {
        public FormAchat()
        {
            InitializeComponent();
        }
        //Instanciation de la classe AdoNET
        
        AdoNET Ado;

        private void Form2_Load(object sender, EventArgs e)
        {
            // Instancier un objet Ado
             Ado = new AdoNET();
            //Début Query 
            //Écriture de la requête Sql 
            string Query = "SELECT * FROM Articles";
            //Préparation de l'objet command
            Ado.Command.CommandText = Query;
            //Ado.Command.CommandType = CommandType.Text;
            Ado.Command.Connection = Ado.Connection;
            //Préparation de l'objet Adapter
            Ado.Adapter.SelectCommand = Ado.Command;
            //Remplir le DataSet Ad.DsMagasin avec la résultat de la requête Query
            Ado.Adapter.Fill(Ado.DsMagasin);
            //Fin Query
            //la DataTable StArticle est égale à la première table (indice 0) du DataSet DsMagasin 
            Ado.DtArticles = Ado.DsMagasin.Tables[0];
            //Afficher la table Ado.DtArticles dans notre dataGridView
            this.dataGridView1.DataSource = Ado.DtArticles;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Parcourir les lignes du DataTable DtEtudiants
            foreach (DataRow row in Ado.DtArticles.Rows)
            {
                //Si le numéro de l'article existe dans la table, Afficher les informations de l'article
                if (row[0].ToString() == textBoxRecherche.Text)
                {
                    MessageBox.Show("Le numéro de référence : " + row[0] + "\n"
                        + "description : " + row[1] + "\n"
                        + "Le prix unitaire: " + row[2] + "\n"+ "Le nombre en inventaire : " + row[3] + "\n"+ "Le nom du vendeur : " + row[4] + "\n",
                        "Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                
            }
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Gestion d'erreur s'il y a rien de rentré ou pas de int
            try
            {  //Vérifie si le nbr entré est plus petit que le nbr de rows dans le Datagrid
                if (int.Parse(textBox2.Text) <= Ado.DtArticles.Rows.Count && int.Parse(textBox2.Text) > 0)
                {    //parcours tous les clients
                    foreach (Client cl in InfoCompte.ListeClients)
                    {
                        if (textBox1.Text == cl.NomCompte && textBox3.Text == cl.MotsPasse)
                        {
                            foreach (DataRow row in Ado.DtArticles.Rows)
                            {
                                //Si le numéro de l'article existe dans la table, Afficher les informations de l'article
                                if (row[0].ToString() == textBox2.Text && Convert.ToInt32(row[3]) > 0)
                                {
                                    MessageBox.Show("Le numéro de référence : " + row[0] + "\n"
                                        + "Description : " + row[1] + "\n"
                                        + "Le prix unitaire: " + row[2] + "\n" + "Le nombre en inventaire : " + row[3] + "\n" + "Le nom du vendeur : " + row[4] + "\n",
                                        "Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Achat act = new Achat(row[1].ToString(), 1, float.Parse(row[2].ToString()), textBox1.Text); //Création de l'achat
                                    InfoCompte.ListAchats.Add(act); //Ajout à la liste d'historique d'achat pour l'utilisateur
                                    MessageBox.Show("Votre achat a été effectué avec succès, merci d'avoir magasiné avec nous!  À la prochaine!");
                                    row[3] = Convert.ToInt32(row[3])-1;
                                    break;
                                }
                                else if (row[0].ToString() == textBox2.Text && Convert.ToInt32(row[3]) == 0)
                                {
                                    MessageBox.Show("L'article n'est pas en inventaire.");
                                    break;
                                }
                            }
                        }
                        break;
                    }
                    MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrecte!"); //Message d'erreur si le compte ou le mot de passe est incorrecte.
                }
                else
                {
                    MessageBox.Show("Vous devez entrer un numéro valide!"); //Message d'erreur si le numéro de l'objet est invalide (20 < num < 0)
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Erreur!"); } //Message d'erreur pour toute autre erreur avec le programme que le try catch va détecter.
        }


   

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
