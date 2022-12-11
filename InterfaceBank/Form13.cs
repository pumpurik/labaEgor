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
                    if (newPasport.TextLength != 0)
                    {
                        for (int i = 0; i < newPasport.TextLength; i++)
                        {
                            char ch = newPasport.Text[i];
                            if (ch < 48 || ch > 57)
                            {
                                newPasport.Text = "";
                                break;
                            }

                        }
                        if ( newPasport.TextLength < 10 || newPasport.Text == "")
                        {
                            MessageBox.Show("Введите корректные новые паспортные данные!");
                            return;
                        }
                    }
                    if (newPhone.TextLength != 0)
                    {
                        for (int i = 0; i < newPhone.TextLength; i++)
                        {
                            char ch = newPhone.Text[i];
                            if (ch < 48 || ch > 57)
                            {
                                newPhone.Text = "";
                                break;
                            }

                        }
                        if ( newPhone.TextLength < 11 || newPhone.Text == "")
                        {
                            MessageBox.Show("Новый номер телефона заполнен неверно!");
                            return;
                        }
                    }
                    if (newFio.Text == Fio.Text)
                        {
                            MessageBox.Show("Вы указали такую же фамилию!");
                            newFio.Text = "";
                            return;
                    }
                    else
                    {
                        if (newPasport.Text == pasport.Text)
                        {
                            MessageBox.Show("Вы указали те же паспортные данные!");
                            newPasport.Text = "";
                            return;
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

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
         
        }

        private void newPasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            newPasport.MaxLength = 10;
          
        }

        private void newPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            newPhone.MaxLength = 11;
       
        }
    }
}
