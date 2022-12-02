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
    public partial class updateWorker : Form
    {
        public updateWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Workers = new Workers();
            Workers.Show();
            this.Hide();
        }

        private void updateWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Заполните ФИО и номер телефона для увольнения сотрудника!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите уволить данного сотрудника?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                sqlCommandDelWorker.Parameters["@fio"].Value = Fio.Text;
                sqlCommandDelWorker.Parameters["@phone"].Value = phone.Text;

                sqlConnectionWorker.Open();
                sqlCommandDelWorker.ExecuteNonQuery();
                sqlConnectionWorker.Close();
                String result = (String)sqlCommandDelWorker.Parameters["@res"].Value;
                Fio.Text = "";   
                phone.Text = "";
                MessageBox.Show(result);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Увольнение отменено!");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Заполните ФИО и номер телефона для увольнения сотрудника!");
            }
            else
            {
                if (phone.TextLength != 0 & phone.TextLength < 10)
                {
                    MessageBox.Show("Введите корректный номер телефона!");
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
                            if (newPhone.Text == phone.Text)
                            {
                                MessageBox.Show("Вы указали такой же номер!");
                                newPhone.Text = "";
                            }
                            else
                            {
                                sqlCommandUpWorker.Parameters["@fio"].Value = Fio.Text;
                                sqlCommandUpWorker.Parameters["@phone"].Value = phone.Text;
                                sqlCommandUpWorker.Parameters["@newFio"].Value = newFio.Text;
                                sqlCommandUpWorker.Parameters["@newPhone"].Value = newPhone.Text;
                                sqlCommandUpWorker.Parameters["@newSalary"].Value = newSalary.Text;

                                sqlConnectionWorker.Open();
                                sqlCommandUpWorker.ExecuteNonQuery();
                                sqlConnectionWorker.Close();
                                String result = (String)sqlCommandUpWorker.Parameters["@res"].Value;
                                if (newFio.TextLength != 0)
                                {
                                    Fio.Text = "";
                                }
                                if (newPhone.TextLength != 0)
                                {
                                    phone.Text = "";
                                }
                                MessageBox.Show(result);
                                newPhone.Text = "";
                                newFio.Text = "";
                                newSalary.Text = "";
                            }
                        }
                   }
                    
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

        private void newSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            newSalary.MaxLength = 7;
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