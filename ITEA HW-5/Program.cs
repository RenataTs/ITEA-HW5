using System;

namespace CW5
{
    class Program
    {
        static int[,] CreateArray(int a, int b)
        {
            int[,] array = new int[a, b];
            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Task1(ref int[,] array, int a, int b)
        {
            int min = array[0, 0];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }

        static int Task2(ref int[,] array, int a, int b)
        {
            int max = array[0, 0];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        static (int, int) Task3(ref int[,] array, int a, int b)
        {
            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (array[i, j] < array[indexA, indexB])
                    {
                        indexA = i;
                        indexB = j;
                    }
                }
            }

            return (indexA, indexB);
        }

        static (int, int) Task4(ref int[,] array, int a, int b)
        {
            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (array[i, j] > array[indexA, indexB])
                    {
                        indexA = i;
                        indexB = j;
                    }
                }
            }

            return (indexA, indexB);
        }

        static void Task5(ref int[,] array, int a, int b)
        {
            int count = 0;

            for (var i = 1; i < a; i++)
            {
                for (var j = 1; j < b; j++)
                {
                }
            }

            Console.WriteLine(count);
        }

        static int[,] Task6(ref int[,] array, int a, int b)
        {
            for (var i = 0; i < a; i++)
            {
                for (var j = i + 1; j < b; j++)
                {
                    Swap(ref array[i, j], ref array[j, i]);
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            int[,] array = CreateArray(a, b);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Task1(ref array, a, b);

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("\t", array[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
