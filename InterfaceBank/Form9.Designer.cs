namespace InterfaceBank
{
    partial class HistoryOfMoney
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
            this.Fio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.moneyH = new System.Windows.Forms.DataGridView();
            this.sqlConnectionHM = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandHM = new System.Data.SqlClient.SqlCommand();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(25, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(25, 96);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(282, 20);
            this.Fio.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(71, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 65);
            this.button2.TabIndex = 12;
            this.button2.Text = "Показать историю";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // moneyH
            // 
            this.moneyH.AllowUserToAddRows = false;
            this.moneyH.AllowUserToDeleteRows = false;
            this.moneyH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moneyH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moneyH.Location = new System.Drawing.Point(511, 52);
            this.moneyH.Name = "moneyH";
            this.moneyH.Size = new System.Drawing.Size(211, 356);
            this.moneyH.TabIndex = 13;
            // 
            // sqlConnectionHM
            // 
            this.sqlConnectionHM.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionHM.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandHM
            // 
            this.sqlCommandHM.CommandText = "SELECT        summa AS [Сумма снятия], date_op AS [Дата операции]\r\nFROM          " +
    "  dbo.GetIssuFunds(@name, @pasport) AS GetIssuFunds_1";
            this.sqlCommandHM.Connection = this.sqlConnectionHM;
            this.sqlCommandHM.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(28, 182);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 15;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите свои паспортные данные:";
            // 
            // HistoryOfMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "HistoryOfMoney";
            this.Text = "История снятия денег";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryOfMoney_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.moneyH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView moneyH;
        private System.Data.SqlClient.SqlConnection sqlConnectionHM;
        private System.Data.SqlClient.SqlCommand sqlCommandHM;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
    }
}