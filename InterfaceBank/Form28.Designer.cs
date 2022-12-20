namespace InterfaceBank
{
    partial class HistoryOfOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryOfOperations));
            this.operationsM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlConnectionOperations = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandTransfers = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandIssuF = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandPayment = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandCurrency = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.operationsM)).BeginInit();
            this.SuspendLayout();
            // 
            // operationsM
            // 
            this.operationsM.AllowUserToAddRows = false;
            this.operationsM.AllowUserToDeleteRows = false;
            this.operationsM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationsM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsM.Location = new System.Drawing.Point(22, 124);
            this.operationsM.Name = "operationsM";
            this.operationsM.Size = new System.Drawing.Size(548, 255);
            this.operationsM.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(22, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(611, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 56);
            this.button2.TabIndex = 16;
            this.button2.Text = "Переводы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(611, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 60);
            this.button3.TabIndex = 17;
            this.button3.Text = "Платежные поручения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(611, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 56);
            this.button4.TabIndex = 18;
            this.button4.Text = "Снятия денег";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(611, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 62);
            this.button5.TabIndex = 19;
            this.button5.Text = "Переводы между валютами";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date1.Location = new System.Drawing.Point(231, 26);
            this.date1.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.date1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(174, 24);
            this.date1.TabIndex = 73;
            this.date1.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date2.Location = new System.Drawing.Point(264, 73);
            this.date2.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.date2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(174, 24);
            this.date2.TabIndex = 74;
            this.date2.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "Дата начала периода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Дата окончания периода:";
            // 
            // sqlConnectionOperations
            // 
            this.sqlConnectionOperations.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionOperations.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandTransfers
            // 
            this.sqlCommandTransfers.CommandText = resources.GetString("sqlCommandTransfers.CommandText");
            this.sqlCommandTransfers.Connection = this.sqlConnectionOperations;
            this.sqlCommandTransfers.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.Date, 1024),
            new System.Data.SqlClient.SqlParameter("@date2", System.Data.SqlDbType.Date, 1024)});
            // 
            // sqlCommandIssuF
            // 
            this.sqlCommandIssuF.CommandText = "SELECT        FioCli AS [ФИО клиента], summa AS Сумма, date_op AS [Дата операции]" +
    "\r\nFROM            dbo.GetIssuFundsManager(@date1, @date2) AS GetIssuFundsManager" +
    "_1";
            this.sqlCommandIssuF.Connection = this.sqlConnectionOperations;
            this.sqlCommandIssuF.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.Date, 1024),
            new System.Data.SqlClient.SqlParameter("@date2", System.Data.SqlDbType.Date, 1024)});
            // 
            // sqlCommandPayment
            // 
            this.sqlCommandPayment.CommandText = resources.GetString("sqlCommandPayment.CommandText");
            this.sqlCommandPayment.Connection = this.sqlConnectionOperations;
            this.sqlCommandPayment.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.Date, 1024),
            new System.Data.SqlClient.SqlParameter("@date2", System.Data.SqlDbType.Date, 1024)});
            // 
            // sqlCommandCurrency
            // 
            this.sqlCommandCurrency.CommandText = resources.GetString("sqlCommandCurrency.CommandText");
            this.sqlCommandCurrency.Connection = this.sqlConnectionOperations;
            this.sqlCommandCurrency.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@date1", System.Data.SqlDbType.Date, 1024),
            new System.Data.SqlClient.SqlParameter("@date2", System.Data.SqlDbType.Date, 1024)});
            // 
            // HistoryOfOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operationsM);
            this.Name = "HistoryOfOperations";
            this.Text = "История операций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryOfOperations_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.operationsM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView operationsM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlConnection sqlConnectionOperations;
        private System.Data.SqlClient.SqlCommand sqlCommandTransfers;
        private System.Data.SqlClient.SqlCommand sqlCommandIssuF;
        private System.Data.SqlClient.SqlCommand sqlCommandPayment;
        private System.Data.SqlClient.SqlCommand sqlCommandCurrency;
    }
}