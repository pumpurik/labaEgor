namespace InterfaceBank
{
    partial class ArrengeApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.sqlConnectionInsApp = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandInsApp = new System.Data.SqlClient.SqlCommand();
            this.button1 = new System.Windows.Forms.Button();
            this.pasport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите полностью свои ФИО:";
            // 
            // Fio
            // 
            this.Fio.Location = new System.Drawing.Point(329, 78);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(269, 20);
            this.Fio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите тип заявки:";
            // 
            // type
            // 
            this.type.AutoCompleteCustomSource.AddRange(new string[] {
            "потребительский кредит",
            "открытие вклада",
            "на ипотеку"});
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "потребительский кредит",
            "открытие вклада",
            "на ипотеку"});
            this.type.Location = new System.Drawing.Point(243, 165);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(187, 21);
            this.type.TabIndex = 3;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(287, 256);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(213, 58);
            this.Add.TabIndex = 4;
            this.Add.Text = "Оформить заявку";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // sqlConnectionInsApp
            // 
            this.sqlConnectionInsApp.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionInsApp.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandInsApp
            // 
            this.sqlCommandInsApp.CommandText = "InsApp";
            this.sqlCommandInsApp.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommandInsApp.Connection = this.sqlConnectionInsApp;
            this.sqlCommandInsApp.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@fio", System.Data.SqlDbType.VarChar, 1000),
            new System.Data.SqlClient.SqlParameter("@type_appl", System.Data.SqlDbType.VarChar, 1000),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@pasport", System.Data.SqlDbType.VarChar)});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasport
            // 
            this.pasport.Location = new System.Drawing.Point(363, 122);
            this.pasport.Name = "pasport";
            this.pasport.Size = new System.Drawing.Size(276, 20);
            this.pasport.TabIndex = 11;
            this.pasport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pasport_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите свои паспортные данные:";
            // 
            // ArrengeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.label1);
            this.Name = "ArrengeApp";
            this.Text = "Оформление заявок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArrengeApp_FormClosing);
            this.Load += new System.EventHandler(this.ArrengeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button Add;
        private System.Data.SqlClient.SqlConnection sqlConnectionInsApp;
        private System.Data.SqlClient.SqlCommand sqlCommandInsApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pasport;
        private System.Windows.Forms.Label label3;
    }
}