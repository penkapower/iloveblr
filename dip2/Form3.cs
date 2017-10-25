using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.IO;

namespace dip2
{
    public partial class Form3 : Form
    {
             public bool UpdateInForm = false;
        string pass;
        
        public void img()
        {
            this.BackgroundImage = Image.FromFile(@"bgr\nature8.jpg", false);
        }
        public Form3()
        {
            InitializeComponent();
            Program.butclic.Open(new Uri("files/sound/btncl.wav", UriKind.Relative));
            Program.butclic.Stop();
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox6.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox4.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox7.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox8.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox9.BackColor = Color.FromArgb(0, 0, 0, 0);
            Thread imag = new Thread(img);
            imag.Start();
            panel1.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.backsound.Stop();
            Program.backsoundpl = 0;
            pictureBox2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox9.Hide();
            pictureBox15.Hide();
            pictureBox11.Hide();
            if (Program.backsoundpl == 1)
            {
                pictureBox1.Show();
            }
            else if (Program.backsoundpl == 0)
            {
                pictureBox2.Show();
            }
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
            Program.backsound.PlayLooping();
            Program.backsoundpl = 1;
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Show();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            this.Close();
            Form f2 = new Form2();
            f2.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox7.Show();
            Program.bbutclicpl = 0;
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
            pictureBox7.Hide();
            Program.bbutclicpl = 1;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Show();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Hide();
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
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            panel1.Show();
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        public void password()
        {
            pass = Decrypt(File.ReadAllText("files/pass.txt"), "Passpord11", "Password22", "SHA1", 2,
                                                    "16CHARSLONG12345", 256);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.bbutclicpl == 1)
            {
                Program.butclic.Play();
            }
            else
            {

            }
            password();
            if (textBox1.Text == pass)
            {
                Form f9 = new Form9();
                this.Close();
                f9.Show();   
            }
            else
            {
                DialogResult res = MessageBox.Show("Неверно введен пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            password();
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == pass)
                {
                    Form f9 = new Form9();
                    this.Close();
                    f9.Show();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Неверно введен пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        textBox1.Text = "";
                    }
                }
            }
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
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
            panel1.Hide();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            textBox1.Text = "";
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
            password();
            if (textBox1.Text == pass)
            {
                Form f9 = new Form9();
                this.Close();
                f9.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Неверно введен пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    textBox1.Text = "";
                }
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

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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

        public Form9 Form9
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
