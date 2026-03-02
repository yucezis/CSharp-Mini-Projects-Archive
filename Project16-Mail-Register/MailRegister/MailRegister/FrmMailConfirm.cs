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
    public partial class FrmMailConfirm: Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }

        Db16ProjectEntities context = new Db16ProjectEntities();
        public string mail;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtMail.Text = mail;
            
            var value = context.TblUser.Where(x => x.Mail == txtMail.Text).Select(y => y.ConfirmCode).FirstOrDefault();

            if (value == txtConfirmCode.Text)
            {
                var value2 = context.TblUser.Where(x => x.Mail == txtMail.Text).FirstOrDefault();
                value2.IsConfirm = true;
                context.SaveChanges();

                MessageBox.Show("Başarıyla kayıt oldunuz");
            }
            else
            {
                MessageBox.Show("Hatalı kod ");
            }



        }

        private void FrmMailConfirm_Load(object sender, EventArgs e)
        {

            txtMail.Text = mail;
        }
            
        
    }
}
