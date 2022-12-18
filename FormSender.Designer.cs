
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
            this.buttonPrimeGenerate = new System.Windows.Forms.Button();
            this.richTextData = new System.Windows.Forms.RichTextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelNCount = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelPValue = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP2Value = new System.Windows.Forms.Label();
            this.labelNValue = new System.Windows.Forms.Label();
            this.buttonPrimeCheck = new System.Windows.Forms.Button();
            this.labelOpenKeyYValue = new System.Windows.Forms.Label();
            this.labelOpenKeyGValue = new System.Windows.Forms.Label();
            this.labelOpenKeyPValue = new System.Windows.Forms.Label();
            this.labelOpenKeyY = new System.Windows.Forms.Label();
            this.labelOpenKeyG = new System.Windows.Forms.Label();
            this.labelOpenKeyP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrivateKeyGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrimeGenerate
            // 
            this.buttonPrimeGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeGenerate.Location = new System.Drawing.Point(12, 119);
            this.buttonPrimeGenerate.Name = "buttonPrimeGenerate";
            this.buttonPrimeGenerate.Size = new System.Drawing.Size(210, 35);
            this.buttonPrimeGenerate.TabIndex = 0;
            this.buttonPrimeGenerate.Text = "Генерация простого P";
            this.buttonPrimeGenerate.UseVisualStyleBackColor = true;
            this.buttonPrimeGenerate.Click += new System.EventHandler(this.buttonPrimelGenerate_Click);
            // 
            // richTextData
            // 
            this.richTextData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextData.Location = new System.Drawing.Point(12, 210);
            this.richTextData.Name = "richTextData";
            this.richTextData.Size = new System.Drawing.Size(684, 158);
            this.richTextData.TabIndex = 1;
            this.richTextData.Text = "";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(22, 82);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(39, 19);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "N = ";
            // 
            // labelNCount
            // 
            this.labelNCount.AutoSize = true;
            this.labelNCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNCount.Location = new System.Drawing.Point(55, 25);
            this.labelNCount.Name = "labelNCount";
            this.labelNCount.Size = new System.Drawing.Size(0, 19);
            this.labelNCount.TabIndex = 3;
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP1.Location = new System.Drawing.Point(22, 25);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(45, 19);
            this.labelP1.TabIndex = 4;
            this.labelP1.Text = "P1 = ";
            // 
            // labelPValue
            // 
            this.labelPValue.AutoSize = true;
            this.labelPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPValue.Location = new System.Drawing.Point(55, 25);
            this.labelPValue.Name = "labelPValue";
            this.labelPValue.Size = new System.Drawing.Size(0, 19);
            this.labelPValue.TabIndex = 5;
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2.Location = new System.Drawing.Point(22, 54);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(45, 19);
            this.labelP2.TabIndex = 6;
            this.labelP2.Text = "P2 = ";
            // 
            // labelP2Value
            // 
            this.labelP2Value.AutoSize = true;
            this.labelP2Value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2Value.Location = new System.Drawing.Point(55, 54);
            this.labelP2Value.Name = "labelP2Value";
            this.labelP2Value.Size = new System.Drawing.Size(0, 19);
            this.labelP2Value.TabIndex = 7;
            // 
            // labelNValue
            // 
            this.labelNValue.AutoSize = true;
            this.labelNValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNValue.Location = new System.Drawing.Point(55, 82);
            this.labelNValue.Name = "labelNValue";
            this.labelNValue.Size = new System.Drawing.Size(0, 19);
            this.labelNValue.TabIndex = 8;
            // 
            // buttonPrimeCheck
            // 
            this.buttonPrimeCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeCheck.Location = new System.Drawing.Point(12, 160);
            this.buttonPrimeCheck.Name = "buttonPrimeCheck";
            this.buttonPrimeCheck.Size = new System.Drawing.Size(210, 35);
            this.buttonPrimeCheck.TabIndex = 9;
            this.buttonPrimeCheck.Text = "Проверка простоты";
            this.buttonPrimeCheck.UseVisualStyleBackColor = true;
            this.buttonPrimeCheck.Click += new System.EventHandler(this.buttonPrimeCheck_Click);
            // 
            // labelOpenKeyYValue
            // 
            this.labelOpenKeyYValue.AutoSize = true;
            this.labelOpenKeyYValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyYValue.Location = new System.Drawing.Point(321, 82);
            this.labelOpenKeyYValue.Name = "labelOpenKeyYValue";
            this.labelOpenKeyYValue.Size = new System.Drawing.Size(58, 19);
            this.labelOpenKeyYValue.TabIndex = 34;
            this.labelOpenKeyYValue.Text = "label2";
            // 
            // labelOpenKeyGValue
            // 
            this.labelOpenKeyGValue.AutoSize = true;
            this.labelOpenKeyGValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyGValue.Location = new System.Drawing.Point(330, 54);
            this.labelOpenKeyGValue.Name = "labelOpenKeyGValue";
            this.labelOpenKeyGValue.Size = new System.Drawing.Size(58, 19);
            this.labelOpenKeyGValue.TabIndex = 33;
            this.labelOpenKeyGValue.Text = "label2";
            // 
            // labelOpenKeyPValue
            // 
            this.labelOpenKeyPValue.AutoSize = true;
            this.labelOpenKeyPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyPValue.Location = new System.Drawing.Point(321, 28);
            this.labelOpenKeyPValue.Name = "labelOpenKeyPValue";
            this.labelOpenKeyPValue.Size = new System.Drawing.Size(58, 19);
            this.labelOpenKeyPValue.TabIndex = 32;
            this.labelOpenKeyPValue.Text = "label2";
            // 
            // labelOpenKeyY
            // 
            this.labelOpenKeyY.AutoSize = true;
            this.labelOpenKeyY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyY.Location = new System.Drawing.Point(294, 82);
            this.labelOpenKeyY.Name = "labelOpenKeyY";
            this.labelOpenKeyY.Size = new System.Drawing.Size(37, 19);
            this.labelOpenKeyY.TabIndex = 31;
            this.labelOpenKeyY.Text = "Y = ";
            // 
            // labelOpenKeyG
            // 
            this.labelOpenKeyG.AutoSize = true;
            this.labelOpenKeyG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyG.Location = new System.Drawing.Point(294, 54);
            this.labelOpenKeyG.Name = "labelOpenKeyG";
            this.labelOpenKeyG.Size = new System.Drawing.Size(40, 19);
            this.labelOpenKeyG.TabIndex = 30;
            this.labelOpenKeyG.Text = "G = ";
            // 
            // labelOpenKeyP
            // 
            this.labelOpenKeyP.AutoSize = true;
            this.labelOpenKeyP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyP.Location = new System.Drawing.Point(294, 28);
            this.labelOpenKeyP.Name = "labelOpenKeyP";
            this.labelOpenKeyP.Size = new System.Drawing.Size(36, 19);
            this.labelOpenKeyP.TabIndex = 29;
            this.labelOpenKeyP.Text = "P = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Открытый ключ";
            // 
            // buttonPrivateKeyGenerate
            // 
            this.buttonPrivateKeyGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrivateKeyGenerate.Location = new System.Drawing.Point(241, 160);
            this.buttonPrivateKeyGenerate.Name = "buttonPrivateKeyGenerate";
            this.buttonPrivateKeyGenerate.Size = new System.Drawing.Size(257, 35);
            this.buttonPrivateKeyGenerate.TabIndex = 35;
            this.buttonPrivateKeyGenerate.Text = "Генерация закрытого ключа";
            this.buttonPrivateKeyGenerate.UseVisualStyleBackColor = true;
            this.buttonPrivateKeyGenerate.Click += new System.EventHandler(this.buttonPrivateKeyGenerate_Click);
            // 
            // FormSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.buttonPrivateKeyGenerate);
            this.Controls.Add(this.labelOpenKeyYValue);
            this.Controls.Add(this.labelOpenKeyGValue);
            this.Controls.Add(this.labelOpenKeyPValue);
            this.Controls.Add(this.labelOpenKeyY);
            this.Controls.Add(this.labelOpenKeyG);
            this.Controls.Add(this.labelOpenKeyP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrimeCheck);
            this.Controls.Add(this.labelNValue);
            this.Controls.Add(this.labelP2Value);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelPValue);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelNCount);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.richTextData);
            this.Controls.Add(this.buttonPrimeGenerate);
            this.Location = new System.Drawing.Point(300, 200);
            this.Name = "FormSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.FormSender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrimeGenerate;
        public System.Windows.Forms.RichTextBox richTextData;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelNCount;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelPValue;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP2Value;
        private System.Windows.Forms.Label labelNValue;
        private System.Windows.Forms.Button buttonPrimeCheck;
        private System.Windows.Forms.Label labelOpenKeyY;
        private System.Windows.Forms.Label labelOpenKeyG;
        private System.Windows.Forms.Label labelOpenKeyP;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelOpenKeyYValue;
        public System.Windows.Forms.Label labelOpenKeyGValue;
        public System.Windows.Forms.Label labelOpenKeyPValue;
        private System.Windows.Forms.Button buttonPrivateKeyGenerate;
    }
}

