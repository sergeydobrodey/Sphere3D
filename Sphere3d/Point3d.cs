using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public Point3d Kosougol(double l, double alpha)
        {
            alpha = Convert.ToDouble(alpha) * Math.PI / 180; 
            double C = Math.Cos(alpha);
            double S = Math.Sin(alpha);
            double[,] matrix = { { 1, 0, 0, 0 },
                               { 0, 1, 0, 0 }, 
                               { l * C, l * S, 0, 0 }, 
                               { 0, 0, 0, 1 } };
            return MultiplicateF(this, matrix);
        }

        public Point3d Perspect(double d)
        {
            double[,] matrix = { { 1, 0, 0, 0 },
                               { 0, 1, 0, 0 },
                               { 0, 0, 1, 1 / d },
                               { 0, 0, 0, 0 } };
            return MultiplicateF(this, matrix);
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
    }
}
