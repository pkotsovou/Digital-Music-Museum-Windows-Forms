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
    public partial class C3cafe : Form
    {
        public C3cafe()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            listBox3.AllowDrop = true;
            listBox4.AllowDrop = true;
            listBox5.AllowDrop = true;
            listBox6.AllowDrop = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            C3 f = new C3();
            f.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            C2kalathi f = new C2kalathi();
            f.PreviousMainForm = this;
            f.Show();
            this.Visible = false;
        }

        private void C3cafe_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1010, 450);
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label2.Text = "\"Διαλέξτε τύπο γεύματος αναλόγως την ώρα της ημέρας\"";
            label2.Location = new Point(300, 70);
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "\"Διαλέξτε ό,τι επιθυμείτε να φάτε ή να πιείτε από την λίστα και τοποθετείστε τα στο κουτί\"";
            label2.Location = new Point(300, 70);
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            listBox1.Visible = true;
            listBox2.Visible = true;
            button7.Visible = true;
            button8.Visible = true; 


        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }else
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

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            label3.Visible = false;
            label2.Text = "\"Διαλέξτε τύπο γεύματος αναλόγως την ώρα της ημέρας\"";
            label2.Location = new Point(300, 70);
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            button7.Visible = false;
            listBox2.Items.Clear();
            listBox4.Items.Clear();
            listBox4.Visible = false;
            listBox3.Visible = false;
            listBox6.Items.Clear();
            listBox6.Visible = false;
            listBox5.Visible = false;
        }
       
        private void button8_Click(object sender, EventArgs e)
        {
            
            if (listBox2.Items.Count == 0 && listBox4.Items.Count == 0 && listBox6.Items.Count == 0)
            {
                MessageBox.Show("Παρακαλώ προσθέστε κάποιο γεύμα ή ρόφημα που επιθυμείτε","",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {

                DialogResult result = MessageBox.Show("Επιτυχής προσθήκη στο καλάθι! Θέλετε να μεταφερθείτε στο καλάθι;", "Επιτυχία", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    C2kalathi f = new C2kalathi();
                    f.PreviousMainForm = this;
                    f.Show();
                    this.Visible = false;
                }
                else if (result == DialogResult.No)
                {
                    C3cafe c3cafe = new C3cafe();
                    c3cafe.Show();
                    Visible = false;

                }


            }
            
            listBox2.Items.Clear();
            listBox4.Items.Clear();
            listBox6.Items.Clear();
            
        }


        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            listBox4.DoDragDrop(listBox3.SelectedItem.ToString(), DragDropEffects.Copy);

        }

        private void listBox3_DragEnter(object sender, DragEventArgs e)
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

        private void listBox3_DragDrop(object sender, DragEventArgs e)
        {
            listBox4.Items.Remove(e.Data.GetData(DataFormats.Text));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "\"Διαλέξτε ό,τι επιθυμείτε να φάτε ή να πιείτε από την λίστα και τοποθετείστε τα στο κουτί\"";
            label2.Location = new Point(300, 70);
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            listBox3.Visible = true;
            listBox4.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            listBox3.DoDragDrop(listBox3.SelectedItem.ToString(), DragDropEffects.Copy);

        }

        private void listBox4_DragEnter(object sender, DragEventArgs e)
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

        private void listBox4_DragDrop(object sender, DragEventArgs e)
        {
            listBox4.Items.Add(e.Data.GetData(DataFormats.Text));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_MouseDown(object sender, MouseEventArgs e)
        {
            listBox6.DoDragDrop(listBox5.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBox6_DragEnter(object sender, DragEventArgs e)
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

        private void listBox6_DragDrop(object sender, DragEventArgs e)
        {
            listBox6.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void listBox6_MouseDown(object sender, MouseEventArgs e)
        {
            listBox5.DoDragDrop(listBox5.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBox5_DragDrop(object sender, DragEventArgs e)
        {
            listBox6.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void listBox5_DragEnter(object sender, DragEventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "\"Διαλέξτε ό,τι επιθυμείτε να φάτε ή να πιείτε από την λίστα και τοποθετείστε τα στο κουτί\"";
            label2.Location = new Point(300, 70);
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            listBox5.Visible = true;
            listBox6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

      
    }
}
