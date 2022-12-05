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
            if (fioClient.Text == "" || pasport.Text == "" || money.Text == "" || schet.Text == "")
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
                if (pasport.TextLength != 0 & pasport.TextLength < 10)
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
