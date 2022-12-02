﻿using System;
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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
            sqlConnectionWorker.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandWorker.ExecuteReader());
            Worker.DataSource = temp;
            sqlConnectionWorker.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Manager = new Manager();
            Manager.Show();
            this.Hide();
        }

        private void Workers_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Workers_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            sqlConnectionWorker.Close();
            sqlConnectionWorker.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandWorker.ExecuteReader());
            Worker.DataSource = temp;
            sqlConnectionWorker.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Поля 'ФИО' и 'номер телефона' обязательны к заполнению!");
            }
            if (phone.TextLength < 11)
            {
                MessageBox.Show("Введите корректный номер телефона!");
            }
            else
            {
                sqlCommandGetWorker.Parameters["@name"].Value = Fio.Text;
                sqlCommandGetWorker.Parameters["@phone"].Value = phone.Text;
                sqlConnectionWorker.Open();
                // создать временную таблицу temp
                var temp = new DataTable();
                // выполнить табличную функцию и вернуть таблицу в объект Reader
                // заполнить таблицу temp данными из Reader
                temp.Load(sqlCommandGetWorker.ExecuteReader());
                //устанавить связь с объектом типа dataGridView
                Worker.DataSource = temp;
                int rows = Worker.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("Такого клиента не существует!");

                    // закрыть соединение с БД

                }
                sqlConnectionWorker.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form InsWorker = new InsWorker();
            InsWorker.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form updateWorker = new updateWorker();
            updateWorker.Show();
            this.Hide();
        }
    }
}