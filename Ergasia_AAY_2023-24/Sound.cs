using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia_AAY_2023_24
{

    public partial class Sound : Form
    {
        private int userRole;

        public Sound()
        {
            InitializeComponent();
        }
        public Sound(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα δωμάτιο.");
            }
            label4.Show();
            button5.Show();
            label2.Show();
            comboBox2.Show();
            button2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text ="Απενεργοποιημένος Ήχος";
            label2.Hide();
            comboBox2.Hide();
            button2.Hide();
            button3.Show();
            button5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Show();
            label4.Text = "Ένταση Ήχου: 50%";
            button5.Show();
            label2.Show();
            comboBox2.Show();
            button2.Show();
            button3.Hide();
        }

        private void Sound_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(635, 340);
            label4.Hide();
            button5.Hide();
            label2.Hide();
            comboBox2.Hide();
            button2.Hide();
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected_sound = comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : null;
            if(string.IsNullOrEmpty(selected_sound))
            {
                MessageBox.Show("Παρακαλώ αλλάξτε την ένταση του ήχου.");
            }else if (selected_sound == "0%")
            {
                label4.Text = "Ένταση Ήχου: 0%";
            }else if(selected_sound == "10%")
            {
                label4.Text = "Ένταση Ήχου: 10%";
            }else if (selected_sound == "20%")
            {
                label4.Text = "Ένταση Ήχου: 20%";
            }else if (selected_sound == "30%")
            {
                label4.Text = "Ένταση Ήχου: 30%";
            }
            else if (selected_sound == "40%")
            {
                label4.Text = "Ένταση Ήχου: 40%";
            }
            else if (selected_sound == "50%")
            {
                label4.Text = "Ένταση Ήχου: 50%";
            }
            else if (selected_sound == "60%")
            {
                label4.Text = "Ένταση Ήχου: 60%";
            }
            else if (selected_sound == "70%")
            {
                label4.Text = "Ένταση Ήχου: 70%";
            }
            else if (selected_sound == "80%")
            {
                label4.Text = "Ένταση Ήχου: 80%";
            }
            else if (selected_sound == "90%")
            {
                label4.Text = "Ένταση Ήχου: 90%";
            }
            else if (selected_sound == "100%")
            {
                label4.Text = "Ένταση Ήχου: 100%";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C5E3 c5E3 = new C5E3(userRole);
            c5E3.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Hide();
            button5.Hide();
            label2.Hide();
            comboBox2.Hide();
            button2.Hide();
            button3.Hide();
        }
    }
}
