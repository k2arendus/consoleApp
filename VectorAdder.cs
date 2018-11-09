using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;


namespace consoleApp
{
    class VectorAdder
    {
        public IEnumerable<double> addVectors(IEnumerable<double> magnitudes, IEnumerable<double> phases)
        {
            return magnitudes.Zip(phases, (a , b) => a +b);
        }
    }
}