using Arif_ShapesGenerator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arif_ShapesGenerator
{
    public class ShapeHelper
    {
        public char[,] map;
        public ICollection<ShapeBase> shapes;

        public ShapeHelper()
        {
            shapes = new List<ShapeBase>();
        }

        public void render()
        {
            if (shapes.Count < 1) return;

            var canvasWidth = shapes.Max(shape => shape.x) + shapes.Max(shape=>shape.map.GetLength(0)) ;
            var canvasHeight = shapes.Max(shape => shape.y) + shapes.Max(shape => shape.map.GetLength(1)) ;
            map = new char[canvasWidth, canvasHeight];
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    empty(i, j);
                }
            }
            foreach (ShapeBase shape in shapes)
            {
                for (int i = 0; i < shape.map.GetLength(0); i++)
                {
                    for (int j = 0; j < shape.map.GetLength(1); j++)
                    {
                        if (map[shape.x + i -1, shape.y + j-1] != ' ') continue;
                        else fill(shape.x + i - 1, shape.y + j - 1, shape.map[i,j]);
                    }
                }
            }
        }

        public void display()
        {
            if (map is null) return;

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void fill(int x, int y)
        {
            map[x, y] = 'X';
        }
        public void empty(int x, int y)
        {
            map[x, y] = ' ';
        }
        public void fill(int x, int y, char c)
        {
            map[x,y]= c;
        }

        public void info()
        {
            Console.WriteLine();
            Console.WriteLine("======================");
            if(shapes.Count > 0)
            {
                foreach(var shape in shapes)
                {
                    shape.GenerateInfo();
                }
            }
        }

        public void AddShape(ShapeBase shape)
        {
            shapes.Add(shape);
        }
    }
}
