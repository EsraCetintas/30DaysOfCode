using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int j = Convert.ToInt32(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            string m = Console.ReadLine();

            Console.WriteLine(i + j);
            Console.WriteLine(String.Format("{0:0.0}", d + f));
            Console.WriteLine(s + "" + m);

        }
    }
}
