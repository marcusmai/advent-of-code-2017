using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string line;
            System.IO.StreamReader input = new System.IO.StreamReader(@"C:\AdventOfCode2017\input_02.txt");
            int sum = 0;

            while ((line = input.ReadLine()) != null)
            {
                int highVal = 0;
                int lowVal = 9999;
                String[] lineVal = line.Split('\t');

                for (int i = 0; i < lineVal.Length; i++)
                {
                    int value = Int32.Parse(lineVal[i]);

                    if (value > highVal)
                    {
                        highVal = value;
                    }
                    if (value < lowVal)
                    {
                        lowVal = value;
                    }
                }
                sum = sum + (highVal - lowVal);
            }

            Console.WriteLine("Resultat: {0}", sum);
            Console.ReadKey();
        }
    }
}
