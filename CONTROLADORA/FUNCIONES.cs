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


        public static void generar_backup()
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "-" + d.Month;

            string servername = "(LocalDb)\\MSSQLLocalDB";
            string dbname = "[DATOS.Negocio]";
            string aaa = @"Data Source=" + servername + "; Initial Catalog= " + dbname + "; Integrated Security=true; MultipleActiveResultSets=True;";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;initial catalog=DATOS.Negocio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            try
            {
                con.Open();
                string str = "USE " + dbname + ";";
                string str1 = "BACKUP DATABASE " + dbname + " TO DISK = 'C:\\Backup_Sistemas\\'" + "Negocio" + "-" + dd + ".Bak' WITH FORMMAT,MEDIANAME = 'Z_SQLserverBackups',NAME = 'full backup of " + "DATOS.Negocio";
                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar generar el Backup. " + ex.Message, ex);
            }
            finally
            {
                con.Close();
            }
        }

        public static string recuperar_backup(string directorio)
        {
            string servername = "(LocalDb)\\MSSQLLocalDB";
            string dbname = "[DATOS.Negocio]";
            string aaa = @"Data Source=" + servername + "; Initial Catalog= " + dbname + "; Integrated Security=true; MultipleActiveResultSets=True;";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;initial catalog=DATOS.Negocio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            try
            {
                con.Open();

                string str = "USE master; ";
                string str1 = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str2 = "RESTORE DATABASE " + dbname + " FROM DISK = '" + directorio + "' WITH REPLACE ";

                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlCommand cmd3 = new SqlCommand(str2, con);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar recuperar el Backup. " + ex.Message, ex);
            }
            finally
            {
                con.Close();
            }
            return directorio;
        }

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
