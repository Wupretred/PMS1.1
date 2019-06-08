using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMS
{
    public partial class 出勤查询 : Form
    {
        private List<List> list;
        public 出勤查询()
        {
            InitializeComponent();
            list = new List<List>();
        }

        private void 出勤查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet42.ATTENDENCE”中。您可以根据需要移动或删除它。
            this.aTTENDENCETableAdapter.Fill(this.pMSDataSet42.ATTENDENCE);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new List("AID", textBox1.Text.Trim()));
            list.Add(new List("Sno", t1.Text.Trim()));
            list.Add(new List("OVERTIME", t2.Text.Trim()));
            list.Add(new List("ABSENCE", t3.Text));
            list.Add(new List("ATIME", t4.Text.Trim()));
            new Query("select * from ATTENDENCE where ", list, attendencetable).ExecuteQuery();
        }
    }
}
