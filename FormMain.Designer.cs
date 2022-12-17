
namespace Elgamal_encryption
{
    partial class FormMain
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
            this.SuspendLayout();
            // 
            // buttonPrimeGenerate
            // 
            this.buttonPrimeGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeGenerate.Location = new System.Drawing.Point(26, 198);
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
            this.richTextData.Location = new System.Drawing.Point(26, 239);
            this.richTextData.Name = "richTextData";
            this.richTextData.Size = new System.Drawing.Size(672, 199);
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
            this.buttonPrimeCheck.Location = new System.Drawing.Point(242, 198);
            this.buttonPrimeCheck.Name = "buttonPrimeCheck";
            this.buttonPrimeCheck.Size = new System.Drawing.Size(210, 35);
            this.buttonPrimeCheck.TabIndex = 9;
            this.buttonPrimeCheck.Text = "Проверка простоты";
            this.buttonPrimeCheck.UseVisualStyleBackColor = true;
            this.buttonPrimeCheck.Click += new System.EventHandler(this.buttonPrimeCheck_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
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
            this.Name = "FormMain";
            this.Text = "Form1";
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
    }
}

