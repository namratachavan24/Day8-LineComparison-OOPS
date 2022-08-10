using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingNonStatic
{
    public class CompareTwoLines
    {
        public void CheckTwoLines(int l1, int m1, int l2, int m2)
        {
            int le1, le2;
            if (l1 == l2)
            {
                int comp = m1.CompareTo(m2);
                if (comp == 0)
                {
                    Console.WriteLine("Both line are equals");
                }
                else if (comp >= 0)
                {
                    Console.WriteLine("Second line is Smaller than first");
                }
                else
                {
                    Console.WriteLine("Second line is bigger than First");
                }
            }
            else
            {
                le1 = m1 - l1;
                le2 = m2 - l2;
                int comp = le1.CompareTo(le2);
                if (comp == 0)
                {
                    Console.WriteLine("Both line are equals");
                }
                else if (comp >= 0)
                {
                    Console.WriteLine("Second line is Smaller than first");
                }
                else
                {
                    Console.WriteLine("Second line is bigger than First");
                }
            }
        }
    }
}
