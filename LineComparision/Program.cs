using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Welcome To Line Comparision======");
            Line line = new Line();
            line.Line1(10, 20, 30, 40);
            line.Line2(20, 30, 40, 60);
            Console.WriteLine("\nChecking whether length is same or not....");
            line.EqualCheck();
            Console.WriteLine("\nChecking whether length is equal,less or greater....");
            line.Comparison();
            Console.ReadKey();
        }
    }
}
