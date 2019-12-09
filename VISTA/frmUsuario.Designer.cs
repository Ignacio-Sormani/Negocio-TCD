namespace VISTA
{
    partial class frmUsuario
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
            this.lblGRUPOS = new System.Windows.Forms.Label();
            this.clbGRUPOS = new System.Windows.Forms.CheckedListBox();
            this.ckbACTIVO = new System.Windows.Forms.CheckBox();
            this.lblESTADO = new System.Windows.Forms.Label();
            this.lblMAIL = new System.Windows.Forms.Label();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGRUPOS
            // 
            this.lblGRUPOS.AutoSize = true;
            this.lblGRUPOS.Location = new System.Drawing.Point(27, 224);
            this.lblGRUPOS.Name = "lblGRUPOS";
            this.lblGRUPOS.Size = new System.Drawing.Size(59, 17);
            this.lblGRUPOS.TabIndex = 31;
            this.lblGRUPOS.Text = "Grupos:";
            // 
            // clbGRUPOS
            // 
            this.clbGRUPOS.FormattingEnabled = true;
            this.clbGRUPOS.Location = new System.Drawing.Point(27, 249);
            this.clbGRUPOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbGRUPOS.Name = "clbGRUPOS";
            this.clbGRUPOS.Size = new System.Drawing.Size(425, 174);
            this.clbGRUPOS.TabIndex = 30;
            this.clbGRUPOS.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbGRUPOS_ItemCheck);
            // 
            // ckbACTIVO
            // 
            this.ckbACTIVO.AutoSize = true;
            this.ckbACTIVO.Location = new System.Drawing.Point(187, 175);
            this.ckbACTIVO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbACTIVO.Name = "ckbACTIVO";
            this.ckbACTIVO.Size = new System.Drawing.Size(68, 21);
            this.ckbACTIVO.TabIndex = 29;
            this.ckbACTIVO.Text = "Activo";
            this.ckbACTIVO.UseVisualStyleBackColor = true;
            // 
            // lblESTADO
            // 
            this.lblESTADO.AutoSize = true;
            this.lblESTADO.Location = new System.Drawing.Point(27, 175);
            this.lblESTADO.Name = "lblESTADO";
            this.lblESTADO.Size = new System.Drawing.Size(56, 17);
            this.lblESTADO.TabIndex = 28;
            this.lblESTADO.Text = "Estado:";
            // 
            // lblMAIL
            // 
            this.lblMAIL.AutoSize = true;
            this.lblMAIL.Location = new System.Drawing.Point(27, 128);
            this.lblMAIL.Name = "lblMAIL";
            this.lblMAIL.Size = new System.Drawing.Size(37, 17);
            this.lblMAIL.TabIndex = 25;
            this.lblMAIL.Text = "Mail:";
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(187, 128);
            this.txtMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(257, 22);
            this.txtMAIL.TabIndex = 24;
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Location = new System.Drawing.Point(27, 79);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(127, 17);
            this.lblNOMBRE.TabIndex = 23;
            this.lblNOMBRE.Text = "Nombre y Apellido:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(187, 79);
            this.txtNOMBRE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(257, 22);
            this.txtNOMBRE.TabIndex = 22;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(30, 534);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(422, 43);
            this.btnCANCELAR.TabIndex = 21;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(30, 444);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(422, 79);
            this.btnGUARDAR.TabIndex = 20;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(27, 30);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(135, 17);
            this.lblUSUARIO.TabIndex = 19;
            this.lblUSUARIO.Text = "Nombre de Usuario:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(187, 30);
            this.txtUSUARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(257, 22);
            this.txtUSUARIO.TabIndex = 18;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 606);
            this.Controls.Add(this.lblGRUPOS);
            this.Controls.Add(this.clbGRUPOS);
            this.Controls.Add(this.ckbACTIVO);
            this.Controls.Add(this.lblESTADO);
            this.Controls.Add(this.lblMAIL);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.lblNOMBRE);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.txtUSUARIO);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsuario";
            this.Text = "Sistema de Libreria - USUARIO";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGRUPOS;
        private System.Windows.Forms.CheckedListBox clbGRUPOS;
        private System.Windows.Forms.CheckBox ckbACTIVO;
        private System.Windows.Forms.Label lblESTADO;
        private System.Windows.Forms.Label lblMAIL;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.TextBox txtUSUARIO;
    }
}