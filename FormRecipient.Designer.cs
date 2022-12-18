
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
            this.richTextData = new System.Windows.Forms.RichTextBox();
            this.buttonPrimeGenerate = new System.Windows.Forms.Button();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelPValue = new System.Windows.Forms.Label();
            this.labelP2Value = new System.Windows.Forms.Label();
            this.labelNValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextData
            // 
            this.richTextData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextData.Location = new System.Drawing.Point(26, 170);
            this.richTextData.Name = "richTextData";
            this.richTextData.Size = new System.Drawing.Size(672, 199);
            this.richTextData.TabIndex = 9;
            this.richTextData.Text = "";
            // 
            // buttonPrimeGenerate
            // 
            this.buttonPrimeGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimeGenerate.Location = new System.Drawing.Point(26, 119);
            this.buttonPrimeGenerate.Name = "buttonPrimeGenerate";
            this.buttonPrimeGenerate.Size = new System.Drawing.Size(210, 35);
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
            // FormRecipient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.labelNValue);
            this.Controls.Add(this.labelP2Value);
            this.Controls.Add(this.labelPValue);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.buttonPrimeGenerate);
            this.Controls.Add(this.richTextData);
            this.Location = new System.Drawing.Point(1024, 200);
            this.Name = "FormRecipient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Recipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox richTextData;
        private System.Windows.Forms.Button buttonPrimeGenerate;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelPValue;
        private System.Windows.Forms.Label labelP2Value;
        private System.Windows.Forms.Label labelNValue;
    }
}