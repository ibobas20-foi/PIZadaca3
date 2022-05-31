using DBLayer;
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

namespace PIZadaca3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DB.SetConfiguration("ibobas20_DB", "ibobas20", "2Dea-6zw");
        }

        public void UcitajPodatke()
        {
            dgvZahtjevi.DataSource = null;
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader("select * from zahtjev");
            while (reader.Read())
            {
                Zahtjev zahtjev = new Zahtjev();
                zahtjev.id = reader.GetInt32(0);
                zahtjev.podnositelj = reader.GetString(1);
                zahtjev.opis_predmeta_nabave = reader.GetString(2);
                zahtjev.naziv_projekta = reader.GetString(3);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();

            dgvZahtjevi.DataSource = zahtjevi;
        }

        public void UcitajPodatke(string predmetNabave)
        {
            dgvZahtjevi.DataSource = null;
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            DB.OpenConnection();
            string upit = $"select * from zahtjev where opis_predmeta_nabave like '%{predmetNabave}%'";
            SqlDataReader reader = DB.GetDataReader(upit);
            while (reader.Read())
            {
                Zahtjev zahtjev = new Zahtjev();
                zahtjev.id = reader.GetInt32(0);
                zahtjev.podnositelj = reader.GetString(1);
                zahtjev.opis_predmeta_nabave = reader.GetString(2);
                zahtjev.naziv_projekta = reader.GetString(3);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();

            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxPredmetNabave.Text))
            {
                UcitajPodatke(tbxPredmetNabave.Text);
                tbxPredmetNabave.Text = "";
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.CurrentRow != null && dgvZahtjevi.CurrentRow.DataBoundItem != null)
            {
                Zahtjev zahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
                
                DB.OpenConnection();
                string naredba = $"delete from zahtjev where id = {zahtjev.id}";
                DB.ExecuteCommand(naredba);
                DB.CloseConnection();
                UcitajPodatke();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZahtjevForm zahtjevForm = new ZahtjevForm(null);
            zahtjevForm.ShowDialog();
            UcitajPodatke();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvZahtjevi.CurrentRow != null && dgvZahtjevi.CurrentRow.DataBoundItem != null)
            {
                Zahtjev zahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
                ZahtjevForm zahtjevForm = new ZahtjevForm(zahtjev);
                zahtjevForm.ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
