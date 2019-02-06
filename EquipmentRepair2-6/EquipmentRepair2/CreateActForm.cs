using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentRepair2
{
    public partial class CreateActForm : Form
    {
        public int kol;
        public CreateActForm()
        {
            InitializeComponent();
            kol = 0;
        }

        private void CreateActForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordererDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter1.SelectOrdererEquipment(this.ordererDataSet.Equipment);


            // TODO: данная строка кода позволяет загрузить данные в таблицу "actDataSet.Act_return". При необходимости она может быть перемещена или удалена.
            this.act_returnTableAdapter.Fill(this.actDataSet.Act_return);
            //this.equipmentTableAdapter.SelectEquipment(this.actDataSet.Equipment);
            this.order_remTableAdapter.SelectOrders(this.actDataSet.Order_rem);
            this.departmentsTableAdapter1.SelectPerformerDepartment(this.performerDataSet.Departments);
            this.personsTableAdapter1.SelectPerformerPerson(this.performerDataSet.Persons);
            this.departmentsTableAdapter.SelectOrdererDepartment(this.ordererDataSet.Departments);
            this.personsTableAdapter.SelectOrdererPerson(this.ordererDataSet.Persons);

            FillMyWorks();

            if (dataGridEquip.Rows.Count != 0)
            {
                textBox3.Text = dataGridEquip.CurrentRow.Cells[5].Value.ToString();
                textBox4.Text = dataGridEquip.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridEquip.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridEquip.CurrentRow.Cells[2].Value.ToString();
            }
        }

        public void FillMyWorks()
        {
            string command = "SELECT ID_work_type, wrk_tp FROM Work_Types WHERE ID_work_type <> 1";
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(command, sqlConnection1);

            DataSet ds = new DataSet();
            sqlConnection1.Open();
            da.Fill(ds);
            sqlConnection1.Close();

            comboBoxWork.DataSource = ds.Tables[0];
            comboBoxWork.DisplayMember = "wrk_tp";
            comboBoxWork.ValueMember = "ID_work_type";
        }

        private void buttonCreateAct_Click(object sender, EventArgs e)
        {
            kol = 0;

            if (dataGridEquip.Rows.Count == 0 || dataGridPerformerDepartment.Rows.Count == 0 || comboBoxWork.Items.Count == 0 ||
                dataGridPerformerPerson.Rows.Count == 0 || dataGridOrder.Rows.Count == 0 || dataGridOrderDepartment.Rows.Count == 0 ||
                dataGridOrderPerson.Rows.Count == 0)
            {
                MessageBox.Show("Недостатньо данних для заповнення!");
            }
            else
            {
                if (textNom.Text != "")
                {
                    if (dateTimePicker2.Value.ToString("dd.MM.yyyy") == dateTimePicker3.Value.ToString("dd.MM.yyyy") ||
                dateTimePicker2.Value < dateTimePicker3.Value)
                    {
                        sqlConnection1.Open();
                        SqlCommand com_Sql = new SqlCommand();
                        string sql = "SELECT COUNT(*) FROM Act_return WHERE (Nomer = @No) AND (YEAR(Date_) = YEAR(@DA))";
                        com_Sql.Connection = sqlConnection1;
                        com_Sql.CommandType = CommandType.Text;
                        com_Sql.CommandText = sql;
                        com_Sql.Parameters.AddWithValue("@No", textNom.Text);
                        com_Sql.Parameters.AddWithValue("@DA", dateTimePicker1.Value.ToString());
                        int res = ((int)com_Sql.ExecuteScalar());
                        sqlConnection1.Close();

                        if (res == 0)
                        {
                            act_returnTableAdapter.AddAct((int)dataGridOrder.CurrentRow.Cells[0].Value, (int)dataGridPerformerPerson.CurrentRow.Cells[0].Value, (int)dataGridOrderPerson.CurrentRow.Cells[0].Value,
                                Convert.ToInt32(textNom.Text), dateTimePicker1.Value.ToString("dd.MM.yyyy"), dateTimePicker2.Value.ToString("dd.MM.yyyy"), dateTimePicker3.Value.ToString("dd.MM.yyyy"));
                            act_returnTableAdapter.Update(actDataSet.Act_return);
                            act_returnTableAdapter.Fill(actDataSet.Act_return);

                            MessageBox.Show("Акт створено!");

                            equipment_in_ActTableAdapter.SelectEquipmentInCurrentAct(actDataSet.Equipment_in_Act, (int)act_returnTableAdapter.MaxAct());
                        }
                        else
                        {
                            MessageBox.Show("Такий номер акту в цьому році вже є!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("\"Дата з\" повинна бути менша \"дати по\"");
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть номер акту!");
                }
            }
        }

        private void buttonAddEquipment_Click(object sender, EventArgs e)
        {
            int KO = 1;
            KO = (int)act_returnTableAdapter.CountAct();

            if (KO == 0)
            {
                MessageBox.Show("Немає замовлень!");
            }
            else
            {
                if (MessageBox.Show("Додати прилад до акту?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kol++;
                    equipment_in_ActTableAdapter.AddEquipmentInAct((int)act_returnTableAdapter.MaxAct(), (int)dataGridEquip.CurrentRow.Cells[0].Value,
                        Convert.ToInt32(comboBoxWork.SelectedValue), (int)numericUpDown1.Value);
                    equipment_in_ActTableAdapter.Update(actDataSet.Equipment_in_Act);
                    equipment_in_ActTableAdapter.SelectEquipmentInCurrentAct(actDataSet.Equipment_in_Act,
                        (int)act_returnTableAdapter.MaxAct());
                }
            }
        }

        private void dataGridEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridEquip.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridEquip.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridEquip.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridEquip.CurrentRow.Cells[2].Value.ToString();
        }

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dataGridPerformerDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEquip.Rows.Count != 0)
            {
                textBox3.Text = dataGridEquip.CurrentRow.Cells[5].Value.ToString();
                textBox4.Text = dataGridEquip.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridEquip.CurrentRow.Cells[4].Value.ToString();
                textBox6.Text = dataGridEquip.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }
    }
}
