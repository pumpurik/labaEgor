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
    public partial class ShowSchetaClient : Form
    {
        public ShowSchetaClient()
        {
            InitializeComponent();
            sqlConnectionSchetaClient.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandShow.ExecuteReader());
            Scheta.DataSource = temp;
            sqlConnectionSchetaClient.Close();
        }

        private void ShowSchetaClient_Load(object sender, EventArgs e)
        {

        }

        private void Scheta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            sqlConnectionSchetaClient.Close();
            sqlConnectionSchetaClient.Open();
            var temp = new DataTable();
            temp.Load(sqlCommandShow.ExecuteReader());
            Scheta.DataSource = temp;
            sqlConnectionSchetaClient.Close();
        }
    }
}
