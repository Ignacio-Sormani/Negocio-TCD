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
            this.txtMAIL.Location = new System.Drawing.Point(95, 63);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(240, 20);
            this.txtMAIL.TabIndex = 29;
            // 
            // btnVOLVER
            // 
            this.btnVOLVER.Location = new System.Drawing.Point(206, 109);
            this.btnVOLVER.Margin = new System.Windows.Forms.Padding(2);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(150, 30);
            this.btnVOLVER.TabIndex = 27;
            this.btnVOLVER.Text = "Cerrar";
            this.btnVOLVER.UseVisualStyleBackColor = true;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // btnRESETEARCLAVE
            // 
            this.btnRESETEARCLAVE.Location = new System.Drawing.Point(26, 109);
            this.btnRESETEARCLAVE.Margin = new System.Windows.Forms.Padding(2);
            this.btnRESETEARCLAVE.Name = "btnRESETEARCLAVE";
            this.btnRESETEARCLAVE.Size = new System.Drawing.Size(150, 30);
            this.btnRESETEARCLAVE.TabIndex = 26;
            this.btnRESETEARCLAVE.Text = "Resetear contraseña";
            this.btnRESETEARCLAVE.UseVisualStyleBackColor = true;
            this.btnRESETEARCLAVE.Click += new System.EventHandler(this.btnRESETEARCLAVE_Click);
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Location = new System.Drawing.Point(35, 63);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(29, 13);
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
            this.lblRESETEARCONTRA.Location = new System.Drawing.Point(40, 20);
            this.lblRESETEARCONTRA.Name = "lblRESETEARCONTRA";
            this.lblRESETEARCONTRA.Size = new System.Drawing.Size(295, 25);
            this.lblRESETEARCONTRA.TabIndex = 21;
            this.lblRESETEARCONTRA.Text = "RESETEAR CONTRASEÑA";
            // 
            // frmResetearContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 165);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.btnRESETEARCLAVE);
            this.Controls.Add(this.lblMAIL);
            this.Controls.Add(this.lblRESETEARCONTRA);
            this.Name = "frmResetearContraseña";
            this.Text = "frmRESETEARCONTRASEÑA";
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