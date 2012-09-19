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
        
        List<Edge> edgelist = new List<Edge>();
        Color ModelColor;

        public GraphicModel(Point3d basepoint,float R,float LOD,Color color) /// Input parametrs are basepoint of Sphere, Radius and Level of detalization
         {
            model.Clear();
            double x, y, z, fi, psi;

            for (fi = 0; fi < Math.PI; fi += LOD)
            {
                edgelist.Add(new Edge(edgelist.Count + 1));
                for (psi = 0; psi < 2 * Math.PI + LOD; psi += LOD)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    model.Add(new Point3d((float)x, (float)y, (float)z));
                    edgelist[edgelist.Count - 1].vertex.Add(new Point3d((float)x, (float)y, (float)z));
                }
            }
            for (psi = 0; psi < Math.PI; psi += LOD)
            {
                edgelist.Add(new Edge(edgelist.Count+1));
                for (fi = 0; fi < 2 * Math.PI+LOD; fi += LOD)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    model.Add(new Point3d((float)x, (float)y, (float)z));
                    edgelist[edgelist.Count - 1].vertex.Add(new Point3d((float)x, (float)y, (float)z));
                }
            }
            this.ModelColor = color;
        }



        public void DrawModel(Graphics FrontView, 
            Graphics LeftView,
            Graphics TopView, 
            Graphics MainView, 
            float size, 
            byte MainViewType, 
            double viewparam1,
            double viewparam2) // Draws model
         {         
            Pen pen = new Pen(ModelColor, 1);
            List<PointF> mxy = new List<PointF>();
            List<PointF> mxz = new List<PointF>();
            List<PointF> myz = new List<PointF>();
          
            foreach (Edge edge in edgelist)
            {
                
                mxy.Clear();
                mxz.Clear();
                myz.Clear();
                foreach (Point3d vertex in edge.vertex)
                {
                    mxy.Add(new PointF(vertex.x + size, vertex.y + size));
                    mxz.Add(new PointF(vertex.x + size, vertex.z + size));
                    myz.Add(new PointF(vertex.y + size, vertex.z + size));
                }
                FrontView.DrawLines(pen, mxy.ToArray());
                LeftView.DrawLines(pen, mxz.ToArray());
                TopView.DrawLines(pen, myz.ToArray());
            }
            for (int i = 0; i < edgelist.Count; i++)
                for (int j = 0; j < edgelist[i].vertex.Count - 1; j++)              
           
           
            {
            //    FrontView.DrawLine(pen, model[i].x + size, -model[i].y + size, model[i + 1].x + size,- model[i + 1].y + size);
            //    LeftView.DrawLine(pen, model[i].x + size, -model[i].z + size, model[i + 1].x + size,- model[i + 1].z + size);
            //    TopView.DrawLine(pen, model[i].y + size, -model[i].z + size, model[i + 1].y + size, -model[i + 1].z + size);
           Draw2D(MainView, edgelist[i].vertex[j], edgelist[i].vertex[j+1],size,MainViewType,viewparam1,viewparam2);
            }         
            
         }



        private void Draw2D(Graphics g,
            Point3d pt1,
            Point3d pt2,
            float size,
            byte MainViewType,
            double viewparam1,
            double viewparam2)  // Draws on  main view
        {
            Pen pen = new Pen(ModelColor, 1);
            Point3d point1=null;
            Point3d point2=null;
            switch (MainViewType)
            {
                case 0: point1 = pt1.Aksonometrik(viewparam1, viewparam2); point2 = pt2.Aksonometrik(viewparam1, viewparam2); break;
                case 1: point1 = pt1.Kosougol(viewparam1, viewparam2); point2 = pt2.Kosougol(viewparam1, viewparam2); break;
                case 2: point1 = pt1.Perspect(viewparam1); point2 = pt2.Perspect(viewparam1); break;
            }
            g.DrawLine(pen, new PointF(point1.x + size, -point1.y + size), new PointF(point2.x + size, -point2.y + size));
          
        }

        

        public void UpdateModel(double movex,
            double movey,
            double movez,
            double scalex,
            double scaley,
            double scalez,
            double anglex,
            double angley,
            double anglez)
        {

            double[,] matrixACT = MatrixReady(movex, movey, movez, scalex, scaley, scalez, anglex, angley, anglez);
            matrix.Clear();
            for (int i = 0; i < edgelist.Count; i++)
                for (int j = 0; j < edgelist[i].vertex.Count; j++)
                    edgelist[i].vertex[j] = edgelist[i].vertex[j].MultiplicateF(edgelist[i].vertex[j], matrixACT);
           
            //for (int i = 0; i < model.Count; i++)
            //{
            //    model[i] = model[i].MultiplicateF(model[i], matrixACT);                  
            //}
        }  // Update model with new parametrs

        private double[,] MatrixReady(double movex,
            double movey,
            double movez,
            double scalex,
            double scaley,
            double scalez,
            double anglex,
            double angley,
            double anglez)
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
