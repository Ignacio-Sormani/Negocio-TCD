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
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvPLANILLA = new System.Windows.Forms.DataGridView();
            this.cmbTIPO = new System.Windows.Forms.ComboBox();
            this.btnFILTRAR = new System.Windows.Forms.Button();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.lblDESDE = new System.Windows.Forms.Label();
            this.lblHASTA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLANILLA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGENERARARCHIVO
            // 
            this.btnGENERARARCHIVO.Location = new System.Drawing.Point(13, 636);
            this.btnGENERARARCHIVO.Margin = new System.Windows.Forms.Padding(4);
            this.btnGENERARARCHIVO.Name = "btnGENERARARCHIVO";
            this.btnGENERARARCHIVO.Size = new System.Drawing.Size(265, 86);
            this.btnGENERARARCHIVO.TabIndex = 0;
            this.btnGENERARARCHIVO.Text = "Generar Planilla Excel";
            this.btnGENERARARCHIVO.UseVisualStyleBackColor = true;
            this.btnGENERARARCHIVO.Click += new System.EventHandler(this.btnGENERARARCHIVO_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Location = new System.Drawing.Point(806, 677);
            this.btnCERRAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(265, 45);
            this.btnCERRAR.TabIndex = 1;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // dgvPLANILLA
            // 
            this.dgvPLANILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPLANILLA.Location = new System.Drawing.Point(13, 132);
            this.dgvPLANILLA.Name = "dgvPLANILLA";
            this.dgvPLANILLA.RowTemplate.Height = 24;
            this.dgvPLANILLA.Size = new System.Drawing.Size(1058, 497);
            this.dgvPLANILLA.TabIndex = 2;
            // 
            // cmbTIPO
            // 
            this.cmbTIPO.FormattingEnabled = true;
            this.cmbTIPO.Location = new System.Drawing.Point(25, 76);
            this.cmbTIPO.Name = "cmbTIPO";
            this.cmbTIPO.Size = new System.Drawing.Size(434, 24);
            this.cmbTIPO.TabIndex = 3;
            this.cmbTIPO.SelectedIndexChanged += new System.EventHandler(this.cmbTIPO_SelectedIndexChanged);
            // 
            // btnFILTRAR
            // 
            this.btnFILTRAR.Location = new System.Drawing.Point(476, 70);
            this.btnFILTRAR.Name = "btnFILTRAR";
            this.btnFILTRAR.Size = new System.Drawing.Size(173, 35);
            this.btnFILTRAR.TabIndex = 4;
            this.btnFILTRAR.Text = "Filtrar";
            this.btnFILTRAR.UseVisualStyleBackColor = true;
            this.btnFILTRAR.Click += new System.EventHandler(this.btnFILTRAR_Click);
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Location = new System.Drawing.Point(81, 28);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(378, 22);
            this.dtpDESDE.TabIndex = 5;
            this.dtpDESDE.Value = new System.DateTime(2018, 10, 2, 0, 0, 0, 0);
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Location = new System.Drawing.Point(528, 28);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(378, 22);
            this.dtpHASTA.TabIndex = 6;
            // 
            // lblDESDE
            // 
            this.lblDESDE.AutoSize = true;
            this.lblDESDE.Location = new System.Drawing.Point(22, 28);
            this.lblDESDE.Name = "lblDESDE";
            this.lblDESDE.Size = new System.Drawing.Size(53, 17);
            this.lblDESDE.TabIndex = 7;
            this.lblDESDE.Text = "Desde:";
            // 
            // lblHASTA
            // 
            this.lblHASTA.AutoSize = true;
            this.lblHASTA.Location = new System.Drawing.Point(473, 28);
            this.lblHASTA.Name = "lblHASTA";
            this.lblHASTA.Size = new System.Drawing.Size(49, 17);
            this.lblHASTA.TabIndex = 8;
            this.lblHASTA.Text = "Hasta:";
            // 
            // frmArchivoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 735);
            this.Controls.Add(this.lblHASTA);
            this.Controls.Add(this.lblDESDE);
            this.Controls.Add(this.dtpHASTA);
            this.Controls.Add(this.dtpDESDE);
            this.Controls.Add(this.btnFILTRAR);
            this.Controls.Add(this.cmbTIPO);
            this.Controls.Add(this.dgvPLANILLA);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnGENERARARCHIVO);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArchivoDeDatos";
            this.Text = "Sistema de Libreria - Archivos de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPLANILLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGENERARARCHIVO;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvPLANILLA;
        private System.Windows.Forms.ComboBox cmbTIPO;
        private System.Windows.Forms.Button btnFILTRAR;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.Label lblDESDE;
        private System.Windows.Forms.Label lblHASTA;
    }
}