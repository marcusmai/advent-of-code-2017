using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode03
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int[,] matrix = new int[10000, 10000];
            int x = (10000 / 2);
            int y = (10000 / 2);
            int count = 1;
            int noCellWrites = 1;
            Boolean loopStop = false;

            matrix[x,y] = 1;
            count++;

            while (loopStop == false)
            {
                //Right
                for (int i = 0; i < noCellWrites; i++)
                {
                    x++;
                    count = matrix[x, y - 1] + matrix[x - 1, y - 1] + matrix[x - 1, y] + matrix[x - 1, y + 1] + matrix[x, y + 1] + matrix[x + 1, y + 1] + matrix[x + 1, y] + matrix[x + 1, y - 1];
                    matrix[x, y] = count;

                    if (count > 325489)
                    {
                        Console.WriteLine("Value: {0}", matrix[x, y]);
                        Console.WriteLine("X,Y: {0}, {1}", x, y);
                        Console.WriteLine(".......................");

                        loopStop = true;
                    }

                    count++;
                }
                //Down
                for (int i = 0; i < noCellWrites; i++)
                {
                    y++;
                    count = matrix[x, y - 1] + matrix[x - 1, y - 1] + matrix[x - 1, y] + matrix[x - 1, y + 1] + matrix[x, y + 1] + matrix[x + 1, y + 1] + matrix[x + 1, y] + matrix[x + 1, y - 1];
                    matrix[x, y] = count;

                    if (count > 325489)
                    {
                        Console.WriteLine("Value: {0}", matrix[x, y]);
                        Console.WriteLine("X,Y: {0}, {1}", x, y);
                        Console.WriteLine(".......................");

                        loopStop = true;
                    }

                    count++;
                }

                noCellWrites++;
                
                //Left
                for (int i = 0; i < noCellWrites; i++)
                {
                    x--;
                    count = matrix[x, y - 1] + matrix[x - 1, y - 1] + matrix[x - 1, y] + matrix[x - 1, y + 1] + matrix[x, y + 1] + matrix[x + 1, y + 1] + matrix[x + 1, y] + matrix[x + 1, y - 1];
                    matrix[x, y] = count;

                    if (count > 325489)
                    {
                        Console.WriteLine("Value: {0}", matrix[x, y]);
                        Console.WriteLine("X,Y: {0}, {1}", x, y);
                        Console.WriteLine(".......................");

                        loopStop = true;
                    }

                    count++;
                }
                //Up
                for (int i = 0; i < noCellWrites; i++)
                {
                    y--;
                    count = matrix[x, y - 1] + matrix[x - 1, y - 1] + matrix[x - 1, y] + matrix[x - 1, y + 1] + matrix[x, y + 1] + matrix[x + 1, y + 1] + matrix[x + 1, y] + matrix[x + 1, y - 1];
                    matrix[x, y] = count;

                    if (count > 325489)
                    {
                        Console.WriteLine("Value: {0}", matrix[x, y]);
                        Console.WriteLine("X,Y: {0}, {1}", x, y);
                        Console.WriteLine(".......................");

                        loopStop = true;
                    }

                    count++;
                }

                noCellWrites++;
            }

            Console.ReadKey();
        }
    }
}
