using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

/*
Represents a vector adder that takes two vectors and returns the sum
Limits: both vectors converted to double format and max value of vector member = 1.79769313486232E+308
 */
namespace consoleApp
{
    class VectorAdder
    {
        public IEnumerable<double> addVectors(IEnumerable<double> magnitudes, IEnumerable<double> phases)
        {
            return magnitudes.Zip(phases, (a , b) => a +b);//add corresponding members of both vectors
        }
    }
}