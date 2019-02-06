namespace EquipmentRepair2
{
    partial class PersonsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonsForm));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textPassUp = new System.Windows.Forms.TextBox();
            this.textPadreUp = new System.Windows.Forms.TextBox();
            this.textNamUp = new System.Windows.Forms.TextBox();
            this.textSurUp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPasportAdd = new System.Windows.Forms.TextBox();
            this.textPadreAdd = new System.Windows.Forms.TextBox();
            this.textNameAdd = new System.Windows.Forms.TextBox();
            this.textSurAdd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSearchPadre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textSearchSur = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textSearchName = new System.Windows.Forms.TextBox();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsDataSet = new EquipmentRepair2.PersonsDataSet();
            this.personsTableAdapter = new EquipmentRepair2.PersonsDataSetTableAdapters.PersonsTableAdapter();
            this.iDPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronimycDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Location = new System.Drawing.Point(339, 383);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textPassUp);
            this.groupBox3.Controls.Add(this.textPadreUp);
            this.groupBox3.Controls.Add(this.textNamUp);
            this.groupBox3.Controls.Add(this.textSurUp);
            this.groupBox3.Location = new System.Drawing.Point(472, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 177);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редагування";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(55, 141);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 23);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Редагувати";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "№ паспорта :\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "По батькові:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ім\'я:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Прізвище:";
            // 
            // textPassUp
            // 
            this.textPassUp.Location = new System.Drawing.Point(88, 102);
            this.textPassUp.MaxLength = 8;
            this.textPassUp.Name = "textPassUp";
            this.textPassUp.Size = new System.Drawing.Size(146, 20);
            this.textPassUp.TabIndex = 16;
            // 
            // textPadreUp
            // 
            this.textPadreUp.Location = new System.Drawing.Point(88, 77);
            this.textPadreUp.MaxLength = 50;
            this.textPadreUp.Name = "textPadreUp";
            this.textPadreUp.Size = new System.Drawing.Size(146, 20);
            this.textPadreUp.TabIndex = 15;
            this.textPadreUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurAdd_KeyPress);
            // 
            // textNamUp
            // 
            this.textNamUp.Location = new System.Drawing.Point(88, 51);
            this.textNamUp.MaxLength = 50;
            this.textNamUp.Name = "textNamUp";
            this.textNamUp.Size = new System.Drawing.Size(146, 20);
            this.textNamUp.TabIndex = 14;
            this.textNamUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurAdd_KeyPress);
            // 
            // textSurUp
            // 
            this.textSurUp.Location = new System.Drawing.Point(88, 25);
            this.textSurUp.MaxLength = 50;
            this.textSurUp.Name = "textSurUp";
            this.textSurUp.Size = new System.Drawing.Size(146, 20);
            this.textSurUp.TabIndex = 13;
            this.textSurUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurAdd_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.comboBoxDepartment);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ButtonAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textPasportAdd);
            this.groupBox2.Controls.Add(this.textPadreAdd);
            this.groupBox2.Controls.Add(this.textNameAdd);
            this.groupBox2.Controls.Add(this.textSurAdd);
            this.groupBox2.Location = new System.Drawing.Point(28, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 184);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додавання";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(98, 20);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDepartment.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Орг. одиниця";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(62, 154);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(96, 23);
            this.ButtonAdd.TabIndex = 21;
            this.ButtonAdd.Text = "Додати";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "№ паспорта :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "По батькові:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ім\'я:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Прізвище:";
            // 
            // textPasportAdd
            // 
            this.textPasportAdd.Location = new System.Drawing.Point(98, 129);
            this.textPasportAdd.MaxLength = 8;
            this.textPasportAdd.Name = "textPasportAdd";
            this.textPasportAdd.Size = new System.Drawing.Size(133, 20);
            this.textPasportAdd.TabIndex = 16;
            // 
            // textPadreAdd
            // 
            this.textPadreAdd.Location = new System.Drawing.Point(98, 103);
            this.textPadreAdd.MaxLength = 50;
            this.textPadreAdd.Name = "textPadreAdd";
            this.textPadreAdd.Size = new System.Drawing.Size(133, 20);
            this.textPadreAdd.TabIndex = 15;
            this.textPadreAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurAdd_KeyPress);
            // 
            // textNameAdd
            // 
            this.textNameAdd.Location = new System.Drawing.Point(98, 77);
            this.textNameAdd.MaxLength = 50;
            this.textNameAdd.Name = "textNameAdd";
            this.textNameAdd.Size = new System.Drawing.Size(133, 20);
            this.textNameAdd.TabIndex = 14;
            this.textNameAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurAdd_KeyPress);
            // 
            // textSurAdd
            // 
            this.textSurAdd.Location = new System.Drawing.Point(98, 51);
            this.textSurAdd.MaxLength = 50;
            this.textSurAdd.Name = "textSurAdd";
            this.textSurAdd.Size = new System.Drawing.Size(133, 20);
            this.textSurAdd.TabIndex = 13;
            this.textSurAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurAdd_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.textSearchPadre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textSearchSur);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textSearchName);
            this.groupBox1.Controls.Add(this.buttonRewind);
            this.groupBox1.Location = new System.Drawing.Point(28, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 61);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // textSearchPadre
            // 
            this.textSearchPadre.Location = new System.Drawing.Point(444, 24);
            this.textSearchPadre.Name = "textSearchPadre";
            this.textSearchPadre.Size = new System.Drawing.Size(112, 20);
            this.textSearchPadre.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "По батькові:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Прізвище:";
            // 
            // textSearchSur
            // 
            this.textSearchSur.Location = new System.Drawing.Point(74, 24);
            this.textSearchSur.Name = "textSearchSur";
            this.textSearchSur.Size = new System.Drawing.Size(106, 20);
            this.textSearchSur.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Ім\'я:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(574, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 54;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearchName
            // 
            this.textSearchName.Location = new System.Drawing.Point(237, 24);
            this.textSearchName.Name = "textSearchName";
            this.textSearchName.Size = new System.Drawing.Size(113, 20);
            this.textSearchName.TabIndex = 53;
            // 
            // buttonRewind
            // 
            this.buttonRewind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRewind.BackgroundImage")));
            this.buttonRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRewind.Location = new System.Drawing.Point(655, 22);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(23, 23);
            this.buttonRewind.TabIndex = 52;
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPersonDataGridViewTextBoxColumn,
            this.iDDepartmentDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronimycDataGridViewTextBoxColumn,
            this.passportnomDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.personsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 230);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=idea-pc;Initial Catalog=EquipmentRepair2;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.personsDataSet;
            // 
            // personsDataSet
            // 
            this.personsDataSet.DataSetName = "PersonsDataSet";
            this.personsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // iDPersonDataGridViewTextBoxColumn
            // 
            this.iDPersonDataGridViewTextBoxColumn.DataPropertyName = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.HeaderText = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.Name = "iDPersonDataGridViewTextBoxColumn";
            this.iDPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDepartmentDataGridViewTextBoxColumn
            // 
            this.iDDepartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.HeaderText = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.Name = "iDDepartmentDataGridViewTextBoxColumn";
            this.iDDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDepartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronimycDataGridViewTextBoxColumn
            // 
            this.patronimycDataGridViewTextBoxColumn.DataPropertyName = "Patronimyc";
            this.patronimycDataGridViewTextBoxColumn.HeaderText = "По батькові";
            this.patronimycDataGridViewTextBoxColumn.Name = "patronimycDataGridViewTextBoxColumn";
            this.patronimycDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportnomDataGridViewTextBoxColumn
            // 
            this.passportnomDataGridViewTextBoxColumn.DataPropertyName = "Passport_nom";
            this.passportnomDataGridViewTextBoxColumn.FillWeight = 65F;
            this.passportnomDataGridViewTextBoxColumn.HeaderText = "№ паспорта";
            this.passportnomDataGridViewTextBoxColumn.Name = "passportnomDataGridViewTextBoxColumn";
            this.passportnomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Dep_Nam";
            this.Column1.HeaderText = "Орг. одиниця";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // PersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 502);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonsForm";
            this.Text = "Персони";
            this.Load += new System.EventHandler(this.PersonsForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textPassUp;
        private System.Windows.Forms.TextBox textPadreUp;
        private System.Windows.Forms.TextBox textNamUp;
        private System.Windows.Forms.TextBox textSurUp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPasportAdd;
        private System.Windows.Forms.TextBox textPadreAdd;
        private System.Windows.Forms.TextBox textNameAdd;
        private System.Windows.Forms.TextBox textSurAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSearchPadre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textSearchSur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textSearchName;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private PersonsDataSet personsDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private PersonsDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronimycDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}