using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;


using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Phần_mềm_gửi_mail_hàng_loạt
{
    public partial class Form1 : Form
    {
        Attachment attack = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txbAttack.Text = dialog.FileName;
            }
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            Thread threadd = new Thread(() =>
            {
                attack = null;
                try
                {
                    //FileInfo file = new FileInfo(txbAttack.Text);
                    attack = new Attachment(txbAttack.Text);
                }
                catch { }

                //Thao tác với file.
                StreamReader sr = new StreamReader(txbTo.Text);
                string email;
                while ((email = sr.ReadLine()) != null)
                {
                    Sentmail(txbId.Text, email, txbSubject.Text, txbMessage.Text, attack);
                }
                sr.Close();
            });
            threadd.Start();

        }
        /// <summary>
        /// gửi mail theo các thông tin truyền vào!
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="file"></param>
        void Sentmail(string from, string to, string subject, string message, Attachment file = null)
        {
            try
            {
                MailMessage Message = new MailMessage(from, to, subject, message);

                if (file != null)
                {
                    Message.Attachments.Add(file);
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;


                client.Credentials = new NetworkCredential(txbId.Text, txbPassword.Text);

                client.Send(Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Bạn nhập sai ID hoặc password!, vui lòng kiểm tra lại!");
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txbTo.Text = dialog.FileName;
            }

        }
    }
}
//https://www.google.com/settings/u/1/security/lesssecureapps ứng dụng kém bảo mật hơn.
