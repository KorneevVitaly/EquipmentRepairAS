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
    public partial class ControlForm : Form
    {
        string currentYear, beginYear, endYear;
        public ControlForm()
        {
            InitializeComponent();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            currentYear = DateTime.Now.Year.ToString();
            beginYear = "01.01." + currentYear;
            endYear = "31.12." + currentYear;

            dateTimePicker1.Value = Convert.ToDateTime(beginYear);
            dateTimePicker2.Value = Convert.ToDateTime(endYear);

            act_returnTableAdapter.SearchControlData(controlDataSet.Act_return, beginYear, endYear);
            CountDolg();
        }

        public void CountDolg()
        {
            int allSum = 0;

            if (dataGridView1.RowCount != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    allSum += Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value.ToString());
                }
            }

            label1.Text = "Ще необхідно відремонтувати " + allSum + " обладнаннь";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("dd.MM.yyyy") == dateTimePicker2.Value.ToString("dd.MM.yyyy") ||
                dateTimePicker1.Value < dateTimePicker2.Value)
            {
                act_returnTableAdapter.SearchControlData(controlDataSet.Act_return, dateTimePicker1.Value.ToString("dd.MM.yyyy"), dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                CountDolg();
            }
            else
            {
                MessageBox.Show("\"Дата з\" повинна бути менша \"дати по\"");
            }
        }

        private void ShowReset_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(beginYear);
            dateTimePicker2.Value = Convert.ToDateTime(endYear);

            act_returnTableAdapter.SearchControlData(controlDataSet.Act_return, beginYear, endYear);
            CountDolg();
        }
    }
}
