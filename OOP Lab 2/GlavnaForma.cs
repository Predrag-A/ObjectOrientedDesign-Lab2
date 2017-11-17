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
    public partial class GlavnaForma : Form
    {

        #region Constructors

        public GlavnaForma()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void LoadValues()
        {
            dataVozaci.DataSource = ListaVozaca.Instance.ListaVozacaValues.ToList();
            dataVozaci.Columns["DatumRodjenja"].Visible = false;
            dataVozaci.Columns["DozvolaOd"].Visible = false;
            dataVozaci.Columns["DozvolaDo"].Visible = false;
            dataVozaci.Columns["MestoIzdavanja"].Visible = false;
            dataVozaci.Columns["Pol"].Visible = false;
            dataVozaci.Columns["ImgPath"].Visible = false;

            if (dataVozaci.RowCount > 0)
            {
                btnObrisi.Enabled = true;
                btnIzmeni.Enabled = true;
                btnSortiraj.Enabled = true;
                cboxSort.Enabled = true;
            }
            else
            {
                btnObrisi.Enabled = false;
                btnIzmeni.Enabled = false;
                btnSortiraj.Enabled = false;
                cboxSort.Enabled = false;
            }
        }

        void Sort()
        {
            if (cboxSort.SelectedIndex == 0)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(Vozac.CompareBroj);
            else if (cboxSort.SelectedIndex == 1)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(Vozac.CompareIme);
            else if (cboxSort.SelectedIndex == 2)
                ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(Vozac.ComparePrezime);

            for (int i = 0; i < ListaVozaca.Instance.ListaVozacaValues.Count -1;i++)
                for (int j = 0; j < ListaVozaca.Instance.ListaVozacaValues.Count - 1; j++)
                    if (ListaVozaca.Instance.SortListDelegate(ListaVozaca.Instance.ListaVozacaValues[j], ListaVozaca.Instance.ListaVozacaValues[j + 1]))
                    {
                        Vozac tmp = new Vozac();
                        tmp = ListaVozaca.Instance.ListaVozacaValues[j];
                        ListaVozaca.Instance.ListaVozacaValues[j] = ListaVozaca.Instance.ListaVozacaValues[j + 1];
                        ListaVozaca.Instance.ListaVozacaValues[j + 1] = tmp;
                    }
        }

        #endregion

        #region Events

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new VozacForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LoadValues();
        }

        private void timerVreme_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            cboxSort.SelectedIndex = 0;
            lblVreme.Text = null;
            timerVreme.Start();
            LoadValues();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dataVozaci.SelectedRows.Count == 0)
                return;

            var form = new VozacForm(ListaVozaca.Instance.getVozac((string)(dataVozaci["BrojDozvole", dataVozaci.SelectedRows[0].Index]).Value));
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LoadValues();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataVozaci.SelectedRows.Count == 0)
                return;
            var forDel = ListaVozaca.Instance.getVozac((string)(dataVozaci["BrojDozvole", dataVozaci.SelectedRows[0].Index].Value));
            ListaVozaca.Instance.ListaVozacaValues.Remove(forDel);
            LoadValues();
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            if (ListaVozaca.Instance.ListaVozacaValues.Count > 1)
            {
                Sort();
                LoadValues();
            }
        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da napustite aplikaciju?",
                "Zatvori", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        #endregion

    }
    
}
