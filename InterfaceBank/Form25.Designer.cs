namespace InterfaceBank
{
    partial class sendPaymentOrder
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
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fioClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fioWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlConnectionPaymentOrder = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandInsPay = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(44, 412);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 33);
            this.back.TabIndex = 11;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(385, 160);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(184, 20);
            this.pasport.TabIndex = 50;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // fioClient
            // 
            this.fioClient.Location = new System.Drawing.Point(351, 115);
            this.fioClient.Name = "fioClient";
            this.fioClient.Size = new System.Drawing.Size(232, 20);
            this.fioClient.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Введите полностью ФИО клиента:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(324, 72);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 20);
            this.phone.TabIndex = 46;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // fioWorker
            // 
            this.fioWorker.Location = new System.Drawing.Point(322, 29);
            this.fioWorker.Name = "fioWorker";
            this.fioWorker.Size = new System.Drawing.Size(234, 20);
            this.fioWorker.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "МВД",
            "Налоговая"});
            this.position.Location = new System.Drawing.Point(373, 199);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(181, 21);
            this.position.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Выберите тип плаженого поручения:";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(250, 239);
            this.money.Name = "money";
            this.money.ShortcutsEnabled = false;
            this.money.Size = new System.Drawing.Size(190, 20);
            this.money.TabIndex = 54;
            this.money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.money_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Введите сумму оплаты:";
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(626, 243);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(189, 86);
            this.Open.TabIndex = 57;
            this.Open.Text = "Отправить платежное поручение";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(626, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 86);
            this.button1.TabIndex = 58;
            this.button1.Text = "Удалить платежное поручение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlConnectionPaymentOrder
            // 
            this.sqlConnectionPaymentOrder.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionPaymentOrder.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandInsPay
            // 
            this.sqlCommandInsPay.CommandText = "InsPay";
            this.sqlCommandInsPay.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandInsPay.Connection = this.sqlConnectionPaymentOrder;
            this.sqlCommandInsPay.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fioW", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioClient", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@type_pay", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@sum_order", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@dateop", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sendPaymentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Open);
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
            this.Controls.Add(this.back);
            this.Name = "sendPaymentOrder";
            this.Text = "Учет платежных поручений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sendPaymentOrder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fioWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlConnection sqlConnectionPaymentOrder;
        private System.Data.SqlClient.SqlCommand sqlCommandInsPay;
    }
}