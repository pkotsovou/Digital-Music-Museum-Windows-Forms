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
    public partial class Lights : Form
    {
        private int userRole;

        public Lights()
        {
            InitializeComponent();
        }
        public Lights(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;

        }

        private void Lights_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(670, 350);
            label4.Hide();
            button2.Hide();
            pictureBox1.Hide();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string selected_room = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : null;
            if(selected_room == "Αίθουσα με Έργα Τέχνης ")
            {
                label4.Show();
                label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                button2.Show();
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.museum_on;
                count = 1;
            }
            else if(selected_room == "Αίθουσα Προβολής Βιντεοσκοπημένων εκδηλώσεων")
            {
                label4.Show();
                label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                button2.Show();
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.videos_on;
                count = 2;
            }
            else if(selected_room == "Καφετέρια")
            {
                label4.Show();
                label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                button2.Show();
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.cafe_on;
                count = 3;
            }
            else if (selected_room == "Αίθουσα Συναυλιών")
            {
                label4.Show();
                label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                button2.Show();
                pictureBox1.Show();
                pictureBox1.Image = Properties.Resources.concern_on;
                count = 4;
            }
            else if (string.IsNullOrEmpty(selected_room))
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα δωμάτιο.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                if (label4.Text == "Κατάσταση Φωτών: Ενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Απενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.museum_off;
                } else if (label4.Text == "Κατάσταση Φωτών: Απενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.museum_on;
                }
            }else if (count == 2)
            {
                if (label4.Text == "Κατάσταση Φωτών: Ενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Απενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.videos_off;
                }
                else if (label4.Text == "Κατάσταση Φωτών: Απενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.videos_on;
                }
            }else if (count == 3)
            {
                if (label4.Text == "Κατάσταση Φωτών: Ενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Απενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.cafe_off;
                }
                else if (label4.Text == "Κατάσταση Φωτών: Απενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.cafe_on;
                }
            }else if (count == 4)
            {
                if (label4.Text == "Κατάσταση Φωτών: Ενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Απενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.concern_off;
                }
                else if (label4.Text == "Κατάσταση Φωτών: Απενεργοποιημένα")
                {
                    label4.Text = "Κατάσταση Φωτών: Ενεργοποιημένα";
                    pictureBox1.Image = Properties.Resources.concern_on;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           C5E3 c5E3 = new C5E3(userRole);
           c5E3.SetUserRole(userRole);
           c5E3.Show();
           Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Hide();
            button2.Hide();
            pictureBox1.Hide(); 
        }
    }
}
