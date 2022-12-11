namespace InterfaceBank
{
    partial class Operator
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
            this.zayavka = new System.Windows.Forms.Button();
            this.wokers = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zayavka
            // 
            this.zayavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zayavka.Location = new System.Drawing.Point(277, 266);
            this.zayavka.Name = "zayavka";
            this.zayavka.Size = new System.Drawing.Size(222, 56);
            this.zayavka.TabIndex = 8;
            this.zayavka.Text = "Учет счетов клиентов";
            this.zayavka.UseVisualStyleBackColor = true;
            this.zayavka.Click += new System.EventHandler(this.zayavka_Click);
            // 
            // wokers
            // 
            this.wokers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wokers.Location = new System.Drawing.Point(277, 177);
            this.wokers.Name = "wokers";
            this.wokers.Size = new System.Drawing.Size(222, 74);
            this.wokers.TabIndex = 7;
            this.wokers.Text = "Переводы на другую валюту";
            this.wokers.UseVisualStyleBackColor = true;
            this.wokers.Click += new System.EventHandler(this.wokers_Click);
            // 
            // clients
            // 
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients.Location = new System.Drawing.Point(277, 106);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(222, 56);
            this.clients.TabIndex = 6;
            this.clients.Text = "Учет переводов";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(258, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите действие";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(277, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 74);
            this.button1.TabIndex = 9;
            this.button1.Text = "Учет квитанций";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zayavka);
            this.Controls.Add(this.wokers);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.label1);
            this.Name = "Operator";
            this.Text = "Операционист";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zayavka;
        private System.Windows.Forms.Button wokers;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}