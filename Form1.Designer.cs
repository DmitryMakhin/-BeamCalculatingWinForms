namespace Sopromat
{
    partial class Main_Window
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
            this.twoSupport_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // twoSupport_Button
            // 
            this.twoSupport_Button.Location = new System.Drawing.Point(282, 178);
            this.twoSupport_Button.Name = "twoSupport_Button";
            this.twoSupport_Button.Size = new System.Drawing.Size(213, 47);
            this.twoSupport_Button.TabIndex = 0;
            this.twoSupport_Button.Text = "Двухопорная балка";
            this.twoSupport_Button.UseVisualStyleBackColor = true;
            this.twoSupport_Button.Click += new System.EventHandler(this.twoSupport_Button_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.twoSupport_Button);
            this.Name = "Main_Window";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button twoSupport_Button;
    }
}

