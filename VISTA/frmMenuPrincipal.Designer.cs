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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
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
            this.verLoginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panDATOSUSUARIO = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDATOSUSUARIO = new System.Windows.Forms.Label();
            this.lblGRUPOS = new System.Windows.Forms.Label();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.lblNOMBREAPELLIDO = new System.Windows.Forms.Label();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.btnCAMBIARCLAVE = new System.Windows.Forms.Button();
            this.btnMIPERFIL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panDATOSUSUARIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Goldenrod;
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
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
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
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar Productos";
            this.gestionarProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionarProductosToolStripMenuItem_Click);
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
            // gestionarLocalidadesToolStripMenuItem
            // 
            this.gestionarLocalidadesToolStripMenuItem.Name = "gestionarLocalidadesToolStripMenuItem";
            this.gestionarLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarLocalidadesToolStripMenuItem.Text = "Gestionar Localidades";
            this.gestionarLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.gestionarLocalidadesToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProveedoresToolStripMenuItem,
            this.gestionarOrdenesDeComprasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // gestionarProveedoresToolStripMenuItem
            // 
            this.gestionarProveedoresToolStripMenuItem.Name = "gestionarProveedoresToolStripMenuItem";
            this.gestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.gestionarProveedoresToolStripMenuItem.Text = "Gestionar Proveedores";
            this.gestionarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestionarProveedoresToolStripMenuItem_Click);
            // 
            // gestionarOrdenesDeComprasToolStripMenuItem
            // 
            this.gestionarOrdenesDeComprasToolStripMenuItem.Name = "gestionarOrdenesDeComprasToolStripMenuItem";
            this.gestionarOrdenesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.gestionarOrdenesDeComprasToolStripMenuItem.Text = "Gestionar Ordenes de Compras";
            this.gestionarOrdenesDeComprasToolStripMenuItem.Click += new System.EventHandler(this.gestionarOrdenesDeCompraToolStripMenuItem_Click);
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
            this.gestionarBackupsToolStripMenuItem,
            this.verLoginsToolStripMenuItem});
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
            // verLoginsToolStripMenuItem
            // 
            this.verLoginsToolStripMenuItem.Name = "verLoginsToolStripMenuItem";
            this.verLoginsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verLoginsToolStripMenuItem.Text = "Logins del Sistema";
            this.verLoginsToolStripMenuItem.Click += new System.EventHandler(this.loginsDelSistemaToolStripMenuItem_Click);
            // 
            // panDATOSUSUARIO
            // 
            this.panDATOSUSUARIO.BackColor = System.Drawing.Color.Linen;
            this.panDATOSUSUARIO.Controls.Add(this.label);
            this.panDATOSUSUARIO.Controls.Add(this.label3);
            this.panDATOSUSUARIO.Controls.Add(this.label2);
            this.panDATOSUSUARIO.Controls.Add(this.label1);
            this.panDATOSUSUARIO.Controls.Add(this.pictureBox1);
            this.panDATOSUSUARIO.Controls.Add(this.lblDATOSUSUARIO);
            this.panDATOSUSUARIO.Controls.Add(this.lblGRUPOS);
            this.panDATOSUSUARIO.Controls.Add(this.lblMAIL);
            this.panDATOSUSUARIO.Controls.Add(this.lblNOMBREAPELLIDO);
            this.panDATOSUSUARIO.Controls.Add(this.lblUSUARIO);
            this.panDATOSUSUARIO.Location = new System.Drawing.Point(194, 61);
            this.panDATOSUSUARIO.Name = "panDATOSUSUARIO";
            this.panDATOSUSUARIO.Size = new System.Drawing.Size(611, 480);
            this.panDATOSUSUARIO.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(25, 299);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 19);
            this.label.TabIndex = 12;
            this.label.Text = "Grupos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(288, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(285, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(285, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblDATOSUSUARIO
            // 
            this.lblDATOSUSUARIO.AutoSize = true;
            this.lblDATOSUSUARIO.Font = new System.Drawing.Font("Arial Black", 18F);
            this.lblDATOSUSUARIO.Location = new System.Drawing.Point(22, 41);
            this.lblDATOSUSUARIO.Name = "lblDATOSUSUARIO";
            this.lblDATOSUSUARIO.Size = new System.Drawing.Size(294, 33);
            this.lblDATOSUSUARIO.TabIndex = 7;
            this.lblDATOSUSUARIO.Text = "DATOS DEL USUARIO";
            // 
            // lblGRUPOS
            // 
            this.lblGRUPOS.AutoSize = true;
            this.lblGRUPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGRUPOS.Location = new System.Drawing.Point(46, 318);
            this.lblGRUPOS.Name = "lblGRUPOS";
            this.lblGRUPOS.Size = new System.Drawing.Size(13, 20);
            this.lblGRUPOS.TabIndex = 3;
            this.lblGRUPOS.Text = ".";
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMAIL.Location = new System.Drawing.Point(289, 260);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(13, 20);
            this.lblMAIL.TabIndex = 2;
            this.lblMAIL.Text = ".";
            // 
            // lblNOMBREAPELLIDO
            // 
            this.lblNOMBREAPELLIDO.AutoSize = true;
            this.lblNOMBREAPELLIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNOMBREAPELLIDO.Location = new System.Drawing.Point(286, 184);
            this.lblNOMBREAPELLIDO.Name = "lblNOMBREAPELLIDO";
            this.lblNOMBREAPELLIDO.Size = new System.Drawing.Size(13, 20);
            this.lblNOMBREAPELLIDO.TabIndex = 1;
            this.lblNOMBREAPELLIDO.Text = ".";
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUSUARIO.Location = new System.Drawing.Point(286, 107);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(13, 20);
            this.lblUSUARIO.TabIndex = 0;
            this.lblUSUARIO.Text = ".";
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLOGOUT.FlatAppearance.BorderSize = 0;
            this.btnLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGOUT.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGOUT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLOGOUT.Image = ((System.Drawing.Image)(resources.GetObject("btnLOGOUT.Image")));
            this.btnLOGOUT.Location = new System.Drawing.Point(42, 388);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(134, 153);
            this.btnLOGOUT.TabIndex = 6;
            this.btnLOGOUT.Text = "LOG OUT";
            this.btnLOGOUT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLOGOUT.UseVisualStyleBackColor = false;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // btnCAMBIARCLAVE
            // 
            this.btnCAMBIARCLAVE.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCAMBIARCLAVE.FlatAppearance.BorderSize = 0;
            this.btnCAMBIARCLAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAMBIARCLAVE.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAMBIARCLAVE.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCAMBIARCLAVE.Image = ((System.Drawing.Image)(resources.GetObject("btnCAMBIARCLAVE.Image")));
            this.btnCAMBIARCLAVE.Location = new System.Drawing.Point(42, 227);
            this.btnCAMBIARCLAVE.Name = "btnCAMBIARCLAVE";
            this.btnCAMBIARCLAVE.Size = new System.Drawing.Size(134, 153);
            this.btnCAMBIARCLAVE.TabIndex = 5;
            this.btnCAMBIARCLAVE.Text = "CAMBIAR CLAVE";
            this.btnCAMBIARCLAVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCAMBIARCLAVE.UseVisualStyleBackColor = false;
            this.btnCAMBIARCLAVE.Click += new System.EventHandler(this.btnCAMBIARCLAVE_Click);
            // 
            // btnMIPERFIL
            // 
            this.btnMIPERFIL.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMIPERFIL.FlatAppearance.BorderSize = 0;
            this.btnMIPERFIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMIPERFIL.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMIPERFIL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMIPERFIL.Image = ((System.Drawing.Image)(resources.GetObject("btnMIPERFIL.Image")));
            this.btnMIPERFIL.Location = new System.Drawing.Point(42, 61);
            this.btnMIPERFIL.Name = "btnMIPERFIL";
            this.btnMIPERFIL.Size = new System.Drawing.Size(134, 153);
            this.btnMIPERFIL.TabIndex = 4;
            this.btnMIPERFIL.Text = "MI PERFIL";
            this.btnMIPERFIL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMIPERFIL.UseVisualStyleBackColor = false;
            this.btnMIPERFIL.Click += new System.EventHandler(this.btnMIPERFIL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(685, 592);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sistema de Libreria © 2019 UAI";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(859, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panDATOSUSUARIO);
            this.Controls.Add(this.btnLOGOUT);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMIPERFIL);
            this.Controls.Add(this.btnCAMBIARCLAVE);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Sistema de Libreria - MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panDATOSUSUARIO.ResumeLayout(false);
            this.panDATOSUSUARIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem verLoginsToolStripMenuItem;
    }
}

