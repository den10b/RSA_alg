
namespace Elgamal_encryption
{
    partial class FormPrimeCheck
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
            this.labelNumberCheck = new System.Windows.Forms.Label();
            this.checkBoxDivisTest = new System.Windows.Forms.CheckBox();
            this.checkBoxAKS = new System.Windows.Forms.CheckBox();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxNumberCheck = new System.Windows.Forms.ComboBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelNumberCheck
            // 
            this.labelNumberCheck.AutoSize = true;
            this.labelNumberCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberCheck.Location = new System.Drawing.Point(169, 9);
            this.labelNumberCheck.Name = "labelNumberCheck";
            this.labelNumberCheck.Size = new System.Drawing.Size(174, 19);
            this.labelNumberCheck.TabIndex = 2;
            this.labelNumberCheck.Text = "Проверяемое число";
            // 
            // checkBoxDivisTest
            // 
            this.checkBoxDivisTest.AutoSize = true;
            this.checkBoxDivisTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDivisTest.Location = new System.Drawing.Point(12, 73);
            this.checkBoxDivisTest.Name = "checkBoxDivisTest";
            this.checkBoxDivisTest.Size = new System.Drawing.Size(212, 23);
            this.checkBoxDivisTest.TabIndex = 4;
            this.checkBoxDivisTest.Text = "Тест пробных делений";
            this.checkBoxDivisTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxAKS
            // 
            this.checkBoxAKS.AutoSize = true;
            this.checkBoxAKS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAKS.Location = new System.Drawing.Point(362, 73);
            this.checkBoxAKS.Name = "checkBoxAKS";
            this.checkBoxAKS.Size = new System.Drawing.Size(97, 23);
            this.checkBoxAKS.TabIndex = 5;
            this.checkBoxAKS.Text = "Тест AKS";
            this.checkBoxAKS.UseVisualStyleBackColor = true;
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartTest.Location = new System.Drawing.Point(12, 222);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(210, 35);
            this.buttonStartTest.TabIndex = 6;
            this.buttonStartTest.Text = "Начать проверку";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(312, 222);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(210, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxNumberCheck
            // 
            this.comboBoxNumberCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumberCheck.FormattingEnabled = true;
            this.comboBoxNumberCheck.Location = new System.Drawing.Point(173, 31);
            this.comboBoxNumberCheck.Name = "comboBoxNumberCheck";
            this.comboBoxNumberCheck.Size = new System.Drawing.Size(170, 27);
            this.comboBoxNumberCheck.TabIndex = 8;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 102);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(510, 114);
            this.richTextBoxResult.TabIndex = 9;
            this.richTextBoxResult.Text = "";
            // 
            // FormPrimeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 269);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.comboBoxNumberCheck);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.checkBoxAKS);
            this.Controls.Add(this.checkBoxDivisTest);
            this.Controls.Add(this.labelNumberCheck);
            this.Location = new System.Drawing.Point(905, 650);
            this.Name = "FormPrimeCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPrimeCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberCheck;
        private System.Windows.Forms.CheckBox checkBoxDivisTest;
        private System.Windows.Forms.CheckBox checkBoxAKS;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.ComboBox comboBoxNumberCheck;
        public System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}