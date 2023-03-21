using System;
using System.Collections;

namespace ArrayEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ary = new int[3, 4];
            int value = 1;

            Console.WriteLine(ary.Length);
            for (int i = 0; i < ary.Length; i++)  // ctrl + shift + /
            {
                for (int k = 0; k < ary.Length; k++) 
                {
                    ary[i, k] = value;
                    ++value;
                }

            }

        }
    }
}