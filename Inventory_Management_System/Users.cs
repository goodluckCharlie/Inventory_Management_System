﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Users : Sample2
    {
        int edit = 0; // this 0 is an indication of save operation and 1 is an indication of update operation
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void Users_Load(object sender, EventArgs e)
        {
            userlabel.Text = retrieval.EMP_NAME;
            MainClass.disable_reset(leftPanel);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        //add button
        public override  void button1_Click(object sender, EventArgs e)
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
            if (nameTxt.Text == "") {nameErrorLabel.Visible = true;} else {nameErrorLabel.Visible = false;}
            if (usernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            if (phoneTxt.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (emailTxt.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex  == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passErrorLabel.Visible || phoneErrorLabel.Visible || emailErrorLabel.Visible || statusErrorLabel.Visible)
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
                   
                    i.insertUser(nameTxt.Text, usernameTxt.Text, passTxt.Text, phoneTxt.Text, emailTxt.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passTxt.Text, phoneTxt.Text, emailTxt.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                   
                }
            }
            
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit ==1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV); 
                }
 
            }

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if(searchTxt.Text != null)
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV, searchTxt.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
            }
        }
        public override  void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emailErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row =  dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UsernameGV"].Value.ToString();
                passTxt.Text = row.Cells["PassGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
