using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02._10._2021
{
    class Program
    {
        public static void Yravnenie(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - (4 * a * c);

            if (D < 0)
            {

                Console.WriteLine("Действительных корней нет");


            }
            else
            {

                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                double[] array = { x1, x2 };

                Console.WriteLine(" x1= {0}\n x2= {1}", x1, x2);

            }

        }

        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }


        static void Sum(int[] arr, ref long p, out double a)
        {
            int Sum = 0;
            a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Sum = ++arr[i];
                p = p * arr[i];
                a = a + arr[i];

            }

            a = a / arr.Length;
            Console.WriteLine($"Сумма элементов: { Sum}");
            Console.WriteLine($"Произведение элементов: { p}");

        }





        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");
            Console.WriteLine("вычисления значения функции y=ax2+bx+c при любом значении a,b,c");
            Console.WriteLine("\nВведите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            Yravnenie(a, b, c);



            Console.WriteLine("\nЗадание 2");
            Random rand = new Random();
            int[] numbers = new int[20];
            int killMe;
            int forWhat;
            for (int i = 0; i < numbers.Length; i++)
            {
                int helpMe = rand.Next(1, 100);
                if (!numbers.Contains(helpMe))
                {
                    numbers[i] = helpMe;
                    Console.Write(numbers[i] + "  ");
                }
                else
                {
                    i--;
                }

            }
            Console.WriteLine("\nВведите 1 число ");
            killMe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите 2 число ");
            forWhat = Convert.ToInt32(Console.ReadLine());
            int dop = forWhat;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (killMe == numbers[i])
                {
                    dop = numbers[i];
                    numbers[i] = forWhat;


                }

                else if (forWhat == numbers[i])
                {
                    numbers[i] = dop;

                }

                Console.Write(numbers[i] + "  ");

            }


            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(mas);
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();


            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Введите количество элементов в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int m = rand.Next(-100, 100);
                if (!arr.Contains(m))
                {
                    arr[i] = m;
                }
                else
                {
                    i--;
                }
                Console.WriteLine(arr[i]);
            }
            long p = 1;
            double arifm;
            Sum(arr, ref p, out arifm);
            Console.WriteLine("Среднее арифметическое " + arifm);



            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("введите число от 0 да 9 : ");
            string str = Console.ReadLine().ToLower();
            bool flag = true;
            bool run = true;
            while (flag)
            {
                if (!run)
                {
                    Console.WriteLine("Введите число от 0 до 9. Если хотите завершить, напишите exit или закрыть!");
                    str = Console.ReadLine().ToLower();
                    Console.Clear();
                }
                else
                {
                    run = false;
                }
                try
                {
                    Console.Clear();
                    if ((str == "exit") || (str == "закрыть"))
                    {
                        flag = false;
                        break;
                    }
                    int number = int.Parse(str);
                    if (number < 0 || number > 9)
                    {
                        throw new Exception("Вы ввели неплавильное число!");
                    }
                    switch (number)
                    {

                        case 0:
                            Console.WriteLine(" ##\n#  #\n#  #\n#  #\n ##");
                            break;
                        case 1:
                            Console.WriteLine("  #\n ##\n# #\n  #\n  #");
                            break;
                        case 2:
                            Console.WriteLine("###\n# #\n # \n#\n###");
                            break;
                        case 3:
                            Console.WriteLine("###\n  #\n # \n  #\n###");
                            break;
                        case 4:
                            Console.WriteLine("# #\n# #\n###\n  #\n  #");
                            break;
                        case 5:
                            Console.WriteLine("###\n#\n###\n  #\n###");
                            break;
                        case 6:
                            Console.WriteLine("###\n#\n###\n# #\n###");
                            break;
                        case 7:
                            Console.WriteLine("###\n  #\n #\n#\n#");
                            break;
                        case 8:
                            Console.WriteLine("###\n# #\n # \n# #\n###");
                            break;
                        default:
                            Console.WriteLine("###\n# #\n###\n  #\n###");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("ERROR");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;


                }






                    Console.ReadKey();
                
            }
        }
    }
}