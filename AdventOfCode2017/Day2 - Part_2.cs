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
            string line;
            System.IO.StreamReader input = new System.IO.StreamReader(@"C:\AdventOfCode2017\input_02.txt");
            int sum = 0;
            int delsum = 0;

            while ((line = input.ReadLine()) != null)
            {
                String[] lineVal = line.Split('\t');

                for (int i = 0; i < lineVal.Length; i++)
                {
                    int value1 = Int32.Parse(lineVal[i]);
                    
                    for (int y = (i+1); y < lineVal.Length ; y++)
                    {
                        int value2 = Int32.Parse(lineVal[y]);
                        float divVal = (float)value1 / (float)value2;
                        if ((divVal % 1) == 0)
                        {
                            delsum = (int)divVal;
                        }
                    }
                   for (int x = 0; x < i; x++)
                    {
                        int value2 = Int32.Parse(lineVal[x]);
                        float divVal = (float)value1 / (float)value2;
                        if ((divVal % 1) == 0)
                        {
                            delsum = (int)divVal;
                        }
                    }
                }
                sum = sum + delsum;
            }

            Console.WriteLine("Resultat: {0}", sum);
            Console.ReadKey();
            
        }
    }
}
