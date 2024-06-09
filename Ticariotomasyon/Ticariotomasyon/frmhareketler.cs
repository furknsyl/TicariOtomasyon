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
    public partial class frmhareketler : Form
    {
        public frmhareketler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmahareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("execute FirmaHareketleri",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;

        }
        void müsterihareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute MüşteriHareketleri", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        private void frmhareketler_Load(object sender, EventArgs e)
        {
            firmahareketleri();
            müsterihareketleri();
        }
    }
}
