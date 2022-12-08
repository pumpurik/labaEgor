﻿using System;
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
            if (fioWorker.Text == "" || phone.Text == "" || fioSender.Text == "" || pasportSender.Text == "" ||  money.Text == "" || schetSender.Text == "" || fioRecipient.Text == "" || pasportRecipient.Text == "" || schetRecipient.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < pasportSender.TextLength; i++)
                {
                    char ch = pasportSender.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        pasportSender.Text = "";
                        break;
                    }

                }
                if ((pasportSender.TextLength != 0 & pasportSender.TextLength < 10) || pasportSender.Text == "")
                {
                    MessageBox.Show("Введите корректные паспортные данные отправителя!");
                }
                else
                {
                    for (int i = 0; i < pasportRecipient.TextLength; i++)
                    {
                        char ch = pasportRecipient.Text[i];
                        if (ch < 48 || ch > 57)
                        {
                            pasportRecipient.Text = "";
                            break;
                        }

                    }
                    if ((pasportRecipient.TextLength != 0 & pasportRecipient.TextLength < 10) || pasportRecipient.Text=="")
                    {
                        MessageBox.Show("Введите корректные паспортные данные получателя!");
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
                                sqlCommandDoTransfer.Parameters["@fioSender"].Value = fioSender.Text;
                                sqlCommandDoTransfer.Parameters["@pasportSender"].Value = pasportSender.Text;
                                sqlCommandDoTransfer.Parameters["@summa"].Value = money.Text;
                                sqlCommandDoTransfer.Parameters["@schetSender"].Value = schetSender.Text;
                                sqlCommandDoTransfer.Parameters["@fioRecipient"].Value = fioRecipient.Text;
                                sqlCommandDoTransfer.Parameters["@pasportRecipient"].Value = pasportRecipient.Text;
                                sqlCommandDoTransfer.Parameters["@schetRecipient"].Value = schetRecipient.Text;
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

        private void pasportSender_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasportSender.MaxLength = 10;

        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
    
        }

        private void pasportRecipient_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasportRecipient.MaxLength = 10;
 
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
            if (fioWorker.Text == "" || phone.Text == "" || fioSender.Text == "" || pasportSender.Text == "" || money.Text == "" || schetSender.Text == "" || fioRecipient.Text == "" || pasportRecipient.Text == "" || schetRecipient.Text == "" || date.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < pasportSender.TextLength; i++)
                {
                    char ch = pasportSender.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        pasportSender.Text = "";
                        break;
                    }

                }
                if ((pasportSender.TextLength != 0 & pasportSender.TextLength < 10) || pasportSender.Text == "")
                {
                    MessageBox.Show("Введите корректные паспортные данные отправителя!");
                }
                else
                {
                    for (int i = 0; i < pasportRecipient.TextLength; i++)
                    {
                        char ch = pasportRecipient.Text[i];
                        if (ch < 48 || ch > 57)
                        {
                            pasportRecipient.Text = "";
                            break;
                        }

                    }
                    if ((pasportRecipient.TextLength != 0 & pasportRecipient.TextLength < 10) || pasportRecipient.Text == "")
                    {
                        MessageBox.Show("Введите корректные паспортные данные получателя!");
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
                                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите отменить перевод?", "", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    sqlCommandDelTransfer.Parameters["@fioW"].Value = fioWorker.Text;
                                    sqlCommandDelTransfer.Parameters["@phone"].Value = phone.Text;
                                    sqlCommandDelTransfer.Parameters["@fioSender"].Value = fioSender.Text;
                                    sqlCommandDelTransfer.Parameters["@pasportSender"].Value = pasportSender.Text;
                                    sqlCommandDelTransfer.Parameters["@summa"].Value = money.Text;
                                    sqlCommandDelTransfer.Parameters["@schetSender"].Value = schetSender.Text;
                                    sqlCommandDelTransfer.Parameters["@fioRecipient"].Value = fioRecipient.Text;
                                    sqlCommandDelTransfer.Parameters["@pasportRecipient"].Value = pasportRecipient.Text;
                                    sqlCommandDelTransfer.Parameters["@schetRecipient"].Value = schetRecipient.Text;
                                    sqlCommandDelTransfer.Parameters["@dateop"].Value = date.Text;

                                    sqlConnectionDoTransfer.Open();
                                    sqlCommandDelTransfer.ExecuteNonQuery();
                                    sqlConnectionDoTransfer.Close();
                                    String result = (String)sqlCommandDelTransfer.Parameters["@res"].Value;
                                    MessageBox.Show(result);
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    MessageBox.Show("Операция отменена!");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
