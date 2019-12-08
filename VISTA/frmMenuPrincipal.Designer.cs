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
            this.gestionarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarOrdenesDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblDATOSUSUARIO = new System.Windows.Forms.Label();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.btnCAMBIARCLAVE = new System.Windows.Forms.Button();
            this.btnMIPERFIL = new System.Windows.Forms.Button();
            this.lblGRUPOS = new System.Windows.Forms.Label();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.lblNOMBREAPELLIDO = new System.Windows.Forms.Label();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panDATOSUSUARIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionesToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.gerenciaToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
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
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.gestionesToolStripMenuItem.Text = "Gestiones";
            // 
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar Productos";
            this.gestionarProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionarProductosToolStripMenuItem_Click);
            // 
            // gestionarMarcasToolStripMenuItem
            // 
            this.gestionarMarcasToolStripMenuItem.Name = "gestionarMarcasToolStripMenuItem";
            this.gestionarMarcasToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.gestionarMarcasToolStripMenuItem.Text = "Gestionar Marcas";
            this.gestionarMarcasToolStripMenuItem.Click += new System.EventHandler(this.gestionarMarcasToolStripMenuItem_Click);
            // 
            // gestionarCategoriasToolStripMenuItem
            // 
            this.gestionarCategoriasToolStripMenuItem.Name = "gestionarCategoriasToolStripMenuItem";
            this.gestionarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.gestionarCategoriasToolStripMenuItem.Text = "Gestionar Categorias";
            this.gestionarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionarCategoriasToolStripMenuItem_Click);
            // 
            // gestionarLocalidadesToolStripMenuItem
            // 
            this.gestionarLocalidadesToolStripMenuItem.Name = "gestionarLocalidadesToolStripMenuItem";
            this.gestionarLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.gestionarLocalidadesToolStripMenuItem.Text = "Gestionar Localidades";
            this.gestionarLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionarLocalidadesToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProveedoresToolStripMenuItem,
            this.gestionarOrdenesDeComprasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // gestionarProveedoresToolStripMenuItem
            // 
            this.gestionarProveedoresToolStripMenuItem.Name = "gestionarProveedoresToolStripMenuItem";
            this.gestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.gestionarProveedoresToolStripMenuItem.Text = "Gestionar Proveedores";
            this.gestionarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestionarProveedoresToolStripMenuItem_Click);
            // 
            // gestionarOrdenesDeComprasToolStripMenuItem
            // 
            this.gestionarOrdenesDeComprasToolStripMenuItem.Name = "gestionarOrdenesDeComprasToolStripMenuItem";
            this.gestionarOrdenesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.gestionarOrdenesDeComprasToolStripMenuItem.Text = "Gestionar Ordenes de Compras";
            this.gestionarOrdenesDeComprasToolStripMenuItem.Click += new System.EventHandler(this.gestionarOrdenesDeCompraToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarRemitosDeComprasToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // gestionarRemitosDeComprasToolStripMenuItem
            // 
            this.gestionarRemitosDeComprasToolStripMenuItem.Name = "gestionarRemitosDeComprasToolStripMenuItem";
            this.gestionarRemitosDeComprasToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.gestionarRemitosDeComprasToolStripMenuItem.Text = "Gestionar Remitos de Compras";
            this.gestionarRemitosDeComprasToolStripMenuItem.Click += new System.EventHandler(this.gestionarRemitosDeComprasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClientesToolStripMenuItem,
            this.gestionarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // gestionarVentasToolStripMenuItem
            // 
            this.gestionarVentasToolStripMenuItem.Name = "gestionarVentasToolStripMenuItem";
            this.gestionarVentasToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.gestionarVentasToolStripMenuItem.Text = "Gestionar Ventas";
            this.gestionarVentasToolStripMenuItem.Click += new System.EventHandler(this.gestionarVentasToolStripMenuItem_Click);
            // 
            // gerenciaToolStripMenuItem
            // 
            this.gerenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarReportesToolStripMenuItem,
            this.generarArchivosDeDatosToolStripMenuItem});
            this.gerenciaToolStripMenuItem.Name = "gerenciaToolStripMenuItem";
            this.gerenciaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.gerenciaToolStripMenuItem.Text = "Gerencia";
            // 
            // gestionarReportesToolStripMenuItem
            // 
            this.gestionarReportesToolStripMenuItem.Name = "gestionarReportesToolStripMenuItem";
            this.gestionarReportesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.gestionarReportesToolStripMenuItem.Text = "Gestionar Reportes";
            this.gestionarReportesToolStripMenuItem.Click += new System.EventHandler(this.gestionarReportesToolStripMenuItem_Click);
            // 
            // generarArchivosDeDatosToolStripMenuItem
            // 
            this.generarArchivosDeDatosToolStripMenuItem.Name = "generarArchivosDeDatosToolStripMenuItem";
            this.generarArchivosDeDatosToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
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
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // gestionarUsuariosToolStripMenuItem
            // 
            this.gestionarUsuariosToolStripMenuItem.Name = "gestionarUsuariosToolStripMenuItem";
            this.gestionarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            this.gestionarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuariosToolStripMenuItem_Click);
            // 
            // gestionarGruposToolStripMenuItem
            // 
            this.gestionarGruposToolStripMenuItem.Name = "gestionarGruposToolStripMenuItem";
            this.gestionarGruposToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.gestionarGruposToolStripMenuItem.Text = "Gestionar Grupos";
            this.gestionarGruposToolStripMenuItem.Click += new System.EventHandler(this.gestionarGruposToolStripMenuItem_Click);
            // 
            // gestionarBackupsToolStripMenuItem
            // 
            this.gestionarBackupsToolStripMenuItem.Name = "gestionarBackupsToolStripMenuItem";
            this.gestionarBackupsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.gestionarBackupsToolStripMenuItem.Text = "Gestionar Backups";
            this.gestionarBackupsToolStripMenuItem.Click += new System.EventHandler(this.gestionarBackupsToolStripMenuItem_Click);
            // 
            // panDATOSUSUARIO
            // 
            this.panDATOSUSUARIO.BackColor = System.Drawing.Color.Linen;
            this.panDATOSUSUARIO.Controls.Add(this.lblDATOSUSUARIO);
            this.panDATOSUSUARIO.Controls.Add(this.lblGRUPOS);
            this.panDATOSUSUARIO.Controls.Add(this.lblMAIL);
            this.panDATOSUSUARIO.Controls.Add(this.lblNOMBREAPELLIDO);
            this.panDATOSUSUARIO.Controls.Add(this.lblUSUARIO);
            this.panDATOSUSUARIO.Location = new System.Drawing.Point(216, 75);
            this.panDATOSUSUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panDATOSUSUARIO.Name = "panDATOSUSUARIO";
            this.panDATOSUSUARIO.Size = new System.Drawing.Size(815, 591);
            this.panDATOSUSUARIO.TabIndex = 1;
            // 
            // lblDATOSUSUARIO
            // 
            this.lblDATOSUSUARIO.AutoSize = true;
            this.lblDATOSUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATOSUSUARIO.Location = new System.Drawing.Point(30, 50);
            this.lblDATOSUSUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDATOSUSUARIO.Name = "lblDATOSUSUARIO";
            this.lblDATOSUSUARIO.Size = new System.Drawing.Size(328, 36);
            this.lblDATOSUSUARIO.TabIndex = 7;
            this.lblDATOSUSUARIO.Text = "DATOS DEL USUARIO";
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLOGOUT.FlatAppearance.BorderSize = 0;
            this.btnLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGOUT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLOGOUT.Location = new System.Drawing.Point(13, 478);
            this.btnLOGOUT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(179, 188);
            this.btnLOGOUT.TabIndex = 6;
            this.btnLOGOUT.Text = "LOG OUT";
            this.btnLOGOUT.UseVisualStyleBackColor = false;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // btnCAMBIARCLAVE
            // 
            this.btnCAMBIARCLAVE.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCAMBIARCLAVE.FlatAppearance.BorderSize = 0;
            this.btnCAMBIARCLAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAMBIARCLAVE.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCAMBIARCLAVE.Location = new System.Drawing.Point(13, 279);
            this.btnCAMBIARCLAVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCAMBIARCLAVE.Name = "btnCAMBIARCLAVE";
            this.btnCAMBIARCLAVE.Size = new System.Drawing.Size(179, 188);
            this.btnCAMBIARCLAVE.TabIndex = 5;
            this.btnCAMBIARCLAVE.Text = "CAMBIAR CLAVE";
            this.btnCAMBIARCLAVE.UseVisualStyleBackColor = false;
            this.btnCAMBIARCLAVE.Click += new System.EventHandler(this.btnCAMBIARCLAVE_Click);
            // 
            // btnMIPERFIL
            // 
            this.btnMIPERFIL.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMIPERFIL.FlatAppearance.BorderSize = 0;
            this.btnMIPERFIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMIPERFIL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMIPERFIL.Location = new System.Drawing.Point(13, 75);
            this.btnMIPERFIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMIPERFIL.Name = "btnMIPERFIL";
            this.btnMIPERFIL.Size = new System.Drawing.Size(179, 188);
            this.btnMIPERFIL.TabIndex = 4;
            this.btnMIPERFIL.Text = "MI PERFIL";
            this.btnMIPERFIL.UseVisualStyleBackColor = false;
            this.btnMIPERFIL.Click += new System.EventHandler(this.btnMIPERFIL_Click);
            // 
            // lblGRUPOS
            // 
            this.lblGRUPOS.AutoSize = true;
            this.lblGRUPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGRUPOS.Location = new System.Drawing.Point(31, 283);
            this.lblGRUPOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGRUPOS.Name = "lblGRUPOS";
            this.lblGRUPOS.Size = new System.Drawing.Size(82, 25);
            this.lblGRUPOS.TabIndex = 3;
            this.lblGRUPOS.Text = "Grupos:";
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMAIL.Location = new System.Drawing.Point(287, 238);
            this.lblMAIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(54, 25);
            this.lblMAIL.TabIndex = 2;
            this.lblMAIL.Text = "Mail:";
            // 
            // lblNOMBREAPELLIDO
            // 
            this.lblNOMBREAPELLIDO.AutoSize = true;
            this.lblNOMBREAPELLIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNOMBREAPELLIDO.Location = new System.Drawing.Point(287, 179);
            this.lblNOMBREAPELLIDO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNOMBREAPELLIDO.Name = "lblNOMBREAPELLIDO";
            this.lblNOMBREAPELLIDO.Size = new System.Drawing.Size(177, 25);
            this.lblNOMBREAPELLIDO.TabIndex = 1;
            this.lblNOMBREAPELLIDO.Text = "Nombre y Apellido:";
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUSUARIO.Location = new System.Drawing.Point(287, 118);
            this.lblUSUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(186, 25);
            this.lblUSUARIO.TabIndex = 0;
            this.lblUSUARIO.Text = "Nombre de Usuario:";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1283, 679);
            this.Controls.Add(this.panDATOSUSUARIO);
            this.Controls.Add(this.btnLOGOUT);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMIPERFIL);
            this.Controls.Add(this.btnCAMBIARCLAVE);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem gestionarOrdenesDeComprasToolStripMenuItem;
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

