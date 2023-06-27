using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Inventory_Management_System
{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userlabel.Text = retrieval.EMP_NAME;
            r.getList("[st_getSupplierList]", supplierDD, "Company", "ID");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        string[] prodArray = new string[4];
        int productID;
        float gt;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9])*?$");

        
        public override  void button1_Click(object sender, EventArgs e) //add button
        {
            MainClass.anable_reset(leftPanel);
        }
        public override void editBtn_Click(object sender, EventArgs e)
        {

        }
        int co;
        updation u = new updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                insertion i = new insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totGV"].Value.ToString()));
                        if (r.checkProductPriceExistance(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString())))
                        {
                            u.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }

                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }
                    }
                    if (co > 0)
                    {
                        MessageBox.Show("Purchase Invoice Created Successfully", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MainClass.showMSG("Unable to create purchase invoice", "Error...", "Error");
                    }
                    sc.Complete();
                }
            
                
            }
        } 

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            purchaseInvoiceDetails pid = new purchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }
        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void barcodeTxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            if (quantityTxt.Text != "")
            {
                if (rg.Match(quantityTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quantityTxt.Text);
                    price = Convert.ToSingle(pupTxt.Text);
                    tot = quan * price;
                    totLabel.Text = tot.ToString("##########.00");
                }
                else
                {
                    quantityTxt.SelectAll();
                }
            }
            else
            {
                totLabel.Text = "0.00";
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (supplierDD.SelectedIndex == -1) { suppErrorLabel.Visible = true; } else { suppErrorLabel.Visible = false; }
            if (quantityTxt.Text == "") { quantErrorLabel.Visible = true; } else { quantErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (suppErrorLabel.Visible || quantErrorLabel.Visible || barcodeErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "stop", "error"); //error is a type of msg
            }
            else
            {  
                dataGridView1.Rows.Add(productID, productTxt.Text, quantityTxt.Text, pupTxt.Text, totLabel.Text);

                gt += Convert.ToSingle(totLabel.Text);
                grossLabel.Text = gt.ToString("##########.00");
                productID = 0;
                productTxt.Text = "";
                pupTxt.Text = "";
                barcodeTxt.Text = "";
                totLabel.Text = "0.00";
                quantityTxt.Text = ""; 
                Array.Clear(prodArray, 0, prodArray.Length);
                
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();                   
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pupTxt_TextChanged(object sender, EventArgs e)
        {
            if (pupTxt.Text != "")
            {
                if(!rg.Match(pupTxt.Text).Success)
                {
                    pupTxt.Text = "";
                    pupTxt.Focus();
                }
            }
        }

        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                prodArray = r.getProductsWRTBarcode_pi(barcodeTxt.Text);
                productID = Convert.ToInt32(prodArray[0]);
                productTxt.Text = prodArray[1];
                string barCode = prodArray[2];
                productTxt.Enabled = false;

                if (barCode == null)
                {
                    return;
                }
                pupTxt.Focus();
            }
            else
            {
                productID = 0;
                productTxt.Text = "";
                pupTxt.Text = "";
                Array.Clear(prodArray, 0, prodArray.Length);

            }
        }
    }
}
