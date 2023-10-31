using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows;
using Xamarin.Forms;

namespace UniSport
{
    class EnviarMailRecPassword
    {
        public int Enviar(string receptor,string mensaje)
        {
            Random r = new Random();
            int numero = r.Next(100000,999999);
            MailMessage mail = new MailMessage();
            mail.To.Add(receptor);
            mail.Subject = "Correo de Verificacion";
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Body = "Su codigo de verificaion es: " + numero + ". Si no solicito la verificacion ignore este mensaje...";
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = false;
            mail.From = new MailAddress("francis_cruz2@hotmail.com.ar");
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("francis_cruz2@hotmail.com.ar", "#28GH27nu89ntJzw");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.office365.com";
            try
            {
                client.Send(mail);
                
            }
            catch (Exception)
            {
                
                throw;
            }
            return 0;
        }
    }
}
