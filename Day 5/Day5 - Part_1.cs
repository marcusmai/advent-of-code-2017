using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode05
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int nextLine = 0;
            
            System.IO.StreamReader input = new System.IO.StreamReader(@"C:\AdventOfCode2017\input_05.txt");
            int[] lines = new int[File.ReadLines(@"C:\AdventOfCode2017\input_05.txt").Count()];

            for (int i = 0; i < lines.Length; i++) lines[i] = Int32.Parse(input.ReadLine());

            while (true)
            {
                if (nextLine >= 0 && nextLine < lines.Length)
                {
                    int oldix = nextLine;
                    nextLine = nextLine + lines[oldix];
                    lines[oldix] = lines[oldix] + 1;
                    steps++;
                }
                else
                    break;
            }
            Console.WriteLine("Steps: {0}", steps);
            Console.ReadKey();
        }
    }
}
