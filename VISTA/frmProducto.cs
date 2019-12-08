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
    public partial class frmProducto : Form
    {
        MODELO.PRODUCTO oProducto;
        CONTROLADORA.cPRODUCTOS cProductos;
        string accion;
        public frmProducto(MODELO.PRODUCTO miProducto, string miAccion)
        {
            InitializeComponent();
            FormStyle.defaultWindowStyle(this);

            accion = miAccion;
            oProducto = miProducto;
            cProductos = CONTROLADORA.cPRODUCTOS.obtener_instancia();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(txtDESCRIPCION.Text)) {
                MessageBox.Show("El valor de la descripcion es incorrecto");
                return;
            }

            if (string.IsNullOrEmpty(lblMARCA.Text))
            {
                MessageBox.Show("Debe seleccionar una marca");
                return;
            }
            if (string.IsNullOrEmpty(lblMARCA.Text))
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return;
            }
            decimal precio;
            if (!Decimal.TryParse(txtPRECIO.Text, out precio))
            {
                MessageBox.Show("El valor del precio es incorrecto");
                return;
            }
            int cant_minima;
            if (!int.TryParse(txtCANTMINIMA.Text, out cant_minima))
            {
                MessageBox.Show("El valor de la cantidad minima es incorrecto");
                return;
            }

            int cant_operativa;
            if (!int.TryParse(txtCANTOPERATIVA.Text, out cant_operativa))
            {
                MessageBox.Show("El valor de la cantidad operativa es incorrecto");
                return;
            }
            
            oProducto.descripcion = txtDESCRIPCION.Text;
            oProducto.precio = precio;
            oProducto.cantidadMinima = cant_minima;
            oProducto.cantidadOperativa = cant_operativa;
            oProducto.asignar_estado(true);
            oProducto.estadoActivo = ckbACTIVO.Checked;

            if (accion == "A")
            {
                oProducto.cantidadActual = 0;
                cProductos.agregar_producto(oProducto);
            }
            else {
                cProductos.modificar_producto(oProducto);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnMARCA_Click(object sender, EventArgs e)
        {
            frmMarcas frmMarcas = new frmMarcas(oProducto);
            frmMarcas.ShowDialog();
            if (oProducto.marca != null)
            {
                lblMARCA.Text = oProducto.marca.ToString();
            }
        }

        private void btnCATEGORIA_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias(oProducto);
            frmCategorias.ShowDialog();
            if (oProducto.categoria != null)
            {
                lblCATEGORIA.Text = oProducto.categoria.ToString();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            if (accion == "M")
            {
                completarCampos();
                btnMARCA.Text = "Modificar Marca";
                btnCATEGORIA.Text = "Modificar Categoria";
            }
            if (accion == "C")
            {
                completarCampos();
                deshabilitarCampos();
                btnCANCELAR.Text = "Cerrar";
                btnGUARDAR.Visible = false;
            }
        }

        public void completarCampos() {
            txtDESCRIPCION.Text = oProducto.descripcion;
            lblMARCA.Text = oProducto.marca.ToString();
            lblCATEGORIA.Text = oProducto.categoria.ToString();
            txtPRECIO.Text = oProducto.precio.ToString();
            txtCANTMINIMA.Text = oProducto.cantidadMinima.ToString();
            txtCANTOPERATIVA.Text = oProducto.cantidadOperativa.ToString();
            ckbACTIVO.Checked = oProducto.estadoActivo;
        }

        public void deshabilitarCampos() {
            txtDESCRIPCION.Enabled = false;
            lblMARCA.Enabled = false;
            lblCATEGORIA.Enabled = false;
            txtPRECIO.Enabled = false;
            txtCANTMINIMA.Enabled = false;
            txtCANTOPERATIVA.Enabled = false;
            ckbACTIVO.Enabled = false;
            btnCATEGORIA.Enabled = false;
            btnMARCA.Enabled = false;
        }

        private void lblCATEGORIA_Click(object sender, EventArgs e)
        {

        }
    }
}
