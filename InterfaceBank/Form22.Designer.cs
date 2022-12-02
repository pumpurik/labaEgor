namespace InterfaceBank
{
    partial class historyOftransfers
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
            this.Fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyH = new System.Windows.Forms.DataGridView();
            this.sqlConnectionGetTransfer = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandGetTransfer = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.moneyH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(84, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 65);
            this.button2.TabIndex = 18;
            this.button2.Text = "Показать историю";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(39, 135);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(282, 20);
            this.Fio.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // moneyH
            // 
            this.moneyH.AllowUserToAddRows = false;
            this.moneyH.AllowUserToDeleteRows = false;
            this.moneyH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moneyH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moneyH.Location = new System.Drawing.Point(359, 34);
            this.moneyH.Name = "moneyH";
            this.moneyH.Size = new System.Drawing.Size(429, 356);
            this.moneyH.TabIndex = 21;
            // 
            // sqlConnectionGetTransfer
            // 
            this.sqlConnectionGetTransfer.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionGetTransfer.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandGetTransfer
            // 
            this.sqlCommandGetTransfer.CommandText = "SELECT        type_ac AS [Счет списания], sender AS Отправитель, Sumary AS Сумма," +
    " fioR AS Получатель, date_op AS [Дата перевода]\r\nFROM            dbo.GetTransfer" +
    "s(@name) AS GetTransfers_1";
            this.sqlCommandGetTransfer.Connection = this.sqlConnectionGetTransfer;
            this.sqlCommandGetTransfer.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // historyOftransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "historyOftransfers";
            this.Text = "История переводов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.historyOftransfers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.moneyH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView moneyH;
        private System.Data.SqlClient.SqlConnection sqlConnectionGetTransfer;
        private System.Data.SqlClient.SqlCommand sqlCommandGetTransfer;
    }
}