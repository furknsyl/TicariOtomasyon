﻿using System;
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
    public partial class frmstokdetay : Form
    {
        public frmstokdetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        public string ad;
        private void frmstokdetay_Load(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM TBL_URUNLER where URUNAD='"+ ad+"'",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource= dt;
        }
    }
}
