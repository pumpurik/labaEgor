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

                if (pasport.TextLength != 0 & pasport.TextLength < 10)
                {
                    MessageBox.Show("Введите корректные паспортные данные!");
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
    }
}
