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
             float x, y, z;

            public Point3d(double x, double y, double z)
            {

                this.x = (float)x;
                this.y = (float)y;
                this.z = (float)z;
            }
        }
                     
        Point3d[] sh;      
        int k = 0;
        int size = 0;
        Point3d basepoint;
        float Lod = 0.1F;


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
       

        public void GetSphere(Point3d basepoint,int R)
        {
            k = 0;
            sh = new Point3d[5000];            
            double x, y, z, fi, psi;


            for (fi = 0; fi < Math.PI; fi += Lod)
                for (psi = 0; psi < 2 * Math.PI; psi += Lod)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    sh[k] = new Point3d((int)x, (int)y, (int)z);
                    k++;
                }
            for (psi = 0; psi < Math.PI; psi +=  Lod)
                for (fi = 0; fi < 2 * Math.PI; fi += Lod)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    sh[k] = new Point3d((int)x, (int)y, (int)z);
                    k++;
                }

        }
       
        public void Draw2D(Graphics g, Point3d pt1, Point3d pt2)
        {
            Pen pen = new Pen(Color.Black, 1);

            g.DrawLine(pen,new PointF(pt1.x-pt1.z/2+125,-pt1.y+pt1.z/2+125),new PointF(pt2.x-pt2.z/2+125,-pt2.y+pt2.z/2+125));
           
        }

        public Point3d Multiplicate(Point3d vertex, double[,] ar)
        {
            double[,] result= new double[1,3];
            double[,] a = new double[1, 3];
            a[0, 0] = vertex.x;
            a[0, 1] = vertex.y;
            a[0, 2] = vertex.z;
            double[,] b = ar;
            for (int i = 0; i < 1; i++)   
               for (int j = 0; j < 3; j++)
               {
                   result[i, j] = 0;
                   for (int r = 0; r < 3; r++)
                       result[i, j] += a[i, r] * b[r, j];
               }   
            
            vertex.x = Convert.ToInt32(result[0,0]); 
            vertex.y = Convert.ToInt32(result[0,1]);
            vertex.z = Convert.ToInt32(result[0,2]);
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
            basepoint = new Point3d(Convert.ToDouble(tbbasex.Text), Convert.ToDouble(tbbasey.Text), Convert.ToDouble(tbbasez.Text));
            GetSphere(basepoint,size);
            DrawSphere();
           
        }

        private void DrawSphere()
        {
            Graphics gF = pbFront.CreateGraphics();
            Graphics gL = pbLeft.CreateGraphics();
            Graphics gT = pbTop.CreateGraphics();
            Graphics gM = pbMain.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 1);

            int i = 0;
            for (i = 0; i < k - 1; i++)
            {
                gF.DrawLine(pen, sh[i].x + 125, sh[i].y + 125, sh[i + 1].x + 125, sh[i + 1].y + 125);
                gL.DrawLine(pen, sh[i].x + 125, sh[i].z + 125, sh[i + 1].x + 125, sh[i + 1].z + 125);
                gT.DrawLine(pen, sh[i].y + 125, sh[i].z + 125, sh[i + 1].y + 125, sh[i + 1].z + 125);
                Draw2D(gM, sh[i], sh[i + 1]);
            }
            gF.DrawLine(pen, sh[i].x + 125, sh[i].y + 125, sh[0].x + 125, sh[0].y + 125);
            gL.DrawLine(pen, sh[i].x + 125, sh[i].z + 125, sh[0].x + 125, sh[0].z + 125);
            gT.DrawLine(pen, sh[i].y + 125, sh[i].z + 125, sh[0].y + 125, sh[0].z + 125);
        }

        private void Initialize()
        {
            pbFront.Image = Properties.Resources.viewport;
            pbLeft.Image = Properties.Resources.viewport;
            pbTop.Image = Properties.Resources.viewport;
            pbMain.Image = null;
            pbFront.Refresh();
            pbLeft.Refresh();
            pbTop.Refresh();
            pbMain.Refresh();
        }
        #region obsolete
        private void btnrotate_Click(object sender, EventArgs e)
        {
            try
            {
                Initialize();               
                double angle = Convert.ToDouble(tbangle.Text) * Math.PI / 180;
                for (int i = 0; i < k; i++)
                {
                    sh[i] = Multiplicate(sh[i], rotate(angle));
                }
                DrawSphere();               
            }
            catch (NullReferenceException )
            {
                 MessageBox.Show("Sphere is not exist");
            };
        }
#endregion

        private void btnmove_Click(object sender, EventArgs e)
        {
            Initialize();
            for (int i = 0; i < k; i++)
            {
                sh[i].x += Convert.ToInt32(tbmovex.Text);
                sh[i].y += Convert.ToInt32(tbmovey.Text);
                sh[i].z += Convert.ToInt32(tbmovez.Text);
            }
            DrawSphere();
        }

        private void pbFront_MouseDown(object sender, MouseEventArgs e)
        {
            basepoint = new Point3d(e.X, e.Y, 0);          
        }

        private void pbFront_MouseUp(object sender, MouseEventArgs e)
        {
            Initialize();
            Point3d radpoint= new Point3d (e.X,e.Y,0);
            size=Convert.ToInt32(Math.Sqrt((radpoint.x-basepoint.x)*(radpoint.x-basepoint.x)+(radpoint.y-basepoint.y)*(radpoint.y-basepoint.y)));
            basepoint.x -= 125;
            basepoint.y -= 125;
            GetSphere(basepoint, size);
            DrawSphere();
        }

        private void trackBarLOD_ValueChanged(object sender, EventArgs e)
        {
            Lod =(float)trackBarLOD.Value / 10;
            tabControlMain.Refresh();
        }

        private void btnscale_Click(object sender, EventArgs e)
        {

        }

       
       

       
      
    }
}

