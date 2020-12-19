using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projetfinal
{
    class AdoNET
    {
       

        //Attributs privés
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtArticles;
        private DataSet dsMagasin;
        //Propriétés
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }
        public DataTable DtArticles { get => dtArticles; set => dtArticles = value; }
        public DataSet DsMagasin { get => dsMagasin; set => dsMagasin = value; }

        //Constructeur
        public AdoNET()
        {   //Changer cette chaine de connexion ici avant  d'exécuter votre programme
            connectionString = "Data Source=WELSH\\MONSQL;Initial Catalog=BibliothèqueArticles;Integrated Security=True";//element different d'un compte à l'autre
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsMagasin = new DataSet();
            dtArticles = new DataTable();

        }

    }
}
