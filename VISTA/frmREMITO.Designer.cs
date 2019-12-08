namespace VISTA
{
    partial class frmRemito
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
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblPROVEEDORNOMBRE = new System.Windows.Forms.Label();
            this.pPRODUCTO = new System.Windows.Forms.Panel();
            this.txtPRECIOUNITARIO = new System.Windows.Forms.TextBox();
            this.lblPRECIOUNITARIO = new System.Windows.Forms.Label();
            this.btnCONFIRMARPRODUCTO = new System.Windows.Forms.Button();
            this.lblPRODUCTO = new System.Windows.Forms.Label();
            this.lblCANTIDAD = new System.Windows.Forms.Label();
            this.nudCANTIDADPRODUCTO = new System.Windows.Forms.NumericUpDown();
            this.btnELIMINARPRODUCTO = new System.Windows.Forms.Button();
            this.lblPRODUCTOS = new System.Windows.Forms.Label();
            this.lblTOTALDETALLE = new System.Windows.Forms.Label();
            this.txtTOTALPRODUCTOS = new System.Windows.Forms.TextBox();
            this.lblPROVEEDOR = new System.Windows.Forms.Label();
            this.dgvPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnORDEN = new System.Windows.Forms.Button();
            this.lblORDEN = new System.Windows.Forms.Label();
            this.btnMODIFICARPRODUCTO = new System.Windows.Forms.Button();
            this.lblNOMBREPROVEEDOR = new System.Windows.Forms.Label();
            this.lblORDENSELECCIONADA = new System.Windows.Forms.Label();
            this.lblFECHAENTREGA = new System.Windows.Forms.Label();
            this.dtpFECHAENTREGA = new System.Windows.Forms.DateTimePicker();
            this.pPRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCANTIDADPRODUCTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(439, 352);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 105;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(132, 352);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 35);
            this.btnGUARDAR.TabIndex = 104;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblPROVEEDORNOMBRE
            // 
            this.lblPROVEEDORNOMBRE.AutoSize = true;
            this.lblPROVEEDORNOMBRE.Location = new System.Drawing.Point(139, 86);
            this.lblPROVEEDORNOMBRE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPROVEEDORNOMBRE.Name = "lblPROVEEDORNOMBRE";
            this.lblPROVEEDORNOMBRE.Size = new System.Drawing.Size(0, 13);
            this.lblPROVEEDORNOMBRE.TabIndex = 103;
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
            this.pPRODUCTO.Location = new System.Drawing.Point(494, 124);
            this.pPRODUCTO.Name = "pPRODUCTO";
            this.pPRODUCTO.Size = new System.Drawing.Size(279, 171);
            this.pPRODUCTO.TabIndex = 101;
            // 
            // txtPRECIOUNITARIO
            // 
            this.txtPRECIOUNITARIO.Location = new System.Drawing.Point(94, 94);
            this.txtPRECIOUNITARIO.Name = "txtPRECIOUNITARIO";
            this.txtPRECIOUNITARIO.Size = new System.Drawing.Size(100, 20);
            this.txtPRECIOUNITARIO.TabIndex = 92;
            // 
            // lblPRECIOUNITARIO
            // 
            this.lblPRECIOUNITARIO.AutoSize = true;
            this.lblPRECIOUNITARIO.Location = new System.Drawing.Point(11, 97);
            this.lblPRECIOUNITARIO.Name = "lblPRECIOUNITARIO";
            this.lblPRECIOUNITARIO.Size = new System.Drawing.Size(77, 13);
            this.lblPRECIOUNITARIO.TabIndex = 65;
            this.lblPRECIOUNITARIO.Text = "Precio unitario:";
            // 
            // btnCONFIRMARPRODUCTO
            // 
            this.btnCONFIRMARPRODUCTO.Location = new System.Drawing.Point(14, 125);
            this.btnCONFIRMARPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONFIRMARPRODUCTO.Name = "btnCONFIRMARPRODUCTO";
            this.btnCONFIRMARPRODUCTO.Size = new System.Drawing.Size(102, 30);
            this.btnCONFIRMARPRODUCTO.TabIndex = 55;
            this.btnCONFIRMARPRODUCTO.Text = "Confirmar";
            this.btnCONFIRMARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnCONFIRMARPRODUCTO.Click += new System.EventHandler(this.btnCONFIRMARPRODUCTO_Click);
            // 
            // lblPRODUCTO
            // 
            this.lblPRODUCTO.AutoSize = true;
            this.lblPRODUCTO.Location = new System.Drawing.Point(11, 17);
            this.lblPRODUCTO.Name = "lblPRODUCTO";
            this.lblPRODUCTO.Size = new System.Drawing.Size(90, 13);
            this.lblPRODUCTO.TabIndex = 64;
            this.lblPRODUCTO.Text = "Nombre Producto";
            // 
            // lblCANTIDAD
            // 
            this.lblCANTIDAD.AutoSize = true;
            this.lblCANTIDAD.Location = new System.Drawing.Point(11, 58);
            this.lblCANTIDAD.Name = "lblCANTIDAD";
            this.lblCANTIDAD.Size = new System.Drawing.Size(52, 13);
            this.lblCANTIDAD.TabIndex = 57;
            this.lblCANTIDAD.Text = "Cantidad:";
            // 
            // nudCANTIDADPRODUCTO
            // 
            this.nudCANTIDADPRODUCTO.Location = new System.Drawing.Point(69, 56);
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
            this.btnELIMINARPRODUCTO.Location = new System.Drawing.Point(12, 300);
            this.btnELIMINARPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINARPRODUCTO.Name = "btnELIMINARPRODUCTO";
            this.btnELIMINARPRODUCTO.Size = new System.Drawing.Size(116, 30);
            this.btnELIMINARPRODUCTO.TabIndex = 100;
            this.btnELIMINARPRODUCTO.Text = "Eliminar Producto";
            this.btnELIMINARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnELIMINARPRODUCTO.Click += new System.EventHandler(this.btnELIMINARPRODUCTO_Click);
            // 
            // lblPRODUCTOS
            // 
            this.lblPRODUCTOS.AutoSize = true;
            this.lblPRODUCTOS.Location = new System.Drawing.Point(13, 108);
            this.lblPRODUCTOS.Name = "lblPRODUCTOS";
            this.lblPRODUCTOS.Size = new System.Drawing.Size(58, 13);
            this.lblPRODUCTOS.TabIndex = 98;
            this.lblPRODUCTOS.Text = "Productos:";
            // 
            // lblTOTALDETALLE
            // 
            this.lblTOTALDETALLE.AutoSize = true;
            this.lblTOTALDETALLE.Location = new System.Drawing.Point(303, 303);
            this.lblTOTALDETALLE.Name = "lblTOTALDETALLE";
            this.lblTOTALDETALLE.Size = new System.Drawing.Size(45, 13);
            this.lblTOTALDETALLE.TabIndex = 97;
            this.lblTOTALDETALLE.Text = "TOTAL:";
            // 
            // txtTOTALPRODUCTOS
            // 
            this.txtTOTALPRODUCTOS.Location = new System.Drawing.Point(367, 300);
            this.txtTOTALPRODUCTOS.Name = "txtTOTALPRODUCTOS";
            this.txtTOTALPRODUCTOS.Size = new System.Drawing.Size(100, 20);
            this.txtTOTALPRODUCTOS.TabIndex = 96;
            // 
            // lblPROVEEDOR
            // 
            this.lblPROVEEDOR.AutoSize = true;
            this.lblPROVEEDOR.Location = new System.Drawing.Point(24, 86);
            this.lblPROVEEDOR.Name = "lblPROVEEDOR";
            this.lblPROVEEDOR.Size = new System.Drawing.Size(59, 13);
            this.lblPROVEEDOR.TabIndex = 93;
            this.lblPROVEEDOR.Text = "Proveedor:";
            // 
            // dgvPRODUCTOS
            // 
            this.dgvPRODUCTOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTOS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvPRODUCTOS.Location = new System.Drawing.Point(13, 124);
            this.dgvPRODUCTOS.Name = "dgvPRODUCTOS";
            this.dgvPRODUCTOS.Size = new System.Drawing.Size(454, 171);
            this.dgvPRODUCTOS.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 108;
            // 
            // btnORDEN
            // 
            this.btnORDEN.Location = new System.Drawing.Point(272, 11);
            this.btnORDEN.Margin = new System.Windows.Forms.Padding(2);
            this.btnORDEN.Name = "btnORDEN";
            this.btnORDEN.Size = new System.Drawing.Size(142, 27);
            this.btnORDEN.TabIndex = 107;
            this.btnORDEN.Text = "Seleccionar Orden ";
            this.btnORDEN.UseVisualStyleBackColor = true;
            this.btnORDEN.Click += new System.EventHandler(this.btnORDEN_Click);
            // 
            // lblORDEN
            // 
            this.lblORDEN.AutoSize = true;
            this.lblORDEN.Location = new System.Drawing.Point(24, 18);
            this.lblORDEN.Name = "lblORDEN";
            this.lblORDEN.Size = new System.Drawing.Size(93, 13);
            this.lblORDEN.TabIndex = 106;
            this.lblORDEN.Text = "Orden de Compra:";
            // 
            // btnMODIFICARPRODUCTO
            // 
            this.btnMODIFICARPRODUCTO.Location = new System.Drawing.Point(132, 300);
            this.btnMODIFICARPRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.btnMODIFICARPRODUCTO.Name = "btnMODIFICARPRODUCTO";
            this.btnMODIFICARPRODUCTO.Size = new System.Drawing.Size(116, 30);
            this.btnMODIFICARPRODUCTO.TabIndex = 109;
            this.btnMODIFICARPRODUCTO.Text = "Modificar Producto";
            this.btnMODIFICARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnMODIFICARPRODUCTO.Click += new System.EventHandler(this.btnMODIFICARPRODUCTO_Click);
            // 
            // lblNOMBREPROVEEDOR
            // 
            this.lblNOMBREPROVEEDOR.AutoSize = true;
            this.lblNOMBREPROVEEDOR.Location = new System.Drawing.Point(269, 86);
            this.lblNOMBREPROVEEDOR.Name = "lblNOMBREPROVEEDOR";
            this.lblNOMBREPROVEEDOR.Size = new System.Drawing.Size(96, 13);
            this.lblNOMBREPROVEEDOR.TabIndex = 110;
            this.lblNOMBREPROVEEDOR.Text = "Nombre Proveedor";
            // 
            // lblORDENSELECCIONADA
            // 
            this.lblORDENSELECCIONADA.AutoSize = true;
            this.lblORDENSELECCIONADA.Location = new System.Drawing.Point(152, 18);
            this.lblORDENSELECCIONADA.Name = "lblORDENSELECCIONADA";
            this.lblORDENSELECCIONADA.Size = new System.Drawing.Size(36, 13);
            this.lblORDENSELECCIONADA.TabIndex = 112;
            this.lblORDENSELECCIONADA.Text = "Orden";
            // 
            // lblFECHAENTREGA
            // 
            this.lblFECHAENTREGA.AutoSize = true;
            this.lblFECHAENTREGA.Location = new System.Drawing.Point(24, 54);
            this.lblFECHAENTREGA.Name = "lblFECHAENTREGA";
            this.lblFECHAENTREGA.Size = new System.Drawing.Size(80, 13);
            this.lblFECHAENTREGA.TabIndex = 94;
            this.lblFECHAENTREGA.Text = "Fecha Entrega:";
            // 
            // dtpFECHAENTREGA
            // 
            this.dtpFECHAENTREGA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFECHAENTREGA.Location = new System.Drawing.Point(142, 54);
            this.dtpFECHAENTREGA.Name = "dtpFECHAENTREGA";
            this.dtpFECHAENTREGA.Size = new System.Drawing.Size(272, 20);
            this.dtpFECHAENTREGA.TabIndex = 95;
            // 
            // frmRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.lblORDENSELECCIONADA);
            this.Controls.Add(this.lblNOMBREPROVEEDOR);
            this.Controls.Add(this.btnMODIFICARPRODUCTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnORDEN);
            this.Controls.Add(this.lblORDEN);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblPROVEEDORNOMBRE);
            this.Controls.Add(this.pPRODUCTO);
            this.Controls.Add(this.btnELIMINARPRODUCTO);
            this.Controls.Add(this.lblPRODUCTOS);
            this.Controls.Add(this.lblTOTALDETALLE);
            this.Controls.Add(this.txtTOTALPRODUCTOS);
            this.Controls.Add(this.dtpFECHAENTREGA);
            this.Controls.Add(this.lblFECHAENTREGA);
            this.Controls.Add(this.lblPROVEEDOR);
            this.Controls.Add(this.dgvPRODUCTOS);
            this.Name = "frmRemito";
            this.Text = "frmREMITO";
            this.Load += new System.EventHandler(this.frmRemito_Load);
            this.pPRODUCTO.ResumeLayout(false);
            this.pPRODUCTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCANTIDADPRODUCTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblPROVEEDORNOMBRE;
        private System.Windows.Forms.Panel pPRODUCTO;
        private System.Windows.Forms.TextBox txtPRECIOUNITARIO;
        private System.Windows.Forms.Label lblPRECIOUNITARIO;
        private System.Windows.Forms.Button btnCONFIRMARPRODUCTO;
        private System.Windows.Forms.Label lblPRODUCTO;
        private System.Windows.Forms.Label lblCANTIDAD;
        private System.Windows.Forms.NumericUpDown nudCANTIDADPRODUCTO;
        private System.Windows.Forms.Button btnELIMINARPRODUCTO;
        private System.Windows.Forms.Label lblPRODUCTOS;
        private System.Windows.Forms.Label lblTOTALDETALLE;
        private System.Windows.Forms.TextBox txtTOTALPRODUCTOS;
        private System.Windows.Forms.Label lblPROVEEDOR;
        private System.Windows.Forms.DataGridView dgvPRODUCTOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnORDEN;
        private System.Windows.Forms.Label lblORDEN;
        private System.Windows.Forms.Button btnMODIFICARPRODUCTO;
        private System.Windows.Forms.Label lblNOMBREPROVEEDOR;
        private System.Windows.Forms.Label lblORDENSELECCIONADA;
        private System.Windows.Forms.Label lblFECHAENTREGA;
        private System.Windows.Forms.DateTimePicker dtpFECHAENTREGA;
    }
}