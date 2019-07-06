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
        CONTROLADORA.cACCIONES cACCIONES;
        CONTROLADORA.cGRUPOS cGRUPOS;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            cACCESOS = CONTROLADORA.cACCESOS.obtener_instancia();
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            cACCIONES = CONTROLADORA.cACCIONES.obtener_instancia();
            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            cACCIONES.verificar_acciones();

            string mensaje = "";
            if (cACCIONES.verificar_grupos() == 0)
            {                
                MODELO.GRUPO oGrupo = new MODELO.GRUPO();
                oGrupo.nombre = "Administrador del Sistema";
                oGrupo.estadoActivo = true;
                cGRUPOS.agregar_grupo(oGrupo);
                mensaje += "Se creo el grupo Administrador del Sistema, ya que no existia.";
            }
            if (cACCIONES.verificar_usuarios() == 0)
            {
                MODELO.USUARIO oUsuario = new MODELO.USUARIO();
                oUsuario.nombreDeUsuario = "Superusuario";
                oUsuario.nombreApellido = "Superusuario Inicial";
                oUsuario.estadoActivo = true;
                oUsuario.clave = CONTROLADORA.FUNCIONES.encriptar_clave("admin");
                oUsuario.conectado = false;
                oUsuario.mail = "superusuario@admin.com";
                oUsuario.grupos.Add(cUSUARIOS.obtener_grupo_admin());
                cUSUARIOS.agregar_usuario(oUsuario);
                mensaje += "\n\nSe agrego un Superusuario con grupo Administrador del Sistema ya que no existia ningun usuario.";
                mensaje += "\nPara ingresar al sistema complete con los siguientes datos.";
                mensaje += "\nNombre de Usuario: Superusuario";
                mensaje += "\nContraseña: admin";
            }
            if (mensaje != "")
            {
                MessageBox.Show(mensaje,"NUEVO USUARIO Y/O GRUPO");
            }           
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
                oAcceso.fechaLogout = System.DateTime.Now;
                oAcceso.usuario = oUsuario;
                cACCESOS.agregar_acceso(oAcceso);


                generarArchivosDeDatosToolStripMenuItem.Enabled = oUsuario.validar_acciones("generarArchivosDeDatosToolStripMenuItem", "frmMenuPrincipal");
                gestionarBackupsToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarBackupsToolStripMenuItem", "frmMenuPrincipal");
                gestionarCategoriasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarCategoriasToolStripMenuItem", "frmMenuPrincipal");
                gestionarClientesToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarClientesToolStripMenuItem", "frmMenuPrincipal");
                gestionarGruposToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarGruposToolStripMenuItem", "frmMenuPrincipal");
                gestionarLocalidadesToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarLocalidadesToolStripMenuItem", "frmMenuPrincipal");
                gestionarMarcasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarMarcasToolStripMenuItem", "frmMenuPrincipal");
                gestionarOrdenesDeCompraToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarOrdenesDeCompraToolStripMenuItem", "frmMenuPrincipal");
                gestionarProductosToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarProductosToolStripMenuItem", "frmMenuPrincipal");
                gestionarProveedoresToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarProveedoresToolStripMenuItem", "frmMenuPrincipal");
                gestionarRemitosDeComprasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarRemitosDeComprasToolStripMenuItem", "frmMenuPrincipal");
                gestionarReportesToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarReportesToolStripMenuItem", "frmMenuPrincipal");
                gestionarUsuariosToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarUsuariosToolStripMenuItem", "frmMenuPrincipal");
                gestionarVentasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarVentasToolStripMenuItem", "frmMenuPrincipal");
                if (gestionarCategoriasToolStripMenuItem.Enabled == false && gestionarLocalidadesToolStripMenuItem.Enabled == false && gestionarMarcasToolStripMenuItem.Enabled == false && gestionarProductosToolStripMenuItem.Enabled == false )
                {
                    gestionesToolStripMenuItem.Enabled = false;
                }
                if (gestionarProveedoresToolStripMenuItem.Enabled == false && gestionarOrdenesDeCompraToolStripMenuItem.Enabled == false)
                {
                    comprasToolStripMenuItem.Enabled = false;
                }
                if (gestionarRemitosDeComprasToolStripMenuItem.Enabled == false)
                {
                    inventarioToolStripMenuItem.Enabled = false;
                }
                if (gestionarClientesToolStripMenuItem.Enabled == false && gestionarVentasToolStripMenuItem.Enabled == false)
                {
                    ventasToolStripMenuItem.Enabled = false;
                }
                if (generarArchivosDeDatosToolStripMenuItem.Enabled == false && gestionarReportesToolStripMenuItem.Enabled == false)
                {
                    gerenciaToolStripMenuItem.Enabled = false;
                }
                if (gestionarBackupsToolStripMenuItem.Enabled == false && gestionarGruposToolStripMenuItem.Enabled == false && gestionarUsuariosToolStripMenuItem.Enabled == false)
                {
                    seguridadToolStripMenuItem.Enabled = false;
                }
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
                //CONTROLADORA.FUNCIONES.generar_backup(); falta arreglar el metodo
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
            foreach (MODELO.GRUPO oGrupo in oUsuario.grupos)
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
