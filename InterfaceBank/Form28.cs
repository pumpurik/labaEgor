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
    public partial class HistoryOfOperations : Form
    {
        public HistoryOfOperations()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            date1.Value = now;
            date2.Value = now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Manager = new Manager();
            Manager.Show();
            this.Hide();
        }

        private void HistoryOfOperations_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (date1.Text == "" || date2.Text == "")
            {
                MessageBox.Show("Заполните даты!");
            }
            else
            {
                sqlCommandIssuF.Parameters["@date1"].Value = date1.Text;
                sqlCommandIssuF.Parameters["@date2"].Value = date2.Text;
                sqlConnectionOperations.Open();
                var temp = new DataTable();
                temp.Load(sqlCommandIssuF.ExecuteReader());
                operationsM.DataSource = temp;
                int rows = operationsM.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("За данный период нет записей!");
                }
                operationsM.Sort(operationsM.Columns[2], ListSortDirection.Descending);
                sqlConnectionOperations.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (date1.Text == "" || date2.Text == "")
            {
                MessageBox.Show("Заполните даты!");
            }
            else
            {
                sqlCommandCurrency.Parameters["@date1"].Value = date1.Text;
                sqlCommandCurrency.Parameters["@date2"].Value = date2.Text;
                sqlConnectionOperations.Open();
                var temp = new DataTable();
                temp.Load(sqlCommandCurrency.ExecuteReader());
                operationsM.DataSource = temp;
                int rows = operationsM.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("За данный период нет записей!");
                }
                operationsM.Sort(operationsM.Columns[5], ListSortDirection.Descending);
                sqlConnectionOperations.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (date1.Text == "" || date2.Text == "")
            {
                MessageBox.Show("Заполните даты!");
            }
            else
            {
                sqlCommandTransfers.Parameters["@date1"].Value = date1.Text;
                sqlCommandTransfers.Parameters["@date2"].Value = date2.Text;
                sqlConnectionOperations.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandTransfers.ExecuteReader());
                operationsM.DataSource = temp;
                    int rows = operationsM.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("За данный период нет записей!");
                    }
                operationsM.Sort(operationsM.Columns[5], ListSortDirection.Descending);
                sqlConnectionOperations.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (date1.Text == "" || date2.Text == "")
            {
                MessageBox.Show("Заполните даты!");
            }
            else
            {
                sqlCommandPayment.Parameters["@date1"].Value = date1.Text;
                sqlCommandPayment.Parameters["@date2"].Value = date2.Text;
                sqlConnectionOperations.Open();
                var temp = new DataTable();
                temp.Load(sqlCommandPayment.ExecuteReader());
                operationsM.DataSource = temp;
                int rows = operationsM.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("За данный период нет записей!");
                }
                operationsM.Sort(operationsM.Columns[3], ListSortDirection.Descending);
                sqlConnectionOperations.Close();
            }
        }
    }
    
}
