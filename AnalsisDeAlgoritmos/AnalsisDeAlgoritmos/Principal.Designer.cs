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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme1 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.CloseWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.TeslaLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroSeparator1 = new MetroSuite.MetroSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeslaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
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
            this.BarraSuperior.Size = new System.Drawing.Size(851, 26);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.ImageActive = null;
            this.CloseWindow.Location = new System.Drawing.Point(828, 5);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(15, 15);
            this.CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseWindow.TabIndex = 1;
            this.CloseWindow.TabStop = false;
            this.CloseWindow.Zoom = 10;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // MinWindow
            // 
            this.MinWindow.BackColor = System.Drawing.Color.Transparent;
            this.MinWindow.Image = ((System.Drawing.Image)(resources.GetObject("MinWindow.Image")));
            this.MinWindow.ImageActive = null;
            this.MinWindow.Location = new System.Drawing.Point(807, 5);
            this.MinWindow.Name = "MinWindow";
            this.MinWindow.Size = new System.Drawing.Size(15, 15);
            this.MinWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinWindow.TabIndex = 1;
            this.MinWindow.TabStop = false;
            this.MinWindow.Zoom = 10;
            this.MinWindow.Click += new System.EventHandler(this.MinWindow_Click);
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
            // metroSeparator1
            // 
            mainColorScheme1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.Color2 = System.Drawing.Color.White;
            this.metroSeparator1.ColorScheme = mainColorScheme1;
            this.metroSeparator1.Location = new System.Drawing.Point(3, 24);
            this.metroSeparator1.Name = "metroSeparator1";
            this.metroSeparator1.Size = new System.Drawing.Size(850, 2);
            this.metroSeparator1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 337);
            this.panel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 384);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(265, 160);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(283, 384);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(278, 160);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(567, 384);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(271, 160);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(850, 750);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeslaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton CloseWindow;
        private Bunifu.Framework.UI.BunifuImageButton MinWindow;
        private Bunifu.Framework.UI.BunifuImageButton TeslaLogo;
        private MetroSuite.MetroSeparator metroSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}

