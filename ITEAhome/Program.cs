using System;

namespace ITEAhome
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Helo! Enter you total price:");

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
                case float n when (n < 300):
                    {
                        Console.WriteLine("you discount 0%" + " Total pay: " + n);

                        break;
                    }

            }





            float count = 5;

            Random rnd = new Random();
            int value = rnd.Next(0, 1000000);
            Console.WriteLine(" ");
            Console.WriteLine("Guess and enter number, from 0 to 100");

            while (true)
            {

                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num < value)
                        {
                            count--;
                            Console.WriteLine("Wrong!!! My number is Bigger! You have: " + count + " assmits.");
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

                        if (count == 0)
                        {

                            Console.WriteLine("YOU LUSSE!!! Goodbye");
                            break;

                        }
            }
            */
            /* Random rnd2 = new Random();
             int value2 = rnd2.Next(0, 1000000);
             Console.WriteLine(" ");
             Console.WriteLine("");
             int num = Convert.ToInt32(Console.ReadLine());
             for (int i=0;i<1000000;i++)
               {                
                 if (value2 % 3 == 3)
                 {
                     value2 += 1;              

                 }


             }

             Console.WriteLine( i+ " " + value2);
         }*/



            Console.WriteLine("Преатствую! Введите ваше Ф.И.О. через пробел:"); //ПреБедствие и Ф.А.Кю.

            string inputName = Console.ReadLine(); // Именины                               
            int firstIndex = inputName.IndexOf(" "); // первое индексное значение поиска имени
            int secondIndex = inputName.LastIndexOf(" "); //второе индексное значение  для поиска отчества
            string firstWord = inputName.ToUpper().Substring(0, 1); // для корректного отображения заглавной буквы фамилии по условию
            string firstName = inputName.ToLower().Substring(1, firstIndex); // для корректного отображения остальной части фамилии по условию 
            string secondName = inputName.ToUpper().Substring(firstIndex, 2) + ".";// корректное отображение данных в имени согласно условию
            string thirdName = inputName.ToUpper().Substring(secondIndex, 2) + ".";// корректное отображение данных в фамилии согласно условию
            Console.WriteLine();
            Console.WriteLine(" " + firstWord + firstName + secondName + thirdName); //вывод решения 
























































































        }
    }
}
