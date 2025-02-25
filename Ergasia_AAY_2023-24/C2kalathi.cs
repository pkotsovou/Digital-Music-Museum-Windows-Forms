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
    public partial class C2kalathi : Form
    {
        public Form PreviousMainForm { get; set; }

        public C2kalathi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || dateTimePicker1.Value == null || textBox2.Text == "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα στοιχεία της κάρτας σας για να ολοκληρωθεί η πληρωμή!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                DialogResult result = MessageBox.Show("Επιτυχής πληρωμή! \nΣας ευχαριστούμε πολύ για την συναλλαγή σας!!!\nΚαλή συνέχεια στην περιήγησή σας στο μουσείο μας!!!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MainCustomer mainCustomer = new MainCustomer();
                    mainCustomer.Show();
                    Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainCustomer mainCustomer = new MainCustomer();
            mainCustomer.Show();
            Visible = false;
        }

        private void C2kalathi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ελέγχετε αν η PreviousMainForm υπάρχει και είναι φόρμα
            if (PreviousMainForm != null && PreviousMainForm is Form)
            {
                // Αλλάζετε το Visible της τρέχουσας φόρμας σε false
                this.Visible = false;

                // Εμφανίζετε την προηγούμενη φόρμα
                PreviousMainForm.Show();
            }
            else
            {
                // Αν υπάρχει πρόβλημα με την PreviousMainForm
                MessageBox.Show("Προέκυψε ένα πρόβλημα κατά τον εντοπισμό της προηγούμενης φόρμας.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
