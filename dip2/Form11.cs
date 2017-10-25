using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using dip2.Properties;

namespace dip2
{
    public partial class Form11 : Form
    {
       string l,l1;
        int g,rr=0,p=0;
        public Form11()
        {
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox17.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox13.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox14.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox15.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox16.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox17.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox18.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox19.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox20.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox21.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox22.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox23.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pictureBox24.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            for (int i=1; i <= Convert.ToInt32(new DirectoryInfo("files/whatsound/q/").GetFiles().Length.ToString()); i++)
            {
                comboBox1.Items.Add(Path.GetFileName("files/whatsound/q/" + i));
            }
            
        }
        public WindowsMediaPlayer f = new WindowsMediaPlayer();
        public WindowsMediaPlayer f1 = new WindowsMediaPlayer();
        
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
            }
            else
            {
                richTextBox1.Text = File.ReadAllText("files/whatsound/a/" + comboBox1.SelectedItem + ".txt", Encoding.Default);
                pictureBox12.Show();
                pictureBox1.Show();
                pictureBox4.Show();
                pictureBox14.Hide();
                pictureBox13.Hide();
                pictureBox16.Show();
                pictureBox20.Show();
                pictureBox21.Show();
                richTextBox1.ReadOnly = false;
            }
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (p == 0)
            {
                p = 0;
                Form fr9sh = new Form9();
                fr9sh.Show();
                f.controls.stop();
                f1.controls.stop();
            }
            else
            {
                p = 0;
                Form fr2sh = new Form2();
                fr2sh.Show();
                f.controls.stop();
                f1.controls.stop();
            }

        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide(); 
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Show();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Hide();
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Show();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Hide();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Show();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Hide();
        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.Show();
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Hide();
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Show();
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Hide();
        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.Show();
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            if (rr==0)
            {
                f.URL = ("files/whatsound/q/" + comboBox1.SelectedItem + ".mp3");
                f.controls.play();
            }
            else {
                f.controls.play();
            }
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
            f.controls.stop();
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
            f1.controls.play();
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
            f1.controls.stop();
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
            if (rr == 0) { 
            File.WriteAllText("files/whatsound/a/" + comboBox1.SelectedItem + ".txt", richTextBox1.Text, Encoding.Default);
            DialogResult res = MessageBox.Show("Вопрос успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                    pictureBox11.Hide();
                    pictureBox12.Hide();
                    pictureBox21.Hide();
                    pictureBox22.Hide();
                    f.controls.stop();
                    f1.controls.stop();
                    richTextBox1.ReadOnly = true;
            }
        }
        else
        {
                File.WriteAllText("files/whatsound/a/" + comboBox1.SelectedItem + ".txt", richTextBox1.Text, Encoding.Default);
                File.Copy(l1, ("files/whatsound/q/" + comboBox1.SelectedItem + ".mp3"), true);
                DialogResult res = MessageBox.Show("Вопрос успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    comboBox1.SelectedIndex = -1;
                    richTextBox1.Text = "";
                    richTextBox1.ReadOnly = true;
                    pictureBox12.Hide();
                    pictureBox1.Hide();
                    pictureBox4.Hide();
                    pictureBox14.Hide();
                    pictureBox13.Hide();
                    pictureBox16.Show();
                    pictureBox20.Hide();
                    pictureBox21.Hide();
                    f.controls.stop();
                    f1.controls.stop();
                    rr = 0;
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
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.WriteAllText("files/whatsound/a/" + (comboBox1.Items.Count + 1) + ".txt", richTextBox1.Text, Encoding.Default);
                File.Copy(l, ("files/whatsound/q/" + (comboBox1.Items.Count + 1) + ".mp3"), true);
                comboBox1.Items.Add(comboBox1.Items.Count + 1);
                DialogResult res = MessageBox.Show("Вопрос успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    comboBox1.SelectedItem = -1;
                    richTextBox1.Text = "";
                    richTextBox1.ReadOnly = true;
                    pictureBox6.Hide();
                    pictureBox5.Hide();
                    pictureBox8.Hide();
                    pictureBox7.Hide();
                    pictureBox9.Hide();
                    pictureBox10.Hide();
                    pictureBox14.Hide();
                    pictureBox13.Hide();
                    pictureBox16.Show();
                    f.controls.stop();
                    f1.controls.stop();
                }
            }
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
            pictureBox14.Hide();
            pictureBox13.Hide();
            pictureBox8.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox7.Hide();
            pictureBox9.Hide();
            pictureBox6.Hide();
            pictureBox5.Hide();
            pictureBox16.Show();
            f.controls.stop();
            f1.controls.stop();
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
            p = 0;
            Close();
        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.Show();
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
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
            else if (Convert.ToInt32(comboBox1.SelectedItem) >= comboBox1.Items.Count)
            {
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить вопрос?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (del == DialogResult.Yes)
                {
                    g = Convert.ToInt16(comboBox1.SelectedItem);
                        comboBox1.Items.Remove(comboBox1.SelectedItem);
                        richTextBox1.Text = "";
                        pictureBox4.Hide();
                        pictureBox3.Hide();
                        pictureBox2.Hide();
                        pictureBox1.Hide();
                        pictureBox12.Hide();
                        pictureBox13.Hide();
                        pictureBox20.Hide();
                        pictureBox21.Hide();
                        pictureBox22.Hide();
                        comboBox1.SelectedIndex = -1;
                        f.controls.stop();
                        f1.controls.stop();
                        File.Delete("files/whatsound/q/" + g + ".mp3");
                        File.Delete("files/whatsound/a/" + g + ".txt");
                }
                else if (del == DialogResult.No)
                {
                }
            }
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
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Filter = "Файлы mp3|*.mp3";
            if (op1.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.Text = "";
                comboBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                richTextBox1.ReadOnly = false;
                pictureBox14.Show();
                f1.URL = (op1.FileName);
                f1.controls.stop();
                pictureBox6.Show();
                pictureBox20.Hide();
                pictureBox21.Hide();
                pictureBox15.Hide();
                pictureBox16.Hide();
                pictureBox11.Hide();
                pictureBox12.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox9.Hide();
                pictureBox8.Show();
                pictureBox10.Show();
                pictureBox21.Hide();
                pictureBox22.Hide();
                l = op1.FileName;
            }
        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.Show();
        }

        private void pictureBox24_MouseEnter(object sender, EventArgs e)
        {
            pictureBox23.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
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

        private void Form11_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void Form11_KeyDown(object sender, KeyEventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Text.Length == 1)
                ((RichTextBox)sender).Text = ((RichTextBox)sender).Text.ToUpper();
            ((RichTextBox)sender).Select(((RichTextBox)sender).Text.Length, 0);
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.Hide();
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
            f.controls.stop();
            OpenFileDialog op2 = new OpenFileDialog();
            op2.Filter = "Файлы mp3|*.mp3";
            if (op2.ShowDialog(this) == DialogResult.OK)
            {
                f.URL = (op2.FileName);
                rr = 1;
                l1 = (op2.FileName);
                f.controls.stop();
            }
        }
    }
}