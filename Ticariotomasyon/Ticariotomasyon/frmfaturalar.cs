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
using DevExpress.XtraRichEdit.Model;
using DevExpress.CodeParser;

namespace Ticariotomasyon
{
    public partial class frmfaturalar : Form
    {
        public frmfaturalar()
        {
            InitializeComponent();
        }

        private void cmbil_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbilce_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        void listele()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * from TBL_FATURABILGI",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;

        }
        void temizle()
        {
            txtid.Text = "";
            txtalici.Text="";
            txtseri.Text = "";
            txtsirano.Text = "";
            txttalan.Text = "";
            txtteden.Text = "";
            txtvergidd.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";


        }

        private void frmfaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtseri.Text);
            kmt.Parameters.AddWithValue("@p2", txtsirano.Text);
            kmt.Parameters.AddWithValue("@p3", msktarih.Text);
            kmt.Parameters.AddWithValue("@p4", msksaat.Text);
            kmt.Parameters.AddWithValue("@p5", txtvergidd.Text);
            kmt.Parameters.AddWithValue("@p6", txtalici.Text);
            kmt.Parameters.AddWithValue("@p7", txtteden.Text);
            kmt.Parameters.AddWithValue("@p8", txttalan.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sisteme Başarıyla Kaydedildi.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null) 
            {
                txtalici.Text = dr["ALICI"].ToString();
                txtseri.Text = dr["SERI"].ToString();
                txtsirano.Text = dr["SIRANO"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                txtvergidd.Text = dr["VERGIDAIRE"].ToString();
                txtteden.Text = dr["TESLIMEDEN"].ToString();
                txttalan.Text = dr["TESLIMALAN"].ToString();
                txtid.Text = dr["FATURABILGIID"].ToString();
                msksaat.Text = dr["SAAT"].ToString();
            }
        }

        private void btnsil2_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@p1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            
        }

        private void btntemizle2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "FİRMA") 
            {
                double miktar, tutar, fiyat;
                miktar = Convert.ToDouble(txtmiktar.Text);
                fiyat = Convert.ToDouble(txtfiyat.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();

                SqlCommand kmt = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txturunad.Text);
                kmt.Parameters.AddWithValue("@p2", txtmiktar.Text);
                kmt.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
                kmt.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                kmt.Parameters.AddWithValue("@p5", txtfaturaid.Text);
                kmt.ExecuteNonQuery();

                //HAREKET TABLOSUNA VERİ GİRİŞİ 

                SqlCommand kmt2 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH,NOTLAR) values (@f1,@f2,@f3,@f4,@f5,@f6,@f7,@f8,@f9)", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@f1", txturunid.Text);
                kmt2.Parameters.AddWithValue("@f2", txtmiktar.Text);
                kmt2.Parameters.AddWithValue("@f3", txtpersonel.Text);
                kmt2.Parameters.AddWithValue("@f4", txtfirma.Text);
                kmt2.Parameters.AddWithValue("@f5", decimal.Parse(txtfiyat.Text));
                kmt2.Parameters.AddWithValue("@f6", decimal.Parse(txttutar.Text));
                kmt2.Parameters.AddWithValue("@f7", txtfaturaid.Text);
                kmt2.Parameters.AddWithValue("@f8", msktarih.Text);
                kmt2.Parameters.AddWithValue("@f9", rchnotlar.Text);

                kmt2.ExecuteNonQuery();

                bgl.baglanti().Close();

                //STOK SAYISINI AZALTMA 

                SqlCommand kmt3 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@M1 where ID=@M2", bgl.baglanti());
                kmt3.Parameters.AddWithValue("@M1", txtmiktar.Text);
                kmt3.Parameters.AddWithValue("@M2", txturunid.Text);
                kmt3.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Sisteme Başarıyla Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

                
            }
            if (comboBox2.Text == "MÜŞTERİ")
            {
                double miktar, tutar, fiyat;
                miktar = Convert.ToDouble(txtmiktar.Text);
                fiyat = Convert.ToDouble(txtfiyat.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();

                SqlCommand kmt = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", txturunad.Text);
                kmt.Parameters.AddWithValue("@p2", txtmiktar.Text);
                kmt.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
                kmt.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
                kmt.Parameters.AddWithValue("@p5", txtfaturaid.Text);
                kmt.ExecuteNonQuery();

                //HAREKET TABLOSUNA VERİ GİRİŞİ 

                SqlCommand kmt2 = new SqlCommand("insert into TBL_MUSTERIHAREKETLER (URUNID,ADET,PERSONEL,MUSTERI,FIYAT,TOPLAM,FATURAID,TARIH,NOTLAR) values (@f1,@f2,@f3,@f4,@f5,@f6,@f7,@f8,@f9)", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@f1", txturunid.Text);
                kmt2.Parameters.AddWithValue("@f2", txtmiktar.Text);
                kmt2.Parameters.AddWithValue("@f3", txtpersonel.Text);
                kmt2.Parameters.AddWithValue("@f4", txtfirma.Text);
                kmt2.Parameters.AddWithValue("@f5", decimal.Parse(txtfiyat.Text));
                kmt2.Parameters.AddWithValue("@f6", decimal.Parse(txttutar.Text));
                kmt2.Parameters.AddWithValue("@f7", txtfaturaid.Text);
                kmt2.Parameters.AddWithValue("@f8", msktarih.Text);
                kmt2.Parameters.AddWithValue("@f9", rchnotlar.Text);

                kmt2.ExecuteNonQuery();

                bgl.baglanti().Close();

                //STOK SAYISINI AZALTMA 

                SqlCommand kmt3 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@M1 where ID=@M2", bgl.baglanti());
                kmt3.Parameters.AddWithValue("@M1", txtmiktar.Text);
                kmt3.Parameters.AddWithValue("@M2", txturunid.Text);
                kmt3.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Sisteme Başarıyla Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnguncelle2_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand("update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtseri.Text);
            kmt.Parameters.AddWithValue("@p2", txtsirano.Text);
            kmt.Parameters.AddWithValue("@p3", msktarih.Text);
            kmt.Parameters.AddWithValue("@p4", msksaat.Text);
            kmt.Parameters.AddWithValue("@p5", txtvergidd.Text);
            kmt.Parameters.AddWithValue("@p6", txtalici.Text);
            kmt.Parameters.AddWithValue("@p7", txtteden.Text);
            kmt.Parameters.AddWithValue("@p8", txttalan.Text);
            kmt.Parameters.AddWithValue("@p9", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           frmfaturaurundetay fr=new frmfaturaurundetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        
                SqlCommand kmt = new SqlCommand("select URUNAD,SATISFIYAT FROM TBL_URUNLER where ID=@P1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@P1", txturunid.Text);
                SqlDataReader dr = kmt.ExecuteReader();
                while (dr.Read())
                {
                    txturunad.Text = dr[0].ToString();
                    txtfiyat.Text = dr[1].ToString();
                }
                bgl.baglanti().Close();
            
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
