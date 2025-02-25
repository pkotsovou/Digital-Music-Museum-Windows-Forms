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
    public partial class C2c : Form
    {
        public C2c()
        {
            InitializeComponent();
        }

        private void C2c_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(600, 270);
            

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            C2.ActiveForm?.Show();
            Close();
        }

       
    }
}
