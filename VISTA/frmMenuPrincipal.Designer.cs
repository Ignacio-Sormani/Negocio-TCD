namespace VISTA
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarOrdenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarRemitosDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarArchivosDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarBackupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panDATOSUSUARIO = new System.Windows.Forms.Panel();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.lblNOMBREAPELLIDO = new System.Windows.Forms.Label();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.lblGRUPOS = new System.Windows.Forms.Label();
            this.btnMIPERFIL = new System.Windows.Forms.Button();
            this.btnCAMBIARCLAVE = new System.Windows.Forms.Button();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.lblDATOSUSUARIO = new System.Windows.Forms.Label();
            this.gestionarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panDATOSUSUARIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionesToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.gerenciaToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionesToolStripMenuItem
            // 
            this.gestionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProductosToolStripMenuItem,
            this.gestionarMarcasToolStripMenuItem,
            this.gestionarCategoriasToolStripMenuItem,
            this.gestionarLocalidadesToolStripMenuItem});
            this.gestionesToolStripMenuItem.Name = "gestionesToolStripMenuItem";
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gestionesToolStripMenuItem.Text = "Gestiones";
            // 
            // gestionarMarcasToolStripMenuItem
            // 
            this.gestionarMarcasToolStripMenuItem.Name = "gestionarMarcasToolStripMenuItem";
            this.gestionarMarcasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarMarcasToolStripMenuItem.Text = "Gestionar Marcas";
            this.gestionarMarcasToolStripMenuItem.Click += new System.EventHandler(this.gestionarMarcasToolStripMenuItem_Click);
            // 
            // gestionarCategoriasToolStripMenuItem
            // 
            this.gestionarCategoriasToolStripMenuItem.Name = "gestionarCategoriasToolStripMenuItem";
            this.gestionarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarCategoriasToolStripMenuItem.Text = "Gestionar Categorias";
            this.gestionarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionarCategoriasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProveedoresToolStripMenuItem,
            this.gestionarOrdenesDeCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // gestionarProveedoresToolStripMenuItem
            // 
            this.gestionarProveedoresToolStripMenuItem.Name = "gestionarProveedoresToolStripMenuItem";
            this.gestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gestionarProveedoresToolStripMenuItem.Text = "Gestionar Proveedores";
            this.gestionarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestionarProveedoresToolStripMenuItem_Click);
            // 
            // gestionarOrdenesDeCompraToolStripMenuItem
            // 
            this.gestionarOrdenesDeCompraToolStripMenuItem.Name = "gestionarOrdenesDeCompraToolStripMenuItem";
            this.gestionarOrdenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gestionarOrdenesDeCompraToolStripMenuItem.Text = "Gestionar Ordenes de Compra";
            this.gestionarOrdenesDeCompraToolStripMenuItem.Click += new System.EventHandler(this.gestionarOrdenesDeCompraToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarRemitosDeComprasToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // gestionarRemitosDeComprasToolStripMenuItem
            // 
            this.gestionarRemitosDeComprasToolStripMenuItem.Name = "gestionarRemitosDeComprasToolStripMenuItem";
            this.gestionarRemitosDeComprasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.gestionarRemitosDeComprasToolStripMenuItem.Text = "Gestionar Remitos de Compras";
            this.gestionarRemitosDeComprasToolStripMenuItem.Click += new System.EventHandler(this.gestionarRemitosDeComprasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClientesToolStripMenuItem,
            this.gestionarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // gestionarVentasToolStripMenuItem
            // 
            this.gestionarVentasToolStripMenuItem.Name = "gestionarVentasToolStripMenuItem";
            this.gestionarVentasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gestionarVentasToolStripMenuItem.Text = "Gestionar Ventas";
            this.gestionarVentasToolStripMenuItem.Click += new System.EventHandler(this.gestionarVentasToolStripMenuItem_Click);
            // 
            // gerenciaToolStripMenuItem
            // 
            this.gerenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarReportesToolStripMenuItem,
            this.generarArchivosDeDatosToolStripMenuItem});
            this.gerenciaToolStripMenuItem.Name = "gerenciaToolStripMenuItem";
            this.gerenciaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gerenciaToolStripMenuItem.Text = "Gerencia";
            // 
            // gestionarReportesToolStripMenuItem
            // 
            this.gestionarReportesToolStripMenuItem.Name = "gestionarReportesToolStripMenuItem";
            this.gestionarReportesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.gestionarReportesToolStripMenuItem.Text = "Gestionar Reportes";
            this.gestionarReportesToolStripMenuItem.Click += new System.EventHandler(this.gestionarReportesToolStripMenuItem_Click);
            // 
            // generarArchivosDeDatosToolStripMenuItem
            // 
            this.generarArchivosDeDatosToolStripMenuItem.Name = "generarArchivosDeDatosToolStripMenuItem";
            this.generarArchivosDeDatosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.generarArchivosDeDatosToolStripMenuItem.Text = "Generar Archivos de Datos";
            this.generarArchivosDeDatosToolStripMenuItem.Click += new System.EventHandler(this.generarArchivosDeDatosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuariosToolStripMenuItem,
            this.gestionarGruposToolStripMenuItem,
            this.gestionarBackupsToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click);
            // 
            // gestionarGruposToolStripMenuItem
            // 
            this.gestionarGruposToolStripMenuItem.Name = "gestionarGruposToolStripMenuItem";
            this.gestionarGruposToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarGruposToolStripMenuItem.Text = "Gestionar Grupos";
            this.gestionarGruposToolStripMenuItem.Click += new System.EventHandler(this.gestionarGruposToolStripMenuItem_Click);
            // 
            // gestionarBackupsToolStripMenuItem
            // 
            this.gestionarBackupsToolStripMenuItem.Name = "gestionarBackupsToolStripMenuItem";
            this.gestionarBackupsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gestionarBackupsToolStripMenuItem.Text = "Gestionar Backups";
            this.gestionarBackupsToolStripMenuItem.Click += new System.EventHandler(this.gestionarBackupsToolStripMenuItem_Click);
            // 
            // panDATOSUSUARIO
            // 
            this.panDATOSUSUARIO.Controls.Add(this.lblDATOSUSUARIO);
            this.panDATOSUSUARIO.Controls.Add(this.btnLOGOUT);
            this.panDATOSUSUARIO.Controls.Add(this.btnCAMBIARCLAVE);
            this.panDATOSUSUARIO.Controls.Add(this.btnMIPERFIL);
            this.panDATOSUSUARIO.Controls.Add(this.lblGRUPOS);
            this.panDATOSUSUARIO.Controls.Add(this.lblMAIL);
            this.panDATOSUSUARIO.Controls.Add(this.lblNOMBREAPELLIDO);
            this.panDATOSUSUARIO.Controls.Add(this.lblUSUARIO);
            this.panDATOSUSUARIO.Location = new System.Drawing.Point(40, 60);
            this.panDATOSUSUARIO.Name = "panDATOSUSUARIO";
            this.panDATOSUSUARIO.Size = new System.Drawing.Size(320, 480);
            this.panDATOSUSUARIO.TabIndex = 1;
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(20, 60);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(101, 13);
            this.lblUSUARIO.TabIndex = 0;
            this.lblUSUARIO.Text = "Nombre de Usuario:";
            // 
            // lblNOMBREAPELLIDO
            // 
            this.lblNOMBREAPELLIDO.AutoSize = true;
            this.lblNOMBREAPELLIDO.Location = new System.Drawing.Point(20, 100);
            this.lblNOMBREAPELLIDO.Name = "lblNOMBREAPELLIDO";
            this.lblNOMBREAPELLIDO.Size = new System.Drawing.Size(95, 13);
            this.lblNOMBREAPELLIDO.TabIndex = 1;
            this.lblNOMBREAPELLIDO.Text = "Nombre y Apellido:";
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Location = new System.Drawing.Point(20, 140);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(29, 13);
            this.lblMAIL.TabIndex = 2;
            this.lblMAIL.Text = "Mail:";
            // 
            // lblGRUPOS
            // 
            this.lblGRUPOS.AutoSize = true;
            this.lblGRUPOS.Location = new System.Drawing.Point(20, 180);
            this.lblGRUPOS.Name = "lblGRUPOS";
            this.lblGRUPOS.Size = new System.Drawing.Size(44, 13);
            this.lblGRUPOS.TabIndex = 3;
            this.lblGRUPOS.Text = "Grupos:";
            // 
            // btnMIPERFIL
            // 
            this.btnMIPERFIL.Location = new System.Drawing.Point(20, 400);
            this.btnMIPERFIL.Name = "btnMIPERFIL";
            this.btnMIPERFIL.Size = new System.Drawing.Size(75, 60);
            this.btnMIPERFIL.TabIndex = 4;
            this.btnMIPERFIL.Text = "MI PERFIL";
            this.btnMIPERFIL.UseVisualStyleBackColor = true;
            this.btnMIPERFIL.Click += new System.EventHandler(this.btnMIPERFIL_Click);
            // 
            // btnCAMBIARCLAVE
            // 
            this.btnCAMBIARCLAVE.Location = new System.Drawing.Point(120, 400);
            this.btnCAMBIARCLAVE.Name = "btnCAMBIARCLAVE";
            this.btnCAMBIARCLAVE.Size = new System.Drawing.Size(75, 60);
            this.btnCAMBIARCLAVE.TabIndex = 5;
            this.btnCAMBIARCLAVE.Text = "CAMBIAR CLAVE";
            this.btnCAMBIARCLAVE.UseVisualStyleBackColor = true;
            this.btnCAMBIARCLAVE.Click += new System.EventHandler(this.btnCAMBIARCLAVE_Click);
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.Location = new System.Drawing.Point(220, 400);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(75, 60);
            this.btnLOGOUT.TabIndex = 6;
            this.btnLOGOUT.Text = "LOG OUT";
            this.btnLOGOUT.UseVisualStyleBackColor = true;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // lblDATOSUSUARIO
            // 
            this.lblDATOSUSUARIO.AutoSize = true;
            this.lblDATOSUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATOSUSUARIO.Location = new System.Drawing.Point(20, 20);
            this.lblDATOSUSUARIO.Name = "lblDATOSUSUARIO";
            this.lblDATOSUSUARIO.Size = new System.Drawing.Size(261, 29);
            this.lblDATOSUSUARIO.TabIndex = 7;
            this.lblDATOSUSUARIO.Text = "DATOS DEL USUARIO";
            // 
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar Productos";
            this.gestionarProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionarProductosToolStripMenuItem_Click);
            // 
            // gestionarLocalidadesToolStripMenuItem
            // 
            this.gestionarLocalidadesToolStripMenuItem.Name = "gestionarLocalidadesToolStripMenuItem";
            this.gestionarLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarLocalidadesToolStripMenuItem.Text = "Gestionar Localidades";
            this.gestionarLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionarLocalidadesToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.panDATOSUSUARIO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panDATOSUSUARIO.ResumeLayout(false);
            this.panDATOSUSUARIO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarOrdenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarRemitosDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarArchivosDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarBackupsToolStripMenuItem;
        private System.Windows.Forms.Panel panDATOSUSUARIO;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.Label lblMAIL;
        private System.Windows.Forms.Label lblNOMBREAPELLIDO;
        private System.Windows.Forms.Button btnLOGOUT;
        private System.Windows.Forms.Button btnCAMBIARCLAVE;
        private System.Windows.Forms.Button btnMIPERFIL;
        private System.Windows.Forms.Label lblGRUPOS;
        private System.Windows.Forms.Label lblDATOSUSUARIO;
        private System.Windows.Forms.ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarLocalidadesToolStripMenuItem;
    }
}

