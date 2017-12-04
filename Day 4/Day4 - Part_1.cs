using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode04
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            Boolean passphraseOK = true;
            int noPassphraseOK = 0;

            System.IO.StreamReader input = new System.IO.StreamReader(@"C:\AdventOfCode2017\input_04.txt");

            while ((line = input.ReadLine()) != null)
            {
                String[] lineWords = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                passphraseOK = true;

                for (int i = 0; i < lineWords.Length; i++)
                {
                    if (i == lineWords.Length - 1)
                    {
                        //Skip last word
                    }
                    else
                    {
                        for (int y = 1; y < (lineWords.Length - i); y++)
                        {
                            if (lineWords[i] == lineWords[y+i])
                            {
                                passphraseOK = false;
                            }
                        }
                    }
                }

                if (passphraseOK == true)
                {
                    noPassphraseOK++;
                }
            }

            Console.WriteLine("Valid passphrases: {0}", noPassphraseOK);
            Console.ReadKey();
        }
    }
}
