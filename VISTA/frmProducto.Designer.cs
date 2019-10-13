namespace VISTA
{
    partial class frmProducto
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
            this.ckbACTIVO = new System.Windows.Forms.CheckBox();
            this.lblESTADO = new System.Windows.Forms.Label();
            this.lblCLAVE = new System.Windows.Forms.Label();
            this.txtPRECIO = new System.Windows.Forms.TextBox();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.txtCANTMINIMA = new System.Windows.Forms.TextBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.btnMARCA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCATEGORIA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCANTOPERATIVA = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.lblMARCA = new System.Windows.Forms.Label();
            this.lblCATEGORIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbACTIVO
            // 
            this.ckbACTIVO.AutoSize = true;
            this.ckbACTIVO.Location = new System.Drawing.Point(141, 317);
            this.ckbACTIVO.Name = "ckbACTIVO";
            this.ckbACTIVO.Size = new System.Drawing.Size(56, 17);
            this.ckbACTIVO.TabIndex = 42;
            this.ckbACTIVO.Text = "Activo";
            this.ckbACTIVO.UseVisualStyleBackColor = true;
            // 
            // lblESTADO
            // 
            this.lblESTADO.AutoSize = true;
            this.lblESTADO.Location = new System.Drawing.Point(21, 317);
            this.lblESTADO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblESTADO.Name = "lblESTADO";
            this.lblESTADO.Size = new System.Drawing.Size(43, 13);
            this.lblESTADO.TabIndex = 41;
            this.lblESTADO.Text = "Estado:";
            // 
            // lblCLAVE
            // 
            this.lblCLAVE.AutoSize = true;
            this.lblCLAVE.Location = new System.Drawing.Point(21, 180);
            this.lblCLAVE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCLAVE.Name = "lblCLAVE";
            this.lblCLAVE.Size = new System.Drawing.Size(40, 13);
            this.lblCLAVE.TabIndex = 40;
            this.lblCLAVE.Text = "Precio:";
            // 
            // txtPRECIO
            // 
            this.txtPRECIO.Location = new System.Drawing.Point(141, 180);
            this.txtPRECIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPRECIO.Name = "txtPRECIO";
            this.txtPRECIO.Size = new System.Drawing.Size(209, 20);
            this.txtPRECIO.TabIndex = 39;
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Location = new System.Drawing.Point(21, 91);
            this.lblNOMBRE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(40, 13);
            this.lblNOMBRE.TabIndex = 36;
            this.lblNOMBRE.Text = "Marca:";
            // 
            // txtCANTMINIMA
            // 
            this.txtCANTMINIMA.Location = new System.Drawing.Point(141, 227);
            this.txtCANTMINIMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCANTMINIMA.Name = "txtCANTMINIMA";
            this.txtCANTMINIMA.Size = new System.Drawing.Size(209, 20);
            this.txtCANTMINIMA.TabIndex = 35;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(78, 360);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(194, 65);
            this.btnGUARDAR.TabIndex = 34;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Location = new System.Drawing.Point(21, 51);
            this.lblUSUARIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(66, 13);
            this.lblUSUARIO.TabIndex = 33;
            this.lblUSUARIO.Text = "Descripcion:";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(141, 51);
            this.txtDESCRIPCION.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(209, 20);
            this.txtDESCRIPCION.TabIndex = 32;
            // 
            // btnMARCA
            // 
            this.btnMARCA.Location = new System.Drawing.Point(269, 78);
            this.btnMARCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMARCA.Name = "btnMARCA";
            this.btnMARCA.Size = new System.Drawing.Size(80, 40);
            this.btnMARCA.TabIndex = 43;
            this.btnMARCA.Text = "Seleccionar Marca";
            this.btnMARCA.UseVisualStyleBackColor = true;
            this.btnMARCA.Click += new System.EventHandler(this.btnMARCA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Categoria:";
            // 
            // btnCATEGORIA
            // 
            this.btnCATEGORIA.Location = new System.Drawing.Point(269, 119);
            this.btnCATEGORIA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCATEGORIA.Name = "btnCATEGORIA";
            this.btnCATEGORIA.Size = new System.Drawing.Size(80, 41);
            this.btnCATEGORIA.TabIndex = 45;
            this.btnCATEGORIA.Text = "Seleccionar Categoria";
            this.btnCATEGORIA.UseVisualStyleBackColor = true;
            this.btnCATEGORIA.Click += new System.EventHandler(this.btnCATEGORIA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cantidad Minima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cantidad Operativa:";
            // 
            // txtCANTOPERATIVA
            // 
            this.txtCANTOPERATIVA.Location = new System.Drawing.Point(141, 273);
            this.txtCANTOPERATIVA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCANTOPERATIVA.Name = "txtCANTOPERATIVA";
            this.txtCANTOPERATIVA.Size = new System.Drawing.Size(209, 20);
            this.txtCANTOPERATIVA.TabIndex = 48;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(78, 428);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(194, 35);
            this.btnCANCELAR.TabIndex = 49;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // lblMARCA
            // 
            this.lblMARCA.AutoSize = true;
            this.lblMARCA.Location = new System.Drawing.Point(139, 91);
            this.lblMARCA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMARCA.Name = "lblMARCA";
            this.lblMARCA.Size = new System.Drawing.Size(0, 13);
            this.lblMARCA.TabIndex = 50;
            // 
            // lblCATEGORIA
            // 
            this.lblCATEGORIA.AutoSize = true;
            this.lblCATEGORIA.Location = new System.Drawing.Point(139, 132);
            this.lblCATEGORIA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCATEGORIA.Name = "lblCATEGORIA";
            this.lblCATEGORIA.Size = new System.Drawing.Size(0, 13);
            this.lblCATEGORIA.TabIndex = 51;
            this.lblCATEGORIA.Click += new System.EventHandler(this.lblCATEGORIA_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 479);
            this.Controls.Add(this.lblCATEGORIA);
            this.Controls.Add(this.lblMARCA);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.txtCANTOPERATIVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCATEGORIA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMARCA);
            this.Controls.Add(this.ckbACTIVO);
            this.Controls.Add(this.lblESTADO);
            this.Controls.Add(this.lblCLAVE);
            this.Controls.Add(this.txtPRECIO);
            this.Controls.Add(this.lblNOMBRE);
            this.Controls.Add(this.txtCANTMINIMA);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbACTIVO;
        private System.Windows.Forms.Label lblESTADO;
        private System.Windows.Forms.Label lblCLAVE;
        private System.Windows.Forms.TextBox txtPRECIO;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.TextBox txtCANTMINIMA;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Button btnMARCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCATEGORIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCANTOPERATIVA;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label lblMARCA;
        private System.Windows.Forms.Label lblCATEGORIA;
    }
}