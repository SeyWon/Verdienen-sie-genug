using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verdienen_sie_genug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button2.Location = new Point(rnd.Next(50,750), rnd.Next(50, 750));


        }
    }
}
