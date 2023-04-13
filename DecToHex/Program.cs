using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> bits = new Stack<string>();
            int bitGroup = 2;
            int dispCount = 0;

            int numToConvert = 0;
            int remainder = 0;
            Random rnd = new Random();

            numToConvert = rnd.Next(1000);

            Console.Write(numToConvert + " in hexadecimal is ");

            while (numToConvert > 0)
            {
                remainder = numToConvert % 16;


                #region Switch-Case
                //switch (remainder)
                //{
                //    case 0:
                //    case 1:
                //    case 2:
                //    case 3:
                //    case 4:
                //    case 5:
                //    case 6:
                //    case 7:
                //    case 8:
                //    case 9:
                //        bits.Push(remainder + "");
                //        break;
                //    case 10:
                //        bits.Push("A");
                //        break;
                //    case 11:
                //        bits.Push("B");
                //        break;
                //    case 12:
                //        bits.Push("C");
                //        break;
                //    case 13:
                //        bits.Push("D");
                //        break;
                //    case 14:
                //        bits.Push("E");
                //        break;
                //    case 15:
                //        bits.Push("F");
                //        break;
                //} 
                #endregion

                #region if-Else
                if(remainder >= 0 && remainder <= 9)
                    bits.Push(remainder + "");
                else if(remainder == 10)
                    bits.Push("A");
                else if (remainder == 11)
                    bits.Push("B");
                else if (remainder == 12)
                    bits.Push("C");
                else if (remainder == 13)
                    bits.Push("D");
                else if (remainder == 14)
                    bits.Push("E");
                else if (remainder == 15) 
                    bits.Push("F");
                #endregion

                numToConvert = numToConvert - remainder;
                numToConvert = numToConvert / 16;
            }

            while (bits.Count % bitGroup != 0)
                bits.Push("0");

            while (bits.Count() > 0)
            {
                Console.Write(bits.Pop());
                dispCount++;

                if (dispCount == bitGroup)
                {
                    Console.Write(":");
                    dispCount = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
