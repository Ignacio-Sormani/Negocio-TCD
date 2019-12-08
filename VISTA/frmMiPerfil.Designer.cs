namespace VISTA
{
    partial class frmMiPerfil
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
            this.lblMAIL = new System.Windows.Forms.Label();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.lblMISDATOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Location = new System.Drawing.Point(20, 148);
            this.lblMAIL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(29, 13);
            this.lblMAIL.TabIndex = 33;
            this.lblMAIL.Text = "Mail:";
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(140, 148);
            this.txtMAIL.Margin = new System.Windows.Forms.Padding(2);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(194, 20);
            this.txtMAIL.TabIndex = 32;
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Location = new System.Drawing.Point(20, 108);
            this.lblNOMBRE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(95, 13);
            this.lblNOMBRE.TabIndex = 31;
            this.lblNOMBRE.Text = "Nombre y Apellido:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(140, 108);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(194, 20);
            this.txtNOMBRE.TabIndex = 30;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(77, 246);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 29;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(77, 192);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 35);
            this.btnGUARDAR.TabIndex = 28;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(20, 68);
            this.lblUSUARIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(101, 13);
            this.lblUSUARIO.TabIndex = 27;
            this.lblUSUARIO.Text = "Nombre de Usuario:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(140, 68);
            this.txtUSUARIO.Margin = new System.Windows.Forms.Padding(2);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(194, 20);
            this.txtUSUARIO.TabIndex = 26;
            // 
            // lblMISDATOS
            // 
            this.lblMISDATOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMISDATOS.AutoSize = true;
            this.lblMISDATOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMISDATOS.Location = new System.Drawing.Point(100, 20);
            this.lblMISDATOS.Name = "lblMISDATOS";
            this.lblMISDATOS.Size = new System.Drawing.Size(136, 25);
            this.lblMISDATOS.TabIndex = 34;
            this.lblMISDATOS.Text = "MIS DATOS";
            // 
            // frmMiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 311);
            this.Controls.Add(this.lblMISDATOS);
            this.Controls.Add(this.lblMAIL);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.lblNOMBRE);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.txtUSUARIO);
            this.Name = "frmMiPerfil";
            this.Text = "frmMiPerfil";
            this.Load += new System.EventHandler(this.frmMiPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMAIL;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.Label lblMISDATOS;
    }
}