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
    public partial class updateWorker : Form
    {
        public updateWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Workers = new Workers();
            Workers.Show();
            this.Hide();
        }

        private void updateWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Заполните ФИО и номер телефона для увольнения сотрудника!");
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
                    DialogResult dialogResult = MessageBox.Show("Вы действительно хотите уволить данного сотрудника?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCommandDelWorker.Parameters["@fio"].Value = Fio.Text;
                        sqlCommandDelWorker.Parameters["@phone"].Value = phone.Text;

                        sqlConnectionWorker.Open();
                        sqlCommandDelWorker.ExecuteNonQuery();
                        sqlConnectionWorker.Close();
                        String result = (String)sqlCommandDelWorker.Parameters["@res"].Value;
                        Fio.Text = "";
                        phone.Text = "";
                        MessageBox.Show(result);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Увольнение отменено!");
                    }
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Fio.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Заполните ФИО и номер телефона для увольнения сотрудника!");
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
                if (phone.TextLength < 11 || phone.Text == "")
                {
                    MessageBox.Show("Введите корректный номер телефона!");
                }
                else
                {
                    if (newPhone.TextLength != 0)
                    {
                        for (int i = 0; i < newPhone.TextLength; i++)
                        {
                            char ch = newPhone.Text[i];
                            if (ch < 48 || ch > 57)
                            {
                                newPhone.Text = "";
                                break;
                            }

                        }
                        if (newPhone.Text == "" || newPhone.TextLength < 11)
                        {
                            MessageBox.Show("Введите корректный новый номер телефона!");
                            newPhone.Text = "";
                            return;
                        }           
                    }
                    //уловие зп
                    if (newSalary.TextLength != 0)
                    {
                        for (int i = 0; i < newSalary.TextLength; i++)
                        {
                            char ch = newSalary.Text[i];
                            if (ch < 48 || ch > 57)
                            {
                                newSalary.Text = "";
                                break;
                            }

                        }
                        if (newSalary.Text == "")
                        {
                            MessageBox.Show("Введите корректную зарплату!");
                            newSalary.Text = "";
                            return;
                        }
                    }
         
                            if (newFio.Text == Fio.Text)
                            {
                                MessageBox.Show("Вы указали такую же фамилию!");
                                newFio.Text = "";
                                return;
                            }
                            else
                            {
                                if (newPhone.Text == phone.Text)
                                {
                                    MessageBox.Show("Вы указали такой же номер!");
                                    newPhone.Text = "";
                                    return;
                                }
                                else
                                {
                                    sqlCommandUpWorker.Parameters["@fio"].Value = Fio.Text;
                                    sqlCommandUpWorker.Parameters["@phone"].Value = phone.Text;
                                    sqlCommandUpWorker.Parameters["@newFio"].Value = newFio.Text;
                                    sqlCommandUpWorker.Parameters["@newPhone"].Value = newPhone.Text;
                                    sqlCommandUpWorker.Parameters["@newSalary"].Value = newSalary.Text;

                                    sqlConnectionWorker.Open();
                                    sqlCommandUpWorker.ExecuteNonQuery();
                                    sqlConnectionWorker.Close();
                                    String result = (String)sqlCommandUpWorker.Parameters["@res"].Value;
                                    if (newFio.TextLength != 0)
                                    {
                                        Fio.Text = "";
                                    }
                                    if (newPhone.TextLength != 0)
                                    {
                                        phone.Text = "";
                                    }
                                    MessageBox.Show(result);
                                    newPhone.Text = "";
                                    newFio.Text = "";
                                    newSalary.Text = "";
                                }
                            }
                    
                }
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            phone.MaxLength = 11;
        
        }

        private void newPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            newPhone.MaxLength = 11;
        
        }

        private void newSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
