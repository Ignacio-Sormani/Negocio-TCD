namespace VISTA
{
    partial class frmBackup
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
            this.lblBACKUP = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.btnRECUPERARBACKUP = new System.Windows.Forms.Button();
            this.btnGENERARBACKUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBACKUP
            // 
            this.lblBACKUP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBACKUP.AutoSize = true;
            this.lblBACKUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBACKUP.Location = new System.Drawing.Point(187, 25);
            this.lblBACKUP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBACKUP.Name = "lblBACKUP";
            this.lblBACKUP.Size = new System.Drawing.Size(132, 31);
            this.lblBACKUP.TabIndex = 11;
            this.lblBACKUP.Text = "BACKUP";
            // 
            // btnVOLVER
            // 
            this.btnVOLVER.Location = new System.Drawing.Point(155, 139);
            this.btnVOLVER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(200, 37);
            this.btnVOLVER.TabIndex = 19;
            this.btnVOLVER.Text = "Volver";
            this.btnVOLVER.UseVisualStyleBackColor = true;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // btnRECUPERARBACKUP
            // 
            this.btnRECUPERARBACKUP.Location = new System.Drawing.Point(263, 71);
            this.btnRECUPERARBACKUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRECUPERARBACKUP.Name = "btnRECUPERARBACKUP";
            this.btnRECUPERARBACKUP.Size = new System.Drawing.Size(200, 37);
            this.btnRECUPERARBACKUP.TabIndex = 59;
            this.btnRECUPERARBACKUP.Text = "Recuperar backup";
            this.btnRECUPERARBACKUP.UseVisualStyleBackColor = true;
            this.btnRECUPERARBACKUP.Click += new System.EventHandler(this.btnRECUPERARBACKUP_Click_1);
            // 
            // btnGENERARBACKUP
            // 
            this.btnGENERARBACKUP.Location = new System.Drawing.Point(49, 71);
            this.btnGENERARBACKUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGENERARBACKUP.Name = "btnGENERARBACKUP";
            this.btnGENERARBACKUP.Size = new System.Drawing.Size(200, 37);
            this.btnGENERARBACKUP.TabIndex = 58;
            this.btnGENERARBACKUP.Text = "Generar backup";
            this.btnGENERARBACKUP.UseVisualStyleBackColor = true;
            this.btnGENERARBACKUP.Click += new System.EventHandler(this.btnGENERARBACKUP_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 197);
            this.Controls.Add(this.btnRECUPERARBACKUP);
            this.Controls.Add(this.btnGENERARBACKUP);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.lblBACKUP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBackup";
            this.Text = "Sistema de Libreria - BACKUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBACKUP;
        private System.Windows.Forms.Button btnVOLVER;
        private System.Windows.Forms.Button btnRECUPERARBACKUP;
        private System.Windows.Forms.Button btnGENERARBACKUP;
    }
}