using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailRegister
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db16ProjectEntities context = new Db16ProjectEntities();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int confirmCode = random.Next(100000, 1000000);

            TblUser user = new TblUser();

            user.Mail = txtMail.Text;
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Password = txtPassword.Text;
            user.IsConfirm = false;
            user.ConfirmCode = confirmCode.ToString();

            context.TblUser.Add(user);
            context.SaveChanges();

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister", "mail");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtMail.Text);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Kayıt olmak için aktivasyon kodu: " + confirmCode;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Aktivasyon Kodunuz";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("mail", "key");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            MessageBox.Show("aktivasyon kodunuz mailinize gönderilmiştir");

            FrmMailConfirm frmMailConfirm = new FrmMailConfirm();
            frmMailConfirm.mail = txtMail.Text;
            frmMailConfirm.Show();
        }
    }
}
