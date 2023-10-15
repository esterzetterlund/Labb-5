namespace Labb_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);   // create an object of the circle class with radius 5
            Circle circle2 = new Circle(6);   // create an object of the circle class with radius 6
                                              
            Console.WriteLine("Arean på cirkeln med radie 5 är: " + circle1.getArea() + " cm2");  // calculate and write to the user the area of the circle
            Console.WriteLine("Arean på cirkeln med radie 6 är: " + circle2.getArea() + " cm2");  // calculate and write to the user the area of the circle

            Console.WriteLine("Omkretsen på cirkeln med radie 5 är: " + circle1.getPerimeter() + " cm");  // calculate and write to the user the perimeter of the circle
            Console.WriteLine("Omkretsen på cirkeln med radie 6 är: " + circle2.getPerimeter() + " cm");  // calculate and write to the user the perimeter of the circle

            Console.WriteLine("Volymen på cirkeln med radie 5 är: " + circle1.getVolume() + " cm3");   // calculate and write to the user the volume of the circle
            Console.WriteLine("Volymen på cirkeln med radie 6 är: " + circle2.getVolume() + " cm3");   // calculate and write to the user the volume of the circle

            Triangle triangle = new Triangle();  // create an object of the triangle class 

            Console.WriteLine("Arean på triangeln är: " + triangle.getArea() + " cm2");  // calculate and write to the user the area of the triangle
            Console.WriteLine("Omkretsen på triangeln är: " + triangle.getPerimeter() + " cm");  // calculate and write to the user the perimeter of the triangle

        }
    }
    public class Circle                           // a class that representing a circle
    {
        public float _pi = 3.141f;                // a field that stores pi
        private int _radius;                      // a field that stores the radius of the circle

        public Circle(int radius)                 // a constructor that takes radius as a parameter
        {
            _radius = radius;
        }
        public float getArea()                   // a method that returns the area of the circle
        {
            return _radius * _radius * _pi;
        }
        public float getPerimeter()              // a method that returns the perimeter of the circle
        {
            return 2 * _pi * _radius;
        }
        public float getVolume()                 // a method that returns the volume of the circle
        {
            return 4 * _pi * _radius * _radius * _radius / 3;
        }


    }
    public class Triangle                        // a class that representing a triangle
    {
        public float _base = 3;                  // a field that stores base
        private int _height = 6;                 // a field that stores height
        public float getArea()                   // a method that returns the area of the triangle
        {
            return (_base * _height)/2;
        }
        public float getPerimeter()              // a method that returns the perimeter of the triangle
        {
            return _base + _height + _height;
        }
    }
}