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
    public partial class historyOftransfers : Form
    {
        public historyOftransfers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void historyOftransfers_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "")
            {
                MessageBox.Show("Заполните поле 'ФИО'!");
            }
            else
            {
                sqlCommandGetTransfer.Parameters["@name"].Value = Fio.Text;

                sqlConnectionGetTransfer.Open();
                var temp = new DataTable();
                temp.Load(sqlCommandGetTransfer.ExecuteReader()); ;
                moneyH.DataSource = temp;
                int rows = moneyH.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("У вас нет истории снятия денег! Проверьте правильность ФИО и паспортных данных или снимите деньги!");
                }
                moneyH.Sort(moneyH.Columns[4], ListSortDirection.Descending);
                sqlConnectionGetTransfer.Close();

            }
        }    
    }
}
