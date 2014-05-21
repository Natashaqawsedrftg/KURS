using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Windows.Forms;



namespace KURS
{
    class Mail
    {
        //SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25);
        
       static public  void Message(string to)
        {
            string too = to;
            string from = "mkosmetiki14@mail.ru";
            string subject = "Отчёт.";
            string body = @"Отчёт о работе магазина за текущий период в прикрепленном файле.";
            MailMessage message = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.mail.ru", 25);
            // Credentials are necessary if the server requires the client  
            // to authenticate before it will send e-mail on the client's behalf.
            client.Credentials = new NetworkCredential("mkosmetiki14@mail.ru", "qawsedrftg1");
                //CredentialCache.DefaultNetworkCredentials;

            string file = @"C:\Users\Андрей свали с компа\Desktop\просто.docx";// адрес на отчет
            Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);
            message.Attachments.Add(attach);



            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
              MessageBox.Show("Exception caught in CreateTestMessage1(): {0}",
                      ex.ToString());
            }
        }
    }
}
