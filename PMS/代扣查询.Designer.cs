namespace PMS
{
    partial class 代扣查询
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
            this.withholdtable = new System.Windows.Forms.DataGridView();
            this.wITHHOLDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wITHHOLDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wITHHOLDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet41 = new PMS.PMSDataSet41();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.wITHHOLDTableAdapter = new PMS.PMSDataSet41TableAdapters.WITHHOLDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.withholdtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wITHHOLDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet41)).BeginInit();
            this.SuspendLayout();
            // 
            // withholdtable
            // 
            this.withholdtable.AutoGenerateColumns = false;
            this.withholdtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.withholdtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wITHHOLDIDDataGridViewTextBoxColumn,
            this.snoDataGridViewTextBoxColumn,
            this.rIDDataGridViewTextBoxColumn,
            this.wITHHOLDTIMEDataGridViewTextBoxColumn});
            this.withholdtable.DataSource = this.wITHHOLDBindingSource;
            this.withholdtable.Location = new System.Drawing.Point(34, 194);
            this.withholdtable.Name = "withholdtable";
            this.withholdtable.RowTemplate.Height = 23;
            this.withholdtable.Size = new System.Drawing.Size(727, 231);
            this.withholdtable.TabIndex = 88;
            // 
            // wITHHOLDIDDataGridViewTextBoxColumn
            // 
            this.wITHHOLDIDDataGridViewTextBoxColumn.DataPropertyName = "WITHHOLDID";
            this.wITHHOLDIDDataGridViewTextBoxColumn.HeaderText = "WITHHOLDID";
            this.wITHHOLDIDDataGridViewTextBoxColumn.Name = "wITHHOLDIDDataGridViewTextBoxColumn";
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "RID";
            this.rIDDataGridViewTextBoxColumn.HeaderText = "RID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            // 
            // wITHHOLDTIMEDataGridViewTextBoxColumn
            // 
            this.wITHHOLDTIMEDataGridViewTextBoxColumn.DataPropertyName = "WITHHOLDTIME";
            this.wITHHOLDTIMEDataGridViewTextBoxColumn.HeaderText = "WITHHOLDTIME";
            this.wITHHOLDTIMEDataGridViewTextBoxColumn.Name = "wITHHOLDTIMEDataGridViewTextBoxColumn";
            // 
            // wITHHOLDBindingSource
            // 
            this.wITHHOLDBindingSource.DataMember = "WITHHOLD";
            this.wITHHOLDBindingSource.DataSource = this.pMSDataSet41;
            // 
            // pMSDataSet41
            // 
            this.pMSDataSet41.DataSetName = "PMSDataSet41";
            this.pMSDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(181, 27);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(146, 21);
            this.t1.TabIndex = 87;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(531, 91);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(106, 21);
            this.t4.TabIndex = 85;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(531, 22);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(106, 21);
            this.t2.TabIndex = 83;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(221, 87);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(106, 21);
            this.t3.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(83, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 27);
            this.label12.TabIndex = 86;
            this.label12.Text = "代扣编号";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(348, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 84;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(473, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 81;
            this.label4.Text = "工号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(473, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 80;
            this.label5.Text = "日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(83, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 27);
            this.label10.TabIndex = 79;
            this.label10.Text = "保险税收编号";
            // 
            // wITHHOLDTableAdapter
            // 
            this.wITHHOLDTableAdapter.ClearBeforeFill = true;
            // 
            // 代扣查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.withholdtable);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Name = "代扣查询";
            this.Text = "代扣查询";
            this.Load += new System.EventHandler(this.代扣查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.withholdtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wITHHOLDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet41)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView withholdtable;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private PMSDataSet41 pMSDataSet41;
        private System.Windows.Forms.BindingSource wITHHOLDBindingSource;
        private PMSDataSet41TableAdapters.WITHHOLDTableAdapter wITHHOLDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wITHHOLDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wITHHOLDTIMEDataGridViewTextBoxColumn;
    }
}