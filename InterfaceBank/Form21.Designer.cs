namespace InterfaceBank
{
    partial class Transfers
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
            this.button2 = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fioWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlConnectionDoTransfer = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandDoTransfer = new System.Data.SqlClient.SqlCommand();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlCommandDelTransfer = new System.Data.SqlClient.SqlCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shetSender = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.schetRepicient = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(134, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 84);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отменить перевод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clients
            // 
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients.Location = new System.Drawing.Point(16, 298);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(175, 82);
            this.clients.TabIndex = 11;
            this.clients.Text = "Совершить перевод";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(314, 85);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 20);
            this.phone.TabIndex = 28;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // fioWorker
            // 
            this.fioWorker.Location = new System.Drawing.Point(312, 42);
            this.fioWorker.Name = "fioWorker";
            this.fioWorker.Size = new System.Drawing.Size(234, 20);
            this.fioWorker.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Введите сумму перевода:";
            // 
            // sqlConnectionDoTransfer
            // 
            this.sqlConnectionDoTransfer.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionDoTransfer.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandDoTransfer
            // 
            this.sqlCommandDoTransfer.CommandText = "DoTransfer";
            this.sqlCommandDoTransfer.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDoTransfer.Connection = this.sqlConnectionDoTransfer;
            this.sqlCommandDoTransfer.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioW", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@idSchetSender", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@idSchetRepicient", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(134, 96);
            this.date.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.date.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(174, 24);
            this.date.TabIndex = 46;
            this.date.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(47, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Для отмены выберите дату перевода:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(646, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 299);
            this.panel1.TabIndex = 47;
            // 
            // sqlCommandDelTransfer
            // 
            this.sqlCommandDelTransfer.CommandText = "DelTransfer";
            this.sqlCommandDelTransfer.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDelTransfer.Connection = this.sqlConnectionDoTransfer;
            this.sqlCommandDelTransfer.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioW", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@idSchetSender", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@idSchetRecipient", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(849, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 96);
            this.button3.TabIndex = 48;
            this.button3.Text = "Посмотреть айди счетов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Введите айди счета отправителя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Введите айди счета получателя:";
            // 
            // shetSender
            // 
            this.shetSender.Location = new System.Drawing.Point(337, 130);
            this.shetSender.Name = "shetSender";
            this.shetSender.Size = new System.Drawing.Size(165, 20);
            this.shetSender.TabIndex = 53;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(263, 179);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(165, 20);
            this.money.TabIndex = 54;
            // 
            // schetRepicient
            // 
            this.schetRepicient.Location = new System.Drawing.Point(323, 224);
            this.schetRepicient.Name = "schetRepicient";
            this.schetRepicient.Size = new System.Drawing.Size(165, 20);
            this.schetRepicient.TabIndex = 55;
            this.schetRepicient.TextChanged += new System.EventHandler(this.schetRepicient_TextChanged);
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 596);
            this.Controls.Add(this.schetRepicient);
            this.Controls.Add(this.money);
            this.Controls.Add(this.shetSender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fioWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.button1);
            this.Name = "Transfers";
            this.Text = "Учет переводов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transfers_FormClosing);
            this.Load += new System.EventHandler(this.Transfers_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Transfers_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fioWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Data.SqlClient.SqlConnection sqlConnectionDoTransfer;
        private System.Data.SqlClient.SqlCommand sqlCommandDoTransfer;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Data.SqlClient.SqlCommand sqlCommandDelTransfer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shetSender;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.TextBox schetRepicient;
    }
}