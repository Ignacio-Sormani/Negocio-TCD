namespace VISTA
{
    partial class frmOrdenesDeCompra
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
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnDARDEBAJA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(150, 67);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 0;
            this.btnAGREGAR.Text = "button1";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(189, 151);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(75, 23);
            this.btnCONSULTAR.TabIndex = 1;
            this.btnCONSULTAR.Text = "button2";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            // 
            // btnDARDEBAJA
            // 
            this.btnDARDEBAJA.Location = new System.Drawing.Point(260, 312);
            this.btnDARDEBAJA.Name = "btnDARDEBAJA";
            this.btnDARDEBAJA.Size = new System.Drawing.Size(75, 23);
            this.btnDARDEBAJA.TabIndex = 2;
            this.btnDARDEBAJA.Text = "button3";
            this.btnDARDEBAJA.UseVisualStyleBackColor = true;
            // 
            // frmOrdenesDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.btnDARDEBAJA);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Name = "frmOrdenesDeCompra";
            this.Text = "frmOrdenesDePago";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnDARDEBAJA;
    }
}