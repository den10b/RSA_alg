
namespace Elgamal_encryption
{
    partial class Form1
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
            this.buttonPrimelGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrimelGenerate
            // 
            this.buttonPrimelGenerate.Location = new System.Drawing.Point(-1, 1);
            this.buttonPrimelGenerate.Name = "buttonPrimelGenerate";
            this.buttonPrimelGenerate.Size = new System.Drawing.Size(155, 35);
            this.buttonPrimelGenerate.TabIndex = 0;
            this.buttonPrimelGenerate.Text = "Генерация простого P";
            this.buttonPrimelGenerate.UseVisualStyleBackColor = true;
            this.buttonPrimelGenerate.Click += new System.EventHandler(this.buttonPrimelGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.buttonPrimelGenerate);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrimelGenerate;
    }
}

