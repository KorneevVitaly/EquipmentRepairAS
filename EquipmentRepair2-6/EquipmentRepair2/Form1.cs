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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void DepartmentMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsForm DepForm = new DepartmentsForm();
            DepForm.Show();
        }

        private void PersonsMenuItem_Click(object sender, EventArgs e)
        {
            PersonsForm RerForm = new PersonsForm();
            RerForm.Show();
        }

        private void EquipmentMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentForm EqForm = new EquipmentForm();
            EqForm.Show();
        }

        private void WorkTypesMenuItem_Click(object sender, EventArgs e)
        {
            WorkTypesForm WorkForm = new WorkTypesForm();
            WorkForm.Show();
        }

        private void CreateOrderMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrderForm CrOrdForm = new CreateOrderForm();
            CrOrdForm.Show();
        }

        private void OrderMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm OrdForm = new OrderForm();
            OrdForm.Show();
        }

        private void CreateActMenuItem_Click(object sender, EventArgs e)
        {
            CreateActForm CreActForm = new CreateActForm();
            CreActForm.Show();
        }

        private void ActMenuItem_Click(object sender, EventArgs e)
        {
            ActForm ActFrm = new ActForm();
            ActFrm.Show();
        }

        private void ControlMenuItem_Click(object sender, EventArgs e)
        {
            ControlForm CtrlForm = new ControlForm();
            CtrlForm.Show();
        }

        private void CreateRepornMenuItem_Click(object sender, EventArgs e)
        {
            ReportCreatingForm RepCrForm = new ReportCreatingForm();
            RepCrForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=" + sqlConnection1.DataSource.ToString() + "; User ID=" + textBox1.Text + "; Password=" + textBox2.Text + ";Initial Catalog=EquipmentRepair2";

                SqlConnectionStringBuilder builder =
                    new SqlConnectionStringBuilder(connectionString);

                builder.IntegratedSecurity = false;


                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    pictureBox1.Visible = true;
                    panel1.Visible = false;
                    menuStrip1.Enabled = true;
                    UserManager.MyLogin = textBox1.Text;

                    if (UserManager.MyLogin == "GodAdmin")
                    {
                        довідникиToolStripMenuItem.Enabled = true;
                        вхіднаІнформаціяToolStripMenuItem.Enabled = true;
                        вихіднаІнформаціяToolStripMenuItem.Enabled = true;
                    }
                    if (UserManager.MyLogin == "CatalogMaster")
                    {
                        довідникиToolStripMenuItem.Enabled = true;
                        вхіднаІнформаціяToolStripMenuItem.Enabled = false;
                        вихіднаІнформаціяToolStripMenuItem.Enabled = false;
                    }
                    if (UserManager.MyLogin == "DocumMaster")
                    {
                        довідникиToolStripMenuItem.Enabled = false;
                        вхіднаІнформаціяToolStripMenuItem.Enabled = true;
                        вихіднаІнформаціяToolStripMenuItem.Enabled = false;
                    }
                    if (UserManager.MyLogin == "PoorReader")
                    {
                        довідникиToolStripMenuItem.Enabled = false;
                        вхіднаІнформаціяToolStripMenuItem.Enabled = false;
                        вихіднаІнформаціяToolStripMenuItem.Enabled = true;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panel1.Visible = true;
            menuStrip1.Enabled = false;
            UserManager.MyLogin = "";

            textBox1.Text = textBox2.Text = "";
        }

    }
}
