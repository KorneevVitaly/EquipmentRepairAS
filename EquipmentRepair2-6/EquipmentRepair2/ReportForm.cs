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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            CrystalReport1 repa = new CrystalReport1();
            repa.SetDataSource(MyDataTables.datTab);
            crystalReportViewer1.ReportSource = repa;
        }
    }
}
