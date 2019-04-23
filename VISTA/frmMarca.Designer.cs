namespace VISTA
{
    partial class frmMarca
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
            this.txtMARCA = new System.Windows.Forms.TextBox();
            this.lblMARCA = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMARCA
            // 
            this.txtMARCA.Location = new System.Drawing.Point(9, 49);
            this.txtMARCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMARCA.Name = "txtMARCA";
            this.txtMARCA.Size = new System.Drawing.Size(194, 20);
            this.txtMARCA.TabIndex = 0;
            // 
            // lblMARCA
            // 
            this.lblMARCA.AutoSize = true;
            this.lblMARCA.Location = new System.Drawing.Point(9, 24);
            this.lblMARCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMARCA.Name = "lblMARCA";
            this.lblMARCA.Size = new System.Drawing.Size(95, 13);
            this.lblMARCA.TabIndex = 1;
            this.lblMARCA.Text = "Nombre de Marca:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(9, 134);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 3;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(9, 80);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 35);
            this.btnGUARDAR.TabIndex = 2;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 238);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblMARCA);
            this.Controls.Add(this.txtMARCA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMARCA;
        private System.Windows.Forms.Label lblMARCA;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
    }
}