namespace VISTA
{
    partial class frmVenta
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
            this.txtCLIENTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvINSUMOS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAGREGARPRODUCTO = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnELIMINARPRODUCTO = new System.Windows.Forms.Button();
            this.panAGREGAR = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINSUMOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panAGREGAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCLIENTE
            // 
            this.txtCLIENTE.Location = new System.Drawing.Point(175, 45);
            this.txtCLIENTE.Name = "txtCLIENTE";
            this.txtCLIENTE.Size = new System.Drawing.Size(176, 20);
            this.txtCLIENTE.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente:";
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.DarkGray;
            this.btnSALIR.Location = new System.Drawing.Point(885, 626);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(111, 64);
            this.btnSALIR.TabIndex = 17;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = false;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.BackColor = System.Drawing.Color.DarkGray;
            this.btnAGREGAR.Location = new System.Drawing.Point(12, 575);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(636, 64);
            this.btnAGREGAR.TabIndex = 15;
            this.btnAGREGAR.Text = "CONFIRMAR VENTA";
            this.btnAGREGAR.UseVisualStyleBackColor = false;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvINSUMOS
            // 
            this.dgvINSUMOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvINSUMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINSUMOS.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvINSUMOS.Location = new System.Drawing.Point(12, 113);
            this.dgvINSUMOS.Name = "dgvINSUMOS";
            this.dgvINSUMOS.Size = new System.Drawing.Size(636, 355);
            this.dgvINSUMOS.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha:";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(175, 12);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(176, 20);
            this.dtpFECHA.TabIndex = 21;
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(509, 483);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(139, 20);
            this.txtTOTAL.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "TOTAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Productos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Producto Seleccionado";
            // 
            // btnAGREGARPRODUCTO
            // 
            this.btnAGREGARPRODUCTO.BackColor = System.Drawing.Color.DarkGray;
            this.btnAGREGARPRODUCTO.Location = new System.Drawing.Point(680, 106);
            this.btnAGREGARPRODUCTO.Name = "btnAGREGARPRODUCTO";
            this.btnAGREGARPRODUCTO.Size = new System.Drawing.Size(240, 32);
            this.btnAGREGARPRODUCTO.TabIndex = 26;
            this.btnAGREGARPRODUCTO.Text = "AGREGAR PRODUCTO";
            this.btnAGREGARPRODUCTO.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cantidad:";
            // 
            // btnELIMINARPRODUCTO
            // 
            this.btnELIMINARPRODUCTO.BackColor = System.Drawing.Color.DarkGray;
            this.btnELIMINARPRODUCTO.Location = new System.Drawing.Point(680, 340);
            this.btnELIMINARPRODUCTO.Name = "btnELIMINARPRODUCTO";
            this.btnELIMINARPRODUCTO.Size = new System.Drawing.Size(240, 32);
            this.btnELIMINARPRODUCTO.TabIndex = 30;
            this.btnELIMINARPRODUCTO.Text = "ELIMINAR PRODUCTO";
            this.btnELIMINARPRODUCTO.UseVisualStyleBackColor = false;
            // 
            // panAGREGAR
            // 
            this.panAGREGAR.Controls.Add(this.button2);
            this.panAGREGAR.Controls.Add(this.button1);
            this.panAGREGAR.Controls.Add(this.label6);
            this.panAGREGAR.Controls.Add(this.numericUpDown1);
            this.panAGREGAR.Controls.Add(this.label5);
            this.panAGREGAR.Location = new System.Drawing.Point(680, 166);
            this.panAGREGAR.Name = "panAGREGAR";
            this.panAGREGAR.Size = new System.Drawing.Size(244, 94);
            this.panAGREGAR.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(201, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(201, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(680, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 32);
            this.button3.TabIndex = 32;
            this.button3.Text = "MODIFICAR PRODUCTO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panAGREGAR);
            this.Controls.Add(this.btnELIMINARPRODUCTO);
            this.Controls.Add(this.btnAGREGARPRODUCTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCLIENTE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvINSUMOS);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvINSUMOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panAGREGAR.ResumeLayout(false);
            this.panAGREGAR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvINSUMOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAGREGARPRODUCTO;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnELIMINARPRODUCTO;
        private System.Windows.Forms.Panel panAGREGAR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}