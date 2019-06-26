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
        public string ACCION;
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
                    foreach (MODELO.GRUPO miGrupo in oUsuario.grupos)
                    {
                        if (miGrupo.codigoGrupo == oGrupo.codigoGrupo)
                        {
                            clbGRUPOS.SetItemChecked(i, true);
                        }
                    }
                }
                bGrupo = true;
            }

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

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMARCA.Text))
            {
                MessageBox.Show("Debe ingresar un valor de marca correcto", "Marca - Atencion!");
                return;
            }

            if (!cMARCAS.verificar_marca_existente(txtMARCA.Text)) //verificar este doble if
            {
                if (!(ACCION == "M" && oMarca.marca == txtMARCA.Text))
                {
                    MessageBox.Show("La marca ingresada ya existe", "Marca - Atencion!");
                    return;
                }
            }

            oMarca.marca = txtMARCA.Text;
            if (ACCION == "A")
            {
                cMARCAS.agregar_marca(oMarca);
            }
            else
            {
                cMARCAS.modificar_marca(oMarca);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
