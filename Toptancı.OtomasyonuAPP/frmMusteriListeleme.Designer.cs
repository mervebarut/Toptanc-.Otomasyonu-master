namespace Toptancı.OtomasyonuAPP
{
    partial class frmMusteriListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmePosta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTCKNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmSoyad,
            this.clmTel,
            this.clmSifre,
            this.clmePosta,
            this.clmAdres,
            this.clmTCKNo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(185, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmAd
            // 
            this.clmAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAd.DataPropertyName = "AD";
            this.clmAd.HeaderText = "Ad";
            this.clmAd.Name = "clmAd";
            // 
            // clmSoyad
            // 
            this.clmSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSoyad.DataPropertyName = "SOYAD";
            this.clmSoyad.HeaderText = "Soyad";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmTel
            // 
            this.clmTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTel.DataPropertyName = "Telefon";
            this.clmTel.HeaderText = "Telefon";
            this.clmTel.Name = "clmTel";
            // 
            // clmSifre
            // 
            this.clmSifre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSifre.DataPropertyName = "Sifre";
            this.clmSifre.HeaderText = "Şifre";
            this.clmSifre.Name = "clmSifre";
            // 
            // clmePosta
            // 
            this.clmePosta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmePosta.DataPropertyName = "ePosta";
            this.clmePosta.HeaderText = "E-Mail";
            this.clmePosta.Name = "clmePosta";
            // 
            // clmAdres
            // 
            this.clmAdres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAdres.DataPropertyName = "Adres";
            this.clmAdres.HeaderText = "Adres";
            this.clmAdres.Name = "clmAdres";
            // 
            // clmTCKNo
            // 
            this.clmTCKNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTCKNo.DataPropertyName = "TCKNo";
            this.clmTCKNo.HeaderText = "TC Kimlik";
            this.clmTCKNo.Name = "clmTCKNo";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKaydet.Location = new System.Drawing.Point(48, 38);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 46);
            this.btnKaydet.TabIndex = 53;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmMusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMusteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme";
            this.Load += new System.EventHandler(this.frmMusteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmePosta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTCKNo;
    }
}