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
    public partial class C2 : Form
    {
        public C2()
        {
            InitializeComponent();
        }

        private void C2_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(1050, 450);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainCustomer mainCustomer = new MainCustomer();
            mainCustomer.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            C2tickets mainTickets = new C2tickets();
            mainTickets.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C2tickets mainTickets = new C2tickets();
            mainTickets.Show();
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            C2tickets mainTickets = new C2tickets();
            mainTickets.Show();
            Visible = false;
        }
        //η C2 να γινεται πιο θολη και μετα να εμφανιζεται (modal)
        private void button1_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (C2a uu = new C2a())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (C2b uu = new C2b())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (C2c uu = new C2c())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (C2a uu = new C2a())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (C2b uu = new C2b())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

            Form formBackground = new Form();
            try
            {
                using (C2c uu = new C2c())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }


        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = SystemColors.Highlight;
            label17.Font = new Font(label17.Font, FontStyle.Italic | FontStyle.Underline);
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = SystemColors.Highlight;
            label18.Font = new Font(label18.Font, FontStyle.Italic | FontStyle.Underline);
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.ForeColor = SystemColors.Highlight;
            label19.Font = new Font(label19.Font, FontStyle.Italic | FontStyle.Underline);
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.DarkSlateBlue;
            label17.Font = new Font(label17.Font, FontStyle.Italic);
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.DarkSlateBlue;
            label18.Font = new Font(label18.Font, FontStyle.Italic);
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = Color.DarkSlateBlue;
            label19.Font = new Font(label19.Font, FontStyle.Italic);
        }
    }
}
