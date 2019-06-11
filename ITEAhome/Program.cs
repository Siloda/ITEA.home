using System;

namespace ITEAhome
{
    class Circle
    {
        private string circleColor = "Red";
        private string circleName = "CirclePit";
        private double circlePerim;
        private double circleArea;
        private double circleRadius;


        public void getCircleRadius()
        {
            Console.WriteLine("You have chosen a circle! ");
            Console.WriteLine();
            Console.WriteLine("Enter radius: ");

            circleRadius = Convert.ToDouble(Console.ReadLine());
        }

        public void getCirclePerim()
        {
            circlePerim = 2 * Math.PI * circleRadius;

        }
        public void getCircleArea()
        {
            circleArea = Math.PI * (circleRadius * circleRadius);

        }
        public void getCircleInfo()
        {
            Console.WriteLine("Circle Color: " + circleColor + "\n" + "Circle Name: " + circleName + "\n" + "Circle Area: " + circleArea + "\n" + "Circle Perim: " + circlePerim + "\n" + "Goodbye!");
        }
    }
    class Square
    {
        private string squareColor = "Black";
        private string squareName = "Kazimir";
        private double squarePerim;
        private double squareArea;
        private double squareSide;


        public void getSquareSide()
        {
            Console.WriteLine("You have chosen a square! ");
            Console.WriteLine();
            Console.WriteLine("Enter side length: ");
            squareSide = Convert.ToDouble(Console.ReadLine());
        }

        public void getSquarePerim()
        {
            squarePerim = squareSide * 4;

        }
        public void getSquareArea()
        {
            squareArea = squareSide * squareSide;

        }
        public void getSquareInfo()
        {
            Console.WriteLine("Square Color: " + squareColor + "\n" + "Square Name: " + squareName + "\n" + "Square Area: " + squareArea + "\n" + "Square Perim: " + squarePerim + "\n" + "Goodbye!");
        }
    }
    class Triangle

    {
        private string triangleColor = "Blue";
        private string triangleName = "Bermud";
        private double trianglePerim;
        private double triangleArea;
        private double triangleSide1;
        private double triangleSide2;
        private double triangleSide3;


        public void getTriangleSide()
        {
            Console.WriteLine("You have chosen a triangle! ");
            Console.WriteLine();
            Console.WriteLine("Enter length side A : ");
            triangleSide1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length side B : ");
            triangleSide2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length side C : ");
            triangleSide3 = Convert.ToDouble(Console.ReadLine());
        }

        public void getTrianglePerim()

        {

            trianglePerim = triangleSide1 + triangleSide2 + triangleSide3;

        }
        public void getTriangleArea()
        {
            double p = 0.5 * (triangleSide1 + triangleSide2 + triangleSide3);

            triangleArea = Math.Sqrt(p * (p - triangleSide1) * (p - triangleSide2) * (p - triangleSide3));


        }
        public void getTriangleInfo()
        {
            Console.WriteLine("Triangle Color: " + triangleColor + "\n" + "Triangle Name: " + triangleName + "\n" + "Triangle Area: " + triangleArea + "\n" + "Triangle Perim: " + trianglePerim + "\n" + "Goodbye!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello guest!\n" + "You can choose three items or exit: \n" + " 1 - circle\n " + "2 - square\n " + "3 - tringle\n " + "0 - exit\n");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":

                    Circle circle = new Circle();
                    circle.getCircleRadius();
                    circle.getCirclePerim();
                    circle.getCircleArea();
                    circle.getCircleInfo();
                    break;
                case "2":

                    Square square = new Square();
                    square.getSquareSide();
                    square.getSquarePerim();
                    square.getSquareArea();
                    square.getSquareInfo();
                    break;
                case "3":

                    Triangle triangle = new Triangle();
                    triangle.getTriangleSide();
                    triangle.getTrianglePerim();
                    triangle.getTriangleArea();
                    triangle.getTriangleInfo();
                    break;
                case "0":

                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("You clicked an unknown letter");
                    break;
            }



        }
    }
}
   /* class Program
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
         }



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

            */
                                                                              



 