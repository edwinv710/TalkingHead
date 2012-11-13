namespace Client
{
    partial class ChartPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartPanel));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.cb_chartType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_chartview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_chartPeriod = new System.Windows.Forms.ComboBox();
            this.cb_testType = new System.Windows.Forms.ComboBox();
            this.chart_history = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_history)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_chart
            // 
            this.panel_chart.BackColor = System.Drawing.Color.Transparent;
            this.panel_chart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_chart.BackgroundImage")));
            this.panel_chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_chart.Location = new System.Drawing.Point(20, 30);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(0, 0);
            this.panel_chart.TabIndex = 6;
            // 
            // cb_chartType
            // 
            this.cb_chartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chartType.FormattingEnabled = true;
            this.cb_chartType.Items.AddRange(new object[] {
            "SpLine",
            "Line"});
            this.cb_chartType.Location = new System.Drawing.Point(479, 21);
            this.cb_chartType.Name = "cb_chartType";
            this.cb_chartType.Size = new System.Drawing.Size(91, 20);
            this.cb_chartType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(402, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chart Type:";
            // 
            // bt_chartview
            // 
            this.bt_chartview.BackgroundImage = global::Client.Properties.Resources.zoom;
            this.bt_chartview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_chartview.FlatAppearance.BorderSize = 0;
            this.bt_chartview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_chartview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_chartview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chartview.Location = new System.Drawing.Point(603, 13);
            this.bt_chartview.Name = "bt_chartview";
            this.bt_chartview.Size = new System.Drawing.Size(35, 35);
            this.bt_chartview.TabIndex = 6;
            this.bt_chartview.UseVisualStyleBackColor = true;
            this.bt_chartview.Click += new System.EventHandler(this.bt_chartview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Type:";
            // 
            // cb_chartPeriod
            // 
            this.cb_chartPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chartPeriod.FormattingEnabled = true;
            this.cb_chartPeriod.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cb_chartPeriod.Location = new System.Drawing.Point(269, 21);
            this.cb_chartPeriod.Name = "cb_chartPeriod";
            this.cb_chartPeriod.Size = new System.Drawing.Size(121, 20);
            this.cb_chartPeriod.TabIndex = 3;
            // 
            // cb_testType
            // 
            this.cb_testType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_testType.FormattingEnabled = true;
            this.cb_testType.Location = new System.Drawing.Point(83, 21);
            this.cb_testType.Name = "cb_testType";
            this.cb_testType.Size = new System.Drawing.Size(121, 20);
            this.cb_testType.TabIndex = 2;
            // 
            // chart_history
            // 
            this.chart_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.chart_history.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_history.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart_history.BackSecondaryColor = System.Drawing.Color.White;
            this.chart_history.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart_history.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart_history.BorderlineWidth = 2;
            this.chart_history.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart_history.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea2.Area3DStyle.Inclination = 15;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.Perspective = 10;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY2.LineColor = System.Drawing.Color.Gray;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(165)))), ((int)(((byte)(191)))), ((int)(((byte)(228)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chart_history.ChartAreas.Add(chartArea2);
            this.chart_history.IsSoftShadows = false;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_history.Legends.Add(legend2);
            this.chart_history.Location = new System.Drawing.Point(10, 53);
            this.chart_history.Margin = new System.Windows.Forms.Padding(0);
            this.chart_history.Name = "chart_history";
            this.chart_history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chart_history.Size = new System.Drawing.Size(654, 325);
            this.chart_history.TabIndex = 1;
            // 
            // ChartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.cb_chartType);
            this.Controls.Add(this.panel_chart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_chartview);
            this.Controls.Add(this.chart_history);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_testType);
            this.Controls.Add(this.cb_chartPeriod);
            this.Name = "ChartPanel";
            this.Size = new System.Drawing.Size(672, 392);
            ((System.ComponentModel.ISupportInitialize)(this.chart_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.ComboBox cb_chartType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_chartview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_chartPeriod;
        private System.Windows.Forms.ComboBox cb_testType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_history;

    }
}
