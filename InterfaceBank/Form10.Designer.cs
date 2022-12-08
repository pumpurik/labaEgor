namespace InterfaceBank
{
    partial class insSchet
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
            this.label2 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scheta = new System.Windows.Forms.ComboBox();
            this.upSchet = new System.Windows.Forms.Button();
            this.sqlConnectionUpAcc = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandUpAcc = new System.Data.SqlClient.SqlCommand();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(330, 71);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(280, 20);
            this.Fio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите сумму для пополнения:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(338, 160);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 9;
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите счет:";
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
            this.scheta.Location = new System.Drawing.Point(187, 204);
            this.scheta.Name = "scheta";
            this.scheta.Size = new System.Drawing.Size(180, 21);
            this.scheta.TabIndex = 11;
            // 
            // upSchet
            // 
            this.upSchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upSchet.Location = new System.Drawing.Point(511, 251);
            this.upSchet.Name = "upSchet";
            this.upSchet.Size = new System.Drawing.Size(210, 61);
            this.upSchet.TabIndex = 12;
            this.upSchet.Text = "Пополнить счет";
            this.upSchet.UseVisualStyleBackColor = true;
            this.upSchet.Click += new System.EventHandler(this.upSchet_Click);
            // 
            // sqlConnectionUpAcc
            // 
            this.sqlConnectionUpAcc.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionUpAcc.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandUpAcc
            // 
            this.sqlCommandUpAcc.CommandText = "UpAcc";
            this.sqlCommandUpAcc.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandUpAcc.Connection = this.sqlConnectionUpAcc;
            this.sqlCommandUpAcc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@type_acc", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@sum", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar)});
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(364, 116);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 15;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите свои паспортные данные:";
            // 
            // insSchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.upSchet);
            this.Controls.Add(this.scheta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "insSchet";
            this.Text = "Пополнение счета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insSchet_FormClosing);
            this.Load += new System.EventHandler(this.insSchet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox scheta;
        private System.Windows.Forms.Button upSchet;
        private System.Data.SqlClient.SqlConnection sqlConnectionUpAcc;
        private System.Data.SqlClient.SqlCommand sqlCommandUpAcc;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label4;
    }
}