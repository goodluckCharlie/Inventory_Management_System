using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory_Management_System
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path+"\\connect"))
            {
                login log = new login();
                MainClass.showWindow(log, this);

            }
                else

            {
                Settings set = new Settings();
                MainClass.showWindow(set, this);
                
                
            }
             
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = false;
            login set = new login();
            MainClass.showWindow(set, this); 
        }
    }
}
