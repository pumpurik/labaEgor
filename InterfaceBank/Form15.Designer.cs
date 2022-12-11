namespace InterfaceBank
{
    partial class InsWorker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sqlConnectionInsWorker = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandInsWorker = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 405);
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
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите полные ФИО сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите должность сотрудника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите номер телефона сотрудника:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Выберите дату рождения сотрудника:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(354, 32);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 18;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(394, 64);
            this.date.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(174, 24);
            this.date.TabIndex = 19;
            this.date.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выберите пол сотрудника:";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.gender.Location = new System.Drawing.Point(291, 109);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(147, 21);
            this.gender.TabIndex = 21;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(394, 151);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(190, 20);
            this.phone.TabIndex = 22;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Менеджер",
            "Операционист"});
            this.position.Location = new System.Drawing.Point(354, 188);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(147, 21);
            this.position.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Введите зарплату сотрудника:";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(327, 228);
            this.salary.Name = "salary";
            this.salary.ShortcutsEnabled = false;
            this.salary.Size = new System.Drawing.Size(190, 20);
            this.salary.TabIndex = 25;
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(544, 287);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(182, 59);
            this.add.TabIndex = 26;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sqlConnectionInsWorker
            // 
            this.sqlConnectionInsWorker.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionInsWorker.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandInsWorker
            // 
            this.sqlCommandInsWorker.CommandText = "InsWorker";
            this.sqlCommandInsWorker.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandInsWorker.Connection = this.sqlConnectionInsWorker;
            this.sqlCommandInsWorker.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@birth", System.Data.SqlDbType.Date),
            new System.Data.SqlClient.SqlParameter("@gender", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@position", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@salary", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // InsWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.position);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "InsWorker";
            this.Text = "Добавление нового сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsWorker_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button add;
        private System.Data.SqlClient.SqlConnection sqlConnectionInsWorker;
        private System.Data.SqlClient.SqlCommand sqlCommandInsWorker;
    }
}