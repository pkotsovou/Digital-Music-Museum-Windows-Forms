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
    public partial class C5E3 : Form
    {
        private int userRole;

        public C5E3()
        {
            InitializeComponent();
        }
        public C5E3(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;

        }
        public void SetUserRole(int role)
        {
            userRole = role;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Ελέγχουμε αν η προηγούμενη φόρμα είναι MainCustomer ή MainEmployee και δημιουργούμε την αντίστοιχη φόρμα
            if (userRole == 0)
            {
                MainCustomer f = new MainCustomer(userRole);
                f.Show();
                Visible = false;
            }
            else if (userRole == 1)
            {
                MainEmployee ff = new MainEmployee(userRole);
                ff.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Lathos");
            }
        }

        private void C5E3_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(785, 350);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lights lights = new Lights(userRole);
            lights.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klimatismos klimatismos = new Klimatismos(userRole);
            klimatismos.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sound sound = new Sound(userRole);
            sound.Show();
            Visible = false;
        }
    }
}
