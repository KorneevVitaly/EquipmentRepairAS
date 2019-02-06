namespace EquipmentRepair2
{
    partial class DepartmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsForm));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textEdit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.iDDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsDataSet = new EquipmentRepair2.DepartmentsDataSet();
            this.departmentsTableAdapter = new EquipmentRepair2.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(466, 256);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEdit);
            this.groupBox3.Controls.Add(this.textEdit);
            this.groupBox3.Location = new System.Drawing.Point(363, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 84);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редагування";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(172, 35);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 56;
            this.buttonEdit.Text = "Редагувати";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textEdit
            // 
            this.textEdit.Location = new System.Drawing.Point(17, 37);
            this.textEdit.MaxLength = 100;
            this.textEdit.Name = "textEdit";
            this.textEdit.Size = new System.Drawing.Size(127, 20);
            this.textEdit.TabIndex = 55;
            this.textEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdd_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.textAdd);
            this.groupBox2.Location = new System.Drawing.Point(363, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 83);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додавання";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(172, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textAdd
            // 
            this.textAdd.Location = new System.Drawing.Point(17, 32);
            this.textAdd.MaxLength = 100;
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(127, 20);
            this.textAdd.TabIndex = 55;
            this.textAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdd_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Controls.Add(this.buttonRewind);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 57);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(182, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 54;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(27, 21);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(127, 20);
            this.textSearch.TabIndex = 53;
            // 
            // buttonRewind
            // 
            this.buttonRewind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRewind.BackgroundImage")));
            this.buttonRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRewind.Location = new System.Drawing.Point(278, 19);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(23, 23);
            this.buttonRewind.TabIndex = 52;
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDepartmentDataGridViewTextBoxColumn,
            this.depNamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(319, 200);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=idea-pc;Initial Catalog=EquipmentRepair2;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // iDDepartmentDataGridViewTextBoxColumn
            // 
            this.iDDepartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.HeaderText = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.Name = "iDDepartmentDataGridViewTextBoxColumn";
            this.iDDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDepartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // depNamDataGridViewTextBoxColumn
            // 
            this.depNamDataGridViewTextBoxColumn.DataPropertyName = "Dep_Nam";
            this.depNamDataGridViewTextBoxColumn.HeaderText = "Орг. одиниця підприємства";
            this.depNamDataGridViewTextBoxColumn.Name = "depNamDataGridViewTextBoxColumn";
            this.depNamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.departmentsDataSet;
            // 
            // departmentsDataSet
            // 
            this.departmentsDataSet.DataSetName = "DepartmentsDataSet";
            this.departmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 332);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentsForm";
            this.Text = "Організаційна одиниця підприємства";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DepartmentsDataSet departmentsDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private DepartmentsDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depNamDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}