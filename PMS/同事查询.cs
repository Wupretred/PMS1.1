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
    public partial class 同事查询 : Form
    {
        private List<List> list;
        public 同事查询()
        {
            InitializeComponent();
            list = new List<List>();
        }

        private void 同事查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet43.STAFF”中。您可以根据需要移动或删除它。
            this.sTAFFTableAdapter.Fill(this.pMSDataSet43.STAFF);

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new List("Sno", t1.Text.Trim()));
            list.Add(new List("Sname", t2.Text.Trim()));
            list.Add(new List("Ssex", t3.Text));
            list.Add(new List("Sbirth", t4.Text.Trim()));
            list.Add(new List("Deptno", t5.Text));
            list.Add(new List("Slevel", t6.Text.Trim()));
            list.Add(new List("Stel", t7.Text.Trim()));
            list.Add(new List("JoinTime", t8.Text.Trim()));
            new Query("select * from STAFF where ", list, stafftable).ExecuteQuery();
        }
    }
}
