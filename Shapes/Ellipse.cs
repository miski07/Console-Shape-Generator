using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator.Shapes
{
    public class Ellipse: ShapeBase
    {
        public Ellipse(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            name = "Ellipse";
        }

        public bool draw()
        {
            try
            {
                map = new char[height, width];
                double a = width / 2.0;
                double b = height / 2.0;
                double tolerance = 0.05;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double normalizedX = (x - a) * (x - a) / (a * a);
                        double normalizedY = (y - b) * (y - b) / (b * b);
                                                
                        double borderDistance = normalizedX + normalizedY;
                        if (Math.Abs(borderDistance - 1) < tolerance)
                        {
                            fill(y,x); 
                        }
                        else
                        {
                            empty(y, x); 
                        }
                    }
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
