namespace VISTA
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnBACKUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Location = new System.Drawing.Point(414, 404);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(180, 60);
            this.btnEXCEL.TabIndex = 4;
            this.btnEXCEL.Text = "Excel";
            this.btnEXCEL.UseVisualStyleBackColor = true;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnBACKUP
            // 
            this.btnBACKUP.Location = new System.Drawing.Point(414, 264);
            this.btnBACKUP.Name = "btnBACKUP";
            this.btnBACKUP.Size = new System.Drawing.Size(180, 60);
            this.btnBACKUP.TabIndex = 3;
            this.btnBACKUP.Text = "Backup";
            this.btnBACKUP.UseVisualStyleBackColor = true;
            this.btnBACKUP.Click += new System.EventHandler(this.btnBACKUP_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.btnBACKUP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnBACKUP;
    }
}

