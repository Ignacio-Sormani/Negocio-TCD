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
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvVENTAS = new System.Windows.Forms.DataGridView();
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.txtFACTURA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDARDEBAJA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.DarkGray;
            this.btnSALIR.Location = new System.Drawing.Point(727, 471);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(269, 35);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.BackColor = System.Drawing.Color.DarkGray;
            this.btnCONSULTAR.Location = new System.Drawing.Point(727, 201);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(269, 44);
            this.btnCONSULTAR.TabIndex = 10;
            this.btnCONSULTAR.Text = "CONSULTAR";
            this.btnCONSULTAR.UseVisualStyleBackColor = false;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.DarkGray;
            this.btnAGREGAR.Location = new System.Drawing.Point(727, 151);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(269, 44);
            this.btnAGREGAR.TabIndex = 8;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvVENTAS
            // 
            this.dgvVENTAS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVENTAS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvVENTAS.Location = new System.Drawing.Point(12, 151);
            this.dgvVENTAS.Name = "dgvVENTAS";
            this.dgvVENTAS.Size = new System.Drawing.Size(709, 355);
            this.dgvVENTAS.TabIndex = 7;
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Location = new System.Drawing.Point(214, 53);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(200, 20);
            this.txtCLIENTE.TabIndex = 13;
            this.txtCLIENTE.TextChanged += new System.EventHandler(this.txtCLIENTE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero Cliente:";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.BackColor = System.Drawing.Color.DarkGray;
            this.btnBUSCAR.Location = new System.Drawing.Point(459, 29);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(98, 66);
            this.btnBUSCAR.TabIndex = 14;
            this.btnBUSCAR.Text = "BUSCAR";
            this.btnBUSCAR.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha:";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(214, 94);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 20);
            this.dtpFECHA.TabIndex = 16;
            // 
            // txtFACTURA
            // 
            this.txtFACTURA.Location = new System.Drawing.Point(214, 12);
            this.txtFACTURA.Name = "txtFACTURA";
            this.txtFACTURA.Size = new System.Drawing.Size(200, 20);
            this.txtFACTURA.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Numero Factura:";
            // 
            // btnDARDEBAJA
            // 
            this.btnDARDEBAJA.BackColor = System.Drawing.Color.DarkGray;
            this.btnDARDEBAJA.Location = new System.Drawing.Point(727, 251);
            this.btnDARDEBAJA.Name = "btnDARDEBAJA";
            this.btnDARDEBAJA.Size = new System.Drawing.Size(269, 44);
            this.btnDARDEBAJA.TabIndex = 19;
            this.btnDARDEBAJA.Text = "DAR DE BAJA";
            this.btnDARDEBAJA.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnDARDEBAJA);
            this.Controls.Add(this.txtFACTURA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.txtCLIENTE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvVENTAS);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvVENTAS;
        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.TextBox txtFACTURA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDARDEBAJA;
    }
}