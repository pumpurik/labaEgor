namespace InterfaceBank
{
    partial class updateClient
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.bankDataSet = new InterfaceBank.BankDataSet();
            this.bankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newFio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPasport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newPhone = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlConnectionUpClient = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandUpClient = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataSetBindingSource
            // 
            this.bankDataSetBindingSource.DataSource = this.bankDataSet;
            this.bankDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите полностью ФИО клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите паспортные данные клиента:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(348, 30);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 12;
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(381, 74);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(190, 20);
            this.pasport.TabIndex = 14;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Заполните только те поля, которые хотите изменить:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "ФИО:";
            // 
            // newFio
            // 
            this.newFio.Location = new System.Drawing.Point(86, 188);
            this.newFio.Name = "newFio";
            this.newFio.Size = new System.Drawing.Size(234, 20);
            this.newFio.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Паспортные данные:";
            // 
            // newPasport
            // 
            this.newPasport.Location = new System.Drawing.Point(224, 228);
            this.newPasport.Name = "newPasport";
            this.newPasport.Size = new System.Drawing.Size(190, 20);
            this.newPasport.TabIndex = 19;
            this.newPasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPasport_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Номер телефона:";
            // 
            // newPhone
            // 
            this.newPhone.Location = new System.Drawing.Point(192, 268);
            this.newPhone.Name = "newPhone";
            this.newPhone.Size = new System.Drawing.Size(190, 20);
            this.newPhone.TabIndex = 21;
            this.newPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPhone_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(546, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 61);
            this.button2.TabIndex = 22;
            this.button2.Text = "Обновить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlConnectionUpClient
            // 
            this.sqlConnectionUpClient.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionUpClient.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandUpClient
            // 
            this.sqlCommandUpClient.CommandText = "UpClient";
            this.sqlCommandUpClient.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandUpClient.Connection = this.sqlConnectionUpClient;
            this.sqlCommandUpClient.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newFio", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newPasport", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newPhone", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // updateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newPasport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newFio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "updateClient";
            this.Text = "Обновление информации о клиенте";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateClient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bankDataSetBindingSource;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newFio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPasport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newPhone;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlConnection sqlConnectionUpClient;
        private System.Data.SqlClient.SqlCommand sqlCommandUpClient;
    }
}