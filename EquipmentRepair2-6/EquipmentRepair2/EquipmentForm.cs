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
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.SelectEquipment(this.equipmentDataSet.Equipment);

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDepartment.Items.Count != 0)
            {
                if (textAddNomenk.Text != "" && textAddInvent.Text != "" && textAddFactor.Text != "" && textAddEquip.Text != "")
                {
                    equipmentTableAdapter.AddEquipment(Convert.ToInt32(comboBoxDepartment.SelectedValue) ,textAddNomenk.Text, textAddInvent.Text, textAddFactor.Text, textAddEquip.Text);
                    equipmentTableAdapter.Update(equipmentDataSet.Equipment);
                    equipmentTableAdapter.SelectLastEquipment(equipmentDataSet.Equipment);
                    textAddNomenk.Clear();
                    textAddInvent.Clear();
                    textAddFactor.Clear();
                    textAddEquip.Clear();
                }
                else
                {
                    MessageBox.Show("Усі поля для заповнення не повинні бути пустими!");
                }
            }
            else
            {
                MessageBox.Show("Не має цехів!");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string old = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string old2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string old3 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string old4 = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (dataGridView1.Rows.Count != 0)
            {
                if (textEditNomenc.Text != "" && textEditInvent.Text != "" && textEditFactor.Text != "" && textEditEquip.Text != "" && dataGridView1.Rows.Count != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете виконати редагування?", "Редагування", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int position;
                        position = this.equipmentBindingSource.Position;
                        equipmentTableAdapter.UpdateEquipment(textEditNomenc.Text, textEditInvent.Text, textEditFactor.Text, textEditEquip.Text, (int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);
                        equipmentTableAdapter.Update(equipmentDataSet.Equipment);
                        equipmentTableAdapter.SelectEquipment(equipmentDataSet.Equipment);
                        Refresh();
                        this.equipmentBindingSource.Position = position;
                    }
                    else
                    {
                        textEditNomenc.Text = old;
                        textEditInvent.Text = old2;
                        textEditFactor.Text = old3;
                        textEditEquip.Text = old4;
                    }
                }
                else
                {
                    textEditNomenc.Text = old;
                    textEditInvent.Text = old2;
                    textEditFactor.Text = old3;
                    textEditEquip.Text = old4;
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
                if (MessageBox.Show("Ви впевнені, що хочете пидалити це обладнання?", "Підтвердження",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int position;
                    position = this.equipmentBindingSource.Position;
                    equipmentDataSet.Equipment.Rows[position].Delete();
                    equipmentTableAdapter.Update(equipmentDataSet.Equipment);
                    equipmentDataSet.Equipment.AcceptChanges();

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            equipmentTableAdapter.SearchEquipment(equipmentDataSet.Equipment, textSearch.Text);
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            this.equipmentTableAdapter.SelectEquipment(this.equipmentDataSet.Equipment);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditNomenc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textEditInvent.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textEditFactor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textEditEquip.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textAddNomenk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textAddEquip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
