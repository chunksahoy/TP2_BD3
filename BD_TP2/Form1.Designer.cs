namespace BD_TP2
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
            this.DGV_Fournisseur = new System.Windows.Forms.DataGridView();
            this.DGV_Inventaire = new System.Windows.Forms.DataGridView();
            this.BTN_AddFournisseur = new System.Windows.Forms.Button();
            this.BTN_UpdateFournisseur = new System.Windows.Forms.Button();
            this.BTN_DeleteFournisseur = new System.Windows.Forms.Button();
            this.BTN_DeleteInventaire = new System.Windows.Forms.Button();
            this.BTN_UpdateInventaire = new System.Windows.Forms.Button();
            this.BTN_AddInventaire = new System.Windows.Forms.Button();
            this.DGV_LowStock = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_RechercheFournisseur = new System.Windows.Forms.TextBox();
            this.TB_RechercheInventaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LowStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Fournisseur
            // 
            this.DGV_Fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Fournisseur.Location = new System.Drawing.Point(94, 47);
            this.DGV_Fournisseur.Name = "DGV_Fournisseur";
            this.DGV_Fournisseur.Size = new System.Drawing.Size(240, 225);
            this.DGV_Fournisseur.TabIndex = 0;
            // 
            // DGV_Inventaire
            // 
            this.DGV_Inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventaire.Location = new System.Drawing.Point(94, 47);
            this.DGV_Inventaire.Name = "DGV_Inventaire";
            this.DGV_Inventaire.Size = new System.Drawing.Size(240, 225);
            this.DGV_Inventaire.TabIndex = 1;
            // 
            // BTN_AddFournisseur
            // 
            this.BTN_AddFournisseur.Location = new System.Drawing.Point(13, 47);
            this.BTN_AddFournisseur.Name = "BTN_AddFournisseur";
            this.BTN_AddFournisseur.Size = new System.Drawing.Size(75, 23);
            this.BTN_AddFournisseur.TabIndex = 2;
            this.BTN_AddFournisseur.Text = "Ajouter";
            this.BTN_AddFournisseur.UseVisualStyleBackColor = true;
            this.BTN_AddFournisseur.Click += new System.EventHandler(this.BTN_AddFournisseur_Click);
            // 
            // BTN_UpdateFournisseur
            // 
            this.BTN_UpdateFournisseur.Location = new System.Drawing.Point(13, 76);
            this.BTN_UpdateFournisseur.Name = "BTN_UpdateFournisseur";
            this.BTN_UpdateFournisseur.Size = new System.Drawing.Size(75, 23);
            this.BTN_UpdateFournisseur.TabIndex = 3;
            this.BTN_UpdateFournisseur.Text = "Modifier";
            this.BTN_UpdateFournisseur.UseVisualStyleBackColor = true;
            this.BTN_UpdateFournisseur.Click += new System.EventHandler(this.BTN_UpdateFournisseur_Click);
            // 
            // BTN_DeleteFournisseur
            // 
            this.BTN_DeleteFournisseur.Location = new System.Drawing.Point(13, 105);
            this.BTN_DeleteFournisseur.Name = "BTN_DeleteFournisseur";
            this.BTN_DeleteFournisseur.Size = new System.Drawing.Size(75, 23);
            this.BTN_DeleteFournisseur.TabIndex = 4;
            this.BTN_DeleteFournisseur.Text = "Supprimer";
            this.BTN_DeleteFournisseur.UseVisualStyleBackColor = true;
            this.BTN_DeleteFournisseur.Click += new System.EventHandler(this.BTN_DeleteFournisseur_Click);
            // 
            // BTN_DeleteInventaire
            // 
            this.BTN_DeleteInventaire.Location = new System.Drawing.Point(13, 105);
            this.BTN_DeleteInventaire.Name = "BTN_DeleteInventaire";
            this.BTN_DeleteInventaire.Size = new System.Drawing.Size(75, 23);
            this.BTN_DeleteInventaire.TabIndex = 7;
            this.BTN_DeleteInventaire.Text = "Supprimer";
            this.BTN_DeleteInventaire.UseVisualStyleBackColor = true;
            this.BTN_DeleteInventaire.Click += new System.EventHandler(this.BTN_DeleteInventaire_Click);
            // 
            // BTN_UpdateInventaire
            // 
            this.BTN_UpdateInventaire.Location = new System.Drawing.Point(13, 76);
            this.BTN_UpdateInventaire.Name = "BTN_UpdateInventaire";
            this.BTN_UpdateInventaire.Size = new System.Drawing.Size(75, 23);
            this.BTN_UpdateInventaire.TabIndex = 6;
            this.BTN_UpdateInventaire.Text = "Modifier";
            this.BTN_UpdateInventaire.UseVisualStyleBackColor = true;
            this.BTN_UpdateInventaire.Click += new System.EventHandler(this.BTN_UpdateInventaire_Click);
            // 
            // BTN_AddInventaire
            // 
            this.BTN_AddInventaire.Location = new System.Drawing.Point(13, 47);
            this.BTN_AddInventaire.Name = "BTN_AddInventaire";
            this.BTN_AddInventaire.Size = new System.Drawing.Size(75, 23);
            this.BTN_AddInventaire.TabIndex = 5;
            this.BTN_AddInventaire.Text = "Ajouter";
            this.BTN_AddInventaire.UseVisualStyleBackColor = true;
            this.BTN_AddInventaire.Click += new System.EventHandler(this.BTN_AddInventaire_Click);
            // 
            // DGV_LowStock
            // 
            this.DGV_LowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LowStock.Location = new System.Drawing.Point(19, 313);
            this.DGV_LowStock.Name = "DGV_LowStock";
            this.DGV_LowStock.Size = new System.Drawing.Size(688, 123);
            this.DGV_LowStock.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_RechercheFournisseur);
            this.groupBox1.Controls.Add(this.DGV_Fournisseur);
            this.groupBox1.Controls.Add(this.BTN_AddFournisseur);
            this.groupBox1.Controls.Add(this.BTN_UpdateFournisseur);
            this.groupBox1.Controls.Add(this.BTN_DeleteFournisseur);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 278);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_RechercheInventaire);
            this.groupBox2.Controls.Add(this.DGV_Inventaire);
            this.groupBox2.Controls.Add(this.BTN_AddInventaire);
            this.groupBox2.Controls.Add(this.BTN_UpdateInventaire);
            this.groupBox2.Controls.Add(this.BTN_DeleteInventaire);
            this.groupBox2.Location = new System.Drawing.Point(367, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 278);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // TB_RechercheFournisseur
            // 
            this.TB_RechercheFournisseur.Location = new System.Drawing.Point(94, 14);
            this.TB_RechercheFournisseur.Name = "TB_RechercheFournisseur";
            this.TB_RechercheFournisseur.Size = new System.Drawing.Size(240, 20);
            this.TB_RechercheFournisseur.TabIndex = 5;
            // 
            // TB_RechercheInventaire
            // 
            this.TB_RechercheInventaire.Location = new System.Drawing.Point(94, 14);
            this.TB_RechercheInventaire.Name = "TB_RechercheInventaire";
            this.TB_RechercheInventaire.Size = new System.Drawing.Size(240, 20);
            this.TB_RechercheInventaire.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recherche:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recherche:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_LowStock);
            this.Name = "Form1";
            this.Text = "Àmoé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LowStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Fournisseur;
        private System.Windows.Forms.DataGridView DGV_Inventaire;
        private System.Windows.Forms.Button BTN_AddFournisseur;
        private System.Windows.Forms.Button BTN_UpdateFournisseur;
        private System.Windows.Forms.Button BTN_DeleteFournisseur;
        private System.Windows.Forms.Button BTN_DeleteInventaire;
        private System.Windows.Forms.Button BTN_UpdateInventaire;
        private System.Windows.Forms.Button BTN_AddInventaire;
        private System.Windows.Forms.DataGridView DGV_LowStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_RechercheFournisseur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_RechercheInventaire;
    }
}

