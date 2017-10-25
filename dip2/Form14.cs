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
    public partial class Form14 : Form
    {
        int logo = 0,nbr;
        public Form14()
        {
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            pictureBox2.BackColor = Color.FromArgb(0,0,0,0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox13.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox14.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox21.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox22.BackColor = Color.FromArgb(0, 0, 0, 0);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            pictureBox3.Load("files/logo/0.png");
            pictureBox7.Hide();
            pictureBox4.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox13.Hide();
            pictureBox8.Hide();
            pictureBox22.Hide();
        }

        public Form4 Form4
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Show();
        }
        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide();
        }
        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Hide();
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
            textBox1.Text = Program.team1;
            pictureBox3.Load(Program.logo1);
            comboBox1.Text = Convert.ToString(nbr);
            pictureBox4.Hide();
            pictureBox9.Hide();
            pictureBox8.Hide();
            pictureBox10.Hide();
            pictureBox6.Show();
            pictureBox12.Show();
            pictureBox13.Hide();
            pictureBox2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
            }
            else
            {
                pictureBox3.Load("files/logo/" + comboBox1.SelectedItem + ".png");
                logo = 1;
            }
        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.Show();
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Hide();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            OpenFileDialog op2 = new OpenFileDialog();
            op2.Filter = "Файлы png|*.png|Файлы jpg|*.jpg";
            if (op2.ShowDialog(this) == DialogResult.OK)
            {
                File.Copy(op2.FileName, "files/timefiles/1.png",true);
                comboBox1.SelectedIndex = -1;
                logo = 1;
                pictureBox3.Load("files/timefiles/1.png");
            }

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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название первой команды!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (logo == 0)
            {
                MessageBox.Show("Выберите ваш логотип!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Команда добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.team1 = textBox1.Text;
                Program.logo1 = pictureBox3.ImageLocation;
                textBox1.Text = "";
                logo = 0;
                nbr =Convert.ToInt16(comboBox1.SelectedItem);
                comboBox1.SelectedIndex = -1;
                pictureBox3.Load("files/logo/0.png");
                pictureBox2.Hide();
                pictureBox4.Show();
                pictureBox7.Hide();
                pictureBox6.Hide();
                pictureBox10.Show();
                pictureBox13.Show();
                pictureBox11.Hide();
                pictureBox12.Hide();
            }
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Hide();
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название первой команды!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (logo == 0)
            {
                MessageBox.Show("Выберите ваш логотип!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Команда добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.team2 = textBox1.Text;
                Program.logo2 = pictureBox3.ImageLocation;
                Form f4 = new Form4();
                f4.Show();
                Close();
            }
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Show();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form14_KeyDown(object sender, KeyEventArgs e)
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            DialogResult result = MessageBox.Show("Вы дествительно хотите выйте в меню?\nВсе настройки будут сброшены.", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form f2 = new Form2();
                f2.Show();
                Program.team1 = "";
                Program.team2 = "";
                Program.logo1 = "";
                Program.logo2 = "";
                logo = 0;
                Close();
    }
        }
    }
}
