using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение наименьшего элемента в введенной последовательности.");
            Console.WriteLine("Введите длину последовательности");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент последовательности: ");
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine($"Наименьший элемент последовательности: {min}");
            Console.ReadKey();
        }
    }
}
