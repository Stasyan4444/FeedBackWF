
namespace WorkTest
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
            this.SendMes = new System.Windows.Forms.Button();
            this.CallUs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UrName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UrEmail = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UrPhone = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Phone = new System.Windows.Forms.PictureBox();
            this.Convertik = new System.Windows.Forms.PictureBox();
            this.Human = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Convertik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Human)).BeginInit();
            this.SuspendLayout();
            // 
            // SendMes
            // 
            this.SendMes.BackColor = System.Drawing.SystemColors.Highlight;
            this.SendMes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendMes.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendMes.Location = new System.Drawing.Point(0, 546);
            this.SendMes.Name = "SendMes";
            this.SendMes.Size = new System.Drawing.Size(510, 71);
            this.SendMes.TabIndex = 0;
            this.SendMes.Text = "Отправить Письмо";
            this.SendMes.UseVisualStyleBackColor = false;
            this.SendMes.Click += new System.EventHandler(this.button1_Click);
            // 
            // CallUs
            // 
            this.CallUs.AutoSize = true;
            this.CallUs.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallUs.ForeColor = System.Drawing.Color.White;
            this.CallUs.Location = new System.Drawing.Point(3, 9);
            this.CallUs.Name = "CallUs";
            this.CallUs.Size = new System.Drawing.Size(500, 26);
            this.CallUs.TabIndex = 1;
            this.CallUs.Text = "Оставьте свои контакты для обратной связи";
            this.CallUs.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.CallUs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 66);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UrName
            // 
            this.UrName.AutoSize = true;
            this.UrName.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrName.Location = new System.Drawing.Point(45, 111);
            this.UrName.Name = "UrName";
            this.UrName.Size = new System.Drawing.Size(106, 23);
            this.UrName.TabIndex = 2;
            this.UrName.Text = "Ваше имя:";
            this.UrName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 43);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(207, 168);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 43);
            this.textBox2.TabIndex = 6;
            // 
            // UrEmail
            // 
            this.UrEmail.AutoSize = true;
            this.UrEmail.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrEmail.Location = new System.Drawing.Point(45, 179);
            this.UrEmail.Name = "UrEmail";
            this.UrEmail.Size = new System.Drawing.Size(108, 20);
            this.UrEmail.TabIndex = 7;
            this.UrEmail.Text = "Ваш Email:";
            this.UrEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(207, 228);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(244, 43);
            this.textBox3.TabIndex = 9;
            // 
            // UrPhone
            // 
            this.UrPhone.AutoSize = true;
            this.UrPhone.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrPhone.Location = new System.Drawing.Point(20, 239);
            this.UrPhone.Name = "UrPhone";
            this.UrPhone.Size = new System.Drawing.Size(131, 20);
            this.UrPhone.TabIndex = 10;
            this.UrPhone.Text = "Ваш телефон:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Техподдержа",
            "Продажи",
            "FAQ",
            "Другое"});
            this.comboBox1.Location = new System.Drawing.Point(157, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Техподдержка";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Тема:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ваше \r\nСообщение:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(157, 348);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 103);
            this.textBox4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цифры:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(157, 468);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 43);
            this.textBox5.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkTest.Properties.Resources.Без_названия;
            this.pictureBox1.Location = new System.Drawing.Point(319, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Phone
            // 
            this.Phone.Image = global::WorkTest.Properties.Resources.phone;
            this.Phone.Location = new System.Drawing.Point(157, 228);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(44, 44);
            this.Phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Phone.TabIndex = 8;
            this.Phone.TabStop = false;
            // 
            // Convertik
            // 
            this.Convertik.Image = global::WorkTest.Properties.Resources.messege;
            this.Convertik.Location = new System.Drawing.Point(157, 168);
            this.Convertik.Name = "Convertik";
            this.Convertik.Size = new System.Drawing.Size(44, 44);
            this.Convertik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Convertik.TabIndex = 5;
            this.Convertik.TabStop = false;
            // 
            // Human
            // 
            this.Human.Image = global::WorkTest.Properties.Resources.human1;
            this.Human.Location = new System.Drawing.Point(157, 101);
            this.Human.Name = "Human";
            this.Human.Size = new System.Drawing.Size(44, 44);
            this.Human.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Human.TabIndex = 3;
            this.Human.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(510, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UrPhone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.UrEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Convertik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Human);
            this.Controls.Add(this.UrName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendMes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Convertik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Human)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMes;
        private System.Windows.Forms.Label CallUs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UrName;
        private System.Windows.Forms.PictureBox Human;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox Convertik;
        private System.Windows.Forms.Label UrEmail;
        private System.Windows.Forms.PictureBox Phone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label UrPhone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

