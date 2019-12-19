using System;
using System.Collections.Generic;
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
    public partial class frmMusteriListeleme : Form
    {
        public frmMusteriListeleme()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            VeriCek();
        }
        DataTable dt;
        void VeriCek()
        {
            MusteriBL mbl = new MusteriBL();
            dt = mbl.MusteriGetir();
            dataGridView1.DataSource = dt;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();

            foreach (DataRow item in dt.Rows)
            {

                Musteri m = new Musteri();
                if (item.RowState != DataRowState.Deleted)
                {
                    m.Ad = item[1].ToString();
                    m.Soyad = item[2].ToString();
                    m.Telefon = item[3].ToString();
                    m.Sifre = item[4].ToString();
                    m.EPosta = item[5].ToString();
                    m.Adres = item[6].ToString();
                    m.TCKNo = item[7].ToString();
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        mbl.Kaydet(m);
                        break;
                    case DataRowState.Deleted:
                        mbl.MusteriSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        m.Musteriid = Convert.ToInt32(item[0]);
                        mbl.Guncelle(m);
                        break;
                    default:
                        break;
                }
            }
        }

        private void frmMusteriListeleme_Load(object sender, EventArgs e)
        {

        }
    }
}
