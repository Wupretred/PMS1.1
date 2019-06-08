namespace PMS
{
    partial class 出勤查询
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
            this.attendencetable = new System.Windows.Forms.DataGridView();
            this.aTTENDENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet42 = new PMS.PMSDataSet42();
            this.button3 = new System.Windows.Forms.Button();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aTTENDENCETableAdapter = new PMS.PMSDataSet42TableAdapters.ATTENDENCETableAdapter();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oVERTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBSENCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attendencetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet42)).BeginInit();
            this.SuspendLayout();
            // 
            // attendencetable
            // 
            this.attendencetable.AutoGenerateColumns = false;
            this.attendencetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendencetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.snoDataGridViewTextBoxColumn,
            this.oVERTIMEDataGridViewTextBoxColumn,
            this.aBSENCEDataGridViewTextBoxColumn,
            this.aTIMEDataGridViewTextBoxColumn});
            this.attendencetable.DataSource = this.aTTENDENCEBindingSource;
            this.attendencetable.Location = new System.Drawing.Point(64, 189);
            this.attendencetable.Name = "attendencetable";
            this.attendencetable.RowTemplate.Height = 23;
            this.attendencetable.Size = new System.Drawing.Size(704, 213);
            this.attendencetable.TabIndex = 66;
            // 
            // aTTENDENCEBindingSource
            // 
            this.aTTENDENCEBindingSource.DataMember = "ATTENDENCE";
            this.aTTENDENCEBindingSource.DataSource = this.pMSDataSet42;
            // 
            // pMSDataSet42
            // 
            this.pMSDataSet42.DataSetName = "PMSDataSet42";
            this.pMSDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(376, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 33);
            this.button3.TabIndex = 65;
            this.button3.Text = "查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(608, 77);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(94, 21);
            this.t4.TabIndex = 64;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(608, 19);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(99, 21);
            this.t1.TabIndex = 63;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(418, 79);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(102, 21);
            this.t3.TabIndex = 62;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(186, 77);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(99, 21);
            this.t2.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(546, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 60;
            this.label9.Text = "工号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(550, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(316, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "缺勤天数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(84, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "加班天数";
            // 
            // aTTENDENCETableAdapter
            // 
            this.aTTENDENCETableAdapter.ClearBeforeFill = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 21);
            this.textBox1.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(84, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 67;
            this.label4.Text = "出勤编号";
            // 
            // 出勤查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.attendencetable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "出勤查询";
            this.Text = "出勤查询";
            this.Load += new System.EventHandler(this.出勤查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendencetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTTENDENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet42)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView attendencetable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PMSDataSet42 pMSDataSet42;
        private System.Windows.Forms.BindingSource aTTENDENCEBindingSource;
        private PMSDataSet42TableAdapters.ATTENDENCETableAdapter aTTENDENCETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oVERTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBSENCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}