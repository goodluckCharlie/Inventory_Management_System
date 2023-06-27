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
    public partial class HomeScreen : Sample 
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            //MDI m = new MDI();
            //m.logoutToolStripMenuItem.Enabled = true;
            MDI.logoutToolStripMenuItem.Enabled = true;
            userlabel.Text = retrieval.EMP_NAME;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            Categories  c = new Categories ();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void proDD_Click(object sender, EventArgs e)
        {
            products p = new products();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            Supplier  s = new Supplier ();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }  

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pi = new PurchaseInvoice();
            MainClass.showWindow(pi, this, MDI.ActiveForm);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stocks s = new stocks();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {

            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void pricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing  pp = new ProductPricing();
            MainClass.showWindow(pp, this, MDI.ActiveForm);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            SalesReturnWindow srw = new SalesReturnWindow();
            MainClass.showWindow(srw, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherForecast wf = new WeatherForecast();
            MainClass.showWindow(wf, this, MDI.ActiveForm);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            stocks sts = new stocks();
            if (sts.status == true)
            {
                notificationPanel.Visible = true;
            }
            else
            {

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Some products are low on stock, Please consider making a reorder. Would you like to check the stock now??", "Reorder Alert...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)

            {
                stocks s = new stocks();
                MainClass.showWindow(s, this, MDI.ActiveForm);
            }
           else
            {

            }
        }
    }
}
