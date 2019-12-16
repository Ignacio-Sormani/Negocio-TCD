using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace CONTROLADORA
{
    public class FUNCIONES
    {

        #region METODOS
        public static string encriptar_clave(string clave)
        {
            byte[] passBytes = Encoding.Unicode.GetBytes(clave);
            SHA256 sha = SHA256.Create();
            byte[] hash = sha.ComputeHash(passBytes);
            string hashString = Encoding.Unicode.GetString(hash);
            return hashString;
        }

        public static string generar_clave_aleatoria()
        {
            char[] ValueAfanumeric = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random random = new Random();
            int longitud = 8;
            string clave = String.Empty;
            for (int i = 0; i < longitud; i++)
            {
                int rm = random.Next(0, 2);
                if (rm == 0)
                {
                    clave += random.Next(0, 10);
                }
                else
                {
                    clave += ValueAfanumeric[random.Next(0, 59)];
                }
            }
            return clave;
        }

        public static bool enviar_mail(string asunto, string mensaje, string destinatario)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(destinatario);
            msg.Subject = asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = mensaje;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("nacho.libreria.2@gmail.com");
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("nacho.libreria.2@gmail.com", "n1a2c3h4o5");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void crear_excel()
        {
            string FileTest = "C:\\Users\\Usuario\\Documents\\Excel\\Planilla.xlsx";
            if (File.Exists(FileTest))
            {
                File.Delete(FileTest);
            }
            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;
            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
            oSheet.Cells[1, 1] = "12345";

            oBook.SaveAs(FileTest);
            oBook.Close();
            oApp.Quit();
        }

        //public static string generar_backup(){}

        //public static bool recuperar_backup(string directorio){}

        #endregion

        #region VALIDACIONES
        public static bool validar_mail(string mail)
        {
            string expresion;
            expresion = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";
            System.Text.RegularExpressions.Regex automata = new Regex(expresion);
            return automata.IsMatch(mail);
        }

        #endregion
    }
}
