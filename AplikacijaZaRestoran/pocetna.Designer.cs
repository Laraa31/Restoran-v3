namespace AplikacijaZaRestoran
{
    partial class Pocetna
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salate = new System.Windows.Forms.Button();
            this.glJelo = new System.Windows.Forms.Button();
            this.zestokaPica = new System.Windows.Forms.Button();
            this.juha = new System.Windows.Forms.Button();
            this.desert = new System.Windows.Forms.Button();
            this.alkPica = new System.Windows.Forms.Button();
            this.bezAlkPica = new System.Windows.Forms.Button();
            this.kave = new System.Windows.Forms.Button();
            this.stolovi = new System.Windows.Forms.ComboBox();
            this.narudzba = new System.Windows.Forms.DataGridView();
            this.ispisRac = new System.Windows.Forms.Button();
            this.izbrisiRac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iznos = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salate);
            this.groupBox1.Controls.Add(this.glJelo);
            this.groupBox1.Controls.Add(this.zestokaPica);
            this.groupBox1.Controls.Add(this.juha);
            this.groupBox1.Controls.Add(this.desert);
            this.groupBox1.Controls.Add(this.alkPica);
            this.groupBox1.Controls.Add(this.bezAlkPica);
            this.groupBox1.Controls.Add(this.kave);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(409, 566);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // salate
            // 
            this.salate.Location = new System.Drawing.Point(221, 289);
            this.salate.Margin = new System.Windows.Forms.Padding(4);
            this.salate.Name = "salate";
            this.salate.Size = new System.Drawing.Size(168, 103);
            this.salate.TabIndex = 15;
            this.salate.Text = "Salata";
            this.salate.UseVisualStyleBackColor = true;
            this.salate.Click += new System.EventHandler(this.salate_Click);
            // 
            // glJelo
            // 
            this.glJelo.Location = new System.Drawing.Point(221, 162);
            this.glJelo.Margin = new System.Windows.Forms.Padding(4);
            this.glJelo.Name = "glJelo";
            this.glJelo.Size = new System.Drawing.Size(168, 103);
            this.glJelo.TabIndex = 14;
            this.glJelo.Text = "Glavno jelo";
            this.glJelo.UseVisualStyleBackColor = true;
            this.glJelo.Click += new System.EventHandler(this.glJelo_Click);
            // 
            // zestokaPica
            // 
            this.zestokaPica.Location = new System.Drawing.Point(221, 426);
            this.zestokaPica.Margin = new System.Windows.Forms.Padding(4);
            this.zestokaPica.Name = "zestokaPica";
            this.zestokaPica.Size = new System.Drawing.Size(168, 103);
            this.zestokaPica.TabIndex = 13;
            this.zestokaPica.Text = "Žestoka pića";
            this.zestokaPica.UseVisualStyleBackColor = true;
            this.zestokaPica.Click += new System.EventHandler(this.predjelo_Click);
            // 
            // juha
            // 
            this.juha.Location = new System.Drawing.Point(221, 32);
            this.juha.Margin = new System.Windows.Forms.Padding(4);
            this.juha.Name = "juha";
            this.juha.Size = new System.Drawing.Size(168, 103);
            this.juha.TabIndex = 12;
            this.juha.Text = "Juha";
            this.juha.UseVisualStyleBackColor = true;
            this.juha.Click += new System.EventHandler(this.juha_Click);
            // 
            // desert
            // 
            this.desert.Location = new System.Drawing.Point(27, 426);
            this.desert.Margin = new System.Windows.Forms.Padding(4);
            this.desert.Name = "desert";
            this.desert.Size = new System.Drawing.Size(168, 103);
            this.desert.TabIndex = 11;
            this.desert.Text = "Desert";
            this.desert.UseVisualStyleBackColor = true;
            this.desert.Click += new System.EventHandler(this.desert_Click);
            // 
            // alkPica
            // 
            this.alkPica.Location = new System.Drawing.Point(27, 289);
            this.alkPica.Margin = new System.Windows.Forms.Padding(4);
            this.alkPica.Name = "alkPica";
            this.alkPica.Size = new System.Drawing.Size(168, 103);
            this.alkPica.TabIndex = 10;
            this.alkPica.Text = "Alkoholna pića";
            this.alkPica.UseVisualStyleBackColor = true;
            this.alkPica.Click += new System.EventHandler(this.alkPica_Click);
            // 
            // bezAlkPica
            // 
            this.bezAlkPica.Location = new System.Drawing.Point(27, 162);
            this.bezAlkPica.Margin = new System.Windows.Forms.Padding(4);
            this.bezAlkPica.Name = "bezAlkPica";
            this.bezAlkPica.Size = new System.Drawing.Size(168, 103);
            this.bezAlkPica.TabIndex = 9;
            this.bezAlkPica.Text = "Bezalkoholna pića";
            this.bezAlkPica.UseVisualStyleBackColor = true;
            this.bezAlkPica.Click += new System.EventHandler(this.bezAlkPica_Click);
            // 
            // kave
            // 
            this.kave.Location = new System.Drawing.Point(27, 32);
            this.kave.Margin = new System.Windows.Forms.Padding(4);
            this.kave.Name = "kave";
            this.kave.Size = new System.Drawing.Size(168, 103);
            this.kave.TabIndex = 8;
            this.kave.Text = "Kava";
            this.kave.UseVisualStyleBackColor = true;
            this.kave.Click += new System.EventHandler(this.kave_Click);
            // 
            // stolovi
            // 
            this.stolovi.FormattingEnabled = true;
            this.stolovi.Items.AddRange(new object[] {
            "Dodaj novi stol"});
            this.stolovi.Location = new System.Drawing.Point(1072, 15);
            this.stolovi.Margin = new System.Windows.Forms.Padding(4);
            this.stolovi.Name = "stolovi";
            this.stolovi.Size = new System.Drawing.Size(426, 24);
            this.stolovi.TabIndex = 0;
            this.stolovi.SelectedIndexChanged += new System.EventHandler(this.stolovi_SelectedIndexChanged);
            // 
            // narudzba
            // 
            this.narudzba.ColumnHeadersHeight = 25;
            this.narudzba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.kolicina,
            this.cijena,
            this.izbrisi});
            this.narudzba.Location = new System.Drawing.Point(1072, 71);
            this.narudzba.Margin = new System.Windows.Forms.Padding(4);
            this.narudzba.Name = "narudzba";
            this.narudzba.RowHeadersVisible = false;
            this.narudzba.RowHeadersWidth = 40;
            this.narudzba.Size = new System.Drawing.Size(426, 394);
            this.narudzba.TabIndex = 11;
            this.narudzba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ispisRac
            // 
            this.ispisRac.Location = new System.Drawing.Point(1072, 523);
            this.ispisRac.Margin = new System.Windows.Forms.Padding(4);
            this.ispisRac.Name = "ispisRac";
            this.ispisRac.Size = new System.Drawing.Size(200, 58);
            this.ispisRac.TabIndex = 14;
            this.ispisRac.Text = "Ispiši račun";
            this.ispisRac.UseVisualStyleBackColor = true;
            // 
            // izbrisiRac
            // 
            this.izbrisiRac.Location = new System.Drawing.Point(1298, 523);
            this.izbrisiRac.Margin = new System.Windows.Forms.Padding(4);
            this.izbrisiRac.Name = "izbrisiRac";
            this.izbrisiRac.Size = new System.Drawing.Size(200, 58);
            this.izbrisiRac.TabIndex = 15;
            this.izbrisiRac.Text = "Izbriši narudžbu";
            this.izbrisiRac.UseVisualStyleBackColor = true;
            this.izbrisiRac.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1068, 484);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Iznos:";
            // 
            // iznos
            // 
            this.iznos.AutoSize = true;
            this.iznos.Location = new System.Drawing.Point(1124, 484);
            this.iznos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iznos.Name = "iznos";
            this.iznos.Size = new System.Drawing.Size(52, 16);
            this.iznos.TabIndex = 17;
            this.iznos.Text = "0,00 KN";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(433, 15);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(627, 566);
            this.panel.TabIndex = 18;
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            // 
            // kolicina
            // 
            this.kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.MinimumWidth = 6;
            this.kolicina.Name = "kolicina";
            // 
            // cijena
            // 
            this.cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijena.HeaderText = "Cijena(€)";
            this.cijena.MinimumWidth = 6;
            this.cijena.Name = "cijena";
            // 
            // izbrisi
            // 
            this.izbrisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.izbrisi.HeaderText = "Izbriši";
            this.izbrisi.MinimumWidth = 6;
            this.izbrisi.Name = "izbrisi";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 596);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.iznos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izbrisiRac);
            this.Controls.Add(this.ispisRac);
            this.Controls.Add(this.narudzba);
            this.Controls.Add(this.stolovi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pocetna";
            this.Text = "Početna stranica";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.narudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button salate;
        private System.Windows.Forms.Button glJelo;
        private System.Windows.Forms.Button zestokaPica;
        private System.Windows.Forms.Button juha;
        private System.Windows.Forms.Button desert;
        private System.Windows.Forms.Button alkPica;
        private System.Windows.Forms.Button bezAlkPica;
        private System.Windows.Forms.Button kave;
        private System.Windows.Forms.ComboBox stolovi;
        private System.Windows.Forms.DataGridView narudzba;
        private System.Windows.Forms.Button ispisRac;
        private System.Windows.Forms.Button izbrisiRac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iznos;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.DataGridViewButtonColumn izbrisi;
    }
}

