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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ergasia_AAY_2023_24
{
    public partial class Karaoke : Form
    {
        private int userRole;

        public Karaoke()
        {
            InitializeComponent();
        }
        public Karaoke(int userRole)
        {
            InitializeComponent();
            this.userRole = userRole;

        }


        string tempname = "";
        string tempfile;
        List<string> templist;
        private void Karaoke_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(800, 400);
            string fileName = "names.txt";
            List<string> namesList = ReadNamesFromFile(fileName);
            if (namesList.Count > 0)
            {
                string randomName = GetRandomName(namesList);

                MessageBox.Show($"Αυτός/ή που θα ξεκινήσει το καραόκε πρώτος/η είναι ο/η : {randomName}");
                tempname = randomName;
                tempfile = fileName;
                templist = namesList;
            }
            else
            {
                Console.WriteLine($"Το αρχείο '{fileName}' είναι άδειο ή δεν υπάρχει.");
            }

            
           
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true; 
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            webBrowser1.Visible = false;
            label16.Visible = false;
            label17.Visible = true;
            button1.Visible = false;
            File.WriteAllText(fileName2, string.Empty);

        }

        static List<string> ReadNamesFromFile(string fileName)
        {
            List<string> namesList = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(fileName);
                namesList.AddRange(lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Σφάλμα κατά τη διάβαση του αρχείου: {ex.Message}");
            }

            return namesList;
        }
        static string GetRandomName(List<string> namesList)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, namesList.Count);
            string selectedName = namesList[randomIndex];
            namesList.RemoveAt(randomIndex);
            return selectedName;


        }
        private void button4_Click(object sender, EventArgs e)
        {
            C4E2 c4E2 = new C4E2(userRole);
            c4E2.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true; 
            label17.Visible = false;
            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "HeavenBryanAdams.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;



            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "HeavenBryanAdams.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;



            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "IWanttoBreakFreeQueen.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "IWanttoBreakFreeQueen.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "LetItBeThe Beatles.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "LetItBeThe Beatles.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "DoIWannaKnowArcticMonkeys.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "DoIWannaKnowArcticMonkeys.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "Pink FloydAnotherBrickInTheWall.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "Pink FloydAnotherBrickInTheWall.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "MyWayFrankSinatra.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = true;
            label17.Visible = false;

            webBrowser1.Visible = true;
            button1.Visible = true;
            button4.Visible = false;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(baseDirectory, "MyWayFrankSinatra.mp4");
            string html = $"<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'/><video width='600' height='300' controls><source src='{localFilePath}' type='video/mp4'>Your browser does not support the video tag.</video></head></html>";
            webBrowser1.DocumentText = html;
            Size = new System.Drawing.Size(800, 520);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(800, 400);

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            webBrowser1.Visible = false;
            label16.Visible = false;
            label17.Visible = true;
            button1.Visible = false;
            button4.Visible = true;
        }

        string fileName2 = "scores.txt";
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {


                string filePath2 = Path.Combine(Environment.CurrentDirectory, fileName2);

                try
                {

                    using (StreamWriter writer = new StreamWriter(filePath2, true))
                    {

                        writer.WriteLine(textBox1.Text);
                    }

                    MessageBox.Show($"Η βαθμολογία αποθηκεύτηκε με επιτυχία.");


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Σφάλμα κατά την αποθήκευση της βαθμολογίας");
                }

                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
            else if (int.TryParse(textBox1.Text + e.KeyChar, out int num) && (num < 0 || num > 10))
            {
                e.Handled = true;
            }
           
        }

        private bool button2Clicked = false;
        private int sessionTotalScore = 0;
        private int totalScore = 0;
        string filePath5 = "scores.txt";
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath5) && new FileInfo(filePath5).Length == 0)
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήστε μία βαθμολογία.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] scores = File.ReadAllLines(fileName2);

                int totalScore = 0;

                // Υπολογίζει το συνολικό άθροισμα των βαθμολογιών
                foreach (string score in scores)
                {
                    if (int.TryParse(score, out int parsedScore))
                    {
                        totalScore += parsedScore;
                    }
                    else
                    {
                        MessageBox.Show($"Μη έγκυρη βαθμολογία: {score}", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Επιστροφή χωρίς να εκτελεστεί ο υπόλοιπος κώδικας
                    }
                }
                int tempscore = totalScore;
                MessageBox.Show($"Η συνολική βαθμολογία είναι: {totalScore}");

                // Αν το κουμπί έχει πατηθεί τουλάχιστον μία φορά, προσθέστε το νέο σύνολο βαθμολογίας στο αρχείο
                string summaryFileName = "summary.txt";
                using (StreamWriter writer = new StreamWriter(summaryFileName, true))
                {
                    writer.WriteLine($"Όνομα: {tempname}, Συνολική Βαθμολογία: {tempscore}");
                }
                tempscore = 0;

                button2Clicked = true;

                if (templist.Count > 0)
                {
                    string randomName = GetRandomName(templist);

                    MessageBox.Show($"Αυτός/ή που θα συνεχίσει το καραόκε  είναι ο/η : {randomName}");
                    tempname = randomName;
                }
                else
                {
                    Console.WriteLine($"Το αρχείο '{tempfile}' είναι άδειο ή δεν υπάρχει.");
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] scoresLines = File.ReadAllLines("scores.txt");
                string summaryContent = File.ReadAllText("summary.txt");
                MessageBox.Show(summaryContent, "Summary"); 
        }
    }
}
