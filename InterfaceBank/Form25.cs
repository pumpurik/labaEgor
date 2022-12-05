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
    public partial class sendPaymentOrder : Form
    {
        public sendPaymentOrder()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form Operator = new Operator();
            Operator.Show();
            this.Hide();
        }

        private void sendPaymentOrder_FormClosing(object sender, FormClosingEventArgs e)
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

        private void money_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Open_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || fioClient.Text == "" || pasport.Text == "" || money.Text == "" || position.Text == "" )
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                if (pasport.TextLength != 0 & pasport.TextLength < 10)
                {
                    MessageBox.Show("Введите корректные паспортные данные!");
                }
                else
                {
                    if (phone.TextLength != 0 & phone.TextLength < 11)
                    {
                        MessageBox.Show("Введите корректный номер телефона!");
                    }
                    else
                    {
                        sqlCommandInsPay.Parameters["@fioW"].Value = fioWorker.Text;
                        sqlCommandInsPay.Parameters["@phone"].Value = phone.Text;
                        sqlCommandInsPay.Parameters["@fioClient"].Value = fioClient.Text;
                        sqlCommandInsPay.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandInsPay.Parameters["@sum_order"].Value = money.Text;
                        sqlCommandInsPay.Parameters["@type_pay"].Value = position.Text;
                        sqlCommandInsPay.Parameters["@dateop"].Value = DateTime.Now;
                        sqlConnectionPaymentOrder.Open();
                        sqlCommandInsPay.ExecuteNonQuery();
                        sqlConnectionPaymentOrder.Close();
                        String result = (String)sqlCommandInsPay.Parameters["@res"].Value;
                        MessageBox.Show(result);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form DelPayOrder = new DelPayOrder();
            DelPayOrder.Show();
            this.Hide();
        }
    }
}
