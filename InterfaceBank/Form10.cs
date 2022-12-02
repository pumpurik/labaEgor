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
    public partial class insSchet : Form
    {
        public insSchet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Scheta = new Scheta();
            Scheta.Show();
            this.Hide();
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void insSchet_Load(object sender, EventArgs e)
        {

        }

        private void upSchet_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || money.Text == "" || scheta.Text == "")
            {
                MessageBox.Show("Заполните данные!");
            }
            else
            {
                if (pasport.TextLength != 0 & pasport.TextLength < 10)
                {
                    MessageBox.Show("Введите корректные паспортные данные!");
                }
                else
                {
                    sqlCommandUpAcc.Parameters["@fio"].Value = Fio.Text;
                    sqlCommandUpAcc.Parameters["@pasport"].Value = pasport.Text;
                    sqlCommandUpAcc.Parameters["@sum"].Value = money.Text;
                    sqlCommandUpAcc.Parameters["@type_acc"].Value = scheta.Text;
                    sqlConnectionUpAcc.Open();
                    sqlCommandUpAcc.ExecuteNonQuery();
                    sqlConnectionUpAcc.Close();
                    String result = (String)sqlCommandUpAcc.Parameters["@res"].Value;
                    MessageBox.Show(result);
                }
            }
        }

        private void insSchet_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void money_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b')
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
