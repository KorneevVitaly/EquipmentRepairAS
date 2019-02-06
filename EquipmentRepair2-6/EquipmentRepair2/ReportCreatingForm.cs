using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentRepair2
{
    public partial class ReportCreatingForm : Form
    {
        string currentYear, beginYear, endYear;
        public ReportCreatingForm()
        {
            InitializeComponent();
            MyDataTables.datTab = reportDataSet11.Tables["Equipment"];
        }

        private void ReportCreatingForm_Load(object sender, EventArgs e)
        {
            currentYear = DateTime.Now.Year.ToString();
            beginYear = "01.01." + currentYear;
            endYear = "31.12." + currentYear;

            dateTimePicker1.Value = Convert.ToDateTime(beginYear);
            dateTimePicker2.Value = Convert.ToDateTime(endYear);

            sqlDataAdapter1.SelectCommand.Parameters[0].Value = dateTimePicker1.MinDate.ToString("dd.MM.yyyy");
            sqlDataAdapter1.SelectCommand.Parameters[1].Value = dateTimePicker2.MaxDate.ToString("dd.MM.yyyy");
            sqlDataAdapter1.Fill(reportDataSet11.Equipment);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ReportForm repFor = new ReportForm();
            repFor.Show();
        }

        private void buttonQuerry_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("dd.MM.yyyy") == dateTimePicker2.Value.ToString("dd.MM.yyyy") ||
                dateTimePicker1.Value < dateTimePicker2.Value)
            {
                reportDataSet11.Clear();
                sqlDataAdapter1.SelectCommand.Parameters[0].Value = dateTimePicker1.Value.ToString("dd.MM.yyyy");
                sqlDataAdapter1.SelectCommand.Parameters[1].Value = dateTimePicker2.Value.ToString("dd.MM.yyyy");
                sqlDataAdapter1.Fill(reportDataSet11.Equipment);

                GetDataFromGrid();
            }
            else
            {
                MessageBox.Show("\"Дата з\" повинна бути менша \"дати по\"");
            }
        }

        public void GetDataFromGrid()
        {
            int[] gridI = new int[dataGridView1.RowCount];
            string[] gridS = new string[dataGridView1.RowCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                gridS[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                gridI[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }

            chart1.Series[0].Points.DataBindXY(gridS, gridI);
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            reportDataSet11.Clear();
            
            dateTimePicker1.Value = Convert.ToDateTime(beginYear);
            dateTimePicker2.Value = Convert.ToDateTime(endYear);

            sqlDataAdapter1.SelectCommand.Parameters[0].Value = dateTimePicker1.MinDate.ToString("dd.MM.yyyy");
            sqlDataAdapter1.SelectCommand.Parameters[1].Value = dateTimePicker2.MaxDate.ToString("dd.MM.yyyy");
            sqlDataAdapter1.Fill(reportDataSet11.Equipment);

            GetDataFromGrid();
        }
    }

    public static class MyDataTables
    {
        public static DataTable datTab;
    }
}
