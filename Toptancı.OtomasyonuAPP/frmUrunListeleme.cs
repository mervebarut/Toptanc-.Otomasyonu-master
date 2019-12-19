using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToptancıBLL;
using ToptancıMODELS;


namespace Toptancı.OtomasyonuAPP
{
    public partial class frmUrunListeleme : Form
    {
        public frmUrunListeleme()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            VeriCek();
        }
        DataTable dt;
        void VeriCek()
        {
            UrunlerBL ubl = new UrunlerBL();
            dt = ubl.UrunlerGetir();
            dataGridView1.DataSource = dt;
        }

        private void frmUrunListeleme_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunlerBL ubl = new UrunlerBL();

            foreach (DataRow item in dt.Rows)
            {

                Urunler u = new Urunler();
                if (item.RowState != DataRowState.Deleted)
                {
                    u.Ad = item[1].ToString();
                    u.Kategoriid = Convert.ToInt32(item[2]);
                    u.Firmaid = Convert.ToInt32(item[3]);
                    u.AlisFiyat = Convert.ToInt32(item[4]);
                    u.SatısFiyat = Convert.ToInt32(item[5]);

                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ubl.Kaydet(u);
                        break;
                    case DataRowState.Deleted:
                        ubl.UrunSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        u.Urunid = Convert.ToInt32(item[0]);
                        ubl.Guncelle(u);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}

