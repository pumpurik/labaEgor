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
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        private void Operator_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            Form Transfers = new Transfers();
            Transfers.Show();
            this.Hide();
        }

        private void wokers_Click(object sender, EventArgs e)
        {
            Form Currency = new Currency();
            Currency.Show();
            this.Hide();
        }

        private void zayavka_Click(object sender, EventArgs e)
        {
            Form SchetaOp = new Scheta();
            SchetaOp.Show();
            this.Hide();
        }
    }
}
