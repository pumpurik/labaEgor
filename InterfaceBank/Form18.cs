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
    public partial class upapp : Form
    {
        public upapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form applications = new applications();
            applications.Show();
            this.Hide();
        }

        private void upapp_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            phone.MaxLength = 11;
        }


        private void update_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "" || status.Text=="")
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                for (int i = 0; i < phone.TextLength; i++)
                {
                    char ch = phone.Text[i];
                    if (ch < 48 || ch > 57)
                    {
                        phone.Text = "";
                        break;
                    }

                }
                if ((phone.TextLength != 0 & phone.TextLength < 11) || phone.Text == "")
                {
                    MessageBox.Show("Введите корректный номер телефона!");
                }
                else
                {
                    for (int i = 0; i < id.TextLength; i++)
                    {
                        char ch = id.Text[i];
                        if (ch < 48 || ch > 57)
                        {
                            id.Text = "";
                            break;
                        }

                    }
                    if ( id.Text == "")
                    {
                        MessageBox.Show("Неверное айди!");
                    }
                    else
                    {

                        sqlCommandUpApp.Parameters["@fio"].Value = Fio.Text;
                        sqlCommandUpApp.Parameters["@phone"].Value = phone.Text;
                        sqlCommandUpApp.Parameters["@idAp"].Value = id.Text;
                        sqlCommandUpApp.Parameters["@status"].Value = status.Text;

                        sqlConnectionUpApp.Open();
                        sqlCommandUpApp.ExecuteNonQuery();
                        sqlConnectionUpApp.Close();
                        String result = (String)sqlCommandUpApp.Parameters["@res"].Value;  
                        MessageBox.Show(result);
                    }

                }
            }
        }
    }
}
