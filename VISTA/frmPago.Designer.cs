namespace VISTA
{
    partial class frmPago
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
            this.lblPRECIOCUOTA = new System.Windows.Forms.Label();
            this.txtPRECIOCUOTA = new System.Windows.Forms.TextBox();
            this.lblCANTIDADCUOTAS = new System.Windows.Forms.Label();
            this.lblFORMADEPAGO = new System.Windows.Forms.Label();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.lblTOTALFINAL = new System.Windows.Forms.Label();
            this.txtTOTALFINAL = new System.Windows.Forms.TextBox();
            this.cmbFORMADEPAGO = new System.Windows.Forms.ComboBox();
            this.cmbCANTIDADCUOTAS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPRECIOCUOTA
            // 
            this.lblPRECIOCUOTA.AutoSize = true;
            this.lblPRECIOCUOTA.Location = new System.Drawing.Point(29, 184);
            this.lblPRECIOCUOTA.Name = "lblPRECIOCUOTA";
            this.lblPRECIOCUOTA.Size = new System.Drawing.Size(93, 17);
            this.lblPRECIOCUOTA.TabIndex = 35;
            this.lblPRECIOCUOTA.Text = "Precio Cuota:";
            // 
            // txtPRECIOCUOTA
            // 
            this.txtPRECIOCUOTA.Location = new System.Drawing.Point(189, 184);
            this.txtPRECIOCUOTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPRECIOCUOTA.Name = "txtPRECIOCUOTA";
            this.txtPRECIOCUOTA.Size = new System.Drawing.Size(257, 22);
            this.txtPRECIOCUOTA.TabIndex = 34;
            // 
            // lblCANTIDADCUOTAS
            // 
            this.lblCANTIDADCUOTAS.AutoSize = true;
            this.lblCANTIDADCUOTAS.Location = new System.Drawing.Point(29, 135);
            this.lblCANTIDADCUOTAS.Name = "lblCANTIDADCUOTAS";
            this.lblCANTIDADCUOTAS.Size = new System.Drawing.Size(136, 17);
            this.lblCANTIDADCUOTAS.TabIndex = 33;
            this.lblCANTIDADCUOTAS.Text = "Cantidad de Cuotas:";
            // 
            // lblFORMADEPAGO
            // 
            this.lblFORMADEPAGO.AutoSize = true;
            this.lblFORMADEPAGO.Location = new System.Drawing.Point(29, 86);
            this.lblFORMADEPAGO.Name = "lblFORMADEPAGO";
            this.lblFORMADEPAGO.Size = new System.Drawing.Size(109, 17);
            this.lblFORMADEPAGO.TabIndex = 31;
            this.lblFORMADEPAGO.Text = "Forma de Pago:";
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Location = new System.Drawing.Point(29, 36);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(44, 17);
            this.lblTOTAL.TabIndex = 29;
            this.lblTOTAL.Text = "Total:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(189, 36);
            this.txtTOTAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(257, 22);
            this.txtTOTAL.TabIndex = 28;
            this.txtTOTAL.TextChanged += new System.EventHandler(this.txtTOTAL_TextChanged);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(32, 399);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(414, 43);
            this.btnCANCELAR.TabIndex = 37;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(32, 306);
            this.btnGUARDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(414, 76);
            this.btnGUARDAR.TabIndex = 36;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // lblTOTALFINAL
            // 
            this.lblTOTALFINAL.AutoSize = true;
            this.lblTOTALFINAL.Location = new System.Drawing.Point(29, 233);
            this.lblTOTALFINAL.Name = "lblTOTALFINAL";
            this.lblTOTALFINAL.Size = new System.Drawing.Size(78, 17);
            this.lblTOTALFINAL.TabIndex = 39;
            this.lblTOTALFINAL.Text = "Total Final:";
            // 
            // txtTOTALFINAL
            // 
            this.txtTOTALFINAL.Location = new System.Drawing.Point(189, 233);
            this.txtTOTALFINAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTOTALFINAL.Name = "txtTOTALFINAL";
            this.txtTOTALFINAL.Size = new System.Drawing.Size(257, 22);
            this.txtTOTALFINAL.TabIndex = 38;
            // 
            // cmbFORMADEPAGO
            // 
            this.cmbFORMADEPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFORMADEPAGO.FormattingEnabled = true;
            this.cmbFORMADEPAGO.Location = new System.Drawing.Point(189, 82);
            this.cmbFORMADEPAGO.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFORMADEPAGO.Name = "cmbFORMADEPAGO";
            this.cmbFORMADEPAGO.Size = new System.Drawing.Size(257, 24);
            this.cmbFORMADEPAGO.TabIndex = 40;
            this.cmbFORMADEPAGO.SelectedValueChanged += new System.EventHandler(this.cmbFORMADEPAGO_SelectedValueChanged);
            // 
            // cmbCANTIDADCUOTAS
            // 
            this.cmbCANTIDADCUOTAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCANTIDADCUOTAS.FormattingEnabled = true;
            this.cmbCANTIDADCUOTAS.Location = new System.Drawing.Point(189, 131);
            this.cmbCANTIDADCUOTAS.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCANTIDADCUOTAS.Name = "cmbCANTIDADCUOTAS";
            this.cmbCANTIDADCUOTAS.Size = new System.Drawing.Size(257, 24);
            this.cmbCANTIDADCUOTAS.TabIndex = 41;
            this.cmbCANTIDADCUOTAS.SelectedValueChanged += new System.EventHandler(this.cmbCANTIDADCUOTAS_SelectedValueChanged);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 535);
            this.Controls.Add(this.cmbCANTIDADCUOTAS);
            this.Controls.Add(this.cmbFORMADEPAGO);
            this.Controls.Add(this.lblTOTALFINAL);
            this.Controls.Add(this.txtTOTALFINAL);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.lblPRECIOCUOTA);
            this.Controls.Add(this.txtPRECIOCUOTA);
            this.Controls.Add(this.lblCANTIDADCUOTAS);
            this.Controls.Add(this.lblFORMADEPAGO);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.txtTOTAL);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPago";
            this.Text = "Sistema de Libreria - PAGO";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPRECIOCUOTA;
        private System.Windows.Forms.TextBox txtPRECIOCUOTA;
        private System.Windows.Forms.Label lblCANTIDADCUOTAS;
        private System.Windows.Forms.Label lblFORMADEPAGO;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label lblTOTALFINAL;
        private System.Windows.Forms.TextBox txtTOTALFINAL;
        private System.Windows.Forms.ComboBox cmbFORMADEPAGO;
        private System.Windows.Forms.ComboBox cmbCANTIDADCUOTAS;
    }
}