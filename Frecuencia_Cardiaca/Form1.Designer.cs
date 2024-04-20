namespace Frecuencia_Cardiaca
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pbGuardar = new System.Windows.Forms.ProgressBar();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lbltabla_registros = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chTiempoRealHR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUmbral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBaudios = new System.Windows.Forms.ComboBox();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.btnPuerto = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chrRegistro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Serialport = new System.IO.Ports.SerialPort(this.components);
            this.Frecuencia_Cardiaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTiempoRealHR)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(617, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 111);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Controls.Add(this.pbGuardar);
            this.panel8.Controls.Add(this.lblTiempo);
            this.panel8.Controls.Add(this.lbltabla_registros);
            this.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Location = new System.Drawing.Point(-3, -2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(584, 64);
            this.panel8.TabIndex = 1;
            // 
            // pbGuardar
            // 
            this.pbGuardar.Location = new System.Drawing.Point(179, 19);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(235, 21);
            this.pbGuardar.TabIndex = 0;
            this.pbGuardar.Visible = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(445, 19);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(78, 24);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lbltabla_registros
            // 
            this.lbltabla_registros.AutoSize = true;
            this.lbltabla_registros.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabla_registros.Location = new System.Drawing.Point(14, 19);
            this.lbltabla_registros.Name = "lbltabla_registros";
            this.lbltabla_registros.Size = new System.Drawing.Size(159, 24);
            this.lbltabla_registros.TabIndex = 2;
            this.lbltabla_registros.Text = "Tabla de registro";
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(3, 68);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(126, 40);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(384, 68);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 40);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.chTiempoRealHR);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(11, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 411);
            this.panel2.TabIndex = 1;
            // 
            // chTiempoRealHR
            // 
            this.chTiempoRealHR.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            this.chTiempoRealHR.BorderlineColor = System.Drawing.SystemColors.AppWorkspace;
            this.chTiempoRealHR.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea15.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea15.AxisX.Interval = 5D;
            chartArea15.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea15.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea15.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea15.AxisX.Maximum = 101D;
            chartArea15.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea15.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea15.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea15.AxisY.Maximum = 1100D;
            chartArea15.AxisY.Minimum = 0D;
            chartArea15.Name = "ChartArea1";
            this.chTiempoRealHR.ChartAreas.Add(chartArea15);
            legend15.Alignment = System.Drawing.StringAlignment.Center;
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend15.Name = "Legend1";
            legend15.TextWrapThreshold = 40;
            this.chTiempoRealHR.Legends.Add(legend15);
            this.chTiempoRealHR.Location = new System.Drawing.Point(13, 65);
            this.chTiempoRealHR.Name = "chTiempoRealHR";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series22.Color = System.Drawing.Color.Red;
            series22.Legend = "Legend1";
            series22.LegendText = "Señal de la frecuencia cardiaca en el tiempo real (000)";
            series22.Name = "Series1";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series23.Legend = "Legend1";
            series23.LegendText = "Umbral";
            series23.Name = "Series2";
            this.chTiempoRealHR.Series.Add(series22);
            this.chTiempoRealHR.Series.Add(series23);
            this.chTiempoRealHR.Size = new System.Drawing.Size(567, 332);
            this.chTiempoRealHR.TabIndex = 2;
            this.chTiempoRealHR.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.label1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(596, 59);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafica (Frecuencia cardiaca en teimpo real";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblstatus);
            this.panel3.Controls.Add(this.lblConexion);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 64);
            this.panel3.TabIndex = 1;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(325, 16);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(77, 24);
            this.lblstatus.TabIndex = 5;
            this.lblstatus.Text = "Estado:";
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.Location = new System.Drawing.Point(15, 16);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(95, 24);
            this.lblConexion.TabIndex = 3;
            this.lblConexion.Text = "Conexion";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.txtUmbral);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cmbBaudios);
            this.panel4.Controls.Add(this.cmbPuerto);
            this.panel4.Controls.Add(this.btnPuerto);
            this.panel4.Controls.Add(this.btnGrabar);
            this.panel4.Controls.Add(this.btnConectar);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(11, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 244);
            this.panel4.TabIndex = 1;
            // 
            // txtUmbral
            // 
            this.txtUmbral.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmbral.Location = new System.Drawing.Point(211, 168);
            this.txtUmbral.Name = "txtUmbral";
            this.txtUmbral.Size = new System.Drawing.Size(62, 27);
            this.txtUmbral.TabIndex = 10;
            this.txtUmbral.Text = "600";
            this.txtUmbral.TextChanged += new System.EventHandler(this.txtUmbral_TextChanged);
            this.txtUmbral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUmbral_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Umbral:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Baudios:";
            // 
            // cmbBaudios
            // 
            this.cmbBaudios.FormattingEnabled = true;
            this.cmbBaudios.Location = new System.Drawing.Point(211, 122);
            this.cmbBaudios.Name = "cmbBaudios";
            this.cmbBaudios.Size = new System.Drawing.Size(243, 24);
            this.cmbBaudios.TabIndex = 9;
            this.cmbBaudios.SelectedIndexChanged += new System.EventHandler(this.cmbBaudios_SelectedIndexChanged);
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(211, 73);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(243, 24);
            this.cmbPuerto.TabIndex = 8;
            this.cmbPuerto.DropDown += new System.EventHandler(this.cmbPuerto_DropDown);
            // 
            // btnPuerto
            // 
            this.btnPuerto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuerto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPuerto.Location = new System.Drawing.Point(21, 73);
            this.btnPuerto.Name = "btnPuerto";
            this.btnPuerto.Size = new System.Drawing.Size(123, 29);
            this.btnPuerto.TabIndex = 7;
            this.btnPuerto.Text = "Puerto";
            this.btnPuerto.UseVisualStyleBackColor = true;
            this.btnPuerto.Click += new System.EventHandler(this.btnPuerto_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGrabar.Location = new System.Drawing.Point(380, 208);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(123, 29);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Enabled = false;
            this.btnConectar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectar.Location = new System.Drawing.Point(21, 208);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(123, 29);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Controls.Add(this.label5);
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(584, 59);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grafica de registro de frecuencia cardiaca";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Controls.Add(this.chrRegistro);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Location = new System.Drawing.Point(614, 353);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 335);
            this.panel7.TabIndex = 1;
            // 
            // chrRegistro
            // 
            this.chrRegistro.BorderlineColor = System.Drawing.SystemColors.AppWorkspace;
            this.chrRegistro.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea16.AxisX.Interval = 1D;
            chartArea16.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea16.AxisX.IsLabelAutoFit = false;
            chartArea16.AxisX.LabelStyle.Angle = -45;
            chartArea16.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea16.AxisX.Maximum = 13D;
            chartArea16.AxisX.Minimum = 0D;
            chartArea16.AxisY.Interval = 50D;
            chartArea16.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea16.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea16.AxisY.Maximum = 300D;
            chartArea16.AxisY.Minimum = 0D;
            chartArea16.Name = "ChartArea1";
            this.chrRegistro.ChartAreas.Add(chartArea16);
            legend16.Alignment = System.Drawing.StringAlignment.Center;
            legend16.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend16.Name = "Legend1";
            this.chrRegistro.Legends.Add(legend16);
            this.chrRegistro.Location = new System.Drawing.Point(11, 65);
            this.chrRegistro.Name = "chrRegistro";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.Lime;
            series24.IsValueShownAsLabel = true;
            series24.LabelForeColor = System.Drawing.Color.Lime;
            series24.Legend = "Legend1";
            series24.LegendText = "Frecuencia Cardiaca (LPM)";
            series24.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series24.Name = "Series1";
            this.chrRegistro.Series.Add(series24);
            this.chrRegistro.Size = new System.Drawing.Size(567, 267);
            this.chrRegistro.TabIndex = 3;
            this.chrRegistro.Text = "chrRegistro";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Serialport
            // 
            this.Serialport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serialport_DataReceived);
            // 
            // Frecuencia_Cardiaca
            // 
            this.Frecuencia_Cardiaca.HeaderText = "Frecuencia_Cardiaca";
            this.Frecuencia_Cardiaca.MinimumWidth = 6;
            this.Frecuencia_Cardiaca.Name = "Frecuencia_Cardiaca";
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.MinimumWidth = 6;
            this.Tiempo.Name = "Tiempo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiempo,
            this.Frecuencia_Cardiaca});
            this.dataGridView1.Location = new System.Drawing.Point(617, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1221, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chTiempoRealHR)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnPuerto;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ProgressBar pbGuardar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lbltabla_registros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTiempoRealHR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.ComboBox cmbBaudios;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort Serialport;
        private System.Windows.Forms.TextBox txtUmbral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Cardiaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

