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
    public partial class KategorijaForm : Form
    {

        #region Attributes

        List<DozvolaKategorije> lista;
        List<DozvolaKategorije> zabrane;

        #endregion

        #region Constructors

        private KategorijaForm()
        {
            InitializeComponent();
        }

        public KategorijaForm(List<DozvolaKategorije> l)
        {
            InitializeComponent();
            lista = l;
        }

        public KategorijaForm(List<DozvolaKategorije> dozvole, List<DozvolaKategorije> lzabrane)
        {
            InitializeComponent();
            lista = dozvole;
            zabrane = lzabrane;
        }

        #endregion

        #region Methods

        public DozvolaKategorije IzForme()
        {
            DozvolaKategorije temp = new DozvolaKategorije();
            temp.DatumDo = dtpDatumDo.Value;
            temp.DatumOd = dtpDatumOd.Value;
            temp.Kategorije = (Kategorija)DozvolaKategorije.ParseIndex(cboxKategorija.Text);
            return temp;
        }

        #endregion

        #region Events

        private void KategorijaForm_Load(object sender, EventArgs e)
        {
            if (zabrane!=null)
            {
                foreach (var k in lista) {
                    cboxKategorija.Items.Add(k.Kategorije);
                }
            }

            else
                cboxKategorija.DataSource = Enum.GetValues(typeof(Kategorija));
            
            cboxKategorija.SelectedIndex = 0;
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (zabrane!=null)
            {
                foreach (var k in zabrane)
                    if (k.Kategorije == (Kategorija)DozvolaKategorije.ParseIndex(cboxKategorija.Text))
                    {

                        MessageBox.Show("Ova zabrana je vec dodata za ovog vozaca.",
                                        "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                zabrane.Add(IzForme());
            }
            else
            {
                foreach (var k in lista)
                    if (k.Kategorije == (Kategorija)DozvolaKategorije.ParseIndex(cboxKategorija.Text))
                    {

                        MessageBox.Show("Ova kategorija je vec dodata za ovog vozaca.",
                                        "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                lista.Add(IzForme());
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.Date;
        }

        #endregion

    }
}
