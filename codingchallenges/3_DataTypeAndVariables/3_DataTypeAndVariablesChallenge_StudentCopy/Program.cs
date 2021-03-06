using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //
            // Insert code here.
            //
            //
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
          switch(obj)
          {
              case bool abool :
              return "Data type => bool";
              case byte aByte:
              return "Data type => byte";
              case sbyte aByte:
              return "Data type => sbyte";
              case string aString:
              return "Data type => a string";
            case char aChar:
              return "Data type => char";
              case decimal aDecimal:
              return "Data type => decimal";
              case double aDouble:
              return "Data type => double";
                  case float aFloat :
              return "Data type => float";
              case int aInt:
              return "Data type => int";
              case uint aUint:
              return "Data type => uint";
            // case nint aNint :
            //   return "Data type => nint";
            //   case nuint aNuint:
            //   return "Data type => nuint";
              case long aLong:
              return "Data type => long";
               case ulong aUlong :
              return "Data type => ulong";
              case short aShort:
              return "Data type => short";
              case ushort aUshort:
              return "Data type => ushort";
                 default:
                    return "This is the default in the switch statement";
              
            

          }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            throw new NotImplementedException($"StringToInt() has not been implemented");

        }
    }// end of class
}// End of Namespace
