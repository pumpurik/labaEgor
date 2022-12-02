namespace InterfaceBank
{
    partial class Form2
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
            this.scheta = new System.Windows.Forms.Button();
            this.request = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(246, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие";
            // 
            // scheta
            // 
            this.scheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheta.Location = new System.Drawing.Point(272, 85);
            this.scheta.Name = "scheta";
            this.scheta.Size = new System.Drawing.Size(222, 56);
            this.scheta.TabIndex = 1;
            this.scheta.Text = "Ваши счета";
            this.scheta.UseVisualStyleBackColor = true;
            this.scheta.Click += new System.EventHandler(this.button1_Click);
            // 
            // request
            // 
            this.request.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request.Location = new System.Drawing.Point(272, 157);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(222, 56);
            this.request.TabIndex = 2;
            this.request.Text = "Ваши заявки";
            this.request.UseVisualStyleBackColor = true;
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(272, 228);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(221, 56);
            this.money.TabIndex = 3;
            this.money.Text = "Снятие денег";
            this.money.UseVisualStyleBackColor = true;
            this.money.Click += new System.EventHandler(this.money_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(273, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Платежи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(273, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ваши переводы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.request);
            this.Controls.Add(this.scheta);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scheta;
        private System.Windows.Forms.Button request;
        private System.Windows.Forms.Button money;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}