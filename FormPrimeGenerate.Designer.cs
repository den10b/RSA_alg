
namespace Elgamal_encryption
{
    partial class FormPrimeGenerate
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
            this.buttonPrimeCheck = new System.Windows.Forms.Button();
            this.labelP2Value = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelPValue = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelNCount = new System.Windows.Forms.Label();
            this.buttonPrimeGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrimeCheck
            // 
            this.buttonPrimeCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeCheck.Location = new System.Drawing.Point(16, 115);
            this.buttonPrimeCheck.Name = "buttonPrimeCheck";
            this.buttonPrimeCheck.Size = new System.Drawing.Size(231, 35);
            this.buttonPrimeCheck.TabIndex = 18;
            this.buttonPrimeCheck.Text = "Проверка простоты";
            this.buttonPrimeCheck.UseVisualStyleBackColor = true;
            this.buttonPrimeCheck.Click += new System.EventHandler(this.buttonPrimeCheck_Click);
            // 
            // labelP2Value
            // 
            this.labelP2Value.AutoSize = true;
            this.labelP2Value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2Value.Location = new System.Drawing.Point(45, 42);
            this.labelP2Value.Name = "labelP2Value";
            this.labelP2Value.Size = new System.Drawing.Size(0, 19);
            this.labelP2Value.TabIndex = 16;
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP2.Location = new System.Drawing.Point(12, 42);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(45, 19);
            this.labelP2.TabIndex = 15;
            this.labelP2.Text = "P2 = ";
            // 
            // labelPValue
            // 
            this.labelPValue.AutoSize = true;
            this.labelPValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPValue.Location = new System.Drawing.Point(45, 13);
            this.labelPValue.Name = "labelPValue";
            this.labelPValue.Size = new System.Drawing.Size(0, 19);
            this.labelPValue.TabIndex = 14;
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP1.Location = new System.Drawing.Point(12, 13);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(45, 19);
            this.labelP1.TabIndex = 13;
            this.labelP1.Text = "P1 = ";
            // 
            // labelNCount
            // 
            this.labelNCount.AutoSize = true;
            this.labelNCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNCount.Location = new System.Drawing.Point(45, 13);
            this.labelNCount.Name = "labelNCount";
            this.labelNCount.Size = new System.Drawing.Size(0, 19);
            this.labelNCount.TabIndex = 12;
            // 
            // buttonPrimeGenerate
            // 
            this.buttonPrimeGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeGenerate.Location = new System.Drawing.Point(16, 74);
            this.buttonPrimeGenerate.Name = "buttonPrimeGenerate";
            this.buttonPrimeGenerate.Size = new System.Drawing.Size(231, 35);
            this.buttonPrimeGenerate.TabIndex = 10;
            this.buttonPrimeGenerate.Text = "Генерация простого P";
            this.buttonPrimeGenerate.UseVisualStyleBackColor = true;
            this.buttonPrimeGenerate.Click += new System.EventHandler(this.buttonPrimeGenerate_Click);
            // 
            // FormPrimeGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 163);
            this.Controls.Add(this.buttonPrimeCheck);
            this.Controls.Add(this.labelP2Value);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelPValue);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelNCount);
            this.Controls.Add(this.buttonPrimeGenerate);
            this.Location = new System.Drawing.Point(625, 650);
            this.Name = "FormPrimeGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PrimeNumberGenerate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrimeCheck;
        private System.Windows.Forms.Label labelP2Value;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelPValue;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelNCount;
        private System.Windows.Forms.Button buttonPrimeGenerate;
    }
}