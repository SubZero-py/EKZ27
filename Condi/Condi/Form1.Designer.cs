namespace Condi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.welcome_image = new System.Windows.Forms.PictureBox();
            this.welcome_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_image)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_login_btn.FlatAppearance.BorderSize = 0;
            this.admin_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_btn.Location = new System.Drawing.Point(374, 364);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(140, 38);
            this.admin_login_btn.TabIndex = 9;
            this.admin_login_btn.Text = "Для персонала";
            this.admin_login_btn.UseVisualStyleBackColor = false;
            this.admin_login_btn.Click += new System.EventHandler(this.admin_login_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(239, 364);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(130, 38);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "Для заказчика";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // welcome_image
            // 
            this.welcome_image.Image = global::Condi.Properties.Resources.Repair_Icon;
            this.welcome_image.Location = new System.Drawing.Point(256, 72);
            this.welcome_image.Name = "welcome_image";
            this.welcome_image.Size = new System.Drawing.Size(259, 274);
            this.welcome_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcome_image.TabIndex = 8;
            this.welcome_image.TabStop = false;
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.Black;
            this.welcome_text.Location = new System.Drawing.Point(46, 49);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(703, 20);
            this.welcome_text.TabIndex = 7;
            this.welcome_text.Text = "Добро пожаловать в сервисный центр по ремонту климатического оборудования";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.welcome_image);
            this.Controls.Add(this.welcome_text);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.welcome_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_login_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox welcome_image;
        private System.Windows.Forms.Label welcome_text;
    }
}

