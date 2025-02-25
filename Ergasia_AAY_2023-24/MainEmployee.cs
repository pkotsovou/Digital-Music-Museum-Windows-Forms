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
    public partial class MainEmployee : Form
    {
        private int userRole;

        public MainEmployee()
        {
            InitializeComponent();
        }
        // Νέος κατασκευαστής που δέχεται τον userRole
        public MainEmployee(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C4E2 f = new C4E2(userRole);
            f.SetUserRole(userRole);
            f.Show();
            Visible = false;
        }
       
        

        private void button5_Click(object sender, EventArgs e)
        {
            C5E3 f = new C5E3(userRole);
            f.SetUserRole(userRole);
            f.Show();
            Visible = false;
        }

 

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.button4b;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.button4a;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.button5b;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.button5a;

        }

        private void MainEmployee_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(815, 400);
        }

        private void mainC_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Είστε σίγουροι ότι θέλετε να αποσυνδεθείτε;", "Έξοδος", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm f = new LoginForm();
                f.Show();
                Visible = false;
            }
            else if (result == DialogResult.No)
            {
                //Nothing
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
