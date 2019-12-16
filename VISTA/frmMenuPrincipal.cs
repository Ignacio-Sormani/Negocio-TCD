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
            FormStyle.defaultWindowStyle(this);
            InitializeComponent();

            cACCESOS = CONTROLADORA.cACCESOS.obtener_instancia();
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            cACCIONES = CONTROLADORA.cACCIONES.obtener_instancia();
            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            cACCIONES.verificar_acciones();
            cGRUPOS.obtener_grupos("");

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
                oUsuario.nombreDeUsuario = "admin";
                oUsuario.nombreApellido = "Administrador Inicial";
                oUsuario.estadoActivo = true;
                oUsuario.clave = CONTROLADORA.FUNCIONES.encriptar_clave("admin");
                oUsuario.conectado = false;
                oUsuario.mail = "admin@admin.com";
                oUsuario.grupos.Add(cUSUARIOS.obtener_grupo_admin());
                cUSUARIOS.agregar_usuario(oUsuario);
                mensaje += "\n\nSe agrego un Admin con grupo Administrador del Sistema ya que no existia ningun usuario.";
                mensaje += "\nPara ingresar al sistema complete con los siguientes datos.";
                mensaje += "\nNombre de Usuario: admin";
                mensaje += "\nContraseña: admin";
            }
            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "NUEVO USUARIO Y/O GRUPO");
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            this.Hide();
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

                generarArchivosDeDatosToolStripMenuItem.Enabled = oUsuario.validar_acciones("generarArchivosDeDatosToolStripMenuItem", "frmArchivoDeDatos");
                gestionarBackupsToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarBackupsToolStripMenuItem", "frmBackup");
                gestionarCategoriasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarCategoriasToolStripMenuItem", "frmCategorias");
                gestionarClientesToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarClientesToolStripMenuItem", "frmClientes");
                gestionarGruposToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarGruposToolStripMenuItem", "frmGrupos");
                gestionarLocalidadesToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarLocalidadesToolStripMenuItem", "frmLocalidades");
                gestionarMarcasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarMarcasToolStripMenuItem", "frmMarcas");
                gestionarOrdenesDeComprasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarOrdenesDeComprasToolStripMenuItem", "frmOrdenesDeCompra");
                gestionarProductosToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarProductosToolStripMenuItem", "frmProductos");
                gestionarProveedoresToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarProveedoresToolStripMenuItem", "frmProveedores");
                gestionarRemitosDeComprasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarRemitosDeComprasToolStripMenuItem", "frmRemitos");
                gestionarReportesToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarReportesToolStripMenuItem", "frmReporte");
                gestionarUsuariosToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarUsuariosToolStripMenuItem", "frmUsuarios");
                gestionarVentasToolStripMenuItem.Enabled = oUsuario.validar_acciones("gestionarVentasToolStripMenuItem", "frmVentas");
                verLoginsToolStripMenuItem.Enabled = oUsuario.validar_acciones("verLoginsToolStripMenuItem", "frmAuditoriaLogin");
                if (gestionarCategoriasToolStripMenuItem.Enabled == false && gestionarLocalidadesToolStripMenuItem.Enabled == false && gestionarMarcasToolStripMenuItem.Enabled == false && gestionarProductosToolStripMenuItem.Enabled == false)
                {
                    gestionesToolStripMenuItem.Enabled = false;
                }
                else
                {
                    gestionesToolStripMenuItem.Enabled = true;
                }
                if (gestionarProveedoresToolStripMenuItem.Enabled == false && gestionarOrdenesDeComprasToolStripMenuItem.Enabled == false)
                {
                    comprasToolStripMenuItem.Enabled = false;
                }
                else
                {
                    comprasToolStripMenuItem.Enabled = true;
                }
                if (gestionarRemitosDeComprasToolStripMenuItem.Enabled == false)
                {
                    inventarioToolStripMenuItem.Enabled = false;
                }
                else
                {
                    inventarioToolStripMenuItem.Enabled = true;
                }
                if (gestionarClientesToolStripMenuItem.Enabled == false && gestionarVentasToolStripMenuItem.Enabled == false)
                {
                    ventasToolStripMenuItem.Enabled = false;
                }
                else
                {
                    ventasToolStripMenuItem.Enabled = true;
                }
                //if (generarArchivosDeDatosToolStripMenuItem.Enabled == false && gestionarReportesToolStripMenuItem.Enabled == false)
                //{
                gerenciaToolStripMenuItem.Enabled = true;
                //}
                //else
                //{
                //    gerenciaToolStripMenuItem.Enabled = true;
                //}
                if (gestionarBackupsToolStripMenuItem.Enabled == false && gestionarGruposToolStripMenuItem.Enabled == false &&
                    gestionarUsuariosToolStripMenuItem.Enabled == false && verLoginsToolStripMenuItem.Enabled == false)
                {
                    seguridadToolStripMenuItem.Enabled = false;
                }
                else
                {
                    seguridadToolStripMenuItem.Enabled = true;
                }
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnMIPERFIL_Click(object sender, EventArgs e)
        {
            frmMiPerfil formMiPerfil = new frmMiPerfil(oUsuario);
            DialogResult dr = formMiPerfil.ShowDialog();
            if (dr == DialogResult.OK)
            {
                cargar_usuario();
            }
        }

        private void btnCAMBIARCLAVE_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña formCambiarContraseña = new frmCambiarContraseña(oUsuario);
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
                string dbname = "DATOS.Negocio";
                string connectionString = @"Data Source=DESKTOP-PUG5ECE; Initial Catalog=" + dbname + "; Integrated Security=true; MultipleActiveResultSets=True;";
                CONTROLADORA.FACADEBACKUP oFacadeBackup = CONTROLADORA.FACADEBACKUP.obtener_instancia();
                try
                {
                    oFacadeBackup.GenerarBackup(dbname, connectionString);
                }
                catch
                {
                    MessageBox.Show("Hubo un problema al intentar generar un backup de la sesion.");
                }
            }
            oAcceso.fechaLogout = System.DateTime.Now;
            cACCESOS.modificar_acceso(oAcceso);
            oUsuario.conectado = false;
            cUSUARIOS.modificar_usuario(oUsuario);
            this.Hide();
            armar_login();
        }

        public void cargar_usuario()
        {
            lblUSUARIO.Text = oUsuario.nombreDeUsuario;
            lblNOMBREAPELLIDO.Text = oUsuario.nombreApellido;
            lblMAIL.Text = oUsuario.mail;
            lblGRUPOS.Text = "";
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
            frmProductos frmProductos = new frmProductos(oUsuario);
            frmProductos.ShowDialog();
        }

        private void gestionarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas frmMarcas = new frmMarcas(oUsuario);
            frmMarcas.ShowDialog();
        }

        private void gestionarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias(oUsuario);
            frmCategorias.ShowDialog();
        }

        private void gestionarLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades frmLocalidades = new frmLocalidades(oUsuario);
            frmLocalidades.ShowDialog();
        }

        private void gestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores(oUsuario);
            frmProveedores.ShowDialog();
        }

        private void gestionarOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenesDeCompra frmOrdenesDeCompra = new frmOrdenesDeCompra(oUsuario);
            frmOrdenesDeCompra.ShowDialog();
        }

        private void gestionarRemitosDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemitos frmRemitos = new frmRemitos(oUsuario);
            frmRemitos.ShowDialog();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes(oUsuario);
            frmClientes.ShowDialog();
        }

        private void gestionarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas(oUsuario);
            frmVentas.ShowDialog();
        }

        private void gestionarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte frmReporte = new frmReporte(oUsuario);
            frmReporte.ShowDialog();
        }

        private void generarArchivosDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivoDeDatos frmArchivoDeDatos = new frmArchivoDeDatos(oUsuario);
            frmArchivoDeDatos.ShowDialog();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios(oUsuario);
            frmUsuarios.ShowDialog();
        }

        private void gestionarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupos frmGrupos = new frmGrupos(oUsuario);
            frmGrupos.ShowDialog();
        }

        private void gestionarBackupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frmBackup = new frmBackup(oUsuario);
            frmBackup.ShowDialog();
        }

        private void loginsDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoriaLogin frmAuditoriaLogins = new frmAuditoriaLogin();
            frmAuditoriaLogins.ShowDialog();
        }
    }
}
