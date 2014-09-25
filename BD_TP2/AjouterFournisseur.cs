using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_TP2
{
    public partial class AjouterFournisseur : Form
    {
        public string nom;
        public string addresse;
        public string ville;
        public string codepostale;
        public string telephone;
        public int solde;
        public string courriel;

        public AjouterFournisseur()
        {
            InitializeComponent();
        }

        private void AjouterFournisseur_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            nom = textBox_Nom.Text.ToString();
            addresse = textBox_Adresse.Text.ToString();
            ville = textBox_Ville.Text.ToString();
            codepostale = textBox_CodePostal.Text.ToString();
            telephone = textBox_Telephone.Text.ToString();
            solde = Int32.Parse(textBox_Solde.Text.ToString());
            courriel = textBox_Courriel.Text.ToString();
        }
    }
}
