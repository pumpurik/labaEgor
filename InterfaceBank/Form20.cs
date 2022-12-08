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
    public partial class PaymentsPay : Form
    {
        public PaymentsPay()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            date.Value = now;
        }

        private void PaymentsPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Payments = new Payments();
            Payments.Show();
            this.Hide();
        }

        private void arrenge_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "" || position.Text == "" || money.Text == "" || schet.Text == "")
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
                        sqlCommandPayment.Parameters["@fio"].Value = Fio.Text;
                        sqlCommandPayment.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandPayment.Parameters["@type_pay"].Value = position.Text;
                        sqlCommandPayment.Parameters["@date"].Value = date.Text;
                        sqlCommandPayment.Parameters["@summa"].Value = money.Text;
                        sqlCommandPayment.Parameters["@schet"].Value = schet.Text;

                        sqlConnectionPayment.Open();
                        sqlCommandPayment.ExecuteNonQuery();
                        sqlConnectionPayment.Close();
                        String result = (String)sqlCommandPayment.Parameters["@res"].Value;
                        MessageBox.Show(result);
                    }
                }

                
            }
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
        }
    }
}
