using System;

namespace ITEAhome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Helo! Enter you total price:");

            float i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case float n when (n >= 500):
                    {
                        Console.WriteLine("you discount 7% " + " Total pay: " + n * 0.93);
                        break;
                    }
                case float n when (n < 500 && n >= 400):
                    {
                        Console.WriteLine("you discount 5% " + " Total pay: " + n * 0.95);
                        break;
                    }
                case float n when (n < 400 && n >= 300):
                    {
                        Console.WriteLine("you discount 3% " + " Total pay: " + n * 0.97);
                        break;
                    }
                case float n when (n < 300 ):
                    { 
                        Console.WriteLine("you discount 0%" + " Total pay: " + n);
                    
                        break;
                    }

                    


                   /* int count = 5;
                     Random rnd = new Random();
                     int value = rnd.Next(0, 101);
                     Console.WriteLine(" ");
                     Console.WriteLine("Guess and enter number, from 0 to 100");

                     while (true)
                     {

                         int num = Convert.ToInt32(Console.ReadLine());

                         if (num < value)
                         {
                             count--;
                             Console.WriteLine("Wrong!!! My number is Bigger! You have: " + count + " assmits." );
                         }
                         if (num > value)
                         {
                             count--;
                             Console.WriteLine("Wrong!!! My number is Less! You have: " + count + " assmits.");
                         }

                         if (num == value)
                         {
                             Console.WriteLine("Bingo!!! YOU WIN");
                             break;
                         }

                         if (count==0)
                         {

                             Console.WriteLine("YOU LUSSE!!! Goodbye");
                             break;
                         }



                     }*/






















































































  
            }
        }
    }
}