using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticariotomasyon
{
    public partial class frmfaturaurunduzenleme : Form
    {
        public frmfaturaurunduzenleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string urunid;
        
        private void frmfaturaurunduzenleme_Load(object sender, EventArgs e)
        {
            txturunid.Text = urunid;
            SqlCommand kmt = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr= kmt.ExecuteReader();
            while (dr.Read())
            {
                txtfiyat.Text = dr[3].ToString();
                txtmiktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
                txturunad.Text = dr[1].ToString();
                bgl.baglanti().Close();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            miktar = Convert.ToDouble(txtmiktar.Text);
            fiyat = Convert.ToDouble(txtfiyat.Text);
            tutar = miktar * fiyat;
            txttutar.Text = tutar.ToString();
            SqlCommand kmt = new SqlCommand("update TBL_FATURADETAY set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 WHERE FATURAURUNID=@p5",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",txturunad.Text);
            kmt.Parameters.AddWithValue("@p2",txtmiktar.Text);
            kmt.Parameters.AddWithValue("@p3",decimal.Parse( txtfiyat.Text));
            kmt.Parameters.AddWithValue("@p4",decimal.Parse(txttutar.Text));
            kmt.Parameters.AddWithValue("@p5",txturunid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
          

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txturunid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
