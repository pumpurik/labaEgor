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
    public partial class DelPayOrder : Form
    {
        public DelPayOrder()
        {
            InitializeComponent();
        }

        private void DelPayOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form sendPaymentOrder = new sendPaymentOrder();
            sendPaymentOrder.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || fioClient.Text == "" || pasport.Text == "" || money.Text == "" || position.Text == "" || schet.Text == "" || date.Text=="")
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
                        DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данное платежное поручение?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            sqlCommandDelPay.Parameters["@fioW"].Value = fioWorker.Text;
                            sqlCommandDelPay.Parameters["@phone"].Value = phone.Text;
                            sqlCommandDelPay.Parameters["@fioClient"].Value = fioClient.Text;
                            sqlCommandDelPay.Parameters["@pasport"].Value = pasport.Text;
                            sqlCommandDelPay.Parameters["@sum_order"].Value = money.Text;
                            sqlCommandDelPay.Parameters["@type_pay"].Value = position.Text;
                            sqlCommandDelPay.Parameters["@dateop"].Value = date.Text;
                            sqlCommandDelPay.Parameters["@schet"].Value = schet.Text;
                            sqlConnectionDelPay.Open();
                            sqlCommandDelPay.ExecuteNonQuery();
                            sqlConnectionDelPay.Close();
                            String result = (String)sqlCommandDelPay.Parameters["@res"].Value;
                            MessageBox.Show(result);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Удаление отменено!");
                        }
                    }

                }
            }
        }

        private void DelPayOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
