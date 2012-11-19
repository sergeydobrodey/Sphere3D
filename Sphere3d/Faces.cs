using System;
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
        private float _A;
        private float _B;
        private float _C;
        private float _D;
        public Faces(Point3d pt1, Point3d pt2, Point3d pt3, Point3d pt4, Color color)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.pt3 = pt3;
            this.pt4 = pt4;
            FaceColor = color;
        }


    

        public void LightDiffuse(Point3d vectorLight)
        {
            //var vectorLight = new Point3d(0,200,200);
            var vectorPoint = new Point3d((pt1.x + pt3.x) / 2, (pt1.y + pt3.y) / 2, (pt1.z+pt3.z)/2);
            double cosTetta = (vectorLight.x * vectorPoint.x + vectorLight.y * vectorPoint.y +
                              vectorLight.z * vectorPoint.z) / (
                                                               Math.Sqrt(Math.Pow(vectorLight.x, 2) +
                                                                         Math.Pow(vectorLight.y, 2) +
                                                                         Math.Pow(vectorLight.z, 2)) *
                                                               Math.Sqrt(Math.Pow(vectorPoint.x, 2) +
                                                                         Math.Pow(vectorPoint.y, 2) +
                                                                         Math.Pow(vectorPoint.z, 2)));
            double lighting = 100 + 100 * 0.6 * cosTetta;
            lighting = lighting > 255 ? 255 : lighting;
            lighting = lighting < 0 ? 0 : lighting;
            FaceColor = Color.FromArgb(Convert.ToInt32(lighting), Convert.ToInt32(lighting), Convert.ToInt32(lighting));
        }

        public void DrawIt(Graphics e, bool light)
        {   
           if (light) e.FillClosedCurve(new SolidBrush(FaceColor), new[] { pt1.ToPoitntFxy(), pt2.ToPoitntFxy(), pt3.ToPoitntFxy(), pt4.ToPoitntFxy(),pt1.ToPoitntFxy()}, FillMode.Alternate);
           else e.DrawLines(new Pen(FaceColor,1), new[] { pt1.ToPoitntFxy(), pt2.ToPoitntFxy(), pt3.ToPoitntFxy(), pt4.ToPoitntFxy(), pt1.ToPoitntFxy() });
          
        }

        public void RobertsSet(Point3d innerPoint)
        {
          
            _A = pt1.y * (pt3.z - pt4.z) + pt3.y * (pt4.z - pt1.z) + pt4.y * (pt1.z - pt3.z);
            _B = pt1.z * (pt3.x - pt4.x) + pt3.z * (pt4.x - pt1.x) + pt4.z * (pt1.x - pt3.x);
            _C = pt1.x * (pt3.y - pt4.y) + pt3.x * (pt4.y - pt1.y) + pt4.x * (pt1.y - pt3.y);
            _D = -(_A * pt4.x + _B * pt4.y + _C * pt4.z);
            if (innerPoint.x * _A + innerPoint.y * _B + innerPoint.z * _C + _D > 0) return;
            _A = -_A;
            _B = -_B;
            _C = -_C;
            _D = -_D;
        }

        public bool RobertsCheck()
        {
            //return  0 * _A + 0 * _B+1 * _C + 0 * _D > 0;
            return _C > 0;
        }
    }
}
