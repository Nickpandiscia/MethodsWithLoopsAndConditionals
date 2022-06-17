using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int num = 0;
            do
            {
                numbers.Add(num++);
            } while (num < 1000);

            while (num > -1000)
            {
                num--;
                numbers.Add(num);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Threes();
            IsEqual(3, 3);

            Console.WriteLine("Give me a number between 0 and 10 and i'll let you know if they are even or odd!");
            int response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 2:
                    Console.WriteLine("That one is even!");
                    break;
                case 5:
                    Console.WriteLine("It's an odd one.");
                    break;
                case 10:
                    Console.WriteLine("For sure even.");
                    break;
                case 1:
                    Console.WriteLine("One is odd.");
                    break;
                case 3:
                    Console.WriteLine("Three is odd!");
                    break;
                case 4:
                    Console.WriteLine("I think four is even. Could be worng!");
                    break;
                case 6:
                    Console.WriteLine("Six is even.");
                    break;
                case 7:
                    Console.WriteLine("Seven? For sure odd!");
                    break;
                case 8:
                    Console.WriteLine("I mean, it has to be even.");
                    break;
                case 9:
                    Console.WriteLine("Nine is odd!");
                    break;
                case 0:
                    Console.WriteLine("Zero is even?");
                    break;
                default:
                    Console.WriteLine("Definitely not either one!");
                    break;
            }

            Console.WriteLine("Give me a nubmer between -3 and 3 and i'll let you know if it is positive of negative!");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case -1:
                    Console.WriteLine("Negative!");
                    break;
                case -2:
                    Console.WriteLine("Maaybee negative. No, definitely negative.");
                    break;
                case -3:
                    Console.WriteLine("Negative.");
                    break;
                case 0:
                    Console.WriteLine("Neither?");
                    break;
                case 1:
                    Console.WriteLine("Positive!");
                    break;
                case 2:
                    Console.WriteLine("Yes. Positive!");
                    break;
                case 3:
                    Console.WriteLine("Annnddd, it's positive!");
                    break;
                default:
                    Console.WriteLine("Wrong number!");
                    break;

                    
            }

            Console.WriteLine("Welcome to our website! Please enter your age to see if you are able to vote.");
            var userAge = int.Parse(Console.ReadLine());
            if (userAge < 21)
            {
                Console.WriteLine("Sorry, you're too young!");
            }
            else
            {
                Console.WriteLine("Welcome. Please vote.");
            }
        }
        public static void Threes()
        {
            for (int o = 3; o <= 999; o += 3)
            {
                Console.WriteLine(o);
            }
        } 
        public static void IsEqual(int number1, int number2)
        {           
            if(number1 == number2)
            {
                Console.WriteLine("These two numbers are True.");
            }
            else
            {
                Console.WriteLine("These two numbers are False.");
            }          
        }              
    }
}