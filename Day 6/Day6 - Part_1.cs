using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCode.Day6
{
    class Day6
    {
        static void Main(string[] args)
        {
            List<string> memoryStates = new List<string>();
            string memoryString = "";
            int cycles = 0;
            string[] input = File.ReadAllText("Day6\\input.txt").Split('\t').ToArray();
            int[] memory = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
                memory[i] = Int32.Parse(input[i]);

            for (int i = 0; i < memory.Length; i++) {memoryString = memoryString + memory[i].ToString();}
            memoryStates.Add(memoryString);
            memoryString = "";

            while (true)
            {
                int startIndex = memory.ToList().IndexOf(memory.Max());
                int blocks = memory[startIndex];
                memory[startIndex] = 0;

                for (int i = 0; i < blocks; i++)
                {
                    if (startIndex >= memory.Length - 1)
                        startIndex = -1;

                    memory[startIndex + 1] += 1;
                    startIndex++;
                }

                for (int i = 0; i < memory.Length; i++) { memoryString = memoryString + memory[i].ToString(); }
                
                cycles++;

                if (memoryStates.Contains(memoryString))
                {
                    break;
                }

                memoryStates.Add(memoryString);
                memoryString = "";

            }

            Console.WriteLine("Result: {0}", cycles);
            Console.ReadKey();
        }
    }
}
