﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sphere3d
{
    class GraphicModel
    {

        readonly List<double[,]> matrix = new List<double[,]>();
        readonly List<Edge> edgelist = new List<Edge>();
        //readonly List<Faces> faceslist = new List<Faces>();
        readonly Color ModelColor;
       
        public GraphicModel(Point3d basepoint,float R,float LOD,Color color)
        {          
            double x, y, z, fi, psi;
            for (fi = 0; fi < Math.PI; fi += LOD)
            {
                edgelist.Add(new Edge());
                for (psi = 0; psi < 2 * Math.PI + LOD; psi += LOD)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);                   
                    edgelist[edgelist.Count - 1].vertex.Add(new Point3d((float)x, (float)y, (float)z));
                }
            }
          
            for (psi = 0; psi < Math.PI; psi += LOD)
            {
                edgelist.Add(new Edge());
                for (fi = 0; fi <2 * Math.PI+LOD; fi += LOD)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);                   
                    edgelist[edgelist.Count - 1].vertex.Add(new Point3d((float)x, (float)y, (float)z));
                    
                }
            }

            ModelColor = color;
        }



        public void DrawModel(Graphics FrontView,
            Graphics LeftView,
            Graphics TopView,
            Graphics MainView,
            float size,
            byte MainViewType,
            double viewparam1,
            double viewparam2,
            double viewparam3,
            double viewparam4) // Draws model
        {
            var pen = new Pen(ModelColor, 1);
            var mxy = new List<PointF>();
            var mxz = new List<PointF>();
            var myz = new List<PointF>();

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

            foreach (Edge t in edgelist)
                for (int j = 0; j < t.vertex.Count - 1; j++)
                    Draw2D(MainView, t.vertex[j], t.vertex[j + 1], MainViewType, viewparam1, viewparam2, viewparam3, viewparam4);
        }


        public void DrawModelFast(
            Graphics MainView,
            float size,
            byte MainViewType,
            double viewparam1,
            double viewparam2,
            double viewparam3,
            double viewparam4) // Draws model
        {
         
            this.Fill(MainView,MainViewType,viewparam1,viewparam2,viewparam3,viewparam4,false);
            //var mainviewlist = new List<PointF>();
            //foreach (Edge t in edgelist)
            //    mainviewlist.AddRange(t.vertex.Select(t1 => t1.Perspect(viewparam1, viewparam2, viewparam3, viewparam4).ToPoitntFxy()));
            //MainView.DrawLines(new Pen(ModelColor, 1), mainviewlist.ToArray());
            
        }
     


        private void Draw2D(Graphics g,
            Point3d pt1,
            Point3d pt2,
            byte MainViewType,
            double viewparam1,
            double viewparam2,
            double viewparam3,
            double viewparam4)  // Draws main view
        {
            var pen = new Pen(ModelColor, 1);
            Point3d point1=null;
            Point3d point2=null;
            switch (MainViewType)
            {
                case 0: point1 = pt1.Aksonometrik(viewparam1, viewparam2); point2 = pt2.Aksonometrik(viewparam1, viewparam2); break;
                case 1: point1 = pt1.Kosougol(viewparam1, viewparam2); point2 = pt2.Kosougol(viewparam1, viewparam2); break;
                case 2: point1 = pt1.Perspect(viewparam1, viewparam2, viewparam3, viewparam4); point2 = pt2.Perspect(viewparam1, viewparam2, viewparam3, viewparam4); break;
            }
            g.DrawLine(pen, point1.ToPoitntFxy(), point2.ToPoitntFxy());
          
        }

        public void Fill(Graphics eGraphics,
            byte mainViewType,
            double viewparam1,
            double viewparam2,
            double viewparam3,
            double viewparam4,
            bool light)
        {
            //faceslist.Clear();
            for (var i = edgelist.Count/2; i < edgelist.Count; i++)
            {
                for (var j = 0; j < edgelist[0].vertex.Count; j++)
                {
                    var iNext = (i != edgelist.Count-1) ? i + 1 : i;
                    var jNext = (j != edgelist[0].vertex.Count-1) ? j + 1 : 0;
                    Point3d point1 = edgelist[i].vertex[j];
                    Point3d point2 = edgelist[i].vertex[jNext];
                    Point3d point3 = edgelist[iNext].vertex[jNext];
                    Point3d point4 = edgelist[iNext].vertex[j];
                    //faceslist.Add(new Faces(point1,point2,point3, point4,ModelColor));
                    var f = new Faces(point1, point2, point3, point4, ModelColor);
                    if (light) f.LightDiffuse();
                    switch (mainViewType)
                    {
                        case 0:
                            f.pt1 = f.pt1.Aksonometrik(viewparam1, viewparam2);
                            f.pt2 = f.pt2.Aksonometrik(viewparam1, viewparam2);
                            f.pt3 = f.pt3.Aksonometrik(viewparam1, viewparam2);
                            f.pt4 = f.pt4.Aksonometrik(viewparam1, viewparam2);
                            break;
                        case 1:
                            f.pt1 = f.pt1.Kosougol(viewparam1, viewparam2);
                            f.pt2 = f.pt2.Kosougol(viewparam1, viewparam2);
                            f.pt3 = f.pt3.Kosougol(viewparam1, viewparam2);
                            f.pt4 = f.pt4.Kosougol(viewparam1, viewparam2);
                            break;
                        case 2:
                            f.pt1 = f.pt1.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
                            f.pt2 = f.pt2.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
                            f.pt3 = f.pt3.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
                            f.pt4 = f.pt4.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
                            break;
                    }

                    var A = f.pt1.y * (f.pt2.z - f.pt3.z) + f.pt2.y * (f.pt3.z - f.pt1.z) + f.pt3.y * (f.pt1.z - f.pt2.z);
                    var B = f.pt1.z * (f.pt2.x - f.pt3.x) + f.pt2.z * (f.pt3.x - f.pt1.x) + f.pt3.z * (f.pt1.x - f.pt2.x);
                    var C = f.pt1.x * (f.pt2.y - f.pt3.y) + f.pt2.x * (f.pt3.y - f.pt1.y) + f.pt3.x * (f.pt1.y - f.pt2.y);
                    var D = -(A * f.pt1.x + B * f.pt1.y + C * f.pt1.z);

                    if (D < 0)
                    {
                        A = -A;
                        B = -B;
                        C = -C;
                        D = -D;
                    }
                    if (0 * A + 0 * B + 10000 * C + 1 * D > 0)
                    {
                        f.DrawIt(eGraphics, light);
                    }
                }
            }
          
           
            //foreach (var f in faceslist)
            //{
            //    if (light) f.LightDiffuse();
            //    switch (mainViewType)
            //    {
            //        case 0:
            //            f.pt1 = f.pt1.Aksonometrik(viewparam1, viewparam2);
            //            f.pt2 = f.pt2.Aksonometrik(viewparam1, viewparam2);
            //            f.pt3 = f.pt3.Aksonometrik(viewparam1, viewparam2);
            //            f.pt4 = f.pt4.Aksonometrik(viewparam1, viewparam2);
            //            break;
            //        case 1:
            //            f.pt1 = f.pt1.Kosougol(viewparam1, viewparam2);
            //            f.pt2 = f.pt2.Kosougol(viewparam1, viewparam2);
            //            f.pt3 = f.pt3.Kosougol(viewparam1, viewparam2);
            //            f.pt4 = f.pt4.Kosougol(viewparam1, viewparam2);
            //            break;
            //        case 2:
            //            f.pt1 = f.pt1.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
            //            f.pt2 = f.pt2.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
            //            f.pt3 = f.pt3.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
            //            f.pt4 = f.pt4.Perspect(viewparam1, viewparam2, viewparam3, viewparam4);
            //            break;
            //    }

            //    var A = f.pt1.y*(f.pt2.z - f.pt3.z) + f.pt2.y*(f.pt3.z - f.pt1.z) + f.pt3.y*(f.pt1.z - f.pt2.z);
            //    var B = f.pt1.z*(f.pt2.x - f.pt3.x) + f.pt2.z*(f.pt3.x - f.pt1.x) + f.pt3.z*(f.pt1.x - f.pt2.x);
            //    var C = f.pt1.x*(f.pt2.y - f.pt3.y) + f.pt2.x*(f.pt3.y - f.pt1.y) + f.pt3.x*(f.pt1.y - f.pt2.y);
            //    var D = -(A*f.pt1.x + B*f.pt1.y + C*f.pt1.z);
             
            //    if (D < 0)
            //    {
            //        A = -A;
            //        B = -B;
            //        C = -C;
            //        D = -D;
            //    }
            //    if (0 * A + 0 * B + 10000 * C + 1 * D > 0)
            //    {
            //        f.DrawIt(eGraphics, light);
            //    }

            //}
           
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
            var matrixACT = MatrixReady(movex, movey, movez, scalex, scaley, scalez, anglex, angley, anglez);
            matrix.Clear();
            foreach (Edge t in edgelist)
                for (int j = 0; j < t.vertex.Count; j++)
                    t.vertex[j] = t.vertex[j].MultiplicateF(t.vertex[j], matrixACT);
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
            var result = new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            return matrix.Aggregate(result, MultiplicateM);
        }   
         


        private double[,] MultiplicateM(double[,] a, double[,] b)
        {
            var result = new double[4, 4];
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
            double[,] rotateX = { { 1, 0, 0, 0 }, { 0, Cx, -Sx, 0 }, { 0, Sx, Cx, 0 }, { 0, 0, 0, 1 } };
            double[,] rotateY = { { Cy, 0, Sy, 0 }, { 0, 1, 0, 0 }, { -Sy, 0, Cy, 0 }, { 0, 0, 0, 1 } };
            double[,] rotateZ = { { Cz, -Sz, 0, 0 }, { Sz, Cz, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            matrix.Add(rotateX);
            matrix.Add(rotateY);
            matrix.Add(rotateZ);
        }

        private void Move(double movex, double movey, double movez)
        {
            double[,] move = { { 1, 0, 0, 0},
                               { 0, 1, 0, 0 },
                               { 0, 0, 1, 0 },
                               { movex, movey, movez, 1 } };
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
