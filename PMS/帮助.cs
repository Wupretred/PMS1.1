using System.Windows.Forms;

namespace PMS
{
    public partial class 帮助 : Form
    {
        public 帮助()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//管理员
        {
            管理员说明 form = new 管理员说明();
            form.Show();
            form.StartPosition = FormStartPosition.CenterParent;
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//员工
        {
            员工说明 form = new 员工说明();
            form.Show();
            form.StartPosition = FormStartPosition.CenterParent;
        }
    }
}