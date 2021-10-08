using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;











// Вообще не поняла эти задания. Нашла в интернете. Из всего ниже написанного понимаю процентов 70 из первого и процентов 30 из второго. Сделала все, что могла. Понять и простить












namespace Homework
{
    class Homework
    {
        static void quickSort(int[] a, int l, int r)
        {
            Console.WriteLine("\n***************************************");
            Console.WriteLine("\n***************************************");
            int temp;
            int x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }
        static void Main(string[] args)
        {
           
            int size;
            size = Convert.ToInt32(Console.ReadLine());
           
            string str = Console.ReadLine();
       
            string[] mas = str.Split(' ');
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(mas[i]);
            }

            quickSort(a, 0, size - 1);
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }



           

            Console.WriteLine("\n***************************************");
            Console.WriteLine("\n***************************************");
            int verticesCount = 10;
            int[,] adjacency = new int[verticesCount, verticesCount];
            Random rnd = new Random();

            // Псевдослучайное заполнение матрицы смежности
            for (int row = 0; row < verticesCount - 1; row++)
                for (int col = row + 1; col < verticesCount; col++)
                    if (rnd.Next(3) < 1)
                    {
                        adjacency[row, col] = 1;
                        adjacency[col, row] = 1;
                    }

            Console.WriteLine("\n***************************************");
            Console.WriteLine("Обход графа в глубину с печатью вершин.");
            PrintDeep(adjacency);

            Console.WriteLine("\n***************************************");
            Console.WriteLine("Обход графа в ширину с печатью вершин.");

            PrintWidth(adjacency);

            Console.ReadKey();
        }

        static bool IsVerifyGraf(int[,] adjacency)
        {
            int verticesCount = adjacency.GetLength(0);
            if (verticesCount != adjacency.GetLength(1))
            {
                Console.WriteLine("Ошибка! Матрица смежности неверной размерности!");
                return false;
            }
            bool error = false;
            for (int row = 0; row < verticesCount; row++)
            {
                if (adjacency[row, row] != 0)
                    error = true;
                for (int col = row + 1; col < verticesCount; col++)
                    if (adjacency[row, col] != adjacency[col, row])
                    {
                        error = true;
                        break;
                    }
                if (error)
                    break;
            }
            if (error)
            {
                Console.WriteLine("Ошибка! Матрица смежности ошибочна!");
                return false;
            }
            return true;
        }

        static void PrintVert(int Vert, int[,] adjacency)
        {
            if (!IsVerifyGraf(adjacency))
                return;
            Console.Write($"Вершина {Vert}. Смежна с вершинами:");
            int verticesCount = adjacency.GetLength(0);
            for (int col = 0; col < verticesCount; col++)
                if (adjacency[Vert, col] != 0)
                    Console.Write($"  {col}");
        }

        static void PrintDeep(int[,] adjacency)
        {
            if (!IsVerifyGraf(adjacency))
                return;

            int verticesCount = adjacency.GetLength(0);

            List<int> vertList = new List<int>();
            Stack<int> vertStack = new Stack<int>();

            for (int vert = 0; vert < verticesCount; vert++)
            {
                //if (vertList.IndexOf(vert) >= 0)
                //    continue;

                int vertCurr = vert;
                while (true)
                {
                    if (vertList.IndexOf(vertCurr) < 0)
                    {
                        PrintVert(vertCurr, adjacency);
                        Console.WriteLine();
                        vertList.Add(vertCurr);

                        for (int col = 0; col < verticesCount; col++)
                            if (adjacency[vertCurr, col] != 0 && vertList.IndexOf(col) < 0)
                                vertStack.Push(col);
                    }

                    if (vertStack.Count == 0)
                        break;

                    vertCurr = vertStack.Pop();
                }

            }

        }

        static void PrintWidth(int[,] adjacency)
        {
            if (!IsVerifyGraf(adjacency))
                return;

            int verticesCount = adjacency.GetLength(0);

            List<int> vertList = new List<int>();
            Queue<int> vertQueue = new Queue<int>();

            for (int vert = 0; vert < verticesCount; vert++)
            {
                //if (vertList.IndexOf(vert) >= 0)
                //    continue;

                int vertCurr = vert;
                while (true)
                {
                    if (vertList.IndexOf(vertCurr) < 0)
                    {
                        PrintVert(vertCurr, adjacency);
                        Console.WriteLine();
                        vertList.Add(vertCurr);

                        for (int col = 0; col < verticesCount; col++)
                            if (adjacency[vertCurr, col] != 0 && vertList.IndexOf(col) < 0)
                                vertQueue.Enqueue(col);
                    }

                    if (vertQueue.Count == 0)
                        break;

                    vertCurr = vertQueue.Dequeue();






                    
                }

            }
        }
    }
}
