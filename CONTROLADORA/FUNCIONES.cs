using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class FUNCIONES
    {

        #region METODOS
        public static string encriptar_clave(string clave)
        {




            return clave;
        }


        public static string generar_clave_aleatorioa()
        {






            return "";
        }

        public static bool enviar_mail(string asunto, string mensaje, string destinatario)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(destinatario);
            mmsg.Subject = asunto;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8; //Para los servidores

            mmsg.Body = mensaje;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;

            mmsg.From = new System.Net.Mail.MailAddress("empresaelchulo@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("empresaelchulo@gmail.com", "ottolini12345");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com"; //mail.dominio.com

            try
            {
                cliente.Send(mmsg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    #endregion

    #region VALIDACIONES
    /*public static bool validar_mail(string mail)
    {




        return true;
    }*/
    #endregion


}
