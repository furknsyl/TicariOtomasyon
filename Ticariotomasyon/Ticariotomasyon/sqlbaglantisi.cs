using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticariotomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-CFA56CN;Initial Catalog=DboTicariOtomason;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
