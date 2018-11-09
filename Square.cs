using System;

namespace consoleApp
{
    class Square
    {
        private double _side;

        public Square(double side)
        {
            this._side = side;
        }

        public void printArea()
        {
            Console.WriteLine($"Perimeter = {4*_side} area= {_side*_side}");
        }
    }
}