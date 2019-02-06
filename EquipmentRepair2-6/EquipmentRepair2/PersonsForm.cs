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
    public partial class PersonsForm : Form
    {
        public PersonsForm()
        {
            InitializeComponent();
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personsDataSet.Persons". При необходимости она может быть перемещена или удалена.
            this.personsTableAdapter.SelectPersons(this.personsDataSet.Persons);            

            FillMyDepartments();
        }

        public void FillMyDepartments()
        {
            string command = "SELECT ID_Department, Dep_Nam FROM Departments WHERE ID_Department <> 1";
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(command, sqlConnection1);

            DataSet ds = new DataSet();
            sqlConnection1.Open();
            da.Fill(ds);
            sqlConnection1.Close();

            comboBoxDepartment.DataSource = ds.Tables[0];
            comboBoxDepartment.DisplayMember = "Dep_Nam";
            comboBoxDepartment.ValueMember = "ID_Department";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex("[A-Z]{2}[0-9]{6}");

            if (textNameAdd.Text != "" && textSurAdd.Text != "" && textPadreAdd.Text != "" && textPasportAdd.Text != "")
            {
                if (!pattern.IsMatch(textPasportAdd.Text))
                {
                    MessageBox.Show("Неправильний формат! \nПриклад: AH123456");
                    textPasportAdd.Clear();
                }
                else
                {
                    personsTableAdapter.AddPerson(Convert.ToInt32(comboBoxDepartment.SelectedValue), textSurAdd.Text, textNameAdd.Text, textPadreAdd.Text, textPasportAdd.Text);
                    personsTableAdapter.Update(personsDataSet.Persons);
                    personsTableAdapter.SelectLastPerson(personsDataSet.Persons);
                    textNameAdd.Clear();
                    textSurAdd.Clear();
                    textPadreAdd.Clear();
                    textPasportAdd.Clear();
                }
            }
            else
            {
                MessageBox.Show("Усі поля для заповнення не повинні бути пустими!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Regex pattern = new Regex("[A-Z]{2}[0-9]{6}");
            string old = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string old2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string old3 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string old4 = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (dataGridView1.Rows.Count != 0)
            {
                if (textSurUp.Text != "" && textNamUp.Text != "" && textPadreUp.Text != "" && textPassUp.Text != "" && dataGridView1.Rows.Count != 0)
                {
                    if (!pattern.IsMatch(textPasportAdd.Text))
                    {
                        MessageBox.Show("Неправильний формат! \nПриклад: AH123456");
                        textSurUp.Text = old;
                        textNamUp.Text = old2;
                        textPadreUp.Text = old3;
                        textPassUp.Text = old4;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int position;
                            position = this.personsBindingSource.Position;
                            personsTableAdapter.UpdatePerson(textSurUp.Text, textNamUp.Text, textPadreUp.Text, textPassUp.Text, (int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);
                            personsTableAdapter.Update(personsDataSet.Persons);
                            personsTableAdapter.SelectPersons(personsDataSet.Persons);
                            Refresh();
                            this.personsBindingSource.Position = position;
                        }
                        else
                        {
                            textSurUp.Text = old;
                            textNamUp.Text = old2;
                            textPadreUp.Text = old3;
                            textPassUp.Text = old4;
                        }
                    }
                }
                else
                {
                    textSurUp.Text = old;
                    textNamUp.Text = old2;
                    textPadreUp.Text = old3;
                    textPassUp.Text = old4;
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
                if (MessageBox.Show("Ви впевнені, що хочете пидалити цю персону?", "Підтвердження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChangeThisPersonInDocuments((int)dataGridView1.CurrentRow.Cells[0].Value);

                    personsTableAdapter.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
                    personsTableAdapter.Update(personsDataSet.Persons);
                    personsTableAdapter.SelectPersons(personsDataSet.Persons);

                }
            }
            else
            {
                MessageBox.Show("Немає записів для видалення!");
            }
        }

        public void ChangeThisPersonInDocuments(int key)
        {
            string command2 = "update Act_return set ID_PersonGive = 1 where ID_PersonGive = @Pa2";
            string command3 = "update Act_return set ID_PersonRet = 1 where ID_PersonRet = @Pa3";
            string command6 = "update Order_rem set ID_PersonGiv = 1 where ID_PersonGiv = @Pa6";
            string command7 = "update Order_rem set ID_PersonRet = 1 where ID_PersonRet = @Pa7";

            sqlConnection1.Open();
            SqlCommand com_Sql2 = new SqlCommand();  SqlCommand com_Sql3 = new SqlCommand(); 
            SqlCommand com_Sql6 = new SqlCommand();  SqlCommand com_Sql7 = new SqlCommand();

            com_Sql2.Connection = sqlConnection1; com_Sql3.Connection = sqlConnection1; 
            com_Sql6.Connection = sqlConnection1; com_Sql7.Connection = sqlConnection1;

            com_Sql2.CommandType = CommandType.Text; com_Sql3.CommandType = CommandType.Text; 
            com_Sql6.CommandType = CommandType.Text; com_Sql7.CommandType = CommandType.Text;

            com_Sql2.CommandText = command2;  com_Sql3.CommandText = command3; 
            com_Sql6.CommandText = command6;  com_Sql7.CommandText = command7;

            com_Sql2.Parameters.AddWithValue("@Pa2", key);
            com_Sql3.Parameters.AddWithValue("@Pa3", key);
            com_Sql6.Parameters.AddWithValue("@Pa6", key);
            com_Sql7.Parameters.AddWithValue("@Pa7", key);

            com_Sql2.ExecuteNonQuery(); com_Sql3.ExecuteNonQuery();
            com_Sql6.ExecuteNonQuery(); com_Sql7.ExecuteNonQuery();

            sqlConnection1.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            personsTableAdapter.SearchPersons(personsDataSet.Persons, "%" + textSearchSur.Text + "%", "%" + textSearchName.Text + "%", "%" + textSearchPadre.Text + "%");
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            this.personsTableAdapter.SelectPersons(this.personsDataSet.Persons);  
        }

        private void textSurAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (e.KeyChar != '\''))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textSurUp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textNamUp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textPadreUp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textPassUp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
