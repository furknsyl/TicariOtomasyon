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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            SqlCommand kmt = new SqlCommand("select * from TBL_ADMINLER where KULLANICIAD=@P1 AND SIFRE=@P2",bgl.baglanti());
            kmt.Parameters.AddWithValue("@P1",textEdit1.Text);
            kmt.Parameters.AddWithValue("@P2",textEdit2.Text);
            SqlDataReader dr= kmt.ExecuteReader();
            if (dr.Read())
            {

                Form1 fr = new Form1();
                fr.kullanici = textEdit1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
