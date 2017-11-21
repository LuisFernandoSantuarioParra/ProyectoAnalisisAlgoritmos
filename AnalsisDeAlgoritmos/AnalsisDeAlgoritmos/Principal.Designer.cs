namespace AnalsisDeAlgoritmos
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme2 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.metroSeparator1 = new MetroSuite.MetroSeparator();
            this.TeslaLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.TimerAlgo = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cElementos = new System.Windows.Forms.ComboBox();
            this.GenerarNumeros = new System.Windows.Forms.Button();
            this.CirProgreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Aviso = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeslaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Controls.Add(this.metroSeparator1);
            this.BarraSuperior.Controls.Add(this.TeslaLogo);
            this.BarraSuperior.Controls.Add(this.MinWindow);
            this.BarraSuperior.Controls.Add(this.CloseWindow);
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1384, 26);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // metroSeparator1
            // 
            mainColorScheme2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme2.Color2 = System.Drawing.Color.White;
            this.metroSeparator1.ColorScheme = mainColorScheme2;
            this.metroSeparator1.Location = new System.Drawing.Point(4, 24);
            this.metroSeparator1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroSeparator1.Name = "metroSeparator1";
            this.metroSeparator1.Size = new System.Drawing.Size(1384, 2);
            this.metroSeparator1.TabIndex = 1;
            // 
            // TeslaLogo
            // 
            this.TeslaLogo.BackColor = System.Drawing.Color.SeaGreen;
            this.TeslaLogo.Enabled = false;
            this.TeslaLogo.Image = ((System.Drawing.Image)(resources.GetObject("TeslaLogo.Image")));
            this.TeslaLogo.ImageActive = null;
            this.TeslaLogo.Location = new System.Drawing.Point(0, 0);
            this.TeslaLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TeslaLogo.Name = "TeslaLogo";
            this.TeslaLogo.Size = new System.Drawing.Size(24, 26);
            this.TeslaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TeslaLogo.TabIndex = 1;
            this.TeslaLogo.TabStop = false;
            this.TeslaLogo.Zoom = 10;
            // 
            // MinWindow
            // 
            this.MinWindow.BackColor = System.Drawing.Color.Transparent;
            this.MinWindow.Image = ((System.Drawing.Image)(resources.GetObject("MinWindow.Image")));
            this.MinWindow.ImageActive = null;
            this.MinWindow.Location = new System.Drawing.Point(1338, 4);
            this.MinWindow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinWindow.Name = "MinWindow";
            this.MinWindow.Size = new System.Drawing.Size(16, 15);
            this.MinWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinWindow.TabIndex = 1;
            this.MinWindow.TabStop = false;
            this.MinWindow.Zoom = 10;
            this.MinWindow.Click += new System.EventHandler(this.MinWindow_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.ImageActive = null;
            this.CloseWindow.Location = new System.Drawing.Point(1360, 4);
            this.CloseWindow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(16, 15);
            this.CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseWindow.TabIndex = 1;
            this.CloseWindow.TabStop = false;
            this.CloseWindow.Zoom = 10;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Area3DStyle.Enable3D = true;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea5.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea5.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.ForeColor = System.Drawing.Color.White;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(2, 69);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(450, 299);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Area3DStyle.Enable3D = true;
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(458, 69);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(450, 299);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Area3DStyle.Enable3D = true;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(924, 69);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.LabelForeColor = System.Drawing.Color.White;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart3.Series.Add(series7);
            this.chart3.Size = new System.Drawing.Size(450, 299);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Area3DStyle.Enable3D = true;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea8);
            legend8.BackColor = System.Drawing.Color.Transparent;
            legend8.ForeColor = System.Drawing.Color.White;
            legend8.Name = "Legend1";
            this.chart4.Legends.Add(legend8);
            this.chart4.Location = new System.Drawing.Point(12, 379);
            this.chart4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart4.Name = "chart4";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.LabelForeColor = System.Drawing.Color.White;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart4.Series.Add(series8);
            this.chart4.Size = new System.Drawing.Size(616, 360);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chart4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bubble Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1090, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shell Sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(626, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insertion Sort";
            // 
            // cElementos
            // 
            this.cElementos.BackColor = System.Drawing.Color.White;
            this.cElementos.ForeColor = System.Drawing.Color.Black;
            this.cElementos.FormattingEnabled = true;
            this.cElementos.Items.AddRange(new object[] {
            "0",
            "100",
            "1000",
            "5000",
            "10000",
            "50000",
            "100000",
            "200000",
            "400000",
            "600000",
            "800000",
            "1000000",
            "2000000",
            "3000000",
            "4000000",
            "5000000",
            "6000000",
            "7000000",
            "8000000",
            "9000000",
            "10000000"});
            this.cElementos.Location = new System.Drawing.Point(1037, 470);
            this.cElementos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cElementos.Name = "cElementos";
            this.cElementos.Size = new System.Drawing.Size(120, 21);
            this.cElementos.TabIndex = 8;
            this.cElementos.Text = "0";
            // 
            // GenerarNumeros
            // 
            this.GenerarNumeros.BackColor = System.Drawing.Color.Black;
            this.GenerarNumeros.ForeColor = System.Drawing.Color.White;
            this.GenerarNumeros.Location = new System.Drawing.Point(1163, 470);
            this.GenerarNumeros.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GenerarNumeros.Name = "GenerarNumeros";
            this.GenerarNumeros.Size = new System.Drawing.Size(160, 24);
            this.GenerarNumeros.TabIndex = 9;
            this.GenerarNumeros.Text = "Generar Numeros";
            this.GenerarNumeros.UseVisualStyleBackColor = false;
            this.GenerarNumeros.Click += new System.EventHandler(this.GenerarNumeros_Click);
            // 
            // CirProgreso
            // 
            this.CirProgreso.animated = false;
            this.CirProgreso.animationIterval = 5;
            this.CirProgreso.animationSpeed = 300;
            this.CirProgreso.BackColor = System.Drawing.Color.Black;
            this.CirProgreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CirProgreso.BackgroundImage")));
            this.CirProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CirProgreso.ForeColor = System.Drawing.Color.White;
            this.CirProgreso.LabelVisible = true;
            this.CirProgreso.LineProgressThickness = 8;
            this.CirProgreso.LineThickness = 5;
            this.CirProgreso.Location = new System.Drawing.Point(1133, 503);
            this.CirProgreso.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CirProgreso.MaxValue = 100;
            this.CirProgreso.Name = "CirProgreso";
            this.CirProgreso.ProgressBackColor = System.Drawing.Color.Black;
            this.CirProgreso.ProgressColor = System.Drawing.Color.White;
            this.CirProgreso.Size = new System.Drawing.Size(90, 90);
            this.CirProgreso.TabIndex = 11;
            this.CirProgreso.Value = 0;
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.White;
            this.Aviso.Location = new System.Drawing.Point(1117, 585);
            this.Aviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(106, 24);
            this.Aviso.TabIndex = 12;
            this.Aviso.Text = "Sin Valores";
            this.Aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1378, 750);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.CirProgreso);
            this.Controls.Add(this.GenerarNumeros);
            this.Controls.Add(this.cElementos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "principal";
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeslaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton CloseWindow;
        private Bunifu.Framework.UI.BunifuImageButton MinWindow;
        private Bunifu.Framework.UI.BunifuImageButton TeslaLogo;
        private MetroSuite.MetroSeparator metroSeparator1;
        private System.Windows.Forms.Timer TimerAlgo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cElementos;
        private System.Windows.Forms.Button GenerarNumeros;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CirProgreso;
        private System.Windows.Forms.Label Aviso;
    }
}

