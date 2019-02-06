namespace EquipmentRepair2
{
    partial class EquipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEditEquip = new System.Windows.Forms.TextBox();
            this.textEditFactor = new System.Windows.Forms.TextBox();
            this.textEditInvent = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textEditNomenc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAddEquip = new System.Windows.Forms.TextBox();
            this.textAddFactor = new System.Windows.Forms.TextBox();
            this.textAddInvent = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textAddNomenk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.equipmentDataSet = new EquipmentRepair2.EquipmentDataSet();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new EquipmentRepair2.EquipmentDataSetTableAdapters.EquipmentTableAdapter();
            this.iDEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomencnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorynomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eqnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(393, 310);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textEditEquip);
            this.groupBox3.Controls.Add(this.textEditFactor);
            this.groupBox3.Controls.Add(this.textEditInvent);
            this.groupBox3.Controls.Add(this.buttonEdit);
            this.groupBox3.Controls.Add(this.textEditNomenc);
            this.groupBox3.Location = new System.Drawing.Point(528, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 196);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редагування";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Обладнання/прилад:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Заводський номер:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Інвентарний номер:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Номенклатурний номер:";
            // 
            // textEditEquip
            // 
            this.textEditEquip.Location = new System.Drawing.Point(154, 108);
            this.textEditEquip.MaxLength = 70;
            this.textEditEquip.Name = "textEditEquip";
            this.textEditEquip.Size = new System.Drawing.Size(127, 20);
            this.textEditEquip.TabIndex = 62;
            this.textEditEquip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddEquip_KeyPress);
            // 
            // textEditFactor
            // 
            this.textEditFactor.Location = new System.Drawing.Point(154, 82);
            this.textEditFactor.MaxLength = 11;
            this.textEditFactor.Name = "textEditFactor";
            this.textEditFactor.Size = new System.Drawing.Size(127, 20);
            this.textEditFactor.TabIndex = 61;
            this.textEditFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddNomenk_KeyPress);
            // 
            // textEditInvent
            // 
            this.textEditInvent.Location = new System.Drawing.Point(154, 54);
            this.textEditInvent.MaxLength = 6;
            this.textEditInvent.Name = "textEditInvent";
            this.textEditInvent.Size = new System.Drawing.Size(127, 20);
            this.textEditInvent.TabIndex = 60;
            this.textEditInvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddNomenk_KeyPress);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(116, 145);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 56;
            this.buttonEdit.Text = "Редагувати";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textEditNomenc
            // 
            this.textEditNomenc.Location = new System.Drawing.Point(154, 28);
            this.textEditNomenc.MaxLength = 11;
            this.textEditNomenc.Name = "textEditNomenc";
            this.textEditNomenc.Size = new System.Drawing.Size(127, 20);
            this.textEditNomenc.TabIndex = 55;
            this.textEditNomenc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddNomenk_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxDepartment);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textAddEquip);
            this.groupBox2.Controls.Add(this.textAddFactor);
            this.groupBox2.Controls.Add(this.textAddInvent);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.textAddNomenk);
            this.groupBox2.Location = new System.Drawing.Point(23, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 206);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додавання";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Обладнання/прилад:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Заводський номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Інвентарний номер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Номенклатурний номер:";
            // 
            // textAddEquip
            // 
            this.textAddEquip.Location = new System.Drawing.Point(162, 131);
            this.textAddEquip.MaxLength = 70;
            this.textAddEquip.Name = "textAddEquip";
            this.textAddEquip.Size = new System.Drawing.Size(127, 20);
            this.textAddEquip.TabIndex = 59;
            this.textAddEquip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddEquip_KeyPress);
            // 
            // textAddFactor
            // 
            this.textAddFactor.Location = new System.Drawing.Point(162, 105);
            this.textAddFactor.MaxLength = 11;
            this.textAddFactor.Name = "textAddFactor";
            this.textAddFactor.Size = new System.Drawing.Size(127, 20);
            this.textAddFactor.TabIndex = 58;
            this.textAddFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddNomenk_KeyPress);
            // 
            // textAddInvent
            // 
            this.textAddInvent.Location = new System.Drawing.Point(162, 77);
            this.textAddInvent.MaxLength = 6;
            this.textAddInvent.Name = "textAddInvent";
            this.textAddInvent.Size = new System.Drawing.Size(127, 20);
            this.textAddInvent.TabIndex = 57;
            this.textAddInvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddNomenk_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(108, 168);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textAddNomenk
            // 
            this.textAddNomenk.Location = new System.Drawing.Point(162, 51);
            this.textAddNomenk.MaxLength = 11;
            this.textAddNomenk.Name = "textAddNomenk";
            this.textAddNomenk.Size = new System.Drawing.Size(127, 20);
            this.textAddNomenk.TabIndex = 55;
            this.textAddNomenk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddNomenk_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonRewind);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(229, 19);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(233, 20);
            this.textSearch.TabIndex = 57;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(477, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 54;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRewind
            // 
            this.buttonRewind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRewind.BackgroundImage")));
            this.buttonRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRewind.Location = new System.Drawing.Point(571, 17);
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
            this.iDEquipmentDataGridViewTextBoxColumn,
            this.iDDepartmentDataGridViewTextBoxColumn,
            this.nomencnomDataGridViewTextBoxColumn,
            this.inventnomDataGridViewTextBoxColumn,
            this.factorynomDataGridViewTextBoxColumn,
            this.eqnameDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.equipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(162, 23);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(127, 21);
            this.comboBoxDepartment.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Орг. одиниця:";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=idea-pc;Initial Catalog=EquipmentRepair2;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // equipmentDataSet
            // 
            this.equipmentDataSet.DataSetName = "EquipmentDataSet";
            this.equipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.equipmentDataSet;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // iDEquipmentDataGridViewTextBoxColumn
            // 
            this.iDEquipmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.HeaderText = "ID_Equipment";
            this.iDEquipmentDataGridViewTextBoxColumn.Name = "iDEquipmentDataGridViewTextBoxColumn";
            this.iDEquipmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEquipmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDepartmentDataGridViewTextBoxColumn
            // 
            this.iDDepartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.HeaderText = "ID_Department";
            this.iDDepartmentDataGridViewTextBoxColumn.Name = "iDDepartmentDataGridViewTextBoxColumn";
            this.iDDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDepartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomencnomDataGridViewTextBoxColumn
            // 
            this.nomencnomDataGridViewTextBoxColumn.DataPropertyName = "Nomenc_nom";
            this.nomencnomDataGridViewTextBoxColumn.HeaderText = "Номенклатурний №";
            this.nomencnomDataGridViewTextBoxColumn.Name = "nomencnomDataGridViewTextBoxColumn";
            this.nomencnomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventnomDataGridViewTextBoxColumn
            // 
            this.inventnomDataGridViewTextBoxColumn.DataPropertyName = "Invent_nom";
            this.inventnomDataGridViewTextBoxColumn.HeaderText = "Інвентарний №";
            this.inventnomDataGridViewTextBoxColumn.Name = "inventnomDataGridViewTextBoxColumn";
            this.inventnomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorynomDataGridViewTextBoxColumn
            // 
            this.factorynomDataGridViewTextBoxColumn.DataPropertyName = "Factory_nom";
            this.factorynomDataGridViewTextBoxColumn.HeaderText = "Заводський №";
            this.factorynomDataGridViewTextBoxColumn.Name = "factorynomDataGridViewTextBoxColumn";
            this.factorynomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eqnameDataGridViewTextBoxColumn
            // 
            this.eqnameDataGridViewTextBoxColumn.DataPropertyName = "Eq_name";
            this.eqnameDataGridViewTextBoxColumn.HeaderText = "Обладнання";
            this.eqnameDataGridViewTextBoxColumn.Name = "eqnameDataGridViewTextBoxColumn";
            this.eqnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Dep_Nam";
            this.Column1.HeaderText = "Орг. од.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 449);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EquipmentForm";
            this.Text = "Обладнання";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEditEquip;
        private System.Windows.Forms.TextBox textEditFactor;
        private System.Windows.Forms.TextBox textEditInvent;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textEditNomenc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAddEquip;
        private System.Windows.Forms.TextBox textAddFactor;
        private System.Windows.Forms.TextBox textAddInvent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textAddNomenk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label9;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private EquipmentDataSet equipmentDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private EquipmentDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomencnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorynomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}