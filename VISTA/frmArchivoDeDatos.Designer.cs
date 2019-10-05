namespace VISTA
{
    partial class frmArchivoDeDatos
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
            this.btnGENERARARCHIVO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGENERARARCHIVO
            // 
            this.btnGENERARARCHIVO.Location = new System.Drawing.Point(137, 109);
            this.btnGENERARARCHIVO.Name = "btnGENERARARCHIVO";
            this.btnGENERARARCHIVO.Size = new System.Drawing.Size(75, 23);
            this.btnGENERARARCHIVO.TabIndex = 0;
            this.btnGENERARARCHIVO.Text = "button1";
            this.btnGENERARARCHIVO.UseVisualStyleBackColor = true;
            // 
            // frmArchivoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 443);
            this.Controls.Add(this.btnGENERARARCHIVO);
            this.Name = "frmArchivoDeDatos";
            this.Text = "frmArchivoDeDatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGENERARARCHIVO;
    }
}