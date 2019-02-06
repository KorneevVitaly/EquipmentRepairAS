namespace EquipmentRepair2
{
    partial class ReportCreatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCreatingForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportDataSet11 = new EquipmentRepair2.ReportDataSet1();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonQuerry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eqnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eqnameDataGridViewTextBoxColumn,
            this.dONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Equipment";
            this.dataGridView1.DataSource = this.reportDataSet11;
            this.dataGridView1.Location = new System.Drawing.Point(21, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 223);
            this.dataGridView1.TabIndex = 61;
            // 
            // reportDataSet11
            // 
            this.reportDataSet11.DataSetName = "ReportDataSet1";
            this.reportDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonRewind
            // 
            this.buttonRewind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRewind.BackgroundImage")));
            this.buttonRewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRewind.Location = new System.Drawing.Point(508, 15);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(23, 23);
            this.buttonRewind.TabIndex = 60;
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(545, 15);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 23);
            this.buttonReport.TabIndex = 59;
            this.buttonReport.Text = "Видати звіт";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonQuerry
            // 
            this.buttonQuerry.Location = new System.Drawing.Point(450, 15);
            this.buttonQuerry.Name = "buttonQuerry";
            this.buttonQuerry.Size = new System.Drawing.Size(52, 23);
            this.buttonQuerry.TabIndex = 58;
            this.buttonQuerry.Text = "Запит";
            this.buttonQuerry.UseVisualStyleBackColor = true;
            this.buttonQuerry.Click += new System.EventHandler(this.buttonQuerry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Дата по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Дата з:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(310, 18);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FROM", System.Data.SqlDbType.Date, 3, "Date_"),
            new System.Data.SqlClient.SqlParameter("@TO", System.Data.SqlDbType.Date, 3, "Date_")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=idea-pc;Initial Catalog=EquipmentRepair2;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Equipment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Eq_name", "Eq_name"),
                        new System.Data.Common.DataColumnMapping("DONE", "DONE")})});
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.reportDataSet11;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(373, 60);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Eq_name";
            series1.YValueMembers = "DONE";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(366, 223);
            this.chart1.TabIndex = 62;
            this.chart1.Text = "chart1";
            // 
            // eqnameDataGridViewTextBoxColumn
            // 
            this.eqnameDataGridViewTextBoxColumn.DataPropertyName = "Eq_name";
            this.eqnameDataGridViewTextBoxColumn.HeaderText = "Обладнання";
            this.eqnameDataGridViewTextBoxColumn.Name = "eqnameDataGridViewTextBoxColumn";
            this.eqnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONEDataGridViewTextBoxColumn
            // 
            this.dONEDataGridViewTextBoxColumn.DataPropertyName = "DONE";
            this.dONEDataGridViewTextBoxColumn.FillWeight = 65F;
            this.dONEDataGridViewTextBoxColumn.HeaderText = "Відремонтовано, к-сть";
            this.dONEDataGridViewTextBoxColumn.Name = "dONEDataGridViewTextBoxColumn";
            this.dONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportCreatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 303);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRewind);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonQuerry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ReportCreatingForm";
            this.Text = "Створення звіту по відремонтованому обладнанню";
            this.Load += new System.EventHandler(this.ReportCreatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonQuerry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private ReportDataSet1 reportDataSet11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONEDataGridViewTextBoxColumn;
    }
}