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

namespace Inventory_Management_System
{
    public partial class Sales : Sample2 
    {
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9])*?$");
        public Sales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void barCodeTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
        retrieval r = new retrieval();
        string[] prodArray = new string[6];
        float GROSS;
        bool productCheck;
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            viewSalesInvoices vsi = new viewSalesInvoices();
            MainClass.showWindow(vsi, this, MDI.ActiveForm);
        }
        private void barCodeTxt_Validating(object sender, CancelEventArgs e)
        {
           if (barCodeTxt.Text != "")
            {
                grossTxt.Text = "";
                totalDiscountTxt.Text = "";
                amountGivenTxt.Text = "";
                changeToGiveTxt.Text = "";

                int qCount = 0, sQuant = 0, nCount = 0;
                prodArray = r.getProductsWRTBarcode(barCodeTxt.Text);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(prodArray[0] == row.Cells["proIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt64(prodArray[0])));              
                nCount = sQuant - qCount;
                if(nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodArray[0]), prodArray[1], 1, Convert.ToSingle(prodArray[3]), Math.Round(Convert.ToSingle(prodArray[4]), 2), Convert.ToSingle(prodArray[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["proIDGV"].Value.ToString() == prodArray[0])
                            {
                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                            }

                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == prodArray[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["discGV"].Value.ToString() != null)
                                    {
                                        disc += Convert.ToSingle(row.Cells["discGV"].Value.ToString()) + Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                        row.Cells["discGV"].Value = disc;
                                        Math.Round(disc);
                                    }

                                    float tot = (Convert.ToSingle(row.Cells["pupGV"].Value.ToString())) * (Convert.ToSingle(row.Cells["quantityGV"].Value.ToString())) - Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                    row.Cells["totGV"].Value = tot;

                                }

                            }

                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodArray[0]), prodArray[1], 1, Convert.ToSingle(prodArray[3]), prodArray[4], Convert.ToSingle(prodArray[5]));
                        }
                    }

                    foreach (DataGridViewRow item in dataGridView1.Rows)

                    {
                        GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
                    }
                    grossLabel.Text = Math.Round(GROSS,0).ToString("##########.00");
                    GROSS = 0;
                    barCodeTxt.Focus();
                    barCodeTxt.Text = "";

                }

                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex !=-1 && e.ColumnIndex !=-1)
            {
                if (e.ColumnIndex == 6)
                {
                    grossTxt.Text = "";
                    totalDiscountTxt.Text = "";
                    amountGivenTxt.Text = "";
                    changeToGiveTxt.Text = "";
                    float gt, tot, dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(grossLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                        grossLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        row.Cells["quantityGV"].Value = q;
                        dis = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(prodArray[4]);
                        row.Cells["discGV"].Value = dis;
                        tot = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) - dis;
                        row.Cells["totGV"].Value = tot;
                    
                        foreach (DataGridViewRow item in dataGridView1.Rows)

                        {
                            GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
                        }
                        grossLabel.Text = GROSS.ToString("##########.00");
                        GROSS = 0;
                       
                    }
                }
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            userlabel.Text = retrieval.EMP_NAME;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                float dis = 0, gross = 0;
                foreach( DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                }
                grossTxt.Text = Math.Round(gross, 0).ToString("##########.00");
                totalDiscountTxt.Text = Math.Round(dis, 0).ToString("##########.00");
            }
        }

        private void amountGivenTxt_TextChanged(object sender, EventArgs e)
        {
            if(amountGivenTxt.Text != "")
            {
                if(!rg.Match(amountGivenTxt.Text).Success)
                {
                    amountGivenTxt.Text = "";
                    amountGivenTxt.Focus();
                }
                else
                {
                    
                }
                    
            }
            else
            {
                changeToGiveTxt.Text = "";
            }
        }

        private void amountGivenTxt_Validating(object sender, CancelEventArgs e)
        {
            if(amountGivenTxt.Text != "" && grossTxt.Text != "")
            {
                if (!(Convert.ToSingle(grossTxt.Text) <= Convert.ToSingle(amountGivenTxt.Text)))
                {
                    amountGivenTxt.Text = "";
                    changeToGiveTxt.Text = "";
                    amountGivenTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amountGivenTxt.Text);
                    float amountToReturn = amountGiven - Convert.ToSingle(grossTxt.Text);
                    changeToGiveTxt.Text = Math.Round(amountToReturn, 0).ToString("##########.00") + Convert.ToSingle(totalDiscountTxt.Text);
                }
            }         
        }
        insertion i = new insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (amountGivenTxt.Text != "" && totalDiscountTxt.Text != "" && grossTxt.Text != "" && payDD.SelectedIndex != -1 && changeToGiveTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\n\tTotal Amount : " + grossTxt.Text + "\n\tTotal Discount : " + totalDiscountTxt.Text + "\n\tAmount Given : " + amountGivenTxt.Text + "\n\tAmount Returned : " + changeToGiveTxt.Text + "\n\nAre you sure, Submit current Sales?\n", "Quastion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "proIDGV", "quantityGV", "pupGV", "discGV", retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grossTxt.Text), Convert.ToSingle(totalDiscountTxt.Text), Convert.ToSingle(amountGivenTxt.Text), Convert.ToSingle(changeToGiveTxt.Text), payDD.SelectedItem.ToString());
                    MainClass.anable_reset(Payments);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";
                    SalesReport sr = new SalesReport();
                    sr.Show();
                }
            }
     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grossTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
