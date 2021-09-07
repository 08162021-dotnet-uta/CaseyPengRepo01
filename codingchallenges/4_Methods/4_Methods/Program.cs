using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1
            string name = GetName();
            GreetFriend(name);

            //2
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");
        }

        public static string GetName()
        {
            Console.WriteLine("enter a name");
            string result = Console.ReadLine();
            return result;
        }

        public static string GreetFriend(string name)
        {
           return "hello, " + name;
        }

        public static double GetNumber()
        {
            Console.WriteLine("enter a number");
            string input = Console.ReadLine();
            //convert string to double num, return a bool 
            bool success  = double.TryParse(Console.ReadLine(),out double number);
            
  

        }

        public static int GetAction()
        {
string input;
            do{
                 Console.WriteLine("enter operaction + ,-,*,/");
        string input = Console.ReadLine();

            }While(input != "+" || input!="-" || input!="*" || input != "/");
return input

        }

        public static double DoAction(double x, double y, int action)
        {
            throw new NotImplementedException("DoAction() is not implemented yet");
        }
    }
}
