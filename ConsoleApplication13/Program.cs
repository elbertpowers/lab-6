using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
     public class Program
    {
        static void Main(string[] args)
        {
            string answerRoll;

            Console.WriteLine("Welcome to Grand Circus Casino! Roll the dice? (y/n) :");
            answerRoll = Console.ReadLine();

            int rollNumber = 1;

            while (answerRoll == "y")
            {
                Console.WriteLine("Roll " + rollNumber);
                rollNumber = rollNumber + 1;
                Random rnd = new Random();


                int randomNumber = rnd.Next(1, 7);
                Console.WriteLine(randomNumber);
                int randomNumber2 = rnd.Next(1, 7);
                Console.WriteLine(randomNumber2);

                int diceSum = randomNumber + randomNumber2;
                switch (diceSum)
                {
                    case 2:
                    case 3:
                        Console.WriteLine("craps!\n");
                        break;
                    case 12: Console.WriteLine("box cars!\n"); break;

                }
                if (randomNumber + randomNumber2 == 2)
                {
                    Console.WriteLine("snake eyes!\n");
                }


                Console.WriteLine("Roll again? (y/n)");
                answerRoll = Console.ReadLine();
            }

            Console.WriteLine("end game");
        }
    }
}
