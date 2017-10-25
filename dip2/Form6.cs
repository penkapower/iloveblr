using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using dip2.Properties;
using WMPLib;

namespace dip2
{
    
    public partial class Form6 : Form
    {
        int eea = 1,cls=0;
        int t=0;
        string otvet;
        double a, a1, b, b1, z, x;
        public Form6()
        {   
            InitializeComponent();
            this.BackgroundImage = Resources.nature8seri;
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            int f, f3, f4,f5;
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
                f = (Convert.ToInt32(pictureBox1.Height * x) - pictureBox1.Height);
                f3 = (Convert.ToInt32(pictureBox9.Height * x) - pictureBox9.Height);
                f4 = (Convert.ToInt32(pictureBox8.Height * x) - pictureBox8.Height);
                f5 = (Convert.ToInt32(pictureBox4.Height * x) - pictureBox4.Height);
                pictureBox1.Location = new Point(Location.X + pictureBox1.Location.X, Location.Y + (pictureBox1.Location.Y - f));
                label3.Location = new Point( ((Convert.ToInt16(a)-label3.Width)/2), Location.Y+200);
                pictureBox2.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + label3.Height + 220);
                pictureBox3.Location = new Point(Location.X + pictureBox1.Width, Location.Y + (pictureBox3.Location.Y - f));
                pictureBox1.Size = new Size(Convert.ToInt32(pictureBox1.Width * z), Convert.ToInt32(pictureBox1.Height * x));
                pictureBox3.Size = new Size(Convert.ToInt32(pictureBox3.Width * z), Convert.ToInt32(pictureBox3.Height * x));
                pictureBox9.Size = new Size(Convert.ToInt32(pictureBox9.Width * (z / 1.5)), Convert.ToInt32(pictureBox9.Height * x));
                pictureBox8.Size = new Size(Convert.ToInt32(pictureBox8.Width * (z / 1.5)), Convert.ToInt32(pictureBox8.Height * x));
                pictureBox9.Location = new Point(Location.X + pictureBox9.Location.X, Location.Y + (pictureBox9.Location.Y - f3));
                pictureBox8.Location = new Point(Location.X + pictureBox8.Location.X, Location.Y + (pictureBox8.Location.Y - f4));
                pictureBox4.Location = new Point(((Convert.ToInt16(a) - pictureBox4.Width) / 2), pictureBox9.Location.Y);

                label2.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200);
                label5.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width), Location.Y + 200);
                label6.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width), Location.Y + 200);
                label7.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width), Location.Y + 200);
                label4.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200);
                pictureBox30.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200 + label2.Height);
                pictureBox31.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200 + label2.Height);
                pictureBox12.Location = new Point(pictureBox2.Location.X + ((pictureBox2.Width - pictureBox12.Width) / 2), Location.Y + label3.Height + pictureBox2.Height + 240);
                pictureBox13.Location = new Point(pictureBox2.Location.X + ((pictureBox2.Width - pictureBox13.Width) / 2), Location.Y + label3.Height + pictureBox2.Height + 240);
            }
        }
        public void quas()
        {
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/yesno/q/").GetFiles().Length.ToString()))
            {
                label1.Text = (File.ReadAllText("files/yesno/q/" + eea + ".txt", Encoding.Default));
                otvet = (File.ReadAllText("files/yesno/a/" + eea + ".txt", Encoding.Default));
            }
            eea++;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox13.Hide();
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox30.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox31.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox13.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            pictureBox8.Visible = false;
            pictureBox4.Visible = false;
            pictureBox9.Visible = false;
            label1.Visible = false;
            pictureBox9.Hide();
            
            Random team = new Random();
            t = team.Next(1, 3);

            if (t == 1)
            {
                label3.Text = (Program.team1);
                pictureBox2.Load(Program.logo1);

            }
            if (t == 2)
            {
                label3.Text = (Program.team2);
                pictureBox2.Load(Program.logo2);
            }
        }
        public WindowsMediaPlayer win = new WindowsMediaPlayer();
        public WindowsMediaPlayer lose = new WindowsMediaPlayer();
        public WindowsMediaPlayer attention = new WindowsMediaPlayer();
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
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
            quas();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            label1.Font = new Font(label1.Font, FontStyle.Regular);
            label1.ForeColor = Color.Black;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox8.Visible = true;
            label1.Visible = true;
            label3.Visible = false;
            pictureBox2.Visible = false;
            quas();
            timer1.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                Program.score1 = Program.score1 + 1;
                label3.Text = (Program.team2);
                pictureBox2.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox2.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                Program.score2 = Program.score2 + 1;
                label3.Text = (Program.team1);
                pictureBox2.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox2.Visible = true;
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
                pictureBox2.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox2.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                label3.Text = (Program.team1);
                pictureBox2.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox2.Visible = true;
                label3.Visible = true;
                timer1.Enabled = true;
                t = 1;
            }
            timer3.Enabled = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/yesno/q/").GetFiles().Length.ToString()))
            {
                if (otvet == "Нет" || otvet == "НЕТ")
                {
                    label1.Text = "ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Green;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    win.URL = ("files/sound/win.mp3");
                    win.controls.play();
                    timer2.Enabled = true;
                }
                else
                {
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
                if (otvet == "Нет" || otvet == "НЕТ")
                {
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
                    label1.Text = "НЕ ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Red;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    lose.URL = ("files/sound/lose.mp3");
                    lose.controls.play();
                    timer4.Enabled = true;
                }
              }
            }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/yesno/q/").GetFiles().Length.ToString()))
            {
                if (otvet == "Да" || otvet == "ДА")
                {
                    label1.Text = "ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Green;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    win.URL = ("files/sound/win.mp3");
                    win.controls.play();
                    timer2.Enabled = true;
                }
                else
                {
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
                if (otvet == "Да" || otvet == "ДА")
                {
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
                    label1.Text = "НЕ ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Red;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    lose.URL = ("files/sound/lose.mp3");
                    lose.controls.play();
                    timer4.Enabled = true;
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            attention.URL=("files/sound/attention.mp3");
            attention.controls.play();
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
            pictureBox4.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            label1.Visible = false;
            label3.Text = "Блиц-опрос";
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

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Show();
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            quas();
            pictureBox2.Visible = false;
            label3.Visible = false;
            this.BackgroundImage = Resources.nature;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox8.Visible = true;
            label1.Visible = true;
            pictureBox13.Hide();
            pictureBox12.Hide();
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
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