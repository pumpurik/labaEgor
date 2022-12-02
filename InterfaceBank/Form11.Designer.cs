namespace InterfaceBank
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.pasport = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sqlConnectionClient = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandClientTable = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandGetClient = new System.Data.SqlClient.SqlCommand();
            this.show = new System.Windows.Forms.Button();
            this.sqlCommandDelClient = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.Client)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите полные ФИО клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(26, 90);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 10;
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(26, 157);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(190, 20);
            this.pasport.TabIndex = 11;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // Client
            // 
            this.Client.AllowUserToAddRows = false;
            this.Client.AllowUserToDeleteRows = false;
            this.Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Client.Location = new System.Drawing.Point(26, 207);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(505, 166);
            this.Client.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(611, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Найти ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(611, 157);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(149, 55);
            this.delete.TabIndex = 14;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(611, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 55);
            this.button4.TabIndex = 15;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(611, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 55);
            this.button5.TabIndex = 16;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sqlConnectionClient
            // 
            this.sqlConnectionClient.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionClient.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandClientTable
            // 
            this.sqlCommandClientTable.CommandText = "SELECT        FIO AS ФИО, passport AS [Паспортные данные], phone, birth AS [Дата " +
    "рождения], gender AS Пол\r\nFROM            clients";
            this.sqlCommandClientTable.Connection = this.sqlConnectionClient;
            // 
            // sqlCommandGetClient
            // 
            this.sqlCommandGetClient.CommandText = "SELECT        FIO AS ФИО, Passport AS [Паспортные данные], phone AS [Номер телефо" +
    "на], birth AS [Дата рождения], gender AS Пол\r\nFROM            dbo.GetClient(@nam" +
    "e, @passport) AS GetClient_1";
            this.sqlCommandGetClient.Connection = this.sqlConnectionClient;
            this.sqlCommandGetClient.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@passport", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(408, 177);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(123, 24);
            this.show.TabIndex = 17;
            this.show.Text = "Показать всех";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // sqlCommandDelClient
            // 
            this.sqlCommandDelClient.CommandText = "DelClient";
            this.sqlCommandDelClient.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDelClient.Connection = this.sqlConnectionClient;
            this.sqlCommandDelClient.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@passport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Clients";
            this.Text = "Учет клиентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clients_FormClosing);
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.DataGridView Client;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Data.SqlClient.SqlConnection sqlConnectionClient;
        private System.Data.SqlClient.SqlCommand sqlCommandClientTable;
        private System.Data.SqlClient.SqlCommand sqlCommandGetClient;
        private System.Windows.Forms.Button show;
        private System.Data.SqlClient.SqlCommand sqlCommandDelClient;
    }
}