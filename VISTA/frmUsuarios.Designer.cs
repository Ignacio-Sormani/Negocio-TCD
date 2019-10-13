namespace VISTA
{
    partial class frmUsuarios
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
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvUSUARIOS = new System.Windows.Forms.DataGridView();
            this.btnCAMBIARESTADO = new System.Windows.Forms.Button();
            this.btnTODAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(14, 11);
            this.lblUSUARIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(46, 13);
            this.lblUSUARIO.TabIndex = 41;
            this.lblUSUARIO.Text = "Usuario:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(233, 320);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 40;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(246, 11);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(82, 20);
            this.btnBUSCAR.TabIndex = 39;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(233, 400);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 37;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(73, 11);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(168, 20);
            this.txtBUSCAR.TabIndex = 38;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(13, 360);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(194, 35);
            this.btnMODIFICAR.TabIndex = 36;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 320);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 35;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvUSUARIOS
            // 
            this.dgvUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSUARIOS.Location = new System.Drawing.Point(13, 37);
            this.dgvUSUARIOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUSUARIOS.Name = "dgvUSUARIOS";
            this.dgvUSUARIOS.RowTemplate.Height = 24;
            this.dgvUSUARIOS.Size = new System.Drawing.Size(414, 278);
            this.dgvUSUARIOS.TabIndex = 34;
            // 
            // btnCAMBIARESTADO
            // 
            this.btnCAMBIARESTADO.Location = new System.Drawing.Point(233, 360);
            this.btnCAMBIARESTADO.Margin = new System.Windows.Forms.Padding(2);
            this.btnCAMBIARESTADO.Name = "btnCAMBIARESTADO";
            this.btnCAMBIARESTADO.Size = new System.Drawing.Size(194, 35);
            this.btnCAMBIARESTADO.TabIndex = 42;
            this.btnCAMBIARESTADO.Text = "Cambiar Estado (Activo/Inactivo)";
            this.btnCAMBIARESTADO.UseVisualStyleBackColor = true;
            this.btnCAMBIARESTADO.Click += new System.EventHandler(this.btnCAMBIARESTADO_Click);
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(331, 11);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(96, 20);
            this.btnTODAS.TabIndex = 65;
            this.btnTODAS.Text = "Ver todas";
            this.btnTODAS.UseVisualStyleBackColor = true;
            this.btnTODAS.Click += new System.EventHandler(this.btnTODAS_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 445);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnCAMBIARESTADO);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvUSUARIOS);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvUSUARIOS;
        private System.Windows.Forms.Button btnCAMBIARESTADO;
        private System.Windows.Forms.Button btnTODAS;
    }
}