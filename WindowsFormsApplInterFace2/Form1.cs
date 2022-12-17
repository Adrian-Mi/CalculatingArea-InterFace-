using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplInterFace2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point(10, 20);
            Circle c = new Circle(5, 7, 10);
            Cylinder y = new Cylinder(4, 3, 10, 15);
            IShape[] arrayofShape = new IShape[3];
            arrayofShape[0] = p;
            arrayofShape[1] = c;
            arrayofShape[2] = y;
            string output = "";
            foreach(IShape w in arrayofShape)
            {
                output += w.Name + "\nArea=" + w.Area() + "\nVolume=" + w.Volume() + "\n\n";
            }
            MessageBox.Show(output);
        }
    }
}
