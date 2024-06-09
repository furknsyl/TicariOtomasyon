namespace Ticariotomasyon
{
    partial class frmmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtmailadres = new DevExpress.XtraEditors.TextEdit();
            this.rchmesaj = new System.Windows.Forms.RichTextBox();
            this.btngonder = new DevExpress.XtraEditors.SimpleButton();
            this.txtkonu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmailadres
            // 
            this.txtmailadres.Location = new System.Drawing.Point(207, 140);
            this.txtmailadres.Name = "txtmailadres";
            this.txtmailadres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmailadres.Properties.Appearance.Options.UseFont = true;
            this.txtmailadres.Size = new System.Drawing.Size(207, 30);
            this.txtmailadres.TabIndex = 1;
            // 
            // rchmesaj
            // 
            this.rchmesaj.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchmesaj.Location = new System.Drawing.Point(207, 246);
            this.rchmesaj.Name = "rchmesaj";
            this.rchmesaj.Size = new System.Drawing.Size(207, 266);
            this.rchmesaj.TabIndex = 2;
            this.rchmesaj.Text = "";
            // 
            // btngonder
            // 
            this.btngonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngonder.Appearance.Options.UseFont = true;
            this.btngonder.Location = new System.Drawing.Point(207, 532);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(207, 29);
            this.btngonder.TabIndex = 3;
            this.btngonder.Text = "GÖNDER";
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(207, 198);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonu.Properties.Appearance.Options.UseFont = true;
            this.txtkonu.Size = new System.Drawing.Size(207, 30);
            this.txtkonu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Konu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesaj :";
            // 
            // frmmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.rchmesaj);
            this.Controls.Add(this.txtmailadres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmmail";
            this.Text = "MAİL";
            this.Load += new System.EventHandler(this.frmmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmailadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtmailadres;
        private System.Windows.Forms.RichTextBox rchmesaj;
        private DevExpress.XtraEditors.SimpleButton btngonder;
        private DevExpress.XtraEditors.TextEdit txtkonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}