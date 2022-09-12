
namespace KEP_Diffie_Hellman
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
            System.Windows.Forms.Label label_Key;
            this.buttonGetKey = new System.Windows.Forms.Button();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.buttonGeneratePN = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label_acceptedValue = new System.Windows.Forms.Label();
            this.label_selectedValue = new System.Windows.Forms.Label();
            this.textBox_acceptedValue = new System.Windows.Forms.TextBox();
            this.textBox_footingG = new System.Windows.Forms.TextBox();
            this.textBox_moduleN = new System.Windows.Forms.TextBox();
            this.label_footingG = new System.Windows.Forms.Label();
            this.textBox_setValue = new System.Windows.Forms.TextBox();
            this.label_moduleN = new System.Windows.Forms.Label();
            this.buttonSendAcceptedValue = new System.Windows.Forms.Button();
            this.buttonAcceptAcceptedValue = new System.Windows.Forms.Button();
            label_Key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Key
            // 
            label_Key.AutoSize = true;
            label_Key.Location = new System.Drawing.Point(12, 188);
            label_Key.Name = "label_Key";
            label_Key.Size = new System.Drawing.Size(108, 13);
            label_Key.TabIndex = 22;
            label_Key.Text = "Вычисленный ключ:";
            // 
            // buttonGetKey
            // 
            this.buttonGetKey.Enabled = false;
            this.buttonGetKey.Location = new System.Drawing.Point(129, 227);
            this.buttonGetKey.Name = "buttonGetKey";
            this.buttonGetKey.Size = new System.Drawing.Size(110, 25);
            this.buttonGetKey.TabIndex = 10;
            this.buttonGetKey.Text = "Получить ключ";
            this.buttonGetKey.UseVisualStyleBackColor = true;
            this.buttonGetKey.Click += new System.EventHandler(this.OnClickButtonGetKey);
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(15, 204);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.ReadOnly = true;
            this.textBox_key.Size = new System.Drawing.Size(224, 20);
            this.textBox_key.TabIndex = 1;
            // 
            // buttonGeneratePN
            // 
            this.buttonGeneratePN.Location = new System.Drawing.Point(131, 25);
            this.buttonGeneratePN.Name = "buttonGeneratePN";
            this.buttonGeneratePN.Size = new System.Drawing.Size(110, 25);
            this.buttonGeneratePN.TabIndex = 21;
            this.buttonGeneratePN.Text = "Сгенерировать";
            this.buttonGeneratePN.UseVisualStyleBackColor = true;
            this.buttonGeneratePN.Click += new System.EventHandler(this.OnClickButtonGeneratePN);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(131, 90);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(110, 25);
            this.buttonAccept.TabIndex = 20;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.OnClickButtonAccept);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(15, 90);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(110, 25);
            this.buttonSend.TabIndex = 19;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.OnClickButtonSend);
            // 
            // label_acceptedValue
            // 
            this.label_acceptedValue.AutoSize = true;
            this.label_acceptedValue.Location = new System.Drawing.Point(128, 118);
            this.label_acceptedValue.Name = "label_acceptedValue";
            this.label_acceptedValue.Size = new System.Drawing.Size(101, 13);
            this.label_acceptedValue.TabIndex = 14;
            this.label_acceptedValue.Text = "Принятое число Y:";
            // 
            // label_selectedValue
            // 
            this.label_selectedValue.AutoSize = true;
            this.label_selectedValue.Location = new System.Drawing.Point(12, 118);
            this.label_selectedValue.Name = "label_selectedValue";
            this.label_selectedValue.Size = new System.Drawing.Size(50, 13);
            this.label_selectedValue.TabIndex = 12;
            this.label_selectedValue.Text = "Число x:";
            // 
            // textBox_acceptedValue
            // 
            this.textBox_acceptedValue.Location = new System.Drawing.Point(131, 134);
            this.textBox_acceptedValue.Name = "textBox_acceptedValue";
            this.textBox_acceptedValue.ReadOnly = true;
            this.textBox_acceptedValue.Size = new System.Drawing.Size(110, 20);
            this.textBox_acceptedValue.TabIndex = 13;
            this.textBox_acceptedValue.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxAcceptedValue);
            // 
            // textBox_footingG
            // 
            this.textBox_footingG.Location = new System.Drawing.Point(15, 64);
            this.textBox_footingG.Name = "textBox_footingG";
            this.textBox_footingG.ReadOnly = true;
            this.textBox_footingG.Size = new System.Drawing.Size(110, 20);
            this.textBox_footingG.TabIndex = 17;
            this.textBox_footingG.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxFootingG);
            // 
            // textBox_moduleN
            // 
            this.textBox_moduleN.Location = new System.Drawing.Point(15, 25);
            this.textBox_moduleN.Name = "textBox_moduleN";
            this.textBox_moduleN.ReadOnly = true;
            this.textBox_moduleN.Size = new System.Drawing.Size(110, 20);
            this.textBox_moduleN.TabIndex = 15;
            this.textBox_moduleN.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxModuleN);
            // 
            // label_footingG
            // 
            this.label_footingG.AutoSize = true;
            this.label_footingG.Location = new System.Drawing.Point(12, 48);
            this.label_footingG.Name = "label_footingG";
            this.label_footingG.Size = new System.Drawing.Size(75, 13);
            this.label_footingG.TabIndex = 18;
            this.label_footingG.Text = "Основание g:";
            // 
            // textBox_setValue
            // 
            this.textBox_setValue.Location = new System.Drawing.Point(15, 134);
            this.textBox_setValue.MaxLength = 8;
            this.textBox_setValue.Name = "textBox_setValue";
            this.textBox_setValue.Size = new System.Drawing.Size(110, 20);
            this.textBox_setValue.TabIndex = 11;
            this.textBox_setValue.TextChanged += new System.EventHandler(this.OnTextChangedTextBoxSetValue);
            // 
            // label_moduleN
            // 
            this.label_moduleN.AutoSize = true;
            this.label_moduleN.Location = new System.Drawing.Point(12, 9);
            this.label_moduleN.Name = "label_moduleN";
            this.label_moduleN.Size = new System.Drawing.Size(57, 13);
            this.label_moduleN.TabIndex = 16;
            this.label_moduleN.Text = "Модуль n:";
            // 
            // buttonSendAcceptedValue
            // 
            this.buttonSendAcceptedValue.Enabled = false;
            this.buttonSendAcceptedValue.Location = new System.Drawing.Point(15, 160);
            this.buttonSendAcceptedValue.Name = "buttonSendAcceptedValue";
            this.buttonSendAcceptedValue.Size = new System.Drawing.Size(110, 25);
            this.buttonSendAcceptedValue.TabIndex = 23;
            this.buttonSendAcceptedValue.Text = "Отправить X";
            this.buttonSendAcceptedValue.UseVisualStyleBackColor = true;
            this.buttonSendAcceptedValue.Click += new System.EventHandler(this.OnClickButtonSendAcceptedValue);
            // 
            // buttonAcceptAcceptedValue
            // 
            this.buttonAcceptAcceptedValue.Location = new System.Drawing.Point(131, 160);
            this.buttonAcceptAcceptedValue.Name = "buttonAcceptAcceptedValue";
            this.buttonAcceptAcceptedValue.Size = new System.Drawing.Size(110, 25);
            this.buttonAcceptAcceptedValue.TabIndex = 24;
            this.buttonAcceptAcceptedValue.Text = "Принять Y";
            this.buttonAcceptAcceptedValue.UseVisualStyleBackColor = true;
            this.buttonAcceptAcceptedValue.Click += new System.EventHandler(this.OnClickButtonAcceptAcceptedValue);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(255, 259);
            this.Controls.Add(this.buttonAcceptAcceptedValue);
            this.Controls.Add(this.buttonSendAcceptedValue);
            this.Controls.Add(this.buttonGetKey);
            this.Controls.Add(label_Key);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.buttonGeneratePN);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label_acceptedValue);
            this.Controls.Add(this.label_selectedValue);
            this.Controls.Add(this.textBox_acceptedValue);
            this.Controls.Add(this.textBox_footingG);
            this.Controls.Add(this.textBox_moduleN);
            this.Controls.Add(this.label_footingG);
            this.Controls.Add(this.textBox_setValue);
            this.Controls.Add(this.label_moduleN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Участник А";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button buttonGetKey;
        private System.Windows.Forms.Button buttonGeneratePN;
        private System.Windows.Forms.Button buttonAccept;
        public System.Windows.Forms.Label label_acceptedValue;
        public System.Windows.Forms.Label label_selectedValue;
        public System.Windows.Forms.TextBox textBox_acceptedValue;
        public System.Windows.Forms.TextBox textBox_footingG;
        public System.Windows.Forms.TextBox textBox_moduleN;
        public System.Windows.Forms.Label label_footingG;
        public System.Windows.Forms.TextBox textBox_setValue;
        public System.Windows.Forms.Label label_moduleN;
        public System.Windows.Forms.Button buttonSendAcceptedValue;
        private System.Windows.Forms.Button buttonSend;
        public System.Windows.Forms.Button buttonAcceptAcceptedValue;
    }
}

