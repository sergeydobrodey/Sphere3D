using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sphere3d
{
    public class Point3d
    {
        public
         float x, y, z;

        public Point3d(double x, double y, double z)
        {

            this.x = (float)x;
            this.y = (float)y;
            this.z = (float)z;
        }
    }
}
