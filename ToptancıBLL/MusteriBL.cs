using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToptancıDAL;
using ToptancıMODELS;

namespace ToptancıBLL
{
    public class MusteriBL:IDisposable
    {
        Helper hlp = new Helper();
        public bool Kaydet(Musteri m)
        {
            try
            {
                Helper hlp = new Helper();
                SqlParameter[] p = { new SqlParameter("@Sifre", m.Sifre), new SqlParameter("@Mail", m.EPosta), new SqlParameter("@Adres", m.Adres), new SqlParameter("@TCKNo", m.TCKNo), new SqlParameter("@Ad", m.Ad), new SqlParameter("@Soyad", m.Soyad), new SqlParameter("@Telefon", m.Telefon) };
                return hlp.ExecuteNonQuery("Insert into MUSTERILER values(@Ad,@Soyad,@Telefon,@Sifre,@Mail,@Adres,@TCKNo)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Guncelle(Musteri m)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Sifre", m.Sifre), new SqlParameter("@Mail", m.EPosta), new SqlParameter("@Adres", m.Adres), new SqlParameter("@TCKNo", m.TCKNo), new SqlParameter("@Ad", m.Ad), new SqlParameter("@Soyad", m.Soyad), new SqlParameter("@Telefon", m.Telefon), new SqlParameter("@MusID", m.Musteriid) };
                return hlp.ExecuteNonQuery("Update MUSTERILER set AD=@Ad,SOYAD=@Soyad,Telefon=@Telefon,Adres=@Adres, ePosta=@Mail, Sifre=@Sifre, TCKNo=@TCKNo Where Musteri_ID=@MusID", p) > 0;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Musteri MusteriBul(string tc)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@tcNO", tc) };
                SqlDataReader dr = hlp.ExecuteReader("Select Musteri_ID,AD,SOYAD,Telefon,Sifre,ePosta,Adres from MUSTERILER Where TCKNo=@tcNO", p);
                Musteri m = null;

                if (dr.Read())
                {
                    m = new Musteri();
                    m.Musteriid = Convert.ToInt32(dr["Musteri_ID"]);
                    m.Ad = dr["AD"].ToString();
                    m.Soyad = dr["SOYAD"].ToString();
                    m.Telefon = dr["Telefon"].ToString();
                    m.Sifre = dr["Sifre"].ToString();
                    m.EPosta = dr["ePosta"].ToString();
                    m.Adres = dr["Adres"].ToString();
                    m.TCKNo = tc;
                }
                dr.Close();
                return m;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool MusteriSil(int Musteriid)
        {
            SqlParameter[] p = { new SqlParameter("@MusteriId", Musteriid) };
            return hlp.ExecuteNonQuery("Delete from MUSTERILER where MusteriId=@MusteriId", p) > 0;
        }

        public DataTable MusteriGetir()
        {
            return hlp.GetDataTable("Select Musteri_ID,AD,SOYAD,Telefon,Sifre,ePosta,Adres,TCKNo from MUSTERILER");
        }
        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}
