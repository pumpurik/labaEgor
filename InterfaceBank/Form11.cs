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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            sqlConnectionClient.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandClientTable.ExecuteReader());
            Client.DataSource = temp;
            sqlConnectionClient.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Manager = new Manager();
            Manager.Show();
            this.Hide();
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
         
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "")
            {
                MessageBox.Show("Поля 'ФИО' и 'паспорт' обязательны к заполнению!");
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
                    sqlCommandGetClient.Parameters["@name"].Value = Fio.Text;
                    sqlCommandGetClient.Parameters["@passport"].Value = pasport.Text;
                    sqlConnectionClient.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandGetClient.ExecuteReader());
                    Client.DataSource = temp;
                    int rows = Client.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("Такого клиента не существует!");
                    }
                    sqlConnectionClient.Close();
                }
            }
            
        }

        private void show_Click(object sender, EventArgs e)
        {
            sqlConnectionClient.Close();
            sqlConnectionClient.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandClientTable.ExecuteReader());
            Client.DataSource = temp;
            sqlConnectionClient.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "")
            {
                MessageBox.Show("Заполните данные!");
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
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данного клиента?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommandDelClient.Parameters["@name"].Value = Fio.Text;
                        sqlCommandDelClient.Parameters["@passport"].Value = pasport.Text;
                        sqlConnectionClient.Open();
                        sqlCommandDelClient.ExecuteNonQuery();
                        sqlConnectionClient.Close();
                        String result = (String)sqlCommandDelClient.Parameters["@res"].Value;
                        MessageBox.Show(result);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Удаление отменено!");
                    }
                }
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form InsClient = new InsClient();
            InsClient.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form updateClient = new updateClient();
            updateClient.Show();
            this.Hide();
        }
    }
}
