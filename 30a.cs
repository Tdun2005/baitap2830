//1
using System;

namespace ex4
{
    public static class EditNumbers
    {
        public static int nhapsonguyenduong()
        {
            int n;
            while (true)
            {
                try
                {
                    Console.Write("Nhập số nguyên dương: ");
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Số nhập vào phải lớn hơn 0.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
            return n;
        }

        public static float nhapsothuc4byte()
        {
            float x;
            while (true)
            {
                try
                {
                    Console.Write("Nhập số thực 4 byte: ");
                    x = float.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
            return x;
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
        }
    }
}
