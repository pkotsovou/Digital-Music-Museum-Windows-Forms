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
    public partial class Klimatismos : Form
    {
        private int userRole;

        public Klimatismos()
        {
            InitializeComponent();
        }
        public Klimatismos(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            C5E3 c5E3 = new C5E3(userRole);
            c5E3.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα δωμάτιο.");
            }
            label4.Show();
            label4.Text = "Κατάσταση Κλιματισμού: Ενεργός";
            button2.Show();
        }

        private void Klimatismos_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(700, 285);

            label4.Hide();
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label4.Text== "Κατάσταση Κλιματισμού: Ενεργός")
            {
                label4.Text = "Κατάσταση Κλιματισμού: Ανενεργός";
            }else if (label4.Text == "Κατάσταση Κλιματισμού: Ανενεργός")
            {
                label4.Text = "Κατάσταση Κλιματισμού: Ενεργός";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Hide();
            button2.Hide();
        }
    }
}
