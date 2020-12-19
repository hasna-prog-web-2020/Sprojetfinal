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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Instancier un objet Ado
            adoNET Ado = new adoNET();
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
    }
}
