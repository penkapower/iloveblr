using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using dip2.Properties;
namespace dip2
{
    public partial class Form12 : Form
    {
        int l, rr = 0, p = 0;
        string l1;
        public Form12()
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
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
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
            pictureBox21.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox22.BackColor = Color.FromArgb(0, 0, 0, 0);
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            for (int i=1; i <= Convert.ToInt32(new DirectoryInfo("files/who/q/").GetFiles().Length.ToString()); i++)
            {
                comboBox1.Items.Add(Path.GetFileName("files/who/q/" + i));
            }
            FileStream fs = new FileStream("files/who/q/" + comboBox1.Items.Count + ".jpg", FileMode.Open, FileAccess.Read);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
            }
            else
            {
                FileStream fs = new FileStream("files/who/q/" + comboBox1.SelectedItem + ".jpg", FileMode.Open, FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
                richTextBox1.Text = File.ReadAllText("files/who/a/" + comboBox1.SelectedItem + ".txt", Encoding.Default);
                richTextBox1.ReadOnly = false;
                pictureBox2.Show();
                pictureBox2.Show();
                pictureBox4.Show();
                pictureBox12.Show();
                pictureBox11.Hide();
                pictureBox7.Hide();
                pictureBox21.Show();
            }
        }

   

       

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
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
            if (rr == 0)
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    File.WriteAllText("files/who/a/" + comboBox1.SelectedItem + ".txt", richTextBox1.Text, Encoding.Default);
                    DialogResult res = MessageBox.Show("Вопрос успешно изменён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        pictureBox21.Hide();
                        pictureBox22.Hide();
                        pictureBox3.Hide();
                        pictureBox2.Hide();
                        pictureBox21.Hide();
                        pictureBox22.Hide();
                        richTextBox1.ReadOnly = true;

                    }
                }
            }
            else
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    File.WriteAllText("files/who/a/" + comboBox1.SelectedItem + ".txt", richTextBox1.Text, Encoding.Default);
                    File.Copy(l1,"files/who/q/" + comboBox1.SelectedItem + ".jpg",true);
                    DialogResult res = MessageBox.Show("Вопрос успешно изменён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        pictureBox21.Hide();
                        pictureBox22.Hide();
                        pictureBox3.Hide();
                        pictureBox2.Hide();
                        pictureBox21.Hide();
                        pictureBox22.Hide();
                        richTextBox1.ReadOnly = true;
                        rr = 0;

                    }
                }
            }
          
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
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.WriteAllText("files/who/a/" + (comboBox1.Items.Count + 1) + ".txt", richTextBox1.Text, Encoding.Default);
                pictureBox1.Image.Save("files/who/q/" + (comboBox1.Items.Count + 1) + ".jpg");
                comboBox1.Items.Add(comboBox1.Items.Count + 1);
                DialogResult res = MessageBox.Show("Вопрос успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    pictureBox11.Hide();
                    pictureBox1.Image = null;
                    richTextBox1.Text = "";
                    richTextBox1.ReadOnly = true;
                    pictureBox7.Hide();
                    pictureBox10.Hide();
                    pictureBox4.Show();
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
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Filter = "Файлы jpg|*.jpg";
            if (op1.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.Text = "";
                comboBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                richTextBox1.ReadOnly = false;
                pictureBox2.Hide();
                pictureBox11.Show();
                pictureBox7.Show();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox12.Hide();
                pictureBox13.Hide();
                pictureBox21.Hide();
                pictureBox22.Hide();
                pictureBox1.Image = Image.FromFile(op1.FileName);
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
            pictureBox1.Image = null;
            pictureBox7.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox8.Hide();
            pictureBox4.Show();
            pictureBox21.Hide();
            pictureBox22.Hide();
            richTextBox1.Text = "";
            comboBox1.Text = "";
            richTextBox1.ReadOnly = true;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.nature;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
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
            else if (Convert.ToInt32(comboBox1.SelectedItem) >= comboBox1.Items.Count)
            {
                DialogResult del = MessageBox.Show("Вы действительно хотите удалить вопрос?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (del == DialogResult.Yes)
                {
                    pictureBox1.Image = null;
                    l = Convert.ToInt16(comboBox1.SelectedItem);
                    if (pictureBox1.Image == null)
                    {
                        comboBox1.Items.Remove(comboBox1.SelectedItem);
                        pictureBox1.Update();
                        pictureBox1.Refresh();
                        richTextBox1.Text = "";
                        pictureBox2.Hide();
                        pictureBox12.Hide();
                        pictureBox13.Hide();
                        pictureBox21.Hide();
                        pictureBox22.Hide();
                        File.Delete("files/who/q/" + l + ".jpg");
                        File.Delete("files/who/a/" + l + ".txt");
                    }
                }
                else if (del == DialogResult.No)
                {
                }
            }

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
            Close();
            p = 0;
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

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void Form12_KeyDown(object sender, KeyEventArgs e)
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
            op2.Filter = "Файлы jpg|*.jpg";
            if (op2.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op2.FileName);
                l1 = (op2.FileName);
                rr = 1;
            }
        }
    }
}