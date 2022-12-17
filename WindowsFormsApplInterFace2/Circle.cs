using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplInterFace2
{
    class Circle:Point
    {
        private double radius;
        public Circle() : base()
        {
            radius = 1;
        }
        //public Circle(int a)
        //{
        //    x = 1;
        //    y = 1;
        //    radius = a;
        //}
        public Circle(int a, int b, double r) : base(a, b)
        {
            radius = r;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double Diameter()
        {
            return 2 * radius;
        }
        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            //return "Center=" + "(" + X + "," + Y + "); " + "Radius=" + radius; 
            return "Center=" + base.ToString() + "Radius=" + radius;
        }
        public override string Name
        {
            get
            {
                return "Circle";
            }
        }
    }
}
