using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{ 
    public class DrawDiamond
    {
        public static string MakeSpaces(int num)
        {
            return " ";
        }
        public static int CalcPadding(char DLetter, char RLetter)
        {
            return 0;
        }


        public static string OneLine(char DLetter, char RLetter)
        {
            return "";

            int Size, i, j, Space;

            Console.WriteLine("Enter the size: ");
            Size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Space = Size - 1;

            for (i = 1; i <= Size; i++)
            {
                for (j = 1; j <= Space; j++)
                    Console.Write(" ");
                Space--;

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Space = 1;

            for (i = 1; i <= Size - 1; i++)
            {
                for (j = 1; j <= Space; j++)
                    Console.Write(" ");

                Space++;

                for (j = 1; j <= 2 * (Size - i) - 1; j++)
                    Console.Write("*");

                 Console.WriteLine();
            }
            
        }
    }
}
