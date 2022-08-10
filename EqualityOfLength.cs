using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionUsingNonStatic
{
    public class EqualityOfLength
    {
        public void CheckEqualityOfLength(int a1, int b1, int a2, int b2)
        {
            int len1, len2;
            if (a1 == a2)
            {
                Console.WriteLine(b1.Equals(b2));
            }
            else
            {
                len1 = b1 - a1;
                len2 = b2 - a2;
                Console.WriteLine(len1.Equals(len2));
              
            }
        }
    }
}
