﻿namespace WeatherApp
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
            this.Feels = new System.Windows.Forms.Label();
            this.Statement = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.wspeed = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imperialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.unitsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(181, 70);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 253);
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
            this.Temperature.Location = new System.Drawing.Point(12, 69);
            this.Temperature.MaxLength = 4;
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            this.Temperature.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Temperature.Size = new System.Drawing.Size(72, 41);
            this.Temperature.TabIndex = 3;
            this.Temperature.TabStop = false;
            this.Temperature.Text = "Temp";
            // 
            // Feels
            // 
            this.Feels.AutoSize = true;
            this.Feels.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feels.Location = new System.Drawing.Point(12, 106);
            this.Feels.Name = "Feels";
            this.Feels.Size = new System.Drawing.Size(59, 17);
            this.Feels.TabIndex = 4;
            this.Feels.Text = "Feels like";
            // 
            // Statement
            // 
            this.Statement.AutoSize = true;
            this.Statement.Font = new System.Drawing.Font("Nirmala UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statement.Location = new System.Drawing.Point(3, 0);
            this.Statement.Name = "Statement";
            this.Statement.Size = new System.Drawing.Size(137, 37);
            this.Statement.TabIndex = 5;
            this.Statement.Text = "Statement";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(6, 34);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(52, 21);
            this.Description.TabIndex = 6;
            this.Description.Text = "label3";
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Max.Location = new System.Drawing.Point(6, 53);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(52, 21);
            this.Max.TabIndex = 7;
            this.Max.Text = "label4";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.Location = new System.Drawing.Point(6, 73);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(52, 21);
            this.Min.TabIndex = 8;
            this.Min.Text = "label5";
            // 
            // wspeed
            // 
            this.wspeed.AutoSize = true;
            this.wspeed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wspeed.Location = new System.Drawing.Point(6, 90);
            this.wspeed.Name = "wspeed";
            this.wspeed.Size = new System.Drawing.Size(52, 21);
            this.wspeed.TabIndex = 9;
            this.wspeed.Text = "label6";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.Location = new System.Drawing.Point(6, 107);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(70, 21);
            this.pressure.TabIndex = 10;
            this.pressure.Text = "pressure";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.Statement);
            this.panel2.Controls.Add(this.Max);
            this.panel2.Controls.Add(this.pressure);
            this.panel2.Controls.Add(this.Description);
            this.panel2.Controls.Add(this.wspeed);
            this.panel2.Controls.Add(this.Min);
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 134);
            this.panel2.TabIndex = 11;
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.metricToolStripMenuItem,
            this.imperialToolStripMenuItem});
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unitsToolStripMenuItem.Text = "Units";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.metricToolStripMenuItem.Text = "Metric";
            this.metricToolStripMenuItem.Click += new System.EventHandler(this.metricToolStripMenuItem_Click);
            // 
            // imperialToolStripMenuItem
            // 
            this.imperialToolStripMenuItem.Name = "imperialToolStripMenuItem";
            this.imperialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imperialToolStripMenuItem.Text = "Imperial";
            this.imperialToolStripMenuItem.Click += new System.EventHandler(this.imperialToolStripMenuItem_Click);
            // 
            // WeatherWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(341, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Feels);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon WeatherIcon;
        private System.Windows.Forms.ContextMenuStrip Close;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox Temperature;
        private System.Windows.Forms.Label Feels;
        private System.Windows.Forms.Label Statement;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label wspeed;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imperialToolStripMenuItem;
    }
}

