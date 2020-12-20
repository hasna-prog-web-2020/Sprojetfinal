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
    public partial class Form2 : Form
    {
        public Form2()
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
            //Remplir le DataSet Ad.DsMagasin avec la résultat de la requête Quert (Dans ce cas le résultat est la table Etudiant) 
            Ado.Adapter.Fill(Ado.DsMagasin);
            //Fin Query
            //la DataTable StArticle est égale à la première table (indice 0) du DataSet DsMagasin 
            Ado.DtArticles = Ado.DsMagasin.Tables[0];
            //Afficher la table Ado.DtEtudiant dans notre dataGridView
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
                //Si le numéro de l'étudiant existe dans la table, Afficher les informations de l'étudiant 
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
            /*
            foreach ( Client cl in InfoCompte.ListeClients)
            if (textBox1.Text != cl.NomCompte)
            {
                    MessageBox.Show("veuiller svp selectionner numéro d'usager");
                    return;

                }*/
            /* foreach (DataRow row in Ado.DtArticles.Rows)
             {

                 if (row[0].ToString() != textBox2.Text)
                 {

                     MessageBox.Show("veuiller svp selectionner un no article");
                     return;

                 }

             }*/


            //gestion d'erreure s'il y a rien de rentré ou pas un int
            try
            {  //si le nbr rentré est plus petit le nbr rows dans le datagrid
                if (int.Parse(textBox2.Text) <= Ado.DtArticles.Rows.Count)
                {    //parcours tous les clients
                    foreach (Client cl in InfoCompte.ListeClients)
                        if (textBox1.Text == cl.NomCompte)
                        {
                            MessageBox.Show("yessss");

                            foreach (DataRow row in Ado.DtArticles.Rows)
                            {
                                //Si le numéro de l'étudiant existe dans la table, Afficher les informations de l'étudiant 
                                if (row[0].ToString() == textBox2.Text)
                                {
                                    MessageBox.Show("Le numéro de référence : " + row[0] + "\n"
                                        + "description : " + row[1] + "\n"
                                        + "Le prix unitaire: " + row[2] + "\n" + "Le nombre en inventaire : " + row[3] + "\n" + "Le nom du vendeur : " + row[4] + "\n",
                                        "Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    Achat act = new Achat(row[1].ToString(), 1, float.Parse(row[2].ToString()), textBox1.Text);
                                    InfoCompte.ListAchats.Add(act);

                                }

                            }


                            return;

                        }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Erreur"); }

        }


   

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
