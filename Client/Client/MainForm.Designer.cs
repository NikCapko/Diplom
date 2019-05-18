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
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(12, 466);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(300, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Отправить сообщение";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbSenderName
            // 
            this.tbSenderName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenderName.Location = new System.Drawing.Point(376, 33);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(276, 29);
            this.tbSenderName.TabIndex = 1;
            this.tbSenderName.Text = "user1";
            // 
            // lSenderName
            // 
            this.lSenderName.AutoSize = true;
            this.lSenderName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSenderName.Location = new System.Drawing.Point(372, 8);
            this.lSenderName.Name = "lSenderName";
            this.lSenderName.Size = new System.Drawing.Size(147, 22);
            this.lSenderName.TabIndex = 2;
            this.lSenderName.Text = "Логин отправителя";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(8, 274);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(91, 22);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "Сообщение";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(12, 299);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(640, 151);
            this.tbMessage.TabIndex = 4;
            // 
            // lRecipientName
            // 
            this.lRecipientName.AutoSize = true;
            this.lRecipientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecipientName.Location = new System.Drawing.Point(8, 126);
            this.lRecipientName.Name = "lRecipientName";
            this.lRecipientName.Size = new System.Drawing.Size(139, 22);
            this.lRecipientName.TabIndex = 7;
            this.lRecipientName.Text = "Логин получателя";
            // 
            // tbRecipientName
            // 
            this.tbRecipientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecipientName.Location = new System.Drawing.Point(11, 151);
            this.tbRecipientName.Name = "tbRecipientName";
            this.tbRecipientName.Size = new System.Drawing.Size(276, 29);
            this.tbRecipientName.TabIndex = 6;
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKey.Location = new System.Drawing.Point(12, 196);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(50, 22);
            this.lKey.TabIndex = 9;
            this.lKey.Text = "Ключ";
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(11, 221);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(640, 29);
            this.tbKey.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(11, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(300, 37);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lServerAddress
            // 
            this.lServerAddress.AutoSize = true;
            this.lServerAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lServerAddress.Location = new System.Drawing.Point(12, 8);
            this.lServerAddress.Name = "lServerAddress";
            this.lServerAddress.Size = new System.Drawing.Size(111, 22);
            this.lServerAddress.TabIndex = 11;
            this.lServerAddress.Text = "Адрес сервера";
            // 
            // tbServerAddress
            // 
            this.tbServerAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerAddress.Location = new System.Drawing.Point(12, 33);
            this.tbServerAddress.Name = "tbServerAddress";
            this.tbServerAddress.Size = new System.Drawing.Size(276, 29);
            this.tbServerAddress.TabIndex = 12;
            this.tbServerAddress.Text = "127.0.0.1:8083";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 515);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(640, 151);
            this.textBox1.TabIndex = 13;
            // 
            // btnCheckUserName
            // 
            this.btnCheckUserName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUserName.Location = new System.Drawing.Point(333, 147);
            this.btnCheckUserName.Name = "btnCheckUserName";
            this.btnCheckUserName.Size = new System.Drawing.Size(300, 37);
            this.btnCheckUserName.TabIndex = 14;
            this.btnCheckUserName.Text = "Проверить";
            this.btnCheckUserName.UseVisualStyleBackColor = true;
            this.btnCheckUserName.Click += new System.EventHandler(this.BtnCheckUserName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 678);
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
    }
}

