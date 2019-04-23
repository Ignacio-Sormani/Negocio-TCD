namespace VISTA
{
    partial class frmCategorias
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
            this.lblCATEGORIA = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvCATEGORIAS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSELECCIONAR
            // 
            this.btnSELECCIONAR.Location = new System.Drawing.Point(233, 366);
            this.btnSELECCIONAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSELECCIONAR.Name = "btnSELECCIONAR";
            this.btnSELECCIONAR.Size = new System.Drawing.Size(194, 35);
            this.btnSELECCIONAR.TabIndex = 24;
            this.btnSELECCIONAR.Text = "Seleccionar";
            this.btnSELECCIONAR.UseVisualStyleBackColor = true;
            // 
            // lblCATEGORIA
            // 
            this.lblCATEGORIA.AutoSize = true;
            this.lblCATEGORIA.Location = new System.Drawing.Point(65, 16);
            this.lblCATEGORIA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCATEGORIA.Name = "lblCATEGORIA";
            this.lblCATEGORIA.Size = new System.Drawing.Size(55, 13);
            this.lblCATEGORIA.TabIndex = 23;
            this.lblCATEGORIA.Text = "Categoria:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(233, 326);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 22;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(297, 16);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(130, 20);
            this.btnBUSCAR.TabIndex = 21;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(233, 406);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 19;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(124, 16);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(168, 20);
            this.txtBUSCAR.TabIndex = 20;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(13, 366);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(194, 35);
            this.btnMODIFICAR.TabIndex = 18;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 326);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 17;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvCATEGORIAS
            // 
            this.dgvCATEGORIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCATEGORIAS.Location = new System.Drawing.Point(13, 43);
            this.dgvCATEGORIAS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCATEGORIAS.Name = "dgvCATEGORIAS";
            this.dgvCATEGORIAS.RowTemplate.Height = 24;
            this.dgvCATEGORIAS.Size = new System.Drawing.Size(414, 278);
            this.dgvCATEGORIAS.TabIndex = 16;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.btnSELECCIONAR);
            this.Controls.Add(this.lblCATEGORIA);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvCATEGORIAS);
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSELECCIONAR;
        private System.Windows.Forms.Label lblCATEGORIA;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvCATEGORIAS;
    }
}