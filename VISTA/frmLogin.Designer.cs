namespace VISTA
{
    partial class frmLogin
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
            this.lblLOGIN = new System.Windows.Forms.Label();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.lblCONTRASEÑA = new System.Windows.Forms.Label();
            this.lblRESETEARCONTRASEÑA = new System.Windows.Forms.Label();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLOGIN
            // 
            this.lblLOGIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLOGIN.AutoSize = true;
            this.lblLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGIN.Location = new System.Drawing.Point(150, 20);
            this.lblLOGIN.Name = "lblLOGIN";
            this.lblLOGIN.Size = new System.Drawing.Size(81, 25);
            this.lblLOGIN.TabIndex = 0;
            this.lblLOGIN.Text = "LOGIN";
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(40, 80);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(76, 13);
            this.lblUSUARIO.TabIndex = 1;
            this.lblUSUARIO.Text = "Usuario o mail:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(140, 80);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(180, 20);
            this.txtUSUARIO.TabIndex = 2;
            // 
            // txtCONTRASEÑA
            // 
            this.txtCONTRASEÑA.Location = new System.Drawing.Point(140, 120);
            this.txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            this.txtCONTRASEÑA.PasswordChar = '*';
            this.txtCONTRASEÑA.Size = new System.Drawing.Size(180, 20);
            this.txtCONTRASEÑA.TabIndex = 4;
            // 
            // lblCONTRASEÑA
            // 
            this.lblCONTRASEÑA.AutoSize = true;
            this.lblCONTRASEÑA.Location = new System.Drawing.Point(40, 120);
            this.lblCONTRASEÑA.Name = "lblCONTRASEÑA";
            this.lblCONTRASEÑA.Size = new System.Drawing.Size(64, 13);
            this.lblCONTRASEÑA.TabIndex = 3;
            this.lblCONTRASEÑA.Text = "Contraseña:";
            // 
            // lblRESETEARCONTRASEÑA
            // 
            this.lblRESETEARCONTRASEÑA.AutoSize = true;
            this.lblRESETEARCONTRASEÑA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRESETEARCONTRASEÑA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRESETEARCONTRASEÑA.Location = new System.Drawing.Point(120, 160);
            this.lblRESETEARCONTRASEÑA.Name = "lblRESETEARCONTRASEÑA";
            this.lblRESETEARCONTRASEÑA.Size = new System.Drawing.Size(142, 15);
            this.lblRESETEARCONTRASEÑA.TabIndex = 5;
            this.lblRESETEARCONTRASEÑA.Text = "Olvide mi contraseña";
            this.lblRESETEARCONTRASEÑA.Click += new System.EventHandler(this.lblRESETEARCONTRASEÑA_Click);
            this.lblRESETEARCONTRASEÑA.MouseEnter += new System.EventHandler(this.lblRESETEARCONTRASEÑA_MouseEnter);
            this.lblRESETEARCONTRASEÑA.MouseLeave += new System.EventHandler(this.lblRESETEARCONTRASEÑA_MouseLeave);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.Location = new System.Drawing.Point(20, 200);
            this.btnLOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(150, 30);
            this.btnLOGIN.TabIndex = 9;
            this.btnLOGIN.Text = "Conectarse";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(200, 200);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(150, 30);
            this.btnCERRAR.TabIndex = 10;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.lblRESETEARCONTRASEÑA);
            this.Controls.Add(this.txtCONTRASEÑA);
            this.Controls.Add(this.lblCONTRASEÑA);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.lblLOGIN);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLOGIN;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.TextBox txtCONTRASEÑA;
        private System.Windows.Forms.Label lblCONTRASEÑA;
        private System.Windows.Forms.Label lblRESETEARCONTRASEÑA;
        private System.Windows.Forms.Button btnLOGIN;
        private System.Windows.Forms.Button btnCERRAR;
    }
}