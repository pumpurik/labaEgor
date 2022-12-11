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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            sqlConnectionClient.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandClientTable.ExecuteReader());
            Client.DataSource = temp;
            sqlConnectionClient.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Manager = new Manager();
            Manager.Show();
            this.Hide();
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" )
            {
                MessageBox.Show("Поле 'ФИО' обязательно к заполнению!");
            }
            else
            {
               
                    sqlCommandGetClient.Parameters["@name"].Value = Fio.Text;
                    
                    sqlConnectionClient.Open();
                    var temp = new DataTable();
                    temp.Load(sqlCommandGetClient.ExecuteReader());
                    Client.DataSource = temp;
                    int rows = Client.Rows.Count;
                    if (rows == 0)
                    {
                        MessageBox.Show("Такого клиента не существует!");
                    }
                    sqlConnectionClient.Close();
                
            }
            
        }

        private void show_Click(object sender, EventArgs e)
        {
            sqlConnectionClient.Close();
            sqlConnectionClient.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandClientTable.ExecuteReader());
            Client.DataSource = temp;
            sqlConnectionClient.Close();
        }

       
        

        private void button4_Click(object sender, EventArgs e)
        {
            Form InsClient = new InsClient();
            InsClient.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form updateClient = new updateClient();
            updateClient.Show();
            this.Hide();
        }
    }
}
