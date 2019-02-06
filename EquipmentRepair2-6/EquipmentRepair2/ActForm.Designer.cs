namespace EquipmentRepair2
{
    partial class ActForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActForm));
            this.buttonDeleteEquipment = new System.Windows.Forms.Button();
            this.buttonDeleteAct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditAmauntInAct = new System.Windows.Forms.Button();
            this.buttonEditAct = new System.Windows.Forms.Button();
            this.numericUpDownEdit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShowReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textSearchNom = new System.Windows.Forms.TextBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxNom = new System.Windows.Forms.CheckBox();
            this.dataGridEqInAct = new System.Windows.Forms.DataGridView();
            this.iDEquipmentinActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDActDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDworktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentInActActBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actreturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actDataSet = new EquipmentRepair2.ActDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAct = new System.Windows.Forms.DataGridView();
            this.iDActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOrderremDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonGiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonRetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPerformerPerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textOredererPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.act_returnTableAdapter = new EquipmentRepair2.ActDataSetTableAdapters.Act_returnTableAdapter();
            this.equipment_in_ActTableAdapter = new EquipmentRepair2.ActDataSetTableAdapters.Equipment_in_ActTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdit)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEqInAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentInActActBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actreturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAct)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteEquipment
            // 
            this.buttonDeleteEquipment.Location = new System.Drawing.Point(776, 421);
            this.buttonDeleteEquipment.Name = "buttonDeleteEquipment";
            this.buttonDeleteEquipment.Size = new System.Drawing.Size(115, 23);
            this.buttonDeleteEquipment.TabIndex = 30;
            this.buttonDeleteEquipment.Text = "Видалити пристрій";
            this.buttonDeleteEquipment.UseVisualStyleBackColor = true;
            this.buttonDeleteEquipment.Click += new System.EventHandler(this.buttonDeleteEquipment_Click);
            // 
            // buttonDeleteAct
            // 
            this.buttonDeleteAct.Location = new System.Drawing.Point(609, 421);
            this.buttonDeleteAct.Name = "buttonDeleteAct";
            this.buttonDeleteAct.Size = new System.Drawing.Size(107, 23);
            this.buttonDeleteAct.TabIndex = 29;
            this.buttonDeleteAct.Text = "Видалити акт";
            this.buttonDeleteAct.UseVisualStyleBackColor = true;
            this.buttonDeleteAct.Click += new System.EventHandler(this.buttonDeleteAct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEditAmauntInAct);
            this.groupBox1.Controls.Add(this.buttonEditAct);
            this.groupBox1.Controls.Add(this.numericUpDownEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textEditNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(563, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 130);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редагування";
            // 
            // buttonEditAmauntInAct
            // 
            this.buttonEditAmauntInAct.Location = new System.Drawing.Point(224, 81);
            this.buttonEditAmauntInAct.Name = "buttonEditAmauntInAct";
            this.buttonEditAmauntInAct.Size = new System.Drawing.Size(104, 35);
            this.buttonEditAmauntInAct.TabIndex = 7;
            this.buttonEditAmauntInAct.Text = "Редагуати к-сть пристроїв в акті";
            this.buttonEditAmauntInAct.UseVisualStyleBackColor = true;
            this.buttonEditAmauntInAct.Click += new System.EventHandler(this.buttonEditAmauntInAct_Click);
            // 
            // buttonEditAct
            // 
            this.buttonEditAct.Location = new System.Drawing.Point(46, 93);
            this.buttonEditAct.Name = "buttonEditAct";
            this.buttonEditAct.Size = new System.Drawing.Size(107, 23);
            this.buttonEditAct.TabIndex = 6;
            this.buttonEditAct.Text = "Редагувати акт";
            this.buttonEditAct.UseVisualStyleBackColor = true;
            this.buttonEditAct.Click += new System.EventHandler(this.buttonEditAct_Click);
            // 
            // numericUpDownEdit
            // 
            this.numericUpDownEdit.Location = new System.Drawing.Point(278, 43);
            this.numericUpDownEdit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEdit.Name = "numericUpDownEdit";
            this.numericUpDownEdit.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownEdit.TabIndex = 5;
            this.numericUpDownEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кількість";
            // 
            // dateTimePickerEdit
            // 
            this.dateTimePickerEdit.Location = new System.Drawing.Point(65, 58);
            this.dateTimePickerEdit.Name = "dateTimePickerEdit";
            this.dateTimePickerEdit.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerEdit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата";
            // 
            // textEditNom
            // 
            this.textEditNom.Location = new System.Drawing.Point(87, 25);
            this.textEditNom.Name = "textEditNom";
            this.textEditNom.Size = new System.Drawing.Size(47, 20);
            this.textEditNom.TabIndex = 1;
            this.textEditNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditNom_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "№";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShowReset);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.textSearchNom);
            this.groupBox3.Controls.Add(this.checkBoxDate);
            this.groupBox3.Controls.Add(this.checkBoxNom);
            this.groupBox3.Location = new System.Drawing.Point(563, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 86);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пошук по акту";
            // 
            // ShowReset
            // 
            this.ShowReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowReset.BackgroundImage")));
            this.ShowReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowReset.Location = new System.Drawing.Point(294, 46);
            this.ShowReset.Name = "ShowReset";
            this.ShowReset.Size = new System.Drawing.Size(30, 30);
            this.ShowReset.TabIndex = 24;
            this.ShowReset.UseVisualStyleBackColor = true;
            this.ShowReset.Click += new System.EventHandler(this.ShowReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(264, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textSearchNom
            // 
            this.textSearchNom.Location = new System.Drawing.Point(119, 19);
            this.textSearchNom.MaxLength = 5;
            this.textSearchNom.Name = "textSearchNom";
            this.textSearchNom.Size = new System.Drawing.Size(59, 20);
            this.textSearchNom.TabIndex = 3;
            this.textSearchNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearchNom_KeyPress);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(33, 51);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(62, 17);
            this.checkBoxDate.TabIndex = 1;
            this.checkBoxDate.Text = "По даті";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxNom
            // 
            this.checkBoxNom.AutoSize = true;
            this.checkBoxNom.Checked = true;
            this.checkBoxNom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNom.Location = new System.Drawing.Point(33, 19);
            this.checkBoxNom.Name = "checkBoxNom";
            this.checkBoxNom.Size = new System.Drawing.Size(80, 17);
            this.checkBoxNom.TabIndex = 0;
            this.checkBoxNom.Text = "По номеру";
            this.checkBoxNom.UseVisualStyleBackColor = true;
            this.checkBoxNom.CheckedChanged += new System.EventHandler(this.checkBoxNom_CheckedChanged);
            // 
            // dataGridEqInAct
            // 
            this.dataGridEqInAct.AllowUserToAddRows = false;
            this.dataGridEqInAct.AutoGenerateColumns = false;
            this.dataGridEqInAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEqInAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEqInAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEquipmentinActDataGridViewTextBoxColumn,
            this.iDActDataGridViewTextBoxColumn1,
            this.iDEquipmentDataGridViewTextBoxColumn,
            this.iDworktypeDataGridViewTextBoxColumn,
            this.Column3,
            this.Column2,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridEqInAct.DataSource = this.equipmentInActActBindingSource;
            this.dataGridEqInAct.Location = new System.Drawing.Point(15, 193);
            this.dataGridEqInAct.Name = "dataGridEqInAct";
            this.dataGridEqInAct.ReadOnly = true;
            this.dataGridEqInAct.Size = new System.Drawing.Size(519, 242);
            this.dataGridEqInAct.TabIndex = 26;
            this.dataGridEqInAct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEqInAct_CellClick);
            // 
            // iDEquipmentinActDataGridViewTextBoxColumn
            // 
            this.iDEquipmentinActDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipment_in_Act";
            this.iDEquipmentinActDataGridViewTextBoxColumn.HeaderText = "ID_Equipment_in_Act";
            this.iDEquipmentinActDataGridViewTextBoxColumn.Name = "iDEquipmentinActDataGridViewTextBoxColumn";
            this.iDEquipmentinActDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEquipmentinActDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDActDataGridViewTextBoxColumn1
            // 
            this.iDActDataGridViewTextBoxColumn1.DataPropertyName = "ID_Act";
            this.iDActDataGridViewTextBoxColumn1.HeaderText = "ID_Act";
            this.iDActDataGridViewTextBoxColumn1.Name = "iDActDataGridViewTextBoxColumn1";
            this.iDActDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDActDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDEquipmentDataGridViewTextBoxColumn
            // 
            this.iDEquipmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.HeaderText = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.Name = "iDEquipmentDataGridViewTextBoxColumn";
            this.iDEquipmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEquipmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDworktypeDataGridViewTextBoxColumn
            // 
            this.iDworktypeDataGridViewTextBoxColumn.DataPropertyName = "ID_work_type";
            this.iDworktypeDataGridViewTextBoxColumn.HeaderText = "ID_work_type";
            this.iDworktypeDataGridViewTextBoxColumn.Name = "iDworktypeDataGridViewTextBoxColumn";
            this.iDworktypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDworktypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "wrk_tp";
            this.Column3.HeaderText = "Вид робіт";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Eq_name";
            this.Column2.HeaderText = "Обладнання";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.FillWeight = 40F;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipmentInActActBindingSource
            // 
            this.equipmentInActActBindingSource.DataMember = "EquipmentInAct_Act";
            this.equipmentInActActBindingSource.DataSource = this.actreturnBindingSource;
            // 
            // actreturnBindingSource
            // 
            this.actreturnBindingSource.DataMember = "Act_return";
            this.actreturnBindingSource.DataSource = this.actDataSet;
            // 
            // actDataSet
            // 
            this.actDataSet.DataSetName = "ActDataSet";
            this.actDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Прилади в акті";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Акт";
            // 
            // dataGridAct
            // 
            this.dataGridAct.AllowUserToAddRows = false;
            this.dataGridAct.AutoGenerateColumns = false;
            this.dataGridAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDActDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iDOrderremDataGridViewTextBoxColumn,
            this.Column1,
            this.iDPersonGiveDataGridViewTextBoxColumn,
            this.iDPersonRetDataGridViewTextBoxColumn,
            this.dateFromDataGridViewTextBoxColumn,
            this.dateToDataGridViewTextBoxColumn});
            this.dataGridAct.DataSource = this.actreturnBindingSource;
            this.dataGridAct.Location = new System.Drawing.Point(12, 30);
            this.dataGridAct.Name = "dataGridAct";
            this.dataGridAct.ReadOnly = true;
            this.dataGridAct.Size = new System.Drawing.Size(592, 123);
            this.dataGridAct.TabIndex = 23;
            this.dataGridAct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAct_CellClick);
            // 
            // iDActDataGridViewTextBoxColumn
            // 
            this.iDActDataGridViewTextBoxColumn.DataPropertyName = "ID_Act";
            this.iDActDataGridViewTextBoxColumn.HeaderText = "ID_Act";
            this.iDActDataGridViewTextBoxColumn.Name = "iDActDataGridViewTextBoxColumn";
            this.iDActDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDActDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "Nomer";
            this.nomerDataGridViewTextBoxColumn.FillWeight = 30F;
            this.nomerDataGridViewTextBoxColumn.HeaderText = "№";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            this.nomerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date_";
            this.dateDataGridViewTextBoxColumn.FillWeight = 60F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDOrderremDataGridViewTextBoxColumn
            // 
            this.iDOrderremDataGridViewTextBoxColumn.DataPropertyName = "ID_Order_rem";
            this.iDOrderremDataGridViewTextBoxColumn.HeaderText = "ID_Order_rem";
            this.iDOrderremDataGridViewTextBoxColumn.Name = "iDOrderremDataGridViewTextBoxColumn";
            this.iDOrderremDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDOrderremDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ORD";
            this.Column1.HeaderText = "Замовлення";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // dateFromDataGridViewTextBoxColumn
            // 
            this.dateFromDataGridViewTextBoxColumn.DataPropertyName = "Date_From";
            this.dateFromDataGridViewTextBoxColumn.FillWeight = 60F;
            this.dateFromDataGridViewTextBoxColumn.HeaderText = "Дата з";
            this.dateFromDataGridViewTextBoxColumn.Name = "dateFromDataGridViewTextBoxColumn";
            this.dateFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateToDataGridViewTextBoxColumn
            // 
            this.dateToDataGridViewTextBoxColumn.DataPropertyName = "Date_To";
            this.dateToDataGridViewTextBoxColumn.FillWeight = 60F;
            this.dateToDataGridViewTextBoxColumn.HeaderText = "Дата по";
            this.dateToDataGridViewTextBoxColumn.Name = "dateToDataGridViewTextBoxColumn";
            this.dateToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textPerformerPerson
            // 
            this.textPerformerPerson.Location = new System.Drawing.Point(692, 90);
            this.textPerformerPerson.Name = "textPerformerPerson";
            this.textPerformerPerson.ReadOnly = true;
            this.textPerformerPerson.Size = new System.Drawing.Size(237, 20);
            this.textPerformerPerson.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Прийняв:";
            // 
            // textOredererPerson
            // 
            this.textOredererPerson.Location = new System.Drawing.Point(692, 55);
            this.textOredererPerson.Name = "textOredererPerson";
            this.textOredererPerson.ReadOnly = true;
            this.textOredererPerson.Size = new System.Drawing.Size(237, 20);
            this.textOredererPerson.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Здав:";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=idea-pc;Initial Catalog=EquipmentRepair2;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // act_returnTableAdapter
            // 
            this.act_returnTableAdapter.ClearBeforeFill = true;
            // 
            // equipment_in_ActTableAdapter
            // 
            this.equipment_in_ActTableAdapter.ClearBeforeFill = true;
            // 
            // ActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 463);
            this.Controls.Add(this.textPerformerPerson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textOredererPerson);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDeleteEquipment);
            this.Controls.Add(this.buttonDeleteAct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridEqInAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAct);
            this.Name = "ActForm";
            this.Text = "Акт приймання-здачі відремонтованих, реконструйованих та модернізованих об’єктів " +
    "";
            this.Load += new System.EventHandler(this.ActForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEqInAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentInActActBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actreturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteEquipment;
        private System.Windows.Forms.Button buttonDeleteAct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEditAmauntInAct;
        private System.Windows.Forms.Button buttonEditAct;
        private System.Windows.Forms.NumericUpDown numericUpDownEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEditNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ShowReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textSearchNom;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxNom;
        private System.Windows.Forms.DataGridView dataGridEqInAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAct;
        private System.Windows.Forms.TextBox textPerformerPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textOredererPerson;
        private System.Windows.Forms.Label label7;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ActDataSet actDataSet;
        private System.Windows.Forms.BindingSource actreturnBindingSource;
        private ActDataSetTableAdapters.Act_returnTableAdapter act_returnTableAdapter;
        private System.Windows.Forms.BindingSource equipmentInActActBindingSource;
        private ActDataSetTableAdapters.Equipment_in_ActTableAdapter equipment_in_ActTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderremDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonGiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonRetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentinActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDActDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDworktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}