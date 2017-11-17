namespace OOP_Lab_2
{
    partial class KategorijaForm
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
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.cboxKategorija = new System.Windows.Forms.ComboBox();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(11, 24);
            this.lblKategorija.Margin = new System.Windows.Forms.Padding(3, 15, 10, 0);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(57, 13);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(12, 52);
            this.lblDatumOd.Margin = new System.Windows.Forms.Padding(3, 15, 10, 0);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(56, 13);
            this.lblDatumOd.TabIndex = 1;
            this.lblDatumOd.Text = "Datum od:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(13, 80);
            this.lblDatumDo.Margin = new System.Windows.Forms.Padding(3, 15, 10, 0);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(56, 13);
            this.lblDatumDo.TabIndex = 2;
            this.lblDatumDo.Text = "Datum do:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumOd.Location = new System.Drawing.Point(81, 46);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumOd.TabIndex = 1;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // cboxKategorija
            // 
            this.cboxKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKategorija.FormattingEnabled = true;
            this.cboxKategorija.Location = new System.Drawing.Point(81, 21);
            this.cboxKategorija.Name = "cboxKategorija";
            this.cboxKategorija.Size = new System.Drawing.Size(121, 21);
            this.cboxKategorija.TabIndex = 0;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumDo.Location = new System.Drawing.Point(82, 74);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumDo.TabIndex = 2;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(42, 110);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(154, 110);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            this.btnZatvori.Leave += new System.EventHandler(this.btnZatvori_Click);
            // 
            // KategorijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 145);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.cboxKategorija);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.lblKategorija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KategorijaForm";
            this.Text = "Kategorija";
            this.Load += new System.EventHandler(this.KategorijaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.ComboBox cboxKategorija;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}