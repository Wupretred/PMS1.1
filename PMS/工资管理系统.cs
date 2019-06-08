using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class 工资管理系统 : Form
    {
        private 行政管理 _formAdminManage;
        private 出勤管理 _formDutyManage;
        private 人事管理 _formPersonalManage;
        private 工资管理 _formSalaryManage;
        private 帮助 _formhelp;
        private Form[] _forms = new Form[5];//将5个界面放在数组里

        public 工资管理系统()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            DrawForm();
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.FormBorderStyle = FormBorderStyle.None;
            _formPersonalManage.TopLevel = false;
            _formPersonalManage.ControlBox = false;
            _formPersonalManage.Dock = DockStyle.Fill;
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.StartPosition = FormStartPosition.CenterParent;
            _formPersonalManage.Show();
        }


        private void 人事管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formPersonalManage);
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.FormBorderStyle = FormBorderStyle.None;
            _formPersonalManage.TopLevel = false;
            _formPersonalManage.ControlBox = false;
            _formPersonalManage.Dock = DockStyle.Fill;
            _formPersonalManage.MdiParent = this;
            _formPersonalManage.StartPosition = FormStartPosition.CenterParent;
        }

        private void 工资管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formSalaryManage);
            _formSalaryManage.MdiParent = this;
            _formSalaryManage.FormBorderStyle = FormBorderStyle.None;
            _formSalaryManage.TopLevel = false;
            _formSalaryManage.ControlBox = false;
            _formSalaryManage.Dock = DockStyle.Fill;
            _formSalaryManage.MdiParent = this;
            _formSalaryManage.StartPosition = FormStartPosition.CenterScreen;
            _formSalaryManage.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            管理员登录界面 form = new 管理员登录界面();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            忘记密码 form = new 忘记密码(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
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

        private void 行政管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formAdminManage);
            _formAdminManage.MdiParent = this;
            _formAdminManage.FormBorderStyle = FormBorderStyle.None;
            _formAdminManage.TopLevel = false;
            _formAdminManage.ControlBox = false;
            _formAdminManage.Dock = DockStyle.Fill;
            _formAdminManage.MdiParent = this;
            _formAdminManage.StartPosition = FormStartPosition.CenterScreen;
            _formAdminManage.Show();
        }

        private void 出勤管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAndHide(_formDutyManage);
            _formDutyManage.MdiParent = this;
            _formDutyManage.FormBorderStyle = FormBorderStyle.None;
            _formDutyManage.TopLevel = false;
            _formDutyManage.ControlBox = false;
            _formDutyManage.Dock = DockStyle.Fill;
            _formDutyManage.MdiParent = this;
            _formDutyManage.StartPosition = FormStartPosition.CenterScreen;
            _formDutyManage.Show();
        }

        private void DrawForm()
        {
            _formPersonalManage = new 人事管理();
            _forms[0] = _formPersonalManage;
            _formSalaryManage = new 工资管理();
            _forms[1] = _formSalaryManage;
            _formAdminManage = new 行政管理();
            _forms[2] = _formAdminManage;
            _formDutyManage = new 出勤管理();
            _forms[3] = _formDutyManage;
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

        private void 工资管理系统_FormClosing(object sender, FormClosingEventArgs e)
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