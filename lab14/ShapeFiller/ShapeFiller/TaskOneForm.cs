using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeFiller
{
    public partial class TaskOneForm : Form
    {
        static Random random = new Random();
        private int x, y, w, h;
        private int wS, hS;
        private ShapesType shapesType;
        private int typeDraw = random.Next(2);
        private Pen pen = new Pen(Color.Red);
        private SolidBrush brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));

        static PointF point1;
        static PointF point2;
        static PointF point3;
        static PointF point4;
        static PointF point5;
        static PointF point6;
        static PointF point7;
        static PointF[] curvePoints;

        private void timer1_Tick(object sender, EventArgs e)
        {
            w = ClientSize.Width;
            h = ClientSize.Height;
            x = random.Next(w / 4, w);
            y = random.Next(h / 4, h);
            wS = random.Next(50, 100);
            hS = random.Next(50, 100);
            point1 = new PointF(x, y);
            point2 = new PointF(x - 50, y - 50);
            point3 = new PointF(x - 70, y - 70);
            point4 = new PointF(x + 150, y + 80);
            point5 = new PointF(x + 120, y - 50);
            point6 = new PointF(x + 75, y - 60);
            point7 = new PointF(x + 45, y + 45);
            pen.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            brush.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

            curvePoints = new PointF[]{
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            shapesType = (ShapesType)random.Next(4);
            typeDraw = random.Next(2);
            Invalidate();
        }

        private void TaskOneForm_Load(object sender, EventArgs e)
        {
            w = ClientSize.Width;
            h = ClientSize.Height;
            x = random.Next(w/3, w/2);
            y = random.Next(h/3, h/2);
            wS = random.Next(50, 100);
            hS = random.Next(50, 100);
            shapesType = (ShapesType)random.Next(4);
            typeDraw = random.Next(2);
            point1 = new PointF(x, y);
            point2 = new PointF(x - 50, y - 50);
            point3 = new PointF(x - 70, y - 70);
            point4 = new PointF(x + 150, y + 80);
            point5 = new PointF(x + 120, y - 50);
            point6 = new PointF(x + 75, y - 60);
            point7 = new PointF(x + 45, y + 45);
            curvePoints = new PointF[]{
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };

        }

        public TaskOneForm()
        {
            InitializeComponent();
        }

        private enum ShapesType { Rectangle, Ellipse, Polygon, Line}

        private void TaskOneForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (typeDraw == 1) 
            {
                switch (shapesType)
                {
                    case ShapesType.Rectangle:
                        Rectangle rectangle = new Rectangle(x, y, wS, hS);
                        g.DrawRectangle(pen, rectangle);
                        break;
                    case ShapesType.Ellipse:
                        RectangleF rectangleF = new RectangleF(x, y, wS, hS);
                        g.DrawEllipse(pen, rectangleF);
                        break;
                    case ShapesType.Polygon:
                        g.DrawPolygon(pen, curvePoints);
                        break;
                    case ShapesType.Line:
                        g.DrawLine(pen, point1, point7);
                        break;
                }
            }
            else
            {
                switch (shapesType)
                {
                    case ShapesType.Rectangle:
                        Rectangle rectangle = new Rectangle(x, y, wS,hS);
                        g.FillRectangle(brush, rectangle);
                        break;
                    case ShapesType.Ellipse:
                        RectangleF rectangleF = new RectangleF(x, y, wS,hS);
                        g.FillEllipse(brush, rectangleF);
                        break;
                    case ShapesType.Polygon:
                        g.FillPolygon(brush, curvePoints);
                        break;
                }
            }
            
        }
    }
}
