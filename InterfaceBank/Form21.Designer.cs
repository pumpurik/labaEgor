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
            this.pasportSender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fioSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.schetSender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.schetRecipient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pasportRecipient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fioRecipient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sqlConnectionDoTransfer = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandDoTransfer = new System.Data.SqlClient.SqlCommand();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlCommandDelTransfer = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 533);
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
            this.button2.Location = new System.Drawing.Point(113, 147);
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
            this.clients.Location = new System.Drawing.Point(463, 440);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(175, 82);
            this.clients.TabIndex = 11;
            this.clients.Text = "Совершить перевод";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(314, 67);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 20);
            this.phone.TabIndex = 28;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // fioWorker
            // 
            this.fioWorker.Location = new System.Drawing.Point(312, 24);
            this.fioWorker.Name = "fioWorker";
            this.fioWorker.Size = new System.Drawing.Size(234, 20);
            this.fioWorker.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // pasportSender
            // 
            this.pasportSender.Location = new System.Drawing.Point(419, 151);
            this.pasportSender.Name = "pasportSender";
            this.pasportSender.Size = new System.Drawing.Size(184, 20);
            this.pasportSender.TabIndex = 32;
            this.pasportSender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasportSender_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Введите паспортные данные отправителя:";
            // 
            // fioSender
            // 
            this.fioSender.Location = new System.Drawing.Point(385, 109);
            this.fioSender.Name = "fioSender";
            this.fioSender.Size = new System.Drawing.Size(232, 20);
            this.fioSender.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Введите полностью ФИО отправителя:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(263, 197);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 34;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Введите сумму перевода:";
            // 
            // schetSender
            // 
            this.schetSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schetSender.FormattingEnabled = true;
            this.schetSender.Items.AddRange(new object[] {
            "кредитный",
            "депозитный",
            "бюджетный",
            "расчетный"});
            this.schetSender.Location = new System.Drawing.Point(258, 242);
            this.schetSender.Name = "schetSender";
            this.schetSender.Size = new System.Drawing.Size(181, 21);
            this.schetSender.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Выберите счет списания:";
            // 
            // schetRecipient
            // 
            this.schetRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schetRecipient.FormattingEnabled = true;
            this.schetRecipient.Items.AddRange(new object[] {
            "кредитный",
            "депозитный",
            "бюджетный",
            "расчетный"});
            this.schetRecipient.Location = new System.Drawing.Point(276, 373);
            this.schetRecipient.Name = "schetRecipient";
            this.schetRecipient.Size = new System.Drawing.Size(181, 21);
            this.schetRecipient.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Выберите счет получателя:";
            // 
            // pasportRecipient
            // 
            this.pasportRecipient.Location = new System.Drawing.Point(405, 331);
            this.pasportRecipient.Name = "pasportRecipient";
            this.pasportRecipient.Size = new System.Drawing.Size(186, 20);
            this.pasportRecipient.TabIndex = 40;
            this.pasportRecipient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasportRecipient_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(387, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Введите паспортные данные получателя:";
            // 
            // fioRecipient
            // 
            this.fioRecipient.Location = new System.Drawing.Point(371, 289);
            this.fioRecipient.Name = "fioRecipient";
            this.fioRecipient.Size = new System.Drawing.Size(232, 20);
            this.fioRecipient.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(353, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "Введите полностью ФИО получателя:";
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
            new System.Data.SqlClient.SqlParameter("@fioSender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasportSender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schetSender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioRecipient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasportRecipient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schetRecipient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(113, 96);
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
            this.label8.Location = new System.Drawing.Point(15, 52);
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
            this.panel1.Location = new System.Drawing.Point(705, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 275);
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
            new System.Data.SqlClient.SqlParameter("@fioSender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasportSender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schetSender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioRecipient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasportRecipient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schetRecipient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.schetRecipient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pasportRecipient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fioRecipient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.schetSender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pasportSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioSender);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.TextBox pasportSender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox schetSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox schetRecipient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pasportRecipient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fioRecipient;
        private System.Windows.Forms.Label label10;
        private System.Data.SqlClient.SqlConnection sqlConnectionDoTransfer;
        private System.Data.SqlClient.SqlCommand sqlCommandDoTransfer;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Data.SqlClient.SqlCommand sqlCommandDelTransfer;
    }
}