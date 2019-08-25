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
        bool bUsuario;
        bool bAccion;
        public frmGrupo(MODELO.GRUPO miGrupo, string miAccion)
        {
            InitializeComponent();

            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            oGrupo = miGrupo;
            ACCION = miAccion;
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            ckbACTIVO.Checked = true;
            clbUSUARIOS.DataSource = null;
            clbUSUARIOS.DataSource = cGRUPOS.obtener_usuarios();

            bAccion = false;

            List<MODELO.ACCION> acciones = cGRUPOS.obtener_acciones();
            //faltar armar el treeview

            /*
            List<MODELO.formulario> forms = cGRUPOS.obtener_acciones();
            var modulos = (from formulario in forms
                           select new { DESCRIPCION = formulario.modulo })
                          .Distinct();
            foreach (var oModulo in modulos)
            {
                var formularios = from formulario in forms
                                  where formulario.modulo == oModulo.DESCRIPCION
                                  select formulario;
                foreach (MODELO.formulario oForm in formularios)
                {
                    if (oForm.acciones.Count() > 0)
                    {
                        TreeNode tnf = new TreeNode();
                        tnf.Text = oForm.descripcion;
                        tnf.Tag = null;
                        foreach (MODELO.accion oAccion in oForm.acciones)
                        {
                            TreeNode tnA = new TreeNode();
                            tnA.Text = oAccion.descripcion;
                            tnA.Tag = oAccion;
                            if (oGrupo.acciones.Count(acc => (acc.modulo == oAccion.modulo) && (acc.descripcionFormulario == oAccion.descripcion) && (acc.control == oAccion.control)) > 0)
                                tnA.Checked = true;
                            else
                                tnA.Checked = false;

                            tnf.Nodes.Add(tnA);
                            HasCheckedChildNodes(tnf);
                        }
                        tvACCIONES.Nodes.Add(tnf);
                    }
                }
            }*/
            bAccion = true;
            
            if (ACCION != "A")
            {
                txtGRUPO.Text = oGrupo.nombre;
                ckbACTIVO.Checked = oGrupo.estadoActivo;
                bUsuario = false;
                for (int i = 0; i < clbUSUARIOS.Items.Count; i++)
                {
                    MODELO.USUARIO oUsuario = (MODELO.USUARIO)clbUSUARIOS.Items[i];
                    if (oGrupo.usuarios.Contains(oUsuario))
                    {
                        clbUSUARIOS.SetItemChecked(i, true);
                    }
                }
                bUsuario = true;
            }

            if (ACCION == "C")
            {
                txtGRUPO.Enabled = false;
                ckbACTIVO.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        private void clbUSUARIOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (bUsuario == false) return;

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
            if (bAccion == false) return;

            TreeNode seleccion = e.Node;

            if (seleccion.Nodes.Count > 0)
            {
                checkChildNodes(seleccion, seleccion.Checked);
            }
            else
            {
                if (seleccion.Tag != null)
                {
                    MODELO.ACCION miACCION;
                    if (seleccion.Checked)
                    {
                        miACCION = ((MODELO.ACCION)seleccion.Tag);
                        oGrupo.acciones.Add(miACCION);
                    }
                    else
                    {
                        miACCION = oGrupo.acciones.FirstOrDefault(acc => (acc.control == ((MODELO.accion)seleccion.Tag).control) && (acc.nombreFormulario == ((MODELO.accion)seleccion.Tag).formulario));
                        oGrupo.acciones.Remove(miACCION);
                    }
                }
            }
            bAccion = false;
            if (seleccion.Parent != null)
            {
                HasCheckedChildNodes(seleccion.Parent);
            }
            bAccion = true;
        }

        private void checkChildNodes(TreeNode node, bool nodeChecked)
        {
            bAccion = false;
            foreach (TreeNode tnS in node.Nodes)
            {
                if (tnS.Nodes.Count > 0)
                {
                    tnS.Checked = nodeChecked;
                    checkChildNodes(tnS, nodeChecked);
                }
                else
                {
                    if (tnS.Tag != null)
                    {
                        MODELO.ACCION miACCION;
                        tnS.Checked = nodeChecked;
                        if (tnS.Checked)
                        {
                            miACCION = ((MODELO.ACCION)tnS.Tag);
                            oGrupo.acciones.Add(miACCION);
                        }
                        else
                        {
                            miACCION = oGrupo.acciones.FirstOrDefault(acc => (acc.control == ((MODELO.accion)tnS.Tag).control) && (acc.nombreFormulario == ((MODELO.accion)tnS.Tag).formulario));
                            oGrupo.acciones.Remove(miACCION);
                        }
                    }
                }
            }
            bAccion = true;
        }

        private void HasCheckedChildNodes(TreeNode node)
        {
            bAccion = false;
            bool marca = true;
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (!childNode.Checked)
                        marca = false;
                }
                node.Checked = marca;
                if (node.Parent != null)
                    HasCheckedChildNodes(node.Parent);
            }
            bAccion = true;
        }
    }
}
