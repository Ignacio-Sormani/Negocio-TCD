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
    [MODELO.formulario(nombre = "frmArchivoDeDatos", gestion = "generarArchivosDeDatos", descripcion = "Gestionar Nuevos Archivos", modulo = "Gerencia")]
    [MODELO.accion(control = "btnGENERARARCHIVO", descripcion = "Generar Archivo de Datos", formulario = "frmArchivoDeDatos", modulo = "Gerencia")]
    public partial class frmArchivoDeDatos : Form
    {
        public frmArchivoDeDatos()
        {
            InitializeComponent();
        }
    }
}
