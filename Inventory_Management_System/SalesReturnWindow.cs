using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class SalesReturnWindow : Sample2
    {
        public SalesReturnWindow()
        {
            InitializeComponent();
        }


        retrieval r = new retrieval();
        Regex rg = new Regex("^[0-9]+$");
        private void loadBtn_Click(object sender, EventArgs e)
        {
            //SalesDataReport sdr = new SalesDataReport();
            


            if (salesIDTxt.Text != "")
                {
                    if (rg.Match(salesIDTxt.Text).Success)
                    {
                        r.showSalesDataViaID(Convert.ToInt64(salesIDTxt.Text), dataGridView1, salesIDgv, barcodeGV, proGV,
                            quantityGV, priceGV, perProTotalGV, totDiscountGV, totAmountGV, givenGV,
                            returnedGV, dateGV, userGV, paymentGV, proIDGV);

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Cells["priceGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["priceGV"].Value));
                        //row.Cells["perProDiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perProDiscountGV"].Value));
                        row.Cells["perProTotalGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["perProTotalGV"].Value));
                        }

                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        userTxt.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
                        payTxt.Text = dataGridView1.Rows[0].Cells["paymentGV"].Value.ToString();
                        givenTxt.Text = dataGridView1.Rows[0].Cells["givenGV"].Value.ToString();
                        refundTxt.Text = dataGridView1.Rows[0].Cells["returnedGV"].Value.ToString();
                        //totDiscountTxt.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["totDiscountGV"].Value.ToString())).ToString();
                        totAmountTxt.Text = Math.Ceiling(Convert.ToSingle(dataGridView1.Rows[0].Cells["totAmountGV"].Value.ToString())).ToString();
                    }
                    else
                    {
                        salesIDTxt.Text = "";
                        salesIDTxt.Focus();
                        dateTimePicker1.Value = DateTime.Now;
                        userTxt.Text = "";
                        payTxt.Text = "";
                        refundTxt.Text = "";
                        //amountReturnedTxt.Text = "";
                        //totDiscountTxt.Text = "";
                        totAmountTxt.Text = "";


                    }
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                    userTxt.Text = "";
                    payTxt.Text = "";
                    givenTxt.Text = "";
                    refundTxt.Text = "";
                    //totDiscountTxt.Text = "";
                    totAmountTxt.Text = "";
                }
            
        }
        //{
        //    if (salesIDTxt.Text != "")
        //    {
        //        if (rg.Match(salesIDTxt.Text).Success)
        //        {
        //            r.showSalesDataViaID(Convert.ToInt64(salesIDTxt.Text), dataGridView1, salesIDgv, barcodeGV, proGV,
        //                quantityGV, priceGV, perProDiscountGV, perProTotalGV, totDiscountGV, totAmountGV, givenGV,
        //                returnedGV, dateGV, userGV, paymentGV, proIDGV);

        //           if (dataGridView1.RowCount > 0)
        //            {
        //                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
        //                userTxt.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
        //                payTxt.Text = dataGridView1.Rows[0].Cells["paymentGV"].Value.ToString();
        //            }

        //        }
        //        else
        //        {
        //            salesIDTxt.Text = "";
        //            salesIDTxt.Focus();
        //            dateTimePicker1.Value = DateTime.Now;
        //            userTxt.Text = "";
        //            payTxt.Text = "";
        //        }                
        //    }
        //    else
        //    {
        //        dateTimePicker1.Value = DateTime.Now;
        //        userTxt.Text = "";
        //        payTxt.Text = ""; 

        //    }
        //}
        //Hashtable ht = new Hashtable();
        //insertion i = new insertion();
        //updation u = new updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void amountLable_Click(object sender, EventArgs e)
        {

        }
    }
}
