using System;

namespace _4._2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(1, 10);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            int count = 0;
            foreach (int item in mas)
            {
                if (item == 7)
                    count++;
            }
            Console.WriteLine("колличесто элементов равных цифре 7= " + count);
        }
    }
}
