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
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl= new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void sehirlistele()
        {
            SqlCommand kmt=new SqlCommand("Select SEHIR from TBL_ILLER",bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while(dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }
        void temizle()
        {
            txtad.Text = "";
            txtid.Text = "";
            txtmail.Text = "";
            txtsyoad.Text = "";
            txtvergi.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            richadres.Text = "";
            msktc.Text = "";
            msktel1.Text="";
            msktel2.Text = "";

        }
        private void frmmusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistele();
        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand kmt=new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR=@P1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtad.Text);
            kmt.Parameters.AddWithValue("@p2", txtsyoad.Text);
            kmt.Parameters.AddWithValue("@p3", msktel1.Text);
            kmt.Parameters.AddWithValue("@p4", msktel2.Text);
            kmt.Parameters.AddWithValue("@p5", msktc.Text);
            kmt.Parameters.AddWithValue("@p6", txtmail.Text);
            kmt.Parameters.AddWithValue("@p7", cmbil.Text);
            kmt.Parameters.AddWithValue("@p8", cmbilce.Text);
            kmt.Parameters.AddWithValue("@p9", richadres.Text);
            kmt.Parameters.AddWithValue("@p10",txtvergi.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sisteme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsyoad.Text = dr["SOYAD"].ToString();
                msktel1.Text = dr["TELEFON"].ToString();
                msktel2.Text = dr["TELEFON2"].ToString();
                msktc.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                richadres.Text = dr["ADRES"].ToString();
                txtvergi.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
             DialogResult secenek= MessageBox.Show("Gerçekten Silmek istiyor musunuz?","Bilgi", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (secenek==DialogResult.Yes)
            {
                SqlCommand kmt = new SqlCommand("Delete from TBL_MUSTERILER where ID=@P1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txtid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_MUSTERILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9,VERGIDAIRE=@P10 where ID=@P11",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtad.Text);
            kmt.Parameters.AddWithValue("@p2", txtsyoad.Text);
            kmt.Parameters.AddWithValue("@p3", msktel1.Text);
            kmt.Parameters.AddWithValue("@p4", msktel2.Text);
            kmt.Parameters.AddWithValue("@p5", msktc.Text);
            kmt.Parameters.AddWithValue("@p6", txtmail.Text);
            kmt.Parameters.AddWithValue("@p7", cmbil.Text);
            kmt.Parameters.AddWithValue("@p8", cmbilce.Text);
            kmt.Parameters.AddWithValue("@p9", richadres.Text);
            kmt.Parameters.AddWithValue("@p10", txtvergi.Text);
            kmt.Parameters.AddWithValue("@p11", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sistem başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
