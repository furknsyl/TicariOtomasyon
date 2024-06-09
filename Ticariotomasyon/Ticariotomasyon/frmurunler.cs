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
using System.Data.Common;

namespace Ticariotomasyon
{
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {

            txtad.Text = "";
            txtalis.Text = "";
            txtid.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            txtsatis.Text = "";
            mskyil.Text = "";
            richdetay.Text = "";
            nudadet.Value = 0;
        }
        private void frmurunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", mskyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(nudadet.Text).ToString());
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", richdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            listele();
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmtsil = new SqlCommand("delete from TBL_URUNLER where ID=@p1",bgl.baglanti());
            kmtsil.Parameters.AddWithValue("@p1", txtid.Text);
            kmtsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarıyla silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["ID"].ToString();
            txtad.Text = dr["URUNAD"].ToString();
            txtmarka.Text = dr["MARKA"].ToString();
            txtmodel.Text = dr["MODEL"].ToString();
            mskyil.Text = dr["YIL"].ToString();
            nudadet.Value = decimal.Parse(dr["ADET"].ToString());
            txtalis.Text = dr["ALISFIYAT"].ToString();
            txtsatis.Text = dr["SATISFIYAT"].ToString();
            richdetay.Text = dr["DETAY"].ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", mskyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(nudadet.Text).ToString());
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", richdetay.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
