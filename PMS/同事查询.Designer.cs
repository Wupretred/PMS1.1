namespace PMS
{
    partial class 同事查询
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.stafftable = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet43 = new PMS.PMSDataSet43();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.ComboBox();
            this.t3 = new System.Windows.Forms.ComboBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.sTAFFTableAdapter = new PMS.PMSDataSet43TableAdapters.STAFFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stafftable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet43)).BeginInit();
            this.SuspendLayout();
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(472, 83);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(107, 21);
            this.t7.TabIndex = 63;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(709, 31);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(104, 21);
            this.t4.TabIndex = 62;
            // 
            // stafftable
            // 
            this.stafftable.AutoGenerateColumns = false;
            this.stafftable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stafftable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.ssexDataGridViewTextBoxColumn,
            this.sbirthDataGridViewTextBoxColumn,
            this.deptnoDataGridViewTextBoxColumn,
            this.slevelDataGridViewTextBoxColumn,
            this.stelDataGridViewTextBoxColumn,
            this.jointimeDataGridViewTextBoxColumn});
            this.stafftable.DataSource = this.sTAFFBindingSource;
            this.stafftable.Location = new System.Drawing.Point(12, 184);
            this.stafftable.Name = "stafftable";
            this.stafftable.RowTemplate.Height = 23;
            this.stafftable.Size = new System.Drawing.Size(850, 254);
            this.stafftable.TabIndex = 61;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // ssexDataGridViewTextBoxColumn
            // 
            this.ssexDataGridViewTextBoxColumn.DataPropertyName = "Ssex";
            this.ssexDataGridViewTextBoxColumn.HeaderText = "Ssex";
            this.ssexDataGridViewTextBoxColumn.Name = "ssexDataGridViewTextBoxColumn";
            // 
            // sbirthDataGridViewTextBoxColumn
            // 
            this.sbirthDataGridViewTextBoxColumn.DataPropertyName = "Sbirth";
            this.sbirthDataGridViewTextBoxColumn.HeaderText = "Sbirth";
            this.sbirthDataGridViewTextBoxColumn.Name = "sbirthDataGridViewTextBoxColumn";
            // 
            // deptnoDataGridViewTextBoxColumn
            // 
            this.deptnoDataGridViewTextBoxColumn.DataPropertyName = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.HeaderText = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.Name = "deptnoDataGridViewTextBoxColumn";
            // 
            // slevelDataGridViewTextBoxColumn
            // 
            this.slevelDataGridViewTextBoxColumn.DataPropertyName = "Slevel";
            this.slevelDataGridViewTextBoxColumn.HeaderText = "Slevel";
            this.slevelDataGridViewTextBoxColumn.Name = "slevelDataGridViewTextBoxColumn";
            // 
            // stelDataGridViewTextBoxColumn
            // 
            this.stelDataGridViewTextBoxColumn.DataPropertyName = "Stel";
            this.stelDataGridViewTextBoxColumn.HeaderText = "Stel";
            this.stelDataGridViewTextBoxColumn.Name = "stelDataGridViewTextBoxColumn";
            // 
            // jointimeDataGridViewTextBoxColumn
            // 
            this.jointimeDataGridViewTextBoxColumn.DataPropertyName = "Jointime";
            this.jointimeDataGridViewTextBoxColumn.HeaderText = "Jointime";
            this.jointimeDataGridViewTextBoxColumn.Name = "jointimeDataGridViewTextBoxColumn";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.pMSDataSet43;
            // 
            // pMSDataSet43
            // 
            this.pMSDataSet43.DataSetName = "PMSDataSet43";
            this.pMSDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(709, 81);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(104, 21);
            this.t8.TabIndex = 60;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(279, 81);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(107, 21);
            this.t6.TabIndex = 59;
            // 
            // t5
            // 
            this.t5.FormattingEnabled = true;
            this.t5.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06"});
            this.t5.Location = new System.Drawing.Point(96, 82);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(95, 20);
            this.t5.TabIndex = 58;
            // 
            // t3
            // 
            this.t3.FormattingEnabled = true;
            this.t3.Items.AddRange(new object[] {
            "男",
            "女"});
            this.t3.Location = new System.Drawing.Point(472, 32);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(99, 20);
            this.t3.TabIndex = 57;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(279, 28);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(107, 21);
            this.t2.TabIndex = 56;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(96, 28);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(95, 21);
            this.t1.TabIndex = 55;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(394, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 33);
            this.button7.TabIndex = 54;
            this.button7.Text = "查询";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(38, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 53;
            this.label6.Text = "部门";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(221, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 27);
            this.label7.TabIndex = 52;
            this.label7.Text = "级别";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(602, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 27);
            this.label11.TabIndex = 51;
            this.label11.Text = "联系方式";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(414, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 27);
            this.label13.TabIndex = 50;
            this.label13.Text = "时间";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(414, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 27);
            this.label15.TabIndex = 49;
            this.label15.Text = "性别";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(602, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 27);
            this.label16.TabIndex = 48;
            this.label16.Text = "出生日期";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(221, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 27);
            this.label19.TabIndex = 47;
            this.label19.Text = "姓名";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(38, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 27);
            this.label20.TabIndex = 46;
            this.label20.Text = "工号";
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // 同事查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.stafftable);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Name = "同事查询";
            this.Text = "同事查询";
            this.Load += new System.EventHandler(this.同事查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stafftable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet43)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.DataGridView stafftable;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.ComboBox t5;
        private System.Windows.Forms.ComboBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private PMSDataSet43 pMSDataSet43;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private PMSDataSet43TableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointimeDataGridViewTextBoxColumn;
    }
}