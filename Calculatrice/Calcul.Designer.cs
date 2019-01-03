namespace Calculatrice
{
    partial class Calcul
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.valeur = new System.Windows.Forms.Label();
            this.reste = new System.Windows.Forms.RadioButton();
            this.produit = new System.Windows.Forms.RadioButton();
            this.pgcd = new System.Windows.Forms.RadioButton();
            this.entier2 = new System.Windows.Forms.TextBox();
            this.entier1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            this.calculer = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.RadioButton();
            this.soustraction = new System.Windows.Forms.RadioButton();
            this.division = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.valeur);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(271, 188);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(205, 104);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Resultat";
            // 
            // valeur
            // 
            this.valeur.AutoSize = true;
            this.valeur.Location = new System.Drawing.Point(31, 49);
            this.valeur.Name = "valeur";
            this.valeur.Size = new System.Drawing.Size(55, 20);
            this.valeur.TabIndex = 0;
            this.valeur.Text = "Valeur";
            // 
            // reste
            // 
            this.reste.AutoSize = true;
            this.reste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reste.Location = new System.Drawing.Point(32, 211);
            this.reste.Name = "reste";
            this.reste.Size = new System.Drawing.Size(233, 24);
            this.reste.TabIndex = 19;
            this.reste.TabStop = true;
            this.reste.Text = "Calculer le reste de la division";
            this.reste.UseVisualStyleBackColor = true;
            // 
            // produit
            // 
            this.produit.AutoSize = true;
            this.produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.Location = new System.Drawing.Point(32, 172);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(153, 24);
            this.produit.TabIndex = 18;
            this.produit.TabStop = true;
            this.produit.Text = "Calculer le produit";
            this.produit.UseVisualStyleBackColor = true;
            // 
            // pgcd
            // 
            this.pgcd.AutoSize = true;
            this.pgcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgcd.Location = new System.Drawing.Point(32, 132);
            this.pgcd.Name = "pgcd";
            this.pgcd.Size = new System.Drawing.Size(150, 24);
            this.pgcd.TabIndex = 17;
            this.pgcd.TabStop = true;
            this.pgcd.Text = "Calculer le PGCD";
            this.pgcd.UseVisualStyleBackColor = true;
            // 
            // entier2
            // 
            this.entier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entier2.Location = new System.Drawing.Point(375, 75);
            this.entier2.Name = "entier2";
            this.entier2.Size = new System.Drawing.Size(76, 26);
            this.entier2.TabIndex = 16;
            this.entier2.TextChanged += new System.EventHandler(this.entier2_TextChanged);
            this.entier2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entier2_KeyPress);
            // 
            // entier1
            // 
            this.entier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entier1.Location = new System.Drawing.Point(162, 75);
            this.entier1.Name = "entier1";
            this.entier1.Size = new System.Drawing.Size(76, 26);
            this.entier1.TabIndex = 15;
            this.entier1.TextChanged += new System.EventHandler(this.entier1_TextChanged);
            this.entier1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entier1_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(297, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 20);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Entier 2 :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(84, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 20);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Entier 1 :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(183, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(140, 24);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Entrez 2 entiers";
            // 
            // quitter
            // 
            this.quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(398, 392);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(106, 31);
            this.quitter.TabIndex = 23;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // nouveau
            // 
            this.nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.Location = new System.Drawing.Point(217, 392);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(106, 31);
            this.nouveau.TabIndex = 22;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // calculer
            // 
            this.calculer.Enabled = false;
            this.calculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculer.Location = new System.Drawing.Point(32, 392);
            this.calculer.Name = "calculer";
            this.calculer.Size = new System.Drawing.Size(106, 31);
            this.calculer.TabIndex = 21;
            this.calculer.Text = "Calculer";
            this.calculer.UseVisualStyleBackColor = true;
            this.calculer.Click += new System.EventHandler(this.calculer_Click);
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(32, 250);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(150, 24);
            this.addition.TabIndex = 24;
            this.addition.TabStop = true;
            this.addition.Text = "Calculer l\'addition";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // soustraction
            // 
            this.soustraction.AutoSize = true;
            this.soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soustraction.Location = new System.Drawing.Point(32, 293);
            this.soustraction.Name = "soustraction";
            this.soustraction.Size = new System.Drawing.Size(191, 24);
            this.soustraction.TabIndex = 25;
            this.soustraction.TabStop = true;
            this.soustraction.Text = "Calculer la soustraction";
            this.soustraction.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(32, 334);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(155, 24);
            this.division.TabIndex = 27;
            this.division.TabStop = true;
            this.division.Text = "Calculer la division";
            this.division.UseVisualStyleBackColor = true;
            // 
            // Calcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 446);
            this.Controls.Add(this.division);
            this.Controls.Add(this.soustraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.reste);
            this.Controls.Add(this.produit);
            this.Controls.Add(this.pgcd);
            this.Controls.Add(this.entier2);
            this.Controls.Add(this.entier1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.calculer);
            this.Name = "Calcul";
            this.Text = "Calcul";
            this.Load += new System.EventHandler(this.Calcul_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label valeur;
        internal System.Windows.Forms.RadioButton reste;
        internal System.Windows.Forms.RadioButton produit;
        internal System.Windows.Forms.RadioButton pgcd;
        internal System.Windows.Forms.TextBox entier2;
        internal System.Windows.Forms.TextBox entier1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button quitter;
        internal System.Windows.Forms.Button nouveau;
        internal System.Windows.Forms.Button calculer;
        internal System.Windows.Forms.RadioButton addition;
        internal System.Windows.Forms.RadioButton soustraction;
        internal System.Windows.Forms.RadioButton division;
    }
}

