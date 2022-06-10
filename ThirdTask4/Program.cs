using System; 

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sum = 0;
            Console.WriteLine("Заполнение псевдослучайными числами матрицы заданного размера.");
            Console.WriteLine("Введите количество строк матрицы: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите количество стобцов матрицы: ");
            int c = int.Parse(Console.ReadLine());
            int[,] array = new int[l,c];
            for (l = 0; l < array.GetLength(0); l++)
            {
                for (c = 0; c < array.GetLength(1); c++)
                {
                    array[l, c] = r.Next(100);
                    sum += array[l, c];
                    Console.Write($"{ array[l, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов массива {sum}");
            Console.ReadKey();
        }
    }
}
