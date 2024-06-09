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
using System.Data.SqlTypes;

namespace Ticariotomasyon
{
    public partial class frmbankalar : Form
    {
        public frmbankalar()
        {
            InitializeComponent();
        }

        void listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("execute BankaBilgileri",bgl.baglanti());
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

        void firmalistesi()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD from TBL_FIRMALAR",bgl.baglanti());
            da.Fill(dt);
            lookupfirma.Properties.ValueMember="ID";
            lookupfirma.Properties.DisplayMember = "AD";
            lookupfirma.Properties.DataSource = dt;
        }

        void temizle()
        {
            txtbankaadi.Text = "";
            txthturu.Text = "";
            txtiban.Text = "";
            txtibanno.Text = "";
            txtsube.Text = "";
            txtyetkili.Text = "";
            msktarih.Text = "";
            msktel.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            lookupfirma.Text = "";
            txtid.Text = "";
            

        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmbankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistele();
            firmalistesi();
            temizle();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into TBL_BANKA (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TARIH,TELEFON,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1",txtbankaadi.Text);
            kmt.Parameters.AddWithValue("@p2", cmbil.Text);
            kmt.Parameters.AddWithValue("@p3", cmbilce.Text);
            kmt.Parameters.AddWithValue("@p4", txtsube.Text);
            kmt.Parameters.AddWithValue("@p5", txtiban.Text);
            kmt.Parameters.AddWithValue("@p6", txtibanno.Text);
            kmt.Parameters.AddWithValue("@p7", txtyetkili.Text);
            kmt.Parameters.AddWithValue("@p8", msktarih.Text);
            kmt.Parameters.AddWithValue("@p9", msktel.Text);
            kmt.Parameters.AddWithValue("@p10", txthturu.Text);
            kmt.Parameters.AddWithValue("@p11", lookupfirma.EditValue);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                txtbankaadi.Text = dr["BANKAADI"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtsube.Text = dr["SUBE"].ToString();
                txtiban.Text = dr["IBAN"].ToString();
                txtibanno.Text = dr["HESAPNO"].ToString();
                txtyetkili.Text = dr["YETKILI"].ToString();
                msktarih.Text = dr["TARIH"].ToString();
                txthturu.Text = dr["HESAPTURU"].ToString();

            }

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from TBL_BANKA where ID=@P1",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",txtid.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (lookupfirma.EditValue==null)
            {
                MessageBox.Show("LÜTFEN FİRMA BİLGİLERİNİ BOŞ BIRAKMAYINIZ !!!");
            }
            else
            {
                SqlCommand kmt = new SqlCommand("update TBL_BANKA set BANKAADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 WHERE ID=@P12", bgl.baglanti());
                kmt.Parameters.AddWithValue("@P1", txtbankaadi.Text);
                kmt.Parameters.AddWithValue("@P2", cmbil.Text);
                kmt.Parameters.AddWithValue("@P3", cmbilce.Text);
                kmt.Parameters.AddWithValue("@P4", txtsube.Text);
                kmt.Parameters.AddWithValue("@P5", txtiban.Text);
                kmt.Parameters.AddWithValue("@P6", txtibanno.Text);
                kmt.Parameters.AddWithValue("@P7", txtyetkili.Text);
                kmt.Parameters.AddWithValue("@P8", msktarih.Text);
                kmt.Parameters.AddWithValue("@P9", msktel.Text);
                kmt.Parameters.AddWithValue("@P10", txthturu.Text);
                kmt.Parameters.AddWithValue("@P11", lookupfirma.EditValue);
                kmt.Parameters.AddWithValue("@P12", txtid.Text);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();

            }
            
        }
    }
}
