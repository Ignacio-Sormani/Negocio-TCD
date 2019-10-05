namespace VISTA
{
    partial class frmRemitos
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
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(202, 252);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(75, 23);
            this.btnCONSULTAR.TabIndex = 3;
            this.btnCONSULTAR.Text = "button2";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(163, 168);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 2;
            this.btnAGREGAR.Text = "button1";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            // 
            // frmRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Name = "frmRemitos";
            this.Text = "frmRemitos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnAGREGAR;
    }
}