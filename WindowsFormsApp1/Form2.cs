using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

   

        private void timer_Click(object sender, EventArgs e)
        {


        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    s = s - 1;
        //    if (s == -1)
        //    {
        //        m = m - 1;
        //        s = 59;
        //    }
        //    if (m == -1)
        //    {
        //        h = h - 1;
        //        m = 59;
        //    }
        //    if ((h == 0 && m == 0 && s == 0) & (v == 10))
        //    {
        //        timer1.Stop();

        //    }
        //}
     
        private void SAve_Click(object sender, EventArgs e)
        {
            string h = textBox4.Text;
            string m = textBox5.Text;
       
            string t = textBox2.Text;
            Form1 Main = this.Owner as Form1;
            if (Main != null)
            {
               Main.label1.Text= $"{h}" + ":" + $"{m}";
                Main.main.Text = t;
            }

       
            

        }

        private void otmena_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}