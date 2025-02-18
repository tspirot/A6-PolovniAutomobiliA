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

namespace A6_PolovniAutomobiliA
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection
            (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\A6.mdf;Integrated Security=True");
        DataTable dtm = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuniComboProizvodjaca();
            PopuniListuModela();
        }
        private void PopuniComboProizvodjaca()
        {
            string upit = "SELECT * FROM Proizvodjac";
            SqlCommand cmd = new SqlCommand(upit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtp = new DataTable();
            try
            {
                da.Fill(dtp);
                comboBoxProizvodjac.DataSource=dtp;
                comboBoxProizvodjac.DisplayMember = "Naziv";
                comboBoxProizvodjac.ValueMember = "ProizvodjacID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopuniListuModela()
        {
            string upit = "SELECT m.ModelID, m.Naziv, p.Naziv " +
                "FROM Model AS m, Proizvodjac AS p " +
                "WHERE m.ProizvodjacID=p.ProizvodjacID";
            SqlCommand cmd = new SqlCommand(upit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dtm);
                foreach (DataRow dr in dtm.Rows)
                {
                    string red = string.Format("{0,-6}{1}, {2}",
                        dr[0], dr[1], dr[2]);
                    listBox1.Items.Add(red);    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                int selind = listBox1.SelectedIndex;
                textBoxSifra.Text = dtm.Rows[selind][0].ToString();
                textBoxNaziv.Text = dtm.Rows[selind][1].ToString();
                comboBoxProizvodjac.Text = dtm.Rows[selind][2].ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int idm;
            if (int.TryParse(textBoxSifra.Text, out idm))
            {
                for (int i = 0; i < dtm.Rows.Count; i++)
                {
                    if (idm == (int)dtm.Rows[i][0])
                    {
                        listBox1.SelectedIndex = i;
                        return;
                    }
                }
                MessageBox.Show("Model sa šifrom " + idm + " ne postoji!");
            }
            else
            {
                MessageBox.Show("Unesite celobrojnu šifru!");
            }
            textBoxSifra.Focus();
            textBoxSifra.SelectAll();
        }
    }
}
