using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      var input1 = int.Parse(Console.ReadLine());
      var input2 = int.Parse(Console.ReadLine());

      int result1 = Add(input1, input2);
      int result2 = Sbutract(input1, input2);
      int result3 = Division(input1, input2);
      int result4 = Multiply(input1, input2);

      Print(result1, result2, result3, result4);

    }

    static int Add(int input1, int input2)
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
    static int Multiply(int input1, int input2)
    {
      return (int)input1 * (int)input2;
    }
    static int Division(int input1, int input2)
    {
      var output = 0;
      try
      {
        output = (int)input1 / (int)input2;
      }
      catch (DivideByZeroException ex)
      {
        // TODO
        Console.WriteLine($"Denominator cannot be 0: '{ex}'");
      }
      return output;
    }


    static void Print(params int[] results)
    {
      for (int i = 0; i < results.Length; i++)
      {
        Console.WriteLine(results[i]);
      }

    }
  }
}