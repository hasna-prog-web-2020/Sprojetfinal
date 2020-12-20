namespace projetfinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firstPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDachatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstPageToolStripMenuItem,
            this.listeDesArticlesToolStripMenuItem,
            this.historiqueDachatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firstPageToolStripMenuItem
            // 
            this.firstPageToolStripMenuItem.Name = "firstPageToolStripMenuItem";
            this.firstPageToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.firstPageToolStripMenuItem.Text = "création usagés";
            this.firstPageToolStripMenuItem.Click += new System.EventHandler(this.firstPageToolStripMenuItem_Click);
            // 
            // listeDesArticlesToolStripMenuItem
            // 
            this.listeDesArticlesToolStripMenuItem.Name = "listeDesArticlesToolStripMenuItem";
            this.listeDesArticlesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.listeDesArticlesToolStripMenuItem.Text = "liste des articles";
            this.listeDesArticlesToolStripMenuItem.Click += new System.EventHandler(this.listeDesArticlesToolStripMenuItem_Click);
            // 
            // historiqueDachatToolStripMenuItem
            // 
            this.historiqueDachatToolStripMenuItem.Name = "historiqueDachatToolStripMenuItem";
            this.historiqueDachatToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.historiqueDachatToolStripMenuItem.Text = "historique d\'achat";
            this.historiqueDachatToolStripMenuItem.Click += new System.EventHandler(this.historiqueDachatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firstPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDachatToolStripMenuItem;
    }
}

