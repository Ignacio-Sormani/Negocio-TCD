namespace VISTA
{
    partial class frmMarcas
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
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvMARCAS = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.lblMARCA = new System.Windows.Forms.Label();
            this.btnSELECCIONAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMARCAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(293, 15);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(130, 20);
            this.btnBUSCAR.TabIndex = 12;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(229, 405);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 10;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(120, 15);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(168, 20);
            this.txtBUSCAR.TabIndex = 11;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(9, 365);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(194, 35);
            this.btnMODIFICAR.TabIndex = 9;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(9, 325);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 8;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvMARCAS
            // 
            this.dgvMARCAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMARCAS.Location = new System.Drawing.Point(9, 42);
            this.dgvMARCAS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMARCAS.Name = "dgvMARCAS";
            this.dgvMARCAS.RowTemplate.Height = 24;
            this.dgvMARCAS.Size = new System.Drawing.Size(414, 278);
            this.dgvMARCAS.TabIndex = 7;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(229, 325);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 13;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // lblMARCA
            // 
            this.lblMARCA.AutoSize = true;
            this.lblMARCA.Location = new System.Drawing.Point(61, 15);
            this.lblMARCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMARCA.Name = "lblMARCA";
            this.lblMARCA.Size = new System.Drawing.Size(40, 13);
            this.lblMARCA.TabIndex = 14;
            this.lblMARCA.Text = "Marca:";
            // 
            // btnSELECCIONAR
            // 
            this.btnSELECCIONAR.Location = new System.Drawing.Point(229, 365);
            this.btnSELECCIONAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSELECCIONAR.Name = "btnSELECCIONAR";
            this.btnSELECCIONAR.Size = new System.Drawing.Size(194, 35);
            this.btnSELECCIONAR.TabIndex = 15;
            this.btnSELECCIONAR.Text = "Seleccionar";
            this.btnSELECCIONAR.UseVisualStyleBackColor = true;
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.btnSELECCIONAR);
            this.Controls.Add(this.lblMARCA);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvMARCAS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMarcas";
            this.Text = "Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMARCAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvMARCAS;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Label lblMARCA;
        private System.Windows.Forms.Button btnSELECCIONAR;
    }
}