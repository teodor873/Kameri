using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiperLinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            pictureBox1.Enabled = true;
            label1.Text = DateTime.Now.ToLongTimeString();
            pictureBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://free-webcambg.com/Primorsko-01-city-street-beach-port-webcam-live-online-camera-kamerite-na-jivo-vremeto-weather.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "";
            if (string.IsNullOrEmpty(url))
            {
                Process.Start("https://www.youtube.com/watch?v=thSQW8jDdYM");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            webBrowser1.Navigate("http://free-webcambg.com/Primorsko-01-city-street-beach-port-webcam-live-online-camera-kamerite-na-jivo-vremeto-weather.html");
            webBrowser2.Navigate("http://free-webcambg.com/Kiten-03-webcam-live-online-camera-plaj-kameri-na-jivo-vremeto-weather.htm");
                    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("http://free-webcambg.com/Primorsko-01-city-street-beach-port-webcam-live-online-camera-kamerite-na-jivo-vremeto-weather.html");
        }
    }
}
