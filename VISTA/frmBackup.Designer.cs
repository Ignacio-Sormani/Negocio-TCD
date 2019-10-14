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
            this.lblBACKUP.Location = new System.Drawing.Point(140, 20);
            this.lblBACKUP.Name = "lblBACKUP";
            this.lblBACKUP.Size = new System.Drawing.Size(104, 25);
            this.lblBACKUP.TabIndex = 11;
            this.lblBACKUP.Text = "BACKUP";
            // 
            // btnVOLVER
            // 
            this.btnVOLVER.Location = new System.Drawing.Point(116, 113);
            this.btnVOLVER.Margin = new System.Windows.Forms.Padding(2);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(150, 30);
            this.btnVOLVER.TabIndex = 19;
            this.btnVOLVER.Text = "Volver";
            this.btnVOLVER.UseVisualStyleBackColor = true;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // btnRECUPERARBACKUP
            // 
            this.btnRECUPERARBACKUP.Location = new System.Drawing.Point(197, 58);
            this.btnRECUPERARBACKUP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRECUPERARBACKUP.Name = "btnRECUPERARBACKUP";
            this.btnRECUPERARBACKUP.Size = new System.Drawing.Size(150, 30);
            this.btnRECUPERARBACKUP.TabIndex = 59;
            this.btnRECUPERARBACKUP.Text = "Recuperar backup";
            this.btnRECUPERARBACKUP.UseVisualStyleBackColor = true;
            this.btnRECUPERARBACKUP.Click += new System.EventHandler(this.btnRECUPERARBACKUP_Click_1);
            // 
            // btnGENERARBACKUP
            // 
            this.btnGENERARBACKUP.Location = new System.Drawing.Point(37, 58);
            this.btnGENERARBACKUP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGENERARBACKUP.Name = "btnGENERARBACKUP";
            this.btnGENERARBACKUP.Size = new System.Drawing.Size(150, 30);
            this.btnGENERARBACKUP.TabIndex = 58;
            this.btnGENERARBACKUP.Text = "Generar backup";
            this.btnGENERARBACKUP.UseVisualStyleBackColor = true;
            this.btnGENERARBACKUP.Click += new System.EventHandler(this.btnGENERARBACKUP_Click_1);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 160);
            this.Controls.Add(this.btnRECUPERARBACKUP);
            this.Controls.Add(this.btnGENERARBACKUP);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.lblBACKUP);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
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