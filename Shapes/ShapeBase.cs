using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator.Shapes
{
    public class ShapeBase : ShapeHelper
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public string name;

        public ShapeBase()
        {
            map = new char[height, width];
        }

        public void GenerateInfo()
        {
            if (name == "Ellipse") GenerateInfoEllipse();
            else if (name == "Circle" || name == "Square") GenerateInfoSimple();
            else GenerateInfoDetail();
        }

        public void GenerateInfoEllipse()
        {
            Console.WriteLine($"{name} ({x},{y}) diameterH={width} diameterV={height}");
        }
        public void GenerateInfoDetail()
        {
            Console.WriteLine($"{name} ({x},{y}) width={width} height={height}");
        }
        public void GenerateInfoSimple()
        {
            Console.WriteLine($"{name} ({x},{y}) size={width}");
        }
    }
}
