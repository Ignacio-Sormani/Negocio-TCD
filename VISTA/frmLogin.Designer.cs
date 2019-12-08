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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLOGIN = new System.Windows.Forms.Label();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.lblCONTRASEÑA = new System.Windows.Forms.Label();
            this.lblRESETEARCONTRASEÑA = new System.Windows.Forms.Label();
            this.btnLOGIN = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLOGIN
            // 
            this.lblLOGIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLOGIN.AutoSize = true;
            this.lblLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGIN.Location = new System.Drawing.Point(114, 30);
            this.lblLOGIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLOGIN.Name = "lblLOGIN";
            this.lblLOGIN.Size = new System.Drawing.Size(191, 31);
            this.lblLOGIN.TabIndex = 0;
            this.lblLOGIN.Text = "Iniciar Sesion";
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(53, 252);
            this.lblUSUARIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(61, 17);
            this.lblUSUARIO.TabIndex = 1;
            this.lblUSUARIO.Text = "Usuario:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(56, 274);
            this.txtUSUARIO.Margin = new System.Windows.Forms.Padding(4);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(280, 22);
            this.txtUSUARIO.TabIndex = 2;
            // 
            // txtCONTRASEÑA
            // 
            this.txtCONTRASEÑA.Location = new System.Drawing.Point(56, 337);
            this.txtCONTRASEÑA.Margin = new System.Windows.Forms.Padding(4);
            this.txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            this.txtCONTRASEÑA.PasswordChar = '*';
            this.txtCONTRASEÑA.Size = new System.Drawing.Size(280, 22);
            this.txtCONTRASEÑA.TabIndex = 4;
            // 
            // lblCONTRASEÑA
            // 
            this.lblCONTRASEÑA.AutoSize = true;
            this.lblCONTRASEÑA.Location = new System.Drawing.Point(53, 315);
            this.lblCONTRASEÑA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCONTRASEÑA.Name = "lblCONTRASEÑA";
            this.lblCONTRASEÑA.Size = new System.Drawing.Size(85, 17);
            this.lblCONTRASEÑA.TabIndex = 3;
            this.lblCONTRASEÑA.Text = "Contraseña:";
            // 
            // lblRESETEARCONTRASEÑA
            // 
            this.lblRESETEARCONTRASEÑA.AutoSize = true;
            this.lblRESETEARCONTRASEÑA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRESETEARCONTRASEÑA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRESETEARCONTRASEÑA.Location = new System.Drawing.Point(123, 379);
            this.lblRESETEARCONTRASEÑA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRESETEARCONTRASEÑA.Name = "lblRESETEARCONTRASEÑA";
            this.lblRESETEARCONTRASEÑA.Size = new System.Drawing.Size(167, 18);
            this.lblRESETEARCONTRASEÑA.TabIndex = 5;
            this.lblRESETEARCONTRASEÑA.Text = "Olvide mi contraseña";
            this.lblRESETEARCONTRASEÑA.Click += new System.EventHandler(this.lblRESETEARCONTRASEÑA_Click);
            this.lblRESETEARCONTRASEÑA.MouseEnter += new System.EventHandler(this.lblRESETEARCONTRASEÑA_MouseEnter);
            this.lblRESETEARCONTRASEÑA.MouseLeave += new System.EventHandler(this.lblRESETEARCONTRASEÑA_MouseLeave);
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.Location = new System.Drawing.Point(56, 419);
            this.btnLOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Size = new System.Drawing.Size(280, 65);
            this.btnLOGIN.TabIndex = 9;
            this.btnLOGIN.Text = "Conectarse";
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(56, 505);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(280, 37);
            this.btnCERRAR.TabIndex = 10;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(105, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sistema de Biblioteca © 2019 UAI";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 576);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLOGIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.lblRESETEARCONTRASEÑA);
            this.Controls.Add(this.txtCONTRASEÑA);
            this.Controls.Add(this.lblCONTRASEÑA);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.lblUSUARIO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}