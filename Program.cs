using System;

namespace Pascals_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //version1(7);
            //version2(7);
            version2advanced(7);
        }

        static void version1(int size)
        {
            int  val = 0;

            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = i * (i - 1) /2;

                    Console.Write(val + " ");
                }
                
                Console.WriteLine();
            }
        }
        static void version2(int Size)
        {
            int val = 0;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                        val = 1;
                    else
                        val = (val * (i - j + 1)) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }
        }
        static void version2advanced(int Size) {
            int val;

            for (int i = 0; i < Size; i++)
            {
                for (int blank = 1; blank <= Size - i; blank++)
                    Console.Write(" ");
                val = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val = val * (i - j) / (j + 1);

                }
                Console.WriteLine();
            }
        }
            
    }

    
}

// row = i
// j = collumn

// pre val * (row - collumn + 1) / collumn


// last val: 3  i:3   j:3

// 3 * 3 / 3

