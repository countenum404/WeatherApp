namespace WeatherApp
{
    partial class WeatherWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherWidget));
            this.WeatherIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Close = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentLocation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Temperature = new System.Windows.Forms.RichTextBox();
            this.Close.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.ContextMenuStrip = this.Close;
            this.WeatherIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("WeatherIcon.Icon")));
            this.WeatherIcon.Text = "Weather";
            this.WeatherIcon.Visible = true;
            this.WeatherIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WeatherIconMouseDoubleClick);
            // 
            // Close
            // 
            this.Close.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItemClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.CurrentLocation);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 63);
            this.panel1.TabIndex = 1;
            // 
            // CurrentLocation
            // 
            this.CurrentLocation.AutoSize = true;
            this.CurrentLocation.Font = new System.Drawing.Font("Nirmala UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLocation.Location = new System.Drawing.Point(33, 9);
            this.CurrentLocation.Name = "CurrentLocation";
            this.CurrentLocation.Size = new System.Drawing.Size(285, 50);
            this.CurrentLocation.TabIndex = 0;
            this.CurrentLocation.Text = "Saint-Petersburg";
            this.CurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.clouds;
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 310);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Temperature
            // 
            this.Temperature.BackColor = System.Drawing.Color.AliceBlue;
            this.Temperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Temperature.CausesValidation = false;
            this.Temperature.Cursor = System.Windows.Forms.Cursors.Default;
            this.Temperature.DetectUrls = false;
            this.Temperature.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.Location = new System.Drawing.Point(128, 338);
            this.Temperature.MaxLength = 4;
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            this.Temperature.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Temperature.Size = new System.Drawing.Size(72, 41);
            this.Temperature.TabIndex = 3;
            this.Temperature.TabStop = false;
            this.Temperature.Text = "Temp";
            // 
            // WeatherWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(341, 485);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeatherWidget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.WidgetLoad);
            this.LostFocus += new System.EventHandler(this.FocusLost);
            this.Close.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon WeatherIcon;
        private System.Windows.Forms.ContextMenuStrip Close;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox Temperature;
    }
}

