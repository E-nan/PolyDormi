using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poly_Dormitory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Halla_Click(object sender, EventArgs e)
        {
            Halla h = new Halla();
            h.Show();
        }

        private void BaekDu_Click(object sender, EventArgs e)
        {
            Baekdu b = new Baekdu();
            b.Show();
        }
    }
}
