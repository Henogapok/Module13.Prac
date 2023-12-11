using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13.Prac
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 4, 3, 5, 7, };

            NumberManager numberManager = new NumberManager(numbers);

            numberManager.PrintSecondMaxValueAndPosition();
            numberManager.RemoveOddNumbers();

            Console.WriteLine("Коллекция после удаления нечетных элементов:");
            numberManager.PrintNumbers();




            List<double> doubles = new List<double> { 1.5,3.0, 3.8, 12.2, 26.7 };

            DoubleManager doubleManager = new DoubleManager(doubles);

            doubleManager.PrintGreaterThanAverage();

        }
    }
}