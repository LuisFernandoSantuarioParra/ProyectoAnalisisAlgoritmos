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
            MetroSuite.MetroSeparator.MainColorScheme mainColorScheme1 = new MetroSuite.MetroSeparator.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.metroSeparator1 = new MetroSuite.MetroSeparator();
            this.TeslaLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseWindow = new Bunifu.Framework.UI.BunifuImageButton();
            this.TimerAlgo = new System.Windows.Forms.Timer(this.components);
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeslaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).BeginInit();
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
            mainColorScheme1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.Color2 = System.Drawing.Color.White;
            this.metroSeparator1.ColorScheme = mainColorScheme1;
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
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 750);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeslaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton CloseWindow;
        private Bunifu.Framework.UI.BunifuImageButton MinWindow;
        private Bunifu.Framework.UI.BunifuImageButton TeslaLogo;
        private MetroSuite.MetroSeparator metroSeparator1;
        private System.Windows.Forms.Timer TimerAlgo;
    }
}

