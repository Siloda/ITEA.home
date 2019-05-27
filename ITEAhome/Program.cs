using System;

namespace ITEAhome
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Helo! Enter you total price:");
            int totalPriсe = Convert.ToInt32(Console.ReadLine());
            
            switch (totalPriсe)
            { 
                                              
                case 500:
                    {
                        Console.WriteLine("you discount: 7% " + " Total Pay: " + (totalPriсe * 0.93 + "$"));
                        break;
                    }
                case 400:
                    {
                        Console.WriteLine("you discount: 5% " + " Total Pay: " + (totalPriсe * 0.95 + "$"));
                        break;
                    }
                case 300:
                    {
                        Console.WriteLine("you discount: 3% " + " Total Pay: " + (totalPriсe * 0.93 + "$"));
                        break;
                    }
                case 100:
                    {
                        Console.WriteLine("you discount: 0% " + " Total Pay: " + totalPriсe);
                        
                        break;
                    }
            }
               
               int count = 5;

             while (true)
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 100);
                Console.WriteLine(" ");
                Console.WriteLine("Guess and enter number, from 0 to 100");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < value)
                {
                    count--;
                    Console.WriteLine("Wrong!!! you have: " + count + " assmits.");
                }
                if (num > value)
                {
                    count--;
                    Console.WriteLine("Wrong!!! you have: " + count + " assmits.");
                }

                if (num == value)
                {
                    Console.WriteLine("Bingo!!!");
                    break;
                }

                if (count==0)
                {
                    
                    Console.WriteLine("Goodbye");
                    break;

                }



            }






















































































        }
    }
} 