﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Client
{
    public partial class SettingControl : UserControl
    {
        public SettingControl()
        {
            InitializeComponent();
            SetStyle(
                     ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw
                     | ControlStyles.Selectable
                     | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint
                     | ControlStyles.SupportsTransparentBackColor,
                     true);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            msgCenter.Objects.UserObject user = new msgCenter.Objects.UserObject();
            user.FirstName = tb_firstname.Text;
            user.MidName = tb_middlename.Text;
            user.LastName = tb_lastname.Text;
            user.Suffx = tb_suffix.Text;
            user.Birthday = tb_bmonth.Text + "/" + tb_bday.Text + "/" + tb_byear.Text;
            user.HomePhone = tb_phone1.Text + "-" + tb_phone2.Text + "-" + tb_phone3.Text;
            user.Gender = rb_male.Checked.ToString() ;
            user.Weight = float.Parse(tb_weight.Text);
            user.Height = float.Parse(tb_height_ft.Text) * 12 + float.Parse(tb_height_in.Text);
            user.Address_Street = tb_street.Text;
            user.Address_City = tb_city.Text;
            user.Address_State = tb_state.Text;
            user.Address_Zipcode = tb_zipcode.Text;
            user.EmgName = tb_emName.Text;
            user.EmgPhone = tb_emPhone1.Text + "-" + tb_emPhone2.Text + "-" + tb_emPhone3.Text;
            user.UseInsulin = cb_insulin.Checked;
            user.update();
            MessageBox.Show("Information Saved.");
            this.Visible = false;
        }

        private void SettingControl_Load(object sender, EventArgs e)
        {
            Initial();
        }

        private void Initial() {
            msgCenter.Objects.UserObject user = msgCenter.Objects.UserObject.GetUser();
            tb_firstname.Text = user.FirstName;
            tb_middlename.Text = user.MidName;
            tb_lastname.Text = user.LastName;
            tb_suffix.Text = user.Suffx;
            if (user.Birthday != "")
            {
                tb_bmonth.Text = user.Birthday.Split('/')[0];
                tb_bday.Text = user.Birthday.Split('/')[1];
                tb_byear.Text = user.Birthday.Split('/')[2];
            }
            if (user.HomePhone != "")
            {
                tb_phone1.Text = user.HomePhone.Split('-')[0];
                tb_phone2.Text = user.HomePhone.Split('-')[1];
                tb_phone3.Text = user.HomePhone.Split('-')[2];
            }
            rb_male.Checked = bool.Parse(user.Gender);
            rb_female.Checked = !bool.Parse(user.Gender);
            tb_weight.Text = user.Weight.ToString();
            tb_height_ft.Text = ((int)(user.Height / 12)).ToString();
            tb_height_in.Text = (user.Height % 12).ToString();
            tb_street.Text = user.Address_Street;
            tb_city.Text = user.Address_City;
            tb_state.Text = user.Address_State;
            tb_zipcode.Text = user.Address_Zipcode;
            tb_emName.Text = user.EmgName;
            cb_insulin.Checked = user.UseInsulin;
            if (user.EmgPhone != "")
            {
                tb_emPhone1.Text = user.EmgPhone.Split('-')[0];
                tb_emPhone2.Text = user.EmgPhone.Split('-')[1];
                tb_emPhone3.Text = user.EmgPhone.Split('-')[2];
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Initial();
        }

        private void tb_zipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_bmonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_bday_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_byear_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_height_ft_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_height_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_emPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_emPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_emPhone3_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_phone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_phone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tb_phone3_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

    }
}
