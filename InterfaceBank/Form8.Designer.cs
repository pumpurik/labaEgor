namespace InterfaceBank
{
    partial class Wmoney
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.scheta = new System.Windows.Forms.ComboBox();
            this.getMoney = new System.Windows.Forms.Button();
            this.sqlConnectionInsIssu = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandInsIssu = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите сумму для снятия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите счет:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(328, 53);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(221, 20);
            this.Fio.TabIndex = 4;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(290, 135);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 5;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // scheta
            // 
            this.scheta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scheta.FormattingEnabled = true;
            this.scheta.Items.AddRange(new object[] {
            "кредитный",
            "депозитный",
            "расчетный",
            "бюджетный"});
            this.scheta.Location = new System.Drawing.Point(185, 175);
            this.scheta.Name = "scheta";
            this.scheta.Size = new System.Drawing.Size(180, 21);
            this.scheta.TabIndex = 6;
            this.scheta.SelectedIndexChanged += new System.EventHandler(this.scheta_SelectedIndexChanged);
            // 
            // getMoney
            // 
            this.getMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getMoney.Location = new System.Drawing.Point(497, 209);
            this.getMoney.Name = "getMoney";
            this.getMoney.Size = new System.Drawing.Size(210, 61);
            this.getMoney.TabIndex = 7;
            this.getMoney.Text = "Снять деньги";
            this.getMoney.UseVisualStyleBackColor = true;
            this.getMoney.Click += new System.EventHandler(this.getMoney_Click);
            // 
            // sqlConnectionInsIssu
            // 
            this.sqlConnectionInsIssu.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionInsIssu.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandInsIssu
            // 
            this.sqlCommandInsIssu.CommandText = "InsIssu";
            this.sqlCommandInsIssu.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandInsIssu.Connection = this.sqlConnectionInsIssu;
            this.sqlCommandInsIssu.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@sum", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@type_acc", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@date", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar)});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.Location = new System.Drawing.Point(497, 327);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(210, 69);
            this.history.TabIndex = 9;
            this.history.Text = "Посмотреть историю";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(362, 95);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 13;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите свои паспортные данные:";
            // 
            // Wmoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.history);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getMoney);
            this.Controls.Add(this.scheta);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Wmoney";
            this.Text = "Снять деньги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wmoney_FormClosing);
            this.Load += new System.EventHandler(this.Wmoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.ComboBox scheta;
        private System.Windows.Forms.Button getMoney;
        private System.Data.SqlClient.SqlConnection sqlConnectionInsIssu;
        private System.Data.SqlClient.SqlCommand sqlCommandInsIssu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label4;
    }
}