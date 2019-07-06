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
        public frmUsuario(MODELO.USUARIO miUsuario, string miAccion)
        {
            InitializeComponent();

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
                txtCLAVE.Visible = false;
                lblCLAVE.Visible = false;
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
                MessageBox.Show("Debe ingresar un nombre y apellido correcto", "Usuario - Atencion!");
                return;
            }
            if (string.IsNullOrEmpty(txtMAIL.Text) || !CONTROLADORA.FUNCIONES.validar_mail(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail correcto");
                return;
            }
            if (ACCION == "A" && (string.IsNullOrEmpty(txtCLAVE.Text) || txtCLAVE.TextLength < 6 || txtCLAVE.TextLength > 10))
            {
                MessageBox.Show("Debe ingresar una contraseña de entre 6 y 10 caracteres");
                return;
            }
            oUsuario.nombreDeUsuario = txtUSUARIO.Text;
            oUsuario.nombreApellido = txtNOMBRE.Text;
            oUsuario.mail = txtMAIL.Text;            
            oUsuario.conectado = false;
            oUsuario.estadoActivo = ckbACTIVO.Checked;
            if (ACCION == "A")
            {
                oUsuario.clave = CONTROLADORA.FUNCIONES.encriptar_clave(txtCLAVE.Text);
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
            if (bGrupo == false) return;

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
