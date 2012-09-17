using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sphere3d
{
    class GraphicModel
    {
        List<Point3d> model = new List<Point3d>();
        List<double[,]> matrix = new List<double[,]>();
        const double W = 1;
        Color ModelColor;

        public GraphicModel(Point3d basepoint,float R,float LOD,Color color) /// Input parametrs are basepoint of Sphere, Radius and Level of detalization
         {
            model.Clear();
            double x, y, z, fi, psi;
            for (fi = 0; fi < Math.PI; fi += LOD)
                for (psi = 0; psi < 2 * Math.PI; psi += LOD)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    model.Add(new Point3d((float)x, (float)y, (float)z));
                }
            for (psi = 0; psi < Math.PI; psi += LOD)
                for (fi = 0; fi < 2 * Math.PI; fi += LOD)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    model.Add(new Point3d((float)x, (float)y, (float)z));
                }
            this.ModelColor = color;
        }

        

        public void DrawModel(Graphics FrontView,Graphics LeftView,Graphics TopView,Graphics MainView,float size,bool MainViewIsometrik) // Draws model
         {         
            Pen pen = new Pen(ModelColor, 1);
            for (int i = 0; i < model.Count - 1; i++)
            {
                FrontView.DrawLine(pen, model[i].x + size, model[i].y + size, model[i + 1].x + size, model[i + 1].y + size);
                LeftView.DrawLine(pen, model[i].x + size, model[i].z + size, model[i + 1].x + size, model[i + 1].z + size);
                TopView.DrawLine(pen, model[i].y + size, model[i].z + size, model[i + 1].y + size, model[i + 1].z + size);
                Draw2D(MainView, model[i], model[i + 1],size,MainViewIsometrik);
            }
            
         }
        
        private void Draw2D(Graphics g, Point3d pt1, Point3d pt2,float size,bool isometrik)  // Draws on  main view
        {
            Pen pen = new Pen(ModelColor, 1);
            if (isometrik)
                g.DrawLine(pen, new PointF((float)(pt1.x / Math.Cos(Math.PI / 6) - pt1.z * Math.Cos(Math.PI / 6) + size), (float)(-pt1.y + pt1.z * Math.Sin(Math.PI / 6) + pt1.x * Math.Sin(Math.PI / 6) + size)), new PointF((float)(pt2.x / Math.Cos(Math.PI / 6) - pt2.z * Math.Cos(Math.PI / 6) + size), (float)(-pt2.y + pt2.z * Math.Sin(Math.PI / 6) + pt2.x * Math.Sin(Math.PI / 6) + size)));
            else
                g.DrawLine(pen, new PointF(pt1.x - pt1.z / 2 + size, -pt1.y + pt1.z / 2 + size), new PointF(pt2.x - pt2.z / 2 + size, -pt2.y + pt2.z / 2 + size));
        }

        public void UpdateModel(double movex, double movey, double movez, double scalex, double scaley, double scalez, double anglex, double angley, double anglez)
        {

            double[,] matrixACT = MatrixReady(movex, movey, movez, scalex, scaley, scalez, anglex, angley, anglez);
            matrix.Clear();
            for (int i = 0; i < model.Count; i++)
            {
                model[i] = MultiplicateF(model[i], matrixACT);
            }
        }  // Update model with new parametrs

        private double[,] MatrixReady(double movex, double movey, double movez, double scalex, double scaley, double scalez, double anglex, double angley, double anglez)
        {           
            Move(movex, movey, movez);
            try
            {               
                Scale(scalex, scaley, scalez);
            }
            catch (FormatException)
            {
                MessageBox.Show("Use decimal comma", "Something wrong");
            }
            anglex = Convert.ToDouble(anglex) * Math.PI / 180; 
            angley = Convert.ToDouble(angley) * Math.PI / 180; 
            anglez = Convert.ToDouble(anglez) * Math.PI / 180; 
            Rotate(anglex, angley, anglez);
            double[,] result = new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            for (int i = 0; i < matrix.Count; i++)
                result = MultiplicateM(result, matrix[i]);
            return result;
        }   
         
        private double[,] MultiplicateM(double[,] a, double[,] b)
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

        private Point3d MultiplicateF(Point3d vertex, double[,] ar)
        {
            double[,] result = new double[4, 1];
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

            vertex.x = (float)(result[0, 0]);
            vertex.y = (float)(result[1, 0]);
            vertex.z = (float)(result[2, 0]);

            return vertex;

        }

        #region Matrix
        private void Rotate(double anglex, double angley, double anglez)
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

        private void Move(double movex, double movey, double movez)
        {
            double[,] move = { { 1, 0, 0, movex }, { 0, 1, 0, movey }, { 0, 0, 1, movez }, { 0, 0, 0, 1 } };
            matrix.Add(move);
        }

        private void Scale(double scalex, double scaley, double scalez)
        {
            double[,] scale = { { scalex, 0, 0, 0 }, { 0, scaley, 0, 0 }, { 0, 0, scalez, 0 }, { 0, 0, 0, 1 } };
            matrix.Add(scale);

        }
        #endregion

        
    }
}
