using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace dip2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            timer1.Interval = 20;
            timer2.Interval = 20;
        }

   



        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            Program.backsound.PlayLooping(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity == 1)
            {
                this.timer1.Stop();
                this.timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity == 0)
            {
                this.Hide();
                this.timer2.Stop();
                Form fr2sh = new Form2();
                fr2sh.Show();
            }
        }
    }
}
