namespace InterfaceBank
{
    partial class DelPayOrder
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
            this.money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fioClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fioWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.schet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlConnectionDelPay = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandDelPay = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(240, 275);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 66;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Введите сумму оплаты:";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "МВД",
            "Налоговая"});
            this.position.Location = new System.Drawing.Point(363, 235);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(181, 21);
            this.position.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Выберите тип плаженого поручения:";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(375, 156);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(184, 20);
            this.pasport.TabIndex = 62;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // fioClient
            // 
            this.fioClient.Location = new System.Drawing.Point(341, 111);
            this.fioClient.Name = "fioClient";
            this.fioClient.Size = new System.Drawing.Size(232, 20);
            this.fioClient.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Введите полностью ФИО клиента:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(314, 68);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 20);
            this.phone.TabIndex = 58;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // fioWorker
            // 
            this.fioWorker.Location = new System.Drawing.Point(312, 25);
            this.fioWorker.Name = "fioWorker";
            this.fioWorker.Size = new System.Drawing.Size(234, 20);
            this.fioWorker.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(40, 390);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 33);
            this.back.TabIndex = 67;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(584, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 64);
            this.button1.TabIndex = 68;
            this.button1.Text = "Удалить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.schet.Location = new System.Drawing.Point(293, 196);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(181, 21);
            this.schet.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Выберите тип счета клиента:";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(472, 307);
            this.date.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.date.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(174, 24);
            this.date.TabIndex = 72;
            this.date.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(454, 24);
            this.label8.TabIndex = 71;
            this.label8.Text = "Выберите дату создания платежного поручения:";
            // 
            // sqlConnectionDelPay
            // 
            this.sqlConnectionDelPay.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionDelPay.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandDelPay
            // 
            this.sqlCommandDelPay.CommandText = "DelPay";
            this.sqlCommandDelPay.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDelPay.Connection = this.sqlConnectionDelPay;
            this.sqlCommandDelPay.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioW", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioClient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@type_pay", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schet", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@sum_order", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // DelPayOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fioWorker);
            this.Controls.Add(this.label1);
            this.Name = "DelPayOrder";
            this.Text = "Удалить платежное поручение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DelPayOrder_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelPayOrder_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fioWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox schet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Data.SqlClient.SqlConnection sqlConnectionDelPay;
        private System.Data.SqlClient.SqlCommand sqlCommandDelPay;
    }
}