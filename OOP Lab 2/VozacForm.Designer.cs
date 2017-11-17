namespace OOP_Lab_2
{
    partial class VozacForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VozacForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPodaci = new System.Windows.Forms.GroupBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.pboxSlika = new System.Windows.Forms.PictureBox();
            this.cboxPol = new System.Windows.Forms.ComboBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.txtBrojDozvole = new System.Windows.Forms.TextBox();
            this.dtpDozvolaDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDozvolaOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblMestoIzdavanja = new System.Windows.Forms.Label();
            this.lblBrojVozacke = new System.Windows.Forms.Label();
            this.lblDozvolaDo = new System.Windows.Forms.Label();
            this.lblDozvolaOd = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.groupKategorija = new System.Windows.Forms.GroupBox();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.dataKategorije = new System.Windows.Forms.DataGridView();
            this.groupZabrana = new System.Windows.Forms.GroupBox();
            this.brnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.dataZabrane = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.groupPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).BeginInit();
            this.groupKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategorije)).BeginInit();
            this.groupZabrana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataZabrane)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPodaci
            // 
            this.groupPodaci.Controls.Add(this.btnDodajSliku);
            this.groupPodaci.Controls.Add(this.pboxSlika);
            this.groupPodaci.Controls.Add(this.cboxPol);
            this.groupPodaci.Controls.Add(this.txtMesto);
            this.groupPodaci.Controls.Add(this.txtBrojDozvole);
            this.groupPodaci.Controls.Add(this.dtpDozvolaDo);
            this.groupPodaci.Controls.Add(this.dtpDozvolaOd);
            this.groupPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.groupPodaci.Controls.Add(this.txtPrezime);
            this.groupPodaci.Controls.Add(this.txtIme);
            this.groupPodaci.Controls.Add(this.lblPol);
            this.groupPodaci.Controls.Add(this.lblMestoIzdavanja);
            this.groupPodaci.Controls.Add(this.lblBrojVozacke);
            this.groupPodaci.Controls.Add(this.lblDozvolaDo);
            this.groupPodaci.Controls.Add(this.lblDozvolaOd);
            this.groupPodaci.Controls.Add(this.lblDatum);
            this.groupPodaci.Controls.Add(this.lblPrezime);
            this.groupPodaci.Controls.Add(this.lblIme);
            this.groupPodaci.Location = new System.Drawing.Point(13, 4);
            this.groupPodaci.Name = "groupPodaci";
            this.groupPodaci.Size = new System.Drawing.Size(403, 269);
            this.groupPodaci.TabIndex = 0;
            this.groupPodaci.TabStop = false;
            this.groupPodaci.Text = "Osnovni podaci";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(279, 171);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(112, 20);
            this.btnDodajSliku.TabIndex = 8;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // pboxSlika
            // 
            this.pboxSlika.Image = global::OOP_Lab_2.Properties.Resources.default_avatar;
            this.pboxSlika.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxSlika.InitialImage")));
            this.pboxSlika.Location = new System.Drawing.Point(279, 31);
            this.pboxSlika.Name = "pboxSlika";
            this.pboxSlika.Size = new System.Drawing.Size(112, 132);
            this.pboxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSlika.TabIndex = 16;
            this.pboxSlika.TabStop = false;
            // 
            // cboxPol
            // 
            this.cboxPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPol.FormattingEnabled = true;
            this.cboxPol.Location = new System.Drawing.Point(143, 226);
            this.cboxPol.Name = "cboxPol";
            this.cboxPol.Size = new System.Drawing.Size(116, 21);
            this.cboxPol.TabIndex = 7;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(142, 199);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(116, 20);
            this.txtMesto.TabIndex = 6;
            // 
            // txtBrojDozvole
            // 
            this.txtBrojDozvole.Location = new System.Drawing.Point(143, 171);
            this.txtBrojDozvole.Name = "txtBrojDozvole";
            this.txtBrojDozvole.Size = new System.Drawing.Size(116, 20);
            this.txtBrojDozvole.TabIndex = 5;
            this.txtBrojDozvole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojDozvole_KeyPress);
            // 
            // dtpDozvolaDo
            // 
            this.dtpDozvolaDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDozvolaDo.Location = new System.Drawing.Point(142, 143);
            this.dtpDozvolaDo.Name = "dtpDozvolaDo";
            this.dtpDozvolaDo.Size = new System.Drawing.Size(116, 20);
            this.dtpDozvolaDo.TabIndex = 4;
            // 
            // dtpDozvolaOd
            // 
            this.dtpDozvolaOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDozvolaOd.Location = new System.Drawing.Point(142, 115);
            this.dtpDozvolaOd.Name = "dtpDozvolaOd";
            this.dtpDozvolaOd.Size = new System.Drawing.Size(116, 20);
            this.dtpDozvolaOd.TabIndex = 3;
            this.dtpDozvolaOd.ValueChanged += new System.EventHandler(this.dtpDozvolaOd_ValueChanged);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(143, 87);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(116, 20);
            this.dtpDatumRodjenja.TabIndex = 2;
            this.dtpDatumRodjenja.ValueChanged += new System.EventHandler(this.dtpDatumRodjenja_ValueChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(143, 59);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(116, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(143, 31);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(116, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(94, 227);
            this.lblPol.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(25, 13);
            this.lblPol.TabIndex = 7;
            this.lblPol.Text = "Pol:";
            // 
            // lblMestoIzdavanja
            // 
            this.lblMestoIzdavanja.AutoSize = true;
            this.lblMestoIzdavanja.Location = new System.Drawing.Point(32, 199);
            this.lblMestoIzdavanja.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblMestoIzdavanja.Name = "lblMestoIzdavanja";
            this.lblMestoIzdavanja.Size = new System.Drawing.Size(87, 13);
            this.lblMestoIzdavanja.TabIndex = 6;
            this.lblMestoIzdavanja.Text = "Mesto izdavanja:";
            // 
            // lblBrojVozacke
            // 
            this.lblBrojVozacke.AutoSize = true;
            this.lblBrojVozacke.Location = new System.Drawing.Point(12, 171);
            this.lblBrojVozacke.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblBrojVozacke.Name = "lblBrojVozacke";
            this.lblBrojVozacke.Size = new System.Drawing.Size(107, 13);
            this.lblBrojVozacke.TabIndex = 5;
            this.lblBrojVozacke.Text = "Br. vozacke dozvole:";
            // 
            // lblDozvolaDo
            // 
            this.lblDozvolaDo.AutoSize = true;
            this.lblDozvolaDo.Location = new System.Drawing.Point(100, 143);
            this.lblDozvolaDo.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblDozvolaDo.Name = "lblDozvolaDo";
            this.lblDozvolaDo.Size = new System.Drawing.Size(19, 13);
            this.lblDozvolaDo.TabIndex = 4;
            this.lblDozvolaDo.Text = "do";
            // 
            // lblDozvolaOd
            // 
            this.lblDozvolaOd.AutoSize = true;
            this.lblDozvolaOd.Location = new System.Drawing.Point(19, 115);
            this.lblDozvolaOd.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblDozvolaOd.Name = "lblDozvolaOd";
            this.lblDozvolaOd.Size = new System.Drawing.Size(100, 13);
            this.lblDozvolaOd.TabIndex = 3;
            this.lblDozvolaOd.Text = "Vazenje dozvole od";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(38, 87);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(81, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum rodjenja:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(72, 59);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(92, 31);
            this.lblIme.Margin = new System.Windows.Forms.Padding(3, 15, 20, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // groupKategorija
            // 
            this.groupKategorija.Controls.Add(this.btnObrisiKategoriju);
            this.groupKategorija.Controls.Add(this.btnDodajKategoriju);
            this.groupKategorija.Controls.Add(this.dataKategorije);
            this.groupKategorija.Location = new System.Drawing.Point(13, 280);
            this.groupKategorija.Name = "groupKategorija";
            this.groupKategorija.Size = new System.Drawing.Size(403, 169);
            this.groupKategorija.TabIndex = 1;
            this.groupKategorija.TabStop = false;
            this.groupKategorija.Text = "Kategorija";
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Image = global::OOP_Lab_2.Properties.Resources.cleanAll;
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(272, 122);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(125, 42);
            this.btnObrisiKategoriju.TabIndex = 1;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Image = global::OOP_Lab_2.Properties.Resources.save;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(6, 122);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(125, 42);
            this.btnDodajKategoriju.TabIndex = 0;
            this.btnDodajKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // dataKategorije
            // 
            this.dataKategorije.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKategorije.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataKategorije.Location = new System.Drawing.Point(6, 20);
            this.dataKategorije.Name = "dataKategorije";
            this.dataKategorije.ReadOnly = true;
            this.dataKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKategorije.Size = new System.Drawing.Size(391, 96);
            this.dataKategorije.TabIndex = 0;
            // 
            // groupZabrana
            // 
            this.groupZabrana.Controls.Add(this.brnObrisiZabranu);
            this.groupZabrana.Controls.Add(this.btnDodajZabranu);
            this.groupZabrana.Controls.Add(this.dataZabrane);
            this.groupZabrana.Location = new System.Drawing.Point(13, 451);
            this.groupZabrana.Name = "groupZabrana";
            this.groupZabrana.Size = new System.Drawing.Size(403, 170);
            this.groupZabrana.TabIndex = 2;
            this.groupZabrana.TabStop = false;
            this.groupZabrana.Text = "Zabrana upravljanja";
            // 
            // brnObrisiZabranu
            // 
            this.brnObrisiZabranu.Image = global::OOP_Lab_2.Properties.Resources.cleanAll;
            this.brnObrisiZabranu.Location = new System.Drawing.Point(272, 121);
            this.brnObrisiZabranu.Name = "brnObrisiZabranu";
            this.brnObrisiZabranu.Size = new System.Drawing.Size(125, 42);
            this.brnObrisiZabranu.TabIndex = 1;
            this.brnObrisiZabranu.Text = "Obrisi zabranu";
            this.brnObrisiZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnObrisiZabranu.UseVisualStyleBackColor = true;
            this.brnObrisiZabranu.Click += new System.EventHandler(this.brnObrisiZabranu_Click);
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.Image = global::OOP_Lab_2.Properties.Resources.save;
            this.btnDodajZabranu.Location = new System.Drawing.Point(6, 121);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(125, 42);
            this.btnDodajZabranu.TabIndex = 0;
            this.btnDodajZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            this.btnDodajZabranu.Click += new System.EventHandler(this.btnDodajZabranu_Click);
            // 
            // dataZabrane
            // 
            this.dataZabrane.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataZabrane.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataZabrane.Location = new System.Drawing.Point(6, 19);
            this.dataZabrane.Name = "dataZabrane";
            this.dataZabrane.ReadOnly = true;
            this.dataZabrane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataZabrane.Size = new System.Drawing.Size(391, 96);
            this.dataZabrane.TabIndex = 3;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(69, 627);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(285, 627);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            this.btnZatvori.Leave += new System.EventHandler(this.btnZatvori_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // VozacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 659);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.groupZabrana);
            this.Controls.Add(this.groupKategorija);
            this.Controls.Add(this.groupPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VozacForm";
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.VozacForm_Load);
            this.Leave += new System.EventHandler(this.btnZatvori_Click);
            this.groupPodaci.ResumeLayout(false);
            this.groupPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).EndInit();
            this.groupKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKategorije)).EndInit();
            this.groupZabrana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataZabrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPodaci;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox pboxSlika;
        private System.Windows.Forms.ComboBox cboxPol;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.TextBox txtBrojDozvole;
        private System.Windows.Forms.DateTimePicker dtpDozvolaDo;
        private System.Windows.Forms.DateTimePicker dtpDozvolaOd;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblMestoIzdavanja;
        private System.Windows.Forms.Label lblBrojVozacke;
        private System.Windows.Forms.Label lblDozvolaDo;
        private System.Windows.Forms.Label lblDozvolaOd;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.GroupBox groupKategorija;
        private System.Windows.Forms.DataGridView dataKategorije;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.GroupBox groupZabrana;
        private System.Windows.Forms.Button brnObrisiZabranu;
        private System.Windows.Forms.Button btnDodajZabranu;
        private System.Windows.Forms.DataGridView dataZabrane;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}