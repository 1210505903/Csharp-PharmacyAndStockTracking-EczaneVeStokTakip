using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace giris
{
    class veritabanieczane
    {
        //claslar nesne oluşturmak için kullanılır claslar içinde tanımlanan değişkenler alan olarak adlandırılır ve içerisinde metotlar tanımlanılır 
        OleDbConnection eczanebaglanti;
        OleDbDataAdapter eczanedapt;
        OleDbCommand eczanekomut;
        DataTable eczanedt;
        public void veritabanina_baglan()
        {
             eczanebaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data Source=vt_eczane.accdb");
               eczanebaglanti.Open();
        }
        public void baglantiyi_kapat()
        {
            eczanebaglanti.Close();


        }
        public DataTable dt_olustur(string eczanekomut)
        {
         veritabanina_baglan();
         eczanedapt = new OleDbDataAdapter(eczanekomut,eczanebaglanti);
         eczanedt = new DataTable();
         eczanedapt.Fill(eczanedt);
         baglantiyi_kapat();
         return eczanedt;
        }
        
    }
}
