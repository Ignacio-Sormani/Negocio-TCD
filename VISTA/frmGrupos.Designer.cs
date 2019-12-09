namespace VISTA
{
    partial class frmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupos));
            this.btnCAMBIARESTADO = new System.Windows.Forms.Button();
            this.lblGRUPO = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvGRUPOS = new System.Windows.Forms.DataGridView();
            this.btnTODOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCAMBIARESTADO
            // 
            this.btnCAMBIARESTADO.Location = new System.Drawing.Point(311, 526);
            this.btnCAMBIARESTADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAMBIARESTADO.Name = "btnCAMBIARESTADO";
            this.btnCAMBIARESTADO.Size = new System.Drawing.Size(259, 63);
            this.btnCAMBIARESTADO.TabIndex = 51;
            this.btnCAMBIARESTADO.Text = "Cambiar Estado (Activo/Inactivo)";
            this.btnCAMBIARESTADO.UseVisualStyleBackColor = true;
            this.btnCAMBIARESTADO.Click += new System.EventHandler(this.btnCAMBIARESTADO_Click);
            // 
            // lblGRUPO
            // 
            this.lblGRUPO.AutoSize = true;
            this.lblGRUPO.Location = new System.Drawing.Point(17, 12);
            this.lblGRUPO.Name = "lblGRUPO";
            this.lblGRUPO.Size = new System.Drawing.Size(52, 17);
            this.lblGRUPO.TabIndex = 50;
            this.lblGRUPO.Text = "Grupo:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.Location = new System.Drawing.Point(17, 526);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(259, 63);
            this.btnCONSULTAR.TabIndex = 49;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(325, 12);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(125, 25);
            this.btnBUSCAR.TabIndex = 48;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(313, 626);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(259, 43);
            this.btnSALIR.TabIndex = 46;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(96, 12);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(223, 22);
            this.txtBUSCAR.TabIndex = 47;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICAR.Image")));
            this.btnMODIFICAR.Location = new System.Drawing.Point(313, 448);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(259, 63);
            this.btnMODIFICAR.TabIndex = 45;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.Location = new System.Drawing.Point(17, 448);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(259, 63);
            this.btnAGREGAR.TabIndex = 44;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvGRUPOS
            // 
            this.dgvGRUPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRUPOS.Location = new System.Drawing.Point(17, 46);
            this.dgvGRUPOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGRUPOS.Name = "dgvGRUPOS";
            this.dgvGRUPOS.RowTemplate.Height = 24;
            this.dgvGRUPOS.Size = new System.Drawing.Size(552, 380);
            this.dgvGRUPOS.TabIndex = 43;
            // 
            // btnTODOS
            // 
            this.btnTODOS.Location = new System.Drawing.Point(456, 12);
            this.btnTODOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTODOS.Name = "btnTODOS";
            this.btnTODOS.Size = new System.Drawing.Size(113, 25);
            this.btnTODOS.TabIndex = 52;
            this.btnTODOS.Text = "Ver todos";
            this.btnTODOS.UseVisualStyleBackColor = true;
            this.btnTODOS.Click += new System.EventHandler(this.btnTODOS_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 680);
            this.Controls.Add(this.btnTODOS);
            this.Controls.Add(this.btnCAMBIARESTADO);
            this.Controls.Add(this.lblGRUPO);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvGRUPOS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGrupos";
            this.Text = "Sistema de Libreria - GRUPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCAMBIARESTADO;
        private System.Windows.Forms.Label lblGRUPO;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvGRUPOS;
        private System.Windows.Forms.Button btnTODOS;
    }
}