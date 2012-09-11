using System;
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
                     
        Point3d[] sh;      
        int k = 0;
        int size = 0;


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
       

        public void GetSphere(int R)
        {
            k = 0;
            sh = new Point3d[3000];            
            double x, y, z, fi, psi;

            
            for (fi = 0; fi < 2 * Math.PI; fi += 0.2)
                for (psi = 0; psi <= Math.PI; psi += 0.2)
              // 
                {
                    x = R * Math.Sin(psi) * Math.Cos(fi);
                    y = R * Math.Sin(psi) * Math.Sin(fi);
                    z = R * Math.Cos(psi);
                    sh[k] = new Point3d((int)x, (int)y, (int)z);
                    k++;
                }

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
            
            size = Convert.ToInt32(tbsize.Text);
            GetSphere(size);
            Graphics gF = pbFront.CreateGraphics();
            Graphics gL = pbLeft.CreateGraphics();
            Graphics gT = pbTop.CreateGraphics();
            Pen pen = new Pen(Color.Red, 1);

            int i = 0;
            for (i = 0; i < k - 1; i++)
            {
                gF.DrawLine(pen, sh[i].x + 125, sh[i].y + 125, sh[i + 1].x + 125, sh[i + 1].y + 125);
                gL.DrawLine(pen, sh[i].x + 125, sh[i].z + 125, sh[i + 1].x + 125, sh[i + 1].z + 125);
                gT.DrawLine(pen, sh[i].y + 125, sh[i].z + 125, sh[i + 1].y + 125, sh[i + 1].z + 125);
            }
            gF.DrawLine(pen, sh[i].x + 125, sh[i].y + 125, sh[0].x + 125, sh[0].y + 125);
            gL.DrawLine(pen, sh[i].x + 125, sh[i].z + 125, sh[0].x + 125, sh[0].z + 125);
            gT.DrawLine(pen, sh[i].y + 125, sh[i].z + 125, sh[0].y + 125, sh[0].z + 125);
           
        }

        private void Initialize()
        {
            pbFront.Image = null;
            pbLeft.Image = null;
            pbTop.Image = null;
            pbFront.Refresh();
            pbLeft.Refresh();
            pbTop.Refresh();
        }
        #region obsolete
        private void btnrotate_Click(object sender, EventArgs e)
        {
            Initialize();
            Graphics gF = pbFront.CreateGraphics();
            Graphics gL = pbLeft.CreateGraphics();
            Graphics gT = pbTop.CreateGraphics();
            Pen pen = new Pen(Color.Red, 1);
            int i = 0;
            double angle = Convert.ToDouble(tbangle.Text) * Math.PI / 180;
            for ( i = 0; i < k; i++)
            {

                sh[i] = Multiplicate(sh[i], rotate(angle));

            }
            
            for (i = 0; i < k - 1; i++)
            {
                gF.DrawLine(pen, sh[i].x + 125, sh[i].y + 125, sh[i + 1].x + 125, sh[i + 1].y + 125);
                gL.DrawLine(pen, sh[i].x + 125, sh[i].z + 125, sh[i + 1].x + 125, sh[i + 1].z + 125);
                gT.DrawLine(pen, sh[i].y + 125, sh[i].z + 125, sh[i + 1].y + 125, sh[i + 1].z + 125);
            }
            gF.DrawLine(pen, sh[i].x + 125, sh[i].y + 125, sh[0].x + 125, sh[0].y + 125);
            gL.DrawLine(pen, sh[i].x + 125, sh[i].z + 125, sh[0].x + 125, sh[0].z + 125);
            gT.DrawLine(pen, sh[i].y + 125, sh[i].z + 125, sh[0].y + 125, sh[0].z + 125);
        }
#endregion

       
      
    }
}

