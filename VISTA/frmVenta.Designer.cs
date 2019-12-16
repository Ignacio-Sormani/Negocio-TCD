namespace VISTA
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblPRODUCTOS = new System.Windows.Forms.Label();
            this.lblTOTALDETALLE = new System.Windows.Forms.Label();
            this.txtTOTALPRODUCTOS = new System.Windows.Forms.TextBox();
            this.lblCLIENTE = new System.Windows.Forms.Label();
            this.dgvPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.btnBUSCARPRODUCTO = new System.Windows.Forms.Button();
            this.btnCONFIRMARPRODUCTO = new System.Windows.Forms.Button();
            this.btnELIMINARPRODUCTO = new System.Windows.Forms.Button();
            this.nudCANTIDADPRODUCTO = new System.Windows.Forms.NumericUpDown();
            this.lblCANTIDAD = new System.Windows.Forms.Label();
            this.lblPRODUCTO = new System.Windows.Forms.Label();
            this.pPRODUCTO = new System.Windows.Forms.Panel();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblCLIENTENOMBRE = new System.Windows.Forms.Label();
            this.btnCLIENTE = new System.Windows.Forms.Button();
            this.lblFECHA = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.btnPAGOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCANTIDADPRODUCTO)).BeginInit();
            this.pPRODUCTO.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPRODUCTOS
            // 
            this.lblPRODUCTOS.AutoSize = true;
            this.lblPRODUCTOS.Location = new System.Drawing.Point(16, 89);
            this.lblPRODUCTOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPRODUCTOS.Name = "lblPRODUCTOS";
            this.lblPRODUCTOS.Size = new System.Drawing.Size(76, 17);
            this.lblPRODUCTOS.TabIndex = 32;
            this.lblPRODUCTOS.Text = "Productos:";
            // 
            // lblTOTALDETALLE
            // 
            this.lblTOTALDETALLE.AutoSize = true;
            this.lblTOTALDETALLE.Location = new System.Drawing.Point(404, 391);
            this.lblTOTALDETALLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTOTALDETALLE.Name = "lblTOTALDETALLE";
            this.lblTOTALDETALLE.Size = new System.Drawing.Size(58, 17);
            this.lblTOTALDETALLE.TabIndex = 31;
            this.lblTOTALDETALLE.Text = "TOTAL:";
            // 
            // txtTOTALPRODUCTOS
            // 
            this.txtTOTALPRODUCTOS.Location = new System.Drawing.Point(489, 387);
            this.txtTOTALPRODUCTOS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTOTALPRODUCTOS.Name = "txtTOTALPRODUCTOS";
            this.txtTOTALPRODUCTOS.Size = new System.Drawing.Size(132, 22);
            this.txtTOTALPRODUCTOS.TabIndex = 30;
            // 
            // lblCLIENTE
            // 
            this.lblCLIENTE.AutoSize = true;
            this.lblCLIENTE.Location = new System.Drawing.Point(16, 56);
            this.lblCLIENTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCLIENTE.Name = "lblCLIENTE";
            this.lblCLIENTE.Size = new System.Drawing.Size(55, 17);
            this.lblCLIENTE.TabIndex = 26;
            this.lblCLIENTE.Text = "Cliente:";
            // 
            // dgvPRODUCTOS
            // 
            this.dgvPRODUCTOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTOS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvPRODUCTOS.Location = new System.Drawing.Point(16, 109);
            this.dgvPRODUCTOS.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPRODUCTOS.Name = "dgvPRODUCTOS";
            this.dgvPRODUCTOS.Size = new System.Drawing.Size(605, 256);
            this.dgvPRODUCTOS.TabIndex = 25;
            // 
            // btnBUSCARPRODUCTO
            // 
            this.btnBUSCARPRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCARPRODUCTO.Image")));
            this.btnBUSCARPRODUCTO.Location = new System.Drawing.Point(657, 109);
            this.btnBUSCARPRODUCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBUSCARPRODUCTO.Name = "btnBUSCARPRODUCTO";
            this.btnBUSCARPRODUCTO.Size = new System.Drawing.Size(372, 37);
            this.btnBUSCARPRODUCTO.TabIndex = 54;
            this.btnBUSCARPRODUCTO.Text = "Buscar Producto";
            this.btnBUSCARPRODUCTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCARPRODUCTO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnBUSCARPRODUCTO.Click += new System.EventHandler(this.btnBUSCARPRODUCTO_Click);
            // 
            // btnCONFIRMARPRODUCTO
            // 
            this.btnCONFIRMARPRODUCTO.Location = new System.Drawing.Point(211, 68);
            this.btnCONFIRMARPRODUCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCONFIRMARPRODUCTO.Name = "btnCONFIRMARPRODUCTO";
            this.btnCONFIRMARPRODUCTO.Size = new System.Drawing.Size(136, 37);
            this.btnCONFIRMARPRODUCTO.TabIndex = 55;
            this.btnCONFIRMARPRODUCTO.Text = "Agregar Producto";
            this.btnCONFIRMARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnCONFIRMARPRODUCTO.Click += new System.EventHandler(this.btnCONFIRMARPRODUCTO_Click);
            // 
            // btnELIMINARPRODUCTO
            // 
            this.btnELIMINARPRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINARPRODUCTO.Image")));
            this.btnELIMINARPRODUCTO.Location = new System.Drawing.Point(16, 381);
            this.btnELIMINARPRODUCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnELIMINARPRODUCTO.Name = "btnELIMINARPRODUCTO";
            this.btnELIMINARPRODUCTO.Size = new System.Drawing.Size(173, 37);
            this.btnELIMINARPRODUCTO.TabIndex = 56;
            this.btnELIMINARPRODUCTO.Text = "Eliminar Producto";
            this.btnELIMINARPRODUCTO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnELIMINARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnELIMINARPRODUCTO.Click += new System.EventHandler(this.btnELIMINARPRODUCTO_Click);
            // 
            // nudCANTIDADPRODUCTO
            // 
            this.nudCANTIDADPRODUCTO.Location = new System.Drawing.Point(92, 76);
            this.nudCANTIDADPRODUCTO.Margin = new System.Windows.Forms.Padding(4);
            this.nudCANTIDADPRODUCTO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCANTIDADPRODUCTO.Name = "nudCANTIDADPRODUCTO";
            this.nudCANTIDADPRODUCTO.Size = new System.Drawing.Size(93, 22);
            this.nudCANTIDADPRODUCTO.TabIndex = 58;
            this.nudCANTIDADPRODUCTO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCANTIDAD
            // 
            this.lblCANTIDAD.AutoSize = true;
            this.lblCANTIDAD.Location = new System.Drawing.Point(15, 79);
            this.lblCANTIDAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCANTIDAD.Name = "lblCANTIDAD";
            this.lblCANTIDAD.Size = new System.Drawing.Size(68, 17);
            this.lblCANTIDAD.TabIndex = 57;
            this.lblCANTIDAD.Text = "Cantidad:";
            // 
            // lblPRODUCTO
            // 
            this.lblPRODUCTO.AutoSize = true;
            this.lblPRODUCTO.Location = new System.Drawing.Point(15, 28);
            this.lblPRODUCTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPRODUCTO.Name = "lblPRODUCTO";
            this.lblPRODUCTO.Size = new System.Drawing.Size(119, 17);
            this.lblPRODUCTO.TabIndex = 64;
            this.lblPRODUCTO.Text = "Nombre Producto";
            // 
            // pPRODUCTO
            // 
            this.pPRODUCTO.BackColor = System.Drawing.SystemColors.GrayText;
            this.pPRODUCTO.Controls.Add(this.btnCONFIRMARPRODUCTO);
            this.pPRODUCTO.Controls.Add(this.lblPRODUCTO);
            this.pPRODUCTO.Controls.Add(this.lblCANTIDAD);
            this.pPRODUCTO.Controls.Add(this.nudCANTIDADPRODUCTO);
            this.pPRODUCTO.Location = new System.Drawing.Point(657, 152);
            this.pPRODUCTO.Margin = new System.Windows.Forms.Padding(4);
            this.pPRODUCTO.Name = "pPRODUCTO";
            this.pPRODUCTO.Size = new System.Drawing.Size(372, 117);
            this.pPRODUCTO.TabIndex = 65;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(774, 534);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(259, 43);
            this.btnCANCELAR.TabIndex = 68;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(774, 467);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(259, 63);
            this.btnGUARDAR.TabIndex = 67;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblCLIENTENOMBRE
            // 
            this.lblCLIENTENOMBRE.AutoSize = true;
            this.lblCLIENTENOMBRE.Location = new System.Drawing.Point(78, 56);
            this.lblCLIENTENOMBRE.Name = "lblCLIENTENOMBRE";
            this.lblCLIENTENOMBRE.Size = new System.Drawing.Size(0, 17);
            this.lblCLIENTENOMBRE.TabIndex = 75;
            // 
            // btnCLIENTE
            // 
            this.btnCLIENTE.Location = new System.Drawing.Point(657, 56);
            this.btnCLIENTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCLIENTE.Name = "btnCLIENTE";
            this.btnCLIENTE.Size = new System.Drawing.Size(372, 33);
            this.btnCLIENTE.TabIndex = 74;
            this.btnCLIENTE.Text = "Seleccionar Cliente";
            this.btnCLIENTE.UseVisualStyleBackColor = true;
            this.btnCLIENTE.Click += new System.EventHandler(this.btnCLIENTE_Click);
            // 
            // lblFECHA
            // 
            this.lblFECHA.AutoSize = true;
            this.lblFECHA.Location = new System.Drawing.Point(16, 27);
            this.lblFECHA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFECHA.Name = "lblFECHA";
            this.lblFECHA.Size = new System.Drawing.Size(51, 17);
            this.lblFECHA.TabIndex = 28;
            this.lblFECHA.Text = "Fecha:";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFECHA.Location = new System.Drawing.Point(75, 27);
            this.dtpFECHA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(361, 22);
            this.dtpFECHA.TabIndex = 29;
            // 
            // btnPAGOS
            // 
            this.btnPAGOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPAGOS.Image")));
            this.btnPAGOS.Location = new System.Drawing.Point(19, 446);
            this.btnPAGOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPAGOS.Name = "btnPAGOS";
            this.btnPAGOS.Size = new System.Drawing.Size(259, 110);
            this.btnPAGOS.TabIndex = 76;
            this.btnPAGOS.Text = "Agregar Pagos";
            this.btnPAGOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPAGOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPAGOS.UseVisualStyleBackColor = true;
            this.btnPAGOS.Click += new System.EventHandler(this.btnPAGOS_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 588);
            this.Controls.Add(this.btnPAGOS);
            this.Controls.Add(this.lblCLIENTENOMBRE);
            this.Controls.Add(this.btnCLIENTE);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.pPRODUCTO);
            this.Controls.Add(this.btnELIMINARPRODUCTO);
            this.Controls.Add(this.btnBUSCARPRODUCTO);
            this.Controls.Add(this.lblPRODUCTOS);
            this.Controls.Add(this.lblTOTALDETALLE);
            this.Controls.Add(this.txtTOTALPRODUCTOS);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.lblFECHA);
            this.Controls.Add(this.lblCLIENTE);
            this.Controls.Add(this.dgvPRODUCTOS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenta";
            this.Text = "Sistema de Libreria - VENTA";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCANTIDADPRODUCTO)).EndInit();
            this.pPRODUCTO.ResumeLayout(false);
            this.pPRODUCTO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPRODUCTOS;
        private System.Windows.Forms.Label lblTOTALDETALLE;
        private System.Windows.Forms.TextBox txtTOTALPRODUCTOS;
        private System.Windows.Forms.Label lblCLIENTE;
        private System.Windows.Forms.DataGridView dgvPRODUCTOS;
        private System.Windows.Forms.Button btnBUSCARPRODUCTO;
        private System.Windows.Forms.Button btnCONFIRMARPRODUCTO;
        private System.Windows.Forms.Button btnELIMINARPRODUCTO;
        private System.Windows.Forms.NumericUpDown nudCANTIDADPRODUCTO;
        private System.Windows.Forms.Label lblCANTIDAD;
        private System.Windows.Forms.Label lblPRODUCTO;
        private System.Windows.Forms.Panel pPRODUCTO;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblCLIENTENOMBRE;
        private System.Windows.Forms.Button btnCLIENTE;
        private System.Windows.Forms.Label lblFECHA;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Button btnPAGOS;
    }
}