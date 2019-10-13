namespace VISTA
{
    partial class frmOrdenDeCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPROVEEDORNOMBRE = new System.Windows.Forms.Label();
            this.btnPROVEEDOR = new System.Windows.Forms.Button();
            this.pPRODUCTO = new System.Windows.Forms.Panel();
            this.btnCONFIRMARPRODUCTO = new System.Windows.Forms.Button();
            this.lblPRODUCTO = new System.Windows.Forms.Label();
            this.lblCANTIDAD = new System.Windows.Forms.Label();
            this.nudCANTIDADPRODUCTO = new System.Windows.Forms.NumericUpDown();
            this.btnELIMINARPRODUCTO = new System.Windows.Forms.Button();
            this.btnBUSCARPRODUCTO = new System.Windows.Forms.Button();
            this.lblPRODUCTOS = new System.Windows.Forms.Label();
            this.lblTOTALDETALLE = new System.Windows.Forms.Label();
            this.txtTOTALPRODUCTOS = new System.Windows.Forms.TextBox();
            this.dtpFECHAENTREGA = new System.Windows.Forms.DateTimePicker();
            this.lblFECHAENTREGA = new System.Windows.Forms.Label();
            this.lblPROVEEDOR = new System.Windows.Forms.Label();
            this.dgvPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.dtpFECHAPEDIDO = new System.Windows.Forms.DateTimePicker();
            this.lblFECHAPEDIDO = new System.Windows.Forms.Label();
            this.lblPRECIOUNITARIO = new System.Windows.Forms.Label();
            this.txtPRECIOUNITARIO = new System.Windows.Forms.TextBox();
            this.pPRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCANTIDADPRODUCTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPROVEEDORNOMBRE
            // 
            this.lblPROVEEDORNOMBRE.AutoSize = true;
            this.lblPROVEEDORNOMBRE.Location = new System.Drawing.Point(172, 79);
            this.lblPROVEEDORNOMBRE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPROVEEDORNOMBRE.Name = "lblPROVEEDORNOMBRE";
            this.lblPROVEEDORNOMBRE.Size = new System.Drawing.Size(0, 13);
            this.lblPROVEEDORNOMBRE.TabIndex = 87;
            // 
            // btnPROVEEDOR
            // 
            this.btnPROVEEDOR.Location = new System.Drawing.Point(305, 72);
            this.btnPROVEEDOR.Margin = new System.Windows.Forms.Padding(2);
            this.btnPROVEEDOR.Name = "btnPROVEEDOR";
            this.btnPROVEEDOR.Size = new System.Drawing.Size(142, 27);
            this.btnPROVEEDOR.TabIndex = 86;
            this.btnPROVEEDOR.Text = "Seleccionar Proveedor";
            this.btnPROVEEDOR.UseVisualStyleBackColor = true;
            this.btnPROVEEDOR.Click += new System.EventHandler(this.btnPROVEEDOR_Click);
            // 
            // pPRODUCTO
            // 
            this.pPRODUCTO.BackColor = System.Drawing.SystemColors.GrayText;
            this.pPRODUCTO.Controls.Add(this.txtPRECIOUNITARIO);
            this.pPRODUCTO.Controls.Add(this.lblPRECIOUNITARIO);
            this.pPRODUCTO.Controls.Add(this.btnCONFIRMARPRODUCTO);
            this.pPRODUCTO.Controls.Add(this.lblPRODUCTO);
            this.pPRODUCTO.Controls.Add(this.lblCANTIDAD);
            this.pPRODUCTO.Controls.Add(this.nudCANTIDADPRODUCTO);
            this.pPRODUCTO.Location = new System.Drawing.Point(493, 160);
            this.pPRODUCTO.Name = "pPRODUCTO";
            this.pPRODUCTO.Size = new System.Drawing.Size(279, 136);
            this.pPRODUCTO.TabIndex = 85;
            // 
            // btnCONFIRMARPRODUCTO
            // 
            this.btnCONFIRMARPRODUCTO.Location = new System.Drawing.Point(158, 55);
            this.btnCONFIRMARPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONFIRMARPRODUCTO.Name = "btnCONFIRMARPRODUCTO";
            this.btnCONFIRMARPRODUCTO.Size = new System.Drawing.Size(102, 30);
            this.btnCONFIRMARPRODUCTO.TabIndex = 55;
            this.btnCONFIRMARPRODUCTO.Text = "Agregar Producto";
            this.btnCONFIRMARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnCONFIRMARPRODUCTO.Click += new System.EventHandler(this.btnCONFIRMARPRODUCTO_Click);
            // 
            // lblPRODUCTO
            // 
            this.lblPRODUCTO.AutoSize = true;
            this.lblPRODUCTO.Location = new System.Drawing.Point(11, 23);
            this.lblPRODUCTO.Name = "lblPRODUCTO";
            this.lblPRODUCTO.Size = new System.Drawing.Size(90, 13);
            this.lblPRODUCTO.TabIndex = 64;
            this.lblPRODUCTO.Text = "Nombre Producto";
            // 
            // lblCANTIDAD
            // 
            this.lblCANTIDAD.AutoSize = true;
            this.lblCANTIDAD.Location = new System.Drawing.Point(11, 64);
            this.lblCANTIDAD.Name = "lblCANTIDAD";
            this.lblCANTIDAD.Size = new System.Drawing.Size(52, 13);
            this.lblCANTIDAD.TabIndex = 57;
            this.lblCANTIDAD.Text = "Cantidad:";
            // 
            // nudCANTIDADPRODUCTO
            // 
            this.nudCANTIDADPRODUCTO.Location = new System.Drawing.Point(69, 62);
            this.nudCANTIDADPRODUCTO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCANTIDADPRODUCTO.Name = "nudCANTIDADPRODUCTO";
            this.nudCANTIDADPRODUCTO.Size = new System.Drawing.Size(70, 20);
            this.nudCANTIDADPRODUCTO.TabIndex = 58;
            this.nudCANTIDADPRODUCTO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnELIMINARPRODUCTO
            // 
            this.btnELIMINARPRODUCTO.Location = new System.Drawing.Point(11, 301);
            this.btnELIMINARPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINARPRODUCTO.Name = "btnELIMINARPRODUCTO";
            this.btnELIMINARPRODUCTO.Size = new System.Drawing.Size(116, 30);
            this.btnELIMINARPRODUCTO.TabIndex = 84;
            this.btnELIMINARPRODUCTO.Text = "Eliminar Producto";
            this.btnELIMINARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnELIMINARPRODUCTO.Click += new System.EventHandler(this.btnELIMINARPRODUCTO_Click);
            // 
            // btnBUSCARPRODUCTO
            // 
            this.btnBUSCARPRODUCTO.Location = new System.Drawing.Point(493, 125);
            this.btnBUSCARPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCARPRODUCTO.Name = "btnBUSCARPRODUCTO";
            this.btnBUSCARPRODUCTO.Size = new System.Drawing.Size(279, 30);
            this.btnBUSCARPRODUCTO.TabIndex = 83;
            this.btnBUSCARPRODUCTO.Text = "Buscar Producto";
            this.btnBUSCARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnBUSCARPRODUCTO.Click += new System.EventHandler(this.btnBUSCARPRODUCTO_Click);
            // 
            // lblPRODUCTOS
            // 
            this.lblPRODUCTOS.AutoSize = true;
            this.lblPRODUCTOS.Location = new System.Drawing.Point(12, 109);
            this.lblPRODUCTOS.Name = "lblPRODUCTOS";
            this.lblPRODUCTOS.Size = new System.Drawing.Size(58, 13);
            this.lblPRODUCTOS.TabIndex = 82;
            this.lblPRODUCTOS.Text = "Productos:";
            // 
            // lblTOTALDETALLE
            // 
            this.lblTOTALDETALLE.AutoSize = true;
            this.lblTOTALDETALLE.Location = new System.Drawing.Point(302, 304);
            this.lblTOTALDETALLE.Name = "lblTOTALDETALLE";
            this.lblTOTALDETALLE.Size = new System.Drawing.Size(45, 13);
            this.lblTOTALDETALLE.TabIndex = 81;
            this.lblTOTALDETALLE.Text = "TOTAL:";
            // 
            // txtTOTALPRODUCTOS
            // 
            this.txtTOTALPRODUCTOS.Location = new System.Drawing.Point(366, 301);
            this.txtTOTALPRODUCTOS.Name = "txtTOTALPRODUCTOS";
            this.txtTOTALPRODUCTOS.Size = new System.Drawing.Size(100, 20);
            this.txtTOTALPRODUCTOS.TabIndex = 80;
            // 
            // dtpFECHAENTREGA
            // 
            this.dtpFECHAENTREGA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFECHAENTREGA.Location = new System.Drawing.Point(175, 47);
            this.dtpFECHAENTREGA.Name = "dtpFECHAENTREGA";
            this.dtpFECHAENTREGA.Size = new System.Drawing.Size(272, 20);
            this.dtpFECHAENTREGA.TabIndex = 79;
            // 
            // lblFECHAENTREGA
            // 
            this.lblFECHAENTREGA.AutoSize = true;
            this.lblFECHAENTREGA.Location = new System.Drawing.Point(57, 47);
            this.lblFECHAENTREGA.Name = "lblFECHAENTREGA";
            this.lblFECHAENTREGA.Size = new System.Drawing.Size(80, 13);
            this.lblFECHAENTREGA.TabIndex = 78;
            this.lblFECHAENTREGA.Text = "Fecha Entrega:";
            // 
            // lblPROVEEDOR
            // 
            this.lblPROVEEDOR.AutoSize = true;
            this.lblPROVEEDOR.Location = new System.Drawing.Point(57, 79);
            this.lblPROVEEDOR.Name = "lblPROVEEDOR";
            this.lblPROVEEDOR.Size = new System.Drawing.Size(59, 13);
            this.lblPROVEEDOR.TabIndex = 77;
            this.lblPROVEEDOR.Text = "Proveedor:";
            // 
            // dgvPRODUCTOS
            // 
            this.dgvPRODUCTOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTOS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvPRODUCTOS.Location = new System.Drawing.Point(12, 125);
            this.dgvPRODUCTOS.Name = "dgvPRODUCTOS";
            this.dgvPRODUCTOS.Size = new System.Drawing.Size(454, 171);
            this.dgvPRODUCTOS.TabIndex = 76;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(438, 353);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 89;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(131, 353);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 35);
            this.btnGUARDAR.TabIndex = 88;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // dtpFECHAPEDIDO
            // 
            this.dtpFECHAPEDIDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFECHAPEDIDO.Location = new System.Drawing.Point(175, 21);
            this.dtpFECHAPEDIDO.Name = "dtpFECHAPEDIDO";
            this.dtpFECHAPEDIDO.Size = new System.Drawing.Size(272, 20);
            this.dtpFECHAPEDIDO.TabIndex = 91;
            // 
            // lblFECHAPEDIDO
            // 
            this.lblFECHAPEDIDO.AutoSize = true;
            this.lblFECHAPEDIDO.Location = new System.Drawing.Point(57, 21);
            this.lblFECHAPEDIDO.Name = "lblFECHAPEDIDO";
            this.lblFECHAPEDIDO.Size = new System.Drawing.Size(76, 13);
            this.lblFECHAPEDIDO.TabIndex = 90;
            this.lblFECHAPEDIDO.Text = "Fecha Pedido:";
            // 
            // lblPRECIOUNITARIO
            // 
            this.lblPRECIOUNITARIO.AutoSize = true;
            this.lblPRECIOUNITARIO.Location = new System.Drawing.Point(11, 103);
            this.lblPRECIOUNITARIO.Name = "lblPRECIOUNITARIO";
            this.lblPRECIOUNITARIO.Size = new System.Drawing.Size(77, 13);
            this.lblPRECIOUNITARIO.TabIndex = 65;
            this.lblPRECIOUNITARIO.Text = "Precio unitario:";
            // 
            // txtPRECIOUNITARIO
            // 
            this.txtPRECIOUNITARIO.Location = new System.Drawing.Point(94, 100);
            this.txtPRECIOUNITARIO.Name = "txtPRECIOUNITARIO";
            this.txtPRECIOUNITARIO.Size = new System.Drawing.Size(100, 20);
            this.txtPRECIOUNITARIO.TabIndex = 92;
            // 
            // frmOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.dtpFECHAPEDIDO);
            this.Controls.Add(this.lblFECHAPEDIDO);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblPROVEEDORNOMBRE);
            this.Controls.Add(this.btnPROVEEDOR);
            this.Controls.Add(this.pPRODUCTO);
            this.Controls.Add(this.btnELIMINARPRODUCTO);
            this.Controls.Add(this.btnBUSCARPRODUCTO);
            this.Controls.Add(this.lblPRODUCTOS);
            this.Controls.Add(this.lblTOTALDETALLE);
            this.Controls.Add(this.txtTOTALPRODUCTOS);
            this.Controls.Add(this.dtpFECHAENTREGA);
            this.Controls.Add(this.lblFECHAENTREGA);
            this.Controls.Add(this.lblPROVEEDOR);
            this.Controls.Add(this.dgvPRODUCTOS);
            this.Name = "frmOrdenDeCompra";
            this.Text = "frmOrdenDePago";
            this.Load += new System.EventHandler(this.frmOrdenDeCompra_Load);
            this.pPRODUCTO.ResumeLayout(false);
            this.pPRODUCTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCANTIDADPRODUCTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPROVEEDORNOMBRE;
        private System.Windows.Forms.Button btnPROVEEDOR;
        private System.Windows.Forms.Panel pPRODUCTO;
        private System.Windows.Forms.Button btnCONFIRMARPRODUCTO;
        private System.Windows.Forms.Label lblPRODUCTO;
        private System.Windows.Forms.Label lblCANTIDAD;
        private System.Windows.Forms.NumericUpDown nudCANTIDADPRODUCTO;
        private System.Windows.Forms.Button btnELIMINARPRODUCTO;
        private System.Windows.Forms.Button btnBUSCARPRODUCTO;
        private System.Windows.Forms.Label lblPRODUCTOS;
        private System.Windows.Forms.Label lblTOTALDETALLE;
        private System.Windows.Forms.TextBox txtTOTALPRODUCTOS;
        private System.Windows.Forms.DateTimePicker dtpFECHAENTREGA;
        private System.Windows.Forms.Label lblFECHAENTREGA;
        private System.Windows.Forms.Label lblPROVEEDOR;
        private System.Windows.Forms.DataGridView dgvPRODUCTOS;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.DateTimePicker dtpFECHAPEDIDO;
        private System.Windows.Forms.Label lblFECHAPEDIDO;
        private System.Windows.Forms.Label lblPRECIOUNITARIO;
        private System.Windows.Forms.TextBox txtPRECIOUNITARIO;
    }
}