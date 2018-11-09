using System;
/*
Represents a square and has a method to find its perimeter and area
Limits: max side lenght = 1.34078079299426E+154
 */
namespace consoleApp
{
    class Square
    {
        private double _side;

        public Square(double side)
        {
            this._side = side;
        }

        public void printAreaAndPerimeter()
        {
            Console.WriteLine($"Perimeter = {4*_side} area= {_side*_side}");
        }
    }
}