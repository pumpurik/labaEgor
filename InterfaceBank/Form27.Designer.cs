namespace InterfaceBank
{
    partial class ShowSchetaClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSchetaClient));
            this.Scheta = new System.Windows.Forms.DataGridView();
            this.sqlConnectionSchetaClient = new System.Data.SqlClient.SqlConnection();
            this.sqlCommandShow = new System.Data.SqlClient.SqlCommand();
            this.show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Scheta)).BeginInit();
            this.SuspendLayout();
            // 
            // Scheta
            // 
            this.Scheta.AllowUserToAddRows = false;
            this.Scheta.AllowUserToDeleteRows = false;
            this.Scheta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Scheta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Scheta.Location = new System.Drawing.Point(51, 68);
            this.Scheta.Name = "Scheta";
            this.Scheta.Size = new System.Drawing.Size(673, 332);
            this.Scheta.TabIndex = 0;
            this.Scheta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Scheta_CellContentClick);
            // 
            // sqlConnectionSchetaClient
            // 
            this.sqlConnectionSchetaClient.ConnectionString = "Data Source=DESKTOP-Q6VD9PD\\SQLEXPRESS01;Initial Catalog=Bank;Integrated Security" +
    "=True";
            this.sqlConnectionSchetaClient.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommandShow
            // 
            this.sqlCommandShow.CommandText = resources.GetString("sqlCommandShow.CommandText");
            this.sqlCommandShow.Connection = this.sqlConnectionSchetaClient;
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.Location = new System.Drawing.Point(538, 31);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(186, 31);
            this.show.TabIndex = 18;
            this.show.Text = "Обновить";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // ShowSchetaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Scheta);
            this.Name = "ShowSchetaClient";
            this.Text = "Счета клиентов";
            this.Load += new System.EventHandler(this.ShowSchetaClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scheta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Scheta;
        private System.Data.SqlClient.SqlConnection sqlConnectionSchetaClient;
        private System.Data.SqlClient.SqlCommand sqlCommandShow;
        private System.Windows.Forms.Button show;
    }
}