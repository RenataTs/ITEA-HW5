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

        static int MinValue(ref int[,] array)
        {
            (int minI, int minJ) = MinI(ref array);

            return array[minI, minJ];
        }

        static int MaxValue(ref int[,] array)
        {
            (int maxI, int maxJ) = MaxI(ref array);

            return array[maxI, maxJ];
        }

        static (int, int) MinI(ref int[,] array)
        {
            int indexI = 0;
            int indexJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < array[indexI, indexJ])
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
            }

            return (indexI, indexJ);
        }

        static (int, int) MaxI(ref int[,] array)
        {
            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > array[maxI, maxJ])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        static int GreaterThanNeighborhood(ref int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > 0 && array[i - 1, j] >= array[i, j])
                    {
                        continue;
                    }

                    if (j > 0 && array[i, j - 1] >= array[i, j])
                    {
                        continue;
                    }

                    if (i < array.GetLength(0) - 1 && array[i + 1, j] >= array[i, j])
                    {
                        continue;
                    }

                    if (j < array.GetLength(1) - 1 && (array[i, j + 1] >= array[i, j]))
                    {
                        continue;
                    }

                    ++count;
                }
            }

            return count;
        }

        static int[,] ChangeAlongTheMainDiagonal(ref int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    Swap(ref array[i, j], ref array[j, i]);
                }
            }

            return array;
        }

        static void Main(string[] args)
        {

        }
    }
}
