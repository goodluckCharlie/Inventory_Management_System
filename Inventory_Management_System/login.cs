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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else {usernameErrorLabel.Visible = false; }
            if (PasswordTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            if (usernameErrorLabel.Visible  || passErrorLabel.Visible)
            {
              
            }
            else
            {   
                   if (retrieval.getUserDetails(UsernameTxt.Text, PasswordTxt.Text))
                    {
                        HomeScreen hm = new HomeScreen();
                        MainClass.showWindow(hm, this, MDI.ActiveForm);
                    }
                    else
                    {

                    }
                
            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
        }
    }
}
