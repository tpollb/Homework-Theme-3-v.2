using System;

namespace Homework_Theme_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int MaxUserNames = -1;
            int PlayerNumber = 0;

            int i;

            int MinGameNumber = 12;
            int MaxGameNumber = 120;

            var random = new Random();
            int GameNumber = random.Next(MinGameNumber, MaxGameNumber);

            int flag = -1;

            //определение количества имён имён
            while (MaxUserNames < 1 || MaxUserNames > 10)
            {
                Console.WriteLine("Enter number of players 1 to 10: ");
                MaxUserNames = int.Parse(Console.ReadLine());
            }

            string[] UserName = new string[MaxUserNames];
            //запись имён

            for (i = 0; i < MaxUserNames; i++)
            {
                Console.WriteLine($"Enter user name {i + 1}");
                UserName[i] = Console.ReadLine();
            }

            Console.WriteLine($"Game number is: {GameNumber}");

            //основной цикл

            for (i = 0; i < (MaxGameNumber - MinGameNumber); i++)
            {
                if (flag == MaxUserNames - 1)
                {
                    flag = 0;
                }
                else flag++;

                //Console.WriteLine($"{flag}");
                Console.WriteLine($"Player {UserName[flag]} your turn. Enter 1 to 4: ");
                PlayerNumber = int.Parse(Console.ReadLine());

                while (PlayerNumber < 1 || PlayerNumber > 4)
                {
                    Console.WriteLine($"Player {UserName[flag]} your turn. Enter 1 to 4: ");
                    PlayerNumber = int.Parse(Console.ReadLine());
                }

                GameNumber = GameNumber - PlayerNumber;
                Console.WriteLine($"Game number is: {GameNumber}");


                if (GameNumber <= 0)
                {
                    Console.WriteLine($"Player {UserName[flag]} win");
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
