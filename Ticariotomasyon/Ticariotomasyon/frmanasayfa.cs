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
using System.Xml;

namespace Ticariotomasyon
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        void azalanstoklar()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT URUNAD,SUM(ADET) AS 'ADET' FROM TBL_URUNLER GROUP BY URUNAD HAVING SUM(ADET)<20 ORDER BY SUM(ADET)",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void ajanda()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TARIH,SAAT,BASLIK FROM TBL_NOTLAR ORDER BY ID DESC", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl3.DataSource = dt;

        }

        void firmahareketleri()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute FirmaHareketleri2",bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;


        }
        void musterihareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MüşteriHareketleri2", bgl.baglanti());
            da.Fill(dt);
            gridControl4.DataSource = dt;

        }

        void haberler()
        {


        }
        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            azalanstoklar();
            ajanda();
            firmahareketleri();
            musterihareketleri();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            webBrowser2.Navigate("https://www.haberler.com/");
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }
    }
}
