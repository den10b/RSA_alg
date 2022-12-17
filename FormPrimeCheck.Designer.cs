
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
            this.checkBoxFerma = new System.Windows.Forms.CheckBox();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxNumberCheck = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNumberCheck
            // 
            this.labelNumberCheck.AutoSize = true;
            this.labelNumberCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberCheck.Location = new System.Drawing.Point(179, 9);
            this.labelNumberCheck.Name = "labelNumberCheck";
            this.labelNumberCheck.Size = new System.Drawing.Size(174, 19);
            this.labelNumberCheck.TabIndex = 2;
            this.labelNumberCheck.Text = "Проверяемое число";
            // 
            // checkBoxDivisTest
            // 
            this.checkBoxDivisTest.AutoSize = true;
            this.checkBoxDivisTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDivisTest.Location = new System.Drawing.Point(12, 102);
            this.checkBoxDivisTest.Name = "checkBoxDivisTest";
            this.checkBoxDivisTest.Size = new System.Drawing.Size(212, 23);
            this.checkBoxDivisTest.TabIndex = 4;
            this.checkBoxDivisTest.Text = "Тест пробных делений";
            this.checkBoxDivisTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxFerma
            // 
            this.checkBoxFerma.AutoSize = true;
            this.checkBoxFerma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFerma.Location = new System.Drawing.Point(356, 102);
            this.checkBoxFerma.Name = "checkBoxFerma";
            this.checkBoxFerma.Size = new System.Drawing.Size(124, 23);
            this.checkBoxFerma.TabIndex = 5;
            this.checkBoxFerma.Text = "Тест Ферма";
            this.checkBoxFerma.UseVisualStyleBackColor = true;
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
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(305, 222);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(210, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxNumberCheck
            // 
            this.comboBoxNumberCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumberCheck.FormattingEnabled = true;
            this.comboBoxNumberCheck.Items.AddRange(new object[] {
            "123",
            "234"});
            this.comboBoxNumberCheck.Location = new System.Drawing.Point(204, 31);
            this.comboBoxNumberCheck.Name = "comboBoxNumberCheck";
            this.comboBoxNumberCheck.Size = new System.Drawing.Size(121, 27);
            this.comboBoxNumberCheck.TabIndex = 8;
            // 
            // FormPrimeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 269);
            this.Controls.Add(this.comboBoxNumberCheck);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.checkBoxFerma);
            this.Controls.Add(this.checkBoxDivisTest);
            this.Controls.Add(this.labelNumberCheck);
            this.Name = "FormPrimeCheck";
            this.Text = "FormPrimeCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberCheck;
        private System.Windows.Forms.CheckBox checkBoxDivisTest;
        private System.Windows.Forms.CheckBox checkBoxFerma;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxNumberCheck;
    }
}