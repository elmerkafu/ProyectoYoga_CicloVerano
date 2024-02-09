using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TestWindows_WCF_Reserva
{
    internal class EnviarEmail
    {
        public int Enviar(string email, string emisor, string pass)
        {
            Random rnd = new Random();
            int numero  = rnd.Next(100000, 1000000);
            MailMessage msg = new MailMessage();

            msg.To.Add(email);
            msg.Subject = "Codigo de verificacion Yoga Grupo 5";
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "Su codigo de verificacion es " +numero+ " Por favor proporcionelo a nuestro personal para su registro.";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(emisor);
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(emisor, pass);
            client.Port = 25;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            try
            {
                client.Send(msg);
            }
            catch(Exception)      
            {
                MessageBox.Show("Correo no enviado, email no valido");
                numero= 0;
            }


            return numero;
        }
    }
}
