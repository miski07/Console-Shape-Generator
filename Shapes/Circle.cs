using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator.Shapes
{
    public class Circle: ShapeBase
    {
        private Ellipse ellipse;
        public Circle(int x, int y,int diameter)
        {
            this.x = x;
            this.y = y;
            this.width = diameter;
            this.height = diameter;
            this.name = "Circle";
            ellipse = new Ellipse(x,y,diameter, diameter);
        }

        //reuse ellipse 
        public bool draw()
        {
            var result= ellipse.draw();
            map = ellipse.map;
            return result;
        }

    }
}
