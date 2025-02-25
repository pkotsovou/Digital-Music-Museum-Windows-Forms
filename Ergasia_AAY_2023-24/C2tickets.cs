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
    public partial class C2tickets : Form
    {
        public C2tickets()
        {
            InitializeComponent();
        }

        private void C2tickets_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(870, 380);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C2 c2 = new C2();
            c2.Show();
            Visible = false;
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == null || comboBox2.Text == ""|| comboBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία για να γίνει προσθήκη στο καλάθι","",MessageBoxButtons.OK,MessageBoxIcon.None);
            }else
            {
                DialogResult result = MessageBox.Show("Επιτυχής προσθήκη στο καλάθι! Θέλετε να μεταφερθείτε στο καλάθι;", "Επιτυχία", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    C2kalathi c2Kalathi = new C2kalathi();
                    c2Kalathi.PreviousMainForm = this;
                    c2Kalathi.Show();
                    this.Visible=false;
                }
                else if (result == DialogResult.No)
                {
                    MainCustomer mainCustomer1 = new MainCustomer();
                    mainCustomer1.Show();
                    Visible=false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultsKalathi = MessageBox.Show("Θα θέλατε να μεταφερθείτε στο καλάθι για κάποια πληρωμή;", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (resultsKalathi == DialogResult.Yes)
            {
                C2kalathi c2Kalathi1 = new C2kalathi();
                c2Kalathi1.PreviousMainForm = this;
                c2Kalathi1.Show();
                this.Visible = false;
            }
               
        }
    }
}
