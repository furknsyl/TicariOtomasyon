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
    public partial class frmayarlar : Form
    {
        
        public frmayarlar()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMINLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {

            txtad.Text = "";
            txtsifre.Text = "";
            txtid.Text="";
        }
        private void frmayarlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_ADMINLER values (@p1,@p2)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",txtad.Text);
            kmt.Parameters.AddWithValue("@p2",txtsifre.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sisteme Başarıyla Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtad.Text = dr["KULLANICIAD"].ToString();
                txtsifre.Text = dr["SIFRE"].ToString();
                txtid.Text = dr["ID"].ToString();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_ADMINLER set KULLANICIAD=@P1,SIFRE=@P2 where ID=@P3",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",txtad.Text);
            kmt.Parameters.AddWithValue("@P2",txtsifre.Text);
            kmt.Parameters.AddWithValue("@P3",txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_ADMINLER where ID=@P1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Silndi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
