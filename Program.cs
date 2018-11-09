using System;
using System.Collections.Generic;

/*
Console app for findig area and perimeter of square.
In addition has a 1-d array adder which returns a thrid vector as result 
 */
namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfSquare = 8.343; //lenght of the side of the square
            var square = new Square(sideOfSquare);
            square.printAreaAndPerimeter();

            VectorAdder vectorAdder = new VectorAdder();
            List<double> vectorA = new List<double>(new double[] {1.3423432,2,3,4,5,6}); //first vector to be added
            List<double> vectorB = new List<double>(new double[] {6,5,4,3,2}); //second vector to be added
            IEnumerable<double> sumVector = vectorAdder.addVectors(vectorA, vectorB);
            foreach(double sum in sumVector)Console.WriteLine(sum);
            

        }
    }
}
