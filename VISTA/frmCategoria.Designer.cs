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
            this.btnCANCELAR.Location = new System.Drawing.Point(30, 158);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(414, 43);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(30, 75);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(414, 70);
            this.btnGUARDAR.TabIndex = 6;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblCATEGORIA
            // 
            this.lblCATEGORIA.AutoSize = true;
            this.lblCATEGORIA.Location = new System.Drawing.Point(27, 30);
            this.lblCATEGORIA.Name = "lblCATEGORIA";
            this.lblCATEGORIA.Size = new System.Drawing.Size(147, 17);
            this.lblCATEGORIA.TabIndex = 33;
            this.lblCATEGORIA.Text = "Nombre de Categoria:";
            // 
            // txtCATEGORIA
            // 
            this.txtCATEGORIA.Location = new System.Drawing.Point(187, 30);
            this.txtCATEGORIA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCATEGORIA.Name = "txtCATEGORIA";
            this.txtCATEGORIA.Size = new System.Drawing.Size(257, 22);
            this.txtCATEGORIA.TabIndex = 32;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 249);
            this.Controls.Add(this.lblCATEGORIA);
            this.Controls.Add(this.txtCATEGORIA);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategoria";
            this.Text = "Sistema de Libreria - CATEGORIA";
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