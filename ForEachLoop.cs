using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_Each_Loop
{
    class ForEachLoop
    {
        static void Main(string[] args)
        {
            // I created a string array name Names that has 4 elements
           string[] Names = {"John","Jack","Sam","Tammy"};

            // Foreach loop which prints the names of the elements in the string Array
           foreach (string Person in Names)
         {
              Console.WriteLine("Nice to meet you\n{0}", Person);
           }
        }
    }
}
