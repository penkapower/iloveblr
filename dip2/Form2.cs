using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace dip2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            if (Program.backsoundpl == 1 && Program.back==1)
            {
                Program.backsound.Play();
                Program.back = 0;
            }
            else
            {

            }
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.Hide();
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.Hide();
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.Hide();
            pictureBox10.Hide();
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

      

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Hide();
        }

    

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string dir = "files/timefiles";
                foreach (string file in Directory.GetFiles(dir))
                File.Delete(file);
                Application.Exit();
            }
            else
            {
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Show();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Show();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            Form f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            Form fr4sh = new Form14();
            fr4sh.Show();
            this.Close();
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Show();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Hide();
        }

     
        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox10, "Справка");
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите выйти из игры?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"files/help/help.chm", HelpNavigator.TableOfContents);
        }
    }
}
