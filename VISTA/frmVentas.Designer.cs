namespace VISTA
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvVENTAS = new System.Windows.Forms.DataGridView();
            this.btnTODAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.lblCLIENTE = new System.Windows.Forms.Label();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.Location = new System.Drawing.Point(325, 455);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(259, 63);
            this.btnCONSULTAR.TabIndex = 58;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(639, 552);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(259, 43);
            this.btnSALIR.TabIndex = 55;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(15, 455);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(259, 63);
            this.btnAGREGAR.TabIndex = 53;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvVENTAS
            // 
            this.dgvVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVENTAS.Location = new System.Drawing.Point(15, 98);
            this.dgvVENTAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVENTAS.Name = "dgvVENTAS";
            this.dgvVENTAS.RowTemplate.Height = 24;
            this.dgvVENTAS.Size = new System.Drawing.Size(883, 342);
            this.dgvVENTAS.TabIndex = 52;
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(769, 62);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(128, 25);
            this.btnTODAS.TabIndex = 64;
            this.btnTODAS.Text = "Ver todas";
            this.btnTODAS.UseVisualStyleBackColor = true;
            this.btnTODAS.Click += new System.EventHandler(this.btnTODAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(769, 28);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(128, 25);
            this.btnBUSCAR.TabIndex = 62;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // lblCLIENTE
            // 
            this.lblCLIENTE.AutoSize = true;
            this.lblCLIENTE.Location = new System.Drawing.Point(441, 32);
            this.lblCLIENTE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCLIENTE.Name = "lblCLIENTE";
            this.lblCLIENTE.Size = new System.Drawing.Size(48, 17);
            this.lblCLIENTE.TabIndex = 68;
            this.lblCLIENTE.Text = "Filtrar:";
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Location = new System.Drawing.Point(497, 29);
            this.txtCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(265, 22);
            this.txtCLIENTE.TabIndex = 71;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 606);
            this.Controls.Add(this.txtCLIENTE);
            this.Controls.Add(this.lblCLIENTE);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvVENTAS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.Text = "Sistema de Libreria - VENTAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvVENTAS;
        private System.Windows.Forms.Button btnTODAS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label lblCLIENTE;
        private System.Windows.Forms.TextBox txtCLIENTE;
    }
}