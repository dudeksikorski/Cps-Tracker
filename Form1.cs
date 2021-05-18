using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cps_tracker
{
    public partial class Form1 : Form
    {

        int clicks = 0;
        double time = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void CLICKPRZYCISK_Click(object sender, EventArgs e)
        {

            if (time > 0)
            {
                clicks++;
                label1.Text = "CLICKS: " + clicks;
                timer1.Start();
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time -= 0.1;
                label3.Text = time.ToString();
            }
            else
            {

                label3.Text = "0";
                timer1.Stop();
                label2.Text = "CLICKS PER SECOND: " + ((double)clicks / 10).ToString();
                
            }


            
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            clicks = 0;
            time = 10;
            label3.Text = "10";
            label2.Text = "CLICKS PER SECOND: 0";
            label1.Text = "CLICKS: 0";

        }
    }
}
