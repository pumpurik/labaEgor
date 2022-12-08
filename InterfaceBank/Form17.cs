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
    public partial class applications : Form
    {
        public applications()
        {
            InitializeComponent();
        }

        private void applications_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Manager = new Manager();
            Manager.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Form  upapp = new upapp();
            upapp.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Поля 'ФИО' и 'номер телефона' обязательны к заполнению!");
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
                    sqlCommandGetApp.Parameters["@fio"].Value = Fio.Text;
                    sqlCommandGetApp.Parameters["@phone"].Value = phone.Text;
                    sqlConnectionGetApp.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandGetApp.ExecuteReader());
                    Worker.DataSource = temp;
                    int rows = Worker.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("На данный момент заявлений нет! Проверьте правильность ввода ФИО и номера телефона!");
                    }
                    sqlConnectionGetApp.Close();
                }
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            phone.MaxLength = 11;
           
        }
    }
}
