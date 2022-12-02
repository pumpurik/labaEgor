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
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
            /* pasport.ShortcutsEnabled = false;*/
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "" )
            {
                MessageBox.Show("Поля 'ФИО' и 'паспорт' обязательны к заполнению!");
            }
            if (pasport.TextLength < 10)
            {
                MessageBox.Show("Введите корректные паспортные данные!");
            }
            else
            {
                sqlCommandGetClient.Parameters["@name"].Value = Fio.Text;
                sqlCommandGetClient.Parameters["@passport"].Value = pasport.Text;
                sqlConnectionClient.Open();
                // создать временную таблицу temp
                var temp = new DataTable();
                // выполнить табличную функцию и вернуть таблицу в объект Reader
                // заполнить таблицу temp данными из Reader
                temp.Load(sqlCommandGetClient.ExecuteReader());
                //устанавить связь с объектом типа dataGridView
                Client.DataSource = temp;
                int rows = Client.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("Такого клиента не существует!");

                    // закрыть соединение с БД
                    
                }
                sqlConnectionClient.Close();
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
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данного клиента?","", MessageBoxButtons.YesNo);
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
