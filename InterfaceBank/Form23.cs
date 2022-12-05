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
    public partial class Currency : Form
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Operator = new Operator();
            Operator.Show();
            this.Hide();
        }

        private void Currency_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void clients_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || fioClient.Text == "" || pasport.Text == "" || money.Text == "" || schet.Text == "" || cur.Text == "")
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
                            MessageBox.Show("Введите корректные паспортные данные!");
                        }
                        else
                        {
                        sqlCommandInsCur.Parameters["@fioW"].Value = fioWorker.Text;
                        sqlCommandInsCur.Parameters["@phone"].Value = phone.Text;
                        sqlCommandInsCur.Parameters["@fioClient"].Value = fioClient.Text;
                        sqlCommandInsCur.Parameters["@pasport"].Value = pasport.Text;
                        sqlCommandInsCur.Parameters["@summa"].Value = money.Text;
                        sqlCommandInsCur.Parameters["@schet"].Value = schet.Text;
                        sqlCommandInsCur.Parameters["@cur"].Value = cur.Text;
                        sqlCommandInsCur.Parameters["@dateop"].Value = DateTime.Now;
                       

                        sqlConnectionInsCur.Open();
                        sqlCommandInsCur.ExecuteNonQuery();
                        sqlConnectionInsCur.Close();
                        String result = (String)sqlCommandInsCur.Parameters["@res"].Value;
                        MessageBox.Show(result);
                        }
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fioWorker.Text == "" || phone.Text == "" || fioClient.Text == "" || pasport.Text == "" || money.Text == "" || schet.Text == "" || cur.Text == "" || date.Text == "")
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
                        MessageBox.Show("Введите корректные паспортные данные!");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Вы действительно хотите отменить перевод?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            sqlCommandDelCur.Parameters["@fioW"].Value = fioWorker.Text;
                            sqlCommandDelCur.Parameters["@phone"].Value = phone.Text;
                            sqlCommandDelCur.Parameters["@fioClient"].Value = fioClient.Text;
                            sqlCommandDelCur.Parameters["@pasport"].Value = pasport.Text;
                            sqlCommandDelCur.Parameters["@summa"].Value = money.Text;
                            sqlCommandDelCur.Parameters["@schet"].Value = schet.Text;
                            sqlCommandDelCur.Parameters["@cur"].Value = cur.Text;
                            sqlCommandDelCur.Parameters["@dateop"].Value = date.Text;


                            sqlConnectionInsCur.Open();
                            sqlCommandDelCur.ExecuteNonQuery();
                            sqlConnectionInsCur.Close();
                            String result = (String)sqlCommandDelCur.Parameters["@res"].Value;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
