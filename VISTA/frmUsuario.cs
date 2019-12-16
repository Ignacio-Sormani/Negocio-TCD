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
    public partial class frmUsuario : Form
    {
        MODELO.USUARIO oUsuario;
        string ACCION;
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        bool bGrupo;
        string nuevaClave;
        string nuevaClaveEncriptada;
        public frmUsuario(MODELO.USUARIO miUsuario, string miAccion)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            oUsuario = miUsuario;
            ACCION = miAccion;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            ckbACTIVO.Checked = true;
            clbGRUPOS.DataSource = null;
            clbGRUPOS.DataSource = cUSUARIOS.obtener_grupos();

            if (ACCION != "A")
            {
                txtUSUARIO.Text = oUsuario.nombreDeUsuario;
                txtNOMBRE.Text = oUsuario.nombreApellido;
                txtMAIL.Text = oUsuario.mail;
                ckbACTIVO.Checked = oUsuario.estadoActivo;
                bGrupo = false;
                for (int i = 0; i < clbGRUPOS.Items.Count; i++)
                {
                    MODELO.GRUPO oGrupo = (MODELO.GRUPO)clbGRUPOS.Items[i];
                    foreach (MODELO.GRUPO miGrupo in oUsuario.grupos.ToList())
                    {
                        if (miGrupo.codigoGrupo == oGrupo.codigoGrupo)
                        {
                            clbGRUPOS.SetItemChecked(i, true);
                        }
                    }
                }
            }
            bGrupo = true;

            if (ACCION == "C")
            {
                txtUSUARIO.Enabled = false;
                txtNOMBRE.Enabled = false;
                txtMAIL.Enabled = false;
                ckbACTIVO.Enabled = false;
                clbGRUPOS.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario correcto");
                return;
            }
            if (!cUSUARIOS.verificar_usuario_existente(txtUSUARIO.Text))
            {
                if (!(ACCION == "M" && oUsuario.nombreDeUsuario == txtUSUARIO.Text))
                {
                    MessageBox.Show("El usuario ingresado ya existe");
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre y apellido correcto");
                return;
            }
            if (string.IsNullOrEmpty(txtMAIL.Text) || !CONTROLADORA.FUNCIONES.validar_mail(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail correcto");
                return;
            }
            oUsuario.nombreDeUsuario = txtUSUARIO.Text;
            oUsuario.nombreApellido = txtNOMBRE.Text;
            oUsuario.mail = txtMAIL.Text;
            oUsuario.conectado = false;
            oUsuario.estadoActivo = ckbACTIVO.Checked;
            if (ACCION == "A")
            {
                //nuevaClave = CONTROLADORA.FUNCIONES.generar_clave_aleatoria();
                nuevaClaveEncriptada = CONTROLADORA.FUNCIONES.encriptar_clave("nacho3");
                oUsuario.clave = nuevaClaveEncriptada;
                //string message = "Su nuevo usuario en el sistema es: " + oUsuario.nombreDeUsuario + " y su clave es: " + nuevaClave + ". Le recomendamos modificar su contraseña cuando acceda al sistema.";
                //if (CONTROLADORA.FUNCIONES.enviar_mail("Nuevo usuario", message, oUsuario.mail))
                //{
                //    MessageBox.Show("Se ha enviado su nueva clave a la direccion de mail ingresada");
                //}
                //else
                //{
                //    MessageBox.Show("No se ha podido enviar la nueva clave a la direccion de mail ingresada");
                //    return;
                //}
                cUSUARIOS.agregar_usuario(oUsuario);
            }
            else
            {
                cUSUARIOS.modificar_usuario(oUsuario);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void clbGRUPOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (bGrupo == false)
                return;
            MODELO.GRUPO oGrupo = (MODELO.GRUPO)clbGRUPOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oUsuario.grupos.Add(oGrupo);
            }
            else
            {
                oUsuario.grupos.Remove(oGrupo);
            }
        }
    }
}
