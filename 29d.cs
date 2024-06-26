//1
using System;

namespace ex4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            array_double_1d ob = new array_double_1d();
            ob.setNumbers(numbers);
            double min = ob.FindMin();
            double max = ob.FindMax();

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }
}
//2
using System;

namespace ex4
{
    public class array_double_1d
    {
        private double[] numbers;

        public void setNumbers(double[] arr)
        {
            numbers = arr;
        }

        public double FindMin()
        {
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public double FindMax()
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
