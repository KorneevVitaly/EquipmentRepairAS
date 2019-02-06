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
    public partial class OrderForm : Form
    {
        string DepOrd, DepPerf, PersOrd, PersPerf;

        public OrderForm()
        {
            InitializeComponent();
            DepOrd = ""; DepPerf = "";
            PersOrd = ""; PersPerf = "";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.order_remTableAdapter.SelectOrders(this.ordersDataSet.Order_rem);
            this.equipment_in_OrderTableAdapter.SelectEquipmentInOrder(this.ordersDataSet.Equipment_in_Order);

            ShowPerformerAndOrderer();
        }

        public void ShowPerformerAndOrderer()
        {
            DepOrd = ""; DepPerf = "";
            PersOrd = ""; PersPerf = "";

            if (dataGridOrder.Rows.Count != 0)
            {
                sqlConnection1.Open();
                SqlCommand comPersOrd = new SqlCommand();
                SqlCommand comPersPerf = new SqlCommand();
                SqlCommand comDepOrd = new SqlCommand();
                SqlCommand comDepPerf = new SqlCommand();
                string PeOrd = "select Surname+' '+Name+' '+Patronimyc as FIO from Persons where ID_Person = " + dataGridOrder.CurrentRow.Cells[3].Value.ToString();
                string PePer = "select Surname+' '+Name+' '+Patronimyc as FIO from Persons where ID_Person = " + dataGridOrder.CurrentRow.Cells[4].Value.ToString();
                string DeOrd = "select Dep_Nam from Departments where ID_Department = " + dataGridOrder.CurrentRow.Cells[1].Value.ToString();
                string DePer = "select Dep_Nam from Departments where ID_Department = " + dataGridOrder.CurrentRow.Cells[2].Value.ToString();

                comPersOrd.Connection = sqlConnection1; comPersPerf.Connection = sqlConnection1;
                comDepOrd.Connection = sqlConnection1; comDepPerf.Connection = sqlConnection1;

                comPersOrd.CommandType = CommandType.Text; comPersPerf.CommandType = CommandType.Text;
                comDepOrd.CommandType = CommandType.Text; comDepPerf.CommandType = CommandType.Text;

                comPersOrd.CommandText = PeOrd; comPersPerf.CommandText = PePer;
                comDepOrd.CommandText = DeOrd; comDepPerf.CommandText = DePer;

                DepOrd = (string)comDepOrd.ExecuteScalar();
                DepPerf = (string)comDepPerf.ExecuteScalar();
                PersOrd = (string)comPersOrd.ExecuteScalar();
                PersPerf = (string)comPersPerf.ExecuteScalar();

                sqlConnection1.Close();
            }

            textOrdererDepartment.Text = DepOrd;
            textOredererPerson.Text = PersOrd;
            textPerformerDepartment.Text = DepPerf;
            textPerformerPerson.Text = PersPerf;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxNom.Checked && checkBoxDate.Checked == false)
            {
                if (textSearchNom.Text != "")
                {
                    order_remTableAdapter.SearchByNom(ordersDataSet.Order_rem, Convert.ToInt32(textSearchNom.Text));
                    equipment_in_OrderTableAdapter.SelectEquipmentInOrder(this.ordersDataSet.Equipment_in_Order);
                }
                else
                {
                    MessageBox.Show("Заповніть поле!");
                }
            }
            if (checkBoxNom.Checked == false && checkBoxDate.Checked)
            {
                order_remTableAdapter.SearchByDate(ordersDataSet.Order_rem, dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                equipment_in_OrderTableAdapter.SelectEquipmentInOrder(this.ordersDataSet.Equipment_in_Order);
            }
            if (checkBoxNom.Checked && checkBoxDate.Checked)
            {
                if (textSearchNom.Text != "")
                {
                    order_remTableAdapter.SearchByNomDate(ordersDataSet.Order_rem, dateTimePicker1.Value.ToString("dd.MM.yyyy"), Convert.ToInt32(textSearchNom.Text));
                    equipment_in_OrderTableAdapter.SelectEquipmentInOrder(this.ordersDataSet.Equipment_in_Order);
                }
                else
                {
                    MessageBox.Show("Заповніть поле!");
                }
            }
            if (checkBoxNom.Checked == false && checkBoxDate.Checked == false)
            {
                MessageBox.Show("Оберіть параметри для пошуку!");
            }
        }

        private void ShowReset_Click(object sender, EventArgs e)
        {
            this.order_remTableAdapter.SelectOrders(this.ordersDataSet.Order_rem);
            this.equipment_in_OrderTableAdapter.SelectEquipmentInOrder(this.ordersDataSet.Equipment_in_Order);

            ShowPerformerAndOrderer();
        }

        private void buttonEditAct_Click(object sender, EventArgs e)
        {
            string old = dataGridOrder.CurrentRow.Cells[5].Value.ToString();
            DateTime OLD = Convert.ToDateTime(dataGridOrder.CurrentRow.Cells[6].Value);

            if (dataGridOrder.Rows.Count != 0)
            {
                if (textEditNom.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlConnection1.Open();
                        SqlCommand com_Sql = new SqlCommand();
                        string sql = "SELECT COUNT(*) FROM Order_rem WHERE (Nom = @No) AND (YEAR(Date_) = YEAR(@DA))";
                        com_Sql.Connection = sqlConnection1;
                        com_Sql.CommandType = CommandType.Text;
                        com_Sql.CommandText = sql;
                        com_Sql.Parameters.AddWithValue("@No", textEditNom.Text);
                        com_Sql.Parameters.AddWithValue("@DA", dateTimePicker1.Value.ToString());
                        int res = ((int)com_Sql.ExecuteScalar());
                        sqlConnection1.Close();

                        if (res == 0)
                        {
                            int position;
                            position = this.orderremBindingSource.Position;
                            order_remTableAdapter.UpdateOrder(Convert.ToInt32(textEditNom.Text), dateTimePickerEdit.Value.ToString("dd.MM.yyyy"), (int)dataGridOrder.CurrentRow.Cells[0].Value, (int)dataGridOrder.CurrentRow.Cells[0].Value);
                            order_remTableAdapter.Update(ordersDataSet.Order_rem);
                            order_remTableAdapter.SelectOrders(ordersDataSet.Order_rem);
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Такий номер замовлення в цьому році вже є!");
                            textEditNom.Text = old;
                            dateTimePickerEdit.Value = OLD;
                        }
                    }
                    else
                    {
                        textEditNom.Text = old;
                        dateTimePickerEdit.Value = OLD;
                    }
                }
                else
                {
                    textEditNom.Text = old;
                    dateTimePickerEdit.Value = OLD;
                    MessageBox.Show("Поле для редагування не повинно бути пустим!");
                }
            }
            else
            {
                MessageBox.Show("Немає елемента для редагування!");
            }
        }

        private void buttonEditAmauntInAct_Click(object sender, EventArgs e)
        {
            Decimal Old = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int position;
                    position = this.equipmentInOrderOrderBindingSource.Position;
                    equipment_in_OrderTableAdapter.UpdateEquipmentInOrder((int)numericUpDownEdit.Value, (int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);
                    equipment_in_OrderTableAdapter.Update(ordersDataSet.Equipment_in_Order);
                    equipment_in_OrderTableAdapter.SelectEquipmentInOrder(ordersDataSet.Equipment_in_Order);
                    Refresh();
                    this.equipmentInOrderOrderBindingSource.Position = position;
                }
                else
                {
                    numericUpDownEdit.Value = Old;
                }
            }
            else
            {
                MessageBox.Show("Немає елемента для редагування!");
            }
        }

        private void buttonDeleteAct_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити акт?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int position;
                    position = this.orderremBindingSource.Position;
                    ordersDataSet.Order_rem.Rows[position].Delete();
                    order_remTableAdapter.Update(ordersDataSet.Order_rem);
                    ordersDataSet.Order_rem.AcceptChanges();
                }
            }
            else
            {
                MessageBox.Show("Нема що видалити!");
            }
        }

        private void buttonDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити цей елемент ?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    equipment_in_OrderTableAdapter.DeleteEqvInOrder(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    equipment_in_OrderTableAdapter.Update(ordersDataSet.Equipment_in_Order);
                    equipment_in_OrderTableAdapter.SelectEquipmentInOrder(ordersDataSet.Equipment_in_Order);
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Нема що видалити!");
            }
        }

        private void dataGridOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowPerformerAndOrderer();

            textEditNom.Text = dataGridOrder.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerEdit.Value = Convert.ToDateTime(dataGridOrder.CurrentRow.Cells[6].Value);

            if (dataGridView1.Rows.Count != 0)
            {
                numericUpDownEdit.Enabled = true;
                buttonEditAmauntInAct.Enabled = true;
                numericUpDownEdit.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }
            else
            {
                numericUpDownEdit.Enabled = false;
                buttonEditAmauntInAct.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDownEdit.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }

        private void textSearchNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void checkBoxNom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNom.Checked)
            {
                textSearchNom.Enabled = true;
            }
            else
            {
                textSearchNom.Enabled = false;
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }


    }
}
