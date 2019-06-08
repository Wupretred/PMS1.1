using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class 出勤管理 : Form
    {
        private List<List> list;
        private SqlConnection sqlConnection = SetConnection.sqlConnection;

        public 出勤管理()
        {
            InitializeComponent();
            SqlCommand sqlCommand = new SqlCommand("select * from ATTENDENCE", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;
            stafftable.DataSource = bindingSource;
            sqlDataReader.Close();
        }
        // private object pMSDataSet1;

        public object ATTENDENCETableAdapter { get; private set; }

        private void 出勤管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet31.ATTENDENCE”中。您可以根据需要移动或删除它。
            this.aTTENDENCETableAdapter3.Fill(this.pMSDataSet31.ATTENDENCE);
            // TODO: 这行代码将数据加载到表“pMSDataSet30.ATTENDENCE”中。您可以根据需要移动或删除它。
            this.aTTENDENCETableAdapter2.Fill(this.pMSDataSet30.ATTENDENCE);
            // TODO: 这行代码将数据加载到表“pMSDataSet6.ATTENDENCE”中。您可以根据需要移动或删除它。
            //            this.aTTENDENCETableAdapter1.Fill(this.pMSDataSet6.ATTENDENCE);
        }

        private void Button1_Click(object sender, EventArgs e) //写入
        {
            String AID = t1.Text.Trim();
            String Sno = t2.Text.Trim();
            String Overtime = t3.Text.Trim();
            String Absence = t4.Text.Trim();
            String Atime = t5.Text.Trim();

            try
            {
                if (AID==""||Sno == "" || Overtime == "" || Absence == "" || Atime == "")
                {
                    MessageBox.Show("请将信息填写完整!", "警告");
                }
                else
                {
                    string insertStr = "INSERT INTO  ATTENDENCE (AID,Sno,OVERTIME,ABSENCE,ATIME) " +
                                       "VALUES ('" +AID+"','"+ Sno + "','" + Overtime + "','" + Absence + "','" + Atime + "')";
                    SqlCommand cmd = new SqlCommand(insertStr, sqlConnection);
                    cmd.ExecuteNonQuery();
                    SqlCommand sqlCommand = new SqlCommand("select * from ATTENDENCE", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = sqlDataReader;
                    stafftable.DataSource = bindingSource;
                    sqlDataReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("输入数据违反要求!", "警告");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e) //删除
        {
            try
            {
                string select_aid = stafftable.SelectedRows[0].Cells[0].Value.ToString(); //选择的当前行第一列的值，也就是ID
                string delete_by_aid = "delete from ATTENDENCE where AID=" + select_aid; //sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_aid, sqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("请正确选择行!");
            }
        }

        private void Button3_Click(object sender, EventArgs e) //查询
        {
            GetData();
            new Query("select * from ATTENDENCE where ", list, stafftable).ExecuteQuery();
        }

        public void GetData()
        {
            list = null;
            list = new List<List>();
            list.Add(new List("AID", t1.Text.Trim()));
            list.Add(new List("Sno", t2.Text.Trim()));
            list.Add(new List("OVERTIME", t3.Text.Trim()));
            list.Add(new List("ABSENCE", t4.Text.Trim()));
            list.Add(new List("ATIME", t5.Text.Trim()));
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}