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
    public partial class upapp : Form
    {
        public upapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form applications = new applications();
            applications.Show();
            this.Hide();
        }

        private void upapp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void update_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "" || status.Text=="")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                if (phone.TextLength != 0 & phone.TextLength < 11)
                {
                    MessageBox.Show("Введите корректный номер телефона!");
                }
                else
                {
                    if (pasport.TextLength != 0 & pasport.TextLength < 10)
                    {
                        MessageBox.Show("Введите корректные паспортные данные!");
                    }
                    else
                    {

                        sqlCommandUpApp.Parameters["@fio"].Value = Fio.Text;
                        sqlCommandUpApp.Parameters["@phone"].Value = phone.Text;
                        sqlCommandUpApp.Parameters["@fioCli"].Value = fioCli.Text;
                        sqlCommandUpApp.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandUpApp.Parameters["@status"].Value = status.Text;

                        sqlConnectionUpApp.Open();
                        sqlCommandUpApp.ExecuteNonQuery();
                        sqlConnectionUpApp.Close();
                        String result = (String)sqlCommandUpApp.Parameters["@res"].Value;  
                        MessageBox.Show(result);
                    }

                }
            }
        }
    }
}
