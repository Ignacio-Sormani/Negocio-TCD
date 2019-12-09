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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
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
            this.btnELIMINARPAGO.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINARPAGO.Image")));
            this.btnELIMINARPAGO.Location = new System.Drawing.Point(175, 202);
            this.btnELIMINARPAGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnELIMINARPAGO.Name = "btnELIMINARPAGO";
            this.btnELIMINARPAGO.Size = new System.Drawing.Size(155, 66);
            this.btnELIMINARPAGO.TabIndex = 72;
            this.btnELIMINARPAGO.Text = "Eliminar Pago";
            this.btnELIMINARPAGO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINARPAGO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnELIMINARPAGO.UseVisualStyleBackColor = true;
            this.btnELIMINARPAGO.Click += new System.EventHandler(this.btnELIMINARPAGO_Click);
            // 
            // btnAGREGARPAGO
            // 
            this.btnAGREGARPAGO.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGARPAGO.Image")));
            this.btnAGREGARPAGO.Location = new System.Drawing.Point(15, 202);
            this.btnAGREGARPAGO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAGREGARPAGO.Name = "btnAGREGARPAGO";
            this.btnAGREGARPAGO.Size = new System.Drawing.Size(155, 66);
            this.btnAGREGARPAGO.TabIndex = 71;
            this.btnAGREGARPAGO.Text = "Agregar Pago";
            this.btnAGREGARPAGO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGARPAGO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAGREGARPAGO.UseVisualStyleBackColor = true;
            this.btnAGREGARPAGO.Click += new System.EventHandler(this.btnAGREGARPAGO_Click);
            // 
            // lblPAGOS
            // 
            this.lblPAGOS.AutoSize = true;
            this.lblPAGOS.Location = new System.Drawing.Point(16, 16);
            this.lblPAGOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPAGOS.Name = "lblPAGOS";
            this.lblPAGOS.Size = new System.Drawing.Size(52, 17);
            this.lblPAGOS.TabIndex = 70;
            this.lblPAGOS.Text = "Pagos:";
            // 
            // lblTOTALPAGOS
            // 
            this.lblTOTALPAGOS.AutoSize = true;
            this.lblTOTALPAGOS.Location = new System.Drawing.Point(544, 207);
            this.lblTOTALPAGOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTOTALPAGOS.Name = "lblTOTALPAGOS";
            this.lblTOTALPAGOS.Size = new System.Drawing.Size(58, 17);
            this.lblTOTALPAGOS.TabIndex = 69;
            this.lblTOTALPAGOS.Text = "TOTAL:";
            // 
            // txtTOTALPAGOS
            // 
            this.txtTOTALPAGOS.Location = new System.Drawing.Point(629, 203);
            this.txtTOTALPAGOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTOTALPAGOS.Name = "txtTOTALPAGOS";
            this.txtTOTALPAGOS.Size = new System.Drawing.Size(132, 22);
            this.txtTOTALPAGOS.TabIndex = 68;
            // 
            // dgvPAGOS
            // 
            this.dgvPAGOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPAGOS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvPAGOS.Location = new System.Drawing.Point(16, 36);
            this.dgvPAGOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPAGOS.Name = "dgvPAGOS";
            this.dgvPAGOS.Size = new System.Drawing.Size(747, 160);
            this.dgvPAGOS.TabIndex = 67;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(608, 271);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(155, 37);
            this.btnCERRAR.TabIndex = 73;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 319);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnELIMINARPAGO);
            this.Controls.Add(this.btnAGREGARPAGO);
            this.Controls.Add(this.lblPAGOS);
            this.Controls.Add(this.lblTOTALPAGOS);
            this.Controls.Add(this.txtTOTALPAGOS);
            this.Controls.Add(this.dgvPAGOS);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPagos";
            this.Text = "Sistema de Libreria - PAGOS";
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