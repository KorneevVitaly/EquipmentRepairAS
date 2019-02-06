namespace EquipmentRepair2
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlDataSet = new EquipmentRepair2.ControlDataSet();
            this.actreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.act_returnTableAdapter = new EquipmentRepair2.ControlDataSetTableAdapters.Act_returnTableAdapter();
            this.iDActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOrderremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonGiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonRetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actreturnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Запит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(467, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата з:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDActDataGridViewTextBoxColumn,
            this.iDOrderremDataGridViewTextBoxColumn,
            this.iDPersonGiveDataGridViewTextBoxColumn,
            this.iDPersonRetDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.DataSource = this.actreturnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 198);
            this.dataGridView1.TabIndex = 7;
            // 
            // controlDataSet
            // 
            this.controlDataSet.DataSetName = "ControlDataSet";
            this.controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actreturnBindingSource
            // 
            this.actreturnBindingSource.DataMember = "Act_return";
            this.actreturnBindingSource.DataSource = this.controlDataSet;
            // 
            // act_returnTableAdapter
            // 
            this.act_returnTableAdapter.ClearBeforeFill = true;
            // 
            // iDActDataGridViewTextBoxColumn
            // 
            this.iDActDataGridViewTextBoxColumn.DataPropertyName = "ID_Act";
            this.iDActDataGridViewTextBoxColumn.HeaderText = "ID_Act";
            this.iDActDataGridViewTextBoxColumn.Name = "iDActDataGridViewTextBoxColumn";
            this.iDActDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDActDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDOrderremDataGridViewTextBoxColumn
            // 
            this.iDOrderremDataGridViewTextBoxColumn.DataPropertyName = "ID_Order_rem";
            this.iDOrderremDataGridViewTextBoxColumn.HeaderText = "ID_Order_rem";
            this.iDOrderremDataGridViewTextBoxColumn.Name = "iDOrderremDataGridViewTextBoxColumn";
            this.iDOrderremDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDOrderremDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPersonGiveDataGridViewTextBoxColumn
            // 
            this.iDPersonGiveDataGridViewTextBoxColumn.DataPropertyName = "ID_PersonGive";
            this.iDPersonGiveDataGridViewTextBoxColumn.HeaderText = "ID_PersonGive";
            this.iDPersonGiveDataGridViewTextBoxColumn.Name = "iDPersonGiveDataGridViewTextBoxColumn";
            this.iDPersonGiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPersonGiveDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPersonRetDataGridViewTextBoxColumn
            // 
            this.iDPersonRetDataGridViewTextBoxColumn.DataPropertyName = "ID_PersonRet";
            this.iDPersonRetDataGridViewTextBoxColumn.HeaderText = "ID_PersonRet";
            this.iDPersonRetDataGridViewTextBoxColumn.Name = "iDPersonRetDataGridViewTextBoxColumn";
            this.iDPersonRetDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPersonRetDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "Nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Nomer";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            this.nomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomerDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date_";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date_";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "Date_From";
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Date_From";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateFromDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "Date_To";
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Date_To";
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateToDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Eq_name";
            this.Column1.HeaderText = "Обладнання";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NEED";
            this.Column2.HeaderText = "Необхідно відремонтувати";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONE";
            this.Column3.HeaderText = "Відремонтовано";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DOLG";
            this.Column4.HeaderText = "Не відремонтовано";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ShowReset
            // 
            this.ShowReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowReset.BackgroundImage")));
            this.ShowReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowReset.Location = new System.Drawing.Point(420, 72);
            this.ShowReset.Name = "ShowReset";
            this.ShowReset.Size = new System.Drawing.Size(23, 23);
            this.ShowReset.TabIndex = 25;
            this.ShowReset.UseVisualStyleBackColor = true;
            this.ShowReset.Click += new System.EventHandler(this.ShowReset_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 366);
            this.Controls.Add(this.ShowReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ControlForm";
            this.Text = "Контроль проведення ремонтів обладнання";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actreturnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlDataSet controlDataSet;
        private System.Windows.Forms.BindingSource actreturnBindingSource;
        private ControlDataSetTableAdapters.Act_returnTableAdapter act_returnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderremDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonGiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonRetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button ShowReset;
    }
}