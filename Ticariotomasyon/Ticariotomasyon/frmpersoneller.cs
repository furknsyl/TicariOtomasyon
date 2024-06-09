using DevExpress.XtraPrinting.BarCode;
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
    public partial class frmpersoneller : Form
    {
        public frmpersoneller()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        void listele()
        {

            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * from TBL_PERSONELLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource= dt; 

        }
        void sehirlistele()
        {
            SqlCommand kmt = new SqlCommand("Select SEHIR from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }
        
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsyoad.Text = "";
            msktel1.Text = "";
            msktc.Text = "";
            txtmail.Text = "";
            cmbilce.Text = "";
            cmbil.Text = "";
            richadres.Text = "";
            txtgorev.Text = "";

        }
        private void frmpersoneller_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistele();
            temizle();
            
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand kmt = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR=@P1", bgl.baglanti());
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
            SqlCommand kmt = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", txtad.Text);
            kmt.Parameters.AddWithValue("@P2", txtsyoad.Text);
            kmt.Parameters.AddWithValue("@P3", msktel1.Text);
            kmt.Parameters.AddWithValue("@P4", msktc.Text);
            kmt.Parameters.AddWithValue("@P5", txtmail.Text);
            kmt.Parameters.AddWithValue("@P6", cmbil.Text);
            kmt.Parameters.AddWithValue("@P7", cmbilce.Text);
            kmt.Parameters.AddWithValue("@P8", richadres.Text);
            kmt.Parameters.AddWithValue("@P9", txtgorev.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr!=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsyoad.Text = dr["SOYAD"].ToString();
                msktel1.Text = dr["TELEFON"].ToString();
                msktc.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                richadres.Text = dr["ADRES"].ToString();
                txtgorev.Text = dr["GOREV"].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Delete from TBL_PERSONELLER where ID=@P1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update TBL_PERSONELLER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 where ID=@P10",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", txtad.Text);
            kmt.Parameters.AddWithValue("@P2", txtsyoad.Text);
            kmt.Parameters.AddWithValue("@P3", msktel1.Text);
            kmt.Parameters.AddWithValue("@P4", msktc.Text);
            kmt.Parameters.AddWithValue("@P5", txtmail.Text);
            kmt.Parameters.AddWithValue("@P6", cmbil.Text);
            kmt.Parameters.AddWithValue("@P7", cmbilce.Text);
            kmt.Parameters.AddWithValue("@P8", richadres.Text);
            kmt.Parameters.AddWithValue("@P9", txtgorev.Text);
            kmt.Parameters.AddWithValue("@P10", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
