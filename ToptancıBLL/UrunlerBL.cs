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
    class UrunlerBL:IDisposable
    {
        Helper hlp = new Helper();
        public bool Kaydet(Urunler u)
        {
            try
            {
                Helper hlp = new Helper();
                SqlParameter[] p = { new SqlParameter("@Kategoriid", u.Kategoriid), new SqlParameter("@Firmaid", u.Firmaid), new SqlParameter("@AlisFiyat", u.AlisFiyat), new SqlParameter("@SatisFiyat", u.SatisFiyat), new SqlParameter("@Ad", u.Ad) }; 
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

        public bool Guncelle(Urunler u)
        {
            try
            {
                SqlParameter[] p = {  new SqlParameter("@UrunID", u.Urunlerid) };
                return hlp.ExecuteNonQuery("Update MUSTERILER set Urun_Adi=@Ad,Katagori_ID=@Kategoriid,Firma_ID=@Firmaid,Alis_Fiyat=@AlisFiyat,Satis_Fiyat=@SatisFiyat, Where Urun_ID=@UrunID", p) > 0;

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

        public Urunler UrunlerBul(string ad)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", ad) };
                SqlDataReader dr = hlp.ExecuteReader("Select Urun_ID,Katagori_ID,Firma_ID,Alis_Fiyat,Satis_Fiyat from URUNLER Where Urun_Adi=@Ad", p);
               Urunler u = null;

                if (dr.Read())
                {
                    u = new Urunler();

                    u.Urunlerid = Convert.ToInt32(dr["Urun_ID"]);
                    u.Kategoriid =Convert.ToInt32 (dr["Katagori_ID"]);
                    u.Firmaid = Convert.ToInt32(dr["Firma_ID"]);
                    u.Alis = Convert.ToInt32(dr["Alis_Fİyat"]);
                    u.Satis =Convert.ToInt32 (dr["ePosta"]);
                   
                  
                    u.Urun_Adi = ad;
                }
                dr.Close();
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UrunlerSil(int Urunlerid)
        {
            SqlParameter[] p = { new SqlParameter("@UrunlerId", Urunlerid) };
            return hlp.ExecuteNonQuery("Delete from URUNLER where UrunlerId=@UrunlerId", p) > 0;
        }

        public DataTable UrunlerGetir()
        {
            return hlp.GetDataTable("Select Urun_ID,Urun_Adi,Katagori_ID,Firma_ID,Alis_Fiyat,Satis_Fiyat, from URUNLER");
        }
        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}

