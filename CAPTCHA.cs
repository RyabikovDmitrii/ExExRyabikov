using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExExRyabikov
{
    public partial class CAPTCHA : Form
    {
        private string capthcaCode;
        public CAPTCHA()
        {
            InitializeComponent();
            GenerateCaptcha();
        }
        private void GenerateCaptcha()
        {
            int lenght = 6;
            capthcaCode = GenerateRandomCode(lenght);
            Bitmap bitmap = new Bitmap(281, 149);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                using (Font font = new Font("Arial", 24, FontStyle.Bold | FontStyle.Strikeout))
                {
                    PointF textPosition = new PointF(10, 10);
                    g.DrawString(capthcaCode, font, Brushes.Black, textPosition);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private string GenerateRandomCode(int lenght)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] stringChars = new char[lenght];
            for (int i = 0; i< lenght; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(stringChars);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captchaTB.Text.Equals(capthcaCode, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("CAPTCHA введена верно!");
                Close();
            }
            else
            {
                MessageBox.Show("CAPTCHA введена неверно! Введите еще раз.");
                GenerateCaptcha();
            }
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
    }
}
