namespace VISTA
{
    partial class frmPagos
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
            this.btnELIMINARPAGO = new System.Windows.Forms.Button();
            this.btnAGREGARPAGO = new System.Windows.Forms.Button();
            this.lblPAGOS = new System.Windows.Forms.Label();
            this.lblTOTALPAGOS = new System.Windows.Forms.Label();
            this.txtTOTALPAGOS = new System.Windows.Forms.TextBox();
            this.dgvPAGOS = new System.Windows.Forms.DataGridView();
            this.btnCERRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAGOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnELIMINARPAGO
            // 
            this.btnELIMINARPAGO.Location = new System.Drawing.Point(131, 164);
            this.btnELIMINARPAGO.Margin = new System.Windows.Forms.Padding(2);
            this.btnELIMINARPAGO.Name = "btnELIMINARPAGO";
            this.btnELIMINARPAGO.Size = new System.Drawing.Size(116, 30);
            this.btnELIMINARPAGO.TabIndex = 72;
            this.btnELIMINARPAGO.Text = "Eliminar Pago";
            this.btnELIMINARPAGO.UseVisualStyleBackColor = true;
            this.btnELIMINARPAGO.Click += new System.EventHandler(this.btnELIMINARPAGO_Click);
            // 
            // btnAGREGARPAGO
            // 
            this.btnAGREGARPAGO.Location = new System.Drawing.Point(11, 164);
            this.btnAGREGARPAGO.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGARPAGO.Name = "btnAGREGARPAGO";
            this.btnAGREGARPAGO.Size = new System.Drawing.Size(116, 30);
            this.btnAGREGARPAGO.TabIndex = 71;
            this.btnAGREGARPAGO.Text = "Agregar Pago";
            this.btnAGREGARPAGO.UseVisualStyleBackColor = true;
            this.btnAGREGARPAGO.Click += new System.EventHandler(this.btnAGREGARPAGO_Click);
            // 
            // lblPAGOS
            // 
            this.lblPAGOS.AutoSize = true;
            this.lblPAGOS.Location = new System.Drawing.Point(12, 13);
            this.lblPAGOS.Name = "lblPAGOS";
            this.lblPAGOS.Size = new System.Drawing.Size(40, 13);
            this.lblPAGOS.TabIndex = 70;
            this.lblPAGOS.Text = "Pagos:";
            // 
            // lblTOTALPAGOS
            // 
            this.lblTOTALPAGOS.AutoSize = true;
            this.lblTOTALPAGOS.Location = new System.Drawing.Point(408, 168);
            this.lblTOTALPAGOS.Name = "lblTOTALPAGOS";
            this.lblTOTALPAGOS.Size = new System.Drawing.Size(45, 13);
            this.lblTOTALPAGOS.TabIndex = 69;
            this.lblTOTALPAGOS.Text = "TOTAL:";
            // 
            // txtTOTALPAGOS
            // 
            this.txtTOTALPAGOS.Location = new System.Drawing.Point(472, 165);
            this.txtTOTALPAGOS.Name = "txtTOTALPAGOS";
            this.txtTOTALPAGOS.Size = new System.Drawing.Size(100, 20);
            this.txtTOTALPAGOS.TabIndex = 68;
            // 
            // dgvPAGOS
            // 
            this.dgvPAGOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPAGOS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvPAGOS.Location = new System.Drawing.Point(12, 29);
            this.dgvPAGOS.Name = "dgvPAGOS";
            this.dgvPAGOS.Size = new System.Drawing.Size(560, 130);
            this.dgvPAGOS.TabIndex = 67;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(251, 165);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(116, 30);
            this.btnCERRAR.TabIndex = 73;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 216);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnELIMINARPAGO);
            this.Controls.Add(this.btnAGREGARPAGO);
            this.Controls.Add(this.lblPAGOS);
            this.Controls.Add(this.lblTOTALPAGOS);
            this.Controls.Add(this.txtTOTALPAGOS);
            this.Controls.Add(this.dgvPAGOS);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAGOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnELIMINARPAGO;
        private System.Windows.Forms.Button btnAGREGARPAGO;
        private System.Windows.Forms.Label lblPAGOS;
        private System.Windows.Forms.Label lblTOTALPAGOS;
        private System.Windows.Forms.TextBox txtTOTALPAGOS;
        private System.Windows.Forms.DataGridView dgvPAGOS;
        private System.Windows.Forms.Button btnCERRAR;
    }
}