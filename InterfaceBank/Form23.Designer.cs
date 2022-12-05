namespace InterfaceBank
{
    partial class Currency
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
            this.money = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fioClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fioWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clients = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlConnectionInsCur = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandInsCur = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandDelCur = new System.Data.SqlClient.SqlCommand();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(280, 205);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 44;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Введите сумму перевода:";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(392, 163);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(184, 20);
            this.pasport.TabIndex = 42;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // fioClient
            // 
            this.fioClient.Location = new System.Drawing.Point(358, 118);
            this.fioClient.Name = "fioClient";
            this.fioClient.Size = new System.Drawing.Size(232, 20);
            this.fioClient.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Введите полностью ФИО клиента:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(331, 75);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 20);
            this.phone.TabIndex = 38;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // fioWorker
            // 
            this.fioWorker.Location = new System.Drawing.Point(329, 32);
            this.fioWorker.Name = "fioWorker";
            this.fioWorker.Size = new System.Drawing.Size(234, 20);
            this.fioWorker.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // schet
            // 
            this.schet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schet.FormattingEnabled = true;
            this.schet.Items.AddRange(new object[] {
            "кредитный",
            "депозитный",
            "бюджетный",
            "расчетный"});
            this.schet.Location = new System.Drawing.Point(275, 244);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(181, 21);
            this.schet.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Выберите счет списания:";
            // 
            // cur
            // 
            this.cur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cur.FormattingEnabled = true;
            this.cur.Items.AddRange(new object[] {
            "USD",
            "CNY"});
            this.cur.Location = new System.Drawing.Point(209, 287);
            this.cur.Name = "cur";
            this.cur.Size = new System.Drawing.Size(181, 21);
            this.cur.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Выберите валюту:";
            // 
            // clients
            // 
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients.Location = new System.Drawing.Point(448, 309);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(175, 82);
            this.clients.TabIndex = 49;
            this.clients.Text = "Совершить перевод";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(683, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 284);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(125, 86);
            this.date.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.date.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(174, 24);
            this.date.TabIndex = 46;
            this.date.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(125, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 84);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отменить перевод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlConnectionInsCur
            // 
            this.sqlConnectionInsCur.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionInsCur.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandInsCur
            // 
            this.sqlCommandInsCur.CommandText = "InsCur";
            this.sqlCommandInsCur.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandInsCur.Connection = this.sqlConnectionInsCur;
            this.sqlCommandInsCur.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioW", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioClient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schet", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@cur", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommandDelCur
            // 
            this.sqlCommandDelCur.CommandText = "DelCur";
            this.sqlCommandDelCur.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDelCur.Connection = this.sqlConnectionInsCur;
            this.sqlCommandDelCur.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioW", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioClient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schet", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@cur", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(415, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Для отмены также выберите дату перевода:";
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.cur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fioWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Currency";
            this.Text = "Переводы на другие валюты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Currency_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fioWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox schet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlConnection sqlConnectionInsCur;
        private System.Data.SqlClient.SqlCommand sqlCommandInsCur;
        private System.Data.SqlClient.SqlCommand sqlCommandDelCur;
        private System.Windows.Forms.Label label9;
    }
}