namespace VISTA
{
    partial class frmGrupo
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
            this.lblACCIONES = new System.Windows.Forms.Label();
            this.lblUSUARIOS = new System.Windows.Forms.Label();
            this.clbUSUARIOS = new System.Windows.Forms.CheckedListBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblGRUPO = new System.Windows.Forms.Label();
            this.txtGRUPO = new System.Windows.Forms.TextBox();
            this.lblESTADO = new System.Windows.Forms.Label();
            this.ckbACTIVO = new System.Windows.Forms.CheckBox();
            this.tvACCIONES = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblACCIONES
            // 
            this.lblACCIONES.AutoSize = true;
            this.lblACCIONES.Location = new System.Drawing.Point(27, 295);
            this.lblACCIONES.Name = "lblACCIONES";
            this.lblACCIONES.Size = new System.Drawing.Size(69, 17);
            this.lblACCIONES.TabIndex = 41;
            this.lblACCIONES.Text = "Acciones:";
            // 
            // lblUSUARIOS
            // 
            this.lblUSUARIOS.AutoSize = true;
            this.lblUSUARIOS.Location = new System.Drawing.Point(27, 123);
            this.lblUSUARIOS.Name = "lblUSUARIOS";
            this.lblUSUARIOS.Size = new System.Drawing.Size(68, 17);
            this.lblUSUARIOS.TabIndex = 40;
            this.lblUSUARIOS.Text = "Usuarios:";
            // 
            // clbUSUARIOS
            // 
            this.clbUSUARIOS.FormattingEnabled = true;
            this.clbUSUARIOS.Location = new System.Drawing.Point(27, 148);
            this.clbUSUARIOS.Margin = new System.Windows.Forms.Padding(4);
            this.clbUSUARIOS.Name = "clbUSUARIOS";
            this.clbUSUARIOS.Size = new System.Drawing.Size(425, 123);
            this.clbUSUARIOS.TabIndex = 39;
            this.clbUSUARIOS.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbUSUARIOS_ItemCheck);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(30, 591);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(422, 43);
            this.btnCANCELAR.TabIndex = 38;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(30, 509);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(422, 74);
            this.btnGUARDAR.TabIndex = 37;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblGRUPO
            // 
            this.lblGRUPO.AutoSize = true;
            this.lblGRUPO.Location = new System.Drawing.Point(27, 30);
            this.lblGRUPO.Name = "lblGRUPO";
            this.lblGRUPO.Size = new System.Drawing.Size(126, 17);
            this.lblGRUPO.TabIndex = 36;
            this.lblGRUPO.Text = "Nombre de Grupo:";
            // 
            // txtGRUPO
            // 
            this.txtGRUPO.Location = new System.Drawing.Point(187, 30);
            this.txtGRUPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGRUPO.Name = "txtGRUPO";
            this.txtGRUPO.Size = new System.Drawing.Size(257, 22);
            this.txtGRUPO.TabIndex = 35;
            // 
            // lblESTADO
            // 
            this.lblESTADO.AutoSize = true;
            this.lblESTADO.Location = new System.Drawing.Point(27, 74);
            this.lblESTADO.Name = "lblESTADO";
            this.lblESTADO.Size = new System.Drawing.Size(56, 17);
            this.lblESTADO.TabIndex = 43;
            this.lblESTADO.Text = "Estado:";
            // 
            // ckbACTIVO
            // 
            this.ckbACTIVO.AutoSize = true;
            this.ckbACTIVO.Location = new System.Drawing.Point(187, 74);
            this.ckbACTIVO.Margin = new System.Windows.Forms.Padding(4);
            this.ckbACTIVO.Name = "ckbACTIVO";
            this.ckbACTIVO.Size = new System.Drawing.Size(68, 21);
            this.ckbACTIVO.TabIndex = 44;
            this.ckbACTIVO.Text = "Activo";
            this.ckbACTIVO.UseVisualStyleBackColor = true;
            // 
            // tvACCIONES
            // 
            this.tvACCIONES.CheckBoxes = true;
            this.tvACCIONES.Location = new System.Drawing.Point(27, 320);
            this.tvACCIONES.Margin = new System.Windows.Forms.Padding(4);
            this.tvACCIONES.Name = "tvACCIONES";
            this.tvACCIONES.Size = new System.Drawing.Size(425, 171);
            this.tvACCIONES.TabIndex = 45;
            this.tvACCIONES.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvACCIONES_AfterCheck);
            // 
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 661);
            this.Controls.Add(this.tvACCIONES);
            this.Controls.Add(this.ckbACTIVO);
            this.Controls.Add(this.lblESTADO);
            this.Controls.Add(this.lblACCIONES);
            this.Controls.Add(this.lblUSUARIOS);
            this.Controls.Add(this.clbUSUARIOS);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblGRUPO);
            this.Controls.Add(this.txtGRUPO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGrupo";
            this.Text = "Sistema de Libreria - GRUPO";
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblACCIONES;
        private System.Windows.Forms.Label lblUSUARIOS;
        private System.Windows.Forms.CheckedListBox clbUSUARIOS;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblGRUPO;
        private System.Windows.Forms.TextBox txtGRUPO;
        private System.Windows.Forms.Label lblESTADO;
        private System.Windows.Forms.CheckBox ckbACTIVO;
        private System.Windows.Forms.TreeView tvACCIONES;
    }
}