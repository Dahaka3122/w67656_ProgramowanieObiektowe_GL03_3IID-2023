using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("1. Liczba parzysta ");
            Console.WriteLine("2. N liczb parzystych ");
            Console.WriteLine("4. Silnia ");
            Console.WriteLine("5. Gra ");
            var input = Console.ReadLine();

            switch (int.Parse(input))
            {
                case 1:
                    IsEven();
                    break;
                case 2:
                    DisplayEvenNumbers();
                    break;
                case 5:
                    Game();
                    break;
                case 0:
                    return;
            }

            Console.ReadKey();
        }

        private static void DisplayEvenNumbers()
        {
            Console.WriteLine("Podaj N");
            var input = Console.ReadLine();

            for (int i = 0; i <= int.Parse(input); i++)
            {
                if (IsEven(i))
                    Console.WriteLine(i);
            }
        }

        static void IsEven()
        {
            Console.WriteLine("Podaj liczbę");
            var input = Console.ReadLine();
            var number = int.Parse(input);
            int i = 1;
            while(i <= number)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void Game()
        {
            var random = new Random();

            var number = random.Next(1, 101);

            int count = 0;
            int shoot;
            do
            {
                count++;
                Console.WriteLine("Podaj liczbę");
                var input = Console.ReadLine();

                shoot = int.Parse(input);

                if (shoot > number)
                    Console.WriteLine("Za duża");
                else if (shoot < number)
                    Console.WriteLine("Za mała");

            }
            while (shoot != number);

            Console.WriteLine("Zgadłeś!");
            Console.WriteLine("Liczba prób: ", shoot);
        }


    }
}
