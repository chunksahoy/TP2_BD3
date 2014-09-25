namespace BD_TP2
{
    partial class AjouterInventaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Accepter = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_IDFournisseur = new System.Windows.Forms.TextBox();
            this.textBox_QteStock = new System.Windows.Forms.TextBox();
            this.textBox_QteMinimum = new System.Windows.Forms.TextBox();
            this.textBox_QteMaximum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Fournisseur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qte Maximum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qte Minimum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Qte Stock";
            // 
            // BTN_Accepter
            // 
            this.BTN_Accepter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Accepter.Location = new System.Drawing.Point(293, 114);
            this.BTN_Accepter.Name = "BTN_Accepter";
            this.BTN_Accepter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accepter.TabIndex = 6;
            this.BTN_Accepter.Text = "Accepter";
            this.BTN_Accepter.UseVisualStyleBackColor = true;
            this.BTN_Accepter.Click += new System.EventHandler(this.BTN_Accepter_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(374, 114);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(92, 25);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(122, 20);
            this.textBox_Description.TabIndex = 7;
            // 
            // textBox_IDFournisseur
            // 
            this.textBox_IDFournisseur.Location = new System.Drawing.Point(92, 51);
            this.textBox_IDFournisseur.Name = "textBox_IDFournisseur";
            this.textBox_IDFournisseur.Size = new System.Drawing.Size(122, 20);
            this.textBox_IDFournisseur.TabIndex = 7;
            // 
            // textBox_QteStock
            // 
            this.textBox_QteStock.Location = new System.Drawing.Point(92, 80);
            this.textBox_QteStock.Name = "textBox_QteStock";
            this.textBox_QteStock.Size = new System.Drawing.Size(123, 20);
            this.textBox_QteStock.TabIndex = 7;
            // 
            // textBox_QteMinimum
            // 
            this.textBox_QteMinimum.Location = new System.Drawing.Point(326, 21);
            this.textBox_QteMinimum.Name = "textBox_QteMinimum";
            this.textBox_QteMinimum.Size = new System.Drawing.Size(123, 20);
            this.textBox_QteMinimum.TabIndex = 7;
            // 
            // textBox_QteMaximum
            // 
            this.textBox_QteMaximum.Location = new System.Drawing.Point(327, 47);
            this.textBox_QteMaximum.Name = "textBox_QteMaximum";
            this.textBox_QteMaximum.Size = new System.Drawing.Size(123, 20);
            this.textBox_QteMaximum.TabIndex = 7;
            // 
            // AjouterInventaire
            // 
            this.AcceptButton = this.BTN_Accepter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(467, 149);
            this.Controls.Add(this.textBox_QteMaximum);
            this.Controls.Add(this.textBox_IDFournisseur);
            this.Controls.Add(this.textBox_QteMinimum);
            this.Controls.Add(this.textBox_QteStock);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Accepter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AjouterInventaire";
            this.Text = "AjouterInventaire";
            this.Load += new System.EventHandler(this.AjouterInventaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Accepter;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_IDFournisseur;
        private System.Windows.Forms.TextBox textBox_QteStock;
        private System.Windows.Forms.TextBox textBox_QteMinimum;
        private System.Windows.Forms.TextBox textBox_QteMaximum;
    }
}