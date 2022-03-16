using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting() 
        {
            using (//perubahan
                SqlConnection con = new SqlConnection("data source=DESKTOP-KVHUS77\\RIDWANAM;database=ProdiTI;User ID=sa;Password=riamima")
            ) 
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
            }
        }
    }
}
