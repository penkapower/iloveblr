using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using dip2.Properties;
using WMPLib;
using System.IO;

namespace dip2
{
    public partial class Form5 : Form
    {
        int eea = 1,cls =0;
        int t = 0,time =0,pl;
        double a, a1, b, b1, z, x;
        string otvet;
        public Form5()
        {
            InitializeComponent();
            this.BackgroundImage = Resources.nature8seri;
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            int f, f3, f4, f5, f6;
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
                f = (Convert.ToInt32(pictureBox2.Width * z) - pictureBox2.Width);
                f3 = (Convert.ToInt32(pictureBox4.Height * (z / 1.5)) - pictureBox4.Height);
                f4 = (Convert.ToInt32(pictureBox5.Height * (z / 1.5)) - pictureBox5.Height);
                f5 = (Convert.ToInt32(pictureBox8.Height * (z / 1.5)) - pictureBox8.Height);
                f6 = (Convert.ToInt32(pictureBox9.Height * (z / 1.5)) - pictureBox9.Height);
                pictureBox2.Location = new Point(Location.X + (pictureBox2.Location.X - f), Location.Y - 0);
                pictureBox4.Location = new Point(Location.X + pictureBox4.Location.X, Location.Y + (pictureBox4.Location.Y - f3));
                pictureBox5.Location = new Point(Location.X + pictureBox5.Location.X, Location.Y + (pictureBox5.Location.Y - f4));
                pictureBox8.Location = new Point(Location.X + pictureBox8.Location.X, Location.Y + (pictureBox8.Location.Y - f5));
                pictureBox9.Location = new Point(Location.X + pictureBox9.Location.X, Location.Y + (pictureBox9.Location.Y - f6));
                label3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + 200);
                pictureBox11.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y + label3.Height + 220);
                x = (b / b1);
                pictureBox2.Size = new Size(Convert.ToInt32(pictureBox2.Width * z), Convert.ToInt32(pictureBox2.Height * x));
                pictureBox3.Size = new Size(Convert.ToInt32(pictureBox3.Width * z), Convert.ToInt32(pictureBox3.Height * x));
                label1.Location = new Point(pictureBox3.Width, Location.Y - 0);
                pictureBox1.Size = new Size(Convert.ToInt32(pictureBox1.Width * z), Convert.ToInt32(pictureBox1.Height * x));
                label1.Size = new Size(Convert.ToInt32(label1.Width * z), Convert.ToInt32(label1.Height * x));
                pictureBox8.Size = new Size(Convert.ToInt32(pictureBox8.Width * (z / 1.5)), Convert.ToInt32(pictureBox8.Height * x));
                pictureBox9.Size = new Size(Convert.ToInt32(pictureBox9.Width * (z / 1.5)), Convert.ToInt32(pictureBox9.Height * x));
                pictureBox4.Size = new Size(Convert.ToInt32(pictureBox4.Width * (z / 1.5)), Convert.ToInt32(pictureBox4.Height * x));
                pictureBox5.Size = new Size(Convert.ToInt32(pictureBox5.Width * (z / 1.5)), Convert.ToInt32(pictureBox5.Height * x));
                pictureBox10.Size = new Size(Convert.ToInt32(pictureBox10.Width * z), Convert.ToInt32(pictureBox10.Height * x));


                label2.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2-300), Location.Y + 200);
                label5.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300+label2.Width), Location.Y + 200);
                label6.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width+label5.Width), Location.Y + 200);
                label7.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width+label6.Width), Location.Y + 200);
                label4.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200);
                pictureBox12.Location = new Point(pictureBox11.Location.X + ((pictureBox11.Width - pictureBox12.Width) / 2), Location.Y + label3.Height + pictureBox11.Height + 240);
                pictureBox13.Location = new Point(pictureBox11.Location.X + ((pictureBox11.Width - pictureBox13.Width) / 2), Location.Y + label3.Height + pictureBox11.Height + 240);
                pictureBox30.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300), Location.Y + 200 + label2.Height);
                pictureBox31.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 200 + label2.Height);
            }
        }
        public WindowsMediaPlayer win = new WindowsMediaPlayer();
        public WindowsMediaPlayer q = new WindowsMediaPlayer();
        public WindowsMediaPlayer lose = new WindowsMediaPlayer();
        public WindowsMediaPlayer attention = new WindowsMediaPlayer();
        public void quas()
        {
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/whatsound/q/").GetFiles().Length.ToString()))
            {
                q.URL = ("files/whatsound/q/" + eea + ".mp3");
                pl = 1;
                otvet = (File.ReadAllText("files/whatsound/a/" + eea + ".txt", Encoding.Default));
                timer1.Enabled = true;
            }
            eea++;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox13.Hide();
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
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
            pictureBox5.Hide();
            pictureBox9.Hide();

            Random team = new Random();
            t = team.Next(1, 3);

            if (t == 1)
            {
                label3.Text = (Program.team1);
                pictureBox11.Load(Program.logo1);

            }
            if (t == 2)
            {
                label3.Text = (Program.team2);
                pictureBox11.Load(Program.logo2);
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
                q.controls.stop();
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

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
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
            time = time + 1;
            if (time == 45)
            {
                q.controls.stop();
                time = 0;
                pl = 0;
                timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pl == 1)
            {
                q.controls.pause();
                pl = 0;
                timer1.Enabled = false;
            }
            else
            {
                q.controls.play();
                pl = 1;
                timer1.Enabled = true;
            }
            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = true;
            pictureBox8.Visible = true;
            pictureBox10.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Focus();
            label3.Visible = false;
            pictureBox11.Visible = false;
            quas();
            timer3.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                Program.score1 = Program.score1 + 1;
                label3.Text = (Program.team2);
                pictureBox11.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox11.Visible = true;
                label3.Visible = true;
                timer3.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                Program.score2 = Program.score2 + 1;
                label3.Text = (Program.team1);
                pictureBox11.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox11.Visible = true;
                label3.Visible = true;
                timer3.Enabled = true;
                t = 1;
            }
            timer2.Enabled = false;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (t == 1)
            {
                label3.Text = (Program.team2);
                pictureBox11.Load(Program.logo2);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox11.Visible = true;
                label3.Visible = true;
                timer3.Enabled = true;
                t = 2;
            }
            else if (t == 2)
            {
                label3.Text = (Program.team1);
                pictureBox11.Load(Program.logo1);
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                this.BackgroundImage = Resources.nature8seri;
                pictureBox11.Visible = true;
                label3.Visible = true;
                timer3.Enabled = true;
                t = 1;
            }
            timer4.Enabled = false;
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
            if (eea <= Convert.ToInt32(new DirectoryInfo("files/whatsound/q/").GetFiles().Length.ToString()))
            {
                if (textBox1.Text == otvet)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    q.controls.stop();
                    pictureBox1.Visible = false;
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
                    q.controls.stop();
                    pictureBox1.Visible = false;
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
            else
            {
                if (textBox1.Text == otvet)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    q.controls.stop();
                    pictureBox1.Visible = false;
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
                        timer5.Enabled = true;
                    }
                    else if (t == 2)
                    {
                        Program.score2 = Program.score2 + 1;
                        timer5.Enabled = true;
                    }
                }
                else
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    q.controls.stop();
                    pictureBox1.Visible = false;
                    label1.Visible = true;
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    label1.Text = "НЕ ПРАВИЛЬНО!";
                    label1.ForeColor = Color.Red;
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    lose.URL = ("files/sound/lose.mp3");
                    lose.controls.play();
                    timer5.Enabled = true;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 1)
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox5_Click(sender, e);
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
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
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;
            label3.Text = "Угадай мелодию";
            label3.Visible = true;
            label3.Location = new Point(((Convert.ToInt16(a) - label3.Width) / 2), Location.Y+100);
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            pictureBox30.Visible = true;
            pictureBox31.Visible = true;
            timer6.Enabled = true;
            timer5.Enabled = false;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Close();
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
            pictureBox11.Visible = false;
            label3.Visible = false;
            this.BackgroundImage = Resources.nature;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox6.Visible = true;
            pictureBox8.Visible = true;
            pictureBox10.Visible = true;
            textBox1.Visible = true;
            pictureBox12.Hide();
            pictureBox13.Hide();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Show();
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
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

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            attention.URL = ("files/sound/attention.mp3");
            attention.controls.play();
        }
    }
}
