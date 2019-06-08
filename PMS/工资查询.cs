using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class 工资查询 : Form
    {
        private List<List> list;
        public 工资查询()
        {
            InitializeComponent();
            list = new List<List>();
        }

        private void 工资查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet40.temp”中。您可以根据需要移动或删除它。
            this.tempTableAdapter.Fill(this.pMSDataSet40.temp);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            list.Clear();//初始化
            list.Add(new List("SALARYID", t1.Text.Trim()));
            list.Add(new List("Sno", t2.Text.Trim()));
            list.Add(new List("Sname", t3.Text.Trim()));
            list.Add(new List("Deptno", t4.Text));
            list.Add(new List("Paytime", t5.Text.Trim()));
            new Query("select * from temp where ", list, salarytable).ExecuteQuery();
        }
    }
}
