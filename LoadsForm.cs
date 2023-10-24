using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;

namespace Sopromat
{
    public partial class LoadsForm : Form
    {
        Calculation_2sb senderForm;
        public Calculation_2sb SupportsForm { get => senderForm; }
        public LoadsForm(Calculation_2sb senderForm)
        {
            this.senderForm = senderForm;

            InitializeComponent();
        }

        private void LoadsForm_Load(object sender, EventArgs e)
        {

        }

        private void TransverseForceCounter_TextChanged(object sender, EventArgs e)
        {

        }
        List<(TextBox, TextBox)> forces1;
        List<(TextBox, TextBox)> forces2;
        List<(TextBox, TextBox)> forces3;
        List<(TextBox, TextBox, TextBox)> forces4;
        public List<(TextBox, TextBox)> Forces1 { get => forces1; }
        public List<(TextBox, TextBox)> Forces2 { get => forces2; }
        public List<(TextBox, TextBox)> Forces3 { get => forces3; }
        public List<(TextBox, TextBox, TextBox)> Forces4 { get => forces4; }

        private void LoadsValueButton_Click(object sender, EventArgs e)
        {
            BeamPicture picture = new BeamPicture(this);
            //picture.Show();

            int a1, a2, a3, a4;
            int.TryParse(TransverseForceCounter.Text, out a1);
            int.TryParse(LongitunadaleForceCounter.Text, out a2);
            int.TryParse(MomentCounter.Text, out a3);
            int.TryParse(UniformlyDistributedLoadCounter.Text, out a4);

            Form dynamicForm = new Form();
            dynamicForm.AutoSize = true;
            dynamicForm.Text = "Ввод значений нагрузок";
            int yPosition = 20;

            forces1 = new List<(TextBox, TextBox)>();
            for (int i = 0; i < a1; i++)
            {
                Label label = new Label();
                label.Text = "Поперечная сила " + (i + 1) + ":";
                label.Location = new Point(10, yPosition);

                TextBox textBox = new TextBox();
                textBox.Location = new Point(200, yPosition);

                Label label1 = new Label();
                label1.Text = "Координата X: ";
                label1.Location = new Point(350, yPosition);

                TextBox textBox1 = new TextBox();
                textBox1.Location = new Point(540, yPosition);

                dynamicForm.Controls.Add(label);
                dynamicForm.Controls.Add(textBox);
                dynamicForm.Controls.Add(label1);
                dynamicForm.Controls.Add(textBox1);

                yPosition += 30; // Увеличьте Y-координату для следующего элемента
                forces1.Add((textBox, textBox1));
            }
            forces2 = new List<(TextBox, TextBox)>();
            for (int i = 0; i < a2; i++)
            {
                Label label1 = new Label();
                label1.Text = "Продольная сила " + (i + 1) + ":";
                label1.Location = new Point(10, yPosition);

                TextBox textBox1 = new TextBox();
                textBox1.Location = new Point(200, yPosition);

                Label label11 = new Label();
                label11.Text = "Координата X: ";
                label11.Location = new Point(350, yPosition);

                TextBox textBox11 = new TextBox();
                textBox11.Location = new Point(540, yPosition);

                dynamicForm.Controls.Add(label1);
                dynamicForm.Controls.Add(textBox1);
                dynamicForm.Controls.Add(label11);
                dynamicForm.Controls.Add(textBox11);
                yPosition += 30;
                forces2.Add((textBox1, textBox11));
            }
            forces3 = new List<(TextBox, TextBox)>();
            for (int i = 0; i < a3; i++)
            {
                Label label2 = new Label();
                label2.Text = "Момент " + (i + 1) + ":";
                label2.Location = new Point(10, yPosition);

                TextBox textBox2 = new TextBox();
                textBox2.Location = new Point(200, yPosition);

                Label label12 = new Label();
                label12.Text = "Координата X: ";
                label12.Location = new Point(350, yPosition);

                TextBox textBox12 = new TextBox();
                textBox12.Location = new Point(540, yPosition);

                dynamicForm.Controls.Add(label2);
                dynamicForm.Controls.Add(textBox2);
                dynamicForm.Controls.Add(label12);
                dynamicForm.Controls.Add(textBox12);
                yPosition += 30;
                forces3.Add((textBox2, textBox12));
            }
            forces4 = new List<(TextBox, TextBox, TextBox)>();
            for (int i = 0; i < a4; i++)
            {
                Label label3 = new Label();
                label3.Text = $"q{i}: ";
                label3.Location = new Point(10, yPosition);

                TextBox textBox3 = new TextBox();
                textBox3.Location = new Point(200, yPosition);

                Label label31 = new Label();
                label31.Text = "Координата X1: ";
                label31.Location = new Point(350, yPosition);
                TextBox textBox31 = new TextBox();
                textBox31.Location = new Point(540, yPosition);

                yPosition += 30;

                Label label32 = new Label();
                label32.Text = "Координата X2: ";
                label32.Location = new Point(350, yPosition);
                TextBox textBox32 = new TextBox();
                textBox32.Location = new Point(540, yPosition);

                dynamicForm.Controls.Add(label3);
                dynamicForm.Controls.Add(textBox3);
                dynamicForm.Controls.Add(label31);
                dynamicForm.Controls.Add(label32);
                dynamicForm.Controls.Add(textBox31);
                dynamicForm.Controls.Add(textBox32);
                yPosition += 30;

                forces4.Add((textBox3, textBox31, textBox32));
            }


            // Создайте кнопку для завершения ввода и обработки данных
            Button submitButton = new Button();
            submitButton.Text = "Готово";
            submitButton.Location = new Point(270, yPosition);
            submitButton.Click += (sender1, e1) =>
            {
                // Здесь можно получить введенные значения из TextBox и обработать их
                // Закрыть форму dynamicForm, если это необходимо
                picture.Show();
                dynamicForm.Close();
            };

            dynamicForm.Controls.Add(submitButton);

            // Отобразите динамически созданную форму
            dynamicForm.ShowDialog();
        }

    }
}


