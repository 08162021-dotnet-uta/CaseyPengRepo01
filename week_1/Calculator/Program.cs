using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          var input1 = int.Parse(Console.ReadLine());
          var input2 = int.Parse(Console.ReadLine());

          int result1 = Add(input1,input2);
          int result2 = Sbutract(input1,input2);

           Print(result1,result2);
         
        }

        static int Add(int input1,int input2)
        {
          //input stuff
          //casting taking the whole thing and covert it to a new type 
//run does't have a type untill run time,complie time, there is no type for va, keyword "var" may only appear....
      
          //comput stuff

          return (int)input1 + (int)input2;
          
          
        }
        static int Sbutract(int input1, int input2)
        {
          //input stuff
          //casting taking the whole thing and covert it to a new type 

      
          //comput stuff

          return (int)input1 - (int)input2;
          //output
        
        }
       static void Print(params int[] results){
       for (int i = 0;i <results.Length;i++)
       {
         Console.WriteLine(results[i]);
       }
        
    }
}
}