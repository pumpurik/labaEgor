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
    public partial class AddSchetClient : Form
    {
        public AddSchetClient()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form Operator = new Operator();
            Operator.Show();
            this.Hide();
        }

        private void AddSchetClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void fioClient_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            if (fioClient.Text == "" || pasport.Text == "" || money.Text == "" || schet.Text == "")
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
                        MessageBox.Show("Введите корректную сумму счета!");
                    }
                    else
                    {
                        sqlCommandInsAcc.Parameters["@fioClient"].Value = fioClient.Text;
                        sqlCommandInsAcc.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandInsAcc.Parameters["@summa"].Value = money.Text;
                        sqlCommandInsAcc.Parameters["@schet"].Value = schet.Text;
                        sqlCommandInsAcc.Parameters["@dateop"].Value = DateTime.Now;

                        sqlConnectionAccount.Open();
                        sqlCommandInsAcc.ExecuteNonQuery();
                        sqlConnectionAccount.Close();
                        String result = (String)sqlCommandInsAcc.Parameters["@res"].Value;
                        MessageBox.Show(result);
                    }
                }
            }
        }

        private void pasport_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (fioClient.Text == "" || pasport.Text == "" || schet.Text == "")
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
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите закрыт счет?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommandDelAcc.Parameters["@fioClient"].Value = fioClient.Text;
                        sqlCommandDelAcc.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandDelAcc.Parameters["@schet"].Value = schet.Text;

                        sqlConnectionAccount.Open();
                        sqlCommandDelAcc.ExecuteNonQuery();
                        sqlConnectionAccount.Close();
                        String result = (String)sqlCommandDelAcc.Parameters["@res"].Value;
                        MessageBox.Show(result);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Закрытие отменено!");
                    }
                }
            }
        }
    }
}
