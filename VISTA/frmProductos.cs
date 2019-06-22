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
    [MODELO.formulario(nombre = "frmProductos", descripcion = "Gestionar Productos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Producto", formulario = "frmProductos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Producto", formulario = "frmProductos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Producto", formulario = "frmProductos", modulo = "Gestiones")]
    [MODELO.accion(control = "btnCAMBIARESTADO", descripcion = "Cambiar Estado Producto", formulario = "frmProductos", modulo = "Gestiones")]
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
    }
}
