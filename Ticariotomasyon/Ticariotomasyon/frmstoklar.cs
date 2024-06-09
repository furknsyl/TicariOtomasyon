using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticariotomasyon
{
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,Sum(Adet) as 'Ürün Sayısı' from TBL_URUNLER group by URUNAD",bgl.baglanti());
            DataTable dt= new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlCommand kmt = new SqlCommand("select URUNAD,Sum(Adet) as 'Ürün Sayısı' from TBL_URUNLER group by URUNAD",bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmstokdetay fr = new frmstokdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();
            }
            fr.Show();

        }
    }
}
