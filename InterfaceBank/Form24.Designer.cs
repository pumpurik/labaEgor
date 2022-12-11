namespace InterfaceBank
{
    partial class AddSchetClient
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
            this.back = new System.Windows.Forms.Button();
            this.schet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fioClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.sqlConnectionAccount = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandInsAcc = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandDelAcc = new System.Data.SqlClient.SqlCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.idSchet = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(33, 461);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 33);
            this.back.TabIndex = 10;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            this.schet.Location = new System.Drawing.Point(216, 125);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(181, 21);
            this.schet.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Выберите тип счета:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(353, 174);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(141, 20);
            this.money.TabIndex = 52;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Введите сумму счета для открытия:";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(375, 81);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(184, 20);
            this.pasport.TabIndex = 50;
            this.pasport.TextChanged += new System.EventHandler(this.pasport_TextChanged);
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // fioClient
            // 
            this.fioClient.Location = new System.Drawing.Point(341, 36);
            this.fioClient.Name = "fioClient";
            this.fioClient.Size = new System.Drawing.Size(232, 20);
            this.fioClient.TabIndex = 48;
            this.fioClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fioClient_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Введите полностью ФИО клиента:";
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(33, 234);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(186, 74);
            this.Open.TabIndex = 55;
            this.Open.Text = "Открыть счет";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(86, 125);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(186, 74);
            this.Close.TabIndex = 56;
            this.Close.Text = "Закрыть счет";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // sqlConnectionAccount
            // 
            this.sqlConnectionAccount.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionAccount.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandInsAcc
            // 
            this.sqlCommandInsAcc.CommandText = "InsAcc";
            this.sqlCommandInsAcc.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandInsAcc.Connection = this.sqlConnectionAccount;
            this.sqlCommandInsAcc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioClient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@summa", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@schet", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommandDelAcc
            // 
            this.sqlCommandDelAcc.CommandText = "DelAcc";
            this.sqlCommandDelAcc.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDelAcc.Connection = this.sqlConnectionAccount;
            this.sqlCommandDelAcc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@idSchet", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(758, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 96);
            this.button3.TabIndex = 57;
            this.button3.Text = "Посмотреть айди счетов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.idSchet);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(600, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 244);
            this.panel1.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Для закрытия счета введите айди:";
            // 
            // idSchet
            // 
            this.idSchet.Location = new System.Drawing.Point(112, 77);
            this.idSchet.Name = "idSchet";
            this.idSchet.Size = new System.Drawing.Size(135, 20);
            this.idSchet.TabIndex = 57;
            // 
            // AddSchetClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back);
            this.Name = "AddSchetClient";
            this.Text = "Управление счетами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSchetClient_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox schet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Data.SqlClient.SqlConnection sqlConnectionAccount;
        private System.Data.SqlClient.SqlCommand sqlCommandInsAcc;
        private System.Data.SqlClient.SqlCommand sqlCommandDelAcc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idSchet;
    }
}