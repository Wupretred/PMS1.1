﻿using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class 选择登陆 : Form
    {
        public 选择登陆()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //设置窗体为居中与屏幕
            this.MaximizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e) //管理员
        {
            管理员登录界面 form = new 管理员登录界面();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e) //员工
        {
            员工登录界面 form = new 员工登录界面();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void 选择登陆_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否退出程序？", "退出程序", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
                Environment.Exit(0);
            else
            {
                e.Cancel = true;
            }
        }
    }
}