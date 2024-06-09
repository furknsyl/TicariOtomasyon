using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticariotomasyon
{
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }

        private void frmraporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'DboTicariOtomasonDataSet3.TBL_PERSONELLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_PERSONELLERTableAdapter.Fill(this.DboTicariOtomasonDataSet3.TBL_PERSONELLER);
            // TODO: Bu kod satırı 'DboTicariOtomasonDataSet2.TBL_GIDERLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboTicariOtomasonDataSet2.TBL_GIDERLER);
            // TODO: Bu kod satırı 'DboTicariOtomasonDataSet.TBL_FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_FIRMALARTableAdapter.Fill(this.DboTicariOtomasonDataSet.TBL_FIRMALAR);
            // TODO: Bu kod satırı 'DboTicariOtomasonDataSet1.TBL_MUSTERILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            this.TBL_MUSTERILERTableAdapter.Fill(this.DboTicariOtomasonDataSet1.TBL_MUSTERILER);
            this.reportViewer3.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();




        }
    }
    
}
