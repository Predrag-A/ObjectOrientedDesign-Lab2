using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;

namespace OOP_Lab_2
{
    public partial class VozacForm : Form
    {

        #region Attributes

        public Vozac vozac;
        List<DozvolaKategorije> listaKategorija;
        List<DozvolaKategorije> listaZabrana;

        #endregion

        #region Constructors

        public VozacForm()
        {
            InitializeComponent();
            cboxPol.Items.Add("M");
            cboxPol.Items.Add("Z");
        }

        public VozacForm(Vozac v) : this()
        {
            vozac = v;
            btnProsledi.Text = "Izmeni";
            txtBrojDozvole.Enabled = false;
            UKontrolu(vozac);
        }

        #endregion

        #region Methods

        bool Validacija()
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtIme.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Polje Prezime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtPrezime.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtMesto.Text))
            {
                MessageBox.Show("Polje Mesto izdavanja ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtMesto.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtBrojDozvole.Text))
            {
                MessageBox.Show("Polje Br. vozacke dozvole izdavanja ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtBrojDozvole.Focus();
                return false;
            }

            if (pboxSlika.ImageLocation == null && btnProsledi.Text == "Prosledi")
            {
                MessageBox.Show("Vozac mora imati sliku.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                btnDodajSliku.Focus();
                return false;
            }

            return true;
        }
        
        Vozac IzKontrole()
        {
            Vozac temp = new Vozac(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value, dtpDozvolaOd.Value,
                dtpDozvolaDo.Value, txtBrojDozvole.Text, txtMesto.Text, true, listaKategorija, listaZabrana, pboxSlika.ImageLocation);
            if (cboxPol.SelectedIndex == 0)
                temp.Pol = false;
            else
                temp.Pol = true;
            return temp;
        }

        void LoadValues()
        {
            if (listaKategorija.Count == 0)
            {
                btnObrisiKategoriju.Enabled = false;
                btnDodajZabranu.Enabled = false;
                brnObrisiZabranu.Enabled = false;
            }
            else
            {
                btnObrisiKategoriju.Enabled = true;
                btnDodajZabranu.Enabled = true;
            }

            if(listaZabrana.Count == 0)            
                brnObrisiZabranu.Enabled = false;            
            else
                brnObrisiZabranu.Enabled = true;

            dataKategorije.DataSource = listaKategorija.ToList();
            dataZabrane.DataSource = listaZabrana.ToList();

            dataKategorije.Columns["Kategorije"].Visible = false;
            dataZabrane.Columns["Kategorije"].Visible = false;

            if (vozac != null)
            {
                if (vozac.ImgPath != null)
                    pboxSlika.Image = Image.FromFile(vozac.ImgPath);
            }
        }

        void UKontrolu(Vozac v)
        {
            txtIme.Text = v.Ime;
            txtPrezime.Text = v.Prezime;
            dtpDatumRodjenja.Value = v.DatumRodjenja;
            dtpDozvolaOd.Value = v.DozvolaOd;
            dtpDozvolaDo.Value = v.DozvolaDo;
            txtBrojDozvole.Text = v.BrojDozvole;
            txtMesto.Text = v.MestoIzdavanja;
            if (v.Pol)
                cboxPol.SelectedItem = 1;
            else
                cboxPol.SelectedItem = 0;
            listaKategorija = v.ListaKategorija;
            listaZabrana = v.ListaZabrana;
            pboxSlika.Image = Image.FromFile(v.ImgPath);
        }

        #endregion

        #region Events

        private void txtBrojDozvole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        

        private void VozacForm_Load(object sender, EventArgs e)
        {
            cboxPol.SelectedIndex = 0;
            if (listaKategorija == null)
                listaKategorija = new List<DozvolaKategorije>();
            if (listaZabrana == null)
                listaZabrana = new List<DozvolaKategorije>();
            LoadValues();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;
            if(vozac == null)
            {
                if (!ListaVozaca.Instance.dodajVozaca(IzKontrole()))
                {
                    MessageBox.Show("Neuspesno dodavanje. Pokusajte ponovo.",
                                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Focus();
                    return;
                }                
            }
            else
            {
                if (!ListaVozaca.Instance.izmeniVozaca(IzKontrole()))
                {
                    MessageBox.Show("Neuspesna izmena. Pokusajte ponovo.",
                                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIme.Focus();
                    return;
                }
            }
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            var form = new KategorijaForm(listaKategorija);
            if (form.ShowDialog() == DialogResult.OK)
                LoadValues();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dataKategorije.SelectedRows.Count == 0)
                return;
            for (int i = 0; i < listaKategorija.Count; i++)            
                if (listaKategorija[i].Kategorije==(Kategorija)dataKategorije["Kategorije", dataKategorije.SelectedRows[0].Index].Value)
                {
                    listaKategorija.RemoveAt(i);
                    LoadValues();
                    break;
                }            
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {
            if(listaKategorija.Count == 0)
            {
                MessageBox.Show("Vozac ne poseduje nijednu kategoriju koja se moze zabraniti.",
                                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var form = new KategorijaForm(listaKategorija, listaZabrana);
            if (form.ShowDialog() == DialogResult.OK)
                LoadValues();
        }

        private void brnObrisiZabranu_Click(object sender, EventArgs e)
        {
            if (dataZabrane.SelectedRows.Count == 0)
                return;
            for (int i = 0; i < listaZabrana.Count; i++)
                if (listaZabrana[i].Kategorije == (Kategorija)dataZabrane["Kategorije", dataZabrane.SelectedRows[0].Index].Value)
                {
                    listaZabrana.RemoveAt(i);
                    LoadValues();
                    break;
                }
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pboxSlika.ImageLocation = ofd.FileName;
                pboxSlika.Image = Image.FromFile(ofd.FileName);
            }
        }        

        private void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {
            dtpDozvolaOd.MinDate = dtpDatumRodjenja.Value.Date;
        }

        private void dtpDozvolaOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDozvolaDo.MinDate = dtpDozvolaOd.Value.Date;
        }

        #endregion
    }
    
}
