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
    public partial class frmResetearContraseña : Form
    {
        string nuevaClave;
        string nuevaClaveEncriptada;
        MODELO.USUARIO oUsuario;
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        public frmResetearContraseña()
        {
            InitializeComponent();

            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
        }

        private void btnRESETEARCLAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMAIL.Text) || CONTROLADORA.FUNCIONES.validar_mail(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail valido");
                return;
            }
            oUsuario = cUSUARIOS.obtener_usuario_mail(txtMAIL.Text);
            if (oUsuario == null)
            {
                MessageBox.Show("El mail ingresado no pertenece a un usuario");
                return;
            }
            if (oUsuario.estadoActivo == false)
            {
                MessageBox.Show("El usuario del mail ingresado esta dado de baja temporal o permanentemente");
                return;
            }
            nuevaClave = CONTROLADORA.FUNCIONES.generar_clave_aleatoria();
            nuevaClaveEncriptada = CONTROLADORA.FUNCIONES.encriptar_clave(nuevaClave);
            oUsuario.clave = nuevaClaveEncriptada;
            cUSUARIOS.modificar_usuario(oUsuario);
            if (CONTROLADORA.FUNCIONES.enviar_mail("Nueva Clave", "Su nueva clave en el sistema es: " + nuevaClave, oUsuario.mail))
            {
                MessageBox.Show("Se ha enviado su nueva clave a la direccion de mail ingresada");
            }
            else
            {
                MessageBox.Show("No se ha podido enviar la nueva clave a la direccion de mail ingresada");
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
