using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator.Shapes
{
    public class Textbox: ShapeBase
    {
        Rectangle rectangle;
        string text;

        public Textbox(int x, int y, int width, int height, string text)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.text = text;
            this.name = "Textbox";
            rectangle = new Rectangle(x, y, width, height);
        }

        //reuse rectangle and draw word
        public bool draw()
        {
            var result = rectangle.draw();
            this.map = rectangle.map;
            text= text.Replace(' ', '_');
            if(text.Length < width - 2)
            {
                var centerX = width / 2;
                var centerY = height / 2;
                int startX =  centerX - Convert.ToInt32(Math.Ceiling((decimal)text.Length / 2));
                if(startX > 0)
                {
                    for(int i=0; i<text.Length; i++)
                    {
                        fill(centerY,startX , text[i]);
                        startX++;
                    }
                }                
            }
            return result;
        }
    }
}
