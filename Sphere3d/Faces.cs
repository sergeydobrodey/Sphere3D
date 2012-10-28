using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Sphere3d
{
    internal class Faces
    {
        public Point3d pt1;
        public Point3d pt2;
        public Point3d pt3;
        public Point3d pt4;
        public Color FaceColor;

        public Faces(Point3d pt1, Point3d pt2, Point3d pt3, Point3d pt4, Color color)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.pt3 = pt3;
            this.pt4 = pt4;
            this.FaceColor = color;
        }

        public double GetDepth()
        {
            double minZ = pt1.z;
            var itemsList = new List<Point3d> {pt1, pt2, pt3, pt4};
            foreach (var point3D in itemsList)
            {
                if (point3D.z < minZ) minZ = point3D.z;
            }
            return minZ;
        }

        public void LightDiffuse()
        {
            var vectorLight = new Point3d(1000 - pt1.x, 1000 - pt1.y, 1000 - pt1.z);
            var vectorPoint = new Point3d(pt1.x, pt1.y, pt1.z);
            double cosTetta = (vectorLight.x * vectorPoint.x + vectorLight.y * vectorLight.y +
                              vectorLight.z * vectorPoint.z) / (
                                                               Math.Sqrt(Math.Pow(vectorLight.x, 2) +
                                                                         Math.Pow(vectorLight.y, 2) +
                                                                         Math.Pow(vectorLight.z, 2)) *
                                                               Math.Sqrt(Math.Pow(vectorPoint.x, 2) +
                                                                         Math.Pow(vectorPoint.y, 2) +
                                                                         Math.Pow(vectorPoint.z, 2)));
            double lighting = 0 + 70 * 0.6 * cosTetta;
            lighting = lighting > 255 ? 255 : lighting;
            lighting = lighting < 0 ? 0 : lighting;
            FaceColor = Color.FromArgb(Convert.ToInt32(lighting), Convert.ToInt32(lighting), Convert.ToInt32(lighting));
        }

        public void DrawIt(Graphics e, bool light)
        {   
           if (light) e.FillClosedCurve(new SolidBrush(FaceColor), new[] { pt1.ToPoitntFxy(), pt2.ToPoitntFxy(), pt3.ToPoitntFxy(), pt4.ToPoitntFxy(),pt1.ToPoitntFxy()}, FillMode.Winding);
           else e.DrawLines(new Pen(FaceColor,1), new[] { pt1.ToPoitntFxy(), pt2.ToPoitntFxy(), pt3.ToPoitntFxy(), pt4.ToPoitntFxy(), pt1.ToPoitntFxy() });
           //e.DrawClosedCurve(new Pen(FaceColor, 1), new[] { pt1.ToPoitntFxy(), pt2.ToPoitntFxy(), pt3.ToPoitntFxy(), pt4.ToPoitntFxy() });
        }
    }
}
