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
            this.lblSEARCH = new System.Windows.Forms.Button();
            this.cmbSERVIDORES = new System.Windows.Forms.ComboBox();
            this.lblDIRECTORIO = new System.Windows.Forms.Label();
            this.lblSERVIDOR = new System.Windows.Forms.Label();
            this.btnGENERARBACKUP = new System.Windows.Forms.Button();
            this.txtDIRECTORIO = new System.Windows.Forms.TextBox();
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
            this.btnVOLVER.Location = new System.Drawing.Point(120, 180);
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
            this.btnRECUPERARBACKUP.Location = new System.Drawing.Point(200, 140);
            this.btnRECUPERARBACKUP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRECUPERARBACKUP.Name = "btnRECUPERARBACKUP";
            this.btnRECUPERARBACKUP.Size = new System.Drawing.Size(150, 30);
            this.btnRECUPERARBACKUP.TabIndex = 59;
            this.btnRECUPERARBACKUP.Text = "Recuperar backup";
            this.btnRECUPERARBACKUP.UseVisualStyleBackColor = true;
            // 
            // lblSEARCH
            // 
            this.lblSEARCH.Location = new System.Drawing.Point(300, 100);
            this.lblSEARCH.Name = "lblSEARCH";
            this.lblSEARCH.Size = new System.Drawing.Size(40, 23);
            this.lblSEARCH.TabIndex = 64;
            this.lblSEARCH.Text = "->";
            this.lblSEARCH.UseVisualStyleBackColor = true;
            // 
            // cmbSERVIDORES
            // 
            this.cmbSERVIDORES.FormattingEnabled = true;
            this.cmbSERVIDORES.Location = new System.Drawing.Point(160, 60);
            this.cmbSERVIDORES.Name = "cmbSERVIDORES";
            this.cmbSERVIDORES.Size = new System.Drawing.Size(180, 21);
            this.cmbSERVIDORES.TabIndex = 60;
            // 
            // lblDIRECTORIO
            // 
            this.lblDIRECTORIO.AutoSize = true;
            this.lblDIRECTORIO.Location = new System.Drawing.Point(40, 100);
            this.lblDIRECTORIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDIRECTORIO.Name = "lblDIRECTORIO";
            this.lblDIRECTORIO.Size = new System.Drawing.Size(55, 13);
            this.lblDIRECTORIO.TabIndex = 63;
            this.lblDIRECTORIO.Text = "Directorio:";
            // 
            // lblSERVIDOR
            // 
            this.lblSERVIDOR.AutoSize = true;
            this.lblSERVIDOR.Location = new System.Drawing.Point(40, 60);
            this.lblSERVIDOR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSERVIDOR.Name = "lblSERVIDOR";
            this.lblSERVIDOR.Size = new System.Drawing.Size(104, 13);
            this.lblSERVIDOR.TabIndex = 62;
            this.lblSERVIDOR.Text = "Nombre del servidor:";
            // 
            // btnGENERARBACKUP
            // 
            this.btnGENERARBACKUP.Location = new System.Drawing.Point(40, 140);
            this.btnGENERARBACKUP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGENERARBACKUP.Name = "btnGENERARBACKUP";
            this.btnGENERARBACKUP.Size = new System.Drawing.Size(150, 30);
            this.btnGENERARBACKUP.TabIndex = 58;
            this.btnGENERARBACKUP.Text = "Generar backup";
            this.btnGENERARBACKUP.UseVisualStyleBackColor = true;
            // 
            // txtDIRECTORIO
            // 
            this.txtDIRECTORIO.Location = new System.Drawing.Point(160, 100);
            this.txtDIRECTORIO.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIRECTORIO.Name = "txtDIRECTORIO";
            this.txtDIRECTORIO.Size = new System.Drawing.Size(120, 20);
            this.txtDIRECTORIO.TabIndex = 61;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 225);
            this.Controls.Add(this.btnRECUPERARBACKUP);
            this.Controls.Add(this.lblSEARCH);
            this.Controls.Add(this.cmbSERVIDORES);
            this.Controls.Add(this.lblDIRECTORIO);
            this.Controls.Add(this.lblSERVIDOR);
            this.Controls.Add(this.btnGENERARBACKUP);
            this.Controls.Add(this.txtDIRECTORIO);
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
        private System.Windows.Forms.Button lblSEARCH;
        private System.Windows.Forms.ComboBox cmbSERVIDORES;
        private System.Windows.Forms.Label lblDIRECTORIO;
        private System.Windows.Forms.Label lblSERVIDOR;
        private System.Windows.Forms.Button btnGENERARBACKUP;
        private System.Windows.Forms.TextBox txtDIRECTORIO;
    }
}