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

        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
  
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || fioClient.Text == "" || pasport.Text == "" || money.Text == "" || position.Text == "" )
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < pasport.TextLength; i++)
                {
                    char ch = pasport.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        pasport.Text = "";
                        break;
                    }

                }
                if ((pasport.TextLength != 0 & pasport.TextLength < 10) || pasport.Text == "")
                {
                    MessageBox.Show("Введите корректные паспортные данные!");
                }
                else
                {
                    for (int i = 0; i < phone.TextLength; i++)
                    {
                        char ch = phone.Text[i];
                        if (ch < 48 || ch > 57)
                        {
                            phone.Text = "";
                            break;
                        }

                    }
                    if ((phone.TextLength != 0 & phone.TextLength < 11) || phone.Text == "")
                    {
                        MessageBox.Show("Введите корректный номер телефона!");
                    }
                    else
                    {
                        for (int i = 0; i < money.TextLength; i++)
                        {
                            char ch = money.Text[i];
                            if (ch < 48 || ch > 57)
                            {
                                money.Text = "";
                                break;
                            }

                        }
                        if (money.Text == "")
                        {
                            MessageBox.Show("Введите корректную сумму оплаты!");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form DelPayOrder = new DelPayOrder();
            DelPayOrder.Show();
            this.Hide();
        }
    }
}
