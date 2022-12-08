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
    public partial class HistoryOfMoney : Form
    {
        public HistoryOfMoney()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Wmoney = new Wmoney();
            Wmoney.Show();
            this.Hide();
        }

        private void HistoryOfMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text=="" )
            {
                MessageBox.Show("Заполните все данные!");
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
                    sqlCommandHM.Parameters["@name"].Value = Fio.Text;
                    sqlCommandHM.Parameters["@pasport"].Value = pasport.Text;
                    sqlConnectionHM.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandHM.ExecuteReader());
                    moneyH.DataSource = temp;
                    int rows = moneyH.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("У вас нет истории снятия денег! Проверьте правильность ФИО и паспортных данных или снимите деньги!");
                    }
                    moneyH.Sort(moneyH.Columns[1], ListSortDirection.Descending);
                    sqlConnectionHM.Close();
                }
            }
        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
          
        }
    }
}
