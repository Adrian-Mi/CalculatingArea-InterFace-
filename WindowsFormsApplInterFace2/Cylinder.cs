using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplInterFace2
{
    class Cylinder:Circle
    {
        private double height;

        public Cylinder() : base()
        {
            height = 1;
        }
        public Cylinder(int x, int y, double r, double h) : base(x, y, r)
        {
            height = h;
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public override double Area()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2) + 2 * Math.PI * Radius * height;
        }
        public override double  Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * height;
        }
        public override string Name
        {
            get
            {
                return "Cylinder";
            }
        }
        public override string ToString()
        {
            //return "Center=" + "(" + X + "," + Y + "); " + "Radius=" + radius; 
            return  base.ToString() + "Height=" + height; 
        }

    }
}
