namespace Condi
{
    partial class Comments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_doc_btn = new System.Windows.Forms.Button();
            this.add_doc_btn = new System.Windows.Forms.Button();
            this.hospital_address_label = new System.Windows.Forms.Label();
            this.phone_no_label = new System.Windows.Forms.Label();
            this.email_address_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.crudPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 196);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // crudPanel
            // 
            this.crudPanel.Controls.Add(this.button1);
            this.crudPanel.Controls.Add(this.textBox6);
            this.crudPanel.Controls.Add(this.label2);
            this.crudPanel.Controls.Add(this.textBox4);
            this.crudPanel.Controls.Add(this.textBox3);
            this.crudPanel.Controls.Add(this.textBox2);
            this.crudPanel.Controls.Add(this.textBox1);
            this.crudPanel.Controls.Add(this.reset_btn);
            this.crudPanel.Controls.Add(this.delete_btn);
            this.crudPanel.Controls.Add(this.update_doc_btn);
            this.crudPanel.Controls.Add(this.add_doc_btn);
            this.crudPanel.Controls.Add(this.hospital_address_label);
            this.crudPanel.Controls.Add(this.phone_no_label);
            this.crudPanel.Controls.Add(this.email_address_label);
            this.crudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudPanel.Location = new System.Drawing.Point(0, 0);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(800, 260);
            this.crudPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID комментария";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 20);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 29;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset_btn.Location = new System.Drawing.Point(614, 86);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(119, 38);
            this.reset_btn.TabIndex = 27;
            this.reset_btn.Text = "Вернуть";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(90)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(475, 86);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(119, 38);
            this.delete_btn.TabIndex = 26;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_doc_btn
            // 
            this.update_doc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(81)))));
            this.update_doc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_doc_btn.FlatAppearance.BorderSize = 0;
            this.update_doc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_doc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_doc_btn.Location = new System.Drawing.Point(614, 32);
            this.update_doc_btn.Name = "update_doc_btn";
            this.update_doc_btn.Size = new System.Drawing.Size(119, 38);
            this.update_doc_btn.TabIndex = 25;
            this.update_doc_btn.Text = "Обновить";
            this.update_doc_btn.UseVisualStyleBackColor = false;
            this.update_doc_btn.Click += new System.EventHandler(this.update_doc_btn_Click);
            // 
            // add_doc_btn
            // 
            this.add_doc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.add_doc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_doc_btn.FlatAppearance.BorderSize = 0;
            this.add_doc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_doc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_doc_btn.Location = new System.Drawing.Point(475, 32);
            this.add_doc_btn.Name = "add_doc_btn";
            this.add_doc_btn.Size = new System.Drawing.Size(119, 38);
            this.add_doc_btn.TabIndex = 24;
            this.add_doc_btn.Text = "Добавить";
            this.add_doc_btn.UseVisualStyleBackColor = false;
            this.add_doc_btn.Click += new System.EventHandler(this.add_doc_btn_Click);
            // 
            // hospital_address_label
            // 
            this.hospital_address_label.AutoSize = true;
            this.hospital_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.hospital_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_address_label.Location = new System.Drawing.Point(245, 9);
            this.hospital_address_label.Name = "hospital_address_label";
            this.hospital_address_label.Size = new System.Drawing.Size(79, 17);
            this.hospital_address_label.TabIndex = 9;
            this.hospital_address_label.Text = "ID клиента";
            // 
            // phone_no_label
            // 
            this.phone_no_label.AutoSize = true;
            this.phone_no_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.phone_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_no_label.Location = new System.Drawing.Point(12, 136);
            this.phone_no_label.Name = "phone_no_label";
            this.phone_no_label.Size = new System.Drawing.Size(80, 17);
            this.phone_no_label.TabIndex = 10;
            this.phone_no_label.Text = "ID мастера";
            // 
            // email_address_label
            // 
            this.email_address_label.AutoSize = true;
            this.email_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address_label.Location = new System.Drawing.Point(12, 79);
            this.email_address_label.Name = "email_address_label";
            this.email_address_label.Size = new System.Drawing.Size(84, 17);
            this.email_address_label.TabIndex = 11;
            this.email_address_label.Text = "Сообщение";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(669, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 44;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(250, 207);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(386, 33);
            this.textBox6.TabIndex = 43;
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crudPanel);
            this.Name = "Comments";
            this.Text = "Комментарии";
            this.Load += new System.EventHandler(this.Comments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_doc_btn;
        private System.Windows.Forms.Button add_doc_btn;
        private System.Windows.Forms.Label hospital_address_label;
        private System.Windows.Forms.Label phone_no_label;
        private System.Windows.Forms.Label email_address_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
    }
}