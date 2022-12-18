
namespace Elgamal_encryption
{
    partial class FormSender
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
            this.richTextData = new System.Windows.Forms.RichTextBox();
            this.labelOpenKeyYValue = new System.Windows.Forms.Label();
            this.labelOpenKeyGValue = new System.Windows.Forms.Label();
            this.labelOpenKeyPValue = new System.Windows.Forms.Label();
            this.labelOpenKeyY = new System.Windows.Forms.Label();
            this.labelOpenKeyG = new System.Windows.Forms.Label();
            this.labelOpenKeyP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrivateKeyGenerate = new System.Windows.Forms.Button();
            this.buttonMessageCrypt = new System.Windows.Forms.Button();
            this.labelKValue = new System.Windows.Forms.Label();
            this.buttonSendToRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextData
            // 
            this.richTextData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextData.Location = new System.Drawing.Point(12, 148);
            this.richTextData.Name = "richTextData";
            this.richTextData.Size = new System.Drawing.Size(511, 289);
            this.richTextData.TabIndex = 1;
            this.richTextData.Text = "";
            // 
            // labelOpenKeyYValue
            // 
            this.labelOpenKeyYValue.AutoSize = true;
            this.labelOpenKeyYValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyYValue.Location = new System.Drawing.Point(39, 82);
            this.labelOpenKeyYValue.Name = "labelOpenKeyYValue";
            this.labelOpenKeyYValue.Size = new System.Drawing.Size(0, 19);
            this.labelOpenKeyYValue.TabIndex = 34;
            // 
            // labelOpenKeyGValue
            // 
            this.labelOpenKeyGValue.AutoSize = true;
            this.labelOpenKeyGValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyGValue.Location = new System.Drawing.Point(48, 54);
            this.labelOpenKeyGValue.Name = "labelOpenKeyGValue";
            this.labelOpenKeyGValue.Size = new System.Drawing.Size(0, 19);
            this.labelOpenKeyGValue.TabIndex = 33;
            // 
            // labelOpenKeyPValue
            // 
            this.labelOpenKeyPValue.AutoSize = true;
            this.labelOpenKeyPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyPValue.Location = new System.Drawing.Point(39, 28);
            this.labelOpenKeyPValue.Name = "labelOpenKeyPValue";
            this.labelOpenKeyPValue.Size = new System.Drawing.Size(0, 19);
            this.labelOpenKeyPValue.TabIndex = 32;
            // 
            // labelOpenKeyY
            // 
            this.labelOpenKeyY.AutoSize = true;
            this.labelOpenKeyY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyY.Location = new System.Drawing.Point(12, 82);
            this.labelOpenKeyY.Name = "labelOpenKeyY";
            this.labelOpenKeyY.Size = new System.Drawing.Size(37, 19);
            this.labelOpenKeyY.TabIndex = 31;
            this.labelOpenKeyY.Text = "Y = ";
            // 
            // labelOpenKeyG
            // 
            this.labelOpenKeyG.AutoSize = true;
            this.labelOpenKeyG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyG.Location = new System.Drawing.Point(12, 54);
            this.labelOpenKeyG.Name = "labelOpenKeyG";
            this.labelOpenKeyG.Size = new System.Drawing.Size(40, 19);
            this.labelOpenKeyG.TabIndex = 30;
            this.labelOpenKeyG.Text = "G = ";
            // 
            // labelOpenKeyP
            // 
            this.labelOpenKeyP.AutoSize = true;
            this.labelOpenKeyP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyP.Location = new System.Drawing.Point(12, 28);
            this.labelOpenKeyP.Name = "labelOpenKeyP";
            this.labelOpenKeyP.Size = new System.Drawing.Size(36, 19);
            this.labelOpenKeyP.TabIndex = 29;
            this.labelOpenKeyP.Text = "P = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Открытый ключ";
            // 
            // buttonPrivateKeyGenerate
            // 
            this.buttonPrivateKeyGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrivateKeyGenerate.Location = new System.Drawing.Point(12, 107);
            this.buttonPrivateKeyGenerate.Name = "buttonPrivateKeyGenerate";
            this.buttonPrivateKeyGenerate.Size = new System.Drawing.Size(257, 35);
            this.buttonPrivateKeyGenerate.TabIndex = 35;
            this.buttonPrivateKeyGenerate.Text = "Генерация закрытого ключа";
            this.buttonPrivateKeyGenerate.UseVisualStyleBackColor = true;
            this.buttonPrivateKeyGenerate.Click += new System.EventHandler(this.buttonPrivateKeyGenerate_Click);
            // 
            // buttonMessageCrypt
            // 
            this.buttonMessageCrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMessageCrypt.Location = new System.Drawing.Point(313, 66);
            this.buttonMessageCrypt.Name = "buttonMessageCrypt";
            this.buttonMessageCrypt.Size = new System.Drawing.Size(210, 35);
            this.buttonMessageCrypt.TabIndex = 36;
            this.buttonMessageCrypt.Text = "Зашифровать";
            this.buttonMessageCrypt.UseVisualStyleBackColor = true;
            this.buttonMessageCrypt.Click += new System.EventHandler(this.buttonMessageCrypt_Click);
            // 
            // labelKValue
            // 
            this.labelKValue.AutoSize = true;
            this.labelKValue.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKValue.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKValue.Location = new System.Drawing.Point(669, 119);
            this.labelKValue.Name = "labelKValue";
            this.labelKValue.Size = new System.Drawing.Size(0, 16);
            this.labelKValue.TabIndex = 37;
            // 
            // buttonSendToRec
            // 
            this.buttonSendToRec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendToRec.Location = new System.Drawing.Point(313, 107);
            this.buttonSendToRec.Name = "buttonSendToRec";
            this.buttonSendToRec.Size = new System.Drawing.Size(210, 35);
            this.buttonSendToRec.TabIndex = 38;
            this.buttonSendToRec.Text = "Отправить";
            this.buttonSendToRec.UseVisualStyleBackColor = true;
            this.buttonSendToRec.Click += new System.EventHandler(this.buttonSendToRec_Click);
            // 
            // FormSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 449);
            this.Controls.Add(this.buttonSendToRec);
            this.Controls.Add(this.labelKValue);
            this.Controls.Add(this.buttonMessageCrypt);
            this.Controls.Add(this.buttonPrivateKeyGenerate);
            this.Controls.Add(this.labelOpenKeyYValue);
            this.Controls.Add(this.labelOpenKeyGValue);
            this.Controls.Add(this.labelOpenKeyPValue);
            this.Controls.Add(this.labelOpenKeyY);
            this.Controls.Add(this.labelOpenKeyG);
            this.Controls.Add(this.labelOpenKeyP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextData);
            this.Location = new System.Drawing.Point(350, 150);
            this.Name = "FormSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.FormSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox richTextData;
        private System.Windows.Forms.Label labelOpenKeyY;
        private System.Windows.Forms.Label labelOpenKeyG;
        private System.Windows.Forms.Label labelOpenKeyP;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelOpenKeyYValue;
        public System.Windows.Forms.Label labelOpenKeyGValue;
        public System.Windows.Forms.Label labelOpenKeyPValue;
        private System.Windows.Forms.Button buttonPrivateKeyGenerate;
        private System.Windows.Forms.Button buttonMessageCrypt;
        public System.Windows.Forms.Label labelKValue;
        private System.Windows.Forms.Button buttonSendToRec;
    }
}

