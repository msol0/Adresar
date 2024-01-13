namespace Adresar.UI
{
    partial class PopisKontakataForm
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
            this.txtTraži = new System.Windows.Forms.TextBox();
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnTraži = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblBrojTel = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgKontakti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgKontakti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTraži
            // 
            this.txtTraži.Location = new System.Drawing.Point(566, 252);
            this.txtTraži.Multiline = true;
            this.txtTraži.Name = "txtTraži";
            this.txtTraži.Size = new System.Drawing.Size(312, 40);
            this.txtTraži.TabIndex = 31;
            // 
            // btnObriši
            // 
            this.btnObriši.AutoSize = true;
            this.btnObriši.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnObriši.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnObriši.ForeColor = System.Drawing.Color.White;
            this.btnObriši.Location = new System.Drawing.Point(827, 642);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(141, 34);
            this.btnObriši.TabIndex = 30;
            this.btnObriši.Text = "Obriši korisnika";
            this.btnObriši.UseVisualStyleBackColor = false;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // btnTraži
            // 
            this.btnTraži.AutoSize = true;
            this.btnTraži.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnTraži.Location = new System.Drawing.Point(884, 252);
            this.btnTraži.Name = "btnTraži";
            this.btnTraži.Size = new System.Drawing.Size(57, 40);
            this.btnTraži.TabIndex = 29;
            this.btnTraži.Text = "Traži";
            this.btnTraži.UseVisualStyleBackColor = true;
            this.btnTraži.Click += new System.EventHandler(this.btnTraži_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.AutoSize = true;
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(151)))), ((int)(((byte)(29)))));
            this.btnIzlaz.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzlaz.ForeColor = System.Drawing.Color.White;
            this.btnIzlaz.Location = new System.Drawing.Point(973, 26);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(79, 34);
            this.btnIzlaz.TabIndex = 28;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.AutoSize = true;
            this.btnAžuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(29)))), ((int)(((byte)(226)))));
            this.btnAžuriraj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnAžuriraj.ForeColor = System.Drawing.Color.White;
            this.btnAžuriraj.Location = new System.Drawing.Point(566, 193);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(145, 34);
            this.btnAžuriraj.TabIndex = 27;
            this.btnAžuriraj.Text = "Ažuriraj podatke";
            this.btnAžuriraj.UseVisualStyleBackColor = false;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(226)))), ((int)(((byte)(151)))));
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(226)))), ((int)(((byte)(151)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(354, 193);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(140, 34);
            this.btnDodaj.TabIndex = 26;
            this.btnDodaj.Text = "Dodaj korisnika";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(702, 138);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(221, 22);
            this.txtTelefon.TabIndex = 25;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(702, 87);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(221, 22);
            this.txtAdresa.TabIndex = 24;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(181, 142);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(221, 22);
            this.txtPrezime.TabIndex = 23;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(181, 90);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(221, 22);
            this.txtIme.TabIndex = 22;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblIme.Location = new System.Drawing.Point(82, 87);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(46, 26);
            this.lblIme.TabIndex = 21;
            this.lblIme.Text = "Ime:";
            // 
            // lblBrojTel
            // 
            this.lblBrojTel.AutoSize = true;
            this.lblBrojTel.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblBrojTel.Location = new System.Drawing.Point(561, 138);
            this.lblBrojTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojTel.Name = "lblBrojTel";
            this.lblBrojTel.Size = new System.Drawing.Size(118, 26);
            this.lblBrojTel.TabIndex = 20;
            this.lblBrojTel.Text = "Broj telefona:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblAdresa.Location = new System.Drawing.Point(561, 87);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(73, 26);
            this.lblAdresa.TabIndex = 19;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblPrezime.Location = new System.Drawing.Point(82, 138);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(83, 26);
            this.lblPrezime.TabIndex = 18;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial Narrow", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblNaslov.Location = new System.Drawing.Point(448, 25);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(171, 30);
            this.lblNaslov.TabIndex = 17;
            this.lblNaslov.Text = "Telefonski imenik";
            // 
            // dgKontakti
            // 
            this.dgKontakti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKontakti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgKontakti.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgKontakti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKontakti.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgKontakti.Location = new System.Drawing.Point(61, 311);
            this.dgKontakti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgKontakti.Name = "dgKontakti";
            this.dgKontakti.RowHeadersWidth = 51;
            this.dgKontakti.RowTemplate.Height = 24;
            this.dgKontakti.Size = new System.Drawing.Size(924, 304);
            this.dgKontakti.TabIndex = 16;
            this.dgKontakti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKontakti_CellClick);
            // 
            // PopisKontakataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 742);
            this.Controls.Add(this.txtTraži);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnTraži);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblBrojTel);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.dgKontakti);
            this.Name = "PopisKontakataForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgKontakti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTraži;
        private System.Windows.Forms.Button btnObriši;
        private System.Windows.Forms.Button btnTraži;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnAžuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBrojTel;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgKontakti;
    }
}

