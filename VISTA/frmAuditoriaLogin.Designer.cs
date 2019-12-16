namespace VISTA
{
    partial class frmAuditoriaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoriaLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.lblPRODUCTO = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.dgvAUDITORIAS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAUDITORIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 25);
            this.button1.TabIndex = 44;
            this.button1.Text = "Ver Todos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPRODUCTO
            // 
            this.lblPRODUCTO.Location = new System.Drawing.Point(35, 14);
            this.lblPRODUCTO.Name = "lblPRODUCTO";
            this.lblPRODUCTO.Size = new System.Drawing.Size(46, 25);
            this.lblPRODUCTO.TabIndex = 42;
            this.lblPRODUCTO.Text = "Filtrar:";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(410, 11);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(125, 25);
            this.btnBUSCAR.TabIndex = 40;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(415, 626);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(259, 43);
            this.btnSALIR.TabIndex = 38;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(87, 11);
            this.txtBUSCAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(307, 22);
            this.txtBUSCAR.TabIndex = 39;
            // 
            // dgvAUDITORIAS
            // 
            this.dgvAUDITORIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAUDITORIAS.Location = new System.Drawing.Point(35, 80);
            this.dgvAUDITORIAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAUDITORIAS.Name = "dgvAUDITORIAS";
            this.dgvAUDITORIAS.RowTemplate.Height = 24;
            this.dgvAUDITORIAS.Size = new System.Drawing.Size(639, 523);
            this.dgvAUDITORIAS.TabIndex = 35;
            // 
            // frmAuditoriaLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPRODUCTO);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.dgvAUDITORIAS);
            this.Name = "frmAuditoriaLogins";
            this.Text = "Sistema de Libreria - AUDITORIAS LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAUDITORIAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPRODUCTO;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.DataGridView dgvAUDITORIAS;
    }
}