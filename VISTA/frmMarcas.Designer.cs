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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvMARCAS = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.lblMARCA = new System.Windows.Forms.Label();
            this.btnSELECCIONAR = new System.Windows.Forms.Button();
            this.btnTODAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMARCAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(436, 21);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(128, 25);
            this.btnBUSCAR.TabIndex = 12;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(311, 632);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(259, 43);
            this.btnSALIR.TabIndex = 10;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(206, 22);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(223, 22);
            this.txtBUSCAR.TabIndex = 11;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICAR.Image")));
            this.btnMODIFICAR.Location = new System.Drawing.Point(311, 473);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(259, 63);
            this.btnMODIFICAR.TabIndex = 9;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(27, 473);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(259, 63);
            this.btnAGREGAR.TabIndex = 8;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvMARCAS
            // 
            this.dgvMARCAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMARCAS.Location = new System.Drawing.Point(27, 88);
            this.dgvMARCAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMARCAS.Name = "dgvMARCAS";
            this.dgvMARCAS.RowTemplate.Height = 24;
            this.dgvMARCAS.Size = new System.Drawing.Size(543, 372);
            this.dgvMARCAS.TabIndex = 7;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.Location = new System.Drawing.Point(27, 551);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(259, 63);
            this.btnCONSULTAR.TabIndex = 13;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // lblMARCA
            // 
            this.lblMARCA.AutoSize = true;
            this.lblMARCA.Location = new System.Drawing.Point(149, 25);
            this.lblMARCA.Name = "lblMARCA";
            this.lblMARCA.Size = new System.Drawing.Size(48, 17);
            this.lblMARCA.TabIndex = 14;
            this.lblMARCA.Text = "Filtrar:";
            // 
            // btnSELECCIONAR
            // 
            this.btnSELECCIONAR.Location = new System.Drawing.Point(311, 551);
            this.btnSELECCIONAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSELECCIONAR.Name = "btnSELECCIONAR";
            this.btnSELECCIONAR.Size = new System.Drawing.Size(259, 63);
            this.btnSELECCIONAR.TabIndex = 15;
            this.btnSELECCIONAR.Text = "Seleccionar";
            this.btnSELECCIONAR.UseVisualStyleBackColor = true;
            this.btnSELECCIONAR.Click += new System.EventHandler(this.btnSELECCIONAR_Click);
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(436, 51);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(128, 25);
            this.btnTODAS.TabIndex = 16;
            this.btnTODAS.Text = "Ver todas";
            this.btnTODAS.UseVisualStyleBackColor = true;
            this.btnTODAS.Click += new System.EventHandler(this.btnTODAS_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 702);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnSELECCIONAR);
            this.Controls.Add(this.lblMARCA);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvMARCAS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMarcas";
            this.Text = "Sistema de Libreria - MARCAS";
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
        private System.Windows.Forms.Button btnTODAS;
    }
}