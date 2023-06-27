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
    public partial class Supplier :Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }
        int edit = 0; // this 0 is an indication of save operation and 1 is an indication of update operation
        int supplierID;
        short stat;
        retrieval r = new retrieval();

        private void Supplier_Load(object sender, EventArgs e)
        {
            userlabel.Text = retrieval.EMP_NAME;
            MainClass.disable_reset(leftPanel);
        }
        //Add button
        public override void button1_Click(object sender, EventArgs e) 
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
            if (supplierCompanyTxt.Text == "") { supNameErrorLabel.Visible = true; } else { supNameErrorLabel.Visible = false; }
            if (personNameTxt.Text == "") { contactPersonErrorLabel.Visible = true; } else { contactPersonErrorLabel.Visible = false; }
            if (phone1Txt.Text == "") { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (addressTxt.Text == "") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (supNameErrorLabel.Visible || contactPersonErrorLabel.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "stop", "error"); //error is a type of msg
            }
            else
            {
                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0) //code for save operation
                {

                    insertion i = new insertion();
                    if (statusDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (statusDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }
                    if (phone2Txt.Text == "" && ntnTxt.Text != "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                    }
                    else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                    }
                    else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                    }
                    r.showSuppliers(dataGridView1, suppIDGV, conNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (phone2Txt.Text == "" && ntnTxt.Text != "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, ntnTxt.Text);
                        }
                        else if (phone2Txt.Text != "" && ntnTxt.Text == "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, null);
                        }
                        else if (phone2Txt.Text == "" && ntnTxt.Text == "")
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, supplierCompanyTxt.Text, personNameTxt.Text, phone1Txt.Text, addressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                        }
                        r.showSuppliers(dataGridView1, suppIDGV, conNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.deleteSupplier(supplierID, "st_deleteSupplier", "@suppID");
                    r.showSuppliers(dataGridView1, suppIDGV, conNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                }

            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, suppIDGV, conNameGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, statusGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID  = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                supplierCompanyTxt.Text = row.Cells["conNameGV"].Value.ToString();
                personNameTxt .Text = row.Cells["personGV"].Value.ToString();
                phone1Txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["Phone2GV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                ntnTxt.Text = row.Cells["ntnGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void statusErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
