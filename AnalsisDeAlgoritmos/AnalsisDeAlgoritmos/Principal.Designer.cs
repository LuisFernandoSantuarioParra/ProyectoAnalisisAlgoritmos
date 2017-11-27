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
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme7 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend27 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.metroSeparator1 = new MetroSuite.MetroSeparator();
            this.TeslaLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseWindow = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.Ordenar = new System.Windows.Forms.Button();
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
            mainColorScheme7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme7.Color2 = System.Drawing.Color.White;
            this.metroSeparator1.ColorScheme = mainColorScheme7;
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
            chartArea25.Area3DStyle.Enable3D = true;
            chartArea25.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea25.AxisX.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea25.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea25.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea25.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea25.AxisY.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea25.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea25.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea25.BackColor = System.Drawing.Color.Transparent;
            chartArea25.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea25);
            legend25.BackColor = System.Drawing.Color.Transparent;
            legend25.ForeColor = System.Drawing.Color.White;
            legend25.Name = "Legend1";
            this.chart1.Legends.Add(legend25);
            this.chart1.Location = new System.Drawing.Point(2, 69);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart1.Name = "chart1";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series25.LabelForeColor = System.Drawing.Color.White;
            series25.Legend = "Legend1";
            series25.Name = "Series1";
            this.chart1.Series.Add(series25);
            this.chart1.Size = new System.Drawing.Size(450, 299);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea26.Area3DStyle.Enable3D = true;
            chartArea26.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea26.AxisX.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea26.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea26.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea26.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea26.AxisY.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea26.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea26.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea26.BackColor = System.Drawing.Color.Transparent;
            chartArea26.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea26);
            legend26.BackColor = System.Drawing.Color.Transparent;
            legend26.ForeColor = System.Drawing.Color.White;
            legend26.Name = "Legend1";
            this.chart2.Legends.Add(legend26);
            this.chart2.Location = new System.Drawing.Point(458, 69);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart2.Name = "chart2";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series26.LabelForeColor = System.Drawing.Color.White;
            series26.Legend = "Legend1";
            series26.Name = "Series1";
            this.chart2.Series.Add(series26);
            this.chart2.Size = new System.Drawing.Size(450, 299);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea27.Area3DStyle.Enable3D = true;
            chartArea27.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea27.AxisX.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea27.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea27.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea27.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea27.AxisY.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea27.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea27.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea27.BackColor = System.Drawing.Color.Transparent;
            chartArea27.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea27);
            legend27.BackColor = System.Drawing.Color.Transparent;
            legend27.ForeColor = System.Drawing.Color.White;
            legend27.Name = "Legend1";
            this.chart3.Legends.Add(legend27);
            this.chart3.Location = new System.Drawing.Point(924, 69);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart3.Name = "chart3";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series27.LabelForeColor = System.Drawing.Color.White;
            series27.Legend = "Legend1";
            series27.Name = "Series1";
            this.chart3.Series.Add(series27);
            this.chart3.Size = new System.Drawing.Size(450, 299);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Transparent;
            chartArea28.Area3DStyle.Enable3D = true;
            chartArea28.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea28.AxisX.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea28.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea28.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea28.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea28.AxisY.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea28.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea28.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea28.BackColor = System.Drawing.Color.Transparent;
            chartArea28.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea28);
            legend28.BackColor = System.Drawing.Color.Transparent;
            legend28.ForeColor = System.Drawing.Color.White;
            legend28.Name = "Legend1";
            this.chart4.Legends.Add(legend28);
            this.chart4.Location = new System.Drawing.Point(12, 379);
            this.chart4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart4.Name = "chart4";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.LabelForeColor = System.Drawing.Color.White;
            series28.Legend = "Legend1";
            series28.Name = "Series1";
            this.chart4.Series.Add(series28);
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
            "1",
            "50",
            "100",
            "1000",
            "5000",
            "10000",
            "50000",
            "100000",
            "200000"});
            this.cElementos.Location = new System.Drawing.Point(729, 490);
            this.cElementos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cElementos.Name = "cElementos";
            this.cElementos.Size = new System.Drawing.Size(120, 21);
            this.cElementos.TabIndex = 8;
            this.cElementos.Text = "1";
            // 
            // GenerarNumeros
            // 
            this.GenerarNumeros.BackColor = System.Drawing.Color.Black;
            this.GenerarNumeros.ForeColor = System.Drawing.Color.White;
            this.GenerarNumeros.Location = new System.Drawing.Point(857, 490);
            this.GenerarNumeros.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GenerarNumeros.Name = "GenerarNumeros";
            this.GenerarNumeros.Size = new System.Drawing.Size(120, 24);
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
            this.CirProgreso.Location = new System.Drawing.Point(806, 523);
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
            this.Aviso.Location = new System.Drawing.Point(753, 617);
            this.Aviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(0, 24);
            this.Aviso.TabIndex = 12;
            this.Aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ordenar
            // 
            this.Ordenar.BackColor = System.Drawing.Color.Black;
            this.Ordenar.ForeColor = System.Drawing.Color.White;
            this.Ordenar.Location = new System.Drawing.Point(776, 432);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(170, 32);
            this.Ordenar.TabIndex = 13;
            this.Ordenar.Text = "Iniciar Ordenamiento";
            this.Ordenar.UseVisualStyleBackColor = false;
            this.Ordenar.Visible = false;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1378, 750);
            this.Controls.Add(this.Ordenar);
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
        private System.Windows.Forms.Button Ordenar;
    }
}

