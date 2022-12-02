namespace InterfaceBank
{
    partial class upapp
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
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fioCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.sqlConnectionUpApp = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandUpApp = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(323, 81);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(190, 20);
            this.phone.TabIndex = 28;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(323, 36);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(386, 165);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(190, 20);
            this.pasport.TabIndex = 32;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // fioCli
            // 
            this.fioCli.Location = new System.Drawing.Point(323, 121);
            this.fioCli.Name = "fioCli";
            this.fioCli.Size = new System.Drawing.Size(234, 20);
            this.fioCli.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Введите полные ФИО клиента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Выберите статус заявки:";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "одобрен",
            "отклонено "});
            this.status.Location = new System.Drawing.Point(264, 206);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(187, 21);
            this.status.TabIndex = 34;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(551, 265);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(178, 86);
            this.update.TabIndex = 35;
            this.update.Text = "Обновить статус заявки";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // sqlConnectionUpApp
            // 
            this.sqlConnectionUpApp.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionUpApp.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandUpApp
            // 
            this.sqlCommandUpApp.CommandText = "UpApp";
            this.sqlCommandUpApp.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandUpApp.Connection = this.sqlConnectionUpApp;
            this.sqlCommandUpApp.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@fioCli", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@status", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // upapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "upapp";
            this.Text = "Обновление статуса заявлений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.upapp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Button update;
        private System.Data.SqlClient.SqlConnection sqlConnectionUpApp;
        private System.Data.SqlClient.SqlCommand sqlCommandUpApp;
    }
}