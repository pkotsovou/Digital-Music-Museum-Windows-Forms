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
    public partial class C2b : Form
    {
        public C2b()
        {
            InitializeComponent();
        }

        private void C2b_Load(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(570, 440);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C2.ActiveForm?.Show();
            Close();
        }
    }
}
