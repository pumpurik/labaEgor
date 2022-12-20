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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    

        private void Search_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "" ) 
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
                    sqlCommandGetPay.Parameters["@fio"].Value = Fio.Text;
                    sqlCommandGetPay.Parameters["@pasport"].Value = pasport.Text;
                    sqlConnectionGetPay.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandGetPay.ExecuteReader());
                    tablePayment.DataSource = temp;
                    int rows = tablePayment.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("У вас нет платежных поручений! Проверьте правильность ФИО и паспортных данных!");
                    }
                    
                    sqlConnectionGetPay.Close();
                    tablePayment.Sort(tablePayment.Columns[1], ListSortDirection.Ascending);
                    
                }
            }
        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
        }

        private void tablePayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tablePayment.Rows[e.RowIndex];
                String name = row.Cells["Отправитель"].Value.ToString();
                String date = row.Cells["Дата отправки"].Value.ToString();
                String sum = row.Cells["Сумма"].Value.ToString();
                String type = row.Cells["Тип счета"].Value.ToString();
                String status = row.Cells["Статус оплаты"].Value.ToString();


                sqlCommandPayment.Parameters["@fio"].Value = Fio.Text;
                sqlCommandPayment.Parameters["@pasport"].Value = pasport.Text;
                sqlCommandPayment.Parameters["@type_pay"].Value = name;
                sqlCommandPayment.Parameters["@date"].Value = date;
                sqlCommandPayment.Parameters["@summa"].Value = sum;
                sqlCommandPayment.Parameters["@schet"].Value = type;

                sqlConnectionGetPay.Open();

                sqlCommandPayment.ExecuteNonQuery();
                sqlConnectionGetPay.Close();
                String result = (String)sqlCommandPayment.Parameters["@res"].Value;
                MessageBox.Show(result);
            }

        }
    }
}
