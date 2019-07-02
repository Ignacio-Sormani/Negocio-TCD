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
            accion = miAccion;
            oProducto = miProducto;
            cProductos = CONTROLADORA.cPRODUCTOS.obtener_instancia();
        }
        

        

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            decimal costo;
            if (!Decimal.TryParse(txtCOSTO.Text, out costo)) {
                MessageBox.Show("El valor del costo es incorrecto");
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
            //marcas y categorias guardados desde los botones
            oProducto.costo = costo;
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
        }

        private void btnCATEGORIA_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias(oProducto);
            frmCategorias.ShowDialog();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
