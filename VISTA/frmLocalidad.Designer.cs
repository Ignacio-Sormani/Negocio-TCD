namespace VISTA
{
    partial class frmLocalidad
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
            this.lblLOCALIDAD = new System.Windows.Forms.Label();
            this.txtLOCALIDAD = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLOCALIDAD
            // 
            this.lblLOCALIDAD.AutoSize = true;
            this.lblLOCALIDAD.Location = new System.Drawing.Point(20, 20);
            this.lblLOCALIDAD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLOCALIDAD.Name = "lblLOCALIDAD";
            this.lblLOCALIDAD.Size = new System.Drawing.Size(56, 13);
            this.lblLOCALIDAD.TabIndex = 41;
            this.lblLOCALIDAD.Text = "Localidad:";
            // 
            // txtLOCALIDAD
            // 
            this.txtLOCALIDAD.Location = new System.Drawing.Point(140, 20);
            this.txtLOCALIDAD.Margin = new System.Windows.Forms.Padding(2);
            this.txtLOCALIDAD.Name = "txtLOCALIDAD";
            this.txtLOCALIDAD.Size = new System.Drawing.Size(194, 20);
            this.txtLOCALIDAD.TabIndex = 40;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(80, 174);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 39;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(80, 120);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 35);
            this.btnGUARDAR.TabIndex = 38;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(20, 60);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 43;
            this.lblCP.Text = "Codigo Postal:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(140, 60);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(194, 20);
            this.txtCP.TabIndex = 42;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 234);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblLOCALIDAD);
            this.Controls.Add(this.txtLOCALIDAD);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLocalidad";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.frmLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLOCALIDAD;
        private System.Windows.Forms.TextBox txtLOCALIDAD;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
    }
}