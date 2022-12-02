namespace InterfaceBank
{
    partial class PaymentsPay
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
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.money = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.arrenge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.ComboBox();
            this.sqlConnectionPayment = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandPayment = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(358, 95);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 17;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите свои паспортные данные:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(324, 41);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(232, 20);
            this.Fio.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Выберите тип плаженого поручения:";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "МВД",
            "Налоговая"});
            this.position.Location = new System.Drawing.Point(375, 150);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(181, 21);
            this.position.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Выберите дату квитанции:";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(281, 197);
            this.date.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.date.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(174, 24);
            this.date.TabIndex = 26;
            this.date.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(252, 251);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 28;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Введите сумму оплаты:";
            // 
            // arrenge
            // 
            this.arrenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrenge.Location = new System.Drawing.Point(519, 284);
            this.arrenge.Name = "arrenge";
            this.arrenge.Size = new System.Drawing.Size(222, 56);
            this.arrenge.TabIndex = 29;
            this.arrenge.Text = "Оплатить";
            this.arrenge.UseVisualStyleBackColor = true;
            this.arrenge.Click += new System.EventHandler(this.arrenge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Выберите счет списания:";
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
            this.schet.Location = new System.Drawing.Point(270, 303);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(181, 21);
            this.schet.TabIndex = 31;
            // 
            // sqlConnectionPayment
            // 
            this.sqlConnectionPayment.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionPayment.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandPayment
            // 
            this.sqlCommandPayment.CommandText = "PayPaymentCli";
            this.sqlCommandPayment.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandPayment.Connection = this.sqlConnectionPayment;
            this.sqlCommandPayment.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@type_pay", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schet", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // PaymentsPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arrenge);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PaymentsPay";
            this.Text = "Оформление платежа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentsPay_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button arrenge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox schet;
        private System.Data.SqlClient.SqlConnection sqlConnectionPayment;
        private System.Data.SqlClient.SqlCommand sqlCommandPayment;
    }
}