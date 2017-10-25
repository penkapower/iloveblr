using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using dip2.Properties;
using WMPLib;

namespace dip2
{
    public partial class Form8 : Form
    {
        int eea = 1,cls=0;
        int t = 0;
        string otvet;
        int f, f3, f4, f5, f6,f8,f9;
        double a, a1, b, b1, z, x;
        public Form8()
        {
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            this.BackgroundImage = Resources.nature8seri;
            a = System.Windows.SystemParameters.PrimaryScreenWidth;
            b = System.Windows.SystemParameters.PrimaryScreenHeight;
            if (a == 1024)
            { }
            else
            {
                a1 = 1024;
                b1 = 768;
                z = (a / a1);
                f = (Convert.ToInt32(pictureBox2.Width * z) - pictureBox2.Width);
                f3 = (Convert.ToInt32(pictureBox4.Height * (z / 1.5)) - pictureBox4.Height);
                f4 = (Convert.ToInt32(pictureBox5.Height * (z / 1.5)) - pictureBox5.Height);
                f5 = (Convert.ToInt32(pictureBox8.Height * (z / 1.5)) - pictureBox8.Height);
                f6 = (Convert.ToInt32(pictureBox9.Height * (z / 1.5)) - pictureBox9.Height);
                f8 = (Convert.ToInt32(label1.Width * z) - label1.Width);
                f9 = (Convert.ToInt32(label2.Width * z) - label2.Width);
                pictureBox2.Location = new Point(Location.X + (pictureBox2.Location.X - f), Location.Y - 0);
                pictureBox4.Location = new Point(Location.X + pictureBox4.Location.X, Location.Y + (pictureBox4.Location.Y - f3));
                pictureBox5.Location = new Point(Location.X + pictureBox5.Location.X, Location.Y + (pictureBox5.Location.Y - f4));
                pictureBox8.Location = new Point(Location.X + pictureBox8.Location.X, Location.Y + (pictureBox8.Location.Y - f5));
                pictureBox9.Location = new Point(Location.X + pictureBox9.Location.X, Location.Y + (pictureBox9.Location.Y - f6));
                x = (b / b1);
                pictureBox2.Size = new Size(Convert.ToInt32(pictureBox2.Width * z), Convert.ToInt32(pictureBox2.Height * x));
                pictureBox1.Size = new Size(Convert.ToInt32(pictureBox1.Width * z), Convert.ToInt32(pictureBox1.Height * x)-1);
                label1.Size = new Size(Convert.ToInt32(label1.Width * z), Convert.ToInt32(label1.Height * x));
                label2.Size = new Size(Convert.ToInt32(label2.Width * z)-2, Convert.ToInt32(label2.Height * x));
                label1.Location = new Point(pictureBox1.Width,Location.Y);
                label2.Location = new Point(pictureBox1.Width, Location.Y+(label1.Height/2));
                pictureBox8.Size = new Size(Convert.ToInt32(pictureBox8.Width * (z / 1.5)), Convert.ToInt32(pictureBox8.Height * x));
                pictureBox9.Size = new Size(Convert.ToInt32(pictureBox9.Width * (z / 1.5)), Convert.ToInt32(pictureBox9.Height * x));
                pictureBox4.Size = new Size(Convert.ToInt32(pictureBox4.Width * (z / 1.5)), Convert.ToInt32(pictureBox4.Height * x));
                pictureBox5.Size = new Size(Convert.ToInt32(pictureBox5.Width * (z / 1.5)), Convert.ToInt32(pictureBox5.Height * x));
                label3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + 200);
                pictureBox3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + label3.Height + 220);
                
                label8.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200);
                label5.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label8.Width), Location.Y + 200);
                label6.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label8.Width + label5.Width), Location.Y + 200);
                label7.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label8.Width + label5.Width + label6.Width), Location.Y + 200);
                label4.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label8.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200);
                pictureBox30.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200 + label8.Height);
                pictureBox31.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label8.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200 + label8.Height);
                pictureBox14.Location = new Point(pictureBox3.Location.X + ((pictureBox3.Width - pictureBox14.Width) / 2), Location.Y + label3.Height + pictureBox3.Height + 240);
                pictureBox15.Location = new Point(pictureBox3.Location.X + ((pictureBox3.Width - pictureBox15.Width) / 2), Location.Y + label3.Height + pictureBox3.Height + 240);
        }
            
        }
        public void quas()
        {
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/translate/q/").GetFiles().Length.ToString()))
            {
                label2.Text = (File.ReadAllText("files/translate/q/" + eea + ".txt", Encoding.Default));
                otvet = (File.ReadAllText("files/translate/a/" + eea + ".txt", Encoding.Default));
            }
            eea++;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox30.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox31.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox14.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox15.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox15.Hide();
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox7.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label8.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            Random team = new Random();
            t = team.Next(1, 3);

            if (t == 1)
            {
                label3.Text = (Program.team1);
                pictureBox3.Load(Program.logo1);

            }
            if (t == 2)
            {
                label3.Text = (Program.team2);
                pictureBox3.Load(Program.logo2);
            }
        }
        public WindowsMediaPlayer win = new WindowsMediaPlayer();
        public WindowsMediaPlayer lose = new WindowsMediaPlayer();
        public WindowsMediaPlayer attention = new WindowsMediaPlayer();

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            DialogResult result = MessageBox.Show("Вы действительно хотите закночить игру и вернуться в главное меню?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cls = 1;
                Program.pic14 = 0;
                Program.pic13 = 0;
                Program.pic15 = 0;
                Program.pic16 = 0;
                Program.logo1 = "";
                Program.logo2 = "";
                Program.score1 = 0;
                Program.score2 = 0;
                Program.team1 = "";
                Program.team2 = "";
                Program.vib = 0;
                Program.back = 1;
                Close();
            }
            else
            {
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cls == 0)
            {
                Form fr4sh = new Form4();
                fr4sh.Show();
            }
            if (cls == 1)
            {
                Form fr2sh = new Form2();
                fr2sh.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
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
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/translate/q/").GetFiles().Length.ToString()))
            {
                if (textBox1.Text == otvet)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    textBox1.Clear();
                    textBox1.Enabled = false;
                    label2.Text = "ПРАВИЛЬНО!";
                    label2.ForeColor = Color.Green;
                    label2.Font = new Font(label1.Font, FontStyle.Underline);
                    win.URL = ("files/sound/win.mp3");
                    win.controls.play();
                    timer2.Enabled = true;
                }
                else
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox3.Visible = false;
                    textBox1.Clear();
                    textBox1.Enabled = false;
                    label2.Text = "НЕ ПРАВИЛЬНО!";
                    label2.ForeColor = Color.Red;
                    label2.Font = new Font(label1.Font, FontStyle.Underline);
                    lose.URL = ("files/sound/lose.mp3");
                    lose.controls.play();
                    timer3.Enabled = true;
                }
            }
            else
            {
                if (textBox1.Text == otvet)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    textBox1.Clear();
                    textBox1.Enabled = false;
                    label2.Text = "ПРАВИЛЬНО!";
                    label2.ForeColor = Color.Green;
                    label2.Font = new Font(label1.Font, FontStyle.Underline);
                    win.URL = ("files/sound/win.mp3");
                    win.controls.play();
                    if (t == 1)
                    {
                        Program.score1 = Program.score1 + 1;
                        timer4.Enabled = true;
                    }
                    else if (t == 2)
                    {
                        Program.score2 = Program.score2 + 1;
                        timer4.Enabled = true;
                    }
                }
                else
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    textBox1.Clear();
                    textBox1.Enabled = false;
                    label2.Text = "НЕ ПРАВИЛЬНО!";
                    label2.ForeColor = Color.Red;
                    label2.Font = new Font(label1.Font, FontStyle.Underline);
                    lose.URL = ("files/sound/lose.mp3");
                    lose.controls.play();
                    timer4.Enabled = true;
                }
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            attention.URL = ("files/sound/attention.mp3");
            attention.controls.play();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                label3.Text = (Program.team2);
                pictureBox3.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox7.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox3.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                label3.Text = (Program.team1);
                pictureBox3.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox7.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox3.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 1;
            }
            timer3.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                Program.score1 = Program.score1 + 1;
                label3.Text = (Program.team2);
                pictureBox3.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox7.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox3.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                Program.score2 = Program.score2 + 1;
                label3.Text = (Program.team1);
                pictureBox3.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox7.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox3.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 1;
            }
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            label2.Font = new Font(label1.Font, FontStyle.Regular);
            label2.ForeColor = Color.Black;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = true;
            pictureBox8.Visible = true;
            pictureBox7.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Focus();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            pictureBox3.Visible = false;
            quas();
            timer1.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox5_Click(sender, e);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label8.Text = (Program.team1);
            pictureBox30.Load(Program.logo1);
            label4.Text = (Program.team2);
            pictureBox31.Load(Program.logo2);
            this.BackgroundImage = Resources.nature8seri;
            label5.Text = Convert.ToString(Program.score1);
            label7.Text = Convert.ToString(Program.score2);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox7.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Text = "Родная мова";
            label3.Visible = true;
            label3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + 100);
            label8.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            timer5.Enabled = true;
            timer4.Enabled = false;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.Show();
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            quas();
            pictureBox3.Visible = false;
            label3.Visible = false;
            this.BackgroundImage = Resources.nature;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = true;
            pictureBox8.Visible = true;
            pictureBox7.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Focus();
            label1.Visible = true;
            label2.Visible = true;
            pictureBox14.Hide();
            pictureBox15.Hide();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
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
    }
}
