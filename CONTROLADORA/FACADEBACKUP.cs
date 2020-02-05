using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    //FACADE PATTERN
    public class FACADEBACKUP
    {
        private static FACADEBACKUP _instancia;
        private GENERARBACKUP oGenerarBackup;
        private RECUPERARBACKUP oRecuperarBackup;

        private FACADEBACKUP()
        {

            oGenerarBackup = new GENERARBACKUP();
            oRecuperarBackup = new RECUPERARBACKUP();
        }

        public static FACADEBACKUP obtener_instancia()
        {

            if (_instancia == null)
            {
                _instancia = new FACADEBACKUP();
            }
            return _instancia;
        }

        public bool GenerarBackup(string dbName, string connectionString)
        {
            if (oGenerarBackup.GenerarBackup(dbName, connectionString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RecuperarBackup(string directorio, string dbname, string connectionString)
        {
            if (oRecuperarBackup.RecuperarBackup(directorio, dbname, connectionString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class GENERARBACKUP
    {
        public bool GenerarBackup(string dbname, string connectionString)
        {
            DateTime dia = DateTime.Now;
            string id = dia.Day + "-" + dia.Month;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                string str1 = "USE [" + dbname + "];";
                string str2 = "BACKUP DATABASE [" + dbname + "] TO DISK = 'C:\\Users\\nacho\\Desktop\\Sistema_de_Libreria\\Backup_Sistemas\\Negocio-" + id + ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLserverBackups',NAME = 'full backup of " + dbname + "'";
                SqlCommand cmd1 = new SqlCommand(str1, connection);
                SqlCommand cmd2 = new SqlCommand(str2, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }
    }

    class RECUPERARBACKUP
    {

        public bool RecuperarBackup(string directorio, string dbname, string connectionString)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                string str1 = "USE master; ";
                string str2 = "ALTER DATABASE [" + dbname + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str3 = "RESTORE DATABASE [" + dbname + "] FROM DISK = '" + directorio + "' WITH REPLACE ";

                SqlCommand cmd1 = new SqlCommand(str1, connection);
                SqlCommand cmd2 = new SqlCommand(str2, connection);
                SqlCommand cmd3 = new SqlCommand(str3, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }
    }
}
