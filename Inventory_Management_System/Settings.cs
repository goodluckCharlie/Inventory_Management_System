using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string s;
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (isCB.Checked)
            {
                if (ServerTxt.Text != "" && databaseLabel.Text != "")
                {
                    s = "Data source=" + ServerTxt.Text + ";Initial catalog=" + DatabaseTxt.Text + ";Integrated security=true;MultipleActiveResultSets=true";
                    File.WriteAllText(path + "\\connect", s);

                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                        }
                    }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            else
            {
                if (ServerTxt.Text != "" && databaseLabel.Text != "" && UserIDTxt.Text != "" && PasswordTxt.Text != "")
                {
                    s = "Data source=" + ServerTxt.Text + ";Initial catalog=" + DatabaseTxt.Text + ";User ID=" + UserIDTxt.Text + ";Password=" + PasswordTxt.Text +"; MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect", s);
                  

                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                    }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            

        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
                {
                UserIDTxt.Enabled = false;
                PasswordTxt.Enabled = false;
                UserIDTxt.Text = "";
                PasswordTxt.Text = "";
                }
            else
                {
                Label4.Enabled = true;
                Label5.Enabled = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
