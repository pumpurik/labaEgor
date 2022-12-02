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
    public partial class InsWorker : Form
    {
        public InsWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Workers = new Workers();
            Workers.Show();
            this.Hide();
        }

        private void InsWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            salary.MaxLength = 7;
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || position.Text == "" || phone.Text == "" || gender.Text == "" || salary.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                if (phone.TextLength < 11)
                {
                    MessageBox.Show("Номер телефона заполнен неверно!");
                }
                else
                {
                    sqlCommandInsWorker.Parameters["@fio"].Value = Fio.Text;
                    sqlCommandInsWorker.Parameters["@birth"].Value = date.Text;
                    sqlCommandInsWorker.Parameters["@gender"].Value = gender.Text;
                    sqlCommandInsWorker.Parameters["@phone"].Value = phone.Text;
                    sqlCommandInsWorker.Parameters["@position"].Value = position.Text;
                    sqlCommandInsWorker.Parameters["@salary"].Value = salary.Text;

                    sqlConnectionInsWorker.Open();
                    sqlCommandInsWorker.ExecuteNonQuery();
                    sqlConnectionInsWorker.Close();
                    String result = (String)sqlCommandInsWorker.Parameters["@res"].Value;
                    MessageBox.Show(result);
                }
            }
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
    }
}
