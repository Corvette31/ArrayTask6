using System;

namespace ArrayTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 30;
            int itemMinValue = 0;
            int itemMaxValue = 101;
            int[] array = new int[arraySize];

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(itemMinValue, itemMaxValue);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nОтсортированный массив\n");


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                Console.Write(array[i] + " ");
            }
        }
    }
}
