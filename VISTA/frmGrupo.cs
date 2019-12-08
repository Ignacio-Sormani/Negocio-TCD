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
    public partial class frmGrupo : Form
    {
        MODELO.GRUPO oGrupo;
        string ACCION;
        CONTROLADORA.cGRUPOS cGRUPOS;
        public frmGrupo(MODELO.GRUPO miGrupo, string miAccion)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            oGrupo = miGrupo;
            ACCION = miAccion;
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            ckbACTIVO.Checked = true;
            clbUSUARIOS.DataSource = null;
            clbUSUARIOS.DataSource = cGRUPOS.obtener_usuarios();

            List<MODELO.ACCION> acciones = cGRUPOS.obtener_acciones();            
            var formularios = (from accion in acciones
                               select new { NombreForm = accion.nombreFormulario })
                              .Distinct();
            foreach (var formulario in formularios)
            {
                TreeNode tnG = new TreeNode();
                var accionesForm = from accion in acciones
                                   where accion.nombreFormulario.Contains(formulario.NombreForm)
                                   select accion;
                foreach (var accionForm in accionesForm)
                {
                    if (accionForm.descripcionAccion.Contains("Gestionar"))
                    {
                        tnG.Text = accionForm.descripcionAccion;
                        if (oGrupo.acciones.Count(acc => (acc.descripcionAccion == tnG.Text)) > 0)
                            tnG.Checked = true;
                        else
                            tnG.Checked = false;
                    }
                    else
                    {
                        TreeNode tnA = new TreeNode();
                        tnA.Text = accionForm.descripcionAccion;
                        tnG.Nodes.Add(tnA);
                        if (oGrupo.acciones.Count(acc => (acc.descripcionAccion == tnA.Text)) > 0)
                            tnA.Checked = true;
                        else
                            tnA.Checked = false;
                    }
                }
                tvACCIONES.Nodes.Add(tnG);
            }

            if (ACCION != "A")
            {
                txtGRUPO.Text = oGrupo.nombre;
                ckbACTIVO.Checked = oGrupo.estadoActivo;
                for (int i = 0; i < clbUSUARIOS.Items.Count; i++)
                {
                    MODELO.USUARIO oUsuario = (MODELO.USUARIO)clbUSUARIOS.Items[i];
                    if (oGrupo.usuarios.Contains(oUsuario))
                    {
                        clbUSUARIOS.SetItemChecked(i, true);
                    }
                }
            }

            if (ACCION == "C" || oGrupo.nombre == "Administrador del Sistema")
            {
                txtGRUPO.Enabled = false;
                ckbACTIVO.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
                clbUSUARIOS.Enabled = false;
                tvACCIONES.Enabled = false;
            }
        }

        private void clbUSUARIOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MODELO.USUARIO oUsuario = (MODELO.USUARIO)clbUSUARIOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGrupo.usuarios.Add(oUsuario);
            }
            else
            {
                oGrupo.usuarios.Remove(oUsuario);
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGRUPO.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de grupo correcto");
                return;
            }
            if (!cGRUPOS.verificar_grupo_existente(txtGRUPO.Text)) //verificar este doble if
            {
                if (!(ACCION == "M" && oGrupo.nombre == txtGRUPO.Text))
                {
                    MessageBox.Show("El grupo ingresado ya existe");
                    return;
                }
            }
            oGrupo.nombre = txtGRUPO.Text;
            oGrupo.estadoActivo = ckbACTIVO.Checked;
            if (ACCION == "A")
            {
                cGRUPOS.agregar_grupo(oGrupo);
            }
            else
            {
                cGRUPOS.modificar_grupo(oGrupo);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tvACCIONES_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode seleccion = e.Node;
            MODELO.ACCION oAccion= cGRUPOS.obtener_accion(seleccion.Text);
            if (seleccion.Checked)
            {
                oGrupo.acciones.Add(oAccion);
            }
            else
            {
                oGrupo.acciones.Remove(oAccion);
            }
        }
    }
}
