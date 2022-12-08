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
    public partial class ArrengeApp : Form
    {
        public ArrengeApp()
        {
            InitializeComponent();
        }

        private void ArrengeApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || type.Text == "" || pasport.Text=="" )
            {
                MessageBox.Show("Заполните данные!");
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
                    sqlCommandInsApp.Parameters["@fio"].Value = Fio.Text;
                    sqlCommandInsApp.Parameters["@pasport"].Value = pasport.Text;
                    sqlCommandInsApp.Parameters["@type_appl"].Value = type.Text;
                    sqlConnectionInsApp.Open();
                    sqlCommandInsApp.ExecuteNonQuery();
                    sqlConnectionInsApp.Close();
                    String result = (String)sqlCommandInsApp.Parameters["@res"].Value;
                    MessageBox.Show(result);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Application = new Application();
            Application.Show();
            this.Hide();
        }

        private void ArrengeApp_Load(object sender, EventArgs e)
        {

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pasport_KeyPress(object sender, KeyPressEventArgs e)
        {
            pasport.MaxLength = 10;   
        }
    }
}
