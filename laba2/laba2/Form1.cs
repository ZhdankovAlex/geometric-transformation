using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        bool power = false;

        const int additiveX = 320;
        const int additiveY = 230;
             
        List<int> A = new List<int>() { 0, 0, 0 };
        List<int> B = new List<int>() { 0, 0, 0 };
        List<int> C = new List<int>() { 0, 0, 0 };
        List<int> D = new List<int>() { 0, 0, 0 };
        List<int> E = new List<int>() { 0, 0, 0 };
        List<int> F = new List<int>() { 0, 0, 0 };
        List<int> G = new List<int>() { 0, 0, 0 };
        List<int> H0 = new List<int>() { 0, 0, 0 };
        List<int> H1 = new List<int>() { 0, 0, 0 };
        List<int> H2 = new List<int>() { 0, 0, 0 };
        List<int> H3 = new List<int>() { 0, 0, 0 };

        int shift = 50;

        Pen p = new Pen(Color.Black, 1);

        Graphics drawArea;
        public Form1()
        {
            InitializeComponent();
            drawArea = pictureBox1.CreateGraphics();
        }
        //draw figure by points
        private void Draw(List<int> a, List<int> b, List<int> c, List<int> d,
                          List<int> e, List<int> f, List<int> g, List<int> h0,
                          List<int> h1, List<int> h2, List<int> h3)
        {
            drawArea.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
           
            drawArea.DrawLine(p, 0, (int)(pictureBox1.Height/2), 
                             (int)(pictureBox1.Width), (int)(pictureBox1.Height / 2));
            drawArea.DrawLine(p, (int)(pictureBox1.Width/2), 0,
                             (int)(pictureBox1.Width/2), (int)(pictureBox1.Height));
            p = new Pen(Color.Red, 1);
            drawArea.DrawLine(p, 90, (int)(pictureBox1.Height), (int)(pictureBox1.Width) - 90, 0);

            p = new Pen(Color.Black, 1);
            drawArea.DrawLine(p, a[0] + additiveX, additiveY - a[1], b[0] + additiveX, additiveY - b[1]);
            drawArea.DrawLine(p, b[0] + additiveX, additiveY - b[1], c[0] + additiveX, additiveY - c[1]);
            drawArea.DrawLine(p, c[0] + additiveX, additiveY - c[1], d[0] + additiveX, additiveY - d[1]);
            drawArea.DrawLine(p, d[0] + additiveX, additiveY - d[1], e[0] + additiveX, additiveY - e[1]);
            drawArea.DrawLine(p, e[0] + additiveX, additiveY - e[1], f[0] + additiveX, additiveY - f[1]);
            drawArea.DrawLine(p, f[0] + additiveX, additiveY - f[1], g[0] + additiveX, additiveY - g[1]);
            drawArea.DrawLine(p, g[0] + additiveX, additiveY - g[1], a[0] + additiveX, additiveY - a[1]);

            Point H0 = new Point(h0[0] + additiveX, additiveY - h0[1]);
            Point H1 = new Point(h1[0] + additiveX, additiveY - h1[1]);
            Point H2 = new Point(h2[0] + additiveX, additiveY - h2[1]);
            Point H3 = new Point(h3[0] + additiveX, additiveY - h3[1]);
            Point[] curvePoints = {H0, H1, H2, H3};
            float tension = 1.0F;
            System.Drawing.Drawing2D.FillMode aFillMode = System.Drawing.Drawing2D.FillMode.Alternate;

            drawArea.DrawClosedCurve(p, curvePoints.ToArray(), tension, aFillMode);
        }
        //initialization
        private void button17_Click(object sender, EventArgs e)
        {
            power = true;

            A[0] = 20;
            A[1] = 110;
            A[2] = 1;

            B[0] = A[0] + 50;
            B[1] = A[1] - 10;
            B[2] = A[2];

            //верхняя точка "короны"
            C[0] = A[0] + 70;
            C[1] = A[1] + 20;
            C[2] = 1;

            D[0] = A[0] + 90;
            D[1] = A[1] - 10;
            D[2] = 1;

            E[0] = A[0] + 140;
            E[1] = A[1];
            E[2] = 1;

            F[0] = A[0] + 120;
            F[1] = A[1] - 30;
            F[2] = 1;

            G[0] = A[0] + 20;
            G[1] = A[1] - 30;
            G[2] = 1;

            H0[0] = A[0] + 70;
            H0[1] = A[1] - 30;
            H0[2] = 1;

            H1[0] = A[0] + 40;
            H1[1] = A[1] - 60;
            H1[2] = 1;

            H2[0] = A[0] + 70;
            H2[1] = A[1] - 90;
            H2[2] = 1;

            H3[0] = A[0] + 100;
            H3[1] = A[1] - 60;
            H3[2] = 1;

            Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
        }
        //multiplicate method
        List<int> Multiplicate(List<int>point, double[,]matrix)
        {
            List<int> result = new List<int>() { 0, 0, 0 };
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i] += (int)(point[j] * matrix[j, i]);
                }
            }
            return result;
        }
        //transform
        private void Transform(List<int> a, List<int> b, List<int> c,
                               List<int> d, List<int> e, List<int> f,
                               List<int> g, List<int> h0, List<int> h1,
                               List<int> h2, List<int> h3, double[,] transform)
        {
            A = Multiplicate(a, transform);
            B = Multiplicate(b, transform);
            C = Multiplicate(c, transform);
            D = Multiplicate(d, transform);
            E = Multiplicate(e, transform);
            F = Multiplicate(f, transform);
            G = Multiplicate(g, transform);
            H0 = Multiplicate(h0, transform);
            H1 = Multiplicate(h1, transform);
            H2 = Multiplicate(h2, transform);
            H3 = Multiplicate(h3, transform);
        }
        //to_left
        private void button2_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { -shift, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //to_right
        private void button1_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { shift, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //to_up
        private void button3_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, shift, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //to_down
        private void button4_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, -shift, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //mirror_OY
        private void button9_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
                                
                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //mirror_OX
        private void button6_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //mirror_X=Y
        private void button5_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 0, 1, 0 }, { 1, 0, 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //scale_X++
        private void button12_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 2, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //scale_X--
        private void button11_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 0.5, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //scale_Y++
        private void button14_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, 2, 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //scale_Y--
        private void button13_Click(object sender, EventArgs e)
        {
            if (power)
            {
                double[,] transform = new double[3, 3] { { 1, 0, 0 }, { 0, 0.5, 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //sin_angle
        static double MySinus(double angle)
        {
            return (Math.Sin((angle / 180D) * Math.PI));
        }
        //cos_angle
        static double MyCosinus(double angle)
        {
            if (angle % 90 == 0 && angle % 180 != 0) return 0;
            return (Math.Cos((angle / 180D) * Math.PI));
        }
        //rotate_00
        private void button16_Click(object sender, EventArgs e)
        {
             if (power)
            {
                double alpha = float.Parse(textBox1.Text);
                double[,] transform = new double[3, 3] { { MyCosinus(alpha), MySinus(alpha), 0 }, { -MySinus(alpha), MyCosinus(alpha), 0 }, { 0, 0, 1 } };

                Transform(A, B, C, D, E, F, G, H0, H1, H2, H3, transform);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
        //rotate_XY
        private void button15_Click(object sender, EventArgs e)
        {            
            if (power)
            {
                int x_point = int.Parse(textBox3.Text);
                int y_point = int.Parse(textBox4.Text);
                double alpha = float.Parse(textBox1.Text);
                
                double[,] transform1 = new double[3, 3]
                { { 1, 0, 0 }, { 0, 1, 0 }, { -x_point, -y_point, 1 } };

                double[,] transform2 = new double[3, 3] 
                { { MyCosinus(alpha), MySinus(alpha), 0 }, 
                { -MySinus(alpha), MyCosinus(alpha), 0 }, 
                { 0, 0, 1 } };

                double[,] transform3 = new double[3, 3]
                { { 1, 0, 0 }, { 0, 1, 0 }, { x_point, y_point, 1 } };

                A = Multiplicate(Multiplicate(Multiplicate(A, transform1), transform2), transform3);
                B = Multiplicate(Multiplicate(Multiplicate(B, transform1), transform2), transform3);
                C = Multiplicate(Multiplicate(Multiplicate(C, transform1), transform2), transform3);
                D = Multiplicate(Multiplicate(Multiplicate(D, transform1), transform2), transform3);
                E = Multiplicate(Multiplicate(Multiplicate(E, transform1), transform2), transform3);
                F = Multiplicate(Multiplicate(Multiplicate(F, transform1), transform2), transform3);
                G = Multiplicate(Multiplicate(Multiplicate(G, transform1), transform2), transform3);
                H0 = Multiplicate(Multiplicate(Multiplicate(H0, transform1), transform2), transform3);
                H1 = Multiplicate(Multiplicate(Multiplicate(H1, transform1), transform2), transform3);
                H2 = Multiplicate(Multiplicate(Multiplicate(H2, transform1), transform2), transform3);
                H3 = Multiplicate(Multiplicate(Multiplicate(H3, transform1), transform2), transform3);

                Draw(A, B, C, D, E, F, G, H0, H1, H2, H3);
            }
        }
    }
}