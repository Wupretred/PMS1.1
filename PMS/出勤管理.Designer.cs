namespace PMS
{
    partial class 出勤管理
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
            this.aTTENDENCEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet6 = new PMS.PMSDataSet6();
            this.aTTENDENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet3 = new PMS.PMSDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t5 = new System.Windows.Forms.TextBox();
            this.aTTENDENCETableAdapter = new PMS.PMSDataSet3TableAdapters.ATTENDENCETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aTTENDENCETableAdapter1 = new PMS.PMSDataSet6TableAdapters.ATTENDENCETableAdapter();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pMSDataSet30 = new PMS.PMSDataSet30();
            this.aTTENDENCEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDENCETableAdapter2 = new PMS.PMSDataSet30TableAdapters.ATTENDENCETableAdapter();
            this.pMSDataSet31 = new PMS.PMSDataSet31();
            this.aTTENDENCEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.aTTENDENCETableAdapter3 = new PMS.PMSDataSet31TableAdapters.ATTENDENCETableAdapter();
            this.stafftable = new System.Windows.Forms.DataGridView();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oVERTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBSENCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stafftable)).BeginInit();
            this.SuspendLayout();
            // 
            // aTTENDENCEBindingSource1
            // 
            this.aTTENDENCEBindingSource1.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource1.DataSource = this.pMSDataSet6;
            // 
            // pMSDataSet6
            // 
            this.pMSDataSet6.DataSetName = "PMSDataSet6";
            this.pMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDENCEBindingSource
            // 
            this.aTTENDENCEBindingSource.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource.DataSource = this.pMSDataSet3;
            // 
            // pMSDataSet3
            // 
            this.pMSDataSet3.DataSetName = "PMSDataSet3";
            this.pMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "出勤数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "添加出勤信息";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(631, 337);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(106, 21);
            this.t2.TabIndex = 39;
            this.t2.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(436, 407);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(106, 21);
            this.t4.TabIndex = 35;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(192, 413);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(106, 21);
            this.t3.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(573, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "工号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(573, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(338, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "缺勤天数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(94, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 26;
            this.label10.Text = "加班天数";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(388, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 40;
            this.button1.Text = "写入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(631, 407);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(106, 21);
            this.t5.TabIndex = 41;
            this.t5.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // aTTENDENCETableAdapter
            // 
            this.aTTENDENCETableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(497, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 33);
            this.button2.TabIndex = 42;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(274, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 33);
            this.button3.TabIndex = 43;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // aTTENDENCETableAdapter1
            // 
            this.aTTENDENCETableAdapter1.ClearBeforeFill = true;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(192, 337);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(106, 21);
            this.t1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(94, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "出勤编号";
            // 
            // pMSDataSet30
            // 
            this.pMSDataSet30.DataSetName = "PMSDataSet30";
            this.pMSDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDENCEBindingSource2
            // 
            this.aTTENDENCEBindingSource2.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource2.DataSource = this.pMSDataSet30;
            // 
            // aTTENDENCETableAdapter2
            // 
            this.aTTENDENCETableAdapter2.ClearBeforeFill = true;
            // 
            // pMSDataSet31
            // 
            this.pMSDataSet31.DataSetName = "PMSDataSet31";
            this.pMSDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTTENDENCEBindingSource3
            // 
            this.aTTENDENCEBindingSource3.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource3.DataSource = this.pMSDataSet31;
            // 
            // aTTENDENCETableAdapter3
            // 
            this.aTTENDENCETableAdapter3.ClearBeforeFill = true;
            // 
            // stafftable
            // 
            this.stafftable.AutoGenerateColumns = false;
            this.stafftable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stafftable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.snoDataGridViewTextBoxColumn,
            this.oVERTIMEDataGridViewTextBoxColumn,
            this.aBSENCEDataGridViewTextBoxColumn,
            this.aTIMEDataGridViewTextBoxColumn});
            this.stafftable.DataSource = this.aTTENDENCEBindingSource3;
            this.stafftable.Location = new System.Drawing.Point(120, 39);
            this.stafftable.Name = "stafftable";
            this.stafftable.RowTemplate.Height = 23;
            this.stafftable.Size = new System.Drawing.Size(615, 191);
            this.stafftable.TabIndex = 46;
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "AID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "AID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // oVERTIMEDataGridViewTextBoxColumn
            // 
            this.oVERTIMEDataGridViewTextBoxColumn.DataPropertyName = "OVERTIME";
            this.oVERTIMEDataGridViewTextBoxColumn.HeaderText = "OVERTIME";
            this.oVERTIMEDataGridViewTextBoxColumn.Name = "oVERTIMEDataGridViewTextBoxColumn";
            // 
            // aBSENCEDataGridViewTextBoxColumn
            // 
            this.aBSENCEDataGridViewTextBoxColumn.DataPropertyName = "ABSENCE";
            this.aBSENCEDataGridViewTextBoxColumn.HeaderText = "ABSENCE";
            this.aBSENCEDataGridViewTextBoxColumn.Name = "aBSENCEDataGridViewTextBoxColumn";
            // 
            // aTIMEDataGridViewTextBoxColumn
            // 
            this.aTIMEDataGridViewTextBoxColumn.DataPropertyName = "ATIME";
            this.aTIMEDataGridViewTextBoxColumn.HeaderText = "ATIME";
            this.aTIMEDataGridViewTextBoxColumn.Name = "aTIMEDataGridViewTextBoxColumn";
            // 
            // 出勤管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 483);
            this.Controls.Add(this.stafftable);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "出勤管理";
            this.Text = "出勤管理";
            this.Load += new System.EventHandler(this.出勤管理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stafftable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private PMS.PMSDataSet3 pMSDataSet3;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource;
        private PMS.PMSDataSet3TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private PMS.PMSDataSet6 pMSDataSet6;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource1;
        private PMS.PMSDataSet6TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter1;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label4;
        private PMSDataSet30 pMSDataSet30;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource2;
        private PMSDataSet30TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter2;
        private PMSDataSet31 pMSDataSet31;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource3;
        private PMSDataSet31TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter3;
        private System.Windows.Forms.DataGridView stafftable;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oVERTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBSENCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTIMEDataGridViewTextBoxColumn;
    }
}