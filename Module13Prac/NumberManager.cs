using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13.Prac
{
    class NumberManager
    {
        private List<int> numbers;

        public NumberManager(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public void PrintSecondMaxValueAndPosition()
        {
            int secondMaxValue = numbers.OrderByDescending(n => n).Skip(1).First();
            int secondMaxIndex = numbers.LastIndexOf(secondMaxValue);

            Console.WriteLine($"Второе максимальное значение: {secondMaxValue}");
            Console.WriteLine($"Позиция второго максимального значения: {secondMaxIndex}");
        }

        public void RemoveOddNumbers()
        {
            numbers.RemoveAll(n => n % 2 != 0);
        }

        public void PrintNumbers()
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

    }
}
