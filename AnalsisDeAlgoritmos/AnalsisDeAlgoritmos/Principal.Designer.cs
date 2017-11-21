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
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme4 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
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
            mainColorScheme4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme4.Color2 = System.Drawing.Color.White;
            this.metroSeparator1.ColorScheme = mainColorScheme4;
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
            chartArea13.Area3DStyle.Enable3D = true;
            chartArea13.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea13.AxisX.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea13.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea13.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea13.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea13.AxisY.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea13.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea13.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea13.BackColor = System.Drawing.Color.Transparent;
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.BackColor = System.Drawing.Color.Transparent;
            legend13.ForeColor = System.Drawing.Color.White;
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(2, 69);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series13.LabelForeColor = System.Drawing.Color.White;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(450, 299);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Area3DStyle.Enable3D = true;
            chartArea14.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea14.AxisX.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea14.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea14.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea14.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea14.AxisY.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea14.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea14.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea14.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.BackColor = System.Drawing.Color.Transparent;
            legend14.ForeColor = System.Drawing.Color.White;
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(458, 69);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.LabelForeColor = System.Drawing.Color.White;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(450, 299);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea15.Area3DStyle.Enable3D = true;
            chartArea15.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea15.AxisX.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea15.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea15.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea15.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea15.AxisY.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea15.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea15.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea15.BackColor = System.Drawing.Color.Transparent;
            chartArea15.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea15);
            legend15.BackColor = System.Drawing.Color.Transparent;
            legend15.ForeColor = System.Drawing.Color.White;
            legend15.Name = "Legend1";
            this.chart3.Legends.Add(legend15);
            this.chart3.Location = new System.Drawing.Point(924, 69);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart3.Name = "chart3";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.LabelForeColor = System.Drawing.Color.White;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart3.Series.Add(series15);
            this.chart3.Size = new System.Drawing.Size(450, 299);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Transparent;
            chartArea16.Area3DStyle.Enable3D = true;
            chartArea16.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea16.AxisX.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea16.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea16.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea16.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea16.AxisY.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea16.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea16.BackColor = System.Drawing.Color.Transparent;
            chartArea16.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea16);
            legend16.BackColor = System.Drawing.Color.Transparent;
            legend16.ForeColor = System.Drawing.Color.White;
            legend16.Name = "Legend1";
            this.chart4.Legends.Add(legend16);
            this.chart4.Location = new System.Drawing.Point(12, 379);
            this.chart4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chart4.Name = "chart4";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.LabelForeColor = System.Drawing.Color.White;
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chart4.Series.Add(series16);
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
            "100"});
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
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar2.LabelVisible = true;
            this.bunifuCircleProgressbar2.LineProgressThickness = 8;
            this.bunifuCircleProgressbar2.LineThickness = 5;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(1133, 503);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Black;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(90, 90);
            this.bunifuCircleProgressbar2.TabIndex = 11;
            this.bunifuCircleProgressbar2.Value = 0;
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.White;
            this.Aviso.Location = new System.Drawing.Point(1129, 600);
            this.Aviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(106, 24);
            this.Aviso.TabIndex = 12;
            this.Aviso.Text = "Sin Valores";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1378, 750);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.bunifuCircleProgressbar2);
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
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private System.Windows.Forms.Label Aviso;
    }
}

