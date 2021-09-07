using System;

namespace _6_FlowControl
{
    public class Program
    {

        public static string username{get;set;}
        public static string password{get;set;}
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive 
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        /// 
        /// 
        public static int GetValidTemperature()
        {
            int input;
        
            do{
                
                Console.WriteLine("enter a temperature between -40 and 135  ");
                string userInput = Console.ReadLine();
                if(!int.TryParse(userInput,out input) ) {
                    Console.WriteLine("Please enter the correct temp");
                } 
            }while(input >135|| input<-40 );
            return input;
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            // if(temp<-20){
            //         Console.WriteLine("hella cold");
            // }else if (temp >=-20 && temp <0){
            //        Console.WriteLine("pretty cold");
            // }else if(temp >=0 && temp <20){
            //       Console.WriteLine("cold");
            // }else if(temp>=20 & temp<40 ){
            //     Console.Write("thawed out");
            // }else if(temp >=40 && temp <60){
            //      Console.Write("feels like Autumn");
            // }else if (temp >=60 && temp <80){
            //            Console.WriteLine("perfect outdoor workout temperatur");
            // }else if()
            // switch( temp)
            // {
            //     case int x when (x <-20):
            //     Console.WriteLine("hella cold");
            //     break;
            //     case int x when (x >=-20 && x <0):
            //      Console.WriteLine("pretty cold");
            //     break;
            //         case int x when (x >=0 && x <20):
            //      Console.WriteLine("cold");
            //     break;
            //       case int x when (x >=20 && x <40):
            //     Console.WriteLine("thawed out");
            //     break;
            //     case int x when (x >=40 && x <60):
            //      Console.WriteLine("feels like Autumn");
            //     break;
            //       case int x when (x >=60 && x <80):
            //      Console.WriteLine("perfect outdoor workout temperatur");
            //     break;
            //       case int x when (x >=80 && x <90):
            //     Console.WriteLine("niiice");
            //     break;
            //         case int x when  (x >=90 && x <100):
            //     Console.WriteLine("hella hot");
            //     break;
            //     case int x when (x >=100 && x <135):
            //      Console.WriteLine("hottest");
            //     break;
            // }
             switch(temp)
            {
                case <-20:
                Console.WriteLine("hella cold");
                break;
                case <0:
                 Console.WriteLine("pretty cold");
                break;
                    case <20:
                 Console.WriteLine("cold");
                break;
                  case  <40:
                Console.WriteLine("thawed out");
                break;
                case  <60:
                 Console.WriteLine("feels like Autumn");
                break;
                  case  <80:
                 Console.WriteLine("perfect outdoor workout temperature");
                break;
                  case  <90:
                Console.WriteLine("niiice");
                break;
                    case <100:
                Console.WriteLine("hella hot");
                break;
                case  <135:
                 Console.WriteLine("hottest");
                break;
            }
        }

        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {
            Console.WriteLine("enter a username: ");
         username = Console.ReadLine();
         Console.WriteLine("username saved");
         Console.WriteLine("Enter a password");
         password= Console.ReadLine();
           Console.WriteLine("password saved");
        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login()
        {
           string inputPassword, inputUsername;
           Console.WriteLine("Please enter your username and password to login ");
           do
           {
            Console.WriteLine("Please enter your username  ");   
            inputUsername= Console.ReadLine();
                Console.WriteLine("Please enter your password  ");   
                inputPassword = Console.ReadLine();
           } while (!Equals(inputUsername,username)|| !Equals(inputPassword, password));
           return true;

        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
        
            string output = temp <= 42 ? $"{temp} is too cold!" : temp >= 43 && temp <= 78 ? $"{temp} is an ok temperature" : temp > 78 ? $"{temp} is too hot!" : "This is the default catch-all";
            Console.WriteLine(output);
        }


    }//EoP
}//EoN
