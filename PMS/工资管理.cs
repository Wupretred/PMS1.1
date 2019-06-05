﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class 工资管理 : Form
    {
        private List<People> list;
        private SqlConnection sqlConnection = SetConnection.sqlConnection;

        public 工资管理()
        {
            InitializeComponent();
        }


        private void Button6_Click(object sender, EventArgs e) //工资查询
        {
            GetData();
            new Query("select * from SALARY where ", list, salarytable).ExecuteQuery();
        }

        private void Button2_Click(object sender, EventArgs e) //写入
        {
            String WITHHOLDID = textBox12.Text.Trim();
            String Sno = textBox5.Text.Trim();
            String RID = textBox7.Text.Trim();
            String WITHHOLDTIME = textBox11.Text.Trim();
            try
            {
                if (WITHHOLDID == "" || Sno == "" || RID == "" || WITHHOLDTIME == "")
                {
                    MessageBox.Show("请将信息填写完整!", "警告");
                }
                else
                {
                    string insertStr = "INSERT INTO  WITHHOLD (WITHHOLDID,Sno,RID,WITHHOLDTIME)    " +
                                       "VALUES ('" + WITHHOLDID + "','" + Sno + "','" + RID + "','" + WITHHOLDTIME +
                                       "')";
                    SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                    cmd.ExecuteNonQuery();
                    SqlDataReader sqlDataReader =
                        new SqlCommand("select * from WITHHOLD", sqlConnection).ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    withholdtable.DataSource = bindingSource;
                    sqlDataReader.Close();
                    MessageBox.Show("写入成功。");
                }
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e) //删除
        {
            try
            {
                string select_ID = withholdtable.SelectedRows[0].Cells[0].Value.ToString(); //选择的当前行第一列的值，也就是ID
                string delete_by_ID = "delete from WITHHOLD where WITHHOLDID=" + "'" + select_ID + "'"; //sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_ID, sqlConnection);
                cmd.ExecuteNonQuery();
                button3.PerformClick();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
        }

        public void GetData()
        {
            list = null;
            list = new List<People>();
            list.Add(new People("Sno", textBox1.Text.Trim()));
            list.Add(new People("Sname", textBox2.Text.Trim()));
            list.Add(new People("Deptno", comboBox1.Text));
            list.Add(new People("Paytime", textBox3.Text.Trim()));
        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from WITHHOLD", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            withholdtable.DataSource = bindingSource;
            sqlDataReader.Close();
        }


    }
}