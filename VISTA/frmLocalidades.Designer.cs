namespace VISTA
{
    partial class frmLocalidades
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
            this.btnTODOS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.btnSALIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTODOS
            // 
            this.btnTODOS.Location = new System.Drawing.Point(835, 199);
            this.btnTODOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnTODOS.Name = "btnTODOS";
            this.btnTODOS.Size = new System.Drawing.Size(179, 88);
            this.btnTODOS.TabIndex = 36;
            this.btnTODOS.Text = "Ver Todos";
            this.btnTODOS.UseVisualStyleBackColor = true;
            this.btnTODOS.Click += new System.EventHandler(this.btnTODOS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(336, 28);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(292, 28);
            this.btnBUSCAR.TabIndex = 35;
            this.btnBUSCAR.Text = "Buscar por nombre";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(316, 22);
            this.txtBuscar.TabIndex = 34;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(666, 454);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(155, 57);
            this.btnELIMINAR.TabIndex = 33;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(351, 454);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(155, 57);
            this.btnMODIFICAR.TabIndex = 32;
            this.btnMODIFICAR.Text = "MODIFICAR";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 454);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(155, 57);
            this.btnAGREGAR.TabIndex = 31;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.AllowUserToAddRows = false;
            this.dgvLocalidades.AllowUserToDeleteRows = false;
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(13, 67);
            this.dgvLocalidades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.ReadOnly = true;
            this.dgvLocalidades.Size = new System.Drawing.Size(808, 379);
            this.dgvLocalidades.TabIndex = 30;
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(847, 306);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(4);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(155, 57);
            this.btnSALIR.TabIndex = 37;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 541);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnTODOS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvLocalidades);
            this.Name = "frmLocalidades";
            this.Text = "Localidades ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTODOS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.Button btnSALIR;
    }
}