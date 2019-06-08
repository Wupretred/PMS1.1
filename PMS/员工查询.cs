using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class 员工查询 : Form
    {
        private 工资查询 _formselectsalary;
        private 代扣查询 _formselectwithhold;
        private 出勤查询 _formselectattendence;
        private 同事查询 _formselectstaff;
        private 帮助 _formhelp;
        private Form[] _forms = new Form[5];//将5个界面放在数组里

        public 员工查询()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            DrawForm();
            _formselectsalary.MdiParent = this;
            _formselectsalary.FormBorderStyle = FormBorderStyle.None;
            _formselectsalary.TopLevel = false;
            _formselectsalary.ControlBox = false;
            _formselectsalary.Dock = DockStyle.Fill;
            _formselectsalary.MdiParent = this;
            _formselectsalary.StartPosition = FormStartPosition.CenterParent;
            _formselectsalary.Show();
        }
        private void 员工查询_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("是否退出程序？", "退出程序", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
                Environment.Exit(0);
            else
            {
                e.Cancel = true;
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            忘记密码 form = new 忘记密码(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            员工登录界面 form = new 员工登录界面();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 工资查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formselectsalary);
            _formselectsalary.MdiParent = this;
            _formselectsalary.FormBorderStyle = FormBorderStyle.None;
            _formselectsalary.TopLevel = false;
            _formselectsalary.ControlBox = false;
            _formselectsalary.Dock = DockStyle.Fill;
            _formselectsalary.MdiParent = this;
            _formselectsalary.StartPosition = FormStartPosition.CenterScreen;
            _formselectsalary.Show();
        }

        private void 代扣查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formselectwithhold);
            _formselectwithhold.MdiParent = this;
            _formselectwithhold.FormBorderStyle = FormBorderStyle.None;
            _formselectwithhold.TopLevel = false;
            _formselectwithhold.ControlBox = false;
            _formselectwithhold.Dock = DockStyle.Fill;
            _formselectwithhold.MdiParent = this;
            _formselectwithhold.StartPosition = FormStartPosition.CenterScreen;
            _formselectwithhold.Show();
        }

        private void 出勤查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formselectattendence);
            _formselectattendence.MdiParent = this;
            _formselectattendence.FormBorderStyle = FormBorderStyle.None;
            _formselectattendence.TopLevel = false;
            _formselectattendence.ControlBox = false;
            _formselectattendence.Dock = DockStyle.Fill;
            _formselectattendence.MdiParent = this;
            _formselectattendence.StartPosition = FormStartPosition.CenterScreen;
            _formselectattendence.Show();
        }

        private void 同事查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formselectstaff);
            _formselectstaff.MdiParent = this;
            _formselectstaff.FormBorderStyle = FormBorderStyle.None;
            _formselectstaff.TopLevel = false;
            _formselectstaff.ControlBox = false;
            _formselectstaff.Dock = DockStyle.Fill;
            _formselectstaff.MdiParent = this;
            _formselectstaff.StartPosition = FormStartPosition.CenterScreen;
            _formselectstaff.Show();
        }

        private void DrawForm()
        {
            _formselectsalary = new 工资查询();
            _forms[0] = _formselectsalary;
            _formselectwithhold = new 代扣查询();
            _forms[1] = _formselectwithhold;
            _formselectattendence = new 出勤查询();
            _forms[2] = _formselectattendence;
            _formselectstaff = new 同事查询();
            _forms[3] = _formselectstaff;
            _formhelp = new 帮助();
            _forms[4] = _formhelp;
        }

        private void ShowAndHide(Form form)//总写隐藏和显示方法
        {
            foreach (Form f in _forms)
            {
                if (f.Equals(form))
                {
                    f.Show();
                }
                else
                    f.Hide();
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formhelp);
            _formhelp.MdiParent = this;
            _formhelp.FormBorderStyle = FormBorderStyle.None;
            _formhelp.TopLevel = false;
            _formhelp.ControlBox = false;
            _formhelp.Dock = DockStyle.Fill;
            _formhelp.MdiParent = this;
            _formhelp.StartPosition = FormStartPosition.CenterScreen;
            _formhelp.Show();
        }
    }
}