using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace TextBook_RusLanguage
{
    public partial class TaskForm : Telerik.WinControls.UI.RadForm
    {
        string path = Application.StartupPath;
        string fileSend = Application.StartupPath + "\\RusLanguage\\Task\\template.docx";
        public TaskForm()
        {
            InitializeComponent();
        }

        public void SendMail()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client =
                new SmtpClient("smtp.mail.ru", Convert.ToInt32(0x19)) // сервер,порт
                {
                    Credentials = new NetworkCredential("kurscoshinenit@mail.ru", "RkfccysqGfhjkm"),
                    EnableSsl = true // обязательно!
                };
                message.From = new MailAddress("kurscoshinenit@mail.ru");
                message.To.Add(new MailAddress("sabotender@mail.ru"));
                message.Subject = "Заголовок";
                message.SubjectEncoding = Encoding.UTF8;
                message.Body = "Текст в форме сообщения";
                message.BodyEncoding = Encoding.UTF8; // кодировка 
                string fileName = @fileSend; // какой-нибудь файл
                Attachment item = new Attachment(fileName);
                message.Attachments.Add(item);// добавляем файл к сообщению
                client.Send(message); // отправка сообщения
                MessageBox.Show("Сообщение отправлено успешно.", "Сообщение отправлено успешно.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string template = path + "\\RusLanguage\\Task\\template.docx";
            string newNode = path + "\\RusLanguage\\Task\\Задание-" + dateTime.ToString("dd-MMMM-yyyy-H-mm-ss") + ".docx";
            File.Copy(template, newNode);
            try
            {

                Word.Application word = new Word.Application();
                word.Visible = true;
                word.Documents.Open(newNode);
                radTextBox1.Text = newNode;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка открытия Word", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            SendMail();
           
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            radTextBox1.Text = openFileDialog1.FileName;
            if (openFileDialog1.FileName == "openFileDialog1")
            {
                fileSend = "";
            }
            else
            {
                fileSend = openFileDialog1.FileName;
            }
            
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (radTextBox1.Text == "")
            {
                radButton2.Enabled = false;
            }
            else
            {
                radButton2.Enabled = true;
            }
        }
    }
}
