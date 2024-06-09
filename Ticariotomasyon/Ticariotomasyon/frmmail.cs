using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticariotomasyon
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmmail_Load(object sender, EventArgs e)
        {
            txtmailadres.Text = mail;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.UseDefaultCredentials = false;
            istemci.Credentials = new System.Net.NetworkCredential("fsoylu500@gmail.com","FSfs2002");
            istemci.Port = 587;
            istemci.Host = "smtp-mail.outlook.com";
            istemci.DeliveryMethod = SmtpDeliveryMethod.Network;
            istemci.EnableSsl = true;
            mesajım.To.Add(txtmailadres.Text);
            mesajım.From = new MailAddress("fsoylu500@gmail.com");
            mesajım.Subject = txtkonu.Text;
            mesajım.Body = rchmesaj.Text;
            istemci.Send(mesajım);
            MessageBox.Show("Mail gönderildi");
             

        }
    }
}
