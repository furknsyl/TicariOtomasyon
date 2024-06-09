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
    public partial class frmnotlar : Form
    {
        public frmnotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select * from TBL_NOTLAR",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            txtid.Text = "";
            txtbaslık.Text = "";
            txthitap.Text = "";
            txtolusturan.Text = "";
            msksaat.Text = "";
            msktarih.Text = "";
            rchdetay.Text = "";
        }

        private void frmnotlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",msktarih.Text);
            kmt.Parameters.AddWithValue("@p2", msksaat.Text);
            kmt.Parameters.AddWithValue("@p3", txtbaslık.Text);
            kmt.Parameters.AddWithValue("@p4", rchdetay.Text);
            kmt.Parameters.AddWithValue("@p5", txtolusturan.Text);
            kmt.Parameters.AddWithValue("@p6", txthitap.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Sisteme Eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtid.Text = dr["ID"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                msksaat.Text = dr["SAAT"].ToString();
                txtbaslık.Text = dr["BASLIK"].ToString();
                rchdetay.Text = dr["DETAY"].ToString();
                txtolusturan.Text = dr["OLUSTURAN"].ToString();
                txthitap.Text = dr["HITAP"].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_NOTLAR where ID=@P1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Sistemden Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_NOTLAR set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@P7",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", msktarih.Text);
            kmt.Parameters.AddWithValue("@P2", msksaat.Text);
            kmt.Parameters.AddWithValue("@P3", txtbaslık.Text);
            kmt.Parameters.AddWithValue("@P4", rchdetay.Text);
            kmt.Parameters.AddWithValue("@P5", txtolusturan.Text);
            kmt.Parameters.AddWithValue("@P6", txthitap.Text);
            kmt.Parameters.AddWithValue("@P7", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Sistem Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmnotdetay fr=new frmnotdetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.metin = dr["DETAY"].ToString();
                

            }
            fr.Show();
        }
    }
}
