using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZadaca3
{
    public partial class ZahtjevForm : Form
    {
        private Zahtjev zahtjev;

        public ZahtjevForm(Zahtjev zahtjev)
        {
            InitializeComponent();
            this.zahtjev = zahtjev;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ZahtjevForm_Load(object sender, EventArgs e)
        {
            if (zahtjev != null)
            {
                tbxPodnositelj.Text = zahtjev.podnositelj;
                tbxPredmetNabave.Text = zahtjev.opis_predmeta_nabave;
                tbxProjekt.Text = zahtjev.naziv_projekta;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (zahtjev == null)
            {
                DB.OpenConnection();

                string naredba = $"insert into zahtjev (podnositelj, opis_predmeta_nabave, naziv_projekta) " +
                    $"values ('{tbxPodnositelj.Text}', '{tbxPredmetNabave.Text}', '{tbxProjekt.Text}')";
                DB.ExecuteCommand(naredba);

                DB.CloseConnection();
            }
            else
            {
                DB.OpenConnection();

                string naredba = $"update zahtjev set podnositelj = '{tbxPodnositelj.Text}', opis_predmeta_nabave = " +
                    $"'{tbxPredmetNabave.Text}', naziv_projekta = '{tbxProjekt.Text}' where id = {zahtjev.id}";
                DB.ExecuteCommand(naredba);

                DB.CloseConnection();
            }
            Close();
        }
    }
}
