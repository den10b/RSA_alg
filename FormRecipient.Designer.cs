﻿
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
            this.richTextDataRecipient = new System.Windows.Forms.RichTextBox();
            this.buttonPrimeGenerate = new System.Windows.Forms.Button();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelPValue = new System.Windows.Forms.Label();
            this.labelP2Value = new System.Windows.Forms.Label();
            this.labelNValue = new System.Windows.Forms.Label();
            this.buttonPublicKeyGenrated = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOpenKeyP = new System.Windows.Forms.Label();
            this.labelOpenKeyG = new System.Windows.Forms.Label();
            this.labelOpenKeyY = new System.Windows.Forms.Label();
            this.labelOpenKeyPValue = new System.Windows.Forms.Label();
            this.labelOpenKeyGValue = new System.Windows.Forms.Label();
            this.labelOpenKeyYValue = new System.Windows.Forms.Label();
            this.buttonSendOpenKey = new System.Windows.Forms.Button();
            this.buttonMessageDecrypt = new System.Windows.Forms.Button();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.labelXValue = new System.Windows.Forms.Label();
            this.labelAValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextDataRecipient
            // 
            this.richTextDataRecipient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextDataRecipient.Location = new System.Drawing.Point(26, 170);
            this.richTextDataRecipient.Name = "richTextDataRecipient";
            this.richTextDataRecipient.Size = new System.Drawing.Size(672, 199);
            this.richTextDataRecipient.TabIndex = 9;
            this.richTextDataRecipient.Text = "";
            // 
            // buttonPrimeGenerate
            // 
            this.buttonPrimeGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeGenerate.Location = new System.Drawing.Point(26, 119);
            this.buttonPrimeGenerate.Name = "buttonPrimeGenerate";
            this.buttonPrimeGenerate.Size = new System.Drawing.Size(200, 35);
            this.buttonPrimeGenerate.TabIndex = 10;
            this.buttonPrimeGenerate.Text = "Генерация простого P";
            this.buttonPrimeGenerate.UseVisualStyleBackColor = true;
            this.buttonPrimeGenerate.Click += new System.EventHandler(this.buttonPrimeGenerate_Click);
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP1.Location = new System.Drawing.Point(22, 25);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(45, 19);
            this.labelP1.TabIndex = 14;
            this.labelP1.Text = "P1 = ";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2.Location = new System.Drawing.Point(22, 54);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(45, 19);
            this.labelP2.TabIndex = 15;
            this.labelP2.Text = "P2 = ";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(22, 82);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(39, 19);
            this.labelN.TabIndex = 16;
            this.labelN.Text = "N = ";
            // 
            // labelPValue
            // 
            this.labelPValue.AutoSize = true;
            this.labelPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPValue.Location = new System.Drawing.Point(56, 25);
            this.labelPValue.Name = "labelPValue";
            this.labelPValue.Size = new System.Drawing.Size(0, 19);
            this.labelPValue.TabIndex = 17;
            // 
            // labelP2Value
            // 
            this.labelP2Value.AutoSize = true;
            this.labelP2Value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2Value.Location = new System.Drawing.Point(56, 54);
            this.labelP2Value.Name = "labelP2Value";
            this.labelP2Value.Size = new System.Drawing.Size(0, 19);
            this.labelP2Value.TabIndex = 18;
            // 
            // labelNValue
            // 
            this.labelNValue.AutoSize = true;
            this.labelNValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNValue.Location = new System.Drawing.Point(56, 82);
            this.labelNValue.Name = "labelNValue";
            this.labelNValue.Size = new System.Drawing.Size(0, 19);
            this.labelNValue.TabIndex = 19;
            // 
            // buttonPublicKeyGenrated
            // 
            this.buttonPublicKeyGenrated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPublicKeyGenrated.Location = new System.Drawing.Point(232, 119);
            this.buttonPublicKeyGenrated.Name = "buttonPublicKeyGenrated";
            this.buttonPublicKeyGenrated.Size = new System.Drawing.Size(180, 35);
            this.buttonPublicKeyGenrated.TabIndex = 20;
            this.buttonPublicKeyGenrated.Text = "Генерация ключей";
            this.buttonPublicKeyGenrated.UseVisualStyleBackColor = true;
            this.buttonPublicKeyGenrated.Click += new System.EventHandler(this.buttonPublicKeyGenrated_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Открытый ключ";
            // 
            // labelOpenKeyP
            // 
            this.labelOpenKeyP.AutoSize = true;
            this.labelOpenKeyP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyP.Location = new System.Drawing.Point(244, 28);
            this.labelOpenKeyP.Name = "labelOpenKeyP";
            this.labelOpenKeyP.Size = new System.Drawing.Size(36, 19);
            this.labelOpenKeyP.TabIndex = 22;
            this.labelOpenKeyP.Text = "P = ";
            // 
            // labelOpenKeyG
            // 
            this.labelOpenKeyG.AutoSize = true;
            this.labelOpenKeyG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyG.Location = new System.Drawing.Point(244, 54);
            this.labelOpenKeyG.Name = "labelOpenKeyG";
            this.labelOpenKeyG.Size = new System.Drawing.Size(40, 19);
            this.labelOpenKeyG.TabIndex = 23;
            this.labelOpenKeyG.Text = "G = ";
            // 
            // labelOpenKeyY
            // 
            this.labelOpenKeyY.AutoSize = true;
            this.labelOpenKeyY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyY.Location = new System.Drawing.Point(244, 82);
            this.labelOpenKeyY.Name = "labelOpenKeyY";
            this.labelOpenKeyY.Size = new System.Drawing.Size(37, 19);
            this.labelOpenKeyY.TabIndex = 24;
            this.labelOpenKeyY.Text = "Y = ";
            // 
            // labelOpenKeyPValue
            // 
            this.labelOpenKeyPValue.AutoSize = true;
            this.labelOpenKeyPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyPValue.Location = new System.Drawing.Point(271, 28);
            this.labelOpenKeyPValue.Name = "labelOpenKeyPValue";
            this.labelOpenKeyPValue.Size = new System.Drawing.Size(58, 19);
            this.labelOpenKeyPValue.TabIndex = 25;
            this.labelOpenKeyPValue.Text = "label2";
            // 
            // labelOpenKeyGValue
            // 
            this.labelOpenKeyGValue.AutoSize = true;
            this.labelOpenKeyGValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyGValue.Location = new System.Drawing.Point(280, 54);
            this.labelOpenKeyGValue.Name = "labelOpenKeyGValue";
            this.labelOpenKeyGValue.Size = new System.Drawing.Size(58, 19);
            this.labelOpenKeyGValue.TabIndex = 26;
            this.labelOpenKeyGValue.Text = "label2";
            // 
            // labelOpenKeyYValue
            // 
            this.labelOpenKeyYValue.AutoSize = true;
            this.labelOpenKeyYValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenKeyYValue.Location = new System.Drawing.Point(271, 82);
            this.labelOpenKeyYValue.Name = "labelOpenKeyYValue";
            this.labelOpenKeyYValue.Size = new System.Drawing.Size(58, 19);
            this.labelOpenKeyYValue.TabIndex = 27;
            this.labelOpenKeyYValue.Text = "label2";
            // 
            // buttonSendOpenKey
            // 
            this.buttonSendOpenKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendOpenKey.Location = new System.Drawing.Point(437, 12);
            this.buttonSendOpenKey.Name = "buttonSendOpenKey";
            this.buttonSendOpenKey.Size = new System.Drawing.Size(261, 35);
            this.buttonSendOpenKey.TabIndex = 28;
            this.buttonSendOpenKey.Text = "Отправить открытый ключ";
            this.buttonSendOpenKey.UseVisualStyleBackColor = true;
            this.buttonSendOpenKey.Click += new System.EventHandler(this.buttonSendOpenKey_Click);
            // 
            // buttonMessageDecrypt
            // 
            this.buttonMessageDecrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMessageDecrypt.Location = new System.Drawing.Point(474, 119);
            this.buttonMessageDecrypt.Name = "buttonMessageDecrypt";
            this.buttonMessageDecrypt.Size = new System.Drawing.Size(210, 35);
            this.buttonMessageDecrypt.TabIndex = 37;
            this.buttonMessageDecrypt.Text = "Дешифровать";
            this.buttonMessageDecrypt.UseVisualStyleBackColor = true;
            this.buttonMessageDecrypt.Click += new System.EventHandler(this.buttonMessageDecrypt_Click);
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRetrieve.Location = new System.Drawing.Point(474, 74);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(210, 35);
            this.buttonRetrieve.TabIndex = 39;
            this.buttonRetrieve.Text = "Получить";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // labelXValue
            // 
            this.labelXValue.AutoSize = true;
            this.labelXValue.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXValue.ForeColor = System.Drawing.SystemColors.Control;
            this.labelXValue.Location = new System.Drawing.Point(113, 12);
            this.labelXValue.Name = "labelXValue";
            this.labelXValue.Size = new System.Drawing.Size(0, 15);
            this.labelXValue.TabIndex = 40;
            // 
            // labelAValue
            // 
            this.labelAValue.AutoSize = true;
            this.labelAValue.Location = new System.Drawing.Point(105, 59);
            this.labelAValue.Name = "labelAValue";
            this.labelAValue.Size = new System.Drawing.Size(35, 13);
            this.labelAValue.TabIndex = 41;
            this.labelAValue.Text = "label2";
            // 
            // FormRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.labelAValue);
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
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.buttonPrimeGenerate);
            this.Controls.Add(this.richTextDataRecipient);
            this.Location = new System.Drawing.Point(1024, 200);
            this.Name = "FormRecipient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox richTextDataRecipient;
        private System.Windows.Forms.Button buttonPrimeGenerate;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelPValue;
        private System.Windows.Forms.Label labelP2Value;
        private System.Windows.Forms.Label labelNValue;
        private System.Windows.Forms.Button buttonPublicKeyGenrated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOpenKeyP;
        private System.Windows.Forms.Label labelOpenKeyG;
        private System.Windows.Forms.Label labelOpenKeyY;
        private System.Windows.Forms.Button buttonSendOpenKey;
        public System.Windows.Forms.Label labelOpenKeyPValue;
        public System.Windows.Forms.Label labelOpenKeyGValue;
        public System.Windows.Forms.Label labelOpenKeyYValue;
        private System.Windows.Forms.Button buttonMessageDecrypt;
        private System.Windows.Forms.Button buttonRetrieve;
        public System.Windows.Forms.Label labelXValue;
        private System.Windows.Forms.Label labelAValue;
    }
}