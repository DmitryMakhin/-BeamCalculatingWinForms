namespace Sopromat
{
    partial class Calculation_2sb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation_2sb));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.beam_length = new System.Windows.Forms.TextBox();
            this.hingeFixedCoordinate = new System.Windows.Forms.TextBox();
            this.hingeNonFixedCoordinate = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadsFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите длину балки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координата шарнирно-неподвижной опоры:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Координата шарнирно-подвижной опоры:";
            // 
            // beam_length
            // 
            this.beam_length.Location = new System.Drawing.Point(334, 68);
            this.beam_length.Name = "beam_length";
            this.beam_length.Size = new System.Drawing.Size(100, 22);
            this.beam_length.TabIndex = 4;
            // 
            // hingeFixedCoordinate
            // 
            this.hingeFixedCoordinate.Location = new System.Drawing.Point(334, 185);
            this.hingeFixedCoordinate.Name = "hingeFixedCoordinate";
            this.hingeFixedCoordinate.Size = new System.Drawing.Size(100, 22);
            this.hingeFixedCoordinate.TabIndex = 5;
            // 
            // hingeNonFixedCoordinate
            // 
            this.hingeNonFixedCoordinate.Location = new System.Drawing.Point(334, 318);
            this.hingeNonFixedCoordinate.Name = "hingeNonFixedCoordinate";
            this.hingeNonFixedCoordinate.Size = new System.Drawing.Size(100, 22);
            this.hingeNonFixedCoordinate.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 40);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // loadsFormButton
            // 
            this.loadsFormButton.Location = new System.Drawing.Point(623, 295);
            this.loadsFormButton.Name = "loadsFormButton";
            this.loadsFormButton.Size = new System.Drawing.Size(146, 68);
            this.loadsFormButton.TabIndex = 8;
            this.loadsFormButton.Text = "Перейти к нагрузкам";
            this.loadsFormButton.UseVisualStyleBackColor = true;
            this.loadsFormButton.Click += new System.EventHandler(this.loadsFormButton_Click);
            // 
            // Calculation_2sb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadsFormButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hingeNonFixedCoordinate);
            this.Controls.Add(this.hingeFixedCoordinate);
            this.Controls.Add(this.beam_length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculation_2sb";
            this.Text = "Координаты и длина балки";
            this.Load += new System.EventHandler(this.Calculation_2sb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox beam_length;
        private System.Windows.Forms.TextBox hingeFixedCoordinate;
        private System.Windows.Forms.TextBox hingeNonFixedCoordinate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loadsFormButton;
    }
}