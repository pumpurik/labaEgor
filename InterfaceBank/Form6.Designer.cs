namespace InterfaceBank
{
    partial class Application
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
            this.Fio = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.tableApp = new System.Windows.Forms.DataGridView();
            this.sqlConnectionGetApp = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandGetApp = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.arrenge = new System.Windows.Forms.Button();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(16, 132);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(232, 20);
            this.Fio.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(53, 270);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(181, 66);
            this.Search.TabIndex = 2;
            this.Search.Text = "Посмотреть историю заявок";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tableApp
            // 
            this.tableApp.AllowUserToAddRows = false;
            this.tableApp.AllowUserToDeleteRows = false;
            this.tableApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableApp.Location = new System.Drawing.Point(364, 79);
            this.tableApp.Name = "tableApp";
            this.tableApp.Size = new System.Drawing.Size(415, 172);
            this.tableApp.TabIndex = 3;
            // 
            // sqlConnectionGetApp
            // 
            this.sqlConnectionGetApp.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionGetApp.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandGetApp
            // 
            this.sqlCommandGetApp.CommandText = "SELECT        type_appl AS [Тип зявления], status AS Статус\r\nFROM            dbo." +
    "GetApp(@name, @pasport) AS GetApp_1";
            this.sqlCommandGetApp.Connection = this.sqlConnectionGetApp;
            this.sqlCommandGetApp.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arrenge
            // 
            this.arrenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrenge.Location = new System.Drawing.Point(546, 303);
            this.arrenge.Name = "arrenge";
            this.arrenge.Size = new System.Drawing.Size(222, 56);
            this.arrenge.TabIndex = 7;
            this.arrenge.Text = "Оформление заявок";
            this.arrenge.UseVisualStyleBackColor = true;
            this.arrenge.Click += new System.EventHandler(this.arrenge_Click);
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(19, 223);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 9;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите свои паспортные данные:";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrenge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableApp);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Name = "Application";
            this.Text = "Просмотр заявок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Application_FormClosing);
            this.Load += new System.EventHandler(this.Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView tableApp;
        private System.Data.SqlClient.SqlConnection sqlConnectionGetApp;
        private System.Data.SqlClient.SqlCommand sqlCommandGetApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button arrenge;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label2;
    }
}