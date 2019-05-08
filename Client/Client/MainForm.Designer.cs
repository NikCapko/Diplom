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
            this.btnReceive = new System.Windows.Forms.Button();
            this.lRecipientName = new System.Windows.Forms.Label();
            this.tbRecipientName = new System.Windows.Forms.TextBox();
            this.lKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(16, 329);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(300, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Отправить сообщение";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbSenderName
            // 
            this.tbSenderName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenderName.Location = new System.Drawing.Point(16, 31);
            this.tbSenderName.Name = "tbSenderName";
            this.tbSenderName.Size = new System.Drawing.Size(276, 29);
            this.tbSenderName.TabIndex = 1;
            // 
            // lSenderName
            // 
            this.lSenderName.AutoSize = true;
            this.lSenderName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSenderName.Location = new System.Drawing.Point(12, 6);
            this.lSenderName.Name = "lSenderName";
            this.lSenderName.Size = new System.Drawing.Size(147, 22);
            this.lSenderName.TabIndex = 2;
            this.lSenderName.Text = "Логин отправителя";
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(12, 137);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(91, 22);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "Сообщение";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(16, 162);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(640, 151);
            this.tbMessage.TabIndex = 4;
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(356, 329);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(300, 37);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "Принять сооющение";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // lRecipientName
            // 
            this.lRecipientName.AutoSize = true;
            this.lRecipientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecipientName.Location = new System.Drawing.Point(312, 6);
            this.lRecipientName.Name = "lRecipientName";
            this.lRecipientName.Size = new System.Drawing.Size(139, 22);
            this.lRecipientName.TabIndex = 7;
            this.lRecipientName.Text = "Логин получателя";
            // 
            // tbRecipientName
            // 
            this.tbRecipientName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecipientName.Location = new System.Drawing.Point(316, 31);
            this.tbRecipientName.Name = "tbRecipientName";
            this.tbRecipientName.Size = new System.Drawing.Size(276, 29);
            this.tbRecipientName.TabIndex = 6;
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKey.Location = new System.Drawing.Point(12, 68);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(50, 22);
            this.lKey.TabIndex = 9;
            this.lKey.Text = "Ключ";
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(16, 93);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(640, 29);
            this.tbKey.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 378);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lRecipientName);
            this.Controls.Add(this.tbRecipientName);
            this.Controls.Add(this.btnReceive);
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
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label lRecipientName;
        private System.Windows.Forms.TextBox tbRecipientName;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.TextBox tbKey;
    }
}

