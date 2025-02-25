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

namespace Ergasia_AAY_2023_24
{
    public partial class c1modal : Form
    {
        public c1modal()
        {
            InitializeComponent();
           
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }else
            {
                Opacity += .02;
            }
            
           
        }

        
        private void c1modal_Load(object sender, EventArgs e)
        {
           int i = C1.parentY + 150;

            this.Location = new Point(C1.parentX + 420, C1.parentY + 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public c1modal(string content)
        {
            InitializeComponent();

            label1.Text = content;

        }
       
    }
}
