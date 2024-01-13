using Adresar.DB.Stores;
using Adresar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Adresar.UI
{
    public partial class PopisKontakataForm : Form
    {
        public PopisKontakataForm()
        {
            InitializeComponent();
            KontaktStore store = new KontaktStore();
            var kontakti = store.GetKontakt();
            dgKontakti.DataSource = kontakti;
            
    }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontaktStore kontaktStore = new KontaktStore();

            Kontakt kontakt = new Kontakt
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Adresa = txtAdresa.Text,
                Broj_telefona = txtTelefon.Text
            };

            kontaktStore.DodajKontakt(kontakt);
            dgKontakti.DataSource = kontaktStore.GetKontakt();
        }


        int selectedId;
        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            KontaktStore kontaktStore = new KontaktStore();

            Kontakt kontakt = new Kontakt();
            kontakt.ID = selectedId;
            kontakt.Ime = txtIme.Text;
            kontakt.Prezime = txtPrezime.Text;
            kontakt.Adresa = txtAdresa.Text;
            kontakt.Broj_telefona = txtTelefon.Text;

            kontaktStore.AžurirajKontakt(kontakt);
            dgKontakti.DataSource = kontaktStore.GetKontakt();


        }

        private void dgKontakti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgKontakti.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["ID"].Value);
                txtIme.Text = row.Cells["Ime"].Value.ToString();
                txtPrezime.Text = row.Cells["Prezime"].Value.ToString();
                txtAdresa.Text = row.Cells["Adresa"].Value.ToString();
                txtTelefon.Text = row.Cells["Broj_telefona"].Value.ToString();
            }
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
            KontaktStore kontaktStore = new KontaktStore();

            Kontakt kontakt = new Kontakt();
            kontakt.ID = selectedId;
            kontakt.Ime = txtIme.Text;
            kontakt.Prezime = txtPrezime.Text;
            kontakt.Adresa = txtAdresa.Text;
            kontakt.Broj_telefona = txtTelefon.Text;

            kontaktStore.ObrišiKontakt(kontakt);
            dgKontakti.DataSource = kontaktStore.GetKontakt();
        }

        private void btnTraži_Click(object sender, EventArgs e)
        {
            KontaktStore kontaktStore = new KontaktStore();
            dgKontakti.DataSource = kontaktStore.Pretraga(txtTraži.Text);
        }
    }
}
