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
    public partial class Wmoney : Form
    {
        public Wmoney()
        {
            InitializeComponent();
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void Wmoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void getMoney_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || money.Text == "" || scheta.Text == "" || pasport.Text=="" )
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
                    sqlCommandInsIssu.Parameters["@fio"].Value = Fio.Text;
                    sqlCommandInsIssu.Parameters["@pasport"].Value = pasport.Text;
                    sqlCommandInsIssu.Parameters["@sum"].Value = money.Text;
                    sqlCommandInsIssu.Parameters["@type_acc"].Value = scheta.Text;
                    sqlCommandInsIssu.Parameters["@date"].Value = DateTime.Now;
                    sqlConnectionInsIssu.Open();
                    sqlCommandInsIssu.ExecuteNonQuery();
                    sqlConnectionInsIssu.Close();
                    String result = (String)sqlCommandInsIssu.Parameters["@res"].Value;
                    MessageBox.Show(result);
                }
            }
        }

        private void scheta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {
            Form HistoryOfMoney = new HistoryOfMoney();
            HistoryOfMoney.Show();
            this.Hide();
        }

        private void Wmoney_Load(object sender, EventArgs e)
        {

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
