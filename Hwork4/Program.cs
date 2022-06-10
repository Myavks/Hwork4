using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Введите число N от 0 до которого вы будете угадывать");
            int n = int.Parse(Console.ReadLine());
            int num = r.Next(0,n);
            Console.WriteLine("Мы загадали число, попробуйте отгадать!");
            while (true)
            {
                string numUser = Convert.ToString(Console.ReadLine());
                if (String.IsNullOrWhiteSpace(numUser))
                {
                    Console.WriteLine($"Загаданное число {num} !");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    int nUser = int.Parse(numUser);
                    if (nUser > num)
                    {
                        Console.WriteLine("Число больше загаданного!");
                    }
                    if (nUser < num)
                    {
                        Console.WriteLine("Число меньше загаданного!");
                    }
                    if (nUser == num)
                    {
                        Console.WriteLine("Вы угадали число!");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
