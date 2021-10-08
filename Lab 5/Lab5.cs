using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Lab5
    {
        public static int findBigger(int a, int b)
        {

            if (a <= b )
            {
                return b;

            }
            else
            {
                return a;
            }

        }


        public static void Swap<T>(ref T a, ref T b) => (a, b) = (b, a);



        static bool fact(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;
        }


        static int Factorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }

        
        static int GetNOD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a == b)
                {
                    return a;
                }
                if (a > b)
                {
                    a = a % b;
                }
                if (a < b && a != 0)
                {
                    b = b % a;
                }
            }
            return Math.Max(a, b);
        }


        static long GetNumberInFibonacci(long n)
        {

            if (n == 1 || n == 0 || n == 2)
            {
                return 1;
            }

            return GetNumberInFibonacci(n - 1) + GetNumberInFibonacci(n - 2);

        }


        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");
            Console.WriteLine("\nВведите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            
            Console.WriteLine(findBigger(a, b));


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nВведите число a");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число b");
             b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Swap(ref a, ref b);
            Console.WriteLine($"{a}  {b}") ;


            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\nВведите число ");
             a = Convert.ToInt32(Console.ReadLine());
            bool flag = fact(ref a);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(a));




            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("\nВведите число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fact=" + Factorial(a));


            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Введите 2 числа");
            Console.WriteLine("Введите числа");
            int numberFirst = int.Parse(Console.ReadLine());
            int numberSecond = int.Parse(Console.ReadLine());
            int nod = GetNOD(numberFirst, numberSecond);
            Console.WriteLine("Их НОД = " + nod);


            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Введите n-ое число ряда Фибоначчи");
           long number = long.Parse(Console.ReadLine());
            Console.WriteLine("n-ое число Фибоначчи = " + GetNumberInFibonacci(number));


















            Console.ReadKey();
        }
    }
}
