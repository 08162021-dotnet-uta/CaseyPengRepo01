using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
          int numOfOdd=0;
          foreach(int ele in x){
              if(ele % 2 == 1){
                  numOfOdd++;
              }
          }
          return numOfOdd;
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
          int numOfEven=0;
          //object can be anything
          foreach(object y in x){
                Console.WriteLine(y);
          }
          return numOfEven;
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {
            int numMulof4=0;
            int i=-1;
            do
            { i++;
                if(x[i]%4 ==0){
                    numMulof4++;
                }
            } while (x[i]!=1234);
         return numMulof4;
        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
          int count =0;
          for(int i =0;i<x.Length;i++){
              if(x[i]%3==0 && x[i]%4==0){
                  count++;
              }
          }
          return count;
        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            string result="";
            string temp="";
            //array of list<string>. each ele in array is a list 
        for(int i =0;i<stringListArray.Length;i++){

            //each ele would be a str
            foreach(string ele in stringListArray[i]){
                temp = ele + " ";
                result+=temp;
            }
        }
            return result;
        }
    }
}