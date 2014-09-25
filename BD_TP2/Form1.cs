using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD_TP2
{
    public partial class Form1 : Form
    {

        SqlConnection connexion;
        String connexionChaine = "Data Source=P104-16\\SQLEXPRESS2012; Initial Catalog=bdOperation; User ID=connOperation;Password=connOperation";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connexion = new SqlConnection(connexionChaine);
            try
            {
                connexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Initialize_DGV(DataGridView dgv)
        {

        }
        private void AjoutFournisseur()
        {
            AjouterFournisseur form = new AjouterFournisseur();

            string sql = "";
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SqlCommand sqlInsert = new SqlCommand();
                    sqlInsert.Connection = connexion;

                    sqlInsert.CommandType = CommandType.Text;

                    sql = "insert into fournisseur (nomfournisseur, adfournisseur, villefournisseur, cpfournisseur, telfournisseur, soldefournisseur, courrielfournisseur)" +
                         " values ('" + form.nom + "', '" + form.addresse + "', '" + form.ville + "', '" + form.codepostale + "', '"
                         + form.telephone + "', " + form.solde + ", '" + form.courriel + "')";

                    sqlInsert.CommandText = sql;
                    sqlInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }
        private void AjoutInventaire()
        {
            AjouterInventaire form = new AjouterInventaire();
            string sql = "";
            string sqlSelect = "select * from fournisseur where idfournisseur=";
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SqlCommand sqlInsert = connexion.CreateCommand();

                    sqlInsert.CommandType = CommandType.Text;

                    sql = "insert into inventaire (descriptioninventaire, idfournisseur, qtestock, qteminimum, qtemaximum)" +
                         " values ('" + form.description + "', " + form.fournisseur + ", " + form.qteStock + ", " + form.qteMin + ", "
                         + form.qteMax + ")";


                    sqlSelect += form.fournisseur;
                    SqlCommand sqlSel = connexion.CreateCommand();
                    sqlSel.CommandType = CommandType.Text;
                    sqlSel.CommandText = sqlSelect;

                    SqlDataReader sqlread = sqlSel.ExecuteReader();

                    if (sqlread.Read())
                    {
                        sqlInsert.CommandText = sql;
                        sqlread.Close();
                        sqlInsert.ExecuteNonQuery();
                    }
                    else
                    {
                        sqlread.Close();
                        MessageBox.Show("Erreur: Ce fournisseur n'existe pas!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void UpdateFournisseur()
        {
            AjouterFournisseur form = new AjouterFournisseur();

            string sql = "";
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SqlCommand sqlUpdate = connexion.CreateCommand();

                    sqlUpdate.CommandType = CommandType.Text;

                    sql = "update fournisseur set nomfournisseur='" + form.nom + "', adfournisseur='" + form.addresse + "', villefournisseur='" +  form.ville + "',"
                        + "cpfournisseur='" + form.codepostale + "', telfournisseur='" + form.telephone + ", soldefournisseur=" + form.solde + ", courrielfournisseur='" + form.courriel + "' where idfournisseur=";

                    sqlUpdate.CommandText = sql;
                    sqlUpdate.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void UpdateInventaire()
        {
            AjouterInventaire form = new AjouterInventaire();

            string sql = "";
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SqlCommand sqlUpdate = connexion.CreateCommand();

                    sqlUpdate.CommandType = CommandType.Text;

                    sql = "update inventaire set descriptionInventaire='" + form.description + "', qteStock=" + form.qteStock +
                        ", qteMin=" + form.qteMin + ", qteMax=" + form.qteMax;

                    sqlUpdate.CommandText = sql;
                    sqlUpdate.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void SupprFournisseur()
        {

        }
        private void SupprInventaire()
        {

        }
        private void SearchFournisseur()
        {

        }
        private void SearchInventaire()
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connexion.Close();
        }

        private void BTN_AddFournisseur_Click(object sender, EventArgs e)
        {
            AjoutFournisseur();
        }

        private void BTN_UpdateFournisseur_Click(object sender, EventArgs e)
        {
            UpdateFournisseur();
        }

        private void BTN_DeleteFournisseur_Click(object sender, EventArgs e)
        {
            SupprFournisseur();
        }

        private void BTN_AddInventaire_Click(object sender, EventArgs e)
        {
            AjoutInventaire();
        }

        private void BTN_UpdateInventaire_Click(object sender, EventArgs e)
        {
            UpdateInventaire();
        }

        private void BTN_DeleteInventaire_Click(object sender, EventArgs e)
        {
            SupprInventaire();
        }

    }
}
