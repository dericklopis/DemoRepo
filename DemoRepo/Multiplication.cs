using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepo
{
    internal class Multiplication
    {
         
              //access-modifier return-type methodName
        public static void Multiplying3Numbers(int firstNumb, int sendNumb, int thirdNumb)
        {
            int result = firstNumb*sendNumb*thirdNumb;
            Console.WriteLine("multiplication of numbers:"+ result);
        }
    }
}
