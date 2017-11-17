namespace OOP_Lab_2
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            this.dataVozaci = new System.Windows.Forms.DataGridView();
            this.groupLista = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblVreme = new System.Windows.Forms.Label();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.cboxSort = new System.Windows.Forms.ComboBox();
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataVozaci)).BeginInit();
            this.groupLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataVozaci
            // 
            this.dataVozaci.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataVozaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVozaci.Location = new System.Drawing.Point(7, 19);
            this.dataVozaci.Name = "dataVozaci";
            this.dataVozaci.ReadOnly = true;
            this.dataVozaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVozaci.Size = new System.Drawing.Size(472, 212);
            this.dataVozaci.TabIndex = 1;
            // 
            // groupLista
            // 
            this.groupLista.Controls.Add(this.btnObrisi);
            this.groupLista.Controls.Add(this.btnIzmeni);
            this.groupLista.Controls.Add(this.btnDodaj);
            this.groupLista.Controls.Add(this.dataVozaci);
            this.groupLista.Location = new System.Drawing.Point(12, 39);
            this.groupLista.Name = "groupLista";
            this.groupLista.Size = new System.Drawing.Size(485, 285);
            this.groupLista.TabIndex = 0;
            this.groupLista.TabStop = false;
            this.groupLista.Text = "Lista vozaca";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Image = global::OOP_Lab_2.Properties.Resources.cleanAll;
            this.btnObrisi.Location = new System.Drawing.Point(365, 237);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(114, 42);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi vozaca";
            this.btnObrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Enabled = false;
            this.btnIzmeni.Image = global::OOP_Lab_2.Properties.Resources.edit;
            this.btnIzmeni.Location = new System.Drawing.Point(127, 237);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(114, 42);
            this.btnIzmeni.TabIndex = 1;
            this.btnIzmeni.Text = "Izmeni vozaca";
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::OOP_Lab_2.Properties.Resources.save;
            this.btnDodaj.Location = new System.Drawing.Point(7, 237);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(114, 42);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj vozaca";
            this.btnDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(12, 9);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(150, 17);
            this.lblVreme.TabIndex = 2;
            this.lblVreme.Text = "HH:mm:ss dd.MM.yyyy";
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Enabled = false;
            this.btnSortiraj.Location = new System.Drawing.Point(264, 12);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 2;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // cboxSort
            // 
            this.cboxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSort.Enabled = false;
            this.cboxSort.FormattingEnabled = true;
            this.cboxSort.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.cboxSort.Location = new System.Drawing.Point(345, 14);
            this.cboxSort.Name = "cboxSort";
            this.cboxSort.Size = new System.Drawing.Size(152, 21);
            this.cboxSort.TabIndex = 1;
            // 
            // timerVreme
            // 
            this.timerVreme.Interval = 1000;
            this.timerVreme.Tick += new System.EventHandler(this.timerVreme_Tick);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 327);
            this.Controls.Add(this.cboxSort);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.groupLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GlavnaForma";
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVozaci)).EndInit();
            this.groupLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVozaci;
        private System.Windows.Forms.GroupBox groupLista;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox cboxSort;
        private System.Windows.Forms.Timer timerVreme;
    }
}

