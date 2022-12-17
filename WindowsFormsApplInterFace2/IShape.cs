using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplInterFace2
{
 public   interface IShape
    {
        double Area();
        double Volume();
        string Name { get; }
    }
}
