using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Sphere3d
{
    public class Edge
    {
        List<Point3d> vertex = new List<Point3d>();
        //Point3d vertex1, vertex2;
        public Edge()
        {
          
        }
        public void  DrawEdge(Graphics g,Color color)
        {
            Pen pen = new Pen(color, 1);
            //g.DrawLines(
        }

    }
}
