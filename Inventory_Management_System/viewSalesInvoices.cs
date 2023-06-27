using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class viewSalesInvoices : Sample
    {
        public viewSalesInvoices()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            r.showDailySales(dateTimePicker1.Value, dataGridView1, salidGV, userGV, totAmtGV, totDisGV, givenGV, returnedGV, userIDgv);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["totAmtGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totAmtGV"].Value));
                row.Cells["totDisGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totDisGV"].Value));
                row.Cells["givenGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["givenGV"].Value));
                row.Cells["returnedGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["returnedGV"].Value));
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
        public static int salesID = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salesID = Convert.ToInt32(row.Cells["salidGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }
    }
}
