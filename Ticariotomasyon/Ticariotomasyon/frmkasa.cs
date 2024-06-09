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
using DevExpress.Charts;

namespace Ticariotomasyon
{
    public partial class frmkasa : Form
    {
        public frmkasa()
        {
            InitializeComponent();
        }

        public string ad;
        void müsterihareket()
        {
            SqlDataAdapter da= new SqlDataAdapter("execute MüşteriHareketleri",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firmahareket()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute FirmaHareketleri", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl3.DataSource = dt;

        }

        void kasacikis()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDERLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        private void frmkasa_Load(object sender, EventArgs e)
        {
            müsterihareket();
            firmahareket();
            kasacikis();

            lblaktifk.Text = ad;
            
            // TOPLAM TUTAR 

            SqlCommand kmt=new SqlCommand("select sum(TUTAR) from TBL_FATURADETAY",bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lbltoplamtutar.Text = dr[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            //FATURA SON AY

            SqlCommand kmt2 = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ) from TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                lblodemeler.Text = dr2[0].ToString() + " TL"; 
            }
            bgl.baglanti().Close();

            // PERSONEL MAAŞLARI

            SqlCommand kmt3 = new SqlCommand("select MAAS from TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr3 = kmt3.ExecuteReader();
            while (dr3.Read())
            {
              lblpermaas.Text = dr3[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            // MÜŞTERİ SAYISI

            SqlCommand kmt4 = new SqlCommand("select count(*) from TBL_MUSTERILER",bgl.baglanti());
            SqlDataReader dr4 = kmt4.ExecuteReader();
            while (dr4.Read())
            {
                lblmussayısı.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            // FİRMA SAYISI

            SqlCommand kmt5 = new SqlCommand("select count(*) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = kmt5.ExecuteReader();
            while (dr5.Read())
            {
                lblfirsayısı.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            // EKSTRA GİDERLER

            SqlCommand kmt6 = new SqlCommand("select sum(EKSTRA) from TBL_GIDERLER", bgl.baglanti());
            SqlDataReader dr6 = kmt6.ExecuteReader();
            while (dr6.Read())
            {
               lblekstragiderler.Text = dr6[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            // PERSONEL SAYISI

            SqlCommand kmt7 = new SqlCommand("select count(*) from TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr7 = kmt7.ExecuteReader();
            while (dr7.Read())
            {
                lblpersayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            // STOK SAYISI

            SqlCommand kmt8 = new SqlCommand("select sum(ADET) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr8 = kmt8.ExecuteReader();
            while (dr8.Read())
            {
                lblstoksayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

           


        }

        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac>0 &&sayac<=5)
            {
                groupControl1.Text = "ELEKTRİK";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand kmt9 = new SqlCommand("select TOP 4 AY,ELEKTRIK from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr9 = kmt9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac > 5 && sayac <= 10)
            {
                groupControl1.Text = "SU";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand kmt10 = new SqlCommand("select TOP 4 AY,SU from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = kmt10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();

            }

            if (sayac > 10 && sayac <= 15)
            {
                groupControl1.Text = "DOĞALGAZ";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand kmt10 = new SqlCommand("select TOP 4 AY,DOGALGAZ from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = kmt10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac > 15 && sayac <= 20)
            {
                groupControl1.Text = "EKSTRA";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand kmt10 = new SqlCommand("select TOP 4 AY,EKSTRA from TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = kmt10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac == 26)
            {
                sayac = 0;

            }
        }
    }
}
