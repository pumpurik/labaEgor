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
    public partial class updateClient : Form
    {
        public updateClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Clients = new Clients();
            Clients.Show();
            this.Hide();
        }

        private void updateClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "")
            {
                MessageBox.Show("Заполните ФИО и паспортные данные для обновления данных!");
            }
            else
            {
                if (pasport.TextLength != 0 & pasport.TextLength < 10)
                {
                    MessageBox.Show("Введите корректные паспортные данные!");
                }
                else
                {
                    if (newPasport.TextLength != 0 & newPasport.TextLength < 10)
                    {
                        MessageBox.Show("Введите корректные паспортные данные!");
                    }
                    else
                    {
                        if (newPhone.TextLength != 0 & newPhone.TextLength < 11)
                        {
                            MessageBox.Show("Номер телефона заполнен неверно!");
                        }
                        else
                        {
                            if (newFio.Text == Fio.Text)
                            {
                                MessageBox.Show("Вы указали такую же фамилию!");
                                newFio.Text = "";
                            }
                            else
                            {
                                if (newPasport.Text == pasport.Text)
                                {
                                    MessageBox.Show("Вы указали те же паспортные данные!");
                                    newPasport.Text = "";
                                }
                                else
                                {
                                    sqlCommandUpClient.Parameters["@fio"].Value = Fio.Text;
                                    sqlCommandUpClient.Parameters["@pasport"].Value = pasport.Text;
                                    sqlCommandUpClient.Parameters["@newFio"].Value = newFio.Text;
                                    sqlCommandUpClient.Parameters["@newPasport"].Value = newPasport.Text;
                                    sqlCommandUpClient.Parameters["@newPhone"].Value = newPhone.Text;

                                    sqlConnectionUpClient.Open();
                                    sqlCommandUpClient.ExecuteNonQuery();
                                    sqlConnectionUpClient.Close();
                                    String result = (String)sqlCommandUpClient.Parameters["@res"].Value;
                                    if (newFio.TextLength != 0)
                                    {
                                        Fio.Text = "";
                                    }
                                    if (newPasport.TextLength != 0)
                                    {
                                        pasport.Text = "";
                                    }
                                    MessageBox.Show(result);
                                    newFio.Text = "";
                                    newPasport.Text = "";
                                    newPhone.Text = "";
                                }
                            }
                        }
                    }
                }
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

        private void newPasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            newPasport.MaxLength = 10;
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void newPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            newPhone.MaxLength = 11;
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
