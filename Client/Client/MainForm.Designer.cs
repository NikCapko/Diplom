namespace Client
{
    partial class MainForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbSenderName = new System.Windows.Forms.TextBox();
            this.lSenderName = new System.Windows.Forms.Label();
            this.lMessage = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lRecipientName = new System.Windows.Forms.Label();
            this.tbRecipientName = new System.Windows.Forms.TextBox();
            this.lKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lServerAddress = new System.Windows.Forms.Label();
            this.tbServerAddress = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheckUserName = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(13, 398);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(400, 46);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Отправить сообщение";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbSenderName
            // 
            this.tbSenderName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenderName.Location = new System.Drawing.Point(501, 41);
            this.tbSenderName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(367, 34);
            this.tbSenderName.TabIndex = 1;
            this.tbSenderName.Text = "user1";
            // 
            // lSenderName
            // 
            this.lSenderName.AutoSize = true;
            this.lSenderName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSenderName.Location = new System.Drawing.Point(496, 10);
            this.lSenderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSenderName.Name = "lSenderName";
            this.lSenderName.Size = new System.Drawing.Size(195, 27);
            this.lSenderName.TabIndex = 2;
            this.lSenderName.Text = "Логин отправителя";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(11, 310);
            this.lMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(122, 27);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "Сообщение";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(16, 341);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(852, 49);
            this.tbMessage.TabIndex = 4;
            this.tbMessage.Text = "Hello";
            // 
            // lRecipientName
            // 
            this.lRecipientName.AutoSize = true;
            this.lRecipientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecipientName.Location = new System.Drawing.Point(11, 155);
            this.lRecipientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRecipientName.Name = "lRecipientName";
            this.lRecipientName.Size = new System.Drawing.Size(185, 27);
            this.lRecipientName.TabIndex = 7;
            this.lRecipientName.Text = "Логин получателя";
            // 
            // tbRecipientName
            // 
            this.tbRecipientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecipientName.Location = new System.Drawing.Point(15, 186);
            this.tbRecipientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRecipientName.Name = "tbRecipientName";
            this.tbRecipientName.Size = new System.Drawing.Size(367, 34);
            this.tbRecipientName.TabIndex = 6;
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKey.Location = new System.Drawing.Point(16, 241);
            this.lKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(65, 27);
            this.lKey.TabIndex = 9;
            this.lKey.Text = "Ключ";
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(15, 272);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(852, 34);
            this.tbKey.TabIndex = 8;
            this.tbKey.Text = "key";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(15, 84);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(400, 46);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lServerAddress
            // 
            this.lServerAddress.AutoSize = true;
            this.lServerAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lServerAddress.Location = new System.Drawing.Point(16, 10);
            this.lServerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lServerAddress.Name = "lServerAddress";
            this.lServerAddress.Size = new System.Drawing.Size(147, 27);
            this.lServerAddress.TabIndex = 11;
            this.lServerAddress.Text = "Адрес сервера";
            // 
            // tbServerAddress
            // 
            this.tbServerAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerAddress.Location = new System.Drawing.Point(21, 42);
            this.tbServerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServerAddress.Name = "tbServerAddress";
            this.tbServerAddress.Size = new System.Drawing.Size(367, 34);
            this.tbServerAddress.TabIndex = 12;
            this.tbServerAddress.Text = "127.0.0.1:8083";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 734);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(852, 85);
            this.textBox1.TabIndex = 13;
            // 
            // btnCheckUserName
            // 
            this.btnCheckUserName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUserName.Location = new System.Drawing.Point(444, 181);
            this.btnCheckUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckUserName.Name = "btnCheckUserName";
            this.btnCheckUserName.Size = new System.Drawing.Size(400, 46);
            this.btnCheckUserName.TabIndex = 14;
            this.btnCheckUserName.Text = "Проверить";
            this.btnCheckUserName.UseVisualStyleBackColor = true;
            this.btnCheckUserName.Click += new System.EventHandler(this.BtnCheckUserName_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 488);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(846, 34);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 457);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Отправляемое зашифрованное сообщение";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 566);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(846, 34);
            this.textBox3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ключ DES для расшифрования";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 616);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ключ DES, зашифрованный с помощью RSA";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(13, 658);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(846, 34);
            this.textBox4.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 834);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCheckUserName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbServerAddress);
            this.Controls.Add(this.lServerAddress);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lRecipientName);
            this.Controls.Add(this.tbRecipientName);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.lSenderName);
            this.Controls.Add(this.tbSenderName);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbSenderName;
        private System.Windows.Forms.Label lSenderName;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lRecipientName;
        private System.Windows.Forms.TextBox tbRecipientName;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lServerAddress;
        private System.Windows.Forms.TextBox tbServerAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheckUserName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

