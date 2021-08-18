using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          var input1 = int.Parse(Console.ReadLine());
          var input2 = int.Parse(Console.ReadLine());

          var result1 = Add(input1,input2);
          var result2 = Sbutract(input1,input2);

            Console.WriteLine(result1,result2);
         
        }

        static void Add()
        {
          //input stuff
          //casting taking the whole thing and covert it to a new type 

      
          //comput stuff

          var compute = (int)input1 + (int)input2;
          
          
        }
        static void Sbutract()
        {
          //input stuff
          //casting taking the whole thing and covert it to a new type 

      
          //comput stuff

          var compute = (int)input1 - (int)input2;
          //output
        
        }
        
        
    }
}
