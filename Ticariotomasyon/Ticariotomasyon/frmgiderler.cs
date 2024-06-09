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
using System.Data.SqlClient;
using DevExpress.XtraBars.Ribbon;

namespace Ticariotomasyon
{
    public partial class frmgiderler : Form
    {
        sqlbaglantisi bgl=new sqlbaglantisi();
        public frmgiderler()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * from TBL_GIDERLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        void temizle()
        {
            txtid.Text = "";
            txtdogalgaz.Text = "";
            txtekstra.Text = "";
            txtelektrik.Text = "";
            txtinternet.Text = "";
            txtmaas.Text = "";
            txtsu.Text = "";
            cmbay.Text = "";
            cmbyil.Text = "";
            rchnotlar.Text="";

        }
        private void frmgiderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtelektrik.Text=="" || txtsu.Text==""|| txtdogalgaz.Text == "" || txtinternet.Text == "" || txtmaas.Text == "" || txtekstra.Text == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                SqlCommand kmt = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAAS,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", cmbay.Text);
                kmt.Parameters.AddWithValue("@p2", cmbyil.Text);
                kmt.Parameters.AddWithValue("@p3", decimal.Parse(txtelektrik.Text));
                kmt.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
                kmt.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalgaz.Text));
                kmt.Parameters.AddWithValue("@p6", decimal.Parse(txtinternet.Text));
                kmt.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
                kmt.Parameters.AddWithValue("@p8", decimal.Parse(txtekstra.Text));
                kmt.Parameters.AddWithValue("@p9", rchnotlar.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();


            }
            


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtid.Text = dr["ID"].ToString();
                cmbay.Text = dr["AY"].ToString();
                cmbyil.Text = dr["YIL"].ToString();
                txtelektrik.Text = dr["ELEKTRIK"].ToString();
                txtsu.Text = dr["SU"].ToString();
                txtdogalgaz.Text = dr["DOGALGAZ"].ToString();
                txtinternet.Text = dr["INTERNET"].ToString();
                txtmaas.Text = dr["MAAS"].ToString();
                txtekstra.Text = dr["EKSTRA"].ToString();
                rchnotlar.Text = dr["NOTLAR"].ToString();
               
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_GIDERLER where ID=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_GIDERLER set AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,MAAS=@P7,EKSTRA=@P8,NOTLAR=@P9 where ID=@P10",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",cmbay.Text);
            kmt.Parameters.AddWithValue("@P2", cmbyil.Text);
            kmt.Parameters.AddWithValue("@P3", decimal.Parse(txtelektrik.Text));
            kmt.Parameters.AddWithValue("@P4", decimal.Parse(txtsu.Text));
            kmt.Parameters.AddWithValue("@P5", decimal.Parse(txtdogalgaz.Text));
            kmt.Parameters.AddWithValue("@P6", decimal.Parse(txtinternet.Text));
            kmt.Parameters.AddWithValue("@P7", decimal.Parse(txtmaas.Text));
            kmt.Parameters.AddWithValue("@P8", decimal.Parse(txtekstra.Text));
            kmt.Parameters.AddWithValue("@P9", rchnotlar.Text);
            kmt.Parameters.AddWithValue("@P10", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }
    }
}
