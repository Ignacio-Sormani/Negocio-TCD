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
    [MODELO.formulario(nombre = "frmClientes", descripcion = "Gestionar Clientes", modulo = "Ventas")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Cliente", formulario = "frmClientes", modulo = "Ventas")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Cliente", formulario = "frmClientes", modulo = "Ventas")]
    [MODELO.accion(control = "btnMODIFICAR", descripcion = "Modificar Cliente", formulario = "frmClientes", modulo = "Ventas")]
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
    }
}
