using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ergasia_AAY_2023_24
{
    public partial class C4E2 : Form
    {
        private int userRole;

        public C4E2(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;

        }
        public void SetUserRole(int role)
        {
            userRole = role;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            // Ελέγχουμε αν η προηγούμενη φόρμα είναι MainCustomer ή MainEmployee και δημιουργούμε την αντίστοιχη φόρμα
            if (userRole==0)
            {
                MainCustomer f = new MainCustomer(userRole);
                f.Show();
                Visible = false;
            }
            else if (userRole==1)
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
       
        private void C4E2_Load(object sender, EventArgs e)
        {
            
            Size = new System.Drawing.Size(1000, 430);

            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            label7.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            comboBox7.Visible = false;
            label16.Visible = false;
            button13.Visible = false;
            label17.Visible = false;
            button14.Visible = false;
            comboBox8.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            button15.Visible = false;
            label20.Visible = false;
            button16.Visible = false;
            label21.Visible = false;
            button17.Visible = false;
            textBox1.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            comboBox9.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            
            if (File.Exists("selected_value.txt"))
            {
                string savedValue = File.ReadAllText("selected_value.txt");
                label3.Text = "Τώρα παίζει: " + savedValue;
               
            }
            if (File.Exists("selected_value2.txt"))
            {
                string savedValue2 = File.ReadAllText("selected_value2.txt");
                label6.Text = "Ρυθμός : " + savedValue2;
            }
            if (File.Exists("selected_value3.txt"))
            {
                string savedValue3 = File.ReadAllText("selected_value3.txt");
                label11.Text = "Ειδικά εφέ φωνής : " + savedValue3;
            }
            if (File.Exists("selected_value4.txt"))
            {
                string savedValue4 = File.ReadAllText("selected_value4.txt");
                label9.Text = "Χρώμα φώτων : " + savedValue4;
            }
            if (File.Exists("selected_value5.txt"))
            {
                string savedValue5 = File.ReadAllText("selected_value5.txt");
                label8.Text = "Είδος μουσικής : " + savedValue5;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = true;
            label7.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label16.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            label15.Visible = true;
            comboBox7.Visible = true;
            button13.Visible = true;
            button10.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            label22.Visible = true;
            label23.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            button19.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            comboBox9.Visible = true;
            button18.Visible = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            comboBox8.Visible = true;
            label20.Visible = true;
            button16.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            label18.Visible = true;
            label19.Visible = true;
            button15.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            label21.Visible = true;
            button17.Visible = true;
            textBox1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Contestants c = new Contestants(userRole);
            c.Show();
            Visible = false;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            label2.Visible = false;
            label17.Visible = true;
            button14.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            C4E2 f = new C4E2(userRole);
            f.SetUserRole(userRole);
            f.Show();
            this.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε καλλιτέχνη.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                label14.Visible = true;
                button12.Visible = true;

                if (comboBox1.SelectedIndex == 0)
                {
                    comboBox2.Visible = true;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false;

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    comboBox3.Visible = true;
                    comboBox2.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox4.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox5.Visible = false;
                    comboBox6.Visible = false;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    comboBox5.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox6.Visible = false;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    comboBox6.Visible = true;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    comboBox5.Visible = false;
                }
            }
        }

        string selectedValue = "";
        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1 && comboBox5.SelectedIndex == -1 && comboBox6.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε κομμάτι.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    selectedValue = comboBox2.SelectedItem.ToString();

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    selectedValue = comboBox3.SelectedItem.ToString();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    selectedValue = comboBox4.SelectedItem.ToString();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    selectedValue = comboBox5.SelectedItem.ToString();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    selectedValue = comboBox6.SelectedItem.ToString();
                }

                MessageBox.Show("Συγχαρητήρια!Το κομμάτι που διαλέξατε θα παίξει τώρα!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                File.WriteAllText("selected_value.txt", selectedValue);
                label3.Text = "Τώρα παίζει :" + selectedValue;
                selectedValue5 = "Κλασσική";
                File.WriteAllText("selected_value5.txt", selectedValue5);
                label8.Text = "Είδος μουσικής : " + selectedValue5;
            }
        }

        string selectedValue2= "";
        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ρυθμό.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (comboBox7.SelectedIndex == 0)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();

                }
                else if (comboBox7.SelectedIndex == 1)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 2)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 3)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 4)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 5)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 6)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 7)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 8)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 9)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 10)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                else if (comboBox7.SelectedIndex == 11)
                {
                    selectedValue2 = comboBox7.SelectedItem.ToString();
                }
                MessageBox.Show("Συγχαρητήρια! Ο ρυθμός θα αλλάξει τώρα!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                File.WriteAllText("selected_value2.txt", selectedValue2);
                label6.Text = "Ρυθμός : " + selectedValue2;
            }
        }

        string selectedValue3 = "";
        private void button14_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked )
            {
                MessageBox.Show("Παρακαλώ διαλέξτε μία από τις επιλογές.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("Συγχαρητήρια!Τα εφέ φωνής προστέθηκαν!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                    selectedValue3 = radioButton1.Text;

                }
                else if (radioButton2.Checked)
                {
                    MessageBox.Show("Συγχαρητήρια!Τα εφέ φωνής αφαιρέθηκαν!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                    selectedValue3 = radioButton2.Text;
                }
                File.WriteAllText("selected_value3.txt", selectedValue3);
                label11.Text = "Ειδικά εφέ φωνής : " + selectedValue3;
            }

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Συγχαρητήρια!Το αντίγραφο ασφαλείας δημιουργήθηκε!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
        string selectedValue4 = "";
        private void button16_Click(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε χρώμα φωτών.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (comboBox8.SelectedIndex == 0)
                {
                    selectedValue4 = comboBox8.SelectedItem.ToString();

                }
                else if (comboBox8.SelectedIndex == 1)
                {
                    selectedValue4 = comboBox8.SelectedItem.ToString();
                }
                else if (comboBox8.SelectedIndex == 2)
                {
                    selectedValue4 = comboBox8.SelectedItem.ToString();
                }
                else if (comboBox8.SelectedIndex == 3)
                {
                    selectedValue4 = comboBox8.SelectedItem.ToString();
                }
                else if (comboBox8.SelectedIndex == 4)
                {
                    selectedValue4 = comboBox8.SelectedItem.ToString();
                }
                MessageBox.Show("Συγχαρητήρια!Το χρώμα των φώτων θα αλλάξει τώρα!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                File.WriteAllText("selected_value4.txt", selectedValue4);
                label9.Text = "Χρώμα φώτων : " + selectedValue4;
            }
        }

        
        private void button17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε κάποιο κομμάτι.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Συγχαρητήρια!Το κομμάτι που πληκτρολογήσατε θα παίξει τώρα!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                selectedValue = textBox1.Text;
                File.WriteAllText("selected_value.txt", selectedValue);
                label3.Text = "Τώρα παίζει : " + selectedValue;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        string selectedValue5 = "";

        private Random random = new Random();
        private List<string> songs = new List<string> { "Brandenburg Concertos", "Symphony No. 5 in C Minor", "Eine kleine Nachtmusik", "The Nutcracker (ballet)", "Vienna Blood (waltz)" };
        private void button18_Click(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε είδος μουσικής.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (comboBox9.SelectedIndex == 0)
                {
                    selectedValue5 = comboBox9.SelectedItem.ToString();
                    int randomIndex = random.Next(0, songs.Count);
                    selectedValue = songs[randomIndex];
                    File.WriteAllText("selected_value.txt", selectedValue);
                    label3.Text = "Τώρα παίζει : " + selectedValue;
                }
                else if (comboBox9.SelectedIndex == 1)
                {
                    selectedValue5 = comboBox9.SelectedItem.ToString();
                    selectedValue = "Άγνωστο";
                    File.WriteAllText("selected_value.txt", selectedValue);
                    label3.Text = "Τώρα παίζει : " + selectedValue;
                }
                else if (comboBox9.SelectedIndex == 2)
                {
                    selectedValue5 = comboBox9.SelectedItem.ToString();
                    selectedValue = "Άγνωστο";
                    File.WriteAllText("selected_value.txt", selectedValue);
                    label3.Text = "Τώρα παίζει : " + selectedValue;
                }
                else if (comboBox9.SelectedIndex == 3)
                {
                    selectedValue5 = comboBox9.SelectedItem.ToString();
                    selectedValue = "Άγνωστο";
                    File.WriteAllText("selected_value.txt", selectedValue);
                    label3.Text = "Τώρα παίζει : " + selectedValue;
                }
                else if (comboBox9.SelectedIndex == 4)
                {
                    selectedValue5 = comboBox9.SelectedItem.ToString();
                    selectedValue = "Άγνωστο";
                    File.WriteAllText("selected_value.txt", selectedValue);
                    label3.Text = "Τώρα παίζει : " + selectedValue;
                }
                MessageBox.Show("Συγχαρητήρια!Τo είδος μουσικης θα αλλάξει τώρα!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
                File.WriteAllText("selected_value5.txt", selectedValue5);
                label8.Text = "Είδος μουσικής : " + selectedValue5;
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Παρακαλώ προσθέστε τραγούδια στο δεύτερο κουτί.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string items = string.Join(", ", listBox2.Items.Cast<object>());
                MessageBox.Show($"Συγχαρητήρια! Η σειρά προτεραιότητας άλλαξε με επιτυχία: {items}", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

