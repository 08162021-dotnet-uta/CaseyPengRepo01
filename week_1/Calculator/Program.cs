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

           print();
         
        }

        static void Add()
        {
          //input stuff
          //casting taking the whole thing and covert it to a new type 
//run does't have a type untill run time,complie time, there is no type for va, keyword "var" may only appear....
      
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
       static void Print(params int[] results){
        Console.ReadLine(result1,result2)
        
    }
}
