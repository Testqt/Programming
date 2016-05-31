using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace function_array_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]ar = new int[10];
            Random ran = new Random();
            
            for (int i = 0; i <ar.Length; i++)
            {
                ar[i] = ran.Next(-100,100);
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine(" ");

            int rez = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                rez = kvadrat(ar[i]);
                Console.WriteLine(ar[i]);
            }
            Console.ReadLine();

        }

        public static int kvadrat(int kv)
        {           
            int rez = kv*kv;
            return rez;
        }
    }
}
