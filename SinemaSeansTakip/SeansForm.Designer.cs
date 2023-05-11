
namespace SinemaSeansTakip
{
    partial class SeansForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbTarih = new System.Windows.Forms.ComboBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSaatEkle = new System.Windows.Forms.Button();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 418);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 51);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(441, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seans Formu";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(637, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(354, 43);
            this.button5.TabIndex = 11;
            this.button5.Text = "Müşteriler";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(509, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 418);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(12, 118);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(354, 43);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownWidth = 250;
            this.cmbFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(12, 80);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(114, 32);
            this.cmbFilm.TabIndex = 14;
            this.cmbFilm.Text = "Film";
            // 
            // cmbTarih
            // 
            this.cmbTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.Location = new System.Drawing.Point(132, 80);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(114, 32);
            this.cmbTarih.TabIndex = 15;
            this.cmbTarih.Text = "Saat";
            // 
            // cmbSalon
            // 
            this.cmbSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(252, 80);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(114, 32);
            this.cmbSalon.TabIndex = 17;
            this.cmbSalon.Text = "Salon";
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.Color.White;
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.Location = new System.Drawing.Point(987, 591);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(105, 30);
            this.btnFilmEkle.TabIndex = 18;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnSaatEkle
            // 
            this.btnSaatEkle.BackColor = System.Drawing.Color.White;
            this.btnSaatEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaatEkle.Location = new System.Drawing.Point(876, 591);
            this.btnSaatEkle.Name = "btnSaatEkle";
            this.btnSaatEkle.Size = new System.Drawing.Size(105, 30);
            this.btnSaatEkle.TabIndex = 19;
            this.btnSaatEkle.Text = "Saat Ekle";
            this.btnSaatEkle.UseVisualStyleBackColor = false;
            this.btnSaatEkle.Click += new System.EventHandler(this.btnSaatEkle_Click);
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.White;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.Location = new System.Drawing.Point(765, 591);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(105, 30);
            this.btnSalonEkle.TabIndex = 20;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // SeansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1104, 627);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.btnSaatEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "SeansForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Seans Takip Uygulaması";
            this.Load += new System.EventHandler(this.SeansForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbTarih;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSaatEkle;
        private System.Windows.Forms.Button btnSalonEkle;
    }
}

