namespace InterfaceBank
{
    partial class Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fio = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Worker = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.sqlConnectionWorker = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandWorker = new System.Data.SqlClient.SqlCommand();
            this.sqlCommandGetWorker = new System.Data.SqlClient.SqlCommand();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.sqlCommandGetWorkerByPosition = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.Worker)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(29, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите полные ФИО сотрудника:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(339, 44);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(234, 20);
            this.Fio.TabIndex = 11;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(626, 37);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(149, 38);
            this.Search.TabIndex = 14;
            this.Search.Text = "ФИО";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(620, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 55);
            this.button4.TabIndex = 16;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(620, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 55);
            this.button5.TabIndex = 17;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Worker
            // 
            this.Worker.AllowUserToAddRows = false;
            this.Worker.AllowUserToDeleteRows = false;
            this.Worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Worker.Location = new System.Drawing.Point(29, 173);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(505, 202);
            this.Worker.TabIndex = 18;
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.Location = new System.Drawing.Point(367, 132);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(167, 35);
            this.show.TabIndex = 19;
            this.show.Text = "Показать всех";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // sqlConnectionWorker
            // 
            this.sqlConnectionWorker.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionWorker.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandWorker
            // 
            this.sqlCommandWorker.CommandText = "SELECT        FIO AS ФИО, birth AS [Дата рождения], gender AS Пол, phone AS [Номе" +
    "р телефона], position AS Должность, salary AS Зарплата, status_emp AS Статус\r\nFR" +
    "OM            employees";
            this.sqlCommandWorker.Connection = this.sqlConnectionWorker;
            // 
            // sqlCommandGetWorker
            // 
            this.sqlCommandGetWorker.CommandText = resources.GetString("sqlCommandGetWorker.CommandText");
            this.sqlCommandGetWorker.Connection = this.sqlConnectionWorker;
            this.sqlCommandGetWorker.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(626, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "должности";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(653, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Найти по:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Выберите должность:";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Менеджер",
            "Операционист"});
            this.position.Location = new System.Drawing.Point(228, 87);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(182, 21);
            this.position.TabIndex = 23;
            // 
            // sqlCommandGetWorkerByPosition
            // 
            this.sqlCommandGetWorkerByPosition.CommandText = resources.GetString("sqlCommandGetWorkerByPosition.CommandText");
            this.sqlCommandGetWorkerByPosition.Connection = this.sqlConnectionWorker;
            this.sqlCommandGetWorkerByPosition.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@position", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Worker);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Workers";
            this.Text = "Учет сотрудников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Workers_FormClosing);
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Worker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView Worker;
        private System.Windows.Forms.Button show;
        private System.Data.SqlClient.SqlConnection sqlConnectionWorker;
        private System.Data.SqlClient.SqlCommand sqlCommandWorker;
        private System.Data.SqlClient.SqlCommand sqlCommandGetWorker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox position;
        private System.Data.SqlClient.SqlCommand sqlCommandGetWorkerByPosition;
    }
}