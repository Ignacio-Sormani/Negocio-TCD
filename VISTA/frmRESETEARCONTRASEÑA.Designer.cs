namespace VISTA
{
    partial class frmResetearContraseña
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
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.btnRESETEARCLAVE = new System.Windows.Forms.Button();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.lblRESETEARCONTRA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(127, 78);
            this.txtMAIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(319, 22);
            this.txtMAIL.TabIndex = 29;
            // 
            // btnVOLVER
            // 
            this.btnVOLVER.Location = new System.Drawing.Point(275, 134);
            this.btnVOLVER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(200, 37);
            this.btnVOLVER.TabIndex = 27;
            this.btnVOLVER.Text = "Cerrar";
            this.btnVOLVER.UseVisualStyleBackColor = true;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // btnRESETEARCLAVE
            // 
            this.btnRESETEARCLAVE.Location = new System.Drawing.Point(35, 134);
            this.btnRESETEARCLAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRESETEARCLAVE.Name = "btnRESETEARCLAVE";
            this.btnRESETEARCLAVE.Size = new System.Drawing.Size(200, 37);
            this.btnRESETEARCLAVE.TabIndex = 26;
            this.btnRESETEARCLAVE.Text = "Resetear contraseña";
            this.btnRESETEARCLAVE.UseVisualStyleBackColor = true;
            this.btnRESETEARCLAVE.Click += new System.EventHandler(this.btnRESETEARCLAVE_Click);
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Location = new System.Drawing.Point(47, 78);
            this.lblMAIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(37, 17);
            this.lblMAIL.TabIndex = 24;
            this.lblMAIL.Text = "Mail:";
            // 
            // lblRESETEARCONTRA
            // 
            this.lblRESETEARCONTRA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRESETEARCONTRA.AutoSize = true;
            this.lblRESETEARCONTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRESETEARCONTRA.Location = new System.Drawing.Point(53, 25);
            this.lblRESETEARCONTRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRESETEARCONTRA.Name = "lblRESETEARCONTRA";
            this.lblRESETEARCONTRA.Size = new System.Drawing.Size(377, 31);
            this.lblRESETEARCONTRA.TabIndex = 21;
            this.lblRESETEARCONTRA.Text = "RESETEAR CONTRASEÑA";
            // 
            // frmResetearContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 203);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.btnRESETEARCLAVE);
            this.Controls.Add(this.lblMAIL);
            this.Controls.Add(this.lblRESETEARCONTRA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmResetearContraseña";
            this.Text = "Sistema de Libreria - RESETEAR CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Button btnVOLVER;
        private System.Windows.Forms.Button btnRESETEARCLAVE;
        private System.Windows.Forms.Label lblMAIL;
        private System.Windows.Forms.Label lblRESETEARCONTRA;
    }
}