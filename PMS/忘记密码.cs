﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMS
{
    public partial class 忘记密码 : Form
    {
        private Form _form;
        private SqlConnection sqlConnection = SetConnection.sqlConnection;

        public 忘记密码(Form form)
        {
            InitializeComponent();
            _form = form;
            this.MaximizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e) //确定
        {
            string UNAME = textBox3.Text.Trim();
            string newpass = textBox2.Text.Trim();
            string checknewpass = textBox1.Text.Trim();

            string sql = "select UNAME from USERS where UNAME = '" + UNAME + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (newpass != checknewpass)
            {
                MessageBox.Show("密码不匹配，请重试！", "警告");
            }
            else if (newpass == "" || checknewpass == "")
            {
                MessageBox.Show("请输入新密码！", "警告");
            }
            else if (!sqlDataReader.HasRows)
                MessageBox.Show("无该用户，请检查后重新输入！", "提示");
            else
            {
                string insertStr = "UPDATE USERS SET UPASSWORD = '" + newpass + "' WHERE UNAME = '" + UNAME + "'";
                SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功！", "提示");

                管理员登录界面 form = new 管理员登录界面();
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)//返回
        {
            this.Hide();
            _form.Show();
            _form.StartPosition = FormStartPosition.CenterScreen;
            //设置窗体为居中与屏幕
        }

        private void 忘记密码_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否退出程序？", "退出程序", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
                Environment.Exit(0);//退出所有线程
            else
            {
                e.Cancel = true;
            }
        }
    }
}