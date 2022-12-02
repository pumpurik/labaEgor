namespace InterfaceBank
{
    partial class Payments
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
            this.tablePayment = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.arrenge = new System.Windows.Forms.Button();
            this.sqlConnectionGetPay = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandGetPay = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayment)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(36, 181);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 13;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите свои паспортные данные:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(33, 90);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(232, 20);
            this.Fio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // tablePayment
            // 
            this.tablePayment.AllowUserToAddRows = false;
            this.tablePayment.AllowUserToDeleteRows = false;
            this.tablePayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePayment.Location = new System.Drawing.Point(383, 37);
            this.tablePayment.Name = "tablePayment";
            this.tablePayment.Size = new System.Drawing.Size(391, 231);
            this.tablePayment.TabIndex = 14;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(85, 231);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(167, 85);
            this.Search.TabIndex = 15;
            this.Search.Text = "Посмотреть новые платежные поручения";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // arrenge
            // 
            this.arrenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrenge.Location = new System.Drawing.Point(552, 325);
            this.arrenge.Name = "arrenge";
            this.arrenge.Size = new System.Drawing.Size(222, 56);
            this.arrenge.TabIndex = 16;
            this.arrenge.Text = "Оплатить";
            this.arrenge.UseVisualStyleBackColor = true;
            this.arrenge.Click += new System.EventHandler(this.arrenge_Click);
            // 
            // sqlConnectionGetPay
            // 
            this.sqlConnectionGetPay.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionGetPay.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandGetPay
            // 
            this.sqlCommandGetPay.CommandText = "SELECT        sender AS Отправитель, date AS [Дата отправки], sum_order AS Сумма," +
    " status AS [Статус оплаты]\r\nFROM            dbo.GetPaymentClient(@fio, @pasport)" +
    " AS GetPaymentClient_1";
            this.sqlCommandGetPay.Connection = this.sqlConnectionGetPay;
            this.sqlCommandGetPay.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrenge);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.tablePayment);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Payments";
            this.Text = "Просмотр платежей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payments_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablePayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablePayment;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button arrenge;
        private System.Data.SqlClient.SqlConnection sqlConnectionGetPay;
        private System.Data.SqlClient.SqlCommand sqlCommandGetPay;
    }
}