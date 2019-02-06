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
    public partial class ActForm : Form
    {
        string PersOrd, PersPerf;
        public ActForm()
        {
            InitializeComponent();
            PersOrd = ""; PersPerf = "";
        }

        private void ActForm_Load(object sender, EventArgs e)
        {
            this.act_returnTableAdapter.SelectAct(this.actDataSet.Act_return);
            this.equipment_in_ActTableAdapter.SelectEquipmentInAct(this.actDataSet.Equipment_in_Act);

            ShowPerformerAndOrderer();
        }

        public void ShowPerformerAndOrderer()
        {
            PersOrd = ""; PersPerf = "";

            if (dataGridAct.Rows.Count != 0)
            {
                sqlConnection1.Open();
                SqlCommand comPersOrd = new SqlCommand();
                SqlCommand comPersPerf = new SqlCommand();
                string PeOrd = "select Surname+' '+Name+' '+Patronimyc as FIO from Persons where ID_Person = " + dataGridAct.CurrentRow.Cells[5].Value.ToString();
                string PePer = "select Surname+' '+Name+' '+Patronimyc as FIO from Persons where ID_Person = " + dataGridAct.CurrentRow.Cells[6].Value.ToString();

                comPersOrd.Connection = sqlConnection1; comPersPerf.Connection = sqlConnection1;

                comPersOrd.CommandType = CommandType.Text; comPersPerf.CommandType = CommandType.Text;

                comPersOrd.CommandText = PeOrd; comPersPerf.CommandText = PePer;

                PersOrd = (string)comPersOrd.ExecuteScalar();
                PersPerf = (string)comPersPerf.ExecuteScalar();

                sqlConnection1.Close();
            }

            textOredererPerson.Text = PersOrd;
            textPerformerPerson.Text = PersPerf;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxNom.Checked && checkBoxDate.Checked == false)
            {
                if (textSearchNom.Text != "")
                {
                    act_returnTableAdapter.SearchActByNom(actDataSet.Act_return, Convert.ToInt32(textSearchNom.Text));
                    equipment_in_ActTableAdapter.SelectEquipmentInAct(actDataSet.Equipment_in_Act);
                }
                else
                {
                    MessageBox.Show("Заповніть поле!");
                }
            }
            if (checkBoxNom.Checked == false && checkBoxDate.Checked)
            {
                act_returnTableAdapter.SearchActByDate(actDataSet.Act_return, dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                equipment_in_ActTableAdapter.SelectEquipmentInAct(actDataSet.Equipment_in_Act);
            }
            if (checkBoxNom.Checked && checkBoxDate.Checked)
            {
                if (textSearchNom.Text != "")
                {
                    act_returnTableAdapter.SearchActByNomDate(actDataSet.Act_return, Convert.ToInt32(textSearchNom.Text), dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                    equipment_in_ActTableAdapter.SelectEquipmentInAct(actDataSet.Equipment_in_Act);
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
            this.act_returnTableAdapter.SelectAct(this.actDataSet.Act_return);
            this.equipment_in_ActTableAdapter.SelectEquipmentInAct(this.actDataSet.Equipment_in_Act);

            ShowPerformerAndOrderer();
        }

        private void buttonEditAct_Click(object sender, EventArgs e)
        {
            string old = dataGridAct.CurrentRow.Cells[1].Value.ToString();
            DateTime OLD = Convert.ToDateTime(dataGridAct.CurrentRow.Cells[2].Value);

            if (dataGridAct.Rows.Count != 0)
            {
                if (textEditNom.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlConnection1.Open();
                        SqlCommand com_Sql = new SqlCommand();
                        string sql = "SELECT COUNT(*) FROM Act_return WHERE (Nomer = @No) AND (YEAR(Date_) = YEAR(@DA))";
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
                            position = this.actreturnBindingSource.Position;
                            act_returnTableAdapter.UpdateAct(Convert.ToInt32(textEditNom.Text), dateTimePickerEdit.Value.ToString("dd.MM.yyyy"), (int)dataGridAct.CurrentRow.Cells[0].Value, (int)dataGridAct.CurrentRow.Cells[0].Value);
                            act_returnTableAdapter.Update(actDataSet.Act_return);
                            act_returnTableAdapter.SelectAct(actDataSet.Act_return);
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Такий номер чеку в цьому році вже є!");
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
            Decimal Old = Convert.ToDecimal(dataGridEqInAct.CurrentRow.Cells[4].Value.ToString());

            if (dataGridEqInAct.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int position;
                    position = this.equipmentInActActBindingSource.Position;
                    equipment_in_ActTableAdapter.UpdateEquipmentInAct((int)numericUpDownEdit.Value, (int)dataGridEqInAct.CurrentRow.Cells[0].Value, (int)dataGridEqInAct.CurrentRow.Cells[0].Value);
                    equipment_in_ActTableAdapter.Update(actDataSet.Equipment_in_Act);
                    equipment_in_ActTableAdapter.SelectEquipmentInAct(actDataSet.Equipment_in_Act);
                    Refresh();
                    this.equipmentInActActBindingSource.Position = position;
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
            if (dataGridAct.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити акт?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int position;
                    position = this.actreturnBindingSource.Position;
                    actDataSet.Act_return.Rows[position].Delete();
                    act_returnTableAdapter.Update(actDataSet.Act_return);
                    actDataSet.Act_return.AcceptChanges();
                }
            }
            else
            {
                MessageBox.Show("Нема що видалити!");
            }
        }

        private void buttonDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (dataGridEqInAct.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити цей елемент?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    equipment_in_ActTableAdapter.DeleteEquipmentInAct(Convert.ToInt32(dataGridEqInAct.CurrentRow.Cells[0].Value.ToString()));
                    equipment_in_ActTableAdapter.Update(actDataSet.Equipment_in_Act);
                    equipment_in_ActTableAdapter.SelectEquipmentInAct(actDataSet.Equipment_in_Act);
                    Refresh();
                }
            }
            else
            {
                MessageBox.Show("Нема що видалити!");
            }
        }

        private void dataGridAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowPerformerAndOrderer();

            textEditNom.Text = dataGridAct.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerEdit.Value = Convert.ToDateTime(dataGridAct.CurrentRow.Cells[2].Value);

            if (dataGridEqInAct.Rows.Count != 0)
            {
                numericUpDownEdit.Enabled = true;
                buttonEditAmauntInAct.Enabled = true;
                numericUpDownEdit.Value = Convert.ToDecimal(dataGridEqInAct.CurrentRow.Cells[6].Value.ToString());
            }
            else
            {
                numericUpDownEdit.Enabled = false;
                buttonEditAmauntInAct.Enabled = false;
            }
        }

        private void dataGridEqInAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDownEdit.Value = Convert.ToDecimal(dataGridEqInAct.CurrentRow.Cells[6].Value.ToString());
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

        private void textEditNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textSearchNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
