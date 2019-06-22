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
    [MODELO.formulario(nombre = "frmRemitos", descripcion = "Gestionar Remitos", modulo = "Inventario")]
    [MODELO.accion(control = "btnAGREGAR", descripcion = "Agregar Remito", formulario = "frmRemitos", modulo = "Inventario")]
    [MODELO.accion(control = "btnCONSULTAR", descripcion = "Consultar Remito", formulario = "frmRemitos", modulo = "Inventario")]
    public partial class frmRemitos : Form
    {
        public frmRemitos()
        {
            InitializeComponent();
        }
    }
}
