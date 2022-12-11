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
            DateTime now = DateTime.Now;
            date.Value = now;
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
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || idSchet.Text == "" || money.Text == "" || position.Text == "" || date.Text=="")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < idSchet.TextLength; i++)
                {
                    char ch = idSchet.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        idSchet.Text = "";
                        break;
                    }

                }
                if (idSchet.Text=="")
                {
                    MessageBox.Show("Неверный айди счета!");
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
                            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данное платежное поручение?", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                sqlCommandDelPay.Parameters["@fioW"].Value = fioWorker.Text;
                                sqlCommandDelPay.Parameters["@phone"].Value = phone.Text;
                                sqlCommandDelPay.Parameters["@idSchet"].Value = idSchet.Text;
                                sqlCommandDelPay.Parameters["@sum_order"].Value = money.Text;
                                sqlCommandDelPay.Parameters["@type_pay"].Value = position.Text;
                                sqlCommandDelPay.Parameters["@dateop"].Value = date.Text;
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
        }

        private void DelPayOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ShowSchetaClient = new ShowSchetaClient();
            ShowSchetaClient.Show();
        }
    }
}
