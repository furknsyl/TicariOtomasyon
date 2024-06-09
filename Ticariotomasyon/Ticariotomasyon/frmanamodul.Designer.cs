namespace Ticariotomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnanasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnurunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnstoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnmusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnfirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnpersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btngiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnkasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnnotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnbankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnrehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnfaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnhareketler = new DevExpress.XtraBars.BarButtonItem();
            this.btnraporlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnayarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnanasayfa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnurunler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnstoklar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnmusteriler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnfirmalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnpersoneller);
            this.ribbonPageGroup2.ItemLinks.Add(this.btngiderler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnkasa);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnnotlar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnbankalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnrehber);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnfaturalar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnhareketler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnraporlar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnayarlar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Caption = "ANA SAYFA";
            this.btnanasayfa.Id = 13;
            this.btnanasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.Image")));
            this.btnanasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.LargeImage")));
            this.btnanasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnanasayfa_ItemClick);
            // 
            // btnurunler
            // 
            this.btnurunler.Caption = "ÜRÜNLER";
            this.btnurunler.Id = 1;
            this.btnurunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnurunler.ImageOptions.Image")));
            this.btnurunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnurunler.ImageOptions.LargeImage")));
            this.btnurunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnurunler.Name = "btnurunler";
            this.btnurunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnurunler_ItemClick);
            // 
            // btnstoklar
            // 
            this.btnstoklar.Caption = "STOKLAR";
            this.btnstoklar.Id = 2;
            this.btnstoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnstoklar.ImageOptions.Image")));
            this.btnstoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnstoklar.ImageOptions.LargeImage")));
            this.btnstoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnstoklar.Name = "btnstoklar";
            this.btnstoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnstoklar_ItemClick);
            // 
            // btnmusteriler
            // 
            this.btnmusteriler.Caption = "MÜŞTERİLER";
            this.btnmusteriler.Id = 3;
            this.btnmusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteriler.ImageOptions.Image")));
            this.btnmusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnmusteriler.ImageOptions.LargeImage")));
            this.btnmusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnmusteriler.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteriler.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnmusteriler.Name = "btnmusteriler";
            this.btnmusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnfirmalar
            // 
            this.btnfirmalar.Caption = "FİRMALAR";
            this.btnfirmalar.Id = 4;
            this.btnfirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfirmalar.ImageOptions.Image")));
            this.btnfirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfirmalar.ImageOptions.LargeImage")));
            this.btnfirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnfirmalar.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfirmalar.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnfirmalar.Name = "btnfirmalar";
            this.btnfirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnfirmalar_ItemClick);
            // 
            // btnpersoneller
            // 
            this.btnpersoneller.Caption = "PERSONELLER";
            this.btnpersoneller.Id = 5;
            this.btnpersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpersoneller.ImageOptions.Image")));
            this.btnpersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnpersoneller.ImageOptions.LargeImage")));
            this.btnpersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.btnpersoneller.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersoneller.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnpersoneller.Name = "btnpersoneller";
            this.btnpersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpersoneller_ItemClick);
            // 
            // btngiderler
            // 
            this.btngiderler.Caption = "GİDERLER";
            this.btngiderler.Id = 6;
            this.btngiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngiderler.ImageOptions.Image")));
            this.btngiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btngiderler.ImageOptions.LargeImage")));
            this.btngiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btngiderler.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiderler.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btngiderler.Name = "btngiderler";
            this.btngiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngiderler_ItemClick);
            // 
            // btnkasa
            // 
            this.btnkasa.Caption = "KASA";
            this.btnkasa.Id = 7;
            this.btnkasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkasa.ImageOptions.Image")));
            this.btnkasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkasa.ImageOptions.LargeImage")));
            this.btnkasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnkasa.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkasa.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnkasa.Name = "btnkasa";
            this.btnkasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkasa_ItemClick);
            // 
            // btnnotlar
            // 
            this.btnnotlar.Caption = "NOTLAR";
            this.btnnotlar.Id = 8;
            this.btnnotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnotlar.ImageOptions.Image")));
            this.btnnotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnotlar.ImageOptions.LargeImage")));
            this.btnnotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnnotlar.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnotlar.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnnotlar.Name = "btnnotlar";
            this.btnnotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnotlar_ItemClick);
            // 
            // btnbankalar
            // 
            this.btnbankalar.Caption = "BANKALAR";
            this.btnbankalar.Id = 9;
            this.btnbankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbankalar.ImageOptions.Image")));
            this.btnbankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnbankalar.ImageOptions.LargeImage")));
            this.btnbankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnbankalar.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbankalar.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnbankalar.Name = "btnbankalar";
            this.btnbankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnbankalar_ItemClick);
            // 
            // btnrehber
            // 
            this.btnrehber.Caption = "REHBER";
            this.btnrehber.Id = 10;
            this.btnrehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrehber.ImageOptions.Image")));
            this.btnrehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnrehber.ImageOptions.LargeImage")));
            this.btnrehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnrehber.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrehber.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnrehber.Name = "btnrehber";
            this.btnrehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnrehber_ItemClick);
            // 
            // btnfaturalar
            // 
            this.btnfaturalar.Caption = "FATURALAR";
            this.btnfaturalar.Id = 11;
            this.btnfaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfaturalar.ImageOptions.Image")));
            this.btnfaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfaturalar.ImageOptions.LargeImage")));
            this.btnfaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnfaturalar.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfaturalar.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnfaturalar.Name = "btnfaturalar";
            this.btnfaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnfaturalar_ItemClick);
            // 
            // btnhareketler
            // 
            this.btnhareketler.Caption = "HAREKETLER";
            this.btnhareketler.Id = 14;
            this.btnhareketler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnhareketler.ImageOptions.SvgImage")));
            this.btnhareketler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhareketler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnhareketler.Name = "btnhareketler";
            this.btnhareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhareketler_ItemClick);
            // 
            // btnraporlar
            // 
            this.btnraporlar.Caption = "RAPORLAR";
            this.btnraporlar.Id = 15;
            this.btnraporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnraporlar.ImageOptions.Image")));
            this.btnraporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnraporlar.ImageOptions.LargeImage")));
            this.btnraporlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnraporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnraporlar.Name = "btnraporlar";
            this.btnraporlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnraporlar_ItemClick);
            // 
            // btnayarlar
            // 
            this.btnayarlar.Caption = "AYARLAR";
            this.btnayarlar.Id = 12;
            this.btnayarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.Image")));
            this.btnayarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.LargeImage")));
            this.btnayarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnayarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnayarlar.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnayarlar.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnayarlar.Name = "btnayarlar";
            this.btnayarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnayarlar_ItemClick);
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.btnurunler,
            this.btnstoklar,
            this.btnmusteriler,
            this.btnfirmalar,
            this.btnpersoneller,
            this.btngiderler,
            this.btnkasa,
            this.btnnotlar,
            this.btnbankalar,
            this.btnrehber,
            this.btnfaturalar,
            this.btnayarlar,
            this.btnanasayfa,
            this.btnhareketler,
            this.btnraporlar});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonControl2.MaxItemId = 16;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.Size = new System.Drawing.Size(1924, 183);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1924, 553);
            this.Controls.Add(this.ribbonControl2);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnanasayfa;
        private DevExpress.XtraBars.BarButtonItem btnurunler;
        private DevExpress.XtraBars.BarButtonItem btnstoklar;
        private DevExpress.XtraBars.BarButtonItem btnmusteriler;
        private DevExpress.XtraBars.BarButtonItem btnfirmalar;
        private DevExpress.XtraBars.BarButtonItem btnpersoneller;
        private DevExpress.XtraBars.BarButtonItem btngiderler;
        private DevExpress.XtraBars.BarButtonItem btnkasa;
        private DevExpress.XtraBars.BarButtonItem btnnotlar;
        private DevExpress.XtraBars.BarButtonItem btnbankalar;
        private DevExpress.XtraBars.BarButtonItem btnrehber;
        private DevExpress.XtraBars.BarButtonItem btnfaturalar;
        private DevExpress.XtraBars.BarButtonItem btnayarlar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnhareketler;
        private DevExpress.XtraBars.BarButtonItem btnraporlar;
    }
}

