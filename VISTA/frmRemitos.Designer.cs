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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemitos));
            this.txtREMITO = new System.Windows.Forms.TextBox();
            this.lblREMITO = new System.Windows.Forms.Label();
            this.btnTODAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvREMITOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvREMITOS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtREMITO
            // 
            this.txtREMITO.Location = new System.Drawing.Point(497, 29);
            this.txtREMITO.Margin = new System.Windows.Forms.Padding(4);
            this.txtREMITO.Name = "txtREMITO";
            this.txtREMITO.Size = new System.Drawing.Size(265, 22);
            this.txtREMITO.TabIndex = 87;
            // 
            // lblREMITO
            // 
            this.lblREMITO.AutoSize = true;
            this.lblREMITO.Location = new System.Drawing.Point(441, 32);
            this.lblREMITO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblREMITO.Name = "lblREMITO";
            this.lblREMITO.Size = new System.Drawing.Size(48, 17);
            this.lblREMITO.TabIndex = 86;
            this.lblREMITO.Text = "Filtrar:";
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(769, 64);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(128, 25);
            this.btnTODAS.TabIndex = 85;
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
            this.btnBUSCAR.TabIndex = 84;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.Location = new System.Drawing.Point(325, 468);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(259, 66);
            this.btnCONSULTAR.TabIndex = 83;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(638, 556);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(259, 43);
            this.btnSALIR.TabIndex = 82;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(15, 468);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(259, 66);
            this.btnAGREGAR.TabIndex = 81;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvREMITOS
            // 
            this.dgvREMITOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvREMITOS.Location = new System.Drawing.Point(15, 102);
            this.dgvREMITOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvREMITOS.Name = "dgvREMITOS";
            this.dgvREMITOS.RowTemplate.Height = 24;
            this.dgvREMITOS.Size = new System.Drawing.Size(883, 342);
            this.dgvREMITOS.TabIndex = 80;
            // 
            // frmRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 610);
            this.Controls.Add(this.txtREMITO);
            this.Controls.Add(this.lblREMITO);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvREMITOS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRemitos";
            this.Text = "Sistema de Libreria - REMITOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvREMITOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtREMITO;
        private System.Windows.Forms.Label lblREMITO;
        private System.Windows.Forms.Button btnTODAS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvREMITOS;
    }
}