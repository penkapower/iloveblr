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

namespace dip2
{
    public partial class Form10 : Form
    {
        int p =0;
        public Form10()
        {
            
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox5.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox13.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox14.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox15.BackColor = Color.FromArgb(0, 0, 0, 0);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i=1; i <= Convert.ToInt32(new DirectoryInfo("files/yesno/q/").GetFiles().Length.ToString()); i++)
            {
                comboBox1.Items.Add(Path.GetFileName("files/yesno/q/"+i));
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
            }
            else
                {
                richTextBox2.Text = File.ReadAllText("files/yesno/q/" + comboBox1.SelectedItem + ".txt", Encoding.Default);
                richTextBox1.Text = File.ReadAllText("files/yesno/a/" + comboBox1.SelectedItem + ".txt", Encoding.Default);
                richTextBox1.ReadOnly = false;
                richTextBox2.ReadOnly = false;
                pictureBox2.Show();
                pictureBox4.Show();
                pictureBox12.Show();
                pictureBox11.Hide();
                pictureBox7.Hide();
            }
        }
        public void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (p == 0)
            {
                p = 0;
                Form fr9sh = new Form9();
                fr9sh.Show();
            }
            else
            {
                p = 0;
                Form fr2sh = new Form2();
                fr2sh.Show();
            }
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Show();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Hide();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide();
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Show();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            if (richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox1.Text == "" && richTextBox2.Text == "")
            {
                MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.WriteAllText("files/yesno/q/" + comboBox1.SelectedItem + ".txt", richTextBox2.Text, Encoding.Default);
                File.WriteAllText("files/yesno/a/" + comboBox1.SelectedItem + ".txt", richTextBox1.Text, Encoding.Default);
                DialogResult res = MessageBox.Show("Вопрос успешно изменён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    pictureBox3.Hide();
                    pictureBox2.Hide();
                    richTextBox1.ReadOnly = true;
                    richTextBox2.ReadOnly = true;

                }
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
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            comboBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            richTextBox1.ReadOnly = false;
            richTextBox2.ReadOnly = false;
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox2.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox11.Show();
            pictureBox7.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            if (richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox1.Text == "" && richTextBox2.Text == "")
            {
                MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.WriteAllText("files/yesno/q/" + (comboBox1.Items.Count + 1) + ".txt", richTextBox2.Text, Encoding.Default);
                File.WriteAllText("files/yesno/a/" + (comboBox1.Items.Count + 1) + ".txt", richTextBox1.Text, Encoding.Default);
                comboBox1.Items.Add(comboBox1.Items.Count + 1);
                DialogResult res = MessageBox.Show("Вопрос успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    pictureBox7.Hide();
                    pictureBox10.Hide();
                    pictureBox11.Hide();
                    pictureBox4.Show();
                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                    comboBox1.Text = "";
                    //comboBox1.Show();
                    richTextBox1.ReadOnly = true;
                    richTextBox2.ReadOnly = true;
                }
            }
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
            pictureBox7.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox8.Hide();
            pictureBox4.Show();
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            comboBox1.Text = "";
            comboBox1.Show();
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
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
            if (Convert.ToInt32(comboBox1.SelectedItem) < comboBox1.Items.Count)
            {
                MessageBox.Show("Не возможно удалить выбранный элемент!\nУдаление возможно начиная с последнего элемента!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Convert.ToInt32(comboBox1.SelectedItem) >= comboBox1.Items.Count)
            {
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить вопрос?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (del == DialogResult.Yes)
                {
                    File.Delete("files/yesno/q/" + comboBox1.SelectedItem + ".txt");
                    File.Delete("files/yesno/a/" + comboBox1.SelectedItem + ".txt");
                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    pictureBox2.Hide();
                    pictureBox12.Hide();
                    pictureBox13.Hide();
                }
                else if (del == DialogResult.No)
                {
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        public void Close(object sender, FormClosedEventArgs e)
        {
            Form10_FormClosed(sender, e);
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
            p = 0;
            Close();
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.Show();
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            p = 1;
            Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void Form10_KeyDown(object sender, KeyEventArgs e)
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

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Text.Length == 1)
                ((RichTextBox)sender).Text = ((RichTextBox)sender).Text.ToUpper();
            ((RichTextBox)sender).Select(((RichTextBox)sender).Text.Length, 0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Text.Length == 1)
                ((RichTextBox)sender).Text = ((RichTextBox)sender).Text.ToUpper();
            ((RichTextBox)sender).Select(((RichTextBox)sender).Text.Length, 0);
        }
    }
}