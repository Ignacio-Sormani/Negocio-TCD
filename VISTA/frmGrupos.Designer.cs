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
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.lblGRUPO = new System.Windows.Forms.Label();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvGRUPOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(233, 360);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(194, 35);
            this.btnELIMINAR.TabIndex = 51;
            this.btnELIMINAR.Text = "Eliminar (desactivar)";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // lblGRUPO
            // 
            this.lblGRUPO.AutoSize = true;
            this.lblGRUPO.Location = new System.Drawing.Point(65, 10);
            this.lblGRUPO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGRUPO.Name = "lblGRUPO";
            this.lblGRUPO.Size = new System.Drawing.Size(39, 13);
            this.lblGRUPO.TabIndex = 50;
            this.lblGRUPO.Text = "Grupo:";
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(233, 320);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 49;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(297, 10);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(130, 20);
            this.btnBUSCAR.TabIndex = 48;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(233, 400);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 46;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(124, 10);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(168, 20);
            this.txtBUSCAR.TabIndex = 47;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(13, 360);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(194, 35);
            this.btnMODIFICAR.TabIndex = 45;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 320);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 44;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            // 
            // dgvGRUPOS
            // 
            this.dgvGRUPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRUPOS.Location = new System.Drawing.Point(13, 37);
            this.dgvGRUPOS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGRUPOS.Name = "dgvGRUPOS";
            this.dgvGRUPOS.RowTemplate.Height = 24;
            this.dgvGRUPOS.Size = new System.Drawing.Size(414, 278);
            this.dgvGRUPOS.TabIndex = 43;
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 445);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.lblGRUPO);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvGRUPOS);
            this.Name = "frmGrupos";
            this.Text = "frmGrupos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Label lblGRUPO;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvGRUPOS;
    }
}