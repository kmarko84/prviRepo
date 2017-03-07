using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Pozdrav. " +((Button)sender).Text + " dugme.", "Ovo je title");
            pgBar.Value += 10;
            if (pgBar.Value==100)
            {
                MessageBox.Show("Pozdrav. " + ((Button)sender).Text + " dugme.", "Ovo je title");

            }
            else
            {
                lblValue.Text = pgBar.Value+"";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pozdrav. " + ((Button)sender).Text + " dugme.", "Ovo je title");
        }
        private void btnStop_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblValue.Text = "0";
        }
    }
}
