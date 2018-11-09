using System;
using System.Collections.Generic;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(8);
            square.printArea();

            VectorAdder vectorAdder = new VectorAdder();
            List<double> vectorA = new List<double>(new double[] {1.3423432,2,3,4,5,6});
            List<double> vectorB = new List<double>(new double[] {6,5,4,3,2});
            IEnumerable<double> sumVector = vectorAdder.addVectors(vectorA, vectorB);
            foreach(double sum in sumVector)Console.WriteLine(sum);
            

        }
    }
}
