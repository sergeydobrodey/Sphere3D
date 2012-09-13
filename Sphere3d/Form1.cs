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


        List<Point3d> sh = new List<Point3d>();  
        List<double[,]> matrix = new List<double[,]>();
        int size = 0;
        Point3d basepoint;
        float Lod = 0.1F;
        int W = 1;

        #region Matrix
        public void Rotate(double anglex,double angley,double anglez)
        {  
            double Cx = Math.Cos(anglex);
            double Sx = Math.Sin(anglex);
            double Cy = Math.Cos(angley);
            double Sy = Math.Sin(angley);
            double Cz = Math.Cos(anglez);
            double Sz = Math.Sin(anglez);
            double[,] rotateX = { { 1, 0, 0, 0 }, { 0, Cx, Sx, 0 }, { 0, -Sx, Cx, 0 }, { 0, 0, 0, 1 } };
            double[,] rotateY = { { Cy, 0, Sy, 0 }, { 0, 1, 0, 0 }, { -Sy, 0, Cy, 0 }, { 0, 0, 0, 1 } };
            double[,] rotateZ = { { Cz, Sz, 0, 0 }, { -Sz, Cz, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            matrix.Add(rotateX);
            matrix.Add(rotateY);
            matrix.Add(rotateZ);
        }

        public void Move(double movex, double movey, double movez)
        {
            double[,] move = { { 1, 0, 0, movex }, { 0, 1, 0, movey }, { 0, 0,1, movez }, { 0, 0, 0, 1 } };
            matrix.Add(move);
        }

        public void Scale(double scalex, double scaley, double scalez)
        {
            double[,] scale = { { scalex, 0, 0, 0 }, { 0, scaley, 0, 0 }, { 0, 0, scalez, 0 }, { 0, 0, 0, 1 } };
            matrix.Add(scale);
            
        }
        #endregion


        public void GetSphere(Point3d basepoint,int R)
        {
            sh.Clear();           
            double x, y, z, fi, psi;
            for (fi = 0; fi < Math.PI; fi += Lod)
                for (psi = 0; psi < 2 * Math.PI; psi += Lod)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    sh.Add(new Point3d((int)x, (int)y, (int)z));                   
                }
            for (psi = 0; psi < Math.PI; psi +=  Lod)
                for (fi = 0; fi < 2 * Math.PI; fi += Lod)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    sh.Add(new Point3d((int)x, (int)y, (int)z));                     
                }            
        }
       
        public void Draw2D(Graphics g, Point3d pt1, Point3d pt2)
        {
            Pen pen = new Pen(Color.Black, 1);

            g.DrawLine(pen,new PointF(pt1.x-pt1.z/2+pbFront.Width/2,-pt1.y+pt1.z/2+pbFront.Width/2),new PointF(pt2.x-pt2.z/2+pbFront.Width/2,-pt2.y+pt2.z/2+pbFront.Width/2));
           
        }

        public Point3d MultiplicateF(Point3d vertex, double[,] ar)
        {
            double[,] result= new double[4,1];
            double[,] a = ar;
            double[,] b = new double[4, 1];
            b[0, 0] = vertex.x;
            b[1, 0] = vertex.y;
            b[2, 0] = vertex.z;
            b[3, 0] = W;
            
            for (int i = 0; i < 4; i++)   
               for (int j = 0; j < 1; j++)
               {
                   result[i, j] = 0;
                   for (int r = 0; r < 4; r++)
                       result[i, j] += a[i, r] * b[r, j];
               }   
            
            vertex.x = (float)(result[0,0]);
            vertex.y = (float)(result[1, 0]);
            vertex.z = (float)(result[2, 0]);
            
            return vertex;

        }

        public double[,] MultiplicateM(double[,] a, double[,] b)
        {
            double[,] result = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    result[i, j] = 0;
                    for (int r = 0; r < 4; r++)
                        result[i, j] += a[i, r] * b[r, j];
                }   
            return result;
        }

        public double[,] MatrixReady() 
        {           

            double movex = Convert.ToDouble(tbmovex.Text);
            double movey = Convert.ToDouble(tbmovey.Text);
            double movez = Convert.ToDouble(tbmovez.Text);
            Move(movex, movey, movez);
           

            double scalex = Convert.ToDouble(tbScaleX.Text);
            double scaley = Convert.ToDouble(tbScaleY.Text);
            double scalez = Convert.ToDouble(tbScaleZ.Text);
            Scale(scalex, scaley, scalez);

            double anglex = Convert.ToDouble(tbanglex.Text) * Math.PI / 180; ;
            double angley = Convert.ToDouble(tbangley.Text) * Math.PI / 180; ;
            double anglez = Convert.ToDouble(tbanglez.Text) * Math.PI / 180; ;
            Rotate(anglex, angley, anglez);

            double[,] result = new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            for (int i = 0; i < matrix.Count; i++)
                result = MultiplicateM(result, matrix[i]);     
            return result;
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

            for (i = 0; i < sh.Count-1; i++)
            {
                gF.DrawLine(pen, sh[i].x + pbFront.Width/2, sh[i].y + pbFront.Width/2, sh[i + 1].x + pbFront.Width/2, sh[i + 1].y + pbFront.Width/2);
                gL.DrawLine(pen, sh[i].x + pbFront.Width/2, sh[i].z + pbFront.Width/2, sh[i + 1].x + pbFront.Width/2, sh[i + 1].z + pbFront.Width/2);
                gT.DrawLine(pen, sh[i].y + pbFront.Width/2, sh[i].z + pbFront.Width/2, sh[i + 1].y + pbFront.Width/2, sh[i + 1].z + pbFront.Width/2);
                Draw2D(gM, sh[i], sh[i + 1]);
            }
            gF.DrawLine(pen, sh[i].x + pbFront.Width/2, sh[i].y + pbFront.Width/2, sh[0].x + pbFront.Width/2, sh[0].y + pbFront.Width/2);
            gL.DrawLine(pen, sh[i].x + pbFront.Width/2, sh[i].z + pbFront.Width/2, sh[0].x + pbFront.Width/2, sh[0].z + pbFront.Width/2);
            gT.DrawLine(pen, sh[i].y + pbFront.Width/2, sh[i].z + pbFront.Width/2, sh[0].y + pbFront.Width/2, sh[0].z + pbFront.Width/2);
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
                Initialize();
                double[,] matrixACT = MatrixReady();
                matrix.Clear();
                for (int i = 0; i < sh.Count-1; i++)
                {
                    sh[i] = MultiplicateF(sh[i], matrixACT);
                }
                DrawSphere();
           
        }
#endregion

        private void btnmove_Click(object sender, EventArgs e)
        {
            btnrotate_Click(this, null);
            //Initialize();
            //for (int i = 0; i < sh.Count - 1; i++)
            //{
            //    sh[i].x += Convert.ToInt32(tbmovex.Text);
            //    sh[i].y += Convert.ToInt32(tbmovey.Text);
            //    sh[i].z += Convert.ToInt32(tbmovez.Text);
            //}
            //DrawSphere();
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
            basepoint.x -= pbFront.Width/2;
            basepoint.y -= pbFront.Width/2;
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
            btnrotate_Click(this, null);
        }

       
       

       
      
    }
}

