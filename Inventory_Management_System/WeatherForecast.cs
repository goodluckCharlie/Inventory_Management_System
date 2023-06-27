using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace Inventory_Management_System
{
    public partial class WeatherForecast : Sample
    {
        public WeatherForecast()
        {
            InitializeComponent();
        }

        //class somePanel : Panel
        //{
        //    public somePanel()
        //    {
        //        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        //        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        //        this.SetStyle(ControlStyles.UserPaint, true);
        //    }
        //}
        string city;
        private void WeatherForecast_Load(object sender, EventArgs e)
        {
            userlabel.Text = retrieval.EMP_NAME;
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            city = cityTxt.Text;

            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=9324c756bf4141b3a36192413202311&q={0}&days=1", city);

            XDocument doc = XDocument.Load(uri);
            string iconUri = (string)doc.Descendants("icon").FirstOrDefault();
            WebClient client = new WebClient();
            byte[] image = client.DownloadData("http:" + iconUri);
            MemoryStream stream = new MemoryStream(image);
            Bitmap newBitmap = new Bitmap(stream);


            string tempC = (string)doc.Descendants("temp_c").FirstOrDefault();
            string tempF = (string)doc.Descendants("temp_f").FirstOrDefault();
            string speedmph = (string)doc.Descendants("wind_mph").FirstOrDefault();
            string speedkph = (string)doc.Descendants("wind_kph").FirstOrDefault();
            string humidity = (string)doc.Descendants("humidity").FirstOrDefault();
            string country = (string)doc.Descendants("country").FirstOrDefault();
            string cloud = (string)doc.Descendants("text").FirstOrDefault();
            Bitmap icon = newBitmap;

            tempCTxt.Text = tempC;
            TempFTxt.Text = tempF;
            windMphTxt.Text = speedmph;
            humidityTxt.Text = humidity;
            windKphTxt.Text = speedkph;
            countryTxt.Text = country;
            cloudLabel.Text = cloud;

            pictureBox1.Image = icon;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {   
            DataTable dt = new DataTable();
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Max Temp", typeof(string));
            dt.Columns.Add("Min Temp", typeof(string));
            dt.Columns.Add("Max wind_Mph", typeof(string));
            dt.Columns.Add("Max wind_Kph", typeof(string));
            dt.Columns.Add("Humidity", typeof(string));
            dt.Columns.Add("Wind direction", typeof(string));
            dt.Columns.Add("Cloud", typeof(string));
            dt.Columns.Add("Pressure_mb", typeof(string));

            city = cityTxt.Text;

            string uri = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=9324c756bf4141b3a36192413202311&q={0}&days=10", city);

            XDocument doc = XDocument.Load(uri);
            foreach (var npc in doc.Descendants("forecastday"))
            {
                //string iconUri = (string)npc.Descendants("icon").FirstOrDefault();
                //WebClient client = new WebClient();
                //byte[] image = client.DownloadData("http:" + iconUri);
                //MemoryStream stream = new MemoryStream(image);
                //Bitmap newBitmap = new Bitmap(stream);

                dt.Rows.Add(new object[]
                {
                    (string)doc.Descendants("country").FirstOrDefault(),
                    (string)npc.Descendants("date").FirstOrDefault(),
                    (string)npc.Descendants("maxtemp_c").FirstOrDefault(),
                    (string)npc.Descendants("mintemp_c").FirstOrDefault(),
                    (string)npc.Descendants("maxwind_mph").FirstOrDefault(),
                    (string)npc.Descendants("maxwind_kph").FirstOrDefault(),
                    (string)npc.Descendants("humidity").FirstOrDefault(),
                    (string)npc.Descendants("wind_dir").FirstOrDefault(),
                    (string)npc.Descendants("text").FirstOrDefault(),
                    (string)npc.Descendants("pressure_mb").FirstOrDefault(),
                }
                ) ;

            }
            
            dataGridView1.DataSource = dt;
        }
    }
}
