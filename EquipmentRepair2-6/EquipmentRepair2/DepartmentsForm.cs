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
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "departmentsDataSet.Departments". При необходимости она может быть перемещена или удалена.
            //this.departmentsTableAdapter.Fill(this.departmentsDataSet.Departments);
            this.departmentsTableAdapter.SelectDepartments(this.departmentsDataSet.Departments);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textAdd.Text != "")
            {
                departmentsTableAdapter.AddDepartment(textAdd.Text);
                departmentsTableAdapter.Update(departmentsDataSet.Departments);
                departmentsTableAdapter.SelectByLastDepartment(departmentsDataSet.Departments);
                textAdd.Clear();
            }
            else
            {
                MessageBox.Show("Поле для заповнення не повинно бути пустим!");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string old2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView1.Rows.Count != 0)
            {
                if (textEdit.Text != "" && dataGridView1.Rows.Count != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int position;
                        position = this.departmentsBindingSource.Position;
                        departmentsTableAdapter.UpdateDepartment(textEdit.Text, (int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);
                        departmentsTableAdapter.Update(departmentsDataSet.Departments);
                        departmentsTableAdapter.SelectDepartments(departmentsDataSet.Departments);
                        Refresh();
                        this.departmentsBindingSource.Position = position;
                    }
                    else
                    {
                        textEdit.Text = old2;
                    }
                }
                else
                {
                    textEdit.Text = old2;
                    MessageBox.Show("Усі поля для редагування не повинні бути пустими!");
                }
            }
            else
            {
                MessageBox.Show("Немає елемента для редагування!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити цех :\"" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "\"?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int position;
                    position = this.departmentsBindingSource.Position;

                    ChangeThisDepartmentInDocument(position);

                    departmentsDataSet.Departments.Rows[position].Delete();
                    departmentsTableAdapter.Update(departmentsDataSet.Departments);
                    departmentsDataSet.Departments.AcceptChanges();
                }
            }
            else
            {
                MessageBox.Show("Немає записів для видалення!");
            }
        }

        public void ChangeThisDepartmentInDocument(int key)
        {
            string command4 = "update Order_rem set ID_DepOrd = 1 where ID_DepOrd = @Pa4";
            string command5 = "update Order_rem set ID_DepPerf = 1 where ID_DepPerf = @Pa5";

            sqlConnection1.Open();
            SqlCommand com_Sql4 = new SqlCommand(); SqlCommand com_Sql5 = new SqlCommand();
            com_Sql4.Connection = sqlConnection1; com_Sql5.Connection = sqlConnection1;
            com_Sql4.CommandType = CommandType.Text; com_Sql5.CommandType = CommandType.Text;
            com_Sql4.CommandText = command4; com_Sql5.CommandText = command5;
            com_Sql4.Parameters.AddWithValue("@Pa4", key);
            com_Sql5.Parameters.AddWithValue("@Pa5", key);
            com_Sql4.ExecuteNonQuery(); com_Sql5.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            departmentsTableAdapter.SearchDepartment(departmentsDataSet.Departments, "%" + textSearch.Text + "%");
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            this.departmentsTableAdapter.SelectDepartments(this.departmentsDataSet.Departments);
        }

        private void textAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (e.KeyChar != '\'') && (e.KeyChar != '\"') && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
