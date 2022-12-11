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
    public partial class Transfers : Form
    {
        public Transfers()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            date.Value = now;
        }

        private void Transfers_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Operator = new Operator();
            Operator.Show();
            this.Hide();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == ""  ||  money.Text == "" || shetSender.Text==""|| schetRepicient.Text=="")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < shetSender.TextLength; i++)
                {
                    char ch = shetSender.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        shetSender.Text = "";
                        break;
                    }

                }
                if (shetSender.Text == "")
                {
                    MessageBox.Show("Неверный айди счета отправителя!");
                }
                else
                {
                    for (int i = 0; i < schetRepicient.TextLength; i++)
                    {
                        char ch = schetRepicient.Text[i];
                        if (ch < 48 || ch > 57)
                        {
                            schetRepicient.Text = "";
                            break;
                        }

                    }
                    if (schetRepicient.Text=="")
                    {
                        MessageBox.Show("Неверный айди счета получателя!");
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
                                MessageBox.Show("Введите корректную сумму перевода!");
                            }
                            else
                            {
                                sqlCommandDoTransfer.Parameters["@fioW"].Value = fioWorker.Text;
                                sqlCommandDoTransfer.Parameters["@phone"].Value = phone.Text;
                                sqlCommandDoTransfer.Parameters["@idSchetSender"].Value = shetSender.Text;
                                sqlCommandDoTransfer.Parameters["@summa"].Value = money.Text;
                                sqlCommandDoTransfer.Parameters["@idSchetRepicient"].Value = schetRepicient.Text;
                                sqlCommandDoTransfer.Parameters["@dateop"].Value = DateTime.Now;
                                sqlConnectionDoTransfer.Open();
                                sqlCommandDoTransfer.ExecuteNonQuery();
                                sqlConnectionDoTransfer.Close();
                                String result = (String)sqlCommandDoTransfer.Parameters["@res"].Value;
                                MessageBox.Show(result);
                            }
                        }
                    }
                }
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            phone.MaxLength = 11;

        }


        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
    
        }


        private void Transfers_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Transfers_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || money.Text == "" || shetSender.Text == "" || schetRepicient.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < shetSender.TextLength; i++)
                {
                    char ch = shetSender.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        shetSender.Text = "";
                        break;
                    }

                }
                if (shetSender.Text == "")
                {
                    MessageBox.Show("Неверный айди счета отправителя!");
                }
                else
                {
                    for (int i = 0; i < schetRepicient.TextLength; i++)
                    {
                        char ch = schetRepicient.Text[i];
                        if (ch < 48 || ch > 57)
                        {
                            schetRepicient.Text = "";
                            break;
                        }

                    }
                    if (schetRepicient.Text == "")
                    {
                        MessageBox.Show("Неверный айди счета получателя!");
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
                                MessageBox.Show("Введите корректную сумму перевода!");
                            }
                            else
                            {
                                sqlCommandDelTransfer.Parameters["@fioW"].Value = fioWorker.Text;
                                sqlCommandDelTransfer.Parameters["@phone"].Value = phone.Text;
                                sqlCommandDelTransfer.Parameters["@idSchetSender"].Value = shetSender.Text;
                                sqlCommandDelTransfer.Parameters["@summa"].Value = money.Text;
                                sqlCommandDelTransfer.Parameters["@idSchetRecipient"].Value = schetRepicient.Text;
                                sqlCommandDelTransfer.Parameters["@dateop"].Value = date.Text;
                                sqlConnectionDoTransfer.Open();
                                sqlCommandDelTransfer.ExecuteNonQuery();
                                sqlConnectionDoTransfer.Close();
                                String result = (String)sqlCommandDelTransfer.Parameters["@res"].Value;
                                MessageBox.Show(result);
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ShowSchetaClient = new ShowSchetaClient();
            ShowSchetaClient.Show(); 
        }

        private void schetRepicient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
