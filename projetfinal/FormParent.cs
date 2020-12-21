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
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void firstPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutCompte elc1 = new FormAjoutCompte();
            elc1.MdiParent = this;
            elc1.Show();

        }

        private void listeDesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAchat elc = new FormAchat();
            elc.MdiParent = this;
            elc.Show();
        }

        private void historiqueDachatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistorique elc2 = new FormHistorique();
            elc2.MdiParent = this;
            elc2.Show();
        }
    }
}
