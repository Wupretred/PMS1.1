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
    public partial class 代扣查询 : Form
    {
        private List<List> list;
        public 代扣查询()
        {
            InitializeComponent();
            list = new List<List>();
        }

        private void 代扣查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pMSDataSet41.WITHHOLD”中。您可以根据需要移动或删除它。
            this.wITHHOLDTableAdapter.Fill(this.pMSDataSet41.WITHHOLD);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            list.Add(new List("WITHHOLDID", t1.Text.Trim()));
            list.Add(new List("Sno", t2.Text.Trim()));
            list.Add(new List("RID", t3.Text));
            list.Add(new List("WITHHOLDTIME", t4.Text.Trim()));
            new Query("select * from WITHHOLD where ", list, withholdtable).ExecuteQuery();
        }
    }
}
