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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ergasia_AAY_2023_24
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(650, 450);
        }

        private void register_loginHere_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
            this.Hide();
        }

        private void register_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddUser(string email, string username, string password, int userType)
        {
            string fileName = "users.txt";

            // Χρήση της κλάσης StreamWriter για εγγραφή στο αρχείο
            using (StreamWriter sw = File.AppendText(fileName))
            {
                // Γράφει τις πληροφορίες του χρήστη στο αρχείο
                sw.WriteLine($"Email: {email}, Username: {username}, Password: {password}, Role: {userType}");
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string enterEmail = textBoxEmail.Text;
            string enterUsername = textBoxRegisterUsername.Text;
            string enterPassword = textBoxRegisterPassword.Text;
            // Έλεγχος για κενά πεδία
            if (string.IsNullOrEmpty(enterEmail) || string.IsNullOrEmpty(enterUsername) || string.IsNullOrEmpty(enterPassword))
            {
                MessageBox.Show("Συμπληρώστε όλα τα πεδία πριν προχωρήσετε στην εγγραφή.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                if (!CheckUsernameExists(enterUsername))
                {
                    AddUser(enterEmail, enterUsername, enterPassword, comboBox1.SelectedIndex);
                    MessageBox.Show("Επιτυχής δημιουργία λογαριασμού!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Το όνομα χρήστη υπάρχει ήδη. Επιλέξτε διαφορετικό όνομα χρήστη.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("Επιλέξτε τον τύπο του λογαριασμού (Πελάτης ή Εργαζόμενος).", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckUsernameExists(string username)
        {
            string fileName = "users.txt";

            // Έλεγχος αν το αρχείο υπάρχει πριν τον έλεγχο του χρήστη
            if (File.Exists(fileName))
            {
                // Χρήση της κλάσης StreamReader για ανάγνωση από το αρχείο
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Διαχωρισμός των πληροφοριών του χρήστη
                        string[] userInfo = line.Split(',');

                        // Ανάλυση των πληροφοριών και σύγκριση με το εισαγόμενο όνομα χρήστη
                        string existingUsername = userInfo[1].Split(':')[1].Trim();

                        if (username == existingUsername)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void checkBoxRegShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRegShowPass.Checked)
            {
                textBoxRegisterPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxRegisterPassword.UseSystemPasswordChar = false;

            }
        }

        private void register_loginHere_MouseEnter(object sender, EventArgs e)
        {
            register_loginHere.ForeColor = SystemColors.Highlight;
            register_loginHere.Font = new Font(register_loginHere.Font, FontStyle.Italic | FontStyle.Underline);
        }

        private void register_loginHere_MouseLeave(object sender, EventArgs e)
        {
          
            register_loginHere.ForeColor = SystemColors.GrayText;
            register_loginHere.Font = new Font(register_loginHere.Font, FontStyle.Bold);


        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxRegisterUsername.Focus();
                textBoxRegisterUsername.SelectAll(); 
            }
        }

     

        private void textBoxRegisterPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus(); 
            }
        }

        private void textBoxRegisterUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxRegisterPassword.Focus();
                textBoxRegisterPassword.SelectAll();
            }
        }
    }
}
