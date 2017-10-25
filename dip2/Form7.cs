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
    public partial class Form7 : Form
    {
        int eea = 1,cls=0;
        int t = 0;
        string otvet;
        double a, a1, b, b1, z, x;
        public Form7()
        {
            InitializeComponent();
            this.BackgroundImage = Resources.nature8seri;
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            int f, f1;
            a = System.Windows.SystemParameters.PrimaryScreenWidth;
            b = System.Windows.SystemParameters.PrimaryScreenHeight;
            if (a == 1024)
            {
            }
            else
            {
                a1 = 1024;
                b1 = 768;
                z = (a / a1);
                x = (b / b1);
                f = (Convert.ToInt32(pictureBox1.Width * z) - pictureBox1.Width);
                f1 = (Convert.ToInt32(pictureBox9.Height * x) - pictureBox9.Height);
                //left
                pictureBox1.Size = new Size(Convert.ToInt32(pictureBox1.Width * z), Convert.ToInt32(pictureBox1.Height * x));
                pictureBox2.Size = new Size(Convert.ToInt32(pictureBox2.Width * z), Convert.ToInt32(pictureBox2.Height * x));
                pictureBox2.Location = new Point(Location.X+1,pictureBox1.Height);
                ////right
                pictureBox10.Size = new Size(Convert.ToInt32(pictureBox10.Width * z), Convert.ToInt32(pictureBox10.Height * x));
                pictureBox11.Size = new Size(Convert.ToInt32(pictureBox11.Width * z), Convert.ToInt32(pictureBox11.Height * x));
                pictureBox10.Location = new Point(Location.X + (pictureBox10.Location.X - f),pictureBox11.Height);
                pictureBox11.Location = new Point(Location.X + (pictureBox11.Location.X - f), Location.Y + 1);
                ////mid
                pictureBox12.Size = new Size((Convert.ToInt16(a) - pictureBox1.Width - pictureBox11.Width+1), Convert.ToInt32(pictureBox12.Height * x));
                pictureBox3.Size = new Size((Convert.ToInt16(a) - pictureBox1.Width - pictureBox11.Width + 1), Convert.ToInt32(pictureBox1.Height + pictureBox2.Height - pictureBox12.Height+1));
                label1.Size = new Size((Convert.ToInt16(a) - pictureBox1.Width - pictureBox11.Width + 1), Convert.ToInt32(pictureBox1.Height + pictureBox2.Height - pictureBox12.Height + 1));
                label1.Location = new Point(pictureBox1.Width, Location.Y + pictureBox12.Height);
                pictureBox3.Location = new Point(pictureBox1.Width, Location.Y + pictureBox12.Height);
                pictureBox12.Location = new Point( pictureBox1.Width, Location.Y + 0);
                ////кнопки
                pictureBox4.Location = new Point(Location.X + pictureBox4.Location.X, Location.Y + (pictureBox4.Location.Y - f1));
                pictureBox5.Location = new Point(Location.X + pictureBox5.Location.X, Location.Y + (pictureBox5.Location.Y - f1));
                pictureBox8.Location = new Point(Location.X + pictureBox8.Location.X, Location.Y + (pictureBox8.Location.Y - f1));
                pictureBox9.Location = new Point(Location.X + pictureBox9.Location.X, Location.Y + (pictureBox9.Location.Y - f1));
                pictureBox4.Size = new Size(Convert.ToInt32(pictureBox4.Width * (z / 1.5)), Convert.ToInt32(pictureBox4.Height * x));
                pictureBox5.Size = new Size(Convert.ToInt32(pictureBox5.Width * (z / 1.5)), Convert.ToInt32(pictureBox5.Height * x));
                pictureBox8.Size = new Size(Convert.ToInt32(pictureBox8.Width * (z / 1.5)), Convert.ToInt32(pictureBox8.Height * x));
                pictureBox9.Size = new Size(Convert.ToInt32(pictureBox9.Width * (z / 1.5)), Convert.ToInt32(pictureBox9.Height * x));
                label3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + 200);
                pictureBox6.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + label3.Height + 220);
 
                label2.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200);
                label5.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width), Location.Y + 200);
                label6.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width), Location.Y + 200);
                label7.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width), Location.Y + 200);
                label4.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200);
                pictureBox30.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200 + label2.Height);
                pictureBox31.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200 + label2.Height);
                pictureBox14.Location = new Point(pictureBox6.Location.X + ((pictureBox6.Width - pictureBox14.Width) / 2), Location.Y + label3.Height + pictureBox6.Height + 240);
                pictureBox15.Location = new Point(pictureBox6.Location.X + ((pictureBox6.Width - pictureBox15.Width) / 2), Location.Y + label3.Height + pictureBox6.Height + 240);
            }
        }
        public WindowsMediaPlayer win = new WindowsMediaPlayer();
        public WindowsMediaPlayer lose = new WindowsMediaPlayer();
        public WindowsMediaPlayer attention = new WindowsMediaPlayer();
        public void quas()
        {
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/who/q/").GetFiles().Length.ToString()))
            {
                pictureBox3.Load("files/who/q/" + eea + ".jpg");
                otvet = (File.ReadAllText("files/who/a/" + eea + ".txt", Encoding.Default));
            }
            eea++;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox30.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox31.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox14.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox15.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox15.Hide();
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            pictureBox12.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            Random team = new Random();
            t = team.Next(1, 3);

            if (t == 1)
            {
                label3.Text = (Program.team1);
                pictureBox6.Load(Program.logo1);

            }
            if (t == 2)
            {
                label3.Text = (Program.team2);
                pictureBox6.Load(Program.logo2);
            }
        }

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/who/q/").GetFiles().Length.ToString()))
            {
                if (textBox1.Text == otvet)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox3.Visible = false;
                    label1.Visible = true;
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    label1.Text = "ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Green;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    win.URL = ("files/sound/win.mp3");
                    win.controls.play();
                    timer2.Enabled = true;
                }
                else
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox3.Visible = false;
                    label1.Visible = true;
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    label1.Text = "НЕ ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Red;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
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
                    pictureBox3.Visible = false;
                    label1.Visible = true;
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    label1.Text = "ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Green;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
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
                    pictureBox3.Visible = false;
                    label1.Visible = true;
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    label1.Text = "НЕ ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Red;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    lose.URL = ("files/sound/lose.mp3");
                    lose.controls.play();
                    timer4.Enabled = true;
                }
            }
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
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
            };
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            label1.Font = new Font(label1.Font, FontStyle.Regular);
            label1.ForeColor = Color.Black;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox7.Visible = true;
            pictureBox10.Visible = true;
            pictureBox4.Visible = true;
            pictureBox8.Visible = true;
            pictureBox12.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Focus();
            label3.Visible = false;
            pictureBox6.Visible = false;
            quas();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                Program.score1 = Program.score1 + 1;
                label3.Text = (Program.team2);
                pictureBox6.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox4.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox12.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox6.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                Program.score2 = Program.score2 + 1;
                label3.Text = (Program.team1);
                pictureBox6.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox7.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox12.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox6.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 1;
            }
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                label3.Text = (Program.team2);
                pictureBox6.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox4.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox12.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox6.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                label3.Text = (Program.team1);
                pictureBox6.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox4.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox12.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox6.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 1;
            }
            timer3.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox5_Click(sender, e);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            attention.URL = ("files/sound/attention.mp3");
            attention.controls.play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = (Program.team1);
            pictureBox30.Load(Program.logo1);
            label4.Text = (Program.team2);
            pictureBox31.Load(Program.logo2);
            this.BackgroundImage = Resources.nature8seri;
            label5.Text = Convert.ToString(Program.score1);
            label7.Text = Convert.ToString(Program.score2);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox4.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            pictureBox12.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            label3.Text = "Известные люди";
            label3.Visible = true;
            label3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + 100);
            label2.Visible = true;
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
            label3.Visible = false;
            pictureBox6.Visible = false;
            pictureBox14.Hide();
            pictureBox15.Hide();
            this.BackgroundImage = Resources.nature;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox10.Visible = true;
            pictureBox7.Visible = true;
            pictureBox4.Visible = true;
            pictureBox8.Visible = true;
            pictureBox12.Visible = true;
            textBox1.Visible = true;
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
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
