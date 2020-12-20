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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void firstPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 elc1 = new Form3();
            elc1.MdiParent = this;
            elc1.Show();

        }

        private void listeDesArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 elc = new Form2();
            elc.MdiParent = this;
            elc.Show();
        }

        private void historiqueDachatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 elc2 = new Form4();
            elc2.MdiParent = this;
            elc2.Show();
        }
    }
}
