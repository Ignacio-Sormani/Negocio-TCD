namespace VISTA
{
    partial class frmRemitos
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
            this.txtPROVEEDOR = new System.Windows.Forms.TextBox();
            this.lblPROVEEDOR = new System.Windows.Forms.Label();
            this.btnTODAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvREMITOS = new System.Windows.Forms.DataGridView();
            this.txtORDEN = new System.Windows.Forms.TextBox();
            this.lblORDEN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvREMITOS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPROVEEDOR
            // 
            this.txtPROVEEDOR.Location = new System.Drawing.Point(195, 18);
            this.txtPROVEEDOR.Name = "txtPROVEEDOR";
            this.txtPROVEEDOR.Size = new System.Drawing.Size(200, 20);
            this.txtPROVEEDOR.TabIndex = 87;
            // 
            // lblPROVEEDOR
            // 
            this.lblPROVEEDOR.AutoSize = true;
            this.lblPROVEEDOR.Location = new System.Drawing.Point(44, 21);
            this.lblPROVEEDOR.Name = "lblPROVEEDOR";
            this.lblPROVEEDOR.Size = new System.Drawing.Size(99, 13);
            this.lblPROVEEDOR.TabIndex = 86;
            this.lblPROVEEDOR.Text = "Nombre Proveedor:";
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(577, 42);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(96, 20);
            this.btnTODAS.TabIndex = 85;
            this.btnTODAS.Text = "Ver todas";
            this.btnTODAS.UseVisualStyleBackColor = true;
            this.btnTODAS.Click += new System.EventHandler(this.btnTODAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(577, 14);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(96, 20);
            this.btnBUSCAR.TabIndex = 84;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(244, 380);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 83;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(479, 380);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 82;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(11, 380);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 81;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvREMITOS
            // 
            this.dgvREMITOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvREMITOS.Location = new System.Drawing.Point(11, 83);
            this.dgvREMITOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvREMITOS.Name = "dgvREMITOS";
            this.dgvREMITOS.RowTemplate.Height = 24;
            this.dgvREMITOS.Size = new System.Drawing.Size(662, 278);
            this.dgvREMITOS.TabIndex = 80;
            // 
            // txtORDEN
            // 
            this.txtORDEN.Location = new System.Drawing.Point(195, 44);
            this.txtORDEN.Name = "txtORDEN";
            this.txtORDEN.Size = new System.Drawing.Size(200, 20);
            this.txtORDEN.TabIndex = 89;
            // 
            // lblORDEN
            // 
            this.lblORDEN.AutoSize = true;
            this.lblORDEN.Location = new System.Drawing.Point(44, 47);
            this.lblORDEN.Name = "lblORDEN";
            this.lblORDEN.Size = new System.Drawing.Size(133, 13);
            this.lblORDEN.TabIndex = 88;
            this.lblORDEN.Text = "Numero Orden de Compra:";
            // 
            // frmRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.txtORDEN);
            this.Controls.Add(this.lblORDEN);
            this.Controls.Add(this.txtPROVEEDOR);
            this.Controls.Add(this.lblPROVEEDOR);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvREMITOS);
            this.Name = "frmRemitos";
            this.Text = "frmRemitos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvREMITOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPROVEEDOR;
        private System.Windows.Forms.Label lblPROVEEDOR;
        private System.Windows.Forms.Button btnTODAS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvREMITOS;
        private System.Windows.Forms.TextBox txtORDEN;
        private System.Windows.Forms.Label lblORDEN;
    }
}