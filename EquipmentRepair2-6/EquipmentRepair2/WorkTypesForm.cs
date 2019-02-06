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
    public partial class WorkTypesForm : Form
    {
        public WorkTypesForm()
        {
            InitializeComponent();
        }

        private void WorkTypesForm_Load(object sender, EventArgs e)
        {
            this.work_TypesTableAdapter.SelectWork(this.workDataSet.Work_Types);

            if (dataGridView1.Rows.Count != 0)
            {
                textEdit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textAdd.Text != "")
            {
                work_TypesTableAdapter.AddWork(textAdd.Text);
                work_TypesTableAdapter.Update(workDataSet.Work_Types);
                work_TypesTableAdapter.SelectLastWork(workDataSet.Work_Types);
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
                        position = this.workTypesBindingSource.Position;
                        work_TypesTableAdapter.UpdateWork(textEdit.Text, (int)dataGridView1.CurrentRow.Cells[0].Value, (int)dataGridView1.CurrentRow.Cells[0].Value);
                        work_TypesTableAdapter.Update(workDataSet.Work_Types);
                        work_TypesTableAdapter.SelectWork(workDataSet.Work_Types);
                        Refresh();
                        this.workTypesBindingSource.Position = position;
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
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видалити вид роботи :\"" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "\"?", "Підтвердження", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int position;
                    position = this.workTypesBindingSource.Position;
                    workDataSet.Work_Types.Rows[position].Delete();
                    work_TypesTableAdapter.Update(workDataSet.Work_Types);
                    workDataSet.Work_Types.AcceptChanges();
                }
            }
            else
            {
                MessageBox.Show("Немає записів для видалення!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            work_TypesTableAdapter.SearchWork(workDataSet.Work_Types, textSearch.Text);
        }

        private void buttonRewind_Click(object sender, EventArgs e)
        {
            this.work_TypesTableAdapter.SelectWork(this.workDataSet.Work_Types);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEdit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void textAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (e.KeyChar != '\'') && (e.KeyChar != '\"') && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
