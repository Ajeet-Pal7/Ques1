using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ques1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(num1.Text != "" && num2.Text != "")
            {
                double n1 = 0, n2 = 0;
                n1 = Convert.ToDouble(num1.Text);
                n2 = Convert.ToDouble(num2.Text);
                MessageBox.Show("Sum of " + n1 + " and " + n2 + " = " + (n1 + n2));
            }
        }
    }
}
