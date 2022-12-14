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
            if (Fio.Text == "" )
            {
                MessageBox.Show("Поле 'ФИО' обязательно к заполнению!");
            }
            else
            {
                    sqlCommandGetWorker.Parameters["@name"].Value = Fio.Text;
                    sqlConnectionWorker.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandGetWorker.ExecuteReader());
                    Worker.DataSource = temp;
                    int rows = Worker.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("Такого сотрудника не существует!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (position.Text == "")
            {
                MessageBox.Show("Поле 'Должность' обязательно к заполнению!");
            }
            else
            {
                sqlCommandGetWorkerByPosition.Parameters["@position"].Value = position.Text;
                sqlConnectionWorker.Open();
                var temp = new DataTable();
                temp.Load(sqlCommandGetWorkerByPosition.ExecuteReader());
                Worker.DataSource = temp;
                int rows = Worker.Rows.Count;
                if (rows == 0)
                {
                    MessageBox.Show("Таких сотрудников не существует!");
                }
                sqlConnectionWorker.Close();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
