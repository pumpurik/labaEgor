namespace InterfaceBank
{
    partial class Scheta
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
            this.search = new System.Windows.Forms.Button();
            this.tableAcc = new System.Windows.Forms.DataGridView();
            this.sqlConnectionAcc = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandAcc = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pasport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(22, 139);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(280, 20);
            this.Fio.TabIndex = 1;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(57, 276);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(191, 48);
            this.search.TabIndex = 2;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // tableAcc
            // 
            this.tableAcc.AllowUserToAddRows = false;
            this.tableAcc.AllowUserToDeleteRows = false;
            this.tableAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAcc.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableAcc.Location = new System.Drawing.Point(415, 89);
            this.tableAcc.Name = "tableAcc";
            this.tableAcc.Size = new System.Drawing.Size(338, 161);
            this.tableAcc.TabIndex = 3;
            // 
            // sqlConnectionAcc
            // 
            this.sqlConnectionAcc.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionAcc.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandAcc
            // 
            this.sqlCommandAcc.CommandText = "SELECT        Date_Op AS [Дата открытия], Sumary AS Сумма, type_ac AS [Тип счета]" +
    "\r\nFROM            dbo.GetAccounts(@name, @pasport) AS GetAccounts_1";
            this.sqlCommandAcc.Connection = this.sqlConnectionAcc;
            this.sqlCommandAcc.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 1024),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(577, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Пополнить счет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите свои паспортные данные:";
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(25, 237);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 7;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // Scheta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableAcc);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Name = "Scheta";
            this.Text = "Просмотр счетов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scheta_FormClosing);
            this.Load += new System.EventHandler(this.Scheta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Button search;
        private System.Data.SqlClient.SqlConnection sqlConnectionAcc;
        private System.Data.SqlClient.SqlCommand sqlCommandAcc;
        private System.Windows.Forms.DataGridView tableAcc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pasport;
    }
}