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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            Form Clients = new Clients();
            Clients.Show();
            this.Hide();
        }

        private void wokers_Click(object sender, EventArgs e)
        {
            Form Workers = new Workers();
            Workers.Show();
            this.Hide();
        }

        private void zayavka_Click(object sender, EventArgs e)
        {
            Form applications = new applications();
            applications.Show();
            this.Hide();

        }
    }
}
