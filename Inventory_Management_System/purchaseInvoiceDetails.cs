using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class purchaseInvoiceDetails : Sample2 
    {
        public purchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        private void purchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseDD, "Company", "ID", "month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        retrieval r = new retrieval();
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseDD, "Company", "ID", "month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }
        public override void backBtn_Click_1(object sender, EventArgs e)
        {
            PurchaseInvoice  obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }
        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void purchaseDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(purchaseDD.SelectedIndex != -1 && purchaseDD.SelectedIndex != 0)
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purchaseDD.SelectedValue.ToString()), dataGridView1, mPIDgv, proIDGV, proGV, quantityGV, pupGV, totGV); 
            foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                }
                grossLabel2.Text = gt.ToString();
                gt = 0; 
            }
        }
        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 0)
                {   
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete " + row.Cells["proGV"].Value.ToString() + " from Purchase Invoice?\n\t\t\tWARNING\n\tDELETION OF PRODUCTS WILL AFFECT STOCK", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    int q;  
                    if (dr== DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItem(Convert.ToInt64(purchaseDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), retrieval.USER_ID, DateTime.Today);
                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                                grossLabel.Text = tot.ToString();
                                d.deleteProductFromPID(Convert.ToInt64(row.Cells["mPIDgv"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
      
                    }
                }
            }
        }
    }
}
