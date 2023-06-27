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
    public partial class stocks : Sample2 
    {
        public stocks()
        {
            InitializeComponent();
        }

        private void stocks_Load(object sender, EventArgs e)
        {
            base.addBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            userlabel.Text = retrieval.EMP_NAME;
            
        }
        public override void button1_Click(object sender, EventArgs e) //add button
        {

        }
       
        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            
        }
        retrieval r = new retrieval();
        
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showStockDetails(dataGridView1, proIDGV, proGV, barGV, expiryGV, bpGV, spGV, catGV, quantityGV, statusGV, finalGV);
           
            

        }
        public override  void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "LOW")
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }
        public bool status;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
