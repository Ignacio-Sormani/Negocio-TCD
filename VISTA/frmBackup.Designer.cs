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
            this.btnRESTAURARSISTEMA = new System.Windows.Forms.Button();
            this.btnGENERARBACKUP = new System.Windows.Forms.Button();
            this.lblBACKUP = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRESTAURARSISTEMA
            // 
            this.btnRESTAURARSISTEMA.Location = new System.Drawing.Point(200, 80);
            this.btnRESTAURARSISTEMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnRESTAURARSISTEMA.Name = "btnRESTAURARSISTEMA";
            this.btnRESTAURARSISTEMA.Size = new System.Drawing.Size(150, 30);
            this.btnRESTAURARSISTEMA.TabIndex = 18;
            this.btnRESTAURARSISTEMA.Text = "Restaurar sistema";
            this.btnRESTAURARSISTEMA.UseVisualStyleBackColor = true;
            this.btnRESTAURARSISTEMA.Click += new System.EventHandler(this.btnRESTAURARSISTEMA_Click);
            // 
            // btnGENERARBACKUP
            // 
            this.btnGENERARBACKUP.Location = new System.Drawing.Point(20, 80);
            this.btnGENERARBACKUP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGENERARBACKUP.Name = "btnGENERARBACKUP";
            this.btnGENERARBACKUP.Size = new System.Drawing.Size(150, 30);
            this.btnGENERARBACKUP.TabIndex = 17;
            this.btnGENERARBACKUP.Text = "Generar backup";
            this.btnGENERARBACKUP.UseVisualStyleBackColor = true;
            this.btnGENERARBACKUP.Click += new System.EventHandler(this.btnGENERARBACKUP_Click);
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
            this.btnVOLVER.Location = new System.Drawing.Point(110, 140);
            this.btnVOLVER.Margin = new System.Windows.Forms.Padding(2);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(150, 30);
            this.btnVOLVER.TabIndex = 19;
            this.btnVOLVER.Text = "Volver";
            this.btnVOLVER.UseVisualStyleBackColor = true;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.btnRESTAURARSISTEMA);
            this.Controls.Add(this.btnGENERARBACKUP);
            this.Controls.Add(this.lblBACKUP);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRESTAURARSISTEMA;
        private System.Windows.Forms.Button btnGENERARBACKUP;
        private System.Windows.Forms.Label lblBACKUP;
        private System.Windows.Forms.Button btnVOLVER;
    }
}