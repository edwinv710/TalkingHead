namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_emergency = new System.Windows.Forms.Button();
            this.bt_info = new System.Windows.Forms.Button();
            this.bt_setting = new System.Windows.Forms.Button();
            this.bt_chart = new System.Windows.Forms.Button();
            this.panel_control = new System.Windows.Forms.Panel();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_quite = new System.Windows.Forms.Button();
            this.panel_emotion = new System.Windows.Forms.Panel();
            this.bt_emotion1 = new System.Windows.Forms.Button();
            this.bt_emotion2 = new System.Windows.Forms.Button();
            this.headBox1 = new Client.HeadBox();
            this.panel_control.SuspendLayout();
            this.panel_emotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_emergency
            // 
            this.bt_emergency.BackColor = System.Drawing.Color.Transparent;
            this.bt_emergency.BackgroundImage = global::Client.Properties.Resources.phone;
            this.bt_emergency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_emergency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emergency.FlatAppearance.BorderSize = 0;
            this.bt_emergency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_emergency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_emergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_emergency.Location = new System.Drawing.Point(22, 15);
            this.bt_emergency.Name = "bt_emergency";
            this.bt_emergency.Size = new System.Drawing.Size(66, 66);
            this.bt_emergency.TabIndex = 0;
            this.bt_emergency.UseVisualStyleBackColor = false;
            this.bt_emergency.Click += new System.EventHandler(this.bt_emergency_Click);
            this.bt_emergency.MouseEnter += new System.EventHandler(this.bt_emergency_MouseEnter);
            this.bt_emergency.MouseLeave += new System.EventHandler(this.bt_emergency_MouseLeave);
            // 
            // bt_info
            // 
            this.bt_info.BackColor = System.Drawing.Color.Transparent;
            this.bt_info.BackgroundImage = global::Client.Properties.Resources.edit;
            this.bt_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_info.FlatAppearance.BorderSize = 0;
            this.bt_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_info.Location = new System.Drawing.Point(109, 15);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(66, 66);
            this.bt_info.TabIndex = 1;
            this.bt_info.UseVisualStyleBackColor = false;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            this.bt_info.MouseEnter += new System.EventHandler(this.bt_info_MouseEnter);
            this.bt_info.MouseLeave += new System.EventHandler(this.bt_info_MouseLeave);
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.Color.Transparent;
            this.bt_setting.BackgroundImage = global::Client.Properties.Resources.applications1;
            this.bt_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_setting.FlatAppearance.BorderSize = 0;
            this.bt_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_setting.Location = new System.Drawing.Point(283, 15);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(66, 66);
            this.bt_setting.TabIndex = 2;
            this.bt_setting.UseVisualStyleBackColor = false;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            this.bt_setting.MouseEnter += new System.EventHandler(this.bt_setting_MouseEnter);
            this.bt_setting.MouseLeave += new System.EventHandler(this.bt_setting_MouseLeave);
            // 
            // bt_chart
            // 
            this.bt_chart.BackColor = System.Drawing.Color.Transparent;
            this.bt_chart.BackgroundImage = global::Client.Properties.Resources.chart;
            this.bt_chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_chart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_chart.FlatAppearance.BorderSize = 0;
            this.bt_chart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chart.Location = new System.Drawing.Point(196, 15);
            this.bt_chart.Name = "bt_chart";
            this.bt_chart.Size = new System.Drawing.Size(66, 66);
            this.bt_chart.TabIndex = 3;
            this.bt_chart.UseVisualStyleBackColor = false;
            this.bt_chart.Click += new System.EventHandler(this.bt_chart_Click);
            this.bt_chart.MouseEnter += new System.EventHandler(this.bt_chart_MouseEnter);
            this.bt_chart.MouseLeave += new System.EventHandler(this.bt_chart_MouseLeave);
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.Transparent;
            this.panel_control.Controls.Add(this.bt_home);
            this.panel_control.Controls.Add(this.bt_quite);
            this.panel_control.Controls.Add(this.bt_emergency);
            this.panel_control.Controls.Add(this.bt_chart);
            this.panel_control.Controls.Add(this.bt_info);
            this.panel_control.Controls.Add(this.bt_setting);
            this.panel_control.Location = new System.Drawing.Point(223, 422);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(591, 100);
            this.panel_control.TabIndex = 4;
            this.panel_control.Visible = false;
            // 
            // bt_home
            // 
            this.bt_home.BackgroundImage = global::Client.Properties.Resources.home;
            this.bt_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Location = new System.Drawing.Point(374, 15);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(66, 66);
            this.bt_home.TabIndex = 5;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            this.bt_home.MouseEnter += new System.EventHandler(this.bt_home_MouseEnter);
            this.bt_home.MouseLeave += new System.EventHandler(this.bt_home_MouseLeave);
            // 
            // bt_quite
            // 
            this.bt_quite.BackgroundImage = global::Client.Properties.Resources.close;
            this.bt_quite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_quite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_quite.FlatAppearance.BorderSize = 0;
            this.bt_quite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_quite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_quite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quite.Location = new System.Drawing.Point(467, 15);
            this.bt_quite.Name = "bt_quite";
            this.bt_quite.Size = new System.Drawing.Size(66, 66);
            this.bt_quite.TabIndex = 4;
            this.bt_quite.UseVisualStyleBackColor = true;
            this.bt_quite.Click += new System.EventHandler(this.bt_quite_Click);
            this.bt_quite.MouseEnter += new System.EventHandler(this.bt_quite_MouseEnter);
            this.bt_quite.MouseLeave += new System.EventHandler(this.bt_quite_MouseLeave);
            // 
            // panel_emotion
            // 
            this.panel_emotion.BackColor = System.Drawing.Color.Transparent;
            this.panel_emotion.Controls.Add(this.bt_emotion2);
            this.panel_emotion.Controls.Add(this.bt_emotion1);
            this.panel_emotion.Location = new System.Drawing.Point(332, 276);
            this.panel_emotion.Name = "panel_emotion";
            this.panel_emotion.Size = new System.Drawing.Size(364, 140);
            this.panel_emotion.TabIndex = 5;
            // 
            // bt_emotion1
            // 
            this.bt_emotion1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_emotion1.BackgroundImage")));
            this.bt_emotion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_emotion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emotion1.FlatAppearance.BorderSize = 0;
            this.bt_emotion1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_emotion1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_emotion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_emotion1.Location = new System.Drawing.Point(65, 20);
            this.bt_emotion1.Name = "bt_emotion1";
            this.bt_emotion1.Size = new System.Drawing.Size(100, 100);
            this.bt_emotion1.TabIndex = 0;
            this.bt_emotion1.UseVisualStyleBackColor = true;
            this.bt_emotion1.Click += new System.EventHandler(this.bt_emotion1_Click);
            this.bt_emotion1.MouseEnter += new System.EventHandler(this.bt_emotion1_MouseEnter);
            this.bt_emotion1.MouseLeave += new System.EventHandler(this.bt_emotion1_MouseLeave);
            // 
            // bt_emotion2
            // 
            this.bt_emotion2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_emotion2.BackgroundImage")));
            this.bt_emotion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_emotion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emotion2.FlatAppearance.BorderSize = 0;
            this.bt_emotion2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_emotion2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_emotion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_emotion2.Location = new System.Drawing.Point(201, 20);
            this.bt_emotion2.Name = "bt_emotion2";
            this.bt_emotion2.Size = new System.Drawing.Size(100, 100);
            this.bt_emotion2.TabIndex = 1;
            this.bt_emotion2.UseVisualStyleBackColor = true;
            this.bt_emotion2.Click += new System.EventHandler(this.bt_emotion2_Click);
            this.bt_emotion2.MouseEnter += new System.EventHandler(this.bt_emotion2_MouseEnter);
            this.bt_emotion2.MouseLeave += new System.EventHandler(this.bt_emotion2_MouseLeave);
            // 
            // headBox1
            // 
            this.headBox1.Location = new System.Drawing.Point(338, 60);
            this.headBox1.Name = "headBox1";
            this.headBox1.Size = new System.Drawing.Size(320, 240);
            this.headBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(960, 534);
            this.Controls.Add(this.panel_emotion);
            this.Controls.Add(this.panel_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel_control.ResumeLayout(false);
            this.panel_emotion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_emergency;
        private System.Windows.Forms.Button bt_info;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Button bt_chart;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button bt_quite;
        private System.Windows.Forms.Button bt_home;
        private HeadBox headBox1;
        private System.Windows.Forms.Panel panel_emotion;
        private System.Windows.Forms.Button bt_emotion2;
        private System.Windows.Forms.Button bt_emotion1;


    }
}

