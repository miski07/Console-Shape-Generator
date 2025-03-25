using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator.Shapes
{
    public class Square: ShapeBase
    {
        Rectangle square;        
        public Square(int x, int y,int width)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = width;
            this.name = "Square";
            this.square = new Rectangle(x, y, width, width);
        }

        //reuse rectangle
        public bool draw()
        {
            var result = square.draw();
            
            this.map = square.map;
            return result;
        }
    }
}
