using Arif_ShapesGenerator;
using Arif_ShapesGenerator.Shapes;

Main();

void Main()
{
    ShapeHelper shapes = new ShapeHelper();
    
    var rectangle = new Rectangle(10,10,30,40);
    rectangle.draw();
    shapes.AddShape(rectangle);
    
    var square = new Square(15,30,35);
    square.draw();
    shapes.AddShape(square);
    
    var ellipse = new Ellipse(100,150,300,200);
    ellipse.draw();
    shapes.AddShape(ellipse);
    
    var circle = new Circle(1,1,300);
    circle.draw();
    shapes.AddShape(circle);
    
    var textBox = new Textbox(5, 5, 200, 100, "sample text");
    textBox.draw();
    shapes.AddShape(textBox);
    
    shapes.render();
    shapes.display();
    shapes.info();
    

}
