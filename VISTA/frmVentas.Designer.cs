namespace VISTA
{
    partial class frmVentas
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
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvVENTAS = new System.Windows.Forms.DataGridView();
            this.btnTODAS = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.lblVENTA = new System.Windows.Forms.Label();
            this.txtVENTA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Location = new System.Drawing.Point(244, 377);
            this.btnCONSULTAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(194, 35);
            this.btnCONSULTAR.TabIndex = 58;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(479, 377);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(194, 35);
            this.btnSALIR.TabIndex = 55;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(11, 377);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(194, 35);
            this.btnAGREGAR.TabIndex = 53;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvVENTAS
            // 
            this.dgvVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVENTAS.Location = new System.Drawing.Point(11, 80);
            this.dgvVENTAS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVENTAS.Name = "dgvVENTAS";
            this.dgvVENTAS.RowTemplate.Height = 24;
            this.dgvVENTAS.Size = new System.Drawing.Size(662, 278);
            this.dgvVENTAS.TabIndex = 52;
            // 
            // btnTODAS
            // 
            this.btnTODAS.Location = new System.Drawing.Point(577, 39);
            this.btnTODAS.Margin = new System.Windows.Forms.Padding(2);
            this.btnTODAS.Name = "btnTODAS";
            this.btnTODAS.Size = new System.Drawing.Size(96, 20);
            this.btnTODAS.TabIndex = 64;
            this.btnTODAS.Text = "Ver todas";
            this.btnTODAS.UseVisualStyleBackColor = true;
            this.btnTODAS.Click += new System.EventHandler(this.btnTODAS_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(577, 11);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(96, 20);
            this.btnBUSCAR.TabIndex = 62;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // lblVENTA
            // 
            this.lblVENTA.AutoSize = true;
            this.lblVENTA.Location = new System.Drawing.Point(44, 18);
            this.lblVENTA.Name = "lblVENTA";
            this.lblVENTA.Size = new System.Drawing.Size(170, 13);
            this.lblVENTA.TabIndex = 68;
            this.lblVENTA.Text = "Nombre cliente o codigo de venta:";
            // 
            // txtVENTA
            // 
            this.txtVENTA.Location = new System.Drawing.Point(324, 18);
            this.txtVENTA.Name = "txtVENTA";
            this.txtVENTA.Size = new System.Drawing.Size(200, 20);
            this.txtVENTA.TabIndex = 71;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.txtVENTA);
            this.Controls.Add(this.lblVENTA);
            this.Controls.Add(this.btnTODAS);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvVENTAS);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvVENTAS;
        private System.Windows.Forms.Button btnTODAS;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label lblVENTA;
        private System.Windows.Forms.TextBox txtVENTA;
    }
}