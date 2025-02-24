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
                dtm.Clear(); // DODATO
                da.Fill(dtm);
                listBox1.Items.Clear(); // DODATO
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

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if(textBoxNaziv.Text.Length == 0)
            {
                MessageBox.Show("Unesite naziv modela!");
                textBoxNaziv.Focus();
                return;
            }
            int idm;
            if(!int.TryParse(textBoxSifra.Text, out idm))
            {
                MessageBox.Show("Unesite celobrojnu šifru!");
                textBoxSifra.Focus();
                textBoxSifra.SelectAll();
                return;
            }
            // Provera da li postoji model sa unetom šifrom
            int dtmi = -1;
            for (int i = 0; i < dtm.Rows.Count; i++)
                if(idm == (int) dtm.Rows[i][0])
                {
                    dtmi = i;
                    break;
                }
            if (dtmi == -1)
            {
                MessageBox.Show("Model sa šifrom " + idm + " ne postoji!");
                textBoxSifra.Focus();
                textBoxSifra.SelectAll();
                return;
            }
            string upit = "UPDATE Model " +
                "SET Naziv=@mnaz, ProizvodjacID=@pid " +
                "WHERE ModelID=@mid";
            SqlCommand cmd = new SqlCommand(upit, conn);
            cmd.Parameters.AddWithValue("@mnaz", textBoxNaziv.Text);
            cmd.Parameters.AddWithValue("@pid", comboBoxProizvodjac.SelectedValue);
            cmd.Parameters.AddWithValue("@mid", idm);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Model je uspešno izmenjen!");
                PopuniListuModela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuspesna izmena!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if (textBoxKM.Text != "" && int.Parse(textBoxKM.Text) != 0)
            {
                // sql3 je srtring SQL upita koji vraća dve kolone: Proizvodjac i Broj
                // razmaci na kraju stringova su neophodni kada spajamo stringove
                string sql3 = "SELECT p.Naziv AS Proizvodjac, COUNT(v.VoziloID) AS Broj " +
                            "FROM Vozilo AS v, Model AS m, Proizvodjac AS p " + // izmedju vozila i proizvodjaca je tabela model, moramo i nju uključiti
                            "WHERE p.ProizvodjacID=m.ProizvodjacID " + // veza izmedju proizvodjjaca i modela
                            "AND m.ModelID=v.ModelID " + // veza izmedju modela i vozila
                            "AND (v.GodinaProizvodnje >= @od " +
                            "AND v.GodinaProizvodnje <= @do) " +
                            "AND v.PredjenoKM < @km " +
                            "GROUP BY p.Naziv";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql3;
                cmd.Connection = conn; // konekcija je u ovom slučaju već kreirana kao polje forme pri kreiranju forme
                cmd.Parameters.AddWithValue("@od", (int)numericUpDownOd.Value); // Value je Decimal tipa
                cmd.Parameters.AddWithValue("@do", (int)numericUpDownDo.Value);
                cmd.Parameters.AddWithValue("@km", int.Parse(textBoxKM.Text)); // Text je String tipa
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtp = new DataTable(); // upit vraća jednu tabelu pa je dovoljan DataTable umesto DataSet
                try
                {
                    da.Fill(dtp); // ova naredba najčešće baca izuzetak: loš konekcioni string, sql upit.... 
                    listView1.Items.Clear();
                    foreach (DataRow row in dtp.Rows)
                    {
                        ListViewItem li = new ListViewItem(row[0].ToString());
                        li.SubItems.Add(row[1].ToString());
                        listView1.Items.Add(li);
                    }
                    // prikaz Chart-a
                    chart1.DataSource = dtp;
                    chart1.Series[0].XValueMember = "Proizvodjac"; // X-osa: naziv kolone iz SELECT upita
                    chart1.Series[0].YValueMembers = "Broj"; // Y-osa: naziv kolone iz SELECT upita
                    chart1.Series[0].IsValueShownAsLabel = false; // bez ovog svojstva neće prikazati Chart, prikaz vrednsoti

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message); // zbog utvrdjivanja uzroka greške prikazaćemo i detalje
                }
                finally
                {
                    // zatvorimo konekciju ka bazi što je bitno ukoliko je baza na serveru
                    if (conn != null)
                        conn.Close();
                    // eksplicitno očistiti iz memorije dinamičke objekte kreirane new operatorom 
                    cmd.Dispose();
                    da.Dispose();
                    dtp.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Unesite pređenu kilometražu !");
                textBoxKM.Focus();
                return;
            }
        }
    }
}
