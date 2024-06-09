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
using DevExpress.Skins;
using System.Runtime.Remoting.Messaging;

namespace Ticariotomasyon
{
    public partial class frmfirmalar : Form
    {
        public frmfirmalar()
        {
            InitializeComponent();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

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
        void kodacıklamalar()
        {
            SqlCommand kmt = new SqlCommand("select FIRMAKOD1 from TBL_KODLAR",bgl.baglanti());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                rchozelkod1.Text = dr[0].ToString();
               
            }

        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsektor.Text = "";
            txtmail.Text = "";
            txtkod1.Text = "";
            txtkod2.Text = "";
            txtkod3.Text = "";
            txtsektor.Text = "";
            txtvergid.Text = "";
            txtyetkili.Text = "";
            txtygorev.Text = "";
            mskfaks.Text = "";
            msktel1.Text = "";
            msktel2.Text = "";
            msktel3.Text = "";
            mskytc.Text = "";
            rchadres.Text = "";
            

        }
        private void frmfirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();
            sehirlistele();
            temizle();
            kodacıklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["AD"].ToString();
                txtsektor.Text = dr["SEKTOR"].ToString();
                txtyetkili.Text = dr["YETKILIADSOYAD"].ToString();
                txtygorev.Text = dr["YETKILISTATU"].ToString();
                mskytc.Text = dr["YETKILITC"].ToString();
                msktel1.Text = dr["TELEFON1"].ToString();
                msktel2.Text = dr["TELEFON2"].ToString();
                msktel3.Text = dr["TELEFON3"].ToString();
                mskfaks.Text = dr["FAX"].ToString();
                txtmail.Text = dr["MAIL"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtvergid.Text = dr["VERGIDAIRE"].ToString();
                rchadres.Text = dr["ADRES"].ToString();
                txtkod1.Text = dr["OZELKOD1"].ToString();
                txtkod2.Text = dr["OZELKOD2"].ToString();
                txtkod3.Text = dr["OZELKOD3"].ToString();


            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_FIRMALAR (AD,SEKTOR,YETKILIADSOYAD,YETKILISTATU,YETKILITC,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtad.Text);
            kmt.Parameters.AddWithValue("@p2", txtsektor.Text);
            kmt.Parameters.AddWithValue("@p3", txtyetkili.Text);
            kmt.Parameters.AddWithValue("@p4", txtygorev.Text);
            kmt.Parameters.AddWithValue("@p5", mskytc.Text);
            kmt.Parameters.AddWithValue("@p6", msktel1.Text);
            kmt.Parameters.AddWithValue("@p7", msktel2.Text);
            kmt.Parameters.AddWithValue("@p8", msktel3.Text);
            kmt.Parameters.AddWithValue("@p9", mskfaks.Text);
            kmt.Parameters.AddWithValue("@p10",txtmail.Text);
            kmt.Parameters.AddWithValue("@p11", cmbil.Text);
            kmt.Parameters.AddWithValue("@p12", cmbilce.Text);
            kmt.Parameters.AddWithValue("@p13", txtvergid.Text);
            kmt.Parameters.AddWithValue("@p14", rchadres.Text);
            kmt.Parameters.AddWithValue("@p15",txtkod1.Text);
            kmt.Parameters.AddWithValue("@p16", txtkod2.Text);
            kmt.Parameters.AddWithValue("@p17",txtkod3.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bşarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            temizle();

        }

        private void cmbilce_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbil_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_FIRMALAR where ID=@P1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            firmalistesi();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update TBL_FIRMALAR set AD=@P1,SEKTOR=@P2,YETKILIADSOYAD=@P3,YETKILISTATU=@P4,YETKILITC=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,FAX=@P9,MAIL=@P10,IL=@P11,ILCE=@P12,VERGIDAIRE=@P13,ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17 WHERE ID=@P18",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1", txtad.Text);
            kmt.Parameters.AddWithValue("@P2", txtsektor.Text);
            kmt.Parameters.AddWithValue("@P3", txtyetkili.Text);
            kmt.Parameters.AddWithValue("@P4", txtygorev.Text);
            kmt.Parameters.AddWithValue("@P5", mskytc.Text);
            kmt.Parameters.AddWithValue("@P6", msktel1.Text);
            kmt.Parameters.AddWithValue("@P7", msktel2.Text);
            kmt.Parameters.AddWithValue("@P8", msktel3.Text);
            kmt.Parameters.AddWithValue("@P9", mskfaks.Text);
            kmt.Parameters.AddWithValue("@P10", txtmail.Text);
            kmt.Parameters.AddWithValue("@P11", cmbil.Text);
            kmt.Parameters.AddWithValue("@P12", cmbilce.Text);
            kmt.Parameters.AddWithValue("@P13", txtvergid.Text);
            kmt.Parameters.AddWithValue("@P14", rchadres.Text);
            kmt.Parameters.AddWithValue("@P15", txtkod1.Text);
            kmt.Parameters.AddWithValue("@P16", txtkod2.Text);
            kmt.Parameters.AddWithValue("@P17", txtkod3.Text);
            kmt.Parameters.AddWithValue("@P18", txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            temizle();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
