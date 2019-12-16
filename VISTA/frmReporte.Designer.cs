namespace VISTA
{
    partial class frmReporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.btnGENERARREPORTE = new System.Windows.Forms.Button();
            this.chartGRAFICOUNO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGRAFICODOS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUNOCANTIDAD = new System.Windows.Forms.Label();
            this.dtpINICIO = new System.Windows.Forms.DateTimePicker();
            this.dtpFIN = new System.Windows.Forms.DateTimePicker();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.dgvUNO = new System.Windows.Forms.DataGridView();
            this.lblUNOTITLE = new System.Windows.Forms.Label();
            this.lblNOMBREGRAFICODOS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDOS = new System.Windows.Forms.DataGridView();
            this.lblNOMBREGRAFICOUNO = new System.Windows.Forms.Label();
            this.lblDOSTITLE = new System.Windows.Forms.Label();
            this.lblDOSCANTIDA = new System.Windows.Forms.Label();
            this.lblTRESTITLE = new System.Windows.Forms.Label();
            this.lblTRESCANTIDAD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbTIPO = new System.Windows.Forms.ComboBox();
            this.lblCANTIDADES = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGRAFICOUNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGRAFICODOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGENERARREPORTE
            // 
            this.btnGENERARREPORTE.Location = new System.Drawing.Point(339, 736);
            this.btnGENERARREPORTE.Margin = new System.Windows.Forms.Padding(4);
            this.btnGENERARREPORTE.Name = "btnGENERARREPORTE";
            this.btnGENERARREPORTE.Size = new System.Drawing.Size(211, 95);
            this.btnGENERARREPORTE.TabIndex = 1;
            this.btnGENERARREPORTE.Text = "Generar Reporte";
            this.btnGENERARREPORTE.UseVisualStyleBackColor = true;
            this.btnGENERARREPORTE.Click += new System.EventHandler(this.btnGENERARREPORTE_Click);
            // 
            // chartGRAFICOUNO
            // 
            this.chartGRAFICOUNO.BackColor = System.Drawing.Color.Linen;
            this.chartGRAFICOUNO.BorderlineColor = System.Drawing.Color.Linen;
            chartArea5.BackColor = System.Drawing.Color.Linen;
            chartArea5.Name = "ChartArea1";
            this.chartGRAFICOUNO.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGRAFICOUNO.Legends.Add(legend5);
            this.chartGRAFICOUNO.Location = new System.Drawing.Point(692, 178);
            this.chartGRAFICOUNO.Name = "chartGRAFICOUNO";
            this.chartGRAFICOUNO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartGRAFICOUNO.Series.Add(series5);
            this.chartGRAFICOUNO.Size = new System.Drawing.Size(652, 425);
            this.chartGRAFICOUNO.TabIndex = 2;
            this.chartGRAFICOUNO.Text = "chart2";
            // 
            // chartGRAFICODOS
            // 
            this.chartGRAFICODOS.BackColor = System.Drawing.Color.Linen;
            chartArea6.BackColor = System.Drawing.Color.SandyBrown;
            chartArea6.Name = "ChartArea1";
            this.chartGRAFICODOS.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartGRAFICODOS.Legends.Add(legend6);
            this.chartGRAFICODOS.Location = new System.Drawing.Point(12, 59);
            this.chartGRAFICODOS.Name = "chartGRAFICODOS";
            this.chartGRAFICODOS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Legend = "Legend1";
            series6.Name = "Datos";
            series6.YValuesPerPoint = 2;
            this.chartGRAFICODOS.Series.Add(series6);
            this.chartGRAFICODOS.Size = new System.Drawing.Size(669, 425);
            this.chartGRAFICODOS.TabIndex = 3;
            this.chartGRAFICODOS.Text = "chart1";
            // 
            // lblUNOCANTIDAD
            // 
            this.lblUNOCANTIDAD.AutoSize = true;
            this.lblUNOCANTIDAD.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblUNOCANTIDAD.Location = new System.Drawing.Point(762, 87);
            this.lblUNOCANTIDAD.Name = "lblUNOCANTIDAD";
            this.lblUNOCANTIDAD.Size = new System.Drawing.Size(46, 17);
            this.lblUNOCANTIDAD.TabIndex = 4;
            this.lblUNOCANTIDAD.Text = "label1";
            // 
            // dtpINICIO
            // 
            this.dtpINICIO.Location = new System.Drawing.Point(171, 651);
            this.dtpINICIO.Name = "dtpINICIO";
            this.dtpINICIO.Size = new System.Drawing.Size(379, 22);
            this.dtpINICIO.TabIndex = 5;
            this.dtpINICIO.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            // 
            // dtpFIN
            // 
            this.dtpFIN.Location = new System.Drawing.Point(171, 697);
            this.dtpFIN.Name = "dtpFIN";
            this.dtpFIN.Size = new System.Drawing.Size(379, 22);
            this.dtpFIN.TabIndex = 6;
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(1116, 772);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(282, 75);
            this.btnSALIR.TabIndex = 7;
            this.btnSALIR.Text = "Cerrar";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // dgvUNO
            // 
            this.dgvUNO.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvUNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUNO.Location = new System.Drawing.Point(744, 622);
            this.dgvUNO.Name = "dgvUNO";
            this.dgvUNO.RowTemplate.Height = 24;
            this.dgvUNO.Size = new System.Drawing.Size(455, 128);
            this.dgvUNO.TabIndex = 8;
            // 
            // lblUNOTITLE
            // 
            this.lblUNOTITLE.AutoSize = true;
            this.lblUNOTITLE.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblUNOTITLE.Location = new System.Drawing.Point(762, 59);
            this.lblUNOTITLE.Name = "lblUNOTITLE";
            this.lblUNOTITLE.Size = new System.Drawing.Size(46, 17);
            this.lblUNOTITLE.TabIndex = 9;
            this.lblUNOTITLE.Text = "label1";
            // 
            // lblNOMBREGRAFICODOS
            // 
            this.lblNOMBREGRAFICODOS.AutoSize = true;
            this.lblNOMBREGRAFICODOS.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMBREGRAFICODOS.Location = new System.Drawing.Point(59, 27);
            this.lblNOMBREGRAFICODOS.Name = "lblNOMBREGRAFICODOS";
            this.lblNOMBREGRAFICODOS.Size = new System.Drawing.Size(68, 29);
            this.lblNOMBREGRAFICODOS.TabIndex = 10;
            this.lblNOMBREGRAFICODOS.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Desde:";
            // 
            // dgvDOS
            // 
            this.dgvDOS.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvDOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDOS.Location = new System.Drawing.Point(95, 511);
            this.dgvDOS.Name = "dgvDOS";
            this.dgvDOS.RowTemplate.Height = 24;
            this.dgvDOS.Size = new System.Drawing.Size(455, 128);
            this.dgvDOS.TabIndex = 13;
            // 
            // lblNOMBREGRAFICOUNO
            // 
            this.lblNOMBREGRAFICOUNO.AutoSize = true;
            this.lblNOMBREGRAFICOUNO.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMBREGRAFICOUNO.Location = new System.Drawing.Point(739, 146);
            this.lblNOMBREGRAFICOUNO.Name = "lblNOMBREGRAFICOUNO";
            this.lblNOMBREGRAFICOUNO.Size = new System.Drawing.Size(68, 29);
            this.lblNOMBREGRAFICOUNO.TabIndex = 14;
            this.lblNOMBREGRAFICOUNO.Text = "label1";
            // 
            // lblDOSTITLE
            // 
            this.lblDOSTITLE.AutoSize = true;
            this.lblDOSTITLE.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDOSTITLE.Location = new System.Drawing.Point(985, 56);
            this.lblDOSTITLE.Name = "lblDOSTITLE";
            this.lblDOSTITLE.Size = new System.Drawing.Size(46, 17);
            this.lblDOSTITLE.TabIndex = 16;
            this.lblDOSTITLE.Text = "label1";
            // 
            // lblDOSCANTIDA
            // 
            this.lblDOSCANTIDA.AutoSize = true;
            this.lblDOSCANTIDA.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDOSCANTIDA.Location = new System.Drawing.Point(985, 91);
            this.lblDOSCANTIDA.Name = "lblDOSCANTIDA";
            this.lblDOSCANTIDA.Size = new System.Drawing.Size(46, 17);
            this.lblDOSCANTIDA.TabIndex = 15;
            this.lblDOSCANTIDA.Text = "label1";
            // 
            // lblTRESTITLE
            // 
            this.lblTRESTITLE.AutoSize = true;
            this.lblTRESTITLE.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTRESTITLE.Location = new System.Drawing.Point(1208, 56);
            this.lblTRESTITLE.Name = "lblTRESTITLE";
            this.lblTRESTITLE.Size = new System.Drawing.Size(46, 17);
            this.lblTRESTITLE.TabIndex = 18;
            this.lblTRESTITLE.Text = "label1";
            // 
            // lblTRESCANTIDAD
            // 
            this.lblTRESCANTIDAD.AutoSize = true;
            this.lblTRESCANTIDAD.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTRESCANTIDAD.Location = new System.Drawing.Point(1208, 92);
            this.lblTRESCANTIDAD.Name = "lblTRESCANTIDAD";
            this.lblTRESCANTIDAD.Size = new System.Drawing.Size(46, 17);
            this.lblTRESCANTIDAD.TabIndex = 17;
            this.lblTRESCANTIDAD.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 70);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(915, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 70);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1138, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 70);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // cmbTIPO
            // 
            this.cmbTIPO.FormattingEnabled = true;
            this.cmbTIPO.Location = new System.Drawing.Point(109, 772);
            this.cmbTIPO.Name = "cmbTIPO";
            this.cmbTIPO.Size = new System.Drawing.Size(223, 24);
            this.cmbTIPO.TabIndex = 22;
            // 
            // lblCANTIDADES
            // 
            this.lblCANTIDADES.AutoSize = true;
            this.lblCANTIDADES.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCANTIDADES.Location = new System.Drawing.Point(687, 9);
            this.lblCANTIDADES.Name = "lblCANTIDADES";
            this.lblCANTIDADES.Size = new System.Drawing.Size(68, 29);
            this.lblCANTIDADES.TabIndex = 23;
            this.lblCANTIDADES.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 772);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo:";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 859);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCANTIDADES);
            this.Controls.Add(this.cmbTIPO);
            this.Controls.Add(this.lblUNOTITLE);
            this.Controls.Add(this.lblTRESTITLE);
            this.Controls.Add(this.lblTRESCANTIDAD);
            this.Controls.Add(this.lblDOSTITLE);
            this.Controls.Add(this.lblDOSCANTIDA);
            this.Controls.Add(this.lblNOMBREGRAFICOUNO);
            this.Controls.Add(this.dgvDOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNOMBREGRAFICODOS);
            this.Controls.Add(this.dgvUNO);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.dtpFIN);
            this.Controls.Add(this.dtpINICIO);
            this.Controls.Add(this.lblUNOCANTIDAD);
            this.Controls.Add(this.chartGRAFICODOS);
            this.Controls.Add(this.chartGRAFICOUNO);
            this.Controls.Add(this.btnGENERARREPORTE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporte";
            this.Text = "Sistema de Libreria - REPORTE";
            ((System.ComponentModel.ISupportInitialize)(this.chartGRAFICOUNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGRAFICODOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGENERARREPORTE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGRAFICOUNO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGRAFICODOS;
        private System.Windows.Forms.Label lblUNOCANTIDAD;
        private System.Windows.Forms.DateTimePicker dtpINICIO;
        private System.Windows.Forms.DateTimePicker dtpFIN;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.DataGridView dgvUNO;
        private System.Windows.Forms.Label lblUNOTITLE;
        private System.Windows.Forms.Label lblNOMBREGRAFICODOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDOS;
        private System.Windows.Forms.Label lblNOMBREGRAFICOUNO;
        private System.Windows.Forms.Label lblDOSTITLE;
        private System.Windows.Forms.Label lblDOSCANTIDA;
        private System.Windows.Forms.Label lblTRESTITLE;
        private System.Windows.Forms.Label lblTRESCANTIDAD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbTIPO;
        private System.Windows.Forms.Label lblCANTIDADES;
        private System.Windows.Forms.Label label3;
    }
}