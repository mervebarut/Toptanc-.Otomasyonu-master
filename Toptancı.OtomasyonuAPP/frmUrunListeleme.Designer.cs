namespace Toptancı.OtomasyonuAPP
{
    partial class frmUrunListeleme
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmUrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKatogori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSatis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.Location = new System.Drawing.Point(32, 139);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 101);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUrunAd,
            this.clmKatogori,
            this.clmFirma,
            this.clmAlis,
            this.clmSatis});
            this.dataGridView1.Location = new System.Drawing.Point(279, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // clmUrunAd
            // 
            this.clmUrunAd.DataPropertyName = "Urun_Adi";
            this.clmUrunAd.HeaderText = "Ürün Adı";
            this.clmUrunAd.Name = "clmUrunAd";
            // 
            // clmKatogori
            // 
            this.clmKatogori.DataPropertyName = "Katagori_ID";
            this.clmKatogori.HeaderText = "Kategori ID";
            this.clmKatogori.Name = "clmKatogori";
            // 
            // clmFirma
            // 
            this.clmFirma.DataPropertyName = "Firma_ID";
            this.clmFirma.HeaderText = "Firma ID";
            this.clmFirma.Name = "clmFirma";
            // 
            // clmAlis
            // 
            this.clmAlis.DataPropertyName = "Alis_Fiyat";
            this.clmAlis.HeaderText = "Alış Fiyatı";
            this.clmAlis.Name = "clmAlis";
            // 
            // clmSatis
            // 
            this.clmSatis.DataPropertyName = "Satis_Fiyat";
            this.clmSatis.HeaderText = "Satış Fiyatı";
            this.clmSatis.Name = "clmSatis";
            // 
            // frmUrunListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmUrunListeleme";
            this.Text = "frmUrunListeleme";
            this.Load += new System.EventHandler(this.frmUrunListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKatogori;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSatis;
    }
}