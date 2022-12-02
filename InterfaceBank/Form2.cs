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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Scheta = new Scheta();
            Scheta.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void request_Click(object sender, EventArgs e)
        {
            Form Application = new Application();
            Application.Show();
            this.Hide();
        }

        private void arrenge_Click(object sender, EventArgs e)
        {
            
        }

        private void money_Click(object sender, EventArgs e)
        {
            Form Wmoney = new Wmoney();
            Wmoney.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            Form Payments = new Payments();
            Payments.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form historyOftransfers = new historyOftransfers();
            historyOftransfers.Show();
            this.Hide();
        }
    }
}
