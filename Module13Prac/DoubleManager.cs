using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13.Prac
{
    class DoubleManager
    {
        private List<double> doubles;

        public DoubleManager(List<double> doubles)
        {
            this.doubles = doubles;
        }

        public void PrintGreaterThanAverage()
        {
            double average = doubles.Average();
            var greaterThanAverage = doubles.Where(d => d > average);

            Console.WriteLine("Элементы, значение которых больше среднего арифметического:");
            foreach (var number in greaterThanAverage)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
