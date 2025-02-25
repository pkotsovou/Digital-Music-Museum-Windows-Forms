using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Ergasia_AAY_2023_24
{

    public partial class MainCustomer : Form
    {
        private int userRole;
        bool slidebarExpand ; 

        public MainCustomer()
        {
            InitializeComponent();
        }
        public MainCustomer(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slidebartimer_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                //if sidebar is expand, minimize 
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    slidebarExpand = false;
                    slidebartimer.Stop();
                }
            }else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    slidebarExpand = true;
                    slidebartimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            slidebartimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C2 f = new C2();
            f.Show();
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            C1 f = new C1();
            f.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C3 f = new C3();
            f.Show();
            Visible = false;
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
            C5E3 f = new C5E3();
            f.Show();
            Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button1b;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button1a;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button2b;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button2a;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.button3b;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.button3a;

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

        private void buttonexit_Click(object sender, EventArgs e)
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

        private void MainCustomer_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(900, 450);
        }



        private void buttonshoppingcart_Click(object sender, EventArgs e)
        {
            C2kalathi f = new C2kalathi();
            f.PreviousMainForm = this;
            f.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string pdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserManual.pdf"); 
                
                if(File.Exists(pdfPath))
                {
                    Process.Start(pdfPath);
                }
                else
                {
                    MessageBox.Show("Το αρχείο PDF δεν βρέθηκε.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα κατά το άνοιγμα του εγχειρίδιου χρήστη: " + ex.Message);
            }
        }
    }
}
