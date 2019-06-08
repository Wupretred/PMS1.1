using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class 工资管理 : Form
    {
        private List<List> list;
        private SqlConnection sqlConnection = SetConnection.sqlConnection;

        public 工资管理()
        {
            InitializeComponent();
        }


        private void Button6_Click(object sender, EventArgs e) //工资删除
        {
            try
            {
                string select_SID = salarytable.SelectedRows[0].Cells[0].Value.ToString(); //选择的当前行第一列的值，也就是ID
                string delete_by_SID = "delete from SALARY where SALARYID=" + select_SID; //sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_SID, sqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
        }

        private void Button2_Click(object sender, EventArgs e) //代扣写入
        {
            try
            {
                GetData1();
                StringBuilder stringBuilder = new StringBuilder("INSERT INTO WITHHOLD VALUES (");
                for (int i = 0; i < list.Count; i++)
                {
                    stringBuilder.Append("'" + list[i].attr + "'");
                    if (i != list.Count - 1)
                    {
                        stringBuilder.Append(" , ");
                    }
                }
                stringBuilder.Append(")");

                SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功添加");
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }
        }
        private void Button1_Click(object sender, EventArgs e) //代扣删除
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

        public void GetData1()
        {
            list = null;
            list = new List<List>();
            list.Add(new List("WITHHOLDID", TT1.Text.Trim()));
            list.Add(new List("Sno", TT2.Text.Trim()));
            list.Add(new List("RID", TT3.Text));
            list.Add(new List("WITHHOLDTIME", TT4.Text.Trim()));

        }
        public void GetData()
        {
            list = null;
            list = new List<List>();
            list.Add(new List("SALARYID", t1.Text.Trim()));
            list.Add(new List("Sno", t2.Text.Trim()));
            list.Add(new List("Deptno", comboBox1.Text));
            list.Add(new List("Grosspay", t3.Text.Trim()));
            list.Add(new List("Paytime", t4.Text.Trim()));

        }

        private void button3_Click_1(object sender, EventArgs e)//代扣查询
        {
            GetData1();
            new Query("select * from WITHHOLD where ", list, withholdtable).ExecuteQuery();
        }

        private void Button5_Click(object sender, EventArgs e)//工资查询
        {
            GetData();
            new Query("select * from temp where ", list, salarytable).ExecuteQuery();
        }

        private void Button4_Click(object sender, EventArgs e)//工资增加
        {
            try
            {
                GetData();
                StringBuilder stringBuilder = new StringBuilder("INSERT INTO SALARY VALUES (");
                for (int i = 0; i < list.Count; i++)
                {

                    stringBuilder.Append("'" + list[i].attr + "'");
                    if (i != list.Count - 1)
                    {
                        stringBuilder.Append(" , ");
                    }
                }
                stringBuilder.Append(")");

                SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), sqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("成功添加");
            }
            catch
            {
                throw;
                MessageBox.Show("请检查输入工资编号和工号");
            }
        }
    }
}