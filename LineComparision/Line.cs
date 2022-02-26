using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Line
    {
        //Initializing Variables
        public int x1,x2,y1,y2;
        public int r1,r2,s1,s2;
        public double length1;
        public double length2;

        //Creating method to calculate length of line1
        public  void Line1(int x1,int x2,int y1,int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;

             this.length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
             Console.WriteLine("The length of Line1 is = " + length1);
             
        }

        //Creating method to calculate length of line2
        public void Line2(int r1, int r2, int s1, int s2)
        {
            this.r1 = r1;
            this.r2 = r2;
            this.s1 = s1;
            this.s2 = s2;

            this.length2 = Math.Sqrt(Math.Pow((r2 - r1), 2) + Math.Pow((s2 - s1), 2));
            Console.WriteLine("The length of Line2 is = " + length2);
        }

        //Creating method for equal check 
        public void EqualCheck()
        {
            if (this.length1.Equals(length2))
            {
                Console.WriteLine("The Length of two lines are same");
            }
            else
            {
                Console.WriteLine("The length of two lines are different");
            }
        }

        //Creating method for comparision
        public void Comparison()
        {
           if(this.length1.CompareTo(this.length2) == 0)
            {
                EqualCheck();
            }
           else if (this.length1.CompareTo(this.length2) > 0)
            {
                Console.WriteLine("length1 is greater than length2");
            }
           else
            {
                Console.WriteLine("length1 is smaller than length2");
            }

        }
    }
}
