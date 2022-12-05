using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Неправильно введен логин или пароль!");
            }
            else 
            {
                sqlCommandLog.Parameters["@log"].Value = username.Text;
                sqlCommandLog.Parameters["@pass"].Value = password.Text;
                sqlConnectionLog.Open();
                sqlCommandLog.ExecuteNonQuery();
                sqlConnectionLog.Close();
                int result = (int)sqlCommandLog.Parameters["@flag"].Value;
                if (result == 0)
                {
                    MessageBox.Show("Неправильно введен логин или пароль!");
                    username.Text = "";
                    password.Text = "";
                }
                else if (result == 1)
                {
                    MessageBox.Show("Вы вошли в приложение для менеджеров!");
                    Form Manager = new Manager();
                    Manager.Show();
                    this.Hide();
                }
                else if (result == 2)
                {
                    MessageBox.Show("Вы вошли в приложение для операционистов!");
                    Form Operator = new Operator();
                    Operator.Show();
                    this.Hide();
                }
                else if (result == 3)
                {
                    MessageBox.Show("Вы вошли в приложение для клиентов!");
                    Form Form2 = new Form2();
                    Form2.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void sqlConnectionLog_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
