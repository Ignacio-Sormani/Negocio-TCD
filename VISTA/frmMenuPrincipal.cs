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
    public partial class frmMenuPrincipal : Form
    {
        MODELO.USUARIO oUsuario;
        MODELO.ACCESO oAcceso;
        CONTROLADORA.cACCESOS cACCESOS;
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            cACCESOS = CONTROLADORA.cACCESOS.obtener_instancia();
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            //cACCESOS.VERIFICA_PERMISOS_ADMINISTRADOR();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            armar_login();
            this.Show();
        }

        public void armar_login()
        {
            frmLogin formLogin = new frmLogin();
            DialogResult dr = formLogin.ShowDialog();
            if (dr == DialogResult.OK)
            {
                oUsuario = formLogin.oUsuario;
                cargar_usuario();
                oUsuario.conectado = true;
                cUSUARIOS.modificar_usuario(oUsuario);
                oAcceso = new MODELO.ACCESO();
                oAcceso.fechaLogin = System.DateTime.Now;
                oAcceso.usuario = oUsuario;
                cACCESOS.agregar_acceso(oAcceso);

                //habilitar los botones del menu obteniendo las acciones
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnMIPERFIL_Click(object sender, EventArgs e)
        {
            frmMiPerfil formMiPerfil = new frmMiPerfil();
            DialogResult dr = formMiPerfil.ShowDialog();
            if (dr == DialogResult.OK)
            {
                cargar_usuario();
            }
        }

        private void btnCAMBIARCLAVE_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña formCambiarContraseña = new frmCambiarContraseña();
            DialogResult dr = formCambiarContraseña.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Se ha cambiado la contraseña");
            }
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            if (cUSUARIOS.cantidad_usuarios_conectados() == 1)
            {
                CONTROLADORA.FUNCIONES.generar_backup();
            }
            oAcceso.fechaLogout = System.DateTime.Now;
            cACCESOS.modificar_acceso(oAcceso);
            oUsuario.conectado = false;
            cUSUARIOS.modificar_usuario(oUsuario);
            armar_login();
        }

        public void cargar_usuario()
        {
            lblUSUARIO.Text = "Nombre de Usuario: " + oUsuario.nombreDeUsuario;
            lblNOMBREAPELLIDO.Text = "Nombre y Apellido: " + oUsuario.nombreApellido;
            lblMAIL.Text = "Mail: " + oUsuario.mail;
            lblGRUPOS.Text = "Grupos: \n";
            foreach (MODELO.GRUPO oGrupo in oUsuario.grupos) // ver si funciona ousuario.grupos o hay que hacer un metodo en controladora
            {
                if (oGrupo.estadoActivo)
                {
                    lblGRUPOS.Text += oGrupo.nombre + "\n";
                }
            }
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
        }

        private void gestionarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frmMarcas = new frmMarcas();
            frmMarcas.ShowDialog();
        }

        private void gestionarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            frmCategorias.ShowDialog();
        }

        private void gestionarLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidades = new frmLocalidades();
            frmLocalidades.ShowDialog();
        }

        private void gestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }

        private void gestionarOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenesDeCompra frmOrdenesDeCompra = new frmOrdenesDeCompra();
            frmOrdenesDeCompra.ShowDialog();
        }

        private void gestionarRemitosDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemitos frmRemitos = new frmRemitos();
            frmRemitos.ShowDialog();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void gestionarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }

        private void gestionarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte frmReporte = new frmReporte();
            frmReporte.ShowDialog();
        }

        private void generarArchivosDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivoDeDatos frmArchivoDeDatos = new frmArchivoDeDatos();
            frmArchivoDeDatos.ShowDialog();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void gestionarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupos frmGrupos = new frmGrupos();
            frmGrupos.ShowDialog();
        }

        private void gestionarBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frmBackup = new frmBackup();
            frmBackup.ShowDialog();
        }

        
    }
}
