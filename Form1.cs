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
    public partial class Form1 : Form
    {
        private bool passwordVisible = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            string user = loginTB.Text;
            string pwd = passwdTB.Text;
            if (user == Properties.Settings.Default.Username && pwd == Properties.Settings.Default.Password)
            {
                MessageBox.Show("Успешный вход!");
                loginTB.Text = "";
                passwdTB.Text = "";
                Hide();
                using (menu menu = new menu())
                {
                    menu.ShowDialog();
                }
                Show();
            }
            else
            {
                MessageBox.Show("неправильно введен логин или пароль! Пожалуйста, введите капчу для продолжения работы с программой.");
                loginTB.Text = "";
                passwdTB.Text = "";
                Hide();
                using (CAPTCHA captcha = new CAPTCHA())
                {
                    captcha.ShowDialog();
                }
                Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void showPasswdBtn_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            passwdTB.PasswordChar = passwordVisible ? '\0' : '*';
        }
    }
}
