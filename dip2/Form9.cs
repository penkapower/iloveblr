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
using System.IO;
using dip2.Properties;

namespace dip2
{
    public partial class Form9 : Form
    {
        int p = 0;
        public Form9()
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
            double a, a1, b, b1, z, x;
            int f, f1, f3;
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
                f3 = (Convert.ToInt32(pictureBox3.Height * x) - pictureBox3.Height);
                //да.нет
                pictureBox1.Size = new Size(Convert.ToInt32(pictureBox1.Width * z), Convert.ToInt32(pictureBox1.Height * x));
                pictureBox5.Size = new Size(Convert.ToInt32(pictureBox5.Width * z), Convert.ToInt32(pictureBox5.Height * x));

                //угадай
                pictureBox2.Location = new Point(Location.X + (pictureBox2.Location.X - f), Location.Y + 1);
                pictureBox6.Location = new Point(Location.X + (pictureBox6.Location.X - f), Location.Y + 1);
                pictureBox2.Size = new Size(Convert.ToInt32(pictureBox2.Width * z), Convert.ToInt32(pictureBox2.Height * x));
                pictureBox6.Size = new Size(Convert.ToInt32(pictureBox6.Width * z), Convert.ToInt32(pictureBox6.Height * x));
                //кто
                pictureBox3.Location = new Point(Location.X + 0, Location.Y + (pictureBox1.Height + 2));
                pictureBox7.Location = new Point(Location.X + 0, Location.Y + (pictureBox1.Height + 2));
                pictureBox3.Size = new Size(Convert.ToInt32(pictureBox3.Width * z), Convert.ToInt32(pictureBox3.Height * x));
                pictureBox7.Size = new Size(Convert.ToInt32(pictureBox7.Width * z), Convert.ToInt32(pictureBox7.Height * x));
                //пере
                pictureBox4.Location = new Point(Location.X + (pictureBox4.Location.X - f), Location.Y + (pictureBox2.Height));
                pictureBox8.Location = new Point(Location.X + (pictureBox8.Location.X - f), Location.Y + (pictureBox2.Height));
                pictureBox4.Size = new Size(Convert.ToInt32(pictureBox4.Width * z), Convert.ToInt32(pictureBox4.Height * x));
                pictureBox8.Size = new Size(Convert.ToInt32(pictureBox8.Width * z), Convert.ToInt32(pictureBox8.Height * x));
                //кнопки
                pictureBox9.Location = new Point(Location.X + Convert.ToInt32(a / 2.5), Location.Y + (pictureBox9.Location.Y - f1));
                pictureBox10.Location = new Point(Location.X + Convert.ToInt32(a / 2.5), Location.Y + (pictureBox10.Location.Y - f1));
                pictureBox9.Size = new Size(Convert.ToInt32(pictureBox9.Width * (z / 1.5)), Convert.ToInt32(pictureBox9.Height * x));
                pictureBox10.Size = new Size(Convert.ToInt32(pictureBox10.Width * (z / 1.5)), Convert.ToInt32(pictureBox10.Height * x));

            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox1.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox12.Hide();
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox11.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox12.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.BackgroundImage = Resources.nature;

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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            p = 1;
            Form f10 = new Form10();
            f10.Show();
            this.Close();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            p = 1;
            Form f11 = new Form11();
            f11.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            p = 1;
            Form f12 = new Form12();
            f12.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            p = 1;
            Form f13 = new Form13();
            f13.Show();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
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
            p = 0;
            this.Close();
        }
        public string Encrypt(string plainText, string password,
             string salt = "Kosher", string hashAlgorithm = "SHA1",
           int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY",
            int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }
        public string Decrypt(string cipherText, string password,
           string salt = "Kosher", string hashAlgorithm = "SHA1",
           int passwordIterations = 2, string initialVector = "OFRna73m*aze01xY",
            int keySize = 256)
        {
            if (string.IsNullOrEmpty(cipherText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            File.SetAttributes("files/pass.txt", FileAttributes.Normal);
            File.WriteAllText("files/pass.txt", Encrypt(textBox1.Text, "Passpord11", "Password22", "SHA1", 2,
                                                 "16CHARSLONG12345", 256), Encoding.Default);
            File.SetAttributes("files/pass.txt", FileAttributes.Hidden);
            DialogResult res = MessageBox.Show("Пароль успешно обновлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                label1.Hide();
                textBox1.Hide();
                pictureBox13.Hide();
                pictureBox11.Show();
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
            }

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
            label1.Show();
            textBox1.Show();
            pictureBox13.Show();
            pictureBox14.Show();
            pictureBox16.Show();
            textBox1.Text = Decrypt(File.ReadAllText("files/pass.txt"), "Passpord11", "Password22", "SHA1", 2,
                                                 "16CHARSLONG12345", 256);
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            pictureBox12.Hide();
            pictureBox11.Hide();
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;

        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Show();
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
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
            label1.Hide();
            textBox1.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox11.Show();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.Show();
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Hide();
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
            File.SetAttributes("files/pass.txt", FileAttributes.Normal);
            File.WriteAllText("files/pass.txt", Encrypt(textBox1.Text, "Passpord11", "Password22", "SHA1", 2,
                                                 "16CHARSLONG12345", 256), Encoding.Default);
            File.SetAttributes("files/pass.txt", FileAttributes.Hidden);
            DialogResult res = MessageBox.Show("Пароль успешно обновлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                label1.Hide();
                textBox1.Hide();
                pictureBox13.Hide();
                pictureBox14.Hide();
                pictureBox15.Hide();
                pictureBox16.Hide();
                pictureBox17.Hide();
                pictureBox11.Show();
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
            }
        }

        private void Form9_KeyDown(object sender, KeyEventArgs e)
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
        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (p == 0)
            {
                Form fr2sh = new Form2();
                fr2sh.Show();
            }
            else
            {
            }
        }
    }
}