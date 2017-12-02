using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText(@"C:\AdventOfCode2017\input_01.txt");
            int sum = 0;
            int nextChar = (input.Length / 2) -1;

            for (int i = 0; i <= (input.Length - 1); i++)
            {
                int currentChar = i;
                nextChar = nextChar + 1;

                if (i != input.Length)
                {
                    if (input[currentChar] == input[nextChar])
                    {
                        sum = sum + (int)Char.GetNumericValue(input[currentChar]);
                    }
                    if (nextChar == input.Length-1)
                    {
                        nextChar = -1;
                    }
                }
            }

            Console.WriteLine("Resultat: {0}", sum);
            Console.ReadKey();
        }
    }
}
