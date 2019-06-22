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
    [MODELO.formulario(nombre = "frmOrdenesDeCompra", descripcion = "Gestionar Ordenes de Compra", modulo = "Compras")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Orden de Compra", formulario = "frmOrdenesDeCompra", modulo = "Compras")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Orden de Compra", formulario = "frmOrdenesDeCompra", modulo = "Compras")]
    [MODELO.accion(control = "btnDARDEBAJA", descripcion = "Dar de Baja Orden de Compra", formulario = "frmOrdenesDeCompra", modulo = "Compras")]
    public partial class frmOrdenesDeCompra : Form
    {
        public frmOrdenesDeCompra()
        {
            InitializeComponent();
        }
    }
}
