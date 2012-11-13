using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Client
{
    public partial class Form1 : Form
    {

        private int _X,_Y;
        private int area_Left = 257;
        private int area_Top = 25;

        private int mid_Left = 338;
        private int mid_Top = 60;


        private SettingControl panel_setting = new SettingControl();
        private DataInputPanel panel_input = new DataInputPanel();
        private PhonePanel panel_phone = new PhonePanel();
        private ChartPanel panel_chart = new ChartPanel();
        private HeadBox panel_head = new HeadBox();
       // public  msgCenter.mainProcess mainPro = new msgCenter.mainProcess();

        public Form1()
        {
            InitializeComponent();


            panel_head.Location = new System.Drawing.Point(mid_Left, mid_Top);
            panel_head.InitialFlash();
            panel_head.Visible = true;
            this.Controls.Add(panel_head);

            panel_chart.Location = new System.Drawing.Point(area_Left, area_Top);
            panel_chart.Visible = false;
            this.Controls.Add(panel_chart);

            panel_setting.Location = new System.Drawing.Point(area_Left, area_Top);
            panel_setting.Visible = false;
            this.Controls.Add(panel_setting);

            panel_input.Location = new System.Drawing.Point(area_Left, area_Top);
            panel_input.Visible = false;
            this.Controls.Add(panel_input);

            panel_phone.Location = new System.Drawing.Point(area_Left, area_Top);
            panel_phone.Visible = false;
            this.Controls.Add(panel_phone);
        }

       

       

        private void bt_emergency_Click(object sender, EventArgs e)
        {
            clearArea();
            panel_phone.Visible = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            if(e.Button==MouseButtons.Left){
                if (_X == e.X && _Y == e.Y)
                {
                    return;
                }
                else
                {
                    this.Left = this.Left + e.X - _X;
                    this.Top = this.Top + e.Y - _Y;
                }
            }
            if (e.Y>500)
            {
                panel_control.Visible = true;
            }
            if (e.Y < 422)
            {
                panel_control.Visible = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _X = e.X;
            _Y = e.Y;
        }

        private void bt_quite_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void bt_chart_Click(object sender, EventArgs e)
        {
            clearArea();
            panel_chart.Visible = true;
        }

        private void ButtonMouseEffect(Button button, bool mouseOver) {
            int enlargeSize = 10;
            int shiftSize = enlargeSize / 2;
            if (mouseOver)
            {
                button.Width += enlargeSize;
                button.Height += enlargeSize;
                button.Left -= shiftSize;
                button.Top -= shiftSize;
            }
            else {
                button.Width -= enlargeSize;
                button.Height -= enlargeSize;
                button.Left += shiftSize;
                button.Top += shiftSize;
            }
        }
        private void bt_setting_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }

        private void bt_setting_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_info_Click(object sender, EventArgs e)
        {
              clearArea();
              panel_input.Visible = true;
            
        }

        private void bt_emergency_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_emergency_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }

        private void bt_info_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_info_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }

        private void bt_chart_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_chart_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }

        private void bt_quite_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_quite_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }


        private void bt_home_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_home_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            clearArea();
            panel_setting.Visible = true;
        }

        private void clearArea() {
            panel_setting.Visible = false;
            panel_chart.Visible = false;
            panel_input.Visible = false;
            panel_head.Visible = false;
            panel_phone.Visible = false;
            panel_emotion.Visible = false;
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            clearArea();
            panel_head.Visible = true;
            panel_emotion.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bt_emotion1_Click(object sender, EventArgs e)
        {
            msgCenter.Objects.EmotionObject.New(msgCenter.Objects.EmotionObject.Emotion_Happy, DateTime.Now);
        }

        private void bt_emotion2_Click(object sender, EventArgs e)
        {
            msgCenter.Objects.EmotionObject.New(msgCenter.Objects.EmotionObject.Emotion_Sad, DateTime.Now);
        }

        private void bt_emotion1_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_emotion1_MouseLeave(object sender, EventArgs e)
        { 
            ButtonMouseEffect((Button)sender, false);
        }

        private void bt_emotion2_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, true);
        }

        private void bt_emotion2_MouseLeave(object sender, EventArgs e)
        {
            ButtonMouseEffect((Button)sender, false);
        }

      

       
    }
}
