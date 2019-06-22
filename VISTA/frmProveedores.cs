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
    [MODELO.formulario(nombre = "frmProveedores", descripcion = "Gestionar Proveedores", modulo = "Compras")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Proveedor", formulario = "frmProveedores", modulo = "Compras")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Proveedor", formulario = "frmProveedores", modulo = "Compras")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Proveedor", formulario = "frmProveedores", modulo = "Compras")]
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
    }
}
