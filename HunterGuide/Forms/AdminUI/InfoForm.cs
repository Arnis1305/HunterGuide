using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.IO;
using System.Net.Mail;
using HunterGuide.EF.Entities;
using HunterGuide.Helpers.Emums;


namespace HunterGuide.Forms.AdminUI
{
    public partial class InfoForm : MetroForm
    {
        private readonly ApplicationUser user;

        public InfoForm(ApplicationUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("hunterguide2503@gmail.com", user.Username);
                // кому отправляем
                MailAddress to = new MailAddress("hunterguide2503@gmail.com");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = user.Username;
                // текст письма
                m.Body = textBox1.Text;
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("hunterguide2503@gmail.com", "Hunterguide12345");
                smtp.EnableSsl = true;
                smtp.Send(m);
                Console.Read();
                MessageBox.Show("Сообщение успешно отправлено!)");
                textBox1.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }



}
