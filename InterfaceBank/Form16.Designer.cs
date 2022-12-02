namespace InterfaceBank
{
    partial class updateWorker
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
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newFio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newSalary = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.sqlConnectionWorker = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandDelWorker = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandUpWorker = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите полные ФИО сотрудника:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(347, 35);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Введите номер телефона сотрудника:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(381, 79);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(190, 20);
            this.phone.TabIndex = 23;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Заполните только те поля, которые хотите изменить:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "ФИО:";
            // 
            // newFio
            // 
            this.newFio.Location = new System.Drawing.Point(83, 177);
            this.newFio.Name = "newFio";
            this.newFio.Size = new System.Drawing.Size(234, 20);
            this.newFio.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Номер телефона:";
            // 
            // newPhone
            // 
            this.newPhone.Location = new System.Drawing.Point(191, 221);
            this.newPhone.Name = "newPhone";
            this.newPhone.Size = new System.Drawing.Size(190, 20);
            this.newPhone.TabIndex = 28;
            this.newPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPhone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Зарплата:";
            // 
            // newSalary
            // 
            this.newSalary.Location = new System.Drawing.Point(127, 266);
            this.newSalary.Name = "newSalary";
            this.newSalary.ShortcutsEnabled = false;
            this.newSalary.Size = new System.Drawing.Size(190, 20);
            this.newSalary.TabIndex = 30;
            this.newSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newSalary_KeyPress);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(595, 225);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(178, 70);
            this.update.TabIndex = 31;
            this.update.Text = "Обновить данные";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(639, 35);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(134, 69);
            this.delete.TabIndex = 32;
            this.delete.Text = "Уволить сотрудника";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // sqlConnectionWorker
            // 
            this.sqlConnectionWorker.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionWorker.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandDelWorker
            // 
            this.sqlCommandDelWorker.CommandText = "DelWorker";
            this.sqlCommandDelWorker.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandDelWorker.Connection = this.sqlConnectionWorker;
            this.sqlCommandDelWorker.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommandUpWorker
            // 
            this.sqlCommandUpWorker.CommandText = "UpWorker";
            this.sqlCommandUpWorker.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandUpWorker.Connection = this.sqlConnectionWorker;
            this.sqlCommandUpWorker.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newFio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newPhone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newSalary", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // updateWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.newSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newFio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "updateWorker";
            this.Text = "Обновление информации о сотрудниках";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateWorker_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newFio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newSalary;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Data.SqlClient.SqlConnection sqlConnectionWorker;
        private System.Data.SqlClient.SqlCommand sqlCommandDelWorker;
        private System.Data.SqlClient.SqlCommand sqlCommandUpWorker;
    }
}