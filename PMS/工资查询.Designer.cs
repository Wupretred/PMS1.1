namespace PMS
{
    partial class 工资查询
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.salarytable = new System.Windows.Forms.DataGridView();
            this.sALARYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosspayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realpayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paytimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet40 = new PMS.PMSDataSet40();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tempTableAdapter = new PMS.PMSDataSet40TableAdapters.tempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salarytable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet40)).BeginInit();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(115, 37);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(96, 21);
            this.t1.TabIndex = 79;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(17, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 27);
            this.label21.TabIndex = 78;
            this.label21.Text = "工资编号";
            // 
            // salarytable
            // 
            this.salarytable.AutoGenerateColumns = false;
            this.salarytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salarytable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sALARYIDDataGridViewTextBoxColumn,
            this.snoDataGridViewTextBoxColumn,
            this.deptnoDataGridViewTextBoxColumn,
            this.grosspayDataGridViewTextBoxColumn,
            this.realpayDataGridViewTextBoxColumn,
            this.paytimeDataGridViewTextBoxColumn});
            this.salarytable.DataSource = this.tempBindingSource;
            this.salarytable.Location = new System.Drawing.Point(35, 186);
            this.salarytable.Name = "salarytable";
            this.salarytable.RowTemplate.Height = 23;
            this.salarytable.Size = new System.Drawing.Size(730, 241);
            this.salarytable.TabIndex = 77;
            // 
            // sALARYIDDataGridViewTextBoxColumn
            // 
            this.sALARYIDDataGridViewTextBoxColumn.DataPropertyName = "SALARYID";
            this.sALARYIDDataGridViewTextBoxColumn.HeaderText = "SALARYID";
            this.sALARYIDDataGridViewTextBoxColumn.Name = "sALARYIDDataGridViewTextBoxColumn";
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // deptnoDataGridViewTextBoxColumn
            // 
            this.deptnoDataGridViewTextBoxColumn.DataPropertyName = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.HeaderText = "Deptno";
            this.deptnoDataGridViewTextBoxColumn.Name = "deptnoDataGridViewTextBoxColumn";
            // 
            // grosspayDataGridViewTextBoxColumn
            // 
            this.grosspayDataGridViewTextBoxColumn.DataPropertyName = "Grosspay";
            this.grosspayDataGridViewTextBoxColumn.HeaderText = "Grosspay";
            this.grosspayDataGridViewTextBoxColumn.Name = "grosspayDataGridViewTextBoxColumn";
            // 
            // realpayDataGridViewTextBoxColumn
            // 
            this.realpayDataGridViewTextBoxColumn.DataPropertyName = "Realpay";
            this.realpayDataGridViewTextBoxColumn.HeaderText = "Realpay";
            this.realpayDataGridViewTextBoxColumn.Name = "realpayDataGridViewTextBoxColumn";
            this.realpayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paytimeDataGridViewTextBoxColumn
            // 
            this.paytimeDataGridViewTextBoxColumn.DataPropertyName = "Paytime";
            this.paytimeDataGridViewTextBoxColumn.HeaderText = "Paytime";
            this.paytimeDataGridViewTextBoxColumn.Name = "paytimeDataGridViewTextBoxColumn";
            // 
            // tempBindingSource
            // 
            this.tempBindingSource.DataMember = "temp";
            this.tempBindingSource.DataSource = this.pMSDataSet40;
            // 
            // pMSDataSet40
            // 
            this.pMSDataSet40.DataSetName = "PMSDataSet40";
            this.pMSDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(536, 85);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(96, 21);
            this.t5.TabIndex = 76;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(683, 37);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(96, 21);
            this.t3.TabIndex = 74;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(396, 39);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(96, 21);
            this.t2.TabIndex = 73;
            // 
            // t4
            // 
            this.t4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t4.FormattingEnabled = true;
            this.t4.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06"});
            this.t4.Location = new System.Drawing.Point(238, 90);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(96, 20);
            this.t4.TabIndex = 75;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(376, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 44);
            this.button6.TabIndex = 72;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(180, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 71;
            this.label8.Text = "部门";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(478, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 27);
            this.label14.TabIndex = 70;
            this.label14.Text = "时间";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(615, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 27);
            this.label17.TabIndex = 69;
            this.label17.Text = "姓名";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(328, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 27);
            this.label18.TabIndex = 68;
            this.label18.Text = "工号";
            // 
            // tempTableAdapter
            // 
            this.tempTableAdapter.ClearBeforeFill = true;
            // 
            // 工资查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.salarytable);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Name = "工资查询";
            this.Text = "工资查询";
            this.Load += new System.EventHandler(this.工资查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salarytable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet40)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView salarytable;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.ComboBox t4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private PMSDataSet40 pMSDataSet40;
        private System.Windows.Forms.BindingSource tempBindingSource;
        private PMSDataSet40TableAdapters.tempTableAdapter tempTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosspayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realpayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paytimeDataGridViewTextBoxColumn;
    }
}