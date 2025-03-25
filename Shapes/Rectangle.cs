using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator.Shapes
{
    public class Rectangle: ShapeBase
    {
        public Rectangle(int x, int y,int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.name = "Triangle";
        }

        public bool draw() {
            try
            {
                if (width < 0 || height < 0) return true;
                map = new char[height,  width];

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                        {
                            fill(i,j);
                        }
                        else
                        {
                            empty(i, j);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
