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
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "")
            {
                MessageBox.Show("Поля 'ФИО' и 'паспортные данные' обязательны к заполнению!");
            }
            else
            {
                if (pasport.TextLength != 0 & pasport.TextLength < 10)
                {
                    MessageBox.Show("Введите корректные паспортные данные!");
                }
                else
                {
                    sqlCommandGetApp.Parameters["@name"].Value = Fio.Text;
                    sqlCommandGetApp.Parameters["@pasport"].Value = pasport.Text;
                    sqlConnectionGetApp.Open();
                    // создать временную таблицу temp
                    var temp = new DataTable();
                    // выполнить табличную функцию и вернуть таблицу в объект Reader
                    // заполнить таблицу temp данными из Reader
                    temp.Load(sqlCommandGetApp.ExecuteReader());
                    //устанавить связь с объектом типа dataGridView
                    tableApp.DataSource = temp;
                    int rows = tableApp.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("У вас нет заявок! Проверьте правильность ФИО и паспортных данных или оформите заявку!");
                    }
                    // закрыть соединение с БД
                    sqlConnectionGetApp.Close();
                }
            }
        }

        private void Application_Load(object sender, EventArgs e)
        {

        }

        private void Application_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void arrenge_Click(object sender, EventArgs e)
        {
            Form ArrengeApp = new ArrengeApp();
            ArrengeApp.Show();
            this.Hide();
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
