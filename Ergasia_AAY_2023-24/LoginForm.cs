using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ergasia_AAY_2023_24
{
    public partial class LoginForm : Form
    {
        public static int UserRole { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(650, 450);
        }

        private void login_RegisterHere_Click(object sender, EventArgs e)
        {

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckUser(string enteredUsername, string enteredPassword, int userType)
        {
            string fileName = "users.txt";

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

                        // Ανάλυση των πληροφοριών και σύγκριση με το εισαγόμενο όνομα χρήστη και κωδικό πρόσβασης
                        string username = userInfo[1].Split(':')[1].Trim();
                        string password = userInfo[2].Split(':')[1].Trim();
                        int role = int.Parse(userInfo[3].Split(':')[1].Trim());

                        if (enteredUsername == username && enteredPassword == password && userType == role)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string enterUsername = textBoxLoginUsernmane.Text;
            string enterPassword = textBoxLoginPassword.Text;
            
            if ( comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                if (CheckUser(enterUsername, enterPassword, comboBox1.SelectedIndex))
                {
                    // Εάν ο έλεγχος είναι επιτυχής, ανακτούμε το ρόλο του χρήστη από το αρχείο
                    int userRole = GetUserRole(enterUsername, enterPassword);

                    // Αποθηκεύουμε τον ρόλο του χρήστη στο LoginForm
                    UserRole = userRole;
                
                    // Ανοίγουμε την κατάλληλη φόρμα ανάλογα με τον ρόλο
                    if (userRole== 0)
                    {
                        MainCustomer f = new MainCustomer(userRole);
                        f.Show();
                        this.Hide();
                    }
                    else if (userRole == 1)
                    {
                        MainEmployee ff = new MainEmployee(userRole);
                        ff.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Λάθος όνομα χρήστη ή κωδικός πρόσβασης.\nΒεβαιωθείτε οτι έχετε δημιουργήσει λογαριασμό!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            else
            {
                MessageBox.Show("Επιλέξτε τον τύπο του λογαριασμού (Πελάτης ή Εργαζόμενος).", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetUserRole(string enteredUsername, string enteredPassword)
        {
            string fileName = "users.txt";

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

                        // Ανάλυση των πληροφοριών και σύγκριση με το εισαγόμενο όνομα χρήστη και κωδικό πρόσβασης
                        string username = userInfo[1].Split(':')[1].Trim();
                        string password = userInfo[2].Split(':')[1].Trim();

                        if (enteredUsername == username && enteredPassword == password)
                        {
                            return int.Parse(userInfo[3].Split(':')[1].Trim());
                        }
                    }
                }
            }
            return -1; // Επιστρέφει -1 αν κάτι πάει στραβά
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxLoginPassword.UseSystemPasswordChar = true;
            }else
            {
                textBoxLoginPassword.UseSystemPasswordChar = false;

            }
        }

        private void login_RegisterHere_MouseEnter(object sender, EventArgs e)
        {
            login_RegisterHere.ForeColor = SystemColors.Highlight; 
            login_RegisterHere.Font = new Font(login_RegisterHere.Font, FontStyle.Italic | FontStyle.Underline);
        }

        private void login_RegisterHere_MouseLeave(object sender, EventArgs e)
        {
            login_RegisterHere.ForeColor = SystemColors.GrayText; 
            login_RegisterHere.Font = new Font(login_RegisterHere.Font, FontStyle.Bold );
        }

        private void textBoxLoginUsernmane_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBoxLoginPassword.Focus();
                textBoxLoginPassword.SelectAll();
            }
        }

        private void textBoxLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus(); // Επικεντρώνει το ComboBox όταν πατηθεί το Enter στο TextBox
            }
        }
    }
}
