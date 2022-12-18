
namespace Elgamal_encryption
{
    partial class FormSecretKey
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
            this.labelNumberGenerate = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumberGenerate
            // 
            this.labelNumberGenerate.AutoSize = true;
            this.labelNumberGenerate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberGenerate.Location = new System.Drawing.Point(23, 9);
            this.labelNumberGenerate.Name = "labelNumberGenerate";
            this.labelNumberGenerate.Size = new System.Drawing.Size(345, 19);
            this.labelNumberGenerate.TabIndex = 1;
            this.labelNumberGenerate.Text = "Секретный ключ сгенерирован успешно";
            this.labelNumberGenerate.Click += new System.EventHandler(this.labelNumberGenerate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(84, 50);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(211, 34);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Ок";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSecretKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 96);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelNumberGenerate);
            this.Name = "FormSecretKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDischargeSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumberGenerate;
        private System.Windows.Forms.Button buttonCancel;
    }
}