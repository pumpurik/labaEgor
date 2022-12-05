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
    public partial class InsClient : Form
    {
        public InsClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Clients = new Clients();
            Clients.Show();
            this.Hide();
        }

        private void InsClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            phone.MaxLength = 11;
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "" || phone.Text == "" || gender.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                if (phone.TextLength < 11)
                {
                    MessageBox.Show("Номер телефона заполнен неверно!");
                }
                else
                {
                    if (pasport.TextLength < 10)
                    {
                        MessageBox.Show("Введите корректные паспортные данные!");
                    }
                    else
                    {
                        sqlCommandInsClient.Parameters["@fio"].Value = Fio.Text;
                        sqlCommandInsClient.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandInsClient.Parameters["@phone"].Value = phone.Text;
                        sqlCommandInsClient.Parameters["@birth"].Value = date.Text;
                        sqlCommandInsClient.Parameters["@gender"].Value = gender.Text;

                        sqlConnectionInsClient.Open();
                        sqlCommandInsClient.ExecuteNonQuery();
                        sqlConnectionInsClient.Close();
                        String result = (String)sqlCommandInsClient.Parameters["@res"].Value;
                        MessageBox.Show(result);
                    }
                }
            }
        }

        private void InsClient_Load(object sender, EventArgs e)
        {

        }
    }
}
