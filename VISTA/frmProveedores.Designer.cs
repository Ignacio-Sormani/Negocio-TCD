namespace VISTA
{
    partial class frmProveedores
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
            this.btnSELECCIONAR = new System.Windows.Forms.Button();
            this.lblPROVEEDOR = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvPROVEEDORES = new System.Windows.Forms.DataGridView();
            this.btnTODOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROVEEDORES)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSELECCIONAR
            // 
            this.btnSELECCIONAR.Location = new System.Drawing.Point(233, 384);
            this.btnSELECCIONAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSELECCIONAR.Name = "btnSELECCIONAR";
            this.btnSELECCIONAR.Size = new System.Drawing.Size(194, 35);
            this.btnSELECCIONAR.TabIndex = 33;
            this.btnSELECCIONAR.Text = "Seleccionar";
            this.btnSELECCIONAR.UseVisualStyleBackColor = true;
            this.btnSELECCIONAR.Click += new System.EventHandler(this.btnSELECCIONAR_Click);
            // 
            // lblPROVEEDOR
            // 
            this.lblPROVEEDOR.Location = new System.Drawing.Point(34, 15);
            this.lblPROVEEDOR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPROVEEDOR.Name = "lblPROVEEDOR";
            this.lblPROVEEDOR.Size = new System.Drawing.Size(102, 43);
            this.lblPROVEEDOR.TabIndex = 32;
            this.lblPROVEEDOR.Text = "Codigo, nombre o cuit del proveedor:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(233, 344);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 31;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(344, 38);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(83, 20);
            this.btnBUSCAR.TabIndex = 30;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(233, 424);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 28;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(156, 15);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(168, 20);
            this.txtBUSCAR.TabIndex = 29;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(13, 384);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(194, 35);
            this.btnMODIFICAR.TabIndex = 27;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 344);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 26;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvPROVEEDORES
            // 
            this.dgvPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPROVEEDORES.Location = new System.Drawing.Point(13, 62);
            this.dgvPROVEEDORES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPROVEEDORES.Name = "dgvPROVEEDORES";
            this.dgvPROVEEDORES.RowTemplate.Height = 24;
            this.dgvPROVEEDORES.Size = new System.Drawing.Size(414, 278);
            this.dgvPROVEEDORES.TabIndex = 25;
            // 
            // btnTODOS
            // 
            this.btnTODOS.Location = new System.Drawing.Point(344, 11);
            this.btnTODOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTODOS.Name = "btnTODOS";
            this.btnTODOS.Size = new System.Drawing.Size(83, 20);
            this.btnTODOS.TabIndex = 34;
            this.btnTODOS.Text = "Ver Todos";
            this.btnTODOS.UseVisualStyleBackColor = true;
            this.btnTODOS.Click += new System.EventHandler(this.btnTODOS_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 470);
            this.Controls.Add(this.btnTODOS);
            this.Controls.Add(this.btnSELECCIONAR);
            this.Controls.Add(this.lblPROVEEDOR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvPROVEEDORES);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROVEEDORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSELECCIONAR;
        private System.Windows.Forms.Label lblPROVEEDOR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvPROVEEDORES;
        private System.Windows.Forms.Button btnTODOS;
    }
}