namespace InterfaceBank
{
    partial class applications
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
            this.Worker = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.sqlConnectionGetApp = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandGetApp = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.Worker)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 394);
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
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(21, 71);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Введите свой номер телефона:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(21, 142);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(190, 20);
            this.phone.TabIndex = 24;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // Worker
            // 
            this.Worker.AllowUserToAddRows = false;
            this.Worker.AllowUserToDeleteRows = false;
            this.Worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Worker.Location = new System.Drawing.Point(21, 188);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(505, 166);
            this.Worker.TabIndex = 25;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(615, 37);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(149, 54);
            this.Search.TabIndex = 26;
            this.Search.Text = "Найти ";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(610, 268);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(178, 86);
            this.update.TabIndex = 32;
            this.update.Text = "Обновить статус заявки";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // sqlConnectionGetApp
            // 
            this.sqlConnectionGetApp.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionGetApp.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandGetApp
            // 
            this.sqlCommandGetApp.CommandText = "SELECT        FIO AS [ФИО клиента], type_appl AS [Тип заявления], status AS [Стат" +
    "ус заявления]\r\nFROM            dbo.GetAppW(@fio, @phone) AS GetAppW_1";
            this.sqlCommandGetApp.Connection = this.sqlConnectionGetApp;
            this.sqlCommandGetApp.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "applications";
            this.Text = "Просмотр и обновление заявок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.applications_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Worker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.DataGridView Worker;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button update;
        private System.Data.SqlClient.SqlConnection sqlConnectionGetApp;
        private System.Data.SqlClient.SqlCommand sqlCommandGetApp;
    }
}