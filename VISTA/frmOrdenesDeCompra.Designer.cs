namespace VISTA
{
    partial class frmOrdenesDeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenesDeCompra));
            this.txtORDEN = new System.Windows.Forms.TextBox();
            this.lblORDEN = new System.Windows.Forms.Label();
            this.btnTODAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvORDENES = new System.Windows.Forms.DataGridView();
            this.btnSELECCIONAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENES)).BeginInit();
            this.SuspendLayout();
            // 
            // txtORDEN
            // 
            this.txtORDEN.Location = new System.Drawing.Point(497, 29);
            this.txtORDEN.Margin = new System.Windows.Forms.Padding(4);
            this.txtORDEN.Name = "txtORDEN";
            this.txtORDEN.Size = new System.Drawing.Size(265, 22);
            this.txtORDEN.TabIndex = 79;
            // 
            // lblORDEN
            // 
            this.lblORDEN.Location = new System.Drawing.Point(434, 26);
            this.lblORDEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblORDEN.Name = "lblORDEN";
            this.lblORDEN.Size = new System.Drawing.Size(55, 25);
            this.lblORDEN.TabIndex = 78;
            this.lblORDEN.Text = "Filtrar:";
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(770, 62);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(128, 25);
            this.btnTODAS.TabIndex = 77;
            this.btnTODAS.Text = "Ver todas";
            this.btnTODAS.UseVisualStyleBackColor = true;
            this.btnTODAS.Click += new System.EventHandler(this.btnTODAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(769, 26);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(128, 25);
            this.btnBUSCAR.TabIndex = 76;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.Location = new System.Drawing.Point(369, 502);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(259, 63);
            this.btnCONSULTAR.TabIndex = 75;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(638, 675);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(259, 43);
            this.btnSALIR.TabIndex = 74;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(15, 502);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(259, 63);
            this.btnAGREGAR.TabIndex = 73;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvORDENES
            // 
            this.dgvORDENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDENES.Location = new System.Drawing.Point(15, 102);
            this.dgvORDENES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvORDENES.Name = "dgvORDENES";
            this.dgvORDENES.RowTemplate.Height = 24;
            this.dgvORDENES.Size = new System.Drawing.Size(883, 368);
            this.dgvORDENES.TabIndex = 72;
            // 
            // btnSELECCIONAR
            // 
            this.btnSELECCIONAR.Location = new System.Drawing.Point(369, 590);
            this.btnSELECCIONAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSELECCIONAR.Name = "btnSELECCIONAR";
            this.btnSELECCIONAR.Size = new System.Drawing.Size(259, 63);
            this.btnSELECCIONAR.TabIndex = 80;
            this.btnSELECCIONAR.Text = "Seleccionar";
            this.btnSELECCIONAR.UseVisualStyleBackColor = true;
            this.btnSELECCIONAR.Click += new System.EventHandler(this.btnSELECCIONAR_Click);
            // 
            // frmOrdenesDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 743);
            this.Controls.Add(this.btnSELECCIONAR);
            this.Controls.Add(this.txtORDEN);
            this.Controls.Add(this.lblORDEN);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvORDENES);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrdenesDeCompra";
            this.Text = "Sistema de Libreria - ORDENES DE COMPRA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtORDEN;
        private System.Windows.Forms.Label lblORDEN;
        private System.Windows.Forms.Button btnTODAS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvORDENES;
        private System.Windows.Forms.Button btnSELECCIONAR;
    }
}