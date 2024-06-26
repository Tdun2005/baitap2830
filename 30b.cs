//1
using System;

namespace ex4
{
    public class array_float_2d
    {
        public static float[,] nhapmangfloat2d(int rows, int cols)
        {
            float[,] array = new float[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Nhập giá trị tại [{i},{j}]: ");
                            array[i, j] = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                        }
                    }
                }
            }
            return array;
        }
    }
}
//2
using System;

namespace ex4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int m = EditNumbers.nhapsonguyenduong();
            int n = EditNumbers.nhapsonguyenduong();
            float x = EditNumbers.nhapsothuc4byte();

            Console.WriteLine("Giá trị của m: " + m.ToString());
            Console.WriteLine("Giá trị của n: " + n.ToString());
            Console.WriteLine("Giá trị của x: " + x.ToString());

            float[,] array = array_float_2d.nhapmangfloat2d(m, n);
        }
    }
}
