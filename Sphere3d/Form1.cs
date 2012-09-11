﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Sphere3d
{
    public partial class Form1 : Form
    {
        //int ox = 250;
        //int oy = 250;

        public class Point3d
        {
            public
             int x, y, z;

            public Point3d(double x, double y, double z)
            {

                this.x = (int)x;
                this.y = (int)y;
                this.z = (int)z;
            }
        }

        int size;
        Point3d[] m;
        Point3d[] sh;      
        int k = 0;


        public double[,] rotate(double angle)
        {
             double C = Math.Cos(angle);
             double S = Math.Sin(angle);             
             double[,] rotateX = { { 1, 0, 0 }, { 0, C, -S }, { 0, S, C } };
             double[,] rotateY = { { C, 0, S }, { 0, 1, 0 }, { -S, 0, C } };
             double[,] rotateZ = { { C, -S, 0 }, { S, C, 0 }, { 0, 0, 1 } };
             if (rX.Checked) return rotateX;
             if (rY.Checked) return rotateY;
             if (rZ.Checked) return rotateZ;
             else return null;           

        }


        public Point3d[] sphar = new Point3d[5000];

        public void GetSphere(int R)
        {
            k = 0;
            sh = new Point3d[3000];            
            //for (double t = 0; t < 2 * Math.PI; t += 0.2)
            //{               
            //    sh[k] = new Point3d(40 * Math.Cos(t),40 * Math.Sin(t),0);
            //    k++;
            //}
            double x, y, z, fi, psi;           
            for (psi = -Math.PI / 2; psi < Math.PI / 2; psi += 0.1)
                for (fi = 0; fi < 2 * Math.PI; fi += 0.1)
                {
                    x = R * Math.Sin(psi) * Math.Cos(fi);
                    y = R * Math.Sin(psi) * Math.Cos(fi);
                    z = R * Math.Cos(psi);
                    sh[k] = new Point3d((int)x, (int)y, (int)z);
                    k++;
                }

        }

        public void DrawCircle(Graphics g, Point pt, int Radius)
        {
            g.DrawEllipse(new Pen(Color.Black), pt.X - Radius, pt.Y - Radius, 2 * Radius, 2 * Radius);
        }
         
        public void Draw2D(Graphics g, Point3d pt1, Point3d pt2)
        {
            Pen pen = new Pen(Color.Black, 1);

            g.DrawLine(pen,new Point(pt1.x-pt1.z/2+250,-pt1.y+pt1.z/2+250),new Point(pt2.x-pt2.z/2+250,-pt2.y+pt2.z/2+250));
        }


        public Point3d Multiplicate(Point3d vertex, double[,] ar)
        {
           
            vertex.x = Convert.ToInt32(vertex.x * ar[0, 0] + vertex.y * ar[1, 2] + vertex.z * ar[2, 0]);
            vertex.y = Convert.ToInt32(vertex.x * ar[0, 1] + vertex.y * ar[1, 1] + vertex.z * ar[2, 1]);
            vertex.z = Convert.ToInt32(vertex.x * ar[0, 2] + vertex.y * ar[1, 2] + vertex.z * ar[2, 2]);
            return vertex;

        }


        public Form1()
        {
            InitializeComponent();
        }


        private void btnbuild_Click(object sender, EventArgs e)
        {
            Initialize();
            pbMain.Refresh();
            Graphics g = pbMain.CreateGraphics();
            size = Convert.ToInt32(tbsize.Text);
            m = new Point3d[8];
            m[0] = new Point3d(0, 0, 0);
            m[1] = new Point3d(0, 0, size);
            m[2] = new Point3d(size, 0, size);
            m[3] = new Point3d(size, 0, 0);
            m[4] = new Point3d(0, size, 0);
            m[5] = new Point3d(0, size, size);
            m[6] = new Point3d(size, size, size);
            m[7] = new Point3d(size, size, 0);
            for (int i = 0; i < 3; i++)
                Draw2D(g, m[i], m[i + 1]);
            Draw2D(g, m[3], m[0]);
            for (int i = 4; i < 7; i++)
                Draw2D(g, m[i], m[i + 1]);
            Draw2D(g, m[4], m[7]);
            Draw2D(g, m[0], m[4]);
            Draw2D(g, m[1], m[5]);
            Draw2D(g, m[2], m[6]);
            Draw2D(g, m[3], m[7]);

        }

        private void Initialize()
        {
            pbMain.Image = Properties.Resources.Untitled;
        }

        private void btnrotate_Click(object sender, EventArgs e)
        {
            Initialize();
            pbMain.Refresh();
            Graphics g = pbMain.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            double angle = Convert.ToDouble(tbangle.Text) * Math.PI / 180;
            for (int i = 0; i < m.Length; i++)
            {

                m[i] = Multiplicate(m[i], rotate(angle));

            }


            for (int i = 0; i < 3; i++)
                Draw2D(g, m[i], m[i + 1]);
            Draw2D(g, m[3], m[0]);
            for (int i = 4; i < 7; i++)
                Draw2D(g, m[i], m[i + 1]);
            Draw2D(g, m[4], m[7]);
            Draw2D(g, m[0], m[4]);
            Draw2D(g, m[1], m[5]);
            Draw2D(g, m[2], m[6]);
            Draw2D(g, m[3], m[7]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSphere(200);
            Graphics g = pbMain.CreateGraphics();
            Pen pen = new Pen(Color.Red,1);
            int i = 0;
            for (i = 0; i < k - 1; i++)
            {
                    g.DrawLine(pen,sh[i].z, sh[i].x, sh[i + 1].z, sh[i + 1].x);
               
             //   DrawCircle(g, new Point(20, 20), 20);

               // Draw2D(g, sh[i], sh[i + 1]);
            }
           // Draw2D(g, sh[0], sh[i]);
          //  Draw2D(g,new Point3d(-20,-20,0),new Point3d(20,20,20));
            g.DrawLine(pen, sh[i ].z, sh[i ].x, sh[0].z, sh[0].x);
        }
    }
}

