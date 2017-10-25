using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using dip2.Properties;

namespace dip2
{
    public partial class Form4 : Form
    {
        int p = 0, end=0;
        double a, a1, b, b1, z, x;
        public Form4()
        { 
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox17.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox18.BackColor = Color.FromArgb(0, 0, 0, 0);
            int f, f1, f2, f3;
            a = System.Windows.SystemParameters.PrimaryScreenWidth;
            b = System.Windows.SystemParameters.PrimaryScreenHeight;
            if (a == 1024 || this.WindowState == FormWindowState.Normal)
            { }
            else
            {
                a1 = 1024;
                b1 = 768;
                z = (a / a1);
                x = (b / b1);
                f = (Convert.ToInt32(pictureBox1.Width * z) - pictureBox1.Width);
                f1 = (Convert.ToInt32(pictureBox9.Height * x) - pictureBox9.Height);
                f2 = (Convert.ToInt32(pictureBox17.Height * x) - pictureBox17.Height);
                f3 = (Convert.ToInt32(pictureBox3.Height * x) - pictureBox3.Height);
                //да.нет
                pictureBox1.Size = new Size(Convert.ToInt32(pictureBox1.Width * z), Convert.ToInt32(pictureBox1.Height * x));
                pictureBox5.Size = new Size(Convert.ToInt32(pictureBox5.Width * z), Convert.ToInt32(pictureBox5.Height * x));
                pictureBox14.Size = new Size(Convert.ToInt32(pictureBox14.Width * z), Convert.ToInt32(pictureBox14.Height * x));
                //угадай
                pictureBox2.Location = new Point(Location.X + (pictureBox2.Location.X - f), Location.Y + 1);
                pictureBox6.Location = new Point(Location.X + (pictureBox6.Location.X - f), Location.Y + 1);
                pictureBox13.Location = new Point(Location.X + (pictureBox13.Location.X - f), Location.Y + 1);
                pictureBox2.Size = new Size(Convert.ToInt32(pictureBox2.Width * z), Convert.ToInt32(pictureBox2.Height * x));
                pictureBox6.Size = new Size(Convert.ToInt32(pictureBox6.Width * z), Convert.ToInt32(pictureBox6.Height * x));
                pictureBox13.Size = new Size(Convert.ToInt32(pictureBox13.Width * z), Convert.ToInt32(pictureBox13.Height * x));
                //кто
                pictureBox3.Location = new Point(Location.X + 0, Location.Y + (pictureBox1.Height + 2));
                pictureBox7.Location = new Point(Location.X + 0, Location.Y + (pictureBox1.Height + 2));
                pictureBox15.Location = new Point(Location.X + 0, Location.Y + (pictureBox1.Height + 2));
                pictureBox3.Size = new Size(Convert.ToInt32(pictureBox3.Width * z), Convert.ToInt32(pictureBox3.Height * x));
                pictureBox7.Size = new Size(Convert.ToInt32(pictureBox7.Width * z), Convert.ToInt32(pictureBox7.Height * x));
                pictureBox15.Size = new Size(Convert.ToInt32(pictureBox15.Width * z), Convert.ToInt32(pictureBox15.Height * x));
                //пере
                pictureBox4.Location = new Point(Location.X + (pictureBox4.Location.X - f), Location.Y + (pictureBox2.Height));
                pictureBox8.Location = new Point(Location.X + (pictureBox8.Location.X - f), Location.Y + (pictureBox2.Height));
                pictureBox16.Location = new Point(Location.X + (pictureBox16.Location.X - f), Location.Y + (pictureBox2.Height));
                pictureBox4.Size = new Size(Convert.ToInt32(pictureBox4.Width * z), Convert.ToInt32(pictureBox4.Height * x));
                pictureBox8.Size = new Size(Convert.ToInt32(pictureBox8.Width * z), Convert.ToInt32(pictureBox8.Height * x));
                pictureBox16.Size = new Size(Convert.ToInt32(pictureBox16.Width * z), Convert.ToInt32(pictureBox16.Height * x));
                //кнопки
                pictureBox9.Location = new Point(Location.X + pictureBox9.Location.X, Location.Y + (pictureBox9.Location.Y - f1));
                pictureBox10.Location = new Point(Location.X + pictureBox10.Location.X, Location.Y + (pictureBox10.Location.Y - f1));
                pictureBox11.Location = new Point(Location.X + pictureBox11.Location.X, Location.Y + (pictureBox11.Location.Y - f1));
                pictureBox12.Location = new Point(Location.X + pictureBox12.Location.X, Location.Y + (pictureBox12.Location.Y - f1));
                pictureBox17.Location = new Point(Location.X + pictureBox17.Location.X, Location.Y + (pictureBox17.Location.Y - f2));
                pictureBox9.Size = new Size(Convert.ToInt32(pictureBox9.Width * (z / 1.5)), Convert.ToInt32(pictureBox9.Height * x));
                pictureBox10.Size = new Size(Convert.ToInt32(pictureBox10.Width * (z / 1.5)), Convert.ToInt32(pictureBox10.Height * x));
                pictureBox12.Size = new Size(Convert.ToInt32(pictureBox12.Width * (z / 1.5)), Convert.ToInt32(pictureBox12.Height * x));
                pictureBox11.Size = new Size(Convert.ToInt32(pictureBox11.Width * (z / 1.5)), Convert.ToInt32(pictureBox11.Height * x));
                pictureBox17.Size = new Size(Convert.ToInt32(pictureBox17.Width * (z / 1.5)), Convert.ToInt32(pictureBox17.Height * x));

                label2.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 310), Location.Y + 250);
                label5.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300 + label2.Width), Location.Y + 250);
                label6.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300 + label2.Width + label5.Width), Location.Y + 250);
                label7.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width), Location.Y + 250);
                label4.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 250);
                pictureBox30.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300), Location.Y + 250 + label2.Height);
                pictureBox31.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y + 250 + label2.Height);
                pictureBox18.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 300), Location.Y+25);
            }

        }

        public Form5 Form5
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Form6 Form6
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Form8 Form8
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Form7 Form7
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Program.backsound.Stop();
            Program.back = 0;
            pictureBox30.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox31.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.BackgroundImage = Resources.nature;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label1.Visible = false;
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox12.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox14.Hide();
            pictureBox13.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            if (Program.vib ==1)
            {
                pictureBox12.Hide();
                pictureBox11.Hide();
                pictureBox17.Hide();
            }
            if (Program.pic14 == 1)
            {
                pictureBox14.Show();
            }
            if (Program.pic13 == 1)
            {
                pictureBox13.Show();
            }
            if (Program.pic15 == 1)
            {
                pictureBox15.Show();
            }
            if (Program.pic16 == 1)
            {
                pictureBox16.Show();
            }
            if (Program.pic13 == 1 && Program.pic14 == 1 && Program.pic15 == 1 && Program.pic16 == 1)
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
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                pictureBox30.Visible = true;
                pictureBox31.Visible = true;
                if (Program.score1 > Program.score2)
                {
                    pictureBox18.Show();
                    end = 1;
                }
                else if (Program.score1 < Program.score2)
                {
                    pictureBox18.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 320 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y+25);
                    pictureBox18.Show();
                    end = 1;
                }
                else if (Program.score1 == Program.score2)
                {
                    pictureBox18.Show();
                    end = 1;
                    PictureBox копиякартинки = new PictureBox();
                    копиякартинки.Image = pictureBox18.Image;
                    копиякартинки.Location = new Point(((Convert.ToInt16(a) - label2.Width) / 2 - 320 + label2.Width + label5.Width + label6.Width + label7.Width), Location.Y+25);
                    копиякартинки.BackColor = Color.FromArgb(0, 0, 0, 0);
                    копиякартинки.SizeMode = PictureBoxSizeMode.AutoSize;
                    копиякартинки.Size = pictureBox18.Size;
                    this.Controls.Add(копиякартинки);
                }
            }
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Show();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Hide();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Show();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Show();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (p == 0)
            {
                p = 0;
                Form fr2sh = new Form2();
                fr2sh.Show();
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
            }
            else if (p == 1)
            {
                p = 0;
                Form f6 = new Form6();
                f6.Show();
            }
            else if (p == 2)
            {
                p = 0;
                Form f5 = new Form5();
                f5.Show();
            }
            else if (p == 3)
            {
                p = 0;
                Form f7 = new Form7();
                f7.Show();
            }
            else if (p == 4)
            {
                p = 0;
                Form f8 = new Form8();
                f8.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            p = 1;
            Program.vib = 1;
            Program.pic14 = 1;
            Close();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            p = 2;
            Program.vib = 1;
            Program.pic13 = 1;
            Close();
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            p = 3;
            Program.vib = 1;
            Program.pic15 = 1;
            Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            p = 4;
            Program.vib = 1;
            Program.pic16 = 1;
            Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите выйти из игры?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            if (end == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
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

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Show();
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Hide();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            pictureBox17.Show();
            pictureBox12.Hide();
            pictureBox11.Hide();
            Program.vib = 1;
            int a, startItemsCount;
            List<int> list = new List<int>() { 1, 2, 3, 4 };

            startItemsCount = list.Count; // кол-во элементов списка
            Random rand = new Random();

            for (int i = 0; i < startItemsCount - 1; i++)
            {

                a = rand.Next(list.Count); // индекс элемента из списка "items"
                if (list[a] == 1)
                {
                    pictureBox14.Show();
                }
                else if (list[a] == 2)
                {
                    pictureBox13.Show();
                }
                else if (list[a] == 3)
                {
                    pictureBox15.Show();
                }
                else if (list[a] == 4)
                {
                    pictureBox16.Show();
                }
                list.RemoveAt(a);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            Program.vib = 0;
        }
    }
        }