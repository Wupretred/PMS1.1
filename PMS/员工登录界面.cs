﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMS
{
    public partial class 员工登录界面 : Form
    {
        SqlConnection sqlConnection = SetConnection.GetConnection();

        public 员工登录界面()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Button1_Click(object sender, EventArgs e) //登录
        {
            string name = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string sql = "select UNAME,UPASSWORD from USERS where UNAME = '" + name + "' and UPASSWORD = '" +
                         password + "'"; //编写SQL命令
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                MessageBox.Show("登陆成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //登录成功
                员工查询 form2 = new 员工查询();
                form2.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("提示：请输入用户名和密码！", "警告");
            else
            {
                MessageBox.Show("提示：用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                sqlDataReader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("数据库关闭错误！", "登陆提示");
            }
        }


        private void Button2_Click(object sender, EventArgs e) //注册
        {
            string name = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("提示：请输入用户名和密码！", "警告");
            else
            {
                string sql = "select UNAME,UPASSWORD from USERS where UNAME = '" + name + "' and UPASSWORD = '" +
                             password + "'"; //编写SQL命令
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                    MessageBox.Show("该用户已注册，请使用其他用户名", "提示");
                else
                {
                    string myinsert = "insert into USERS(UNAME,UPASSWORD) values('" + name + "','" + password + "')";
                    SqlCommand mycom = new SqlCommand(myinsert, sqlConnection);
                    mycom.ExecuteNonQuery();
                    MessageBox.Show("您已注册成功", "提示");
                    button1.PerformClick();
                }

                sqlDataReader.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e) //忘记密码
        {
            if (sqlConnection == null)
            {
                MessageBox.Show("数据库连接错误，请先检查连接！");
            }
            else
            {
                忘记密码 form = new 忘记密码(this);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
        }

        private void Button4_Click(object sender, EventArgs e) //转换身份
        {
            管理员登录界面 form = new 管理员登录界面();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void 员工登录界面_Load(object sender, EventArgs e)
        {
        }

        private void 员工登录界面_FormClosing(object sender, FormClosingEventArgs e)
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