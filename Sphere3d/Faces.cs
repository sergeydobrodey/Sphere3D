using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Sphere3d
{
    class Faces
    {
        public Point3d pt1;
        public Point3d pt2;
        public Point3d pt3;           
        public Point3d pt4;        
        public Faces(Point3d pt1, Point3d pt2, Point3d pt3, Point3d pt4)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.pt3 = pt3;
            this.pt4 = pt4;
        }
        public void DrawIt(Graphics exy,Graphics exz,Graphics eyz,Color color)
        {
            //e.DrawClosedCurve(new Pen(color, 1), new PointF[] { pt1.ToPoitntF(), pt2.ToPoitntF(), pt3.ToPoitntF(), pt4.ToPoitntF() });     
            exy.DrawLines(new Pen(color, 1), new PointF[] { pt1.ToPoitntFxy(), pt2.ToPoitntFxy(), pt3.ToPoitntFxy(), pt4.ToPoitntFxy(), pt1.ToPoitntFxy() });
            exz.DrawLines(new Pen(color, 1), new PointF[] { pt1.ToPoitntFxz(), pt2.ToPoitntFxz(), pt3.ToPoitntFxz(), pt4.ToPoitntFxz(), pt1.ToPoitntFxz() });
            eyz.DrawLines(new Pen(color, 1), new PointF[] { pt1.ToPoitntFyz(), pt2.ToPoitntFyz(), pt3.ToPoitntFyz(), pt4.ToPoitntFyz(), pt1.ToPoitntFyz() });
            //e.FillPolygon(new SolidBrush(color), new PointF[] { pt1.ToPoitntF(), pt2.ToPoitntF(), pt3.ToPoitntF(), pt4.ToPoitntF() }, System.Drawing.Drawing2D.FillMode.Alternate);
        }
    }
}
