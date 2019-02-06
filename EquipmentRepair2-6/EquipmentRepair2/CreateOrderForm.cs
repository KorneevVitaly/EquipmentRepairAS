using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace EquipmentRepair2
{
    public partial class CreateOrderForm : Form
    {
        public int kol;
        public CreateOrderForm()
        {
            InitializeComponent();
            kol = 0;
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.SelectOrdererDepartment(this.ordererDataSet.Departments);
            personsTableAdapter.SelectOrdererPerson(ordererDataSet.Persons);
            equipmentTableAdapter.SelectOrdererEquipment(ordererDataSet.Equipment);
            
            //this.order_remTableAdapter.Fill(this.ordersDataSet.Order_rem);
            this.departmentsTableAdapter1.SelectPerformerDepartment(this.performerDataSet.Departments);
            this.personsTableAdapter1.SelectPerformerPerson(this.performerDataSet.Persons);

            fillEquipmentTextboxes();
        }        

        private void dataGridEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEquipmentTextboxes();
        }

        public void fillEquipmentTextboxes()
        {
            if (dataGridEquipment.Rows.Count != 0)
            {
                textBox3.Text = dataGridEquipment.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridEquipment.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridEquipment.CurrentRow.Cells[5].Value.ToString();
                textBox6.Text = dataGridEquipment.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
            }
        }

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            kol = 0;


            if(dataGridPerformerDepartment.Rows.Count != 0 && dataGridPerformerPerson.Rows.Count != 0 &&
                dataGridOrderDepartment.Rows.Count != 0 && dataGridOrderPerson.Rows.Count != 0)
            {
                if (textNom.Text != "")
                {
                    sqlConnection1.Open();
                    SqlCommand com_Sql = new SqlCommand();
                    string sql = "SELECT COUNT(*) FROM Order_rem WHERE (Nom = @No) AND (YEAR(Date_) = YEAR(@DA))";
                    com_Sql.Connection = sqlConnection1;
                    com_Sql.CommandType = CommandType.Text;
                    com_Sql.CommandText = sql;
                    com_Sql.Parameters.AddWithValue("@No", textNom.Text);
                    com_Sql.Parameters.AddWithValue("@DA", dateTimePicker1.Value.ToString());
                    int res = ((int)com_Sql.ExecuteScalar());
                    sqlConnection1.Close();

                    if (res == 0)
                    {
                        order_remTableAdapter.AddOrder((int)dataGridOrderDepartment.CurrentRow.Cells[0].Value, (int)dataGridPerformerDepartment.CurrentRow.Cells[0].Value,
                                                        (int)dataGridOrderPerson.CurrentRow.Cells[0].Value, (int)dataGridPerformerPerson.CurrentRow.Cells[0].Value,
                                                        Convert.ToInt32(textNom.Text), dateTimePicker1.Value.ToString("dd.MM.yyyy"), Convert.ToInt32(numericUpDown1.Value));
                        order_remTableAdapter.Update(ordersDataSet.Order_rem);
                        order_remTableAdapter.Fill(ordersDataSet.Order_rem);

                        MessageBox.Show("Замовлення створено!");

                        equipment_in_OrderTableAdapter.SelectEquipmentInCurrentOrder(ordersDataSet.Equipment_in_Order,
                        (int)order_remTableAdapter.MaxOrder());
                    }
                    else
                    {
                        MessageBox.Show("Такий номер замовлення в цьому році вже є!");
                    }
                }
                else
                {
                    MessageBox.Show("Заповніть номер замовлення!");
                }
            }
            else
            {
                MessageBox.Show("Недостатньо данних для заповнення!");
            }
        }

        private void buttonAddEquipment_Click(object sender, EventArgs e)
        {
            int KO = 1;
            KO = (int)order_remTableAdapter.CountOrders();

            if (KO == 0)
            {
                MessageBox.Show("Немає замовлень!");
            }
            else
            {
                if (MessageBox.Show("Додати прилад до замовлення?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    kol++;
                    equipment_in_OrderTableAdapter.AddEquipmentInOrder((int)order_remTableAdapter.MaxOrder(),
                        (int)dataGridEquipment.CurrentRow.Cells[0].Value, (int)numericUpDown2.Value);
                    equipment_in_OrderTableAdapter.Update(ordersDataSet.Equipment_in_Order);
                    equipment_in_OrderTableAdapter.SelectEquipmentInCurrentOrder(ordersDataSet.Equipment_in_Order,
                        (int)order_remTableAdapter.MaxOrder());
                }
            }
        }

        private void dataGridOrderDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEquipmentTextboxes();
        }
    }
}
