
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
            this.buttonPrimelGenerate = new System.Windows.Forms.Button();
            this.richTextData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonPrimelGenerate
            // 
            this.buttonPrimelGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrimelGenerate.Location = new System.Drawing.Point(12, 12);
            this.buttonPrimelGenerate.Name = "buttonPrimelGenerate";
            this.buttonPrimelGenerate.Size = new System.Drawing.Size(210, 35);
            this.buttonPrimelGenerate.TabIndex = 0;
            this.buttonPrimelGenerate.Text = "Генерация простого P";
            this.buttonPrimelGenerate.UseVisualStyleBackColor = true;
            this.buttonPrimelGenerate.Click += new System.EventHandler(this.buttonPrimelGenerate_Click);
            // 
            // richTextData
            // 
            this.richTextData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextData.Location = new System.Drawing.Point(12, 53);
            this.richTextData.Name = "richTextData";
            this.richTextData.Size = new System.Drawing.Size(686, 385);
            this.richTextData.TabIndex = 1;
            this.richTextData.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.richTextData);
            this.Controls.Add(this.buttonPrimelGenerate);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrimelGenerate;
        public System.Windows.Forms.RichTextBox richTextData;
    }
}

