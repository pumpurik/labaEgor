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
    public partial class Scheta : Form
    {
        public Scheta()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || pasport.Text == "" )
            {
                MessageBox.Show("Поля 'ФИО' и 'паспортные данные' обязательны к заполнению!");
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
                    sqlCommandAcc.Parameters["@name"].Value = Fio.Text;
                    sqlCommandAcc.Parameters["@pasport"].Value = pasport.Text;
                    sqlConnectionAcc.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandAcc.ExecuteReader());
                    tableAcc.DataSource = temp;
                    int rows = tableAcc.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("У вас нет счета! Проверьте правильность ФИО и паспортных данных или откройте счет!");
                    }
                    sqlConnectionAcc.Close();
                }
            }
        }

        private void Scheta_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void Scheta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form insSchet = new insSchet();
            insSchet.Show();
            this.Hide();
        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
           
        }
    }
}
