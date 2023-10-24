namespace Sopromat
{
    partial class LoadsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TransverseForceCounter = new System.Windows.Forms.TextBox();
            this.LongitunadaleForceCounter = new System.Windows.Forms.TextBox();
            this.MomentCounter = new System.Windows.Forms.TextBox();
            this.LoadsValueButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UniformlyDistributedLoadCounter = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество поперечных сил в балке: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите количество продольных сил в балке: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите количество моментов в балке: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(210, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(210, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // TransverseForceCounter
            // 
            this.TransverseForceCounter.Location = new System.Drawing.Point(392, 60);
            this.TransverseForceCounter.Name = "TransverseForceCounter";
            this.TransverseForceCounter.Size = new System.Drawing.Size(100, 22);
            this.TransverseForceCounter.TabIndex = 6;
            this.TransverseForceCounter.TextChanged += new System.EventHandler(this.TransverseForceCounter_TextChanged);
            // 
            // LongitunadaleForceCounter
            // 
            this.LongitunadaleForceCounter.Location = new System.Drawing.Point(392, 142);
            this.LongitunadaleForceCounter.Name = "LongitunadaleForceCounter";
            this.LongitunadaleForceCounter.Size = new System.Drawing.Size(100, 22);
            this.LongitunadaleForceCounter.TabIndex = 7;
            // 
            // MomentCounter
            // 
            this.MomentCounter.Location = new System.Drawing.Point(392, 231);
            this.MomentCounter.Name = "MomentCounter";
            this.MomentCounter.Size = new System.Drawing.Size(100, 22);
            this.MomentCounter.TabIndex = 8;
            // 
            // LoadsValueButton
            // 
            this.LoadsValueButton.Location = new System.Drawing.Point(589, 58);
            this.LoadsValueButton.Name = "LoadsValueButton";
            this.LoadsValueButton.Size = new System.Drawing.Size(186, 71);
            this.LoadsValueButton.TabIndex = 9;
            this.LoadsValueButton.Text = "Перейти к вводу значений нагрузок";
            this.LoadsValueButton.UseVisualStyleBackColor = true;
            this.LoadsValueButton.Click += new System.EventHandler(this.LoadsValueButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите количество равномерно-распределенных нагрузок в балке:";
            // 
            // UniformlyDistributedLoadCounter
            // 
            this.UniformlyDistributedLoadCounter.Location = new System.Drawing.Point(580, 327);
            this.UniformlyDistributedLoadCounter.Name = "UniformlyDistributedLoadCounter";
            this.UniformlyDistributedLoadCounter.Size = new System.Drawing.Size(100, 22);
            this.UniformlyDistributedLoadCounter.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(210, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 54);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // LoadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.UniformlyDistributedLoadCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoadsValueButton);
            this.Controls.Add(this.MomentCounter);
            this.Controls.Add(this.LongitunadaleForceCounter);
            this.Controls.Add(this.TransverseForceCounter);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoadsForm";
            this.Text = "LoadsForm";
            this.Load += new System.EventHandler(this.LoadsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TransverseForceCounter;
        private System.Windows.Forms.TextBox LongitunadaleForceCounter;
        private System.Windows.Forms.TextBox MomentCounter;
        private System.Windows.Forms.Button LoadsValueButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UniformlyDistributedLoadCounter;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}