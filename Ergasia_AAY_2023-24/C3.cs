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

namespace Ergasia_AAY_2023_24
{
    public partial class C3 : Form
    {
        public C3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C3cafe c3Cafe = new C3cafe();
            c3Cafe.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainCustomer mainCustomer = new MainCustomer();
            mainCustomer.Show();
            Visible = false;
        }

        private void C3_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(950, 620);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Hide();
            if (radioButton1.Checked)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localFilePath = Path.Combine(baseDirectory, "radioButton1.mp4");
                string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
                webBrowser1.DocumentText = html;
            }
            else if (radioButton2.Checked)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localFilePath = Path.Combine(baseDirectory, "radioButton2.mp4");
                string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
                webBrowser1.DocumentText = html;
            }
            else if (radioButton3.Checked)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localFilePath = Path.Combine(baseDirectory, "radioButton3.mp4");
                string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
                webBrowser1.DocumentText = html;
            }
            else if (radioButton4.Checked)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localFilePath = Path.Combine(baseDirectory, "radioButton4.mp4");
                string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
                webBrowser1.DocumentText = html;
            }
            else if (radioButton5.Checked)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localFilePath = Path.Combine(baseDirectory, "radioButton5.mp4");
                string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
                webBrowser1.DocumentText = html;
            }
            else if (radioButton6.Checked)
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string localFilePath = Path.Combine(baseDirectory, "radioButton6.mp4");
                string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
                webBrowser1.DocumentText = html;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
