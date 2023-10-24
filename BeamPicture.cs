using BeamTest.Forces;
using BeamTest.Supports;
using ISopromat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sopromat
{
    public partial class BeamPicture : Form
    {
        LoadsForm loadsForm;
        static int length;
        static Beam beam;
        public BeamPicture(LoadsForm senderForm)
        {
            loadsForm = senderForm;
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.BackColor = Color.LightGray;
            panel1.Padding = new Padding(5);
            Graphics g = e.Graphics;
            int.TryParse(loadsForm.SupportsForm.Beam_Length.Text, out length);
            DrawSimpleBeam(900, g);
            beam = new Beam(length);
            int xCoordS1;
            int.TryParse(loadsForm.SupportsForm.HingeFixedCoordinate.Text, out xCoordS1);
            InsertSupport1AtX(xCoordS1);
            beam.Supports.Add(new HingeFixedSupport(xCoordS1));
            int xCoordS2;
            int.TryParse(loadsForm.SupportsForm.HingeNonFixedCoordinate.Text, out xCoordS2);
            InsertSupport2AtX(xCoordS2);
            beam.Supports.Add(new HingeNonFixedSupport(xCoordS2));
            foreach (var item in loadsForm.Forces1)
            {
                int xCoordF1;
                int.TryParse(item.Item2.Text, out xCoordF1);
                int forceValue1;
                int.TryParse(item.Item1.Text, out forceValue1);
                InsertForce1AtX(xCoordF1, forceValue1);
                beam.Forces.Add(new TransverseForce(forceValue1, xCoordF1));
            }
            foreach (var item in loadsForm.Forces2)
            {
                int xCoordF2;
                int.TryParse(item.Item2.Text, out xCoordF2);
                int forceValue2;
                int.TryParse(item.Item1.Text, out forceValue2);
                InsertForce2AtX(xCoordF2, forceValue2);
                beam.Forces.Add(new LongitunadaleForce(forceValue2, xCoordF2));
            }
            foreach (var item in loadsForm.Forces3)
            {
                int xCoordF3;
                int.TryParse(item.Item2.Text, out xCoordF3);
                int forceValue3;
                int.TryParse(item.Item1.Text, out forceValue3);
                InsertMomentAtX(xCoordF3, forceValue3);
                beam.Forces.Add(new MomentForce(forceValue3, xCoordF3));
            }
            foreach (var item in loadsForm.Forces4)
            {
                int xStart;
                int.TryParse(item.Item2.Text, out xStart);
                int xEnd;
                int.TryParse(item.Item3.Text, out xEnd);
                int forceValue4;
                int.TryParse(item.Item1.Text, out forceValue4);
                InsertUniformlyDistributedLoad(xStart, xEnd, forceValue4, g);
                beam.Forces.Add(new UniformlyDistributedLoad(forceValue4, xStart, xEnd));
            }

            beam.SplitUniformDistributedLoad(beam);

            IEqualityComparer<IForce> comparer = new ItemComparer();
            beam.Forces = beam.Forces.Distinct(comparer).ToList();
            beam.ChangeSupportsToForces(beam);
            beam.WriteMomentEquation(beam);
            double x = beam.Length;
        }
        public void DrawSimpleBeam(int length, Graphics g)
        {
            g.DrawLine(new Pen(Color.Brown, 2), new Point(pictureBox1.Width / 2 - length / 2, pictureBox1.Height / 4), new Point(pictureBox1.Width / 2 + length / 2, pictureBox1.Height / 4));
        }
        private void InsertSupport1AtX(int xCoordinate)
        {
            // Загрузите изображение опоры из ресурсов проекта
            // Создайте новое изображение для PictureBox, если оно не существует
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            // Загрузите изображение опоры из файла
            Image supportImage = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Supports\\Шарнирно-неподвижная_опора1.png");


            // Разместите изображение опоры на PictureBox в заданных координатах X
            int yCoordinate = pictureBox1.Height / 4 - supportImage.Height / 4 + 8; // Высота опоры центрирована по вертикали

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900 - 20;
                float xCoordD = xCoordinate;
                float lengthD = length;
                float t1 = (xCoordD / lengthD) * 900 - 20;
                float t2 = pictureBox1.Width / 2 - 450;
                g.DrawImage(supportImage, t2 + t1, yCoordinate);
            }

            // Обновите PictureBox, чтобы отобразить изменения
            pictureBox1.Invalidate();
        }
        private void InsertSupport2AtX(int xCoordinate)
        {
            // Загрузите изображение опоры из ресурсов проекта
            // Создайте новое изображение для PictureBox, если оно не существует
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            // Загрузите изображение опоры из файла
            Image supportImage = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Supports\\Шарнирно-подвижная_опора1.png");


            // Разместите изображение опоры на PictureBox в заданных координатах X
            int yCoordinate = pictureBox1.Height / 4 - supportImage.Height / 4 + 8; // Высота опоры центрирована по вертикали

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900 - 20;
                float xCoordD = xCoordinate;
                float lengthD = length;
                float t1 = (xCoordD / lengthD) * 900 - 20;
                float t2 = pictureBox1.Width / 2 - 450;
                g.DrawImage(supportImage, t2 + t1, yCoordinate);
            }

            // Обновите PictureBox, чтобы отобразить изменения
            pictureBox1.Invalidate();
        }
        private void InsertForce1AtX(int xCoordinate, int force)
        {
            // Загрузите изображение опоры из ресурсов проекта
            // Создайте новое изображение для PictureBox, если оно не существует
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            // Загрузите изображение опоры из файла

            bool orientationDown = (force < 0);

            switch (orientationDown)
            {
                case true:
                    Image supportImage = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Loads\\Поперечная_Нагрузка_Вниз.png");


                    // Разместите изображение опоры на PictureBox в заданных координатах X
                    int yCoordinate = pictureBox1.Height / 4 - supportImage.Height / 4 - 30; // Высота опоры центрирована по вертикали

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900 - 20;
                        float xCoordD = xCoordinate;
                        float lengthD = length;
                        float t1 = (xCoordD / lengthD) * 900 - 11;
                        float t2 = pictureBox1.Width / 2 - 450;
                        g.DrawImage(supportImage, t2 + t1, yCoordinate);
                    }

                    // Обновите PictureBox, чтобы отобразить изменения
                    pictureBox1.Invalidate();
                    break;
                case false:
                    Image supportImage1 = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Loads\\Поперечная_Нагрузка_Вверх.png");


                    // Разместите изображение опоры на PictureBox в заданных координатах X
                    int yCoordinate1 = pictureBox1.Height / 4 - supportImage1.Height / 4 + 10; // Высота опоры центрирована по вертикали

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900 - 20;
                        float xCoordD = xCoordinate;
                        float lengthD = length;
                        float t1 = (xCoordD / lengthD) * 900 - 11;
                        float t2 = pictureBox1.Width / 2 - 450;
                        g.DrawImage(supportImage1, t2 + t1, yCoordinate1);
                    }

                    // Обновите PictureBox, чтобы отобразить изменения
                    pictureBox1.Invalidate();
                    break;
            }
        }
        private void InsertForce2AtX(int xCoordinate, int force)
        {
            // Загрузите изображение опоры из ресурсов проекта
            // Создайте новое изображение для PictureBox, если оно не существует
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            // Загрузите изображение опоры из файла

            bool orientationRight = (force > 0);

            switch (orientationRight)
            {
                case true:
                    Image supportImage = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Loads\\Продольная_Нагрузка_Вправо.png");


                    // Разместите изображение опоры на PictureBox в заданных координатах X
                    int yCoordinate = pictureBox1.Height / 4 - supportImage.Height / 4; // Высота опоры центрирована по вертикали

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900;
                        float xCoordD = xCoordinate;
                        float lengthD = length;
                        float t1 = (xCoordD / lengthD) * 900 - 11;
                        float t2 = pictureBox1.Width / 2 - 450;
                        g.DrawImage(supportImage, t2 + t1, yCoordinate);
                    }

                    // Обновите PictureBox, чтобы отобразить изменения
                    pictureBox1.Invalidate();
                    break;
                case false:
                    Image supportImage1 = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Loads\\Продольная_Нагрузка_Влево.png");


                    // Разместите изображение опоры на PictureBox в заданных координатах X
                    int yCoordinate1 = pictureBox1.Height / 4 - supportImage1.Height / 4; // Высота опоры центрирована по вертикали

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900;
                        float xCoordD = xCoordinate;
                        float lengthD = length;
                        float t1 = (xCoordD / lengthD) * 900 - 11;
                        float t2 = pictureBox1.Width / 2 - 450;
                        g.DrawImage(supportImage1, t2 + t1, yCoordinate1);
                    }

                    // Обновите PictureBox, чтобы отобразить изменения
                    pictureBox1.Invalidate();
                    break;
            }
        }
        private void InsertMomentAtX(int xCoordinate, int moment)
        {
            // Загрузите изображение опоры из ресурсов проекта
            // Создайте новое изображение для PictureBox, если оно не существует
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            // Загрузите изображение опоры из файла

            bool orientationClockWise = (moment < 0);

            switch (orientationClockWise)
            {
                case true:
                    Image supportImage = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Loads\\Момент_ПоЧасовой.png");


                    // Разместите изображение опоры на PictureBox в заданных координатах X
                    int yCoordinate = pictureBox1.Height / 4 - supportImage.Height / 4 - 25; // Высота опоры центрирована по вертикали

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900 - 20;
                        float xCoordD = xCoordinate;
                        float lengthD = length;
                        float t1 = (xCoordD / lengthD) * 900 - 14;
                        float t2 = pictureBox1.Width / 2 - 450;
                        g.DrawImage(supportImage, t2 + t1, yCoordinate);
                    }

                    // Обновите PictureBox, чтобы отобразить изменения
                    pictureBox1.Invalidate();
                    break;
                case false:
                    Image supportImage1 = Image.FromFile("C:\\Users\\Пользователь\\Desktop\\Visual_Studio\\Projects_C#\\Sopromat\\Images\\Loads\\Момент_ПротивЧасовой.png");


                    // Разместите изображение опоры на PictureBox в заданных координатах X
                    int yCoordinate1 = pictureBox1.Height / 4 - supportImage1.Height / 4 - 25; // Высота опоры центрирована по вертикали

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        int t = pictureBox1.Width / 2 - 900 / 2 + xCoordinate / length * 900 - 20;
                        float xCoordD = xCoordinate;
                        float lengthD = length;
                        float t1 = (xCoordD / lengthD) * 900 - 14;
                        float t2 = pictureBox1.Width / 2 - 450;
                        g.DrawImage(supportImage1, t2 + t1, yCoordinate1);
                    }

                    // Обновите PictureBox, чтобы отобразить изменения
                    pictureBox1.Invalidate();
                    break;
            }
        }
        private void InsertUniformlyDistributedLoad(int xCoordinateStart, int xCoordinateEnd, int value, Graphics g)
        {
            bool orientationDown = value < 0;
            switch (orientationDown)
            {
                case true:
                    if (pictureBox1.Image == null)
                    {
                        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    }

                    // Установите цвет и толщину линии
                    Pen pen = new Pen(Color.Black, 2);

                    // Установите длину и расстояние между стрелочками
                    int arrowSpacing = 20;

                    float xCoordD = xCoordinateStart;
                    float lengthD = length;
                    //float t1 = (xCoordD / lengthD) * 900;
                    //float t2 = pictureBox1.Width / 2 - 450;

                    // Вычислите координаты начала и конца нагрузки
                    float t1 = pictureBox1.Width / 2 - 450;
                    float t2 = (xCoordinateStart / lengthD) * 900;
                    float t3 = (xCoordinateEnd / lengthD) * 900;

                    float startX = t1 + t2;
                    float endX = t1 + t3;
                    int y = pictureBox1.Height / 4 - 20;

                    // Нарисуйте линию для нагрузки
                    g.DrawLine(pen, startX, y, endX, y);
                    // Нарисуйте стрелочки
                    for (float x = startX; x <= endX; x += arrowSpacing)
                    {
                        DrawArrow(g, x, y + 20);
                    }
                    void DrawArrow(Graphics g1, float x, int y3)
                    {
                        int arrowLength = 10;
                        int arrowAngle = 30;  // Угол наклона стрелки

                        // Рассчитайте координаты концов стрелки
                        double angleRad = arrowAngle * (Math.PI / 180);
                        double x1 = x - (arrowLength * Math.Sin(angleRad));
                        double y11 = y3 - (arrowLength * Math.Cos(angleRad));

                        double x2 = x + (arrowLength * Math.Sin(angleRad));
                        double y2 = y11;

                        // Нарисуйте стрелку
                        g1.DrawLine(Pens.Black, x, y3, (float)x1, (float)y11);
                        g1.DrawLine(Pens.Black, x, y3, (float)x2, (float)y2);
                        g1.DrawLine(Pens.Black, x, y3, x, y3 - 20);
                    }
                    break;
                case false:
                    if (pictureBox1.Image == null)
                    {
                        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    }

                    // Установите цвет и толщину линии
                    Pen pen1 = new Pen(Color.Black, 2);

                    // Установите длину и расстояние между стрелочками
                    int arrowSpacing1 = 20;

                    float xCoordD1 = xCoordinateStart;
                    float lengthD1 = length;
                    //float t1 = (xCoordD / lengthD) * 900;
                    //float t2 = pictureBox1.Width / 2 - 450;

                    // Вычислите координаты начала и конца нагрузки
                    float t11 = pictureBox1.Width / 2 - 450;
                    float t22 = (xCoordinateStart / lengthD1) * 900;
                    float t33 = (xCoordinateEnd / lengthD1) * 900;

                    float startX1 = t11 + t22;
                    float endX1 = t11 + t33;
                    int y1 = pictureBox1.Height / 4 + 20;

                    // Нарисуйте линию для нагрузки
                    g.DrawLine(pen1, startX1, y1, endX1, y1);
                    // Нарисуйте стрелочки
                    for (float x = startX1; x <= endX1; x += arrowSpacing1)
                    {
                        DrawArrow1(g, x, y1 - 20);
                    }
                    void DrawArrow1(Graphics g1, float x, int y3)
                    {
                        int arrowLength = 10;
                        int arrowAngle = 30;  // Угол наклона стрелки

                        // Рассчитайте координаты концов стрелки
                        double angleRad = arrowAngle * (Math.PI / 180);
                        double x1 = x + (arrowLength * Math.Sin(angleRad));
                        double y11 = y3 + (arrowLength * Math.Cos(angleRad));

                        double x2 = x - (arrowLength * Math.Sin(angleRad));
                        double y2 = y11;

                        // Нарисуйте стрелку
                        g1.DrawLine(Pens.Black, x, y3, (float)x1, (float)y11);
                        g1.DrawLine(Pens.Black, x, y3, (float)x2, (float)y2);
                        g1.DrawLine(Pens.Black, x, y3, x, y3 + 20);
                    }
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = length, x, y;
            this.chart1.Series[0].Points.Clear();
            //x = a;
            //while (x <= b)
            //{

            //}
            foreach (MomentForce moment in beam.GraphMoments)
            {
                chart1.Series[0].Points.AddXY(moment.XCoord, moment.Value);
            }
        }
    }
}
