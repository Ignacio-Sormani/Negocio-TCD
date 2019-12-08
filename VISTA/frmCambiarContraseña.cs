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
    public partial class frmCambiarContraseña : Form
    {
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        MODELO.USUARIO oUsuario;
        public frmCambiarContraseña(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            FormStyle.windowStyle(this);

            oUsuario = miUsuario;
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
        }

        private void btnVOLVER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCAMBIARCONTRASEÑA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCONTRAVIEJA.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña antigua");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCONTRANUEVA1.Text))
            {
                MessageBox.Show("Debe ingresar una nueva contraseña");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCONTRANUEVA2.Text))
            {
                MessageBox.Show("Debe ingresar la nueva contraseña");
                return;
            }

            if (oUsuario.clave != CONTROLADORA.FUNCIONES.encriptar_clave(txtCONTRAVIEJA.Text))
            {
                MessageBox.Show("La contraseña antigua no es correcta");
                return;
            }

            if (txtCONTRANUEVA1.Text != txtCONTRANUEVA2.Text)
            {
                MessageBox.Show("Las nuevas contraseñas no coinciden");
                return;
            }

            oUsuario.clave = CONTROLADORA.FUNCIONES.encriptar_clave(txtCONTRANUEVA1.Text);
            cUSUARIOS.modificar_usuario(oUsuario);
            this.Close();
        }
    }
}
