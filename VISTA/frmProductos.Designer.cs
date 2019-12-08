namespace VISTA
{
    partial class frmProductos
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
            this.lblPRODUCTO = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSELECCIONAR
            // 
            this.btnSELECCIONAR.Location = new System.Drawing.Point(231, 413);
            this.btnSELECCIONAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSELECCIONAR.Name = "btnSELECCIONAR";
            this.btnSELECCIONAR.Size = new System.Drawing.Size(194, 35);
            this.btnSELECCIONAR.TabIndex = 33;
            this.btnSELECCIONAR.Text = "Seleccionar";
            this.btnSELECCIONAR.UseVisualStyleBackColor = true;
            this.btnSELECCIONAR.Click += new System.EventHandler(this.btnSELECCIONAR_Click);
            // 
            // lblPRODUCTO
            // 
            this.lblPRODUCTO.Location = new System.Drawing.Point(26, 20);
            this.lblPRODUCTO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPRODUCTO.Name = "lblPRODUCTO";
            this.lblPRODUCTO.Size = new System.Drawing.Size(101, 52);
            this.lblPRODUCTO.TabIndex = 32;
            this.lblPRODUCTO.Text = "Codigo , nombre y estado de producto, marca y categoria:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(231, 373);
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
            this.btnBUSCAR.Location = new System.Drawing.Point(329, 20);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(94, 20);
            this.btnBUSCAR.TabIndex = 30;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(231, 453);
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
            this.txtBUSCAR.Location = new System.Drawing.Point(168, 37);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(157, 20);
            this.txtBUSCAR.TabIndex = 29;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(11, 413);
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
            this.btnAGREGAR.Location = new System.Drawing.Point(11, 373);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 26;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvPRODUCTOS
            // 
            this.dgvPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTOS.Location = new System.Drawing.Point(11, 110);
            this.dgvPRODUCTOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPRODUCTOS.Name = "dgvPRODUCTOS";
            this.dgvPRODUCTOS.RowTemplate.Height = 24;
            this.dgvPRODUCTOS.Size = new System.Drawing.Size(414, 258);
            this.dgvPRODUCTOS.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 20);
            this.button1.TabIndex = 34;
            this.button1.Text = "Ver Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSELECCIONAR);
            this.Controls.Add(this.lblPRODUCTO);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvPRODUCTOS);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSELECCIONAR;
        private System.Windows.Forms.Label lblPRODUCTO;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvPRODUCTOS;
        private System.Windows.Forms.Button button1;
    }
}