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
    public partial class Contestants : Form
    {
        private int userRole;


        public Contestants()
        {
            InitializeComponent();
        }
        public Contestants(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;


        }
        public static string fileName = "names.txt";

        public static string lastAddedName;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                try
                {

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {

                        writer.WriteLine(textBox1.Text);
                        lastAddedName = textBox1.Text;
                    }

                    MessageBox.Show($"Το όνομα '{textBox1.Text}' αποθηκεύτηκε με επιτυχία.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Σφάλμα κατά την αποθήκευση του ονόματος: {ex.Message}");
                }

                textBox1.Clear();
            }
        }

        private void Contestants_Load(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, string.Empty);
        }
        string filePath = "names.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length == 0)
            {
                MessageBox.Show("Παρακαλώ εισάγετε κάποιο όνομα.");
            }
            else
            {
                Karaoke k = new Karaoke(userRole);
                k.Show();
                Visible = false;
            }
           

        }
    }
}
