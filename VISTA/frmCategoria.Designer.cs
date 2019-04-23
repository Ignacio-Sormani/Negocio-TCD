namespace VISTA
{
    partial class frmCategoria
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
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblCATEGORIA = new System.Windows.Forms.Label();
            this.txtCATEGORIA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(9, 157);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(9, 103);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 35);
            this.btnGUARDAR.TabIndex = 6;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblCATEGORIA
            // 
            this.lblCATEGORIA.AutoSize = true;
            this.lblCATEGORIA.Location = new System.Drawing.Point(9, 47);
            this.lblCATEGORIA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCATEGORIA.Name = "lblCATEGORIA";
            this.lblCATEGORIA.Size = new System.Drawing.Size(110, 13);
            this.lblCATEGORIA.TabIndex = 5;
            this.lblCATEGORIA.Text = "Nombre de Categoria:";
            // 
            // txtCATEGORIA
            // 
            this.txtCATEGORIA.Location = new System.Drawing.Point(9, 72);
            this.txtCATEGORIA.Margin = new System.Windows.Forms.Padding(2);
            this.txtCATEGORIA.Name = "txtCATEGORIA";
            this.txtCATEGORIA.Size = new System.Drawing.Size(194, 20);
            this.txtCATEGORIA.TabIndex = 4;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 238);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblCATEGORIA);
            this.Controls.Add(this.txtCATEGORIA);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblCATEGORIA;
        private System.Windows.Forms.TextBox txtCATEGORIA;
    }
}