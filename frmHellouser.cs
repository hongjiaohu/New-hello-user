using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_user
{
    public partial class frmHellouser : Form
    {
        public frmHellouser()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            /**

 *

 * Name: Hongjiao Hu

 * Teacher: Mr. Hardman
 
 * Assignment #2, Program #1

 * Date Last Modified: 10/14/2016

 *

 */


            //user input
            double input1 = Convert.ToDouble(txtOutput1.Text);
            double input2 = Convert.ToDouble(txtOutput2.Text);

            double total = input1 * 12 + input2;

            //computer display
            lblDispaly.Text = string.Format("{0,10}{1,15:C2}\n{2,10}{3,15:C2}\n{4,10}{5,15:C2}",
                "Monthly wages", input1, "Year-end bonuses", input2, "Total:", total);
        }

        private void lblDispaly_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
