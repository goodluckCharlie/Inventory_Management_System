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
    public partial class products : Sample2
    {
        int edit = 0; // this 0 is an indication of save operation and 1 is an indication of update operation
        int proID;
        public products()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void products_Load(object sender, EventArgs e)
        {
            userlabel.Text = retrieval.EMP_NAME;
            MainClass.disable_reset(leftPanel);
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
           
        }
        public override void button1_Click(object sender, EventArgs e) //add button
        {
            MainClass.anable_reset(leftPanel);
            edit = 0;  
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (proTxt.Text == "") { proErrorLabel.Visible = true; } else { proErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (expiryPicker.Value < DateTime.Now ) { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "invalid Date"; } else { expiryErrorLabel.Visible = false; }
            if (expiryPicker.Value.Date == DateTime.Now.Date) { expiryErrorLabel.Visible = false; }           
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }
            if (proErrorLabel.Visible || barcodeErrorLabel.Visible || expiryErrorLabel.Visible || categoryErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "stop", "error"); //error is a type of msg
            }
            else
            {

                if (edit == 0) //code for save operation
                {

                    insertion i = new insertion();
                    if (expiryPicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));
                    }
                    else
                    {
                        i.insertProduct(proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);
                    }
                    
                    r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (expiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(proID, proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue));
                        }
                        else
                        {
                            u.updateProduct(proID, proTxt.Text, barcodeTxt.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);
                        }
                           
                        r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
                        MainClass.disable_reset(leftPanel);
                    }
 
                }
            }
        }

        public override  void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.deleteProduct(proID, "st_deleteProduct", "@proID");
                    r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
                }

            }
        }

        public override  void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, catGV, barcodeGV, catIDGV);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != 1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                proID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                proTxt.Text = row.Cells["proGV"].Value.ToString();
                barcodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                if (row.Cells["expiryGV"].FormattedValue == "") 
                {
                    expiryPicker.Value = DateTime.Now;
                }
                else
                {
                    expiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }              
                categoryDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void expiryPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
