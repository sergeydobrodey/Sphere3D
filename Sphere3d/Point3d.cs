using System;
using System.Drawing;

namespace Sphere3d
{
    public class Point3d
    {    
        public float x, y, z;
        const double W = 1;
        public Point3d(double x, double y, double z)
        {

            this.x = (float)x;
            this.y = (float)y;
            this.z = (float)z;
        }

        public Point3d Aksonometrik(double psi, double fi)
        {
            psi = Convert.ToDouble(psi) * Math.PI / 180;
            fi = Convert.ToDouble(fi) * Math.PI / 180;
            double Sp = Math.Sin(psi);
            double Cp = Math.Cos(psi);
            double Sf = Math.Sin(fi);
            double Cf = Math.Cos(fi);             
            double[,] matrix = { { Cp, Sf * Sp, 0, 0 },
                               { 0, Cf, 0, 0 },
                               { Sp, -Sf * Cp, 0, 0 },
                               { 0, 0, 0, 1 } };
            return MultiplicateF(this, matrix);
        }
       
        /// TODO: 
        
       
        public Point3d Kosougol(double l, double alpha)
        {
            alpha = Convert.ToDouble(alpha) * Math.PI / 180; 
            double C = Math.Cos(alpha);
            double S = Math.Sin(alpha);
            double[,] matrix = { { 1, 0, 0, 0 },
                               { l * C, l * S, 0, 0 }, 
                               { 0, 0, 1, 0 }, 
                               { 0, 0, 0, 1 } };
            return MultiplicateF(this, matrix);
        }

        public Point3d Perspect(double d,double q,double fi,double psi)       
        {
            fi = Convert.ToDouble(fi) * Math.PI / 180;
            psi = Convert.ToDouble(psi) * Math.PI / 180;
            double Sp = Math.Sin(psi);
            double Cp = Math.Cos(psi);
            double Sf = Math.Sin(fi);
            double Cf = Math.Cos(fi);
            double[,] matrix = { { 1, 0, 0, 0 },
                               { 0, 1, 0, 0 },
                               { 0, 0, 0,  1/d },
                               { 0, 0, 0, 1 } };
            double[,] matrixView = { { -Sp, -Cf * Cp, -Sf * Cp, 0 },
                                   { Cp, -Cf * Sp, -Sf * Sp, 0 },
                                   { 0, Sf, -Cf, 0 },
                                   { 0, 0, q, 1 } };
            Point3d correctPoint = MultiplicateF(this, matrixView);

            return new Point3d(correctPoint.x/(correctPoint.z/d+1),correctPoint.y/(correctPoint.z/d+1),0);
        }

        public Point3d MultiplicateF(Point3d vertex, double[,] ar)
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
            return (new Point3d((float)(result[0, 0]),(float)(result[1, 0]),(float)(result[2, 0])));

        }

        public PointF ToPoitntFxy()
        {
            return new PointF(this.x + 200, this.y + 200);
        }
        public PointF ToPoitntFxz()
        {
            return new PointF(this.x + 200, this.z + 200);
        }
        public PointF ToPoitntFyz()
        {
            return new PointF(this.y + 200, this.z + 200);
        }

    }
}
