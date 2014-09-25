using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_TP2
{
    public partial class AjouterInventaire : Form
    {
        public string description;
        public string fournisseur;
        public int qteStock;
        public int qteMin;
        public int qteMax;

        public AjouterInventaire()
        {
            InitializeComponent();
        }

        private void AjouterInventaire_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Accepter_Click(object sender, EventArgs e)
        {
            description = textBox_Description.Text.ToString();
            fournisseur = textBox_IDFournisseur.Text.ToString();
            qteStock = Int32.Parse(textBox_QteStock.Text.ToString());
            qteMin = Int32.Parse(textBox_QteMinimum.Text.ToString());
            qteMax = Int32.Parse(textBox_QteMaximum.Text.ToString());
        }
    }
}
