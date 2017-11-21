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
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme3 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.metroSeparator1 = new MetroSuite.MetroSeparator();
            this.TeslaLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerAlgo = new System.Windows.Forms.Timer(this.components);
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Generar = new System.Windows.Forms.Button();
            this.bProgreso = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Aviso = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.ComboBox();
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
            this.BarraSuperior.Location = new System.Drawing.Point(-1, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1385, 26);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // metroSeparator1
            // 
            mainColorScheme3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme3.Color2 = System.Drawing.Color.White;
            this.metroSeparator1.ColorScheme = mainColorScheme3;
            this.metroSeparator1.Location = new System.Drawing.Point(3, 24);
            this.metroSeparator1.Name = "metroSeparator1";
            this.metroSeparator1.Size = new System.Drawing.Size(1385, 2);
            this.metroSeparator1.TabIndex = 1;
            // 
            // TeslaLogo
            // 
            this.TeslaLogo.BackColor = System.Drawing.Color.SeaGreen;
            this.TeslaLogo.Enabled = false;
            this.TeslaLogo.Image = ((System.Drawing.Image)(resources.GetObject("TeslaLogo.Image")));
            this.TeslaLogo.ImageActive = null;
            this.TeslaLogo.Location = new System.Drawing.Point(1, 1);
            this.TeslaLogo.Name = "TeslaLogo";
            this.TeslaLogo.Size = new System.Drawing.Size(25, 25);
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
            this.MinWindow.Location = new System.Drawing.Point(1338, 5);
            this.MinWindow.Name = "MinWindow";
            this.MinWindow.Size = new System.Drawing.Size(15, 15);
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
            this.CloseWindow.Location = new System.Drawing.Point(1359, 5);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(15, 15);
            this.CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseWindow.TabIndex = 1;
            this.CloseWindow.TabStop = false;
            this.CloseWindow.Zoom = 10;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Area3DStyle.Enable3D = true;
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea9.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea9.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea9.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea9.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.BorderColor = System.Drawing.Color.White;
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.IsSoftShadows = false;
            legend9.BackColor = System.Drawing.Color.Transparent;
            legend9.ForeColor = System.Drawing.Color.White;
            legend9.HeaderSeparatorColor = System.Drawing.Color.White;
            legend9.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend9.Name = "Legend1";
            legend9.ShadowColor = System.Drawing.Color.LightGray;
            legend9.TitleForeColor = System.Drawing.Color.White;
            legend9.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(12, 58);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series9.YValuesPerPoint = 6;
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(450, 283);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Area3DStyle.Enable3D = true;
            chartArea10.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisX.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea10.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea10.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea10.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisY.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea10.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea10.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea10.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BorderColor = System.Drawing.Color.White;
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.IsSoftShadows = false;
            legend10.BackColor = System.Drawing.Color.Transparent;
            legend10.ForeColor = System.Drawing.Color.White;
            legend10.HeaderSeparatorColor = System.Drawing.Color.White;
            legend10.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend10.Name = "Legend1";
            legend10.ShadowColor = System.Drawing.Color.LightGray;
            legend10.TitleForeColor = System.Drawing.Color.White;
            legend10.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(456, 58);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series10.LabelForeColor = System.Drawing.Color.White;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series10.YValuesPerPoint = 6;
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(462, 283);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Area3DStyle.Enable3D = true;
            chartArea11.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea11.AxisX.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea11.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea11.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea11.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea11.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea11.AxisY.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea11.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea11.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea11.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BorderColor = System.Drawing.Color.White;
            chartArea11.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea11);
            this.chart3.IsSoftShadows = false;
            legend11.BackColor = System.Drawing.Color.Transparent;
            legend11.ForeColor = System.Drawing.Color.White;
            legend11.HeaderSeparatorColor = System.Drawing.Color.White;
            legend11.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend11.Name = "Legend1";
            legend11.ShadowColor = System.Drawing.Color.LightGray;
            legend11.TitleForeColor = System.Drawing.Color.White;
            legend11.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart3.Legends.Add(legend11);
            this.chart3.Location = new System.Drawing.Point(915, 58);
            this.chart3.Name = "chart3";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series11.LabelForeColor = System.Drawing.Color.White;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series11.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series11.YValuesPerPoint = 6;
            this.chart3.Series.Add(series11);
            this.chart3.Size = new System.Drawing.Size(455, 283);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Economica", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bubble Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Economica", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(643, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insertion Sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Economica", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1103, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shell Sort";
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Area3DStyle.Enable3D = true;
            chartArea12.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea12.AxisX.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea12.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea12.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea12.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea12.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea12.AxisY.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea12.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea12.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea12.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BorderColor = System.Drawing.Color.White;
            chartArea12.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea12);
            this.chart4.IsSoftShadows = false;
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.ForeColor = System.Drawing.Color.White;
            legend12.HeaderSeparatorColor = System.Drawing.Color.White;
            legend12.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend12.Name = "Legend1";
            legend12.ShadowColor = System.Drawing.Color.LightGray;
            legend12.TitleForeColor = System.Drawing.Color.White;
            legend12.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart4.Legends.Add(legend12);
            this.chart4.Location = new System.Drawing.Point(12, 359);
            this.chart4.Name = "chart4";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series12.LabelForeColor = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series12.YValuesPerPoint = 6;
            this.chart4.Series.Add(series12);
            this.chart4.Size = new System.Drawing.Size(694, 379);
            this.chart4.TabIndex = 9;
            this.chart4.Text = "chart4";
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.Black;
            this.Generar.ForeColor = System.Drawing.Color.White;
            this.Generar.Location = new System.Drawing.Point(897, 435);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(132, 23);
            this.Generar.TabIndex = 12;
            this.Generar.Text = "Generar Numeros";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // bProgreso
            // 
            this.bProgreso.BackColor = System.Drawing.Color.Silver;
            this.bProgreso.BorderRadius = 5;
            this.bProgreso.Location = new System.Drawing.Point(886, 464);
            this.bProgreso.MaximumValue = 100;
            this.bProgreso.Name = "bProgreso";
            this.bProgreso.ProgressColor = System.Drawing.Color.Teal;
            this.bProgreso.Size = new System.Drawing.Size(153, 10);
            this.bProgreso.TabIndex = 13;
            this.bProgreso.Value = 0;
            this.bProgreso.progressChanged += new System.EventHandler(this.bunifuProgressBar1_progressChanged);
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Font = new System.Drawing.Font("Economica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.ForeColor = System.Drawing.Color.White;
            this.Aviso.Location = new System.Drawing.Point(929, 477);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(59, 16);
            this.Aviso.TabIndex = 14;
            this.Aviso.Text = "SinNumeros";
            // 
            // Opciones
            // 
            this.Opciones.FormattingEnabled = true;
            this.Opciones.Items.AddRange(new object[] {
            "0",
            "100",
            "1000",
            "5000",
            "10000",
            "20000",
            "40000",
            "60000",
            "80000",
            "100000",
            "200000"});
            this.Opciones.Location = new System.Drawing.Point(916, 408);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(99, 21);
            this.Opciones.TabIndex = 15;
            this.Opciones.Text = "0";
            this.Opciones.SelectedIndexChanged += new System.EventHandler(this.Opciones_SelectedIndexChanged);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 750);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.bProgreso);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TimerAlgo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Button Generar;
        private Bunifu.Framework.UI.BunifuProgressBar bProgreso;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.ComboBox Opciones;
    }
}

