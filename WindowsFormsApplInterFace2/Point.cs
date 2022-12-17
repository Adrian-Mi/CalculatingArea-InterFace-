using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplInterFace2
{
    class Point:IShape
    {
        private int x;
        private int y;
        //protected int x;//only The derive classes has the access to the private
        //                //members of the base class
        //protected int y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int a)
        {
            x = a;
            y = 0;
        }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Volume()
        {
            return 0;
        }
        public virtual string Name
        {
            get { return "Point"; }
        }

        
    }
}
