// Property of: James Crispe
// Created on: Feb 28, 2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_do_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.Write(i * j + "\t");
                    j++;
                } while (j <= 10);
                Console.Write("\n");
                i++;
            } while (i <= 10);


        }
    }
}
