using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.Resources;
using System.Reflection ;  

namespace Client
{
    public partial class PhonePanel : UserControl
    {
        private msgCenter.mainProcess mainPro = new msgCenter.mainProcess();
        List<WindowsMediaPlayer> players = new List<WindowsMediaPlayer>();
        
        public PhonePanel()
        {
            InitializeComponent();
            InitialMediaPlayers();
        }

        private void InitialMediaPlayers()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            for (int i = 0; i < 10; i++)
            {
                WindowsMediaPlayer mp = new WindowsMediaPlayer();
                mp.settings.mute = true;
                mp.URL = path + @"\sounds\" + "dtmf-" + i + ".wav";
                players.Add(mp);
            }

            WindowsMediaPlayer mp_star = new WindowsMediaPlayer();
            mp_star.settings.mute = true;
            mp_star.URL = path + @"\sounds\" + "dtmf-star.wav";
            players.Add(mp_star);

            WindowsMediaPlayer mp_pound = new WindowsMediaPlayer();
            mp_pound.settings.mute = true;
            mp_pound.URL = path + @"\sounds\" + "dtmf-pound.wav";
            players.Add(mp_star);

            WindowsMediaPlayer mp_back = new WindowsMediaPlayer();
            mp_back.settings.mute = true;
            mp_back.URL = path + @"\sounds\" + "dtmf-back.wav";
            players.Add(mp_back);

        }
        private void phoneNumberClick(Button bt) {
            int index = int.Parse(bt.Text);
            tb_dialNumber.Text += index.ToString();
            players[index].settings.mute = false;
            players[index].controls.play();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            phoneNumberClick((Button)sender);
        }

        private void bt_call_Click(object sender, EventArgs e)
        {
            if (tb_dialNumber.Text != string.Empty)
            {
                mainPro.CallPhone(tb_dialNumber.Text);
            }
        }

        private void bt_Emg_Click(object sender, EventArgs e)
        {
            if (tb_dialNumber.Text != string.Empty)
            {
                msgCenter.Objects.UserObject user = new msgCenter.Objects.UserObject();
                mainPro.CallPhone(user.getEmgPhoneNumber());
            }

        }

        private void bt_star_Click(object sender, EventArgs e)
        {
            players[10].settings.mute = false;
            players[10].controls.play();
        }

        private void bt_pound_Click(object sender, EventArgs e)
        {
            players[11].settings.mute = false;
            players[11].controls.play();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            if (tb_dialNumber.Text.Length > 0)
            {
                tb_dialNumber.Text = tb_dialNumber.Text.Substring(0, tb_dialNumber.Text.Length - 1);
            }
            players[12].settings.mute = false;
            players[12].controls.play();
        }

    

       
    }
}
