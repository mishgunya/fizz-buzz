using System;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fizz = "fizz";
            string buzz = "buzz";
            string fizz_buzz = "fizz buzz";
            Console.WriteLine("Введите число итераций < 100");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 100)
            {
                for (int i = 1; i < N; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine(fizz_buzz);
                    }

                    else if (i % 5 == 0)
                    {
                        Console.WriteLine(buzz);
                    }
                    else if (i % 3 == 0)
                    {

                        Console.WriteLine(fizz); ;

                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else
            {
                Console.WriteLine("Ваше число => 100");
            }
        }
    }
}
