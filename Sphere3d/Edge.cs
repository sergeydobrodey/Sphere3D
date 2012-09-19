using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Sphere3d
{
    public class Edge
    {
        public List<Point3d> vertex = new List<Point3d>();
        int id;
        public Edge(int id)
        {
            this.id = id;
        }
    }
}
