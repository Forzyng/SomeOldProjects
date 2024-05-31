using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace CS_Lan_SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            try
            {

            
            MailMessage message = new MailMessage(txb_from.Text, txb_to.Text);
            message.Subject = txb_theme.Text;
            message.IsBodyHtml = false;
            message.Body = txb_Message.Text;

            //Attachment attachment = new Attachment(); - файл для отправки
            //message.Attachments.Add(attachment);

            SmtpClient smtp = new SmtpClient(txb_server.Text, (int)numericUpDown1.Value);
            smtp.EnableSsl = chb_SSL.Checked;
            smtp.Credentials = new NetworkCredential(txb_from.Text, txb_password.Text);
                MessageBox.Show("START");
            smtp.SendCompleted += Smtp_SendCompleted;
                Action a = () =>
                {
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("END");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Done");
            }
        }
    }
}
