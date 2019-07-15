using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    [MODELO.formulario(nombre = "frmBackup", gestion = "gestionarBackups", descripcion = "Gestionar Backup", modulo = "Seguridad")]
    [MODELO.accion(control = "btnGENERARBACKUP", descripcion = "Generar Backup", formulario = "frmBackup", modulo = "Seguridad")]
    [MODELO.accion(control = "btnRECUPERARBACKUP", descripcion = "Recuperar Backup", formulario = "frmBackup", modulo = "Seguridad")]

    public partial class frmBackup : Form
    {        
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnGENERARBACKUP_Click(object sender, EventArgs e)
        {
            CONTROLADORA.FUNCIONES.generar_backup();
        }

        private void btnRECUPERARBACKUP_Click(object sender, EventArgs e)
        {/*
            OpenFileRestaurarCopia.InitialDirectory = @"C";
            OpenFileRestaurarCopia.Title = "Busque la copia de seguridad";
            OpenFileRestaurarCopia.CheckFileExists = true;
            OpenFileRestaurarCopia.CheckPathExists = true;
            OpenFileRestaurarCopia.DefaultExt = "BAK";
            OpenFileRestaurarCopia.Filter = "Text files (*.bak)|*.bak";
            OpenFileRestaurarCopia.FilterIndex = 2;
            OpenFileRestaurarCopia.RestoreDirectory = true;
            OpenFileRestaurarCopia.ReadOnlyChecked = true;
            OpenFileRestaurarCopia.ShowReadOnly = true;

            DialogResult resultado = OpenFileRestaurarCopia.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                DialogResult confirmacion = MessageBox.Show("¿Seguro deseas restaurar la Base de Datos con esta Copia de Seguridad? \n\nIMPORTANTE: Se recomienda realizar una Copia de Seguridad antes de proceder con la Restauración.",
                    "Restaurar Copia de Seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    String nombreArchivo = OpenFileRestaurarCopia.FileName;
                    try
                    {
                        String mensaje = cBACKUP.RESTAURAR_COPIA(nombreArchivo);  //cFachadBackup.MetodoRestaurarCopia(nombreArchivo);
                        if (mensaje == "Y")
                        {
                            MessageBox.Show("La Base de Datos se ha restaurado satisfactoriamente", "Restaurar Copia de Seguridad",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La copia de seguridad a sido restaurada con exito", "ATENCION",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Restaurar Copia de Seguridad",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }*/

        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
