
namespace Elgamal_encryption
{
    partial class FormRecipient
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
            this.labelXValue = new System.Windows.Forms.Label();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.buttonMessageDecrypt = new System.Windows.Forms.Button();
            this.buttonSendOpenKey = new System.Windows.Forms.Button();
            this.labelOpenKeyYValue = new System.Windows.Forms.Label();
            this.labelOpenKeyGValue = new System.Windows.Forms.Label();
            this.labelOpenKeyPValue = new System.Windows.Forms.Label();
            this.labelOpenKeyY = new System.Windows.Forms.Label();
            this.labelOpenKeyG = new System.Windows.Forms.Label();
            this.labelOpenKeyP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPublicKeyGenrated = new System.Windows.Forms.Button();
            this.labelNValue = new System.Windows.Forms.Label();
            this.labelP2Value = new System.Windows.Forms.Label();
            this.labelPValue = new System.Windows.Forms.Label();
            this.buttonPrimeGenerate = new System.Windows.Forms.Button();
            this.richTextDataRecipient = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelXValue
            // 
            this.labelXValue.AutoSize = true;
            this.labelXValue.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXValue.ForeColor = System.Drawing.SystemColors.Control;
            this.labelXValue.Location = new System.Drawing.Point(292, 88);
            this.labelXValue.Name = "labelXValue";
            this.labelXValue.Size = new System.Drawing.Size(0, 15);
            this.labelXValue.TabIndex = 61;
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRetrieve.Location = new System.Drawing.Point(29, 402);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(210, 35);
            this.buttonRetrieve.TabIndex = 60;
            this.buttonRetrieve.Text = "Получить";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click_1);
            // 
            // buttonMessageDecrypt
            // 
            this.buttonMessageDecrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMessageDecrypt.Location = new System.Drawing.Point(305, 402);
            this.buttonMessageDecrypt.Name = "buttonMessageDecrypt";
            this.buttonMessageDecrypt.Size = new System.Drawing.Size(210, 35);
            this.buttonMessageDecrypt.TabIndex = 59;
            this.buttonMessageDecrypt.Text = "Дешифровать";
            this.buttonMessageDecrypt.UseVisualStyleBackColor = true;
            this.buttonMessageDecrypt.Click += new System.EventHandler(this.buttonMessageDecrypt_Click_1);
            // 
            // buttonSendOpenKey
            // 
            this.buttonSendOpenKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendOpenKey.Location = new System.Drawing.Point(254, 110);
            this.buttonSendOpenKey.Name = "buttonSendOpenKey";
            this.buttonSendOpenKey.Size = new System.Drawing.Size(261, 35);
            this.buttonSendOpenKey.TabIndex = 58;
            this.buttonSendOpenKey.Text = "Отправить открытый ключ";
            this.buttonSendOpenKey.UseVisualStyleBackColor = true;
            this.buttonSendOpenKey.Click += new System.EventHandler(this.buttonSendOpenKey_Click_1);
            // 
            // labelOpenKeyYValue
            // 
            this.labelOpenKeyYValue.AutoSize = true;
            this.labelOpenKeyYValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyYValue.Location = new System.Drawing.Point(58, 85);
            this.labelOpenKeyYValue.Name = "labelOpenKeyYValue";
            this.labelOpenKeyYValue.Size = new System.Drawing.Size(0, 19);
            this.labelOpenKeyYValue.TabIndex = 57;
            // 
            // labelOpenKeyGValue
            // 
            this.labelOpenKeyGValue.AutoSize = true;
            this.labelOpenKeyGValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyGValue.Location = new System.Drawing.Point(67, 57);
            this.labelOpenKeyGValue.Name = "labelOpenKeyGValue";
            this.labelOpenKeyGValue.Size = new System.Drawing.Size(0, 19);
            this.labelOpenKeyGValue.TabIndex = 56;
            // 
            // labelOpenKeyPValue
            // 
            this.labelOpenKeyPValue.AutoSize = true;
            this.labelOpenKeyPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyPValue.Location = new System.Drawing.Point(58, 31);
            this.labelOpenKeyPValue.Name = "labelOpenKeyPValue";
            this.labelOpenKeyPValue.Size = new System.Drawing.Size(0, 19);
            this.labelOpenKeyPValue.TabIndex = 55;
            // 
            // labelOpenKeyY
            // 
            this.labelOpenKeyY.AutoSize = true;
            this.labelOpenKeyY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyY.Location = new System.Drawing.Point(31, 85);
            this.labelOpenKeyY.Name = "labelOpenKeyY";
            this.labelOpenKeyY.Size = new System.Drawing.Size(37, 19);
            this.labelOpenKeyY.TabIndex = 54;
            this.labelOpenKeyY.Text = "Y = ";
            // 
            // labelOpenKeyG
            // 
            this.labelOpenKeyG.AutoSize = true;
            this.labelOpenKeyG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyG.Location = new System.Drawing.Point(31, 57);
            this.labelOpenKeyG.Name = "labelOpenKeyG";
            this.labelOpenKeyG.Size = new System.Drawing.Size(40, 19);
            this.labelOpenKeyG.TabIndex = 53;
            this.labelOpenKeyG.Text = "G = ";
            // 
            // labelOpenKeyP
            // 
            this.labelOpenKeyP.AutoSize = true;
            this.labelOpenKeyP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyP.Location = new System.Drawing.Point(31, 31);
            this.labelOpenKeyP.Name = "labelOpenKeyP";
            this.labelOpenKeyP.Size = new System.Drawing.Size(36, 19);
            this.labelOpenKeyP.TabIndex = 52;
            this.labelOpenKeyP.Text = "P = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Открытый ключ";
            // 
            // buttonPublicKeyGenrated
            // 
            this.buttonPublicKeyGenrated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPublicKeyGenrated.Location = new System.Drawing.Point(317, 17);
            this.buttonPublicKeyGenrated.Name = "buttonPublicKeyGenrated";
            this.buttonPublicKeyGenrated.Size = new System.Drawing.Size(180, 35);
            this.buttonPublicKeyGenrated.TabIndex = 50;
            this.buttonPublicKeyGenrated.Text = "Генерация ключей";
            this.buttonPublicKeyGenrated.UseVisualStyleBackColor = true;
            this.buttonPublicKeyGenrated.Click += new System.EventHandler(this.buttonPublicKeyGenrated_Click_1);
            // 
            // labelNValue
            // 
            this.labelNValue.AutoSize = true;
            this.labelNValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNValue.Location = new System.Drawing.Point(61, 82);
            this.labelNValue.Name = "labelNValue";
            this.labelNValue.Size = new System.Drawing.Size(0, 19);
            this.labelNValue.TabIndex = 49;
            // 
            // labelP2Value
            // 
            this.labelP2Value.AutoSize = true;
            this.labelP2Value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2Value.Location = new System.Drawing.Point(61, 54);
            this.labelP2Value.Name = "labelP2Value";
            this.labelP2Value.Size = new System.Drawing.Size(0, 19);
            this.labelP2Value.TabIndex = 48;
            // 
            // labelPValue
            // 
            this.labelPValue.AutoSize = true;
            this.labelPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPValue.Location = new System.Drawing.Point(61, 25);
            this.labelPValue.Name = "labelPValue";
            this.labelPValue.Size = new System.Drawing.Size(0, 19);
            this.labelPValue.TabIndex = 47;
            // 
            // buttonPrimeGenerate
            // 
            this.buttonPrimeGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeGenerate.Location = new System.Drawing.Point(29, 110);
            this.buttonPrimeGenerate.Name = "buttonPrimeGenerate";
            this.buttonPrimeGenerate.Size = new System.Drawing.Size(200, 35);
            this.buttonPrimeGenerate.TabIndex = 43;
            this.buttonPrimeGenerate.Text = "Генерация простого P";
            this.buttonPrimeGenerate.UseVisualStyleBackColor = true;
            this.buttonPrimeGenerate.Click += new System.EventHandler(this.buttonPrimeGenerate_Click_1);
            // 
            // richTextDataRecipient
            // 
            this.richTextDataRecipient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextDataRecipient.Location = new System.Drawing.Point(29, 151);
            this.richTextDataRecipient.Name = "richTextDataRecipient";
            this.richTextDataRecipient.Size = new System.Drawing.Size(486, 245);
            this.richTextDataRecipient.TabIndex = 42;
            this.richTextDataRecipient.Text = "";
            // 
            // FormRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 449);
            this.Controls.Add(this.labelXValue);
            this.Controls.Add(this.buttonRetrieve);
            this.Controls.Add(this.buttonMessageDecrypt);
            this.Controls.Add(this.buttonSendOpenKey);
            this.Controls.Add(this.labelOpenKeyYValue);
            this.Controls.Add(this.labelOpenKeyGValue);
            this.Controls.Add(this.labelOpenKeyPValue);
            this.Controls.Add(this.labelOpenKeyY);
            this.Controls.Add(this.labelOpenKeyG);
            this.Controls.Add(this.labelOpenKeyP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPublicKeyGenrated);
            this.Controls.Add(this.labelNValue);
            this.Controls.Add(this.labelP2Value);
            this.Controls.Add(this.labelPValue);
            this.Controls.Add(this.buttonPrimeGenerate);
            this.Controls.Add(this.richTextDataRecipient);
            this.Location = new System.Drawing.Point(905, 150);
            this.Name = "FormRecipient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelXValue;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Button buttonMessageDecrypt;
        private System.Windows.Forms.Button buttonSendOpenKey;
        public System.Windows.Forms.Label labelOpenKeyYValue;
        public System.Windows.Forms.Label labelOpenKeyGValue;
        public System.Windows.Forms.Label labelOpenKeyPValue;
        private System.Windows.Forms.Label labelOpenKeyY;
        private System.Windows.Forms.Label labelOpenKeyG;
        private System.Windows.Forms.Label labelOpenKeyP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPublicKeyGenrated;
        private System.Windows.Forms.Label labelNValue;
        private System.Windows.Forms.Label labelP2Value;
        private System.Windows.Forms.Label labelPValue;
        private System.Windows.Forms.Button buttonPrimeGenerate;
        public System.Windows.Forms.RichTextBox richTextDataRecipient;
    }
}